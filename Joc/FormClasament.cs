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
    public partial class FormClasament : Form
    {
        public FormClasament()
        {
            InitializeComponent();
        }

        private void FormClasament_Load(object sender, EventArgs e)
        {
            ScorMaxim.Text = Form2.getScor().ToString();
            listJucatori.Items.Clear();
            Dictionary<string, int> informatii = new Dictionary<string, int>();
            foreach (string line in File.ReadLines(@"C:\\Users\\Octav\\source\\repos\\Joc\Joc\\Jucatori.txt"))
            {
                string[] bits = line.Split(' ');
                informatii.Add(bits[0], int.Parse(bits[1]));
            }

            var lista = informatii.ToList();
            lista.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
            int i = 1;
            foreach(var a in lista)
            {
                listJucatori.Items.Add(i.ToString()+'.'+' '+a);
                i++;
            }
        
    }
    }
}
