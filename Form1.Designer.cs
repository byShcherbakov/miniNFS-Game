namespace WindowsFormsApp1
{
    partial class btn_rest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btn_rest));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Red2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pB2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Red1 = new System.Windows.Forms.PictureBox();
            this.Red_2 = new System.Windows.Forms.PictureBox();
            this.Labellose = new System.Windows.Forms.Label();
            this.btnRest = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.labelCoins = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Label();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.Sound = new System.Windows.Forms.Button();
            this.label_win = new System.Windows.Forms.Label();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.lose_h = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.PictureBox();
            this.Start_game = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.Button();
            this.mainINFO = new System.Windows.Forms.TextBox();
            this.MainMenuBack1 = new System.Windows.Forms.Button();
            this.log_menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Red2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Red2
            // 
            this.Red2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Red2.BackgroundImage")));
            this.Red2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Red2.Location = new System.Drawing.Point(0, 0);
            this.Red2.Name = "Red2";
            this.Red2.Size = new System.Drawing.Size(842, 650);
            this.Red2.TabIndex = 0;
            this.Red2.TabStop = false;
            this.Red2.Click += new System.EventHandler(this.pictureBox1_Click_3);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(425, 452);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 128);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pB2
            // 
            this.pB2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pB2.BackgroundImage")));
            this.pB2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB2.Location = new System.Drawing.Point(0, -650);
            this.pB2.Name = "pB2";
            this.pB2.Size = new System.Drawing.Size(842, 650);
            this.pB2.TabIndex = 2;
            this.pB2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(842, 650);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_4);
            // 
            // Red1
            // 
            this.Red1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Red1.Image = ((System.Drawing.Image)(resources.GetObject("Red1.Image")));
            this.Red1.Location = new System.Drawing.Point(193, -130);
            this.Red1.Name = "Red1";
            this.Red1.Size = new System.Drawing.Size(100, 100);
            this.Red1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Red1.TabIndex = 4;
            this.Red1.TabStop = false;
            // 
            // Red_2
            // 
            this.Red_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Red_2.Image = ((System.Drawing.Image)(resources.GetObject("Red_2.Image")));
            this.Red_2.Location = new System.Drawing.Point(489, -400);
            this.Red_2.Name = "Red_2";
            this.Red_2.Size = new System.Drawing.Size(100, 100);
            this.Red_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Red_2.TabIndex = 5;
            this.Red_2.TabStop = false;
            this.Red_2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Labellose
            // 
            this.Labellose.AutoSize = true;
            this.Labellose.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Labellose.ForeColor = System.Drawing.Color.Red;
            this.Labellose.Location = new System.Drawing.Point(216, 169);
            this.Labellose.Name = "Labellose";
            this.Labellose.Size = new System.Drawing.Size(453, 64);
            this.Labellose.TabIndex = 6;
            this.Labellose.Text = "Вы проиграли !!!";
            this.Labellose.Click += new System.EventHandler(this.Labellose_Click);
            // 
            // btnRest
            // 
            this.btnRest.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRest.Location = new System.Drawing.Point(245, 323);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(367, 44);
            this.btnRest.TabIndex = 8;
            this.btnRest.Text = "Начать заново";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(468, -550);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(32, 32);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 9;
            this.coin.TabStop = false;
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.Color.Red;
            this.labelCoins.Location = new System.Drawing.Point(12, 20);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(250, 50);
            this.labelCoins.TabIndex = 10;
            this.labelCoins.Text = "Монеток: 0 ";
            this.labelCoins.Click += new System.EventHandler(this.labelCoins_Click);
            // 
            // Stop
            // 
            this.Stop.AutoSize = true;
            this.Stop.BackColor = System.Drawing.SystemColors.Control;
            this.Stop.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stop.Location = new System.Drawing.Point(288, 216);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(265, 86);
            this.Stop.TabIndex = 12;
            this.Stop.Text = "ПАУЗА";
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            // 
            // Sound
            // 
            this.Sound.BackColor = System.Drawing.Color.RoyalBlue;
            this.Sound.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sound.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Sound.Location = new System.Drawing.Point(731, 515);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(97, 75);
            this.Sound.TabIndex = 14;
            this.Sound.Text = "Звук";
            this.Sound.UseVisualStyleBackColor = false;
            this.Sound.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // label_win
            // 
            this.label_win.AutoSize = true;
            this.label_win.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_win.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_win.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_win.Location = new System.Drawing.Point(142, 97);
            this.label_win.Name = "label_win";
            this.label_win.Size = new System.Drawing.Size(552, 83);
            this.label_win.TabIndex = 15;
            this.label_win.Text = "Вы выиграли !!!!";
            this.label_win.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.DimGray;
            this.heart2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart2.BackgroundImage")));
            this.heart2.Image = ((System.Drawing.Image)(resources.GetObject("heart2.Image")));
            this.heart2.Location = new System.Drawing.Point(713, 20);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(50, 50);
            this.heart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart2.TabIndex = 16;
            this.heart2.TabStop = false;
            this.heart2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.DimGray;
            this.heart3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart3.BackgroundImage")));
            this.heart3.Image = ((System.Drawing.Image)(resources.GetObject("heart3.Image")));
            this.heart3.Location = new System.Drawing.Point(778, 20);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(50, 50);
            this.heart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart3.TabIndex = 17;
            this.heart3.TabStop = false;
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.DimGray;
            this.heart1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart1.BackgroundImage")));
            this.heart1.Image = ((System.Drawing.Image)(resources.GetObject("heart1.Image")));
            this.heart1.Location = new System.Drawing.Point(644, 20);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(50, 50);
            this.heart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart1.TabIndex = 18;
            this.heart1.TabStop = false;
            this.heart1.Click += new System.EventHandler(this.heart1_Click);
            // 
            // lose_h
            // 
            this.lose_h.AutoSize = true;
            this.lose_h.CausesValidation = false;
            this.lose_h.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lose_h.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lose_h.Location = new System.Drawing.Point(141, 120);
            this.lose_h.Name = "lose_h";
            this.lose_h.Size = new System.Drawing.Size(562, 86);
            this.lose_h.TabIndex = 19;
            this.lose_h.Text = "Потеря жизини";
            this.lose_h.Click += new System.EventHandler(this.lose_h_Click);
            // 
            // Menu
            // 
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(842, 650);
            this.Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menu.TabIndex = 20;
            this.Menu.TabStop = false;
            this.Menu.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Start_game
            // 
            this.Start_game.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Start_game.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Start_game.Location = new System.Drawing.Point(334, 272);
            this.Start_game.Name = "Start_game";
            this.Start_game.Size = new System.Drawing.Size(181, 75);
            this.Start_game.TabIndex = 21;
            this.Start_game.Text = "СТАРТ";
            this.Start_game.UseVisualStyleBackColor = false;
            this.Start_game.Click += new System.EventHandler(this.Start_game_Click);
            // 
            // Rules
            // 
            this.Rules.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Rules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Rules.Location = new System.Drawing.Point(334, 363);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(181, 43);
            this.Rules.TabIndex = 22;
            this.Rules.Text = "ПРАВИЛА ИГРЫ";
            this.Rules.UseVisualStyleBackColor = true;
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // mainINFO
            // 
            this.mainINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainINFO.Location = new System.Drawing.Point(193, 192);
            this.mainINFO.Multiline = true;
            this.mainINFO.Name = "mainINFO";
            this.mainINFO.Size = new System.Drawing.Size(476, 305);
            this.mainINFO.TabIndex = 23;
            this.mainINFO.Text = resources.GetString("mainINFO.Text");
            this.mainINFO.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // MainMenuBack1
            // 
            this.MainMenuBack1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuBack1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MainMenuBack1.Location = new System.Drawing.Point(368, 528);
            this.MainMenuBack1.Name = "MainMenuBack1";
            this.MainMenuBack1.Size = new System.Drawing.Size(116, 52);
            this.MainMenuBack1.TabIndex = 25;
            this.MainMenuBack1.Text = "НАЗАД";
            this.MainMenuBack1.UseVisualStyleBackColor = true;
            this.MainMenuBack1.Click += new System.EventHandler(this.MainMenuBack1_Click);
            // 
            // log_menu
            // 
            this.log_menu.BackColor = System.Drawing.Color.RoyalBlue;
            this.log_menu.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
            this.log_menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.log_menu.Location = new System.Drawing.Point(12, 515);
            this.log_menu.Name = "log_menu";
            this.log_menu.Size = new System.Drawing.Size(117, 75);
            this.log_menu.TabIndex = 26;
            this.log_menu.Text = "МЕНЮ";
            this.log_menu.UseVisualStyleBackColor = false;
            this.log_menu.Click += new System.EventHandler(this.log_menu_Click);
            // 
            // btn_rest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.log_menu);
            this.Controls.Add(this.MainMenuBack1);
            this.Controls.Add(this.mainINFO);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.Start_game);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.lose_h);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.label_win);
            this.Controls.Add(this.Sound);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.Labellose);
            this.Controls.Add(this.Red_2);
            this.Controls.Add(this.Red1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.Red2);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btn_rest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Red2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox Red2;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pB2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Red1;
        private System.Windows.Forms.PictureBox Red_2;
        private System.Windows.Forms.Label Labellose;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Label Stop;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.Button Sound;
        private System.Windows.Forms.Label label_win;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.Label lose_h;
        private System.Windows.Forms.PictureBox Menu;
        private System.Windows.Forms.Button Start_game;
        private System.Windows.Forms.Button Rules;
        private System.Windows.Forms.TextBox mainINFO;
        private System.Windows.Forms.Button MainMenuBack1;
        private System.Windows.Forms.Button log_menu;
    }
}

