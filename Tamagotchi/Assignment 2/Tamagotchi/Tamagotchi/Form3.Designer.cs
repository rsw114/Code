namespace Tamagotchi
{
    partial class Form3
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
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.scissors = new System.Windows.Forms.Button();
            this.Draw = new System.Windows.Forms.Button();
            this.cscore = new System.Windows.Forms.Label();
            this.uscore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rock
            // 
            this.rock.Location = new System.Drawing.Point(29, 59);
            this.rock.Margin = new System.Windows.Forms.Padding(4);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(100, 28);
            this.rock.TabIndex = 0;
            this.rock.Text = "Rock";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // paper
            // 
            this.paper.Location = new System.Drawing.Point(177, 59);
            this.paper.Margin = new System.Windows.Forms.Padding(4);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(100, 28);
            this.paper.TabIndex = 1;
            this.paper.Text = "Paper";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // scissors
            // 
            this.scissors.Location = new System.Drawing.Point(327, 59);
            this.scissors.Margin = new System.Windows.Forms.Padding(4);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(100, 28);
            this.scissors.TabIndex = 2;
            this.scissors.Text = "Scissors";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(177, 148);
            this.Draw.Margin = new System.Windows.Forms.Padding(4);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(100, 53);
            this.Draw.TabIndex = 3;
            this.Draw.Text = "DRAW";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // cscore
            // 
            this.cscore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cscore.Location = new System.Drawing.Point(174, 269);
            this.cscore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cscore.Name = "cscore";
            this.cscore.Size = new System.Drawing.Size(100, 22);
            this.cscore.TabIndex = 4;
            this.cscore.Text = "0";
            this.cscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uscore
            // 
            this.uscore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uscore.Location = new System.Drawing.Point(29, 269);
            this.uscore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uscore.Name = "uscore";
            this.uscore.Size = new System.Drawing.Size(104, 22);
            this.uscore.TabIndex = 5;
            this.uscore.Text = "0";
            this.uscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your Score";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(177, 291);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 53);
            this.label2.TabIndex = 7;
            this.label2.Text = "Computer Sciore";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 182);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose rock paper or scissors then click draw.\r\n\r\nRock beats scissors, paper beat" +
    "s rock and scissors beats paper. \r\n\r\nThe first to 3 wins.";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uscore);
            this.Controls.Add(this.cscore);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Label cscore;
        private System.Windows.Forms.Label uscore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}