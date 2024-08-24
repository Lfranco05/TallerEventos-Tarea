using TallerEventos.Clases;

namespace TallerEventos
{
    public partial class ControlTareas : Form
    {
        List<Tarea> tareas = new List<Tarea>();

        public ControlTareas()
        {
            InitializeComponent();

            // Asigna el evento KeyDown al TextBox de nombre de tarea
            txtNombreTarea.KeyDown += new KeyEventHandler(txtNombreTarea_KeyDown);
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            AgregarTarea();
        }

        // Método que agrega la tarea
        private void AgregarTarea()
        {
            if (txtNombreTarea.Text.Trim() == "")
            {
                MessageBox.Show("Debe agregar un nombre para la tarea");
                return;
            }
            Tarea nuevaTarea = new Tarea(txtNombreTarea.Text, "Pendiente");
            tareas.Add(nuevaTarea);

            this.renderizarTareas();
        }

        // Evento que se dispara cuando se presiona una tecla en el TextBox
        private void txtNombreTarea_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si la tecla presionada es "Enter"
            if (e.KeyCode == Keys.Enter)
            {
                AgregarTarea();
                e.SuppressKeyPress = true; // Evita que se emita un "beep" de la tecla Enter
            }
        }

        private void renderizarTareas()
        {
            flowPanelTareasPendientes.Controls.Clear();
            foreach (Tarea tarea in tareas)
            {
                Label tarjeta = new Label();
                tarjeta.Text = tarea.Nombre;
                tarjeta.AutoSize = true;
                tarjeta.Padding = new Padding(10);
                tarjeta.Margin = new Padding(5);
                tarjeta.BackColor = Color.White;
                tarjeta.ForeColor = Color.Black;
                tarjeta.BorderStyle = BorderStyle.FixedSingle;

                tarjeta.MouseHover += (sender, e) =>
                {
                    tarjeta.BackColor = Color.LightGray;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Bold);
                    tarjeta.Cursor = Cursors.Hand;
                };

                tarjeta.MouseLeave += (sender, e) =>
                {
                    tarjeta.BackColor = Color.White;
                    tarjeta.Font = new Font(tarjeta.Font, FontStyle.Regular);
                };

                flowPanelTareasPendientes.Controls.Add(tarjeta);
            }
        }

        private void btnEliminarUltimaTarea_Click(object sender, EventArgs e)
        {
            tareas.RemoveAt(tareas.Count - 1);
            this.renderizarTareas();
        }
    }
}
