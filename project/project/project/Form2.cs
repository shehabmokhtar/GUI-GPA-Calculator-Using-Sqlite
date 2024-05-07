using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form2 : Form
    {
        public SQLiteConnection Connection_Data_2;


        public Form2()
        {
            InitializeComponent();
        }


        public void Connect_data()
        {
            Connection_Data_2 = new SQLiteConnection("Data Source=D:\\101010\\Database\\Courses.db");
            Connection_Data_2.Open();
        }

    
        public void set_R_L_2()
        {
            this.Size = new Size(900, 500);

            int X2 = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int Y2 = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(X2, Y2);
        }



        private void Form2_Move(object sender, EventArgs e)
        {
            set_R_L_2();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            set_R_L_2();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();

            // Hide Form2 & Back to Form1
        }

        private void txt_ECTS_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Close();

            this.Close();
        }

        private void btn_add_new_course_Click(object sender, EventArgs e)
        {
            Connect_data();
            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = "INSERT INTO Courses (Course_Code,Course_Name,ECTS_Credit,Letter_Grade,Semester,GPA,) " +
                "VALUES (@Course_Code,@Course_Name,@ECTS_Credit,@Letter_Grade,@Semester,@GPA)";
            command.Connection = Connection_Data_2;
            command.Parameters.AddWithValue("@Course_Code",txt_course_code.Text);
            command.Parameters.AddWithValue("@Course_Name",txt_course_name.Text);
            command.Parameters.AddWithValue("@ECTS_Credit",txt_ECTS.Text);
            command.Parameters.AddWithValue("@Letter_Grade",cbx_letter_grade.Text);
            command.Parameters.AddWithValue("@Semester",cbx_Semester.Text);
            command.Parameters.AddWithValue("@GPA",txt_GPA.Text);
            command.ExecuteNonQuery();
            Connection_Data_2.Close();

        }

        private void btn_delete_course_Click(object sender, EventArgs e)
        {
            Connect_data();

            string delete_Course_code = txt_course_code.Text;
            string delete_Course_Name = txt_course_name.Text;
            string delete_subject = delete_Course_code + delete_Course_Name;
        
          
            SQLiteCommand SQLiteCmd = new SQLiteCommand();
            SQLiteCmd.CommandText = "Delete from Course where Name='" + delete_subject + "'";
            SQLiteCmd.Connection = Connection_Data_2;

            SQLiteCmd.ExecuteNonQuery();


        }

        private void btn_display_Click(object sender, EventArgs e)
        {
           

            Form3 F3 = new Form3();
            F3.Show();
            



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
