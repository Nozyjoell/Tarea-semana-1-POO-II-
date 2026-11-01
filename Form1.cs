namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            String tarea = textTarea.Text;

            if(tarea != "")
            {
                list_Tarea.Items.Add(tarea);
                textTarea.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese una tarea");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            list_Tarea.Items.RemoveAt(list_Tarea.SelectedIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
