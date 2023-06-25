namespace WealthBooster
{
    partial class MoneyMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyMenu));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IncreasePayout = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SetShotPrice = new System.Windows.Forms.Button();
            this.SharedTimerMoney = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShotPriceText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.InstructionButton = new System.Windows.Forms.Button();
            this.TpShop = new System.Windows.Forms.Button();
            this.TpCashier = new System.Windows.Forms.Button();
            this.TpTables = new System.Windows.Forms.Button();
            this.TpCasino = new System.Windows.Forms.Button();
            this.RigTable = new System.Windows.Forms.CheckBox();
            this.RpLoopBox = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IncreasePayout);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(10, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 52);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Mission / FAIL";
            // 
            // IncreasePayout
            // 
            this.IncreasePayout.AutoSize = true;
            this.IncreasePayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreasePayout.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.IncreasePayout.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.IncreasePayout.Location = new System.Drawing.Point(6, 23);
            this.IncreasePayout.Name = "IncreasePayout";
            this.IncreasePayout.Size = new System.Drawing.Size(230, 17);
            this.IncreasePayout.TabIndex = 46;
            this.IncreasePayout.Text = "Increase Payout for failing a Mission";
            this.IncreasePayout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "RP / Money Menu";
            // 
            // SetShotPrice
            // 
            this.SetShotPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.SetShotPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SetShotPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetShotPrice.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetShotPrice.ForeColor = System.Drawing.Color.Purple;
            this.SetShotPrice.Location = new System.Drawing.Point(112, 23);
            this.SetShotPrice.Name = "SetShotPrice";
            this.SetShotPrice.Size = new System.Drawing.Size(101, 22);
            this.SetShotPrice.TabIndex = 45;
            this.SetShotPrice.TabStop = false;
            this.SetShotPrice.Text = "Set Shot Price";
            this.SetShotPrice.UseVisualStyleBackColor = true;
            this.SetShotPrice.Click += new System.EventHandler(this.SetShotPrice_Click);
            // 
            // SharedTimerMoney
            // 
            this.SharedTimerMoney.Tick += new System.EventHandler(this.SharedTimerMoney_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShotPriceText);
            this.groupBox1.Controls.Add(this.SetShotPrice);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(10, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 54);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Strip Club Shot Price / get rid of Money";
            // 
            // ShotPriceText
            // 
            this.ShotPriceText.BackColor = System.Drawing.Color.Black;
            this.ShotPriceText.Font = new System.Drawing.Font("Verdana", 9F);
            this.ShotPriceText.ForeColor = System.Drawing.Color.Purple;
            this.ShotPriceText.Location = new System.Drawing.Point(6, 23);
            this.ShotPriceText.Name = "ShotPriceText";
            this.ShotPriceText.Size = new System.Drawing.Size(100, 22);
            this.ShotPriceText.TabIndex = 95;
            this.ShotPriceText.TabStop = false;
            this.ShotPriceText.Text = "10";
            this.ShotPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InstructionButton);
            this.groupBox3.Controls.Add(this.TpShop);
            this.groupBox3.Controls.Add(this.TpCashier);
            this.groupBox3.Controls.Add(this.TpTables);
            this.groupBox3.Controls.Add(this.TpCasino);
            this.groupBox3.Controls.Add(this.RigTable);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox3.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox3.Location = new System.Drawing.Point(10, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 83);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Roulette Hack";
            // 
            // InstructionButton
            // 
            this.InstructionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.InstructionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.InstructionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstructionButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionButton.ForeColor = System.Drawing.Color.Lime;
            this.InstructionButton.Location = new System.Drawing.Point(248, 48);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(106, 22);
            this.InstructionButton.TabIndex = 49;
            this.InstructionButton.TabStop = false;
            this.InstructionButton.Text = "How it works?";
            this.InstructionButton.UseVisualStyleBackColor = true;
            this.InstructionButton.Click += new System.EventHandler(this.InstructionButton_Click);
            // 
            // TpShop
            // 
            this.TpShop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.TpShop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.TpShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TpShop.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpShop.ForeColor = System.Drawing.Color.Purple;
            this.TpShop.Location = new System.Drawing.Point(263, 20);
            this.TpShop.Name = "TpShop";
            this.TpShop.Size = new System.Drawing.Size(91, 22);
            this.TpShop.TabIndex = 51;
            this.TpShop.TabStop = false;
            this.TpShop.Text = "TP Shop";
            this.TpShop.UseVisualStyleBackColor = true;
            this.TpShop.Click += new System.EventHandler(this.TpShop_Click);
            // 
            // TpCashier
            // 
            this.TpCashier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.TpCashier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.TpCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TpCashier.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpCashier.ForeColor = System.Drawing.Color.Purple;
            this.TpCashier.Location = new System.Drawing.Point(163, 48);
            this.TpCashier.Name = "TpCashier";
            this.TpCashier.Size = new System.Drawing.Size(79, 22);
            this.TpCashier.TabIndex = 50;
            this.TpCashier.TabStop = false;
            this.TpCashier.Text = "TP Cashier";
            this.TpCashier.UseVisualStyleBackColor = true;
            this.TpCashier.Click += new System.EventHandler(this.TpCashier_Click);
            // 
            // TpTables
            // 
            this.TpTables.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.TpTables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.TpTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TpTables.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpTables.ForeColor = System.Drawing.Color.Purple;
            this.TpTables.Location = new System.Drawing.Point(30, 48);
            this.TpTables.Name = "TpTables";
            this.TpTables.Size = new System.Drawing.Size(127, 22);
            this.TpTables.TabIndex = 49;
            this.TpTables.TabStop = false;
            this.TpTables.Text = "TP Roulette Tables";
            this.TpTables.UseVisualStyleBackColor = true;
            this.TpTables.Click += new System.EventHandler(this.TpTables_Click);
            // 
            // TpCasino
            // 
            this.TpCasino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.TpCasino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.TpCasino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TpCasino.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TpCasino.ForeColor = System.Drawing.Color.Purple;
            this.TpCasino.Location = new System.Drawing.Point(178, 20);
            this.TpCasino.Name = "TpCasino";
            this.TpCasino.Size = new System.Drawing.Size(82, 22);
            this.TpCasino.TabIndex = 48;
            this.TpCasino.TabStop = false;
            this.TpCasino.Text = "TP Casino";
            this.TpCasino.UseVisualStyleBackColor = true;
            this.TpCasino.Click += new System.EventHandler(this.TpCasino_Click);
            // 
            // RigTable
            // 
            this.RigTable.AutoSize = true;
            this.RigTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RigTable.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.RigTable.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RigTable.Location = new System.Drawing.Point(6, 23);
            this.RigTable.Name = "RigTable";
            this.RigTable.Size = new System.Drawing.Size(126, 17);
            this.RigTable.TabIndex = 46;
            this.RigTable.Text = "Rig Roulette Table";
            this.RigTable.UseVisualStyleBackColor = true;
            // 
            // RpLoopBox
            // 
            this.RpLoopBox.AutoSize = true;
            this.RpLoopBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RpLoopBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.RpLoopBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RpLoopBox.Location = new System.Drawing.Point(10, 35);
            this.RpLoopBox.Name = "RpLoopBox";
            this.RpLoopBox.Size = new System.Drawing.Size(69, 17);
            this.RpLoopBox.TabIndex = 53;
            this.RpLoopBox.Text = "RP Loop";
            this.RpLoopBox.UseVisualStyleBackColor = true;
            this.RpLoopBox.CheckedChanged += new System.EventHandler(this.RpLoopBox_CheckedChanged);
            // 
            // MoneyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(381, 268);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.RpLoopBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoneyMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyMenu";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoneyMenu_FormClosing);
            this.Load += new System.EventHandler(this.MoneyMenu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox IncreasePayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetShotPrice;
        private System.Windows.Forms.Timer SharedTimerMoney;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ShotPriceText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button InstructionButton;
        private System.Windows.Forms.Button TpShop;
        private System.Windows.Forms.Button TpCashier;
        private System.Windows.Forms.Button TpTables;
        private System.Windows.Forms.Button TpCasino;
        private System.Windows.Forms.CheckBox RigTable;
        private System.Windows.Forms.CheckBox RpLoopBox;
    }
}