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
    public partial class INSERTAR : Form
    {
        SqlConnection con;
        String sql;
        DataSet ds;
        SqlDataReader dr;
        SqlCommand com;
        DataTable dt;

        public INSERTAR()
        {
            InitializeComponent();
        }

        private void INSERTAR_Load(object sender, EventArgs e)
        {
            zonas();
            ZONAAA.DropDownStyle = ComboBoxStyle.DropDownList;
            EDO.DropDownStyle = ComboBoxStyle.DropDownList;
            COL.DropDownStyle = ComboBoxStyle.DropDownList;
            CALL.DropDownStyle = ComboBoxStyle.DropDownList;
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
        private void ZONAAA_SelectedIndexChanged(object sender, EventArgs e)
        {
            COL.Items.Clear();
            COL.Visible = false;
            CALL.Items.Clear();
            CALL.Visible = false;
            EDO.Text = "";
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
            EDO.Items.Clear();
            dr.Close();
            sql = "select Estado from ESTADO ORDER BY Estado";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                EDO.Items.Add(dr[0].ToString());
            }
            EDO.Visible = true;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void EDO_SelectedIndexChanged(object sender, EventArgs e)
        {
            CALL.Items.Clear();
            CALL.Visible = false;
            COL.Items.Clear();
            dr.Close();
            COL.Text = "";
            sql = "SELECT COLONIA.Colonia FROM COLONIA, ESTADO WHERE Colonia.Estado=ESTADO.id and ESTADO.Estado='" + EDO.Text+ "'";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                COL.Items.Add(dr[0].ToString());
            }
            COL.Visible = true;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void COL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CALL.Items.Clear();
            dr.Close();
            sql = "SELECT CALLE.Calle FROM CALLE, COLONIA WHERE COLONIA.id=CALLE.Colonia AND COLONIA.Colonia='" + COL.Text + "'";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                CALL.Items.Add(dr[0].ToString());
            }
            CALL.Visible = true;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void CALL_SelectedIndexChanged(object sender, EventArgs e)
        {
            dr.Close();
            sql = "SELECT id FROM CALLE WHERE Calle='" + CALL.Text + "'";
            com = new SqlCommand(sql, con);
            dr = com.ExecuteReader();
            if(dr.Read())
            IDCALL.Text = dr["id"].ToString();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            if(NOM.Text.Length>0 && MAIL.Text.Length > 0 && TEL.Text.Length>0)
            {
                try
                {
                    dr.Close();
                    sql = "INSERT INTO CLIENTE (Nombre, Correo, Telefono, Calle, num) VALUES('" + NOM.Text + "', '" + MAIL.Text + "', '" + TEL.Text + "', " + IDCALL.Text + ", " + NUM.Value + ");";
                    
                    com = new SqlCommand(sql, con);
                    int a = com.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("INSERTADO");
                    }
                    EDO.Items.Clear();
                    EDO.Text = "";
                    ZONAAA.Items.Clear();
                    ZONAAA.Text = "";
                    COL.Items.Clear();
                    COL.Text = "";
                    CALL.Items.Clear();
                    CALL.Text = "";
                    NOM.Text = "";
                    MAIL.Text = "";
                    TEL.Text = "";
                    IDCALL.Text = "";
                    NUM.Value = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("OCURRIO UN ERROR");
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
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
