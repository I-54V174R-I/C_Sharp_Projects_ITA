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
    public partial class CONSULTA_2 : Form
    {
        SqlConnection con;
        String sql, sql1, sql2;
        SqlDataAdapter da, da1, da2;
        DataSet ds;
        public CONSULTA_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
        }

        void cargar()
        {
            DataTable dt = new DataTable();
            sql = "select  CLIENTE.id, CLIENTE.Nombre, CLIENTE.Correo, CLIENTE.Telefono, CALLE.Calle, CLIENTE.num, COLONIA.Colonia, ESTADO.Estado from CLIENTE, CALLE, COLONIA, ESTADO WHERE CLIENTE.Calle = CALLE.id AND CALLE.Colonia = COLONIA.id AND COLONIA.Estado = ESTADO.id; ";
            sql1 = sql;
            sql2 = sql;

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
                con = new SqlConnection("Data Source =.; Initial Catalog = Norte; Integrated Security = True");
                con.Open();
            }
            catch (Exception ex)
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
    }
}
