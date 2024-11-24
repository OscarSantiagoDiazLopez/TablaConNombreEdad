using _3PR1611.Modelo;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using _3._0PR1611.Data;

namespace _3._0PR1611
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato = new Usuario();

        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Guardar();
            Iniciar();
            Limpiar();
            Consultar();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Edad");
            Grid.DataSource = tabla;
        }

        private void Guardar()
        {
            UsuarioModel model = new UsuarioModel()
            {
                Nom = txtNom.Text,
                Edad = int.Parse(txtEdad.Text)
            };
            dato.Guardar(model);
        }

        private void Consultar()
        {
            
            foreach (var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nom;
                fila["Edad"] = item.Edad;
                tabla.Rows.Add(fila);
            }
        }

        private void Limpiar()
        {
            txtNom.Text = "";
            txtEdad.Text = "";
        }
    }
}
