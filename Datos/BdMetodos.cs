using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using interfaces;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Datos
{
     public class BdMetodos : iBdMetodos
    {
         //comment 

         SqlConnection cnn;
         //string usuario = "vicente";
         //string con = "vicente";
         //string based = "Parcial3";
         //string server = "VICEN-PC\\SQLEXPRESS";
         //////tocar estos datoooooooooooooooooooooooooooooooooooooooooooooooooooooos

         //string usuario = "pelad0";
         //string con = "admin";
         //string based = "Fenix";
         //string server = "NO";

         //string usuario = "LaboIII";
         //string con = "1234";
         //string based = "ParcialLabo4";
         //string server = "MARIANO\\SQLEXPRESS";


        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        public string Based
        {
            get { return based; }
            set { based = value; }
        }
        public string Con
        {
            get { return con; }
            set { con = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        string strcnn;
        public BdMetodos()
        {
            cnn = new SqlConnection();
            cnn.ConnectionString = conectionstring();
        }
        SqlTransaction transac = null;

        public string conectionstring()
        {
            strcnn = "Data Source=" + server + ";Initial Catalog=" + based + ";User ID=" + usuario + ";" + "Password=" + con;
            return strcnn;
        }
        //
        public int ejecutar(String sql)
        {
            int res = -1;
            SqlCommand comand = new SqlCommand();

            try
            {
                comand.Connection = getConection();
                transac = cnn.BeginTransaction();
                comand.Transaction = transac;
                comand.CommandType = System.Data.CommandType.Text;
                comand.CommandText = sql;
                res = Convert.ToInt32(comand.ExecuteScalar());
                transac.Commit();

            }
            catch (SqlException ex)
            {
                transac.Rollback();
                throw ex;
            }
            finally
            {
                cnn.Close();

            }

            return res;

        }

        public DataTable consultar(String sql)
        {
            DataTable dt = new DataTable();
            SqlCommand comand = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();

            try
            {
                comand.Connection = getConection();

                transac = cnn.BeginTransaction();
                comand.Transaction = transac;


                comand.CommandType = System.Data.CommandType.Text;
                comand.CommandText = sql;
                adapter.SelectCommand = comand;
                adapter.Fill(dt);
                transac.Commit();
            }
            catch (SqlException ex)
            {
                transac.Rollback();
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
            return dt;
        }

        public DataTable Consultar(string sp, SqlParameter[] datos)
        {
            DataTable dt = new DataTable();
            SqlCommand comand = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {



                comand.Connection = getConection();
                transac = cnn.BeginTransaction();
                comand.Transaction = transac;



                comand.CommandType = CommandType.StoredProcedure;

                comand.CommandText = sp;
                comand.Parameters.AddRange(datos);

                da.SelectCommand = comand;
                da.Fill(dt);

                transac.Commit();

            }
            catch (Exception ex)
            {
                transac.Rollback();
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return dt;

        }
        //
        public SqlConnection getConection()
        {
            try
            {
                cnn.Open();
                return cnn;
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }


        public int Ejecutar(string sp, SqlParameter[] datos)
        {
            SqlCommand comand = new SqlCommand();

            int res = -1;

            try
            {

                comand.Connection = getConection();
                transac = cnn.BeginTransaction();
                comand.Transaction = transac;




                comand.CommandType = CommandType.StoredProcedure;

                comand.CommandText = sp;
                comand.Parameters.AddRange(datos);

                res = Convert.ToInt32(comand.ExecuteScalar());
                transac.Commit();


            }
            catch (Exception ex)
            {
                transac.Rollback();
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return res;

        }
    }
}
