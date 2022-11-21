namespace Wedstrijd
{
    partial class Spel
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
            this.Antwoorden = new System.Windows.Forms.GroupBox();
            this.Som = new System.Windows.Forms.Label();
            this.Antwoord_Vier = new System.Windows.Forms.RadioButton();
            this.Antwoord_Drie = new System.Windows.Forms.RadioButton();
            this.Antwoord_Twee = new System.Windows.Forms.RadioButton();
            this.Antwoord_Een = new System.Windows.Forms.RadioButton();
            this.label_Vraag = new System.Windows.Forms.Label();
            this.label_Goed = new System.Windows.Forms.Label();
            this.label_Fout = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tijd = new System.Windows.Forms.Label();
            this.listBox_BesteScores = new System.Windows.Forms.ListBox();
            this.label_BesteScores = new System.Windows.Forms.Label();
            this.label_BesteScore = new System.Windows.Forms.Label();
            this.label_GemiddeldeScore = new System.Windows.Forms.Label();
            this.label_VorigeScore = new System.Windows.Forms.Label();
            this.Antwoorden.SuspendLayout();
            this.SuspendLayout();
            // 
            // Antwoorden
            // 
            this.Antwoorden.Controls.Add(this.label_VorigeScore);
            this.Antwoorden.Controls.Add(this.label_GemiddeldeScore);
            this.Antwoorden.Controls.Add(this.label_BesteScore);
            this.Antwoorden.Controls.Add(this.Som);
            this.Antwoorden.Controls.Add(this.Antwoord_Vier);
            this.Antwoorden.Controls.Add(this.Antwoord_Drie);
            this.Antwoorden.Controls.Add(this.Antwoord_Twee);
            this.Antwoorden.Controls.Add(this.Antwoord_Een);
            this.Antwoorden.Controls.Add(this.label_Vraag);
            this.Antwoorden.Location = new System.Drawing.Point(34, 49);
            this.Antwoorden.Name = "Antwoorden";
            this.Antwoorden.Size = new System.Drawing.Size(630, 209);
            this.Antwoorden.TabIndex = 0;
            this.Antwoorden.TabStop = false;
            // 
            // Som
            // 
            this.Som.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Som.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Som.Location = new System.Drawing.Point(227, 34);
            this.Som.Name = "Som";
            this.Som.Size = new System.Drawing.Size(160, 56);
            this.Som.TabIndex = 7;
            this.Som.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Som.Click += new System.EventHandler(this.Som_Click_1);
            // 
            // Antwoord_Vier
            // 
            this.Antwoord_Vier.AutoSize = true;
            this.Antwoord_Vier.Location = new System.Drawing.Point(481, 153);
            this.Antwoord_Vier.Name = "Antwoord_Vier";
            this.Antwoord_Vier.Size = new System.Drawing.Size(95, 21);
            this.Antwoord_Vier.TabIndex = 4;
            this.Antwoord_Vier.TabStop = true;
            this.Antwoord_Vier.Text = "antwoord4";
            this.Antwoord_Vier.UseVisualStyleBackColor = true;
            this.Antwoord_Vier.CheckedChanged += new System.EventHandler(this.Antwoord_Vier_CheckedChanged);
            // 
            // Antwoord_Drie
            // 
            this.Antwoord_Drie.AutoSize = true;
            this.Antwoord_Drie.Location = new System.Drawing.Point(325, 153);
            this.Antwoord_Drie.Name = "Antwoord_Drie";
            this.Antwoord_Drie.Size = new System.Drawing.Size(95, 21);
            this.Antwoord_Drie.TabIndex = 3;
            this.Antwoord_Drie.TabStop = true;
            this.Antwoord_Drie.Text = "antwoord3";
            this.Antwoord_Drie.UseVisualStyleBackColor = true;
            this.Antwoord_Drie.CheckedChanged += new System.EventHandler(this.Antwoord_Drie_CheckedChanged);
            // 
            // Antwoord_Twee
            // 
            this.Antwoord_Twee.AutoSize = true;
            this.Antwoord_Twee.Location = new System.Drawing.Point(162, 153);
            this.Antwoord_Twee.Name = "Antwoord_Twee";
            this.Antwoord_Twee.Size = new System.Drawing.Size(95, 21);
            this.Antwoord_Twee.TabIndex = 2;
            this.Antwoord_Twee.TabStop = true;
            this.Antwoord_Twee.Text = "antwoord2";
            this.Antwoord_Twee.UseVisualStyleBackColor = true;
            this.Antwoord_Twee.CheckedChanged += new System.EventHandler(this.Antwoord_Twee_CheckedChanged);
            // 
            // Antwoord_Een
            // 
            this.Antwoord_Een.AutoSize = true;
            this.Antwoord_Een.Location = new System.Drawing.Point(11, 153);
            this.Antwoord_Een.Name = "Antwoord_Een";
            this.Antwoord_Een.Size = new System.Drawing.Size(95, 21);
            this.Antwoord_Een.TabIndex = 1;
            this.Antwoord_Een.TabStop = true;
            this.Antwoord_Een.Text = "antwoord1";
            this.Antwoord_Een.UseVisualStyleBackColor = true;
            this.Antwoord_Een.CheckedChanged += new System.EventHandler(this.Antwoord_Een_CheckedChanged);
            // 
            // label_Vraag
            // 
            this.label_Vraag.AutoSize = true;
            this.label_Vraag.Location = new System.Drawing.Point(279, 0);
            this.label_Vraag.Name = "label_Vraag";
            this.label_Vraag.Size = new System.Drawing.Size(46, 17);
            this.label_Vraag.TabIndex = 0;
            this.label_Vraag.Text = "Vraag";
            // 
            // label_Goed
            // 
            this.label_Goed.AutoSize = true;
            this.label_Goed.ForeColor = System.Drawing.Color.Green;
            this.label_Goed.Location = new System.Drawing.Point(100, 304);
            this.label_Goed.Name = "label_Goed";
            this.label_Goed.Size = new System.Drawing.Size(16, 17);
            this.label_Goed.TabIndex = 9;
            this.label_Goed.Text = "0";
            // 
            // label_Fout
            // 
            this.label_Fout.AutoSize = true;
            this.label_Fout.ForeColor = System.Drawing.Color.Red;
            this.label_Fout.Location = new System.Drawing.Point(567, 304);
            this.label_Fout.Name = "label_Fout";
            this.label_Fout.Size = new System.Drawing.Size(16, 17);
            this.label_Fout.TabIndex = 10;
            this.label_Fout.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tijd
            // 
            this.Tijd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tijd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Tijd.Location = new System.Drawing.Point(263, 376);
            this.Tijd.Name = "Tijd";
            this.Tijd.Size = new System.Drawing.Size(160, 56);
            this.Tijd.TabIndex = 11;
            this.Tijd.Text = "Tijd over: ";
            this.Tijd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox_BesteScores
            // 
            this.listBox_BesteScores.FormattingEnabled = true;
            this.listBox_BesteScores.ItemHeight = 16;
            this.listBox_BesteScores.Location = new System.Drawing.Point(670, 58);
            this.listBox_BesteScores.Name = "listBox_BesteScores";
            this.listBox_BesteScores.Size = new System.Drawing.Size(91, 196);
            this.listBox_BesteScores.TabIndex = 8;
            // 
            // label_BesteScores
            // 
            this.label_BesteScores.AutoSize = true;
            this.label_BesteScores.Location = new System.Drawing.Point(667, 26);
            this.label_BesteScores.Name = "label_BesteScores";
            this.label_BesteScores.Size = new System.Drawing.Size(94, 17);
            this.label_BesteScores.TabIndex = 13;
            this.label_BesteScores.Text = "Beste scores:";
            // 
            // label_BesteScore
            // 
            this.label_BesteScore.AutoSize = true;
            this.label_BesteScore.Location = new System.Drawing.Point(17, 34);
            this.label_BesteScore.Name = "label_BesteScore";
            this.label_BesteScore.Size = new System.Drawing.Size(46, 17);
            this.label_BesteScore.TabIndex = 9;
            this.label_BesteScore.Text = "label2";
            // 
            // label_GemiddeldeScore
            // 
            this.label_GemiddeldeScore.AutoSize = true;
            this.label_GemiddeldeScore.Location = new System.Drawing.Point(17, 99);
            this.label_GemiddeldeScore.Name = "label_GemiddeldeScore";
            this.label_GemiddeldeScore.Size = new System.Drawing.Size(46, 17);
            this.label_GemiddeldeScore.TabIndex = 10;
            this.label_GemiddeldeScore.Text = "label3";
            // 
            // label_VorigeScore
            // 
            this.label_VorigeScore.AutoSize = true;
            this.label_VorigeScore.Location = new System.Drawing.Point(17, 67);
            this.label_VorigeScore.Name = "label_VorigeScore";
            this.label_VorigeScore.Size = new System.Drawing.Size(46, 17);
            this.label_VorigeScore.TabIndex = 11;
            this.label_VorigeScore.Text = "label1";
            // 
            // Spel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_BesteScores);
            this.Controls.Add(this.Tijd);
            this.Controls.Add(this.listBox_BesteScores);
            this.Controls.Add(this.label_Fout);
            this.Controls.Add(this.label_Goed);
            this.Controls.Add(this.Antwoorden);
            this.Name = "Spel";
            this.Text = "Rekenspel";
            this.Load += new System.EventHandler(this.Spel_Load);
            this.Antwoorden.ResumeLayout(false);
            this.Antwoorden.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Antwoorden;
        private System.Windows.Forms.RadioButton Antwoord_Vier;
        private System.Windows.Forms.RadioButton Antwoord_Drie;
        private System.Windows.Forms.RadioButton Antwoord_Twee;
        private System.Windows.Forms.RadioButton Antwoord_Een;
        private System.Windows.Forms.Label label_Vraag;
        private System.Windows.Forms.Label Som;
        private System.Windows.Forms.Label label_Goed;
        private System.Windows.Forms.Label label_Fout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Tijd;
        private System.Windows.Forms.Label label_GemiddeldeScore;
        private System.Windows.Forms.Label label_BesteScore;
        private System.Windows.Forms.ListBox listBox_BesteScores;
        private System.Windows.Forms.Label label_BesteScores;
        private System.Windows.Forms.Label label_VorigeScore;
    }
}