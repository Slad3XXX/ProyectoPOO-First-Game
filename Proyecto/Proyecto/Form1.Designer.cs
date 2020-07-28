namespace Proyecto
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
            this.bPlay = new System.Windows.Forms.Button();
            this.lablel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPlayer4 = new System.Windows.Forms.TextBox();
            this.tbPlayer3 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bPlay
            // 
            this.bPlay.Location = new System.Drawing.Point(87, 278);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(188, 109);
            this.bPlay.TabIndex = 0;
            this.bPlay.Text = "Play";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // lablel1
            // 
            this.lablel1.AutoSize = true;
            this.lablel1.Location = new System.Drawing.Point(12, 44);
            this.lablel1.Name = "lablel1";
            this.lablel1.Size = new System.Drawing.Size(60, 17);
            this.lablel1.TabIndex = 1;
            this.lablel1.Text = "Player 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player 4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player 3 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Player 2";
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Location = new System.Drawing.Point(98, 44);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(199, 22);
            this.tbPlayer1.TabIndex = 5;
            // 
            // tbPlayer4
            // 
            this.tbPlayer4.Location = new System.Drawing.Point(98, 207);
            this.tbPlayer4.Name = "tbPlayer4";
            this.tbPlayer4.Size = new System.Drawing.Size(199, 22);
            this.tbPlayer4.TabIndex = 6;
            // 
            // tbPlayer3
            // 
            this.tbPlayer3.Location = new System.Drawing.Point(98, 148);
            this.tbPlayer3.Name = "tbPlayer3";
            this.tbPlayer3.Size = new System.Drawing.Size(199, 22);
            this.tbPlayer3.TabIndex = 7;
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Location = new System.Drawing.Point(98, 93);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(199, 22);
            this.tbPlayer2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(379, 426);
            this.Controls.Add(this.tbPlayer2);
            this.Controls.Add(this.tbPlayer3);
            this.Controls.Add(this.tbPlayer4);
            this.Controls.Add(this.tbPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lablel1);
            this.Controls.Add(this.bPlay);
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Label lablel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.TextBox tbPlayer4;
        private System.Windows.Forms.TextBox tbPlayer3;
        private System.Windows.Forms.TextBox tbPlayer2;
    }
}

