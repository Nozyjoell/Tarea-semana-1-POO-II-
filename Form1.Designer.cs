namespace GestionTareasPendientes
{
    partial class Form1
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
            textTarea = new TextBox();
            btn_Agregar = new Button();
            list_Tarea = new ListBox();
            btn_Eliminar = new Button();
            SuspendLayout();
            // 
            // textTarea
            // 
            textTarea.BackColor = Color.White;
            textTarea.BorderStyle = BorderStyle.FixedSingle;
            textTarea.Font = new Font("Segoe UI", 12F);
            textTarea.Location = new Point(96, 53);
            textTarea.Name = "textTarea";
            textTarea.Size = new Size(297, 34);
            textTarea.TabIndex = 0;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(42, 157, 143);
            btn_Agregar.FlatAppearance.BorderSize = 5;
            btn_Agregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Agregar.ForeColor = Color.White;
            btn_Agregar.Location = new Point(144, 116);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(205, 51);
            btn_Agregar.TabIndex = 1;
            btn_Agregar.Text = "Agregar Tarea";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // list_Tarea
            // 
            list_Tarea.BackColor = Color.White;
            list_Tarea.BorderStyle = BorderStyle.None;
            list_Tarea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            list_Tarea.ForeColor = Color.FromArgb(38, 70, 83);
            list_Tarea.FormattingEnabled = true;
            list_Tarea.Location = new Point(96, 174);
            list_Tarea.Name = "list_Tarea";
            list_Tarea.Size = new Size(297, 196);
            list_Tarea.TabIndex = 2;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.FromArgb(231, 111, 81);
            btn_Eliminar.FlatAppearance.BorderColor = SystemColors.InfoText;
            btn_Eliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_Eliminar.ForeColor = Color.White;
            btn_Eliminar.Location = new Point(144, 412);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(205, 55);
            btn_Eliminar.TabIndex = 3;
            btn_Eliminar.Text = "Eliminar Tarea";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 250);
            ClientSize = new Size(489, 580);
            Controls.Add(btn_Eliminar);
            Controls.Add(list_Tarea);
            Controls.Add(btn_Agregar);
            Controls.Add(textTarea);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(38, 70, 83);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Gestion Tareas Pendientes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTarea;
        private Button btn_Agregar;
        private ListBox list_Tarea;
        private Button btn_Eliminar;
    }
}
