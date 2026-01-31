namespace Parcial2
{
    using Microsoft.Data.SqlClient;
    using System.Data;
    using System.DirectoryServices.ActiveDirectory;
    using System.Drawing;
    using System.Windows.Forms;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public partial class Form1 : Form
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=ConversionesDB;TrustServerCertificate=true;Integrated Security=SSPI;";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxIngresarEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIngresarDolar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIngresarPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConvertirEuro_Click(object sender, EventArgs e)
        {

            string input = textBoxIngresarEuro.Text;
            if (double.TryParse(input, out double euros))
            {
                double dolares = euros * 1.17;
                double pesos = (euros * 1.17) * 4.258;

                textBox1.Text = euros.ToString("F3");
                textBox2.Text = dolares.ToString("F3");
                textBox3.Text = pesos.ToString("F3");

                
                string sql = "INSERT INTO HistorialConversiones (TipoConversion, ValorIngresado, Euro, Dolar, Peso) " +
                             "VALUES (@TipoConversion, @ValorIngresado, @Euro, @Dolar, @Peso)";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TipoConversion", "Euro");
                    cmd.Parameters.AddWithValue("@ValorIngresado", euros);
                    cmd.Parameters.AddWithValue("@Euro", euros);
                    cmd.Parameters.AddWithValue("@Dolar", dolares);
                    cmd.Parameters.AddWithValue("@Peso", pesos);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para euros.");
            }

        }

        private void buttonConvertirDolar_Click(object sender, EventArgs e)
        {
            string input = textBoxIngresarDolar.Text;
            if (double.TryParse(input, out double dolar2))
            {
                double euros2 = dolar2 / 1.17;
                double pesos2 = dolar2 * 4.258;
                textBox4.Text = euros2.ToString("F3");
                textBox5.Text = dolar2.ToString("F3");
                textBox6.Text = pesos2.ToString("F3");

                string sql = "INSERT INTO HistorialConversiones (TipoConversion, ValorIngresado, Euro, Dolar, Peso) " +
                             "VALUES (@TipoConversion, @ValorIngresado, @Euro, @Dolar, @Peso)";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TipoConversion", "Dolar");
                    cmd.Parameters.AddWithValue("@ValorIngresado", dolar2);
                    cmd.Parameters.AddWithValue("@Euro", euros2);
                    cmd.Parameters.AddWithValue("@Dolar", dolar2);
                    cmd.Parameters.AddWithValue("@Peso", pesos2);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para dólares.");
            }
        }

        private void buttonConvertirPeso_Click(object sender, EventArgs e)
        {
            string input = textBoxIngresarPeso.Text;

            if (double.TryParse(input, out double pesos3))
            {
                double dolares3 = pesos3 / 4.258;
                double euros3 = pesos3 / (4.258 * 1.17);
                textBox7.Text = euros3.ToString("F3");
                textBox8.Text = dolares3.ToString("F3");
                textBox9.Text = pesos3.ToString("F3");

                string sql = "INSERT INTO HistorialConversiones (TipoConversion, ValorIngresado, Euro, Dolar, Peso) " +
                             "VALUES (@TipoConversion, @ValorIngresado, @Euro, @Dolar, @Peso)";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TipoConversion", "Pesos Colombianos");
                    cmd.Parameters.AddWithValue("@ValorIngresado", pesos3);
                    cmd.Parameters.AddWithValue("@Euro", euros3);
                    cmd.Parameters.AddWithValue("@Dolar", dolares3);
                    cmd.Parameters.AddWithValue("@Peso", pesos3);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para pesos.");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMostrarConversiones_Click(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM HistorialConversiones ORDER BY Fecha DESC";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, con))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string sql = "DELETE FROM HistorialConversiones";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                MessageBox.Show("Historial eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al limpiar el historial: {ex.Message}");
            }
        }
    }
}
