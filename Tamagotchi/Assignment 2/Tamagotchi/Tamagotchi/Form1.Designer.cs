namespace Tamagotchi
{
    partial class Form1
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
            this.fed = new System.Windows.Forms.Label();
            this.healthy = new System.Windows.Forms.Label();
            this.bored = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.feed = new System.Windows.Forms.Button();
            this.heal = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.battle = new System.Windows.Forms.Button();
            this.qsave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fed
            // 
            this.fed.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fed.Location = new System.Drawing.Point(81, 74);
            this.fed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fed.Name = "fed";
            this.fed.Size = new System.Drawing.Size(75, 19);
            this.fed.TabIndex = 0;
            this.fed.Click += new System.EventHandler(this.feed_Click);
            // 
            // healthy
            // 
            this.healthy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.healthy.Location = new System.Drawing.Point(380, 74);
            this.healthy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.healthy.Name = "healthy";
            this.healthy.Size = new System.Drawing.Size(75, 19);
            this.healthy.TabIndex = 1;
            // 
            // bored
            // 
            this.bored.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bored.Location = new System.Drawing.Point(226, 74);
            this.bored.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bored.Name = "bored";
            this.bored.Size = new System.Drawing.Size(75, 19);
            this.bored.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // feed
            // 
            this.feed.Location = new System.Drawing.Point(86, 143);
            this.feed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.feed.Name = "feed";
            this.feed.Size = new System.Drawing.Size(70, 40);
            this.feed.TabIndex = 3;
            this.feed.Text = "Feed";
            this.feed.UseVisualStyleBackColor = true;
            this.feed.Click += new System.EventHandler(this.feed_Click);
            // 
            // heal
            // 
            this.heal.Location = new System.Drawing.Point(382, 143);
            this.heal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.heal.Name = "heal";
            this.heal.Size = new System.Drawing.Size(70, 40);
            this.heal.TabIndex = 4;
            this.heal.Text = "heal";
            this.heal.UseVisualStyleBackColor = true;
            this.heal.Click += new System.EventHandler(this.heal_Click);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(228, 143);
            this.play.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(70, 40);
            this.play.TabIndex = 5;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(83, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "HUNGER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(379, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "HEALTH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(225, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "BOREDOM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // battle
            // 
            this.battle.Location = new System.Drawing.Point(227, 231);
            this.battle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.battle.Name = "battle";
            this.battle.Size = new System.Drawing.Size(70, 40);
            this.battle.TabIndex = 12;
            this.battle.Text = "Battle";
            this.battle.UseVisualStyleBackColor = true;
            this.battle.Click += new System.EventHandler(this.battle_Click);
            // 
            // qsave
            // 
            this.qsave.Location = new System.Drawing.Point(228, 332);
            this.qsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qsave.Name = "qsave";
            this.qsave.Size = new System.Drawing.Size(92, 40);
            this.qsave.TabIndex = 13;
            this.qsave.Text = "Quit and record states";
            this.qsave.UseVisualStyleBackColor = true;
            this.qsave.Click += new System.EventHandler(this.qsave_Click_1);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.ImageLocation = "0,0";
            this.pictureBox1.Location = new System.Drawing.Point(483, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 222);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(86, 332);
            this.Quit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(92, 40);
            this.Quit.TabIndex = 15;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 513);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.qsave);
            this.Controls.Add(this.battle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.play);
            this.Controls.Add(this.heal);
            this.Controls.Add(this.feed);
            this.Controls.Add(this.bored);
            this.Controls.Add(this.healthy);
            this.Controls.Add(this.fed);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fed;
        private System.Windows.Forms.Label healthy;
        private System.Windows.Forms.Label bored;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button feed;
        private System.Windows.Forms.Button heal;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button battle;
        private System.Windows.Forms.Button qsave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Quit;
    }
}

