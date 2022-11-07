namespace atletikaGUI
{
    partial class GUI
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
            this.AranyermetSzerzettNem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValaszVersenySzam = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValaszErmesHely = new System.Windows.Forms.NumericUpDown();
            this.Keres = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nevtext = new System.Windows.Forms.TextBox();
            this.eredmenytext = new System.Windows.Forms.TextBox();
            this.nemzettext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ValaszErmesHely)).BeginInit();
            this.SuspendLayout();
            // 
            // AranyermetSzerzettNem
            // 
            this.AranyermetSzerzettNem.FormattingEnabled = true;
            this.AranyermetSzerzettNem.ItemHeight = 18;
            this.AranyermetSzerzettNem.Location = new System.Drawing.Point(20, 25);
            this.AranyermetSzerzettNem.Name = "AranyermetSzerzettNem";
            this.AranyermetSzerzettNem.Size = new System.Drawing.Size(276, 454);
            this.AranyermetSzerzettNem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aranyérmet szerzett nemzetek:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Válassza ki a versenyszámot:";
            // 
            // ValaszVersenySzam
            // 
            this.ValaszVersenySzam.FormattingEnabled = true;
            this.ValaszVersenySzam.ItemHeight = 18;
            this.ValaszVersenySzam.Location = new System.Drawing.Point(421, 36);
            this.ValaszVersenySzam.Name = "ValaszVersenySzam";
            this.ValaszVersenySzam.Size = new System.Drawing.Size(254, 76);
            this.ValaszVersenySzam.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Válassza ki az érmes helyezést:";
            // 
            // ValaszErmesHely
            // 
            this.ValaszErmesHely.Location = new System.Drawing.Point(423, 177);
            this.ValaszErmesHely.Name = "ValaszErmesHely";
            this.ValaszErmesHely.Size = new System.Drawing.Size(46, 27);
            this.ValaszErmesHely.TabIndex = 5;
            // 
            // Keres
            // 
            this.Keres.Location = new System.Drawing.Point(480, 301);
            this.Keres.Name = "Keres";
            this.Keres.Size = new System.Drawing.Size(180, 57);
            this.Keres.TabIndex = 6;
            this.Keres.Text = "keresés";
            this.Keres.UseVisualStyleBackColor = false;
            this.Keres.Click += new System.EventHandler(this.Keres_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(345, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Versenyző adatai:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "neve:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "eredménye:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 499);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "nemzete:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // nevtext
            // 
            this.nevtext.Location = new System.Drawing.Point(442, 422);
            this.nevtext.Name = "nevtext";
            this.nevtext.Size = new System.Drawing.Size(108, 27);
            this.nevtext.TabIndex = 12;
            this.nevtext.Visible = false;
            // 
            // eredmenytext
            // 
            this.eredmenytext.Location = new System.Drawing.Point(442, 455);
            this.eredmenytext.Name = "eredmenytext";
            this.eredmenytext.Size = new System.Drawing.Size(108, 27);
            this.eredmenytext.TabIndex = 13;
            this.eredmenytext.Visible = false;
            // 
            // nemzettext
            // 
            this.nemzettext.Location = new System.Drawing.Point(442, 496);
            this.nemzettext.Name = "nemzettext";
            this.nemzettext.Size = new System.Drawing.Size(108, 27);
            this.nemzettext.TabIndex = 14;
            this.nemzettext.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "aranyos - nemzetek";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1640, 915);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nemzettext);
            this.Controls.Add(this.eredmenytext);
            this.Controls.Add(this.nevtext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Keres);
            this.Controls.Add(this.ValaszErmesHely);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValaszVersenySzam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AranyermetSzerzettNem);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GUI";
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ValaszErmesHely)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AranyermetSzerzettNem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ValaszVersenySzam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ValaszErmesHely;
        private System.Windows.Forms.Button Keres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nevtext;
        private System.Windows.Forms.TextBox eredmenytext;
        private System.Windows.Forms.TextBox nemzettext;
        private System.Windows.Forms.Button button1;
    }
}

