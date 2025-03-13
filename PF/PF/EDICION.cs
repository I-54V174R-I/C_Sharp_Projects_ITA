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
    public partial class EDICION : Form
    {
        SqlConnection con;
        String sql;
        DataSet ds;
        SqlDataReader dr;
        SqlCommand com;
        public EDICION()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cambio();
        }
        void zonas()
        {
            DataTable dt = new DataTable();
            try
            {
                conexionNorte();
                ZONAAA.Items.Clear();
                sql = "select Nombre from ZONA";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ZONAAA.Items.Add(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("INTENTAR CONECTAR CON BASE DE DATOS CENTRO");
                zonas2();
            }
        }
        void zonas2()
        {
            DataTable dt = new DataTable();
            try
            {
                dr.Close();
                conexionCentro();
                ZONAAA.Items.Clear();
                sql = "select Nombre from ZONA";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ZONAAA.Items.Add(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("INTENTAR CONECTAR CON BASE DE DATOS SUR");
                zonas3();
            }
        }
        void zonas3()
        {
            try
            {
                dr.Close();
                conexionSur();
                ZONAAA.Items.Clear();
                sql = "select Nombre from ZONA";
                com = new SqlCommand(sql, con);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ZONAAA.Items.Add(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO HAY CONEXION");
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////
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

        private void EDICION_Load(object sender, EventArgs e)
        {
            zonas();
            ZONAAA.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        /////////////////////////////////////////////////////
        void cambio()
        {
            String b="";
            dr.Close();
            sql = "SELECT Nombre from	CLIENTE where id=" + ID.Text;
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();
            if (dr.Read())
            b = dr["Nombre"].ToString();
            if (b.Length == 0)
            {
                MessageBox.Show("ID NO EXISTENTE");
            }
            else
            {
                try
                {
                    dr.Close();
                    sql = "update CLIENTE SET Nombre = '" + NOM.Text + "' WHERE id=" + ID.Text;
                    com = new SqlCommand(sql, con);
                    int a = com.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("EDITADO");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HA OCURRIDO UN ERROR");
                }
            }
        }

        private void ZONAAA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ZONAAA.Text.Equals("NORTE"))
            {
                conexionNorte();
            }
            if (ZONAAA.Text.Equals("CENTRO"))
            {
                conexionCentro();
            }
            if (ZONAAA.Text.Equals("SUR"))
            {
                conexionSur();
            }
        }
    }
}
