using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDI
{
    public partial class Form2 : Form
    {
        private string sql;
        private MiConexion Conexion = new MiConexion();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            llenarComboGeneros();
            llenarComboPeliculas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Padre.f1.Activate();
        }

        private void contarSin_Click(object sender, EventArgs e)
        {
            sql = "SELECT COUNT(*) FROM [Peliculas] WHERE CodGenero = " + tbCodGenero.Text;
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            labelResultadoContar.Text = cmd.ExecuteScalar().ToString();
            Conexion.CerrarConexion();
        }

        private void contarCon_Click(object sender, EventArgs e)
        {
            sql = "SELECT COUNT(*) FROM [Peliculas] WHERE CodGenero = @genero";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            cmd.Parameters.Add("@genero", SqlDbType.Int).Value = tbCodGenero.Text;
            Conexion.AbrirConexion();
            labelResultadoContar.Text = cmd.ExecuteScalar().ToString();
            Conexion.CerrarConexion();
        }

        private void insertarSin_Click(object sender, EventArgs e)
        {
            try
            {
                int pelicula = maximoPeliculas();
                sql = "INSERT INTO [Peliculas] (CodPelicula, Titulo, Duración, CodGenero, Año, Productora, Pais, Precio, Director) VALUES (" + pelicula + ", '" + tbTitulo.Text + "', " + tbDuracion.Text + ", " + (comboBox1.SelectedIndex + 1) + ", " + tbAno.Text + ", '" + tbProductora.Text + "', '" + tbPais.Text + "', " + tbPrecio.Text + ", '" + tbDirector.Text + "');";
                SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
                Conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                Conexion.CerrarConexion();
                labelResultadoInsertar.Text = "Éxito";
            }
            catch (Exception)
            {
                labelResultadoInsertar.Text = "Fallido";
            }
        }

        private void insertarCon_Click(object sender, EventArgs e)
        {
            try
            {
                int pelicula = maximoPeliculas();
                sql = "INSERT INTO [Peliculas] (CodPelicula, Titulo, Duración, CodGenero, Año, Productora, Pais, Precio, Director) VALUES (@codPelicula, @titulo, @duracion, @codGenero, @ano, @productora, @pais, @precio, @director);";
                SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
                cmd.Parameters.Add("@codPelicula", SqlDbType.Int).Value = pelicula;
                cmd.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = tbTitulo.Text;
                cmd.Parameters.Add("@duracion", SqlDbType.Int).Value = tbDuracion.Text;
                cmd.Parameters.Add("@codGenero", SqlDbType.Int).Value = (comboBox1.SelectedIndex + 1);
                cmd.Parameters.Add("@ano", SqlDbType.Int).Value = tbAno.Text;
                cmd.Parameters.Add("@productora", SqlDbType.NVarChar).Value = tbProductora.Text;
                cmd.Parameters.Add("@pais", SqlDbType.NVarChar).Value = tbPais.Text;
                cmd.Parameters.Add("@precio", SqlDbType.Float).Value = tbPrecio.Text;
                cmd.Parameters.Add("@director", SqlDbType.NVarChar).Value = tbDirector.Text;
                Conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                Conexion.CerrarConexion();
                labelResultadoInsertar.Text = "Éxito";
            }
            catch (Exception)
            {
                labelResultadoInsertar.Text = "Fallido";
            }
        }

        private void llenarComboGeneros()
        {
            sql = "SELECT DISTINCT NomGenero FROM [Generos]";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
                comboBox2.Items.Add(dr[0].ToString());
            }
            Conexion.CerrarConexion();
        }

        private void llenarComboPeliculas()
        {
            sql = "SELECT DISTINCT Titulo FROM [Peliculas]";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr[0].ToString());
            }
            Conexion.CerrarConexion();
        }

        private int maximoPeliculas()
        {
            int pelicula = 0;
            sql = "SELECT MAX(CodPelicula) FROM [Peliculas]";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            pelicula = Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 1;
            Conexion.CerrarConexion();
            return pelicula;
        }

        private void borrarSin_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "DELETE FROM [Peliculas] WHERE CodPelicula = " + tbCodPelicula.Text;
                SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
                Conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                Conexion.CerrarConexion();
                labelResultadoBorrar.Text = "Éxito";
            }
            catch (Exception)
            {
                labelResultadoBorrar.Text = "Fallido";
            }
        }

        private void borrarCon_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "DELETE FROM [Peliculas] WHERE CodPelicula = @pelicula";
                SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
                cmd.Parameters.Add("@pelicula", SqlDbType.Int).Value = tbCodPelicula.Text;
                Conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                Conexion.CerrarConexion();
                labelResultadoBorrar.Text = "Éxito";
            }
            catch (Exception)
            {
                labelResultadoBorrar.Text = "Fallido";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "SELECT CodGenero FROM [Peliculas] WHERE Titulo = '" + comboBox3.Items[comboBox3.SelectedIndex].ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            int genero = Convert.ToInt32(cmd.ExecuteScalar());
            comboBox2.SelectedIndex = genero - 1;
            Conexion.CerrarConexion();

            tbTitulo2.Text = comboBox3.Items[comboBox3.SelectedIndex].ToString();

            sql = "SELECT Duración FROM [Peliculas] WHERE Titulo = '" + comboBox3.Items[comboBox3.SelectedIndex].ToString() + "'";
            cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            tbDuracion2.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
            Conexion.CerrarConexion();

            sql = "SELECT Año FROM [Peliculas] WHERE Titulo = '" + comboBox3.Items[comboBox3.SelectedIndex].ToString() + "'";
            cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            tbAno2.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
            Conexion.CerrarConexion();

            sql = "SELECT Productora FROM [Peliculas] WHERE Titulo = '" + comboBox3.Items[comboBox3.SelectedIndex].ToString() + "'";
            cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            tbProductora2.Text = cmd.ExecuteScalar().ToString();
            Conexion.CerrarConexion();

            sql = "SELECT Pais FROM [Peliculas] WHERE Titulo = '" + comboBox3.Items[comboBox3.SelectedIndex].ToString() + "'";
            cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            tbPais2.Text = cmd.ExecuteScalar().ToString();
            Conexion.CerrarConexion();

            sql = "SELECT Precio FROM [Peliculas] WHERE Titulo = '" + comboBox3.Items[comboBox3.SelectedIndex].ToString() + "'";
            cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            tbPrecio2.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
            Conexion.CerrarConexion();

            sql = "SELECT Director FROM [Peliculas] WHERE Titulo = '" + comboBox3.Items[comboBox3.SelectedIndex].ToString() + "'";
            cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();
            tbDirector2.Text = cmd.ExecuteScalar().ToString();
            Conexion.CerrarConexion();
        }

        private void modificarSin_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT CodPelicula FROM [Peliculas] WHERE Titulo = '" + comboBox3.Items[comboBox3.SelectedIndex].ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
                cmd.Parameters.Add("@pelicula", SqlDbType.Int).Value = tbCodPelicula.Text;
                Conexion.AbrirConexion();
                String codigo = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                Conexion.CerrarConexion();

                int pelicula = maximoPeliculas();
                sql = "UPDATE [Peliculas] SET Titulo = '" + tbTitulo2.Text + "', Duración = " + tbDuracion2.Text + ", CodGenero = " + (comboBox2.SelectedIndex + 1) + ", Año = " + tbAno2.Text + ", Productora = '" + tbProductora2.Text + "', Pais = '" + tbPais2.Text + "', Precio = " + tbPrecio2.Text + ", Director = '" + tbDirector2.Text + "' WHERE CodPelicula = " + codigo + ";";
                cmd = new SqlCommand(sql, Conexion.pConexion);
                Conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                Conexion.CerrarConexion();
                labelResultadoModificar.Text = "Éxito";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.StackTrace);
                labelResultadoModificar.Text = "Fallido";
            }
        }

        private void modificarCon_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT CodPelicula FROM [Peliculas] WHERE Titulo = @pelicula";
                SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
                cmd.Parameters.Add("@pelicula", SqlDbType.NVarChar).Value = comboBox3.Items[comboBox3.SelectedIndex].ToString();
                Conexion.AbrirConexion();
                String codigo = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
                Conexion.CerrarConexion();

                int pelicula = maximoPeliculas();
                sql = "UPDATE [Peliculas] SET Titulo = @titulo, Duración = @duracion, CodGenero = @codGenero, Año = @ano, Productora = @productora, Pais = @pais, Precio = @precio, Director = @director WHERE CodPelicula = @codPelicula;";
                cmd = new SqlCommand(sql, Conexion.pConexion);
                cmd.Parameters.Add("@codPelicula", SqlDbType.Int).Value = codigo;
                cmd.Parameters.Add("@titulo", SqlDbType.NVarChar).Value = tbTitulo2.Text;
                cmd.Parameters.Add("@duracion", SqlDbType.Int).Value = tbDuracion2.Text;
                cmd.Parameters.Add("@codGenero", SqlDbType.Int).Value = (comboBox2.SelectedIndex + 1);
                cmd.Parameters.Add("@ano", SqlDbType.Int).Value = tbAno2.Text;
                cmd.Parameters.Add("@productora", SqlDbType.NVarChar).Value = tbProductora2.Text;
                cmd.Parameters.Add("@pais", SqlDbType.NVarChar).Value = tbPais2.Text;
                cmd.Parameters.Add("@precio", SqlDbType.Float).Value = tbPrecio2.Text;
                cmd.Parameters.Add("@director", SqlDbType.NVarChar).Value = tbDirector2.Text;
                Conexion.AbrirConexion();
                cmd.ExecuteNonQuery();
                Conexion.CerrarConexion();
                labelResultadoModificar.Text = "Éxito";
            }
            catch (Exception E)
            {
                MessageBox.Show(E.StackTrace);
                labelResultadoModificar.Text = "Fallido";
            }
        }
    }
}
