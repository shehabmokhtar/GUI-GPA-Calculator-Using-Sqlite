using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace Final_Project
{
    public partial class Form1 : Form
    {

        public SQLiteConnection Connection_Data ;


        public Form1()
        {
            InitializeComponent();
        }

        public void Connect_data()
        {
            Connection_Data = new SQLiteConnection("Data Source =D:\\101010\\Database\\Courses_Main.db");
            Connection_Data.Open();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
                
        }

        public void set_R_L_1()
        {
            this.Size = new Size(900, 500);

            int X1 = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int Y2 = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(X1, Y2);
        }



        private void Courses_Resize(object sender, EventArgs e)
        {
            set_R_L_1();

        }

        private void Courses_Move(object sender, EventArgs e)
        {
            set_R_L_1();

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

      

        private void btn_Add_Courses_Click(object sender, EventArgs e)
        {

            Form2 F2 = new Form2();
            F2.ShowDialog();
            this.Close();
            // Hide Form1 & Go to Form2

            //---------------------------------------------------------------------------------------------------------//

            Connect_data();
            SQLiteCommand command = new SQLiteCommand();
            command.CommandText = "INSERT INTO Course_Main ( ID , Name , Surname ) VALUES ( @ID , @Name , @Surname )";
            command.Connection = Connection_Data;
            command.Parameters.AddWithValue("@ID", textBox1.Text);
            command.Parameters.AddWithValue("@Name", textBox2.Text);
            command.Parameters.AddWithValue("@Surname", textBox3.Text);
            command.ExecuteNonQuery();
            Connection_Data.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}