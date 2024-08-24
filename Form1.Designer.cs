namespace TallerEventos
{
    partial class ControlTareas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombreTarea = new TextBox();
            btnAgregarTarea = new Button();
            flowPanelTareasPendientes = new FlowLayoutPanel();
            btnEliminarUltimaTarea = new Button();
            SuspendLayout();
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.Location = new Point(43, 49);
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.PlaceholderText = "Ingrese su tarea";
            txtNombreTarea.Size = new Size(356, 27);
            txtNombreTarea.TabIndex = 0;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.BackColor = Color.FromArgb(128, 255, 128);
            btnAgregarTarea.Location = new Point(417, 43);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(117, 39);
            btnAgregarTarea.TabIndex = 1;
            btnAgregarTarea.Text = "AGREGAR +";
            btnAgregarTarea.UseVisualStyleBackColor = false;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // flowPanelTareasPendientes
            // 
            flowPanelTareasPendientes.FlowDirection = FlowDirection.TopDown;
            flowPanelTareasPendientes.Location = new Point(43, 100);
            flowPanelTareasPendientes.Name = "flowPanelTareasPendientes";
            flowPanelTareasPendientes.Size = new Size(356, 338);
            flowPanelTareasPendientes.TabIndex = 2;
            // 
            // btnEliminarUltimaTarea
            // 
            btnEliminarUltimaTarea.Location = new Point(417, 100);
            btnEliminarUltimaTarea.Name = "btnEliminarUltimaTarea";
            btnEliminarUltimaTarea.Size = new Size(117, 49);
            btnEliminarUltimaTarea.TabIndex = 3;
            btnEliminarUltimaTarea.Text = "ELIMINAR ULTIMA TAREA";
            btnEliminarUltimaTarea.UseVisualStyleBackColor = true;
            btnEliminarUltimaTarea.Click += btnEliminarUltimaTarea_Click;
            // 
            // ControlTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarUltimaTarea);
            Controls.Add(flowPanelTareasPendientes);
            Controls.Add(btnAgregarTarea);
            Controls.Add(txtNombreTarea);
            Name = "ControlTareas";
            Text = "ControlTareas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreTarea;
        private Button btnAgregarTarea;
        private FlowLayoutPanel flowPanelTareasPendientes;
        private Button btnEliminarUltimaTarea;
    }
}
