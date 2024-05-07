namespace Final_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            this.S = new System.Windows.Forms.Label();
            this.CD = new System.Windows.Forms.Label();
            this.CN = new System.Windows.Forms.Label();
            this.ECTS = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.btn_Add_another = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "-Student ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "-Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "-Surname";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "-Course Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "-Course Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "-ECTS Credit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "-Letter Grade";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.college_icon_png_01;
            this.pictureBox1.Location = new System.Drawing.Point(373, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(332, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 30);
            this.label9.TabIndex = 9;
            this.label9.Text = "The New Course Information";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(167, 133);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 30);
            this.ID.TabIndex = 10;
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.N.Location = new System.Drawing.Point(167, 184);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(0, 30);
            this.N.TabIndex = 11;
            this.N.Click += new System.EventHandler(this.N_Click);
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S.Location = new System.Drawing.Point(167, 220);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(0, 30);
            this.S.TabIndex = 12;
            // 
            // CD
            // 
            this.CD.AutoSize = true;
            this.CD.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CD.Location = new System.Drawing.Point(167, 254);
            this.CD.Name = "CD";
            this.CD.Size = new System.Drawing.Size(0, 30);
            this.CD.TabIndex = 13;
            // 
            // CN
            // 
            this.CN.AutoSize = true;
            this.CN.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CN.Location = new System.Drawing.Point(167, 288);
            this.CN.Name = "CN";
            this.CN.Size = new System.Drawing.Size(0, 30);
            this.CN.TabIndex = 14;
            // 
            // ECTS
            // 
            this.ECTS.AutoSize = true;
            this.ECTS.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ECTS.Location = new System.Drawing.Point(167, 341);
            this.ECTS.Name = "ECTS";
            this.ECTS.Size = new System.Drawing.Size(0, 30);
            this.ECTS.TabIndex = 15;
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L.Location = new System.Drawing.Point(167, 406);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(0, 30);
            this.L.TabIndex = 16;
            // 
            // btn_Add_another
            // 
            this.btn_Add_another.BackColor = System.Drawing.Color.Black;
            this.btn_Add_another.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_another.ForeColor = System.Drawing.Color.White;
            this.btn_Add_another.Location = new System.Drawing.Point(667, 338);
            this.btn_Add_another.Name = "btn_Add_another";
            this.btn_Add_another.Size = new System.Drawing.Size(217, 40);
            this.btn_Add_another.TabIndex = 17;
            this.btn_Add_another.Text = "Add Another Course";
            this.btn_Add_another.UseVisualStyleBackColor = false;
            this.btn_Add_another.Click += new System.EventHandler(this.btn_Add_another_Click);
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Green;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(667, 379);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(217, 40);
            this.btn_print.TabIndex = 18;
            this.btn_print.Text = "Print Information";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(667, 421);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(217, 40);
            this.btn_close.TabIndex = 19;
            this.btn_close.Text = "Finish";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(-1, 423);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 34);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "<< Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "-Semester";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 25);
            this.label10.TabIndex = 22;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_Add_another);
            this.Controls.Add(this.L);
            this.Controls.Add(this.ECTS);
            this.Controls.Add(this.CN);
            this.Controls.Add(this.CD);
            this.Controls.Add(this.S);
            this.Controls.Add(this.N);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "ACA";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Move += new System.EventHandler(this.Form3_Move);
            this.Resize += new System.EventHandler(this.Form3_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label9;
        private Label ID;
        private Label N;
        private Label S;
        private Label CD;
        private Label CN;
        private Label ECTS;
        private Label L;
        private Button btn_Add_another;
        private Button btn_print;
        private Button btn_close;
        private Button btn_back;
        private Label label8;
        private Label label10;
    }
}