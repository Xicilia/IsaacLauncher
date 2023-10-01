
namespace IsaacLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NormalStartButton = new System.Windows.Forms.Button();
            this.DailyRunStartButton = new System.Windows.Forms.Button();
            this.NormalRunLabel = new System.Windows.Forms.Label();
            this.DailyRunStartLabel = new System.Windows.Forms.Label();
            this.BinPathLabel = new System.Windows.Forms.Label();
            this.PathToOptionsLabel = new System.Windows.Forms.Label();
            this.GameBinaryPath = new System.Windows.Forms.Label();
            this.PathToOptions = new System.Windows.Forms.Label();
            this.SelectBinaryPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NormalStartButton
            // 
            this.NormalStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.NormalStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalStartButton.Font = new System.Drawing.Font("Microsoft Tai Le", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalStartButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NormalStartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NormalStartButton.Location = new System.Drawing.Point(12, 31);
            this.NormalStartButton.Name = "NormalStartButton";
            this.NormalStartButton.Size = new System.Drawing.Size(492, 100);
            this.NormalStartButton.TabIndex = 0;
            this.NormalStartButton.Text = "Normal Start";
            this.NormalStartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NormalStartButton.UseVisualStyleBackColor = false;
            this.NormalStartButton.Click += new System.EventHandler(this.NormalStartButtonClick);
            // 
            // DailyRunStartButton
            // 
            this.DailyRunStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.DailyRunStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DailyRunStartButton.Font = new System.Drawing.Font("Microsoft Tai Le", 44.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyRunStartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DailyRunStartButton.Location = new System.Drawing.Point(12, 168);
            this.DailyRunStartButton.Name = "DailyRunStartButton";
            this.DailyRunStartButton.Size = new System.Drawing.Size(492, 100);
            this.DailyRunStartButton.TabIndex = 1;
            this.DailyRunStartButton.Text = "Daily Run Start";
            this.DailyRunStartButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DailyRunStartButton.UseVisualStyleBackColor = false;
            this.DailyRunStartButton.Click += new System.EventHandler(this.DailyRunButtonStartClick);
            // 
            // NormalRunLabel
            // 
            this.NormalRunLabel.AutoSize = true;
            this.NormalRunLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.NormalRunLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NormalRunLabel.Location = new System.Drawing.Point(12, 7);
            this.NormalRunLabel.Name = "NormalRunLabel";
            this.NormalRunLabel.Size = new System.Drawing.Size(271, 21);
            this.NormalRunLabel.TabIndex = 2;
            this.NormalRunLabel.Text = "Debug console and mods are enabled";
            // 
            // DailyRunStartLabel
            // 
            this.DailyRunStartLabel.AutoSize = true;
            this.DailyRunStartLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.DailyRunStartLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyRunStartLabel.Location = new System.Drawing.Point(12, 144);
            this.DailyRunStartLabel.Name = "DailyRunStartLabel";
            this.DailyRunStartLabel.Size = new System.Drawing.Size(274, 21);
            this.DailyRunStartLabel.TabIndex = 3;
            this.DailyRunStartLabel.Text = "Debug console and mods are disabled";
            // 
            // BinPathLabel
            // 
            this.BinPathLabel.AutoSize = true;
            this.BinPathLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.BinPathLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BinPathLabel.Location = new System.Drawing.Point(88, 284);
            this.BinPathLabel.Name = "BinPathLabel";
            this.BinPathLabel.Size = new System.Drawing.Size(101, 13);
            this.BinPathLabel.TabIndex = 4;
            this.BinPathLabel.Text = "Game binary path:";
            // 
            // PathToOptionsLabel
            // 
            this.PathToOptionsLabel.AutoSize = true;
            this.PathToOptionsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.PathToOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathToOptionsLabel.Location = new System.Drawing.Point(88, 309);
            this.PathToOptionsLabel.Name = "PathToOptionsLabel";
            this.PathToOptionsLabel.Size = new System.Drawing.Size(106, 13);
            this.PathToOptionsLabel.TabIndex = 5;
            this.PathToOptionsLabel.Text = "Path to options.ini:";
            // 
            // GameBinaryPath
            // 
            this.GameBinaryPath.AutoSize = true;
            this.GameBinaryPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.GameBinaryPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameBinaryPath.Location = new System.Drawing.Point(189, 284);
            this.GameBinaryPath.Name = "GameBinaryPath";
            this.GameBinaryPath.Size = new System.Drawing.Size(81, 13);
            this.GameBinaryPath.TabIndex = 6;
            this.GameBinaryPath.Text = "Not Selected :(";
            // 
            // PathToOptions
            // 
            this.PathToOptions.AutoSize = true;
            this.PathToOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(190)))), ((int)(((byte)(187)))));
            this.PathToOptions.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathToOptions.Location = new System.Drawing.Point(189, 309);
            this.PathToOptions.Name = "PathToOptions";
            this.PathToOptions.Size = new System.Drawing.Size(11, 13);
            this.PathToOptions.TabIndex = 7;
            this.PathToOptions.Text = "-";
            // 
            // SelectBinaryPath
            // 
            this.SelectBinaryPath.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelectBinaryPath.Location = new System.Drawing.Point(12, 279);
            this.SelectBinaryPath.Name = "SelectBinaryPath";
            this.SelectBinaryPath.Size = new System.Drawing.Size(75, 23);
            this.SelectBinaryPath.TabIndex = 8;
            this.SelectBinaryPath.Text = "Select";
            this.SelectBinaryPath.UseVisualStyleBackColor = false;
            this.SelectBinaryPath.Click += new System.EventHandler(this.SelectBinaryPathClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(512, 337);
            this.Controls.Add(this.SelectBinaryPath);
            this.Controls.Add(this.PathToOptions);
            this.Controls.Add(this.GameBinaryPath);
            this.Controls.Add(this.PathToOptionsLabel);
            this.Controls.Add(this.BinPathLabel);
            this.Controls.Add(this.DailyRunStartLabel);
            this.Controls.Add(this.NormalRunLabel);
            this.Controls.Add(this.DailyRunStartButton);
            this.Controls.Add(this.NormalStartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Isaac Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NormalStartButton;
        private System.Windows.Forms.Button DailyRunStartButton;
        private System.Windows.Forms.Label NormalRunLabel;
        private System.Windows.Forms.Label DailyRunStartLabel;
        private System.Windows.Forms.Label BinPathLabel;
        private System.Windows.Forms.Label PathToOptionsLabel;
        private System.Windows.Forms.Label GameBinaryPath;
        private System.Windows.Forms.Label PathToOptions;
        private System.Windows.Forms.Button SelectBinaryPath;
    }
}

