using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Joc
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 joaca = new Form2();
            this.Hide();
            joaca.ShowDialog();
            this.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 setari = new Form3();
            this.Hide();
            setari.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //   FormInregistrare inregistrare = new FormInregistrare();
            // inregistrare.ShowDialog();
            if (FormInregistrare.conectareAdmin == false)
            {
                textBoxNume.Text = FormInregistrare.getNume();
                buttonDate.Enabled = false;
                buttonDate.Visible = false;
            }
            else {
                textBoxNume.Text = "Admin";

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
             sd
            sada
            asd
             */
        }

        private void SetareJucator(object sender, FormClosingEventArgs e)
        {
            
            int s_scor = Form2.getScor();

            if (s_scor > 0)
            {
                //string informatie = FormInregistrare.getNume();
                //informatie += ' ';
               // informatie += s_scor.ToString();
               // informatie += '\n';
               // File.AppendAllText(@"C:\\Users\\Octav\\source\\repos\\Joc\Joc\\Jucatori.txt", informatie);
                DataAcces da = new DataAcces();
                da.introduJucator(FormInregistrare.getNume(), s_scor);
            }

        }



        private void buttonDate_Click(object sender, EventArgs e)
        {
            FormDateAdmin datee = new FormDateAdmin();
            this.Hide();
            datee.ShowDialog();
            this.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form5 backF = new Form5();
            this.Hide();
            backF.ShowDialog();
            this.Show();
        }
    }


}
