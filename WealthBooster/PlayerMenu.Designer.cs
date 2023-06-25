namespace WealthBooster
{
    partial class PlayerMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerMenu));
            this.label2 = new System.Windows.Forms.Label();
            this.RunSpeedMult = new System.Windows.Forms.TrackBar();
            this.ToggleAutoJumpBox = new System.Windows.Forms.CheckBox();
            this.UndeadRadarBox = new System.Windows.Forms.CheckBox();
            this.NoCollisionBox = new System.Windows.Forms.CheckBox();
            this.NeverWantedBox = new System.Windows.Forms.CheckBox();
            this.MaxWantedButton = new System.Windows.Forms.Button();
            this.RemoveWantedButton = new System.Windows.Forms.Button();
            this.HealPlayerButton = new System.Windows.Forms.Button();
            this.SuicideButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GodmodeCheckBox = new System.Windows.Forms.CheckBox();
            this.SharedTimerPlayer = new System.Windows.Forms.Timer(this.components);
            this.NoclipCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.RunSpeedMult)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(7, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Run Speed";
            // 
            // RunSpeedMult
            // 
            this.RunSpeedMult.LargeChange = 1;
            this.RunSpeedMult.Location = new System.Drawing.Point(71, 174);
            this.RunSpeedMult.Maximum = 15;
            this.RunSpeedMult.Minimum = 1;
            this.RunSpeedMult.Name = "RunSpeedMult";
            this.RunSpeedMult.Size = new System.Drawing.Size(104, 45);
            this.RunSpeedMult.TabIndex = 25;
            this.RunSpeedMult.TabStop = false;
            this.RunSpeedMult.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.RunSpeedMult.Value = 1;
            this.RunSpeedMult.Scroll += new System.EventHandler(this.RunSpeedMult_Scroll);
            // 
            // ToggleAutoJumpBox
            // 
            this.ToggleAutoJumpBox.AutoSize = true;
            this.ToggleAutoJumpBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleAutoJumpBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ToggleAutoJumpBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToggleAutoJumpBox.Location = new System.Drawing.Point(10, 128);
            this.ToggleAutoJumpBox.Name = "ToggleAutoJumpBox";
            this.ToggleAutoJumpBox.Size = new System.Drawing.Size(124, 17);
            this.ToggleAutoJumpBox.TabIndex = 24;
            this.ToggleAutoJumpBox.Text = "Toggle Auto Jump";
            this.ToggleAutoJumpBox.UseVisualStyleBackColor = true;
            this.ToggleAutoJumpBox.CheckedChanged += new System.EventHandler(this.ToggleAutoJumpBox_CheckedChanged);
            // 
            // UndeadRadarBox
            // 
            this.UndeadRadarBox.AutoSize = true;
            this.UndeadRadarBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndeadRadarBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.UndeadRadarBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.UndeadRadarBox.Location = new System.Drawing.Point(10, 105);
            this.UndeadRadarBox.Name = "UndeadRadarBox";
            this.UndeadRadarBox.Size = new System.Drawing.Size(134, 17);
            this.UndeadRadarBox.TabIndex = 23;
            this.UndeadRadarBox.Text = "Undead / Off Radar";
            this.UndeadRadarBox.UseVisualStyleBackColor = true;
            this.UndeadRadarBox.CheckedChanged += new System.EventHandler(this.UndeadRadarBox_CheckedChanged);
            // 
            // NoCollisionBox
            // 
            this.NoCollisionBox.AutoSize = true;
            this.NoCollisionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoCollisionBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.NoCollisionBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.NoCollisionBox.Location = new System.Drawing.Point(10, 82);
            this.NoCollisionBox.Name = "NoCollisionBox";
            this.NoCollisionBox.Size = new System.Drawing.Size(90, 17);
            this.NoCollisionBox.TabIndex = 22;
            this.NoCollisionBox.Text = "No Collision";
            this.NoCollisionBox.UseVisualStyleBackColor = true;
            // 
            // NeverWantedBox
            // 
            this.NeverWantedBox.AutoSize = true;
            this.NeverWantedBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NeverWantedBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.NeverWantedBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.NeverWantedBox.Location = new System.Drawing.Point(10, 59);
            this.NeverWantedBox.Name = "NeverWantedBox";
            this.NeverWantedBox.Size = new System.Drawing.Size(103, 17);
            this.NeverWantedBox.TabIndex = 21;
            this.NeverWantedBox.Text = "Never Wanted";
            this.NeverWantedBox.UseVisualStyleBackColor = true;
            // 
            // MaxWantedButton
            // 
            this.MaxWantedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.MaxWantedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.MaxWantedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxWantedButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxWantedButton.ForeColor = System.Drawing.Color.Purple;
            this.MaxWantedButton.Location = new System.Drawing.Point(11, 314);
            this.MaxWantedButton.Name = "MaxWantedButton";
            this.MaxWantedButton.Size = new System.Drawing.Size(158, 23);
            this.MaxWantedButton.TabIndex = 20;
            this.MaxWantedButton.TabStop = false;
            this.MaxWantedButton.Text = "Max Wanted Level";
            this.MaxWantedButton.UseVisualStyleBackColor = true;
            this.MaxWantedButton.Click += new System.EventHandler(this.MaxWantedButton_Click);
            // 
            // RemoveWantedButton
            // 
            this.RemoveWantedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.RemoveWantedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveWantedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveWantedButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveWantedButton.ForeColor = System.Drawing.Color.Purple;
            this.RemoveWantedButton.Location = new System.Drawing.Point(11, 285);
            this.RemoveWantedButton.Name = "RemoveWantedButton";
            this.RemoveWantedButton.Size = new System.Drawing.Size(158, 23);
            this.RemoveWantedButton.TabIndex = 19;
            this.RemoveWantedButton.TabStop = false;
            this.RemoveWantedButton.Text = "Remove Wanted Level";
            this.RemoveWantedButton.UseVisualStyleBackColor = true;
            this.RemoveWantedButton.Click += new System.EventHandler(this.RemoveWantedButton_Click);
            // 
            // HealPlayerButton
            // 
            this.HealPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.HealPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.HealPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HealPlayerButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealPlayerButton.ForeColor = System.Drawing.Color.Purple;
            this.HealPlayerButton.Location = new System.Drawing.Point(33, 251);
            this.HealPlayerButton.Name = "HealPlayerButton";
            this.HealPlayerButton.Size = new System.Drawing.Size(114, 23);
            this.HealPlayerButton.TabIndex = 18;
            this.HealPlayerButton.TabStop = false;
            this.HealPlayerButton.Text = "Heal Player";
            this.HealPlayerButton.UseVisualStyleBackColor = true;
            this.HealPlayerButton.Click += new System.EventHandler(this.HealPlayerButton_Click);
            // 
            // SuicideButton
            // 
            this.SuicideButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.SuicideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SuicideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SuicideButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuicideButton.ForeColor = System.Drawing.Color.Purple;
            this.SuicideButton.Location = new System.Drawing.Point(33, 222);
            this.SuicideButton.Name = "SuicideButton";
            this.SuicideButton.Size = new System.Drawing.Size(114, 23);
            this.SuicideButton.TabIndex = 17;
            this.SuicideButton.TabStop = false;
            this.SuicideButton.Text = "Suicide";
            this.SuicideButton.UseVisualStyleBackColor = true;
            this.SuicideButton.Click += new System.EventHandler(this.SuicideButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Player Menu";
            // 
            // GodmodeCheckBox
            // 
            this.GodmodeCheckBox.AutoSize = true;
            this.GodmodeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GodmodeCheckBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.GodmodeCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GodmodeCheckBox.Location = new System.Drawing.Point(10, 36);
            this.GodmodeCheckBox.Name = "GodmodeCheckBox";
            this.GodmodeCheckBox.Size = new System.Drawing.Size(78, 17);
            this.GodmodeCheckBox.TabIndex = 15;
            this.GodmodeCheckBox.Text = "Godmode";
            this.GodmodeCheckBox.UseVisualStyleBackColor = true;
            this.GodmodeCheckBox.CheckedChanged += new System.EventHandler(this.GodmodeCheckBox_CheckedChanged);
            // 
            // SharedTimerPlayer
            // 
            this.SharedTimerPlayer.Tick += new System.EventHandler(this.SharedTimerPlayer_Tick);
            // 
            // NoclipCheckbox
            // 
            this.NoclipCheckbox.AutoSize = true;
            this.NoclipCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoclipCheckbox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.NoclipCheckbox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.NoclipCheckbox.Location = new System.Drawing.Point(10, 151);
            this.NoclipCheckbox.Name = "NoclipCheckbox";
            this.NoclipCheckbox.Size = new System.Drawing.Size(110, 17);
            this.NoclipCheckbox.TabIndex = 27;
            this.NoclipCheckbox.Text = "Noclip (buggy!)";
            this.NoclipCheckbox.UseVisualStyleBackColor = true;
            this.NoclipCheckbox.CheckedChanged += new System.EventHandler(this.NoclipCheckbox_CheckedChanged);
            // 
            // PlayerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(182, 346);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RunSpeedMult);
            this.Controls.Add(this.ToggleAutoJumpBox);
            this.Controls.Add(this.UndeadRadarBox);
            this.Controls.Add(this.NoCollisionBox);
            this.Controls.Add(this.NeverWantedBox);
            this.Controls.Add(this.MaxWantedButton);
            this.Controls.Add(this.RemoveWantedButton);
            this.Controls.Add(this.HealPlayerButton);
            this.Controls.Add(this.SuicideButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GodmodeCheckBox);
            this.Controls.Add(this.NoclipCheckbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerMenu";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerMenu_FormClosing);
            this.Load += new System.EventHandler(this.PlayerMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RunSpeedMult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar RunSpeedMult;
        private System.Windows.Forms.CheckBox ToggleAutoJumpBox;
        private System.Windows.Forms.CheckBox UndeadRadarBox;
        private System.Windows.Forms.CheckBox NoCollisionBox;
        private System.Windows.Forms.CheckBox NeverWantedBox;
        private System.Windows.Forms.Button MaxWantedButton;
        private System.Windows.Forms.Button RemoveWantedButton;
        private System.Windows.Forms.Button HealPlayerButton;
        private System.Windows.Forms.Button SuicideButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox GodmodeCheckBox;
        private System.Windows.Forms.Timer SharedTimerPlayer;
        private System.Windows.Forms.CheckBox NoclipCheckbox;
    }
}