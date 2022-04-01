using System.Data;
using System.Data.SqlClient;

namespace ProyectoAdmnBD
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection("Data Source = LAPTOP-BVSMJ8SM\\SQLEXPRESS; Initial Catalog = BDProyecto; Integrated Security = True");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                MessageBox.Show("Se ha conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido conectar" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM EMPLEADOS", Con);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Empleados.DataSource = tabla;
        }
    }
}