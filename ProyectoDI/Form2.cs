﻿using System;
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
        private int cont;
        private MiConexion Conexion = new MiConexion();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            llenarComboGeneros();
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
                cont++;
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
    }
}