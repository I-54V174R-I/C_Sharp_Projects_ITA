using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace PF
{
    public partial class CONSULTA_1 : Form
    {
        SqlConnection con;
        String sql, sql1, sql2;
        SqlDataAdapter da, da1, da2;
        DataSet ds;

        public CONSULTA_1()
        {
            InitializeComponent();
        }

        void cargar()
        {
            DataTable dt = new DataTable();
            sql = "select ESTADO.Estado, ZONA.Nombre  from ESTADO, ZONA WHERE ZONA.id=ESTADO.Zona;";
            sql1 = "select ESTADO.Estado, ZONA.Nombre  from ESTADO, ZONA WHERE ZONA.id=ESTADO.Zona;";
            sql2 = "select ESTADO.Estado, ZONA.Nombre  from ESTADO, ZONA WHERE ZONA.id=ESTADO.Zona;";

            if (checkBox1.Checked)
            {
                conexionNorte();
                da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
            }

            if (checkBox2.Checked)
            {
                conexionCentro();
                da1 = new SqlDataAdapter(sql1, con);
                da1.Fill(dt);
            }

            if (checkBox3.Checked)
            {
                conexionSur();
                da2 = new SqlDataAdapter(sql2, con);
                da2.Fill(dt);
            }

            tabla.DataSource = dt;
        }
        void conexionNorte()
        {
            try
            {
                con= new SqlConnection("Data Source =.; Initial Catalog = Norte; Integrated Security = True");
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR AL CONECTAR CON BASE DE DATOS DEL NORTE");
            }
        }
        void conexionCentro()
        {
            try
            {
                con = new SqlConnection("Data Source =.; Initial Catalog = Centro; Integrated Security = True");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CONECTAR CON BASE DE DATOS DEL CENTRO");
            }
        }
        void conexionSur()
        {
            try
            {
                con = new SqlConnection("Data Source =.; Initial Catalog = Sur; Integrated Security = True");
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CONECTAR CON BASE DE DATOS DEL Sur");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}