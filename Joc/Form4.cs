using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using ClosedXML;
using Microsoft.Office.Interop.Excel;

namespace Joc
{
    public partial class FormDateAdmin : Form
    {

        List<Jucator> jucatori = new List<Jucator>();
        public FormDateAdmin()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddIndexes()
        {
            int id = 1;
            for (int i= 0;i < jucatori.Count;i++)
            {
                jucatori[i].id = id;
                id++;
            }
           return;
        }

        private void FormDateAdmin_Load(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();
            jucatori = db.GetJucatori();
            AddIndexes();

            List<string[]> rows = new List<string[]>();
            foreach(Jucator j in jucatori)
            {
                string[] aux = { j.id.ToString(), j.numeJucator, j.scor.ToString() };
                rows.Add(aux);
            }

            for(int i = 0; i<rows.Count; i++)
            {
                var listViewItem = new ListViewItem(rows[i]);
                listViewDate.Items.Add(listViewItem);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAcces db = new DataAcces();
            db.stergeDate();
            this.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Terifiantul";
                    ws.Cells[2, 2] = "Clasamentul jucatorilor";
                    ws.Cells[3, 1] = "Nr/o";
                    ws.Cells[3, 2] = "Nume jucator";
                    ws.Cells[3, 3] = "Scor";


                    DataAcces da = new DataAcces();
                    List<Jucator> juc = da.GetJucatori();
                    int i = 4;
                    foreach (Jucator j in juc)
                    {
                        ws.Cells[i, 1] = (i-3).ToString();
                        ws.Cells[i, 2] = j.numeJucator;
                        ws.Cells[i, 3] = j.scor.ToString();
                        i++;
                    }
                    i++;
                    ws.Cells[i, 1] = "Data";
                   
                    ws.Cells[i, 2] = DateTime.Today.ToString("dd.MM.yyyy");
                    ws.Cells[i+2, 1] = "Semnatura";
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, (XlSaveAsAccessMode)XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    MessageBox.Show("Bravo");
                }
            }

        }

        private void listViewDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
