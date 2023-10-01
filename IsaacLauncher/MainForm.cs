using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace IsaacLauncher
{

    public partial class MainForm : Form
    {

        private static string DataFolder = "data";

        // Taunt duration
        private static int TauntDelay = 4500;

        private static Image StartImage = Image.FromFile(Path.Combine(DataFolder, "start.png"));
        private static Image TauntCompleteImage = Image.FromFile(Path.Combine(DataFolder, "end.png"));
        private static Image Taunt = Image.FromFile(Path.Combine(DataFolder, "taunt.gif"));

        // Contains link to clicked button for interactionss
        private Button ClickedStartButton;

        // Full path to game binary, including .exe
        private string PathToGameBinary;
        // Path to game folder (PathToGameBinary excluding .exe)
        private string PathToGameFolder;
        // Only name of .exe
        private string GameBinaryName;

        // Path to options.ini
        private string PathToOptionsConfig;

        private OpenFileDialog BinarySelectDialog;

        public MainForm()
        {
            InitializeComponent();

            // Prevent resizing
            MaximizeBox = false;

            NormalStartButton.Image = StartImage;
            DailyRunStartButton.Image = StartImage;

            ClickedStartButton = null;

            BlockStart();

            // Init file dialog
            BinarySelectDialog = new OpenFileDialog();
            BinarySelectDialog.Filter = "Binary files(*.exe)|*.exe";
            BinarySelectDialog.Title = "Select The Binding of Isaac: Repentance .exe";

            PathToGameFolder = null;
            PathToGameBinary = null;

            #if DEBUG
                Debug.WriteLine($"Saved path to binary: {Properties.Settings.Default.PathToGameBinary}");
            #endif

            if (!String.IsNullOrEmpty(Properties.Settings.Default.PathToGameBinary))
            {
                PathToGameBinary = Properties.Settings.Default.PathToGameBinary;

                ExtractGameFolderAndBinaryName();
            }

            FindPathToOptionsFile();


        }

        private void FindPathToOptionsFile()
        {
            PathToOptionsConfig = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                Path.Combine("\\My Games", "Binding of Isaac Repentance", "options.ini");

            if (!File.Exists(PathToOptionsConfig))
            {
                MessageBox.Show("Can't find options.ini. Check your game data and try again.");

                Close();
                Application.Exit();
            }

            PathToOptions.Text = "Found! :)";
        }

        private void ExtractGameFolderAndBinaryName()
        {
            //Path elements
            string[] SplittedPath = PathToGameBinary.Split('\\');

            foreach (string PathElement in SplittedPath)
            {
                if (PathElement.EndsWith(".exe"))
                {
                    GameBinaryName = PathElement;
                    break;
                }

                PathToGameFolder = Path.Combine(PathToGameFolder + "\\", PathElement);

            }

            if (String.IsNullOrEmpty(GameBinaryName))
            {
                MessageBox.Show("Incorrect path to game binary. Path should be to .exe file");
                return;
            }

            GameBinaryPath.Text = "Selected! :)";

            AllowStart();
        }

        private void RunTaunt()
        {
            ClickedStartButton.Image = Taunt;

            Task EndTauntTask = Task.Delay(TauntDelay).ContinueWith(t => {

                EndTaunt();

                RunGame();

            });
        }

        private void EndTaunt()
        {
            ClickedStartButton.Image = TauntCompleteImage;
        }

        private void ChangeConfig(int DebugConsoleEnabled, int ModsEnabled)
        {
            //Create options.ini backup before rewrite
            File.Copy(PathToOptionsConfig, Path.Combine(DataFolder, "OptionsBackup.ini"), true);

            string[] ConfigLines = File.ReadAllLines(PathToOptionsConfig);

            for (int i = 0; i < ConfigLines.Length - 1; i++)
            {
                string ConfigLine = ConfigLines[i];

                if (ConfigLine.StartsWith("EnableDebugConsole"))
                {
                    ConfigLine = ConfigLine.Substring(0, ConfigLine.Length - 1) + DebugConsoleEnabled.ToString();
                    ConfigLines[i] = ConfigLine;
                }
                else if (ConfigLine.StartsWith("EnableMods"))
                {
                    ConfigLine = ConfigLine.Substring(0, ConfigLine.Length - 1) + ModsEnabled.ToString();
                    ConfigLines[i] = ConfigLine;
                }
            }

            File.WriteAllLines(PathToOptionsConfig, ConfigLines);
        }

        private void RunGame()
        {

            ProcessStartInfo Info = new ProcessStartInfo(GameBinaryName);
            Info.WorkingDirectory = PathToGameFolder + "\\";
            Info.UseShellExecute = true;

            #if DEBUG
                Debug.WriteLine($"{Info.WorkingDirectory}{Info.FileName}");
            #endif

            try
            {
                Process.Start(Info);

            } catch (Win32Exception) { } // User cancelled run so do nothing 

            Application.Exit();

        }

        private void BlockStart()
        {
            NormalStartButton.Enabled = false;
            DailyRunStartButton.Enabled = false;
        }

        private void AllowStart()
        {
            NormalStartButton.Enabled = true;
            DailyRunStartButton.Enabled = true;
        }

        private void NormalStartButtonClick(object sender, EventArgs e)
        {
            // Prevent clicks while taunt is playing
            if (ClickedStartButton != null)
            {
                return;
            }

            ClickedStartButton = NormalStartButton;
            DailyRunStartButton.Enabled = false;

            ChangeConfig(1, 1);

            RunTaunt();
        }

        private void DailyRunButtonStartClick(object sender, EventArgs e)
        {
            // Prevent clicks while taunt is playing
            if (ClickedStartButton != null)
            {
                return;
            }

            ClickedStartButton = DailyRunStartButton;
            NormalStartButton.Enabled = false;

            ChangeConfig(0, 0);

            RunTaunt();
        }

        private void SelectBinaryPathClick(object sender, EventArgs e)
        {
            if (BinarySelectDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            PathToGameBinary = BinarySelectDialog.FileName;
            #if DEBUG
                Debug.WriteLine($"Selected file from dialog: {PathToGameBinary}");
            #endif

            Properties.Settings.Default.PathToGameBinary = PathToGameBinary;
            Properties.Settings.Default.Save();

            ExtractGameFolderAndBinaryName();
        }
    }
}
