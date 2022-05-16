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

using System.Data.Sql;

namespace Joc
{
    
    public partial class FormInregistrare : Form
    {
        List<Admin> admini = new List<Admin>();

        public static bool conectareAdmin= false;


        private static string nume="";

         static public string getNume()
        {
            return nume;
        }
        


        public FormInregistrare()
        {
            InitializeComponent();

            labelErrorAdmin.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 1)
            {
            List<Jucator> jc = new List<Jucator>();
            DataAcces da = new DataAcces();
                jc = da.GetJucatori();
                if (numeJucator.Text == "")
                {
                    labelError.Text = "Numele trebuie să conțină caractere!";
                    labelError.ForeColor = Color.Red;
                }
                else if (numeJucator.Text.Contains(' '))
                {
                    labelError.Text = "Numele nu trebuie să conțină spații!";
                    labelError.ForeColor = Color.Red;

                }
                else
                {

                    if (jc.Count == 0)
                    {
                        nume = numeJucator.Text;
                        this.Hide();
                        Form1 joc = new Form1();
                        joc.ShowDialog();
                        this.Close();
                    }

                    bool notOk = false;
                    foreach (Jucator line in jc)
                    {
                      //  int index = line.numeJucator;
                        string numele = line.numeJucator;
                        if (numele.Equals(numeJucator.Text))
                        {
                            labelError.Text = "Exista deja asa un jucator";
                            labelError.ForeColor = Color.Red;
                            notOk = true;
                        }
                    }

                    if (!notOk)
                    {
                        nume = numeJucator.Text;
                        this.Hide();
                        Form1 joc = new Form1();
                        joc.ShowDialog();
                        this.Close();
                    }

                }
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                DataAcces db = new DataAcces();
                admini = db.GetAdmini();

                Admin user = new Admin();
                user.username = textBoxAdminNume.Text;
                user.parola = textBoxAdminParola.Text;

              //  bool conectareAdminReusita = false;

                foreach(Admin a in admini)
                {
                    if(a.username == user.username &&a.parola == user.parola)
                    {
                        conectareAdmin = true; break;
                    }
                }

                if (conectareAdmin)
                {
                    this.Hide();
                    Form1 joc = new Form1();
                    joc.ShowDialog();
                    this.Close();
                }
                else
                {
                    labelErrorAdmin.Text = "Ai introdus date incorecte!!!";
                    labelErrorAdmin.ForeColor = Color.Red;
                    textBoxAdminNume.Text = "";
                    textBoxAdminParola.Text = "";

                }



            }
        }

        

        private void FormInregistrare_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        private void labelError_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                //Dezactivare
                numeJucator.Enabled = false;
                numeJucator.Visible= false;
                labelJucatorNume.Visible = false;
                labelError.Visible = false;

                //Activare
                labelAdminNume.Visible = true;
                labelAdminParol.Visible = true;
                textBoxAdminNume.Enabled = true;
                textBoxAdminNume.Visible = true;
                textBoxAdminParola.Enabled= true;
                textBoxAdminParola.Visible = true;
                labelErrorAdmin.Visible = true;
                labelErrorAdmin.Text = "";

            }
            else if(comboBox1.SelectedIndex == 1)
            {
                //Dezactivare
                labelAdminNume.Visible = false;
                labelAdminParol.Visible = false;
                textBoxAdminNume.Enabled = false;
                textBoxAdminNume.Visible = false;
                textBoxAdminParola.Enabled = false;
                textBoxAdminParola.Visible = false;
                labelErrorAdmin.Visible = false;

                //Activare
                numeJucator.Enabled = true;
                numeJucator.Visible = true;
                labelJucatorNume.Visible = true;
                labelError.Visible =true;


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAdminNume_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
