namespace Final_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_letter_grade = new System.Windows.Forms.ComboBox();
            this.txt_ECTS = new System.Windows.Forms.TextBox();
            this.txt_GPA = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_add_new_course = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_delete_course = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Course_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_course_code = new System.Windows.Forms.TextBox();
            this.txt_course_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Semester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.college_icon_png_0;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "ECTS Credit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Letter Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "GPA";
            // 
            // cbx_letter_grade
            // 
            this.cbx_letter_grade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_letter_grade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_letter_grade.BackColor = System.Drawing.Color.Black;
            this.cbx_letter_grade.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_letter_grade.ForeColor = System.Drawing.Color.White;
            this.cbx_letter_grade.FormattingEnabled = true;
            this.cbx_letter_grade.Items.AddRange(new object[] {
            "AA",
            "BA",
            "BB",
            "CB",
            "CC",
            "DC",
            "DD",
            "FD",
            "FF"});
            this.cbx_letter_grade.Location = new System.Drawing.Point(152, 259);
            this.cbx_letter_grade.Name = "cbx_letter_grade";
            this.cbx_letter_grade.Size = new System.Drawing.Size(161, 38);
            this.cbx_letter_grade.TabIndex = 8;
            // 
            // txt_ECTS
            // 
            this.txt_ECTS.BackColor = System.Drawing.Color.Black;
            this.txt_ECTS.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ECTS.ForeColor = System.Drawing.Color.White;
            this.txt_ECTS.Location = new System.Drawing.Point(152, 205);
            this.txt_ECTS.Name = "txt_ECTS";
            this.txt_ECTS.Size = new System.Drawing.Size(161, 37);
            this.txt_ECTS.TabIndex = 9;
            this.txt_ECTS.TextChanged += new System.EventHandler(this.txt_ECTS_TextChanged);
            // 
            // txt_GPA
            // 
            this.txt_GPA.BackColor = System.Drawing.Color.Black;
            this.txt_GPA.Font = new System.Drawing.Font("Andalus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_GPA.ForeColor = System.Drawing.Color.White;
            this.txt_GPA.Location = new System.Drawing.Point(152, 353);
            this.txt_GPA.Name = "txt_GPA";
            this.txt_GPA.Size = new System.Drawing.Size(161, 37);
            this.txt_GPA.TabIndex = 10;
            this.txt_GPA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(-1, 425);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(122, 34);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "<< Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_add_new_course
            // 
            this.btn_add_new_course.BackColor = System.Drawing.Color.Black;
            this.btn_add_new_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_new_course.ForeColor = System.Drawing.Color.White;
            this.btn_add_new_course.Location = new System.Drawing.Point(680, 300);
            this.btn_add_new_course.Name = "btn_add_new_course";
            this.btn_add_new_course.Size = new System.Drawing.Size(204, 37);
            this.btn_add_new_course.TabIndex = 12;
            this.btn_add_new_course.Text = "Add";
            this.btn_add_new_course.UseVisualStyleBackColor = false;
            this.btn_add_new_course.Click += new System.EventHandler(this.btn_add_new_course_Click);
            // 
            // btn_display
            // 
            this.btn_display.BackColor = System.Drawing.Color.Black;
            this.btn_display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_display.ForeColor = System.Drawing.Color.White;
            this.btn_display.Location = new System.Drawing.Point(680, 342);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(204, 37);
            this.btn_display.TabIndex = 13;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = false;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_delete_course
            // 
            this.btn_delete_course.BackColor = System.Drawing.Color.Black;
            this.btn_delete_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_course.ForeColor = System.Drawing.Color.White;
            this.btn_delete_course.Location = new System.Drawing.Point(680, 382);
            this.btn_delete_course.Name = "btn_delete_course";
            this.btn_delete_course.Size = new System.Drawing.Size(204, 37);
            this.btn_delete_course.TabIndex = 14;
            this.btn_delete_course.Text = "Delete Course";
            this.btn_delete_course.UseVisualStyleBackColor = false;
            this.btn_delete_course.Click += new System.EventHandler(this.btn_delete_course_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(797, 425);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(89, 34);
            this.btn_Close.TabIndex = 15;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course_code,
            this.Course_Name,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.CGPA});
            this.dataGridView1.Location = new System.Drawing.Point(326, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(558, 289);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Course_code
            // 
            this.Course_code.HeaderText = "Course Code";
            this.Course_code.Name = "Course_code";
            // 
            // Course_Name
            // 
            this.Course_Name.HeaderText = "Course Name";
            this.Course_Name.Name = "Course_Name";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ECTS Credit";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Letter Grade";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Semester";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "GPA";
            this.Column6.Name = "Column6";
            // 
            // CGPA
            // 
            this.CGPA.HeaderText = "CGPA";
            this.CGPA.Name = "CGPA";
            // 
            // txt_course_code
            // 
            this.txt_course_code.BackColor = System.Drawing.Color.Black;
            this.txt_course_code.ForeColor = System.Drawing.Color.White;
            this.txt_course_code.Location = new System.Drawing.Point(152, 103);
            this.txt_course_code.Name = "txt_course_code";
            this.txt_course_code.Size = new System.Drawing.Size(161, 33);
            this.txt_course_code.TabIndex = 17;
            // 
            // txt_course_name
            // 
            this.txt_course_name.BackColor = System.Drawing.Color.Black;
            this.txt_course_name.ForeColor = System.Drawing.Color.White;
            this.txt_course_name.Location = new System.Drawing.Point(152, 152);
            this.txt_course_name.Name = "txt_course_name";
            this.txt_course_name.Size = new System.Drawing.Size(161, 33);
            this.txt_course_name.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Semester";
            // 
            // cbx_Semester
            // 
            this.cbx_Semester.BackColor = System.Drawing.Color.Black;
            this.cbx_Semester.ForeColor = System.Drawing.Color.White;
            this.cbx_Semester.FormattingEnabled = true;
            this.cbx_Semester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbx_Semester.Location = new System.Drawing.Point(152, 309);
            this.cbx_Semester.Name = "cbx_Semester";
            this.cbx_Semester.Size = new System.Drawing.Size(161, 33);
            this.cbx_Semester.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.cbx_Semester);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_course_name);
            this.Controls.Add(this.txt_course_code);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_delete_course);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_add_new_course);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_GPA);
            this.Controls.Add(this.txt_ECTS);
            this.Controls.Add(this.cbx_letter_grade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "ACA";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Move += new System.EventHandler(this.Form2_Move);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbx_letter_grade;
        private TextBox txt_ECTS;
        private TextBox txt_GPA;
        private Button btn_back;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_add_new_course;
        private Button btn_display;
        private Button btn_delete_course;
        private Button btn_Close;
        private DataGridView dataGridView1;
        private TextBox txt_course_code;
        private TextBox txt_course_name;
        private Label label6;
        private ComboBox cbx_Semester;
        private DataGridViewTextBoxColumn Course_code;
        private DataGridViewTextBoxColumn Course_Name;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn CGPA;
    }
}