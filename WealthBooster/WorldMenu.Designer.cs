namespace WealthBooster
{
    partial class WorldMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldMenu));
            this.SharedTimerWorld = new System.Windows.Forms.Timer(this.components);
            this.ToggleSnowBox = new System.Windows.Forms.CheckBox();
            this.WeatherSmog = new System.Windows.Forms.Button();
            this.WeatherWindySnow = new System.Windows.Forms.Button();
            this.WeatherRain = new System.Windows.Forms.Button();
            this.WeatherThunder = new System.Windows.Forms.Button();
            this.WeatherXmas = new System.Windows.Forms.Button();
            this.SunnyWeather = new System.Windows.Forms.Button();
            this.ClearWeather = new System.Windows.Forms.Button();
            this.EmptyLobbyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BlueRain = new System.Windows.Forms.Button();
            this.RedRain = new System.Windows.Forms.Button();
            this.GreenRain = new System.Windows.Forms.Button();
            this.ResetRainSettings = new System.Windows.Forms.Button();
            this.SetTime0 = new System.Windows.Forms.Button();
            this.TimeBypassBox = new System.Windows.Forms.CheckBox();
            this.CustomTimeFreezeBox = new System.Windows.Forms.CheckBox();
            this.SyncRealTimeBox = new System.Windows.Forms.CheckBox();
            this.TimeSecondsValue = new System.Windows.Forms.NumericUpDown();
            this.SetTime18 = new System.Windows.Forms.Button();
            this.TimeMinutesValue = new System.Windows.Forms.NumericUpDown();
            this.SetTime12 = new System.Windows.Forms.Button();
            this.SetTime6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSecondsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMinutesValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SharedTimerWorld
            // 
            this.SharedTimerWorld.Tick += new System.EventHandler(this.SharedTimerWorld_Tick);
            // 
            // ToggleSnowBox
            // 
            this.ToggleSnowBox.AutoSize = true;
            this.ToggleSnowBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleSnowBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ToggleSnowBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ToggleSnowBox.Location = new System.Drawing.Point(6, 110);
            this.ToggleSnowBox.Name = "ToggleSnowBox";
            this.ToggleSnowBox.Size = new System.Drawing.Size(95, 17);
            this.ToggleSnowBox.TabIndex = 46;
            this.ToggleSnowBox.Text = "Toggle Snow";
            this.ToggleSnowBox.UseVisualStyleBackColor = true;
            this.ToggleSnowBox.CheckedChanged += new System.EventHandler(this.ToggleSnowBox_CheckedChanged);
            // 
            // WeatherSmog
            // 
            this.WeatherSmog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.WeatherSmog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.WeatherSmog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeatherSmog.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherSmog.ForeColor = System.Drawing.Color.Purple;
            this.WeatherSmog.Location = new System.Drawing.Point(404, 23);
            this.WeatherSmog.Name = "WeatherSmog";
            this.WeatherSmog.Size = new System.Drawing.Size(54, 23);
            this.WeatherSmog.TabIndex = 45;
            this.WeatherSmog.TabStop = false;
            this.WeatherSmog.Text = "Smog";
            this.WeatherSmog.UseVisualStyleBackColor = true;
            this.WeatherSmog.Click += new System.EventHandler(this.WeatherSmog_Click);
            // 
            // WeatherWindySnow
            // 
            this.WeatherWindySnow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.WeatherWindySnow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.WeatherWindySnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeatherWindySnow.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherWindySnow.ForeColor = System.Drawing.Color.Purple;
            this.WeatherWindySnow.Location = new System.Drawing.Point(310, 23);
            this.WeatherWindySnow.Name = "WeatherWindySnow";
            this.WeatherWindySnow.Size = new System.Drawing.Size(88, 23);
            this.WeatherWindySnow.TabIndex = 44;
            this.WeatherWindySnow.TabStop = false;
            this.WeatherWindySnow.Text = "Windy Snow";
            this.WeatherWindySnow.UseVisualStyleBackColor = true;
            this.WeatherWindySnow.Click += new System.EventHandler(this.WeatherWindySnow_Click);
            // 
            // WeatherRain
            // 
            this.WeatherRain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.WeatherRain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.WeatherRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeatherRain.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherRain.ForeColor = System.Drawing.Color.Purple;
            this.WeatherRain.Location = new System.Drawing.Point(260, 23);
            this.WeatherRain.Name = "WeatherRain";
            this.WeatherRain.Size = new System.Drawing.Size(44, 23);
            this.WeatherRain.TabIndex = 43;
            this.WeatherRain.TabStop = false;
            this.WeatherRain.Text = "Rain";
            this.WeatherRain.UseVisualStyleBackColor = true;
            this.WeatherRain.Click += new System.EventHandler(this.WeatherRain_Click);
            // 
            // WeatherThunder
            // 
            this.WeatherThunder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.WeatherThunder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.WeatherThunder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeatherThunder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherThunder.ForeColor = System.Drawing.Color.Purple;
            this.WeatherThunder.Location = new System.Drawing.Point(187, 23);
            this.WeatherThunder.Name = "WeatherThunder";
            this.WeatherThunder.Size = new System.Drawing.Size(67, 23);
            this.WeatherThunder.TabIndex = 42;
            this.WeatherThunder.TabStop = false;
            this.WeatherThunder.Text = "Thunder";
            this.WeatherThunder.UseVisualStyleBackColor = true;
            this.WeatherThunder.Click += new System.EventHandler(this.WeatherThunder_Click);
            // 
            // WeatherXmas
            // 
            this.WeatherXmas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.WeatherXmas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.WeatherXmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeatherXmas.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeatherXmas.ForeColor = System.Drawing.Color.Purple;
            this.WeatherXmas.Location = new System.Drawing.Point(128, 23);
            this.WeatherXmas.Name = "WeatherXmas";
            this.WeatherXmas.Size = new System.Drawing.Size(53, 23);
            this.WeatherXmas.TabIndex = 41;
            this.WeatherXmas.TabStop = false;
            this.WeatherXmas.Text = "XMAS";
            this.WeatherXmas.UseVisualStyleBackColor = true;
            this.WeatherXmas.Click += new System.EventHandler(this.WeatherXmas_Click);
            // 
            // SunnyWeather
            // 
            this.SunnyWeather.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.SunnyWeather.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SunnyWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SunnyWeather.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunnyWeather.ForeColor = System.Drawing.Color.Purple;
            this.SunnyWeather.Location = new System.Drawing.Point(63, 23);
            this.SunnyWeather.Name = "SunnyWeather";
            this.SunnyWeather.Size = new System.Drawing.Size(59, 23);
            this.SunnyWeather.TabIndex = 40;
            this.SunnyWeather.TabStop = false;
            this.SunnyWeather.Text = "Sunny";
            this.SunnyWeather.UseVisualStyleBackColor = true;
            this.SunnyWeather.Click += new System.EventHandler(this.SunnyWeather_Click);
            // 
            // ClearWeather
            // 
            this.ClearWeather.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.ClearWeather.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ClearWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearWeather.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearWeather.ForeColor = System.Drawing.Color.Purple;
            this.ClearWeather.Location = new System.Drawing.Point(6, 23);
            this.ClearWeather.Name = "ClearWeather";
            this.ClearWeather.Size = new System.Drawing.Size(51, 23);
            this.ClearWeather.TabIndex = 39;
            this.ClearWeather.TabStop = false;
            this.ClearWeather.Text = "Clear";
            this.ClearWeather.UseVisualStyleBackColor = true;
            this.ClearWeather.Click += new System.EventHandler(this.ClearWeather_Click);
            // 
            // EmptyLobbyButton
            // 
            this.EmptyLobbyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.EmptyLobbyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.EmptyLobbyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmptyLobbyButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyLobbyButton.ForeColor = System.Drawing.Color.Red;
            this.EmptyLobbyButton.Location = new System.Drawing.Point(12, 281);
            this.EmptyLobbyButton.Name = "EmptyLobbyButton";
            this.EmptyLobbyButton.Size = new System.Drawing.Size(138, 23);
            this.EmptyLobbyButton.TabIndex = 55;
            this.EmptyLobbyButton.TabStop = false;
            this.EmptyLobbyButton.Text = "- ! EMPTY LOBBY ! -";
            this.EmptyLobbyButton.UseVisualStyleBackColor = true;
            this.EmptyLobbyButton.Click += new System.EventHandler(this.EmptyLobbyButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BlueRain);
            this.groupBox2.Controls.Add(this.RedRain);
            this.groupBox2.Controls.Add(this.GreenRain);
            this.groupBox2.Controls.Add(this.ResetRainSettings);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(6, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 52);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rain Settings";
            // 
            // BlueRain
            // 
            this.BlueRain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.BlueRain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BlueRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlueRain.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueRain.ForeColor = System.Drawing.Color.Purple;
            this.BlueRain.Location = new System.Drawing.Point(276, 23);
            this.BlueRain.Name = "BlueRain";
            this.BlueRain.Size = new System.Drawing.Size(75, 23);
            this.BlueRain.TabIndex = 50;
            this.BlueRain.TabStop = false;
            this.BlueRain.Text = "Blue Rain";
            this.BlueRain.UseVisualStyleBackColor = true;
            this.BlueRain.Click += new System.EventHandler(this.BlueRain_Click);
            // 
            // RedRain
            // 
            this.RedRain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.RedRain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RedRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedRain.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedRain.ForeColor = System.Drawing.Color.Purple;
            this.RedRain.Location = new System.Drawing.Point(200, 23);
            this.RedRain.Name = "RedRain";
            this.RedRain.Size = new System.Drawing.Size(70, 23);
            this.RedRain.TabIndex = 49;
            this.RedRain.TabStop = false;
            this.RedRain.Text = "Red Rain";
            this.RedRain.UseVisualStyleBackColor = true;
            this.RedRain.Click += new System.EventHandler(this.RedRain_Click);
            // 
            // GreenRain
            // 
            this.GreenRain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.GreenRain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.GreenRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenRain.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenRain.ForeColor = System.Drawing.Color.Purple;
            this.GreenRain.Location = new System.Drawing.Point(103, 23);
            this.GreenRain.Name = "GreenRain";
            this.GreenRain.Size = new System.Drawing.Size(91, 23);
            this.GreenRain.TabIndex = 48;
            this.GreenRain.TabStop = false;
            this.GreenRain.Text = "Green Rain";
            this.GreenRain.UseVisualStyleBackColor = true;
            this.GreenRain.Click += new System.EventHandler(this.GreenRain_Click);
            // 
            // ResetRainSettings
            // 
            this.ResetRainSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.ResetRainSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ResetRainSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetRainSettings.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetRainSettings.ForeColor = System.Drawing.Color.Purple;
            this.ResetRainSettings.Location = new System.Drawing.Point(6, 23);
            this.ResetRainSettings.Name = "ResetRainSettings";
            this.ResetRainSettings.Size = new System.Drawing.Size(91, 23);
            this.ResetRainSettings.TabIndex = 47;
            this.ResetRainSettings.TabStop = false;
            this.ResetRainSettings.Text = "Reset Rain";
            this.ResetRainSettings.UseVisualStyleBackColor = true;
            this.ResetRainSettings.Click += new System.EventHandler(this.ResetRainSettings_Click);
            // 
            // SetTime0
            // 
            this.SetTime0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.SetTime0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SetTime0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetTime0.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTime0.ForeColor = System.Drawing.Color.Purple;
            this.SetTime0.Location = new System.Drawing.Point(185, 20);
            this.SetTime0.Name = "SetTime0";
            this.SetTime0.Size = new System.Drawing.Size(67, 23);
            this.SetTime0.TabIndex = 38;
            this.SetTime0.TabStop = false;
            this.SetTime0.Text = "00:00";
            this.SetTime0.UseVisualStyleBackColor = true;
            this.SetTime0.Click += new System.EventHandler(this.SetTime0_Click);
            // 
            // TimeBypassBox
            // 
            this.TimeBypassBox.AutoSize = true;
            this.TimeBypassBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimeBypassBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.TimeBypassBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimeBypassBox.Location = new System.Drawing.Point(6, 23);
            this.TimeBypassBox.Name = "TimeBypassBox";
            this.TimeBypassBox.Size = new System.Drawing.Size(132, 17);
            this.TimeBypassBox.TabIndex = 37;
            this.TimeBypassBox.Text = "Time Reset Bypass";
            this.TimeBypassBox.UseVisualStyleBackColor = true;
            // 
            // CustomTimeFreezeBox
            // 
            this.CustomTimeFreezeBox.AutoSize = true;
            this.CustomTimeFreezeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomTimeFreezeBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.CustomTimeFreezeBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustomTimeFreezeBox.Location = new System.Drawing.Point(6, 69);
            this.CustomTimeFreezeBox.Name = "CustomTimeFreezeBox";
            this.CustomTimeFreezeBox.Size = new System.Drawing.Size(141, 17);
            this.CustomTimeFreezeBox.TabIndex = 43;
            this.CustomTimeFreezeBox.Text = "Custom Time Freeze";
            this.CustomTimeFreezeBox.UseVisualStyleBackColor = true;
            // 
            // SyncRealTimeBox
            // 
            this.SyncRealTimeBox.AutoSize = true;
            this.SyncRealTimeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SyncRealTimeBox.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.SyncRealTimeBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SyncRealTimeBox.Location = new System.Drawing.Point(6, 46);
            this.SyncRealTimeBox.Name = "SyncRealTimeBox";
            this.SyncRealTimeBox.Size = new System.Drawing.Size(175, 17);
            this.SyncRealTimeBox.TabIndex = 42;
            this.SyncRealTimeBox.Text = "Sync with Real World Time";
            this.SyncRealTimeBox.UseVisualStyleBackColor = true;
            // 
            // TimeSecondsValue
            // 
            this.TimeSecondsValue.BackColor = System.Drawing.Color.Black;
            this.TimeSecondsValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeSecondsValue.ForeColor = System.Drawing.Color.Purple;
            this.TimeSecondsValue.Location = new System.Drawing.Point(251, 67);
            this.TimeSecondsValue.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.TimeSecondsValue.Name = "TimeSecondsValue";
            this.TimeSecondsValue.Size = new System.Drawing.Size(48, 24);
            this.TimeSecondsValue.TabIndex = 1;
            this.TimeSecondsValue.TabStop = false;
            this.TimeSecondsValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeSecondsValue.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // SetTime18
            // 
            this.SetTime18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.SetTime18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SetTime18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetTime18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTime18.ForeColor = System.Drawing.Color.Purple;
            this.SetTime18.Location = new System.Drawing.Point(404, 20);
            this.SetTime18.Name = "SetTime18";
            this.SetTime18.Size = new System.Drawing.Size(67, 23);
            this.SetTime18.TabIndex = 41;
            this.SetTime18.TabStop = false;
            this.SetTime18.Text = "18:00";
            this.SetTime18.UseVisualStyleBackColor = true;
            this.SetTime18.Click += new System.EventHandler(this.SetTime18_Click);
            // 
            // TimeMinutesValue
            // 
            this.TimeMinutesValue.BackColor = System.Drawing.Color.Black;
            this.TimeMinutesValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeMinutesValue.ForeColor = System.Drawing.Color.Purple;
            this.TimeMinutesValue.Location = new System.Drawing.Point(197, 67);
            this.TimeMinutesValue.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.TimeMinutesValue.Name = "TimeMinutesValue";
            this.TimeMinutesValue.Size = new System.Drawing.Size(48, 24);
            this.TimeMinutesValue.TabIndex = 0;
            this.TimeMinutesValue.TabStop = false;
            this.TimeMinutesValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeMinutesValue.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // SetTime12
            // 
            this.SetTime12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.SetTime12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SetTime12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetTime12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTime12.ForeColor = System.Drawing.Color.Purple;
            this.SetTime12.Location = new System.Drawing.Point(331, 20);
            this.SetTime12.Name = "SetTime12";
            this.SetTime12.Size = new System.Drawing.Size(67, 23);
            this.SetTime12.TabIndex = 40;
            this.SetTime12.TabStop = false;
            this.SetTime12.Text = "12:00";
            this.SetTime12.UseVisualStyleBackColor = true;
            this.SetTime12.Click += new System.EventHandler(this.SetTime12_Click);
            // 
            // SetTime6
            // 
            this.SetTime6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.SetTime6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SetTime6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetTime6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTime6.ForeColor = System.Drawing.Color.Purple;
            this.SetTime6.Location = new System.Drawing.Point(258, 20);
            this.SetTime6.Name = "SetTime6";
            this.SetTime6.Size = new System.Drawing.Size(67, 23);
            this.SetTime6.TabIndex = 39;
            this.SetTime6.TabStop = false;
            this.SetTime6.Text = "06:00";
            this.SetTime6.UseVisualStyleBackColor = true;
            this.SetTime6.Click += new System.EventHandler(this.SetTime6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ToggleSnowBox);
            this.groupBox1.Controls.Add(this.WeatherSmog);
            this.groupBox1.Controls.Add(this.WeatherWindySnow);
            this.groupBox1.Controls.Add(this.WeatherRain);
            this.groupBox1.Controls.Add(this.WeatherThunder);
            this.groupBox1.Controls.Add(this.WeatherXmas);
            this.groupBox1.Controls.Add(this.SunnyWeather);
            this.groupBox1.Controls.Add(this.ClearWeather);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 135);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Weather";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CustomTimeFreezeBox);
            this.groupBox3.Controls.Add(this.SyncRealTimeBox);
            this.groupBox3.Controls.Add(this.TimeSecondsValue);
            this.groupBox3.Controls.Add(this.SetTime18);
            this.groupBox3.Controls.Add(this.TimeMinutesValue);
            this.groupBox3.Controls.Add(this.SetTime12);
            this.groupBox3.Controls.Add(this.SetTime6);
            this.groupBox3.Controls.Add(this.SetTime0);
            this.groupBox3.Controls.Add(this.TimeBypassBox);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox3.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox3.Location = new System.Drawing.Point(12, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 100);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "World Menu";
            // 
            // WorldMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(501, 312);
            this.Controls.Add(this.EmptyLobbyButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorldMenu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldMenu";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorldMenu_FormClosing);
            this.Load += new System.EventHandler(this.WorldMenu_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimeSecondsValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMinutesValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SharedTimerWorld;
        private System.Windows.Forms.CheckBox ToggleSnowBox;
        private System.Windows.Forms.Button WeatherSmog;
        private System.Windows.Forms.Button WeatherWindySnow;
        private System.Windows.Forms.Button WeatherRain;
        private System.Windows.Forms.Button WeatherThunder;
        private System.Windows.Forms.Button WeatherXmas;
        private System.Windows.Forms.Button SunnyWeather;
        private System.Windows.Forms.Button ClearWeather;
        private System.Windows.Forms.Button EmptyLobbyButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BlueRain;
        private System.Windows.Forms.Button RedRain;
        private System.Windows.Forms.Button GreenRain;
        private System.Windows.Forms.Button ResetRainSettings;
        private System.Windows.Forms.Button SetTime0;
        private System.Windows.Forms.CheckBox TimeBypassBox;
        private System.Windows.Forms.CheckBox CustomTimeFreezeBox;
        private System.Windows.Forms.CheckBox SyncRealTimeBox;
        private System.Windows.Forms.NumericUpDown TimeSecondsValue;
        private System.Windows.Forms.Button SetTime18;
        private System.Windows.Forms.NumericUpDown TimeMinutesValue;
        private System.Windows.Forms.Button SetTime12;
        private System.Windows.Forms.Button SetTime6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}