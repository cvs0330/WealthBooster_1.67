namespace WealthBooster
{
    partial class Overlay
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            this.HotkeyLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.PosZLabel = new System.Windows.Forms.Label();
            this.ArmorLabel = new System.Windows.Forms.Label();
            this.PosYLabel = new System.Windows.Forms.Label();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.PosXLabel = new System.Windows.Forms.Label();
            this.ConnectionText = new System.Windows.Forms.Label();
            this.HotkeyPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SharedTimerOverlay = new System.Windows.Forms.Timer(this.components);
            this.InfoPanel.SuspendLayout();
            this.HotkeyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HotkeyLabel
            // 
            this.HotkeyLabel.AutoSize = true;
            this.HotkeyLabel.BackColor = System.Drawing.Color.Black;
            this.HotkeyLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotkeyLabel.ForeColor = System.Drawing.Color.Purple;
            this.HotkeyLabel.Location = new System.Drawing.Point(677, 3);
            this.HotkeyLabel.Name = "HotkeyLabel";
            this.HotkeyLabel.Size = new System.Drawing.Size(490, 13);
            this.HotkeyLabel.TabIndex = 8;
            this.HotkeyLabel.Text = "PRESS \"G\" TO HIDE/SHOW MENU | \"DELETE\" TO UNLOAD | \"F5\" TO SHOW HOTKEYS";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.Black;
            this.InfoPanel.Controls.Add(this.PosZLabel);
            this.InfoPanel.Controls.Add(this.ArmorLabel);
            this.InfoPanel.Controls.Add(this.PosYLabel);
            this.InfoPanel.Controls.Add(this.HealthLabel);
            this.InfoPanel.Controls.Add(this.PosXLabel);
            this.InfoPanel.Location = new System.Drawing.Point(4, 17);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(132, 77);
            this.InfoPanel.TabIndex = 7;
            // 
            // PosZLabel
            // 
            this.PosZLabel.AutoSize = true;
            this.PosZLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosZLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PosZLabel.Location = new System.Drawing.Point(5, 59);
            this.PosZLabel.Name = "PosZLabel";
            this.PosZLabel.Size = new System.Drawing.Size(28, 13);
            this.PosZLabel.TabIndex = 8;
            this.PosZLabel.Text = "Z : ";
            // 
            // ArmorLabel
            // 
            this.ArmorLabel.AutoSize = true;
            this.ArmorLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArmorLabel.ForeColor = System.Drawing.Color.Aqua;
            this.ArmorLabel.Location = new System.Drawing.Point(5, 16);
            this.ArmorLabel.Name = "ArmorLabel";
            this.ArmorLabel.Size = new System.Drawing.Size(56, 13);
            this.ArmorLabel.TabIndex = 4;
            this.ArmorLabel.Text = "Armor : ";
            // 
            // PosYLabel
            // 
            this.PosYLabel.AutoSize = true;
            this.PosYLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosYLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PosYLabel.Location = new System.Drawing.Point(5, 46);
            this.PosYLabel.Name = "PosYLabel";
            this.PosYLabel.Size = new System.Drawing.Size(27, 13);
            this.PosYLabel.TabIndex = 7;
            this.PosYLabel.Text = "Y : ";
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.ForeColor = System.Drawing.Color.Red;
            this.HealthLabel.Location = new System.Drawing.Point(5, 3);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(56, 13);
            this.HealthLabel.TabIndex = 5;
            this.HealthLabel.Text = "Health : ";
            // 
            // PosXLabel
            // 
            this.PosXLabel.AutoSize = true;
            this.PosXLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosXLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PosXLabel.Location = new System.Drawing.Point(5, 33);
            this.PosXLabel.Name = "PosXLabel";
            this.PosXLabel.Size = new System.Drawing.Size(28, 13);
            this.PosXLabel.TabIndex = 6;
            this.PosXLabel.Text = "X : ";
            // 
            // ConnectionText
            // 
            this.ConnectionText.AutoSize = true;
            this.ConnectionText.BackColor = System.Drawing.Color.Black;
            this.ConnectionText.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionText.ForeColor = System.Drawing.Color.Red;
            this.ConnectionText.Location = new System.Drawing.Point(4, 3);
            this.ConnectionText.Name = "ConnectionText";
            this.ConnectionText.Size = new System.Drawing.Size(119, 13);
            this.ConnectionText.TabIndex = 5;
            this.ConnectionText.Text = "waiting for game....";
            // 
            // HotkeyPanel
            // 
            this.HotkeyPanel.BackColor = System.Drawing.Color.Black;
            this.HotkeyPanel.Controls.Add(this.label1);
            this.HotkeyPanel.Controls.Add(this.label4);
            this.HotkeyPanel.Controls.Add(this.label10);
            this.HotkeyPanel.Controls.Add(this.label11);
            this.HotkeyPanel.Controls.Add(this.label5);
            this.HotkeyPanel.Controls.Add(this.label6);
            this.HotkeyPanel.Controls.Add(this.label8);
            this.HotkeyPanel.Controls.Add(this.label7);
            this.HotkeyPanel.Controls.Add(this.label9);
            this.HotkeyPanel.Location = new System.Drawing.Point(4, 107);
            this.HotkeyPanel.Name = "HotkeyPanel";
            this.HotkeyPanel.Size = new System.Drawing.Size(154, 146);
            this.HotkeyPanel.TabIndex = 6;
            this.HotkeyPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(36, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Noclip / num8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(39, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Heal / num0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(4, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Remove Wanted / num2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(15, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Max Wanted / num3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(28, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Suicide / num1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(18, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Save Pos 1 / num7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(20, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Load Pos 2 / num6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(20, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Load Pos 1 / num4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(18, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Save Pos 2 / num9";
            // 
            // SharedTimerOverlay
            // 
            this.SharedTimerOverlay.Tick += new System.EventHandler(this.SharedTimerOverlay_Tick);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1173, 258);
            this.Controls.Add(this.HotkeyLabel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.ConnectionText);
            this.Controls.Add(this.HotkeyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Overlay";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Overlay_FormClosing);
            this.Load += new System.EventHandler(this.Overlay_Load);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.HotkeyPanel.ResumeLayout(false);
            this.HotkeyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HotkeyLabel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label PosZLabel;
        private System.Windows.Forms.Label ArmorLabel;
        private System.Windows.Forms.Label PosYLabel;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.Label PosXLabel;
        private System.Windows.Forms.Label ConnectionText;
        private System.Windows.Forms.Panel HotkeyPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer SharedTimerOverlay;
    }
}

