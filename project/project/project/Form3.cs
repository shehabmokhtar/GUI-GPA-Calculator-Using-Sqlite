using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void set_R_L_3()
        {
            this.Size = new Size(900, 500);

            int X3 = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int Y3 = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(X3, Y3);
        }

        private void Form3_Move(object sender, EventArgs e)
        {
            set_R_L_3();
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            set_R_L_3();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void N_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Program Will Print The Course Information");
        }

        private void btn_Add_another_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Add a new course");

            Form1 F1 = new Form1();
            F1.Show();
             
            this.Close();




        }

        private void ID_Click(object sender, EventArgs e)
        {
        
          
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good Luck");
            
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form2 F2=new Form2();
            F2.Show();
            this.Close();
        }
    }
}
