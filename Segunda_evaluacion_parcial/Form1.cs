using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Segunda_evaluacion_parcial
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=ParcialProgramacion1;Trusted_Connection=True;TrustServerCertificate=True;");
        int idSeleccionado = 0;

        public Form1()
        {
            InitializeComponent();

            // Conecta los botones con sus métodos
            btnconsultar.Click += btnconsultar_Click;
            btnactualizar.Click += btnactualizar_Click;
            btneliminar.Click += btneliminar_Click;
            btnlimpiar.Click += btnlimpiar_Click;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        // ---------- MÉTODOS AUXILIARES ----------
        private void Consultar()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Productos", con);
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                dataGridView1.DataSource = tabla;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Limpiar()
        {
            txtproducto.Clear();
            txtcategoria.Clear();
            txtprecio.Clear();
            txtexistencias.Clear();
            idSeleccionado = 0;
        }

        private bool Validar(out decimal precio, out int existencias)
        {
            precio = 0;
            existencias = 0;

            if (txtproducto.Text == "" || txtcategoria.Text == "")
            {
                MessageBox.Show("Nombre y categoría son obligatorios");
                return false;
            }
            if (!decimal.TryParse(txtprecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor que cero");
                return false;
            }
            if (!int.TryParse(txtexistencias.Text, out existencias) || existencias < 0)
            {
                MessageBox.Show("Las existencias deben ser un entero mayor o igual a cero");
                return false;
            }
            return true;
        }

        // ---------- BOTONES ----------
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!Validar(out decimal precio, out int existencias)) return;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Productos (Nombre, Categoria, Precio, Existencias) VALUES (@n, @c, @p, @e)", con);
                cmd.Parameters.AddWithValue("@n", txtproducto.Text);
                cmd.Parameters.AddWithValue("@c", txtcategoria.Text);
                cmd.Parameters.AddWithValue("@p", precio);
                cmd.Parameters.AddWithValue("@e", existencias);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Guardado correctamente");
                Consultar();
                Limpiar();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la tabla");
                return;
            }
            if (!Validar(out decimal precio, out int existencias)) return;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Productos SET Nombre=@n, Categoria=@c, Precio=@p, Existencias=@e WHERE IdProducto=@id", con);
                cmd.Parameters.AddWithValue("@n", txtproducto.Text);
                cmd.Parameters.AddWithValue("@c", txtcategoria.Text);
                cmd.Parameters.AddWithValue("@p", precio);
                cmd.Parameters.AddWithValue("@e", existencias);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Actualizado correctamente");
                Consultar();
                Limpiar();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la tabla");
                return;
            }

            DialogResult r = MessageBox.Show("¿Desea eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) return;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Productos WHERE IdProducto=@id", con);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Eliminado correctamente");
                Consultar();
                Limpiar();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // ---------- CLIC EN LA TABLA ----------
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            idSeleccionado = Convert.ToInt32(fila.Cells["IdProducto"].Value);
            txtproducto.Text = fila.Cells["Nombre"].Value.ToString();
            txtcategoria.Text = fila.Cells["Categoria"].Value.ToString();
            txtprecio.Text = fila.Cells["Precio"].Value.ToString();
            txtexistencias.Text = fila.Cells["Existencias"].Value.ToString();
        }
    }
}