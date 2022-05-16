using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Joc
{
    class DataAcces
    {
        public List<Admin> GetAdmini()
        {
            using (IDbConnection connection= new System.Data.SqlClient.SqlConnection(Helper.CnnVal("JocDB")))
            {
                connection.Open();
                List<Admin> output = new List<Admin>();

                if (connection.State == ConnectionState.Open)
                {


                     output = connection.Query<Admin>($"select * from Admini").ToList();

                }
                    return output;
            }



          //  throw new NotImplementedException();
        }

        public DataTable getInExcel()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("JocDB")))
            {
                DataTable dt = new DataTable();
                connection.Open();
                DataTable output = new DataTable();

                if (connection.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("select * from Admini", new System.Data.SqlClient.SqlConnection(Helper.CnnVal("JocDB")));
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    
                    sda.Fill(dt);

                    

                     //output = connection.Query($"select * from Admini");

                }
                return dt;
            }

        }


        public List<Jucator> GetJucatori()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("JocDB")))
            {
                connection.Open();
                List<Jucator> output = new List<Jucator>();

                if(connection.State == ConnectionState.Open)
                {

                    output = connection.Query<Jucator>("dbo.Joc_GetMaxScorJucatori").ToList();
                }

                return output;
            }
        }

        public void stergeDate()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("JocDB")))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {

                    connection.Query<Jucator>("dbo.Joc_stergeJucatori");
                }

                return;
            }


        }

        public void introduJucator(string NumeJucator, int Scor)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("JocDB")))
            {
                connection.Open();

                if (connection.State == ConnectionState.Open)
                {
                    List<Jucator> jc = new List<Jucator>();
                    jc.Add(new Jucator { numeJucator = NumeJucator, scor = Scor });

                    connection.Execute("dbo.Joc_introduJucator @numeJucator, @scor", new {NumeJucator, Scor});
                }

                return;
            }
        }



    }
}
