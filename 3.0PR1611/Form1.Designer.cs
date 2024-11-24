namespace _3._0PR1611
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
            txtNom = new TextBox();
            txtEdad = new TextBox();
            Nom = new Label();
            Edad = new Label();
            Save = new Button();
            Clear = new Button();
            Grid = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid).BeginInit();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Font = new Font("Verdana", 9.75F);
            txtNom.Location = new Point(149, 65);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(178, 23);
            txtNom.TabIndex = 8;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Verdana", 9.75F);
            txtEdad.Location = new Point(151, 118);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 9;
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            Nom.ForeColor = SystemColors.Control;
            Nom.Location = new Point(34, 60);
            Nom.Name = "Nom";
            Nom.Size = new Size(120, 25);
            Nom.TabIndex = 10;
            Nom.Text = "Nombre: ";
            // 
            // Edad
            // 
            Edad.AutoSize = true;
            Edad.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            Edad.ForeColor = SystemColors.Control;
            Edad.Location = new Point(51, 118);
            Edad.Name = "Edad";
            Edad.Size = new Size(78, 25);
            Edad.TabIndex = 11;
            Edad.Text = "Edad:";
            // 
            // Save
            // 
            Save.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            Save.Location = new Point(136, 190);
            Save.Name = "Save";
            Save.Size = new Size(115, 48);
            Save.TabIndex = 12;
            Save.Text = "Guardar";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Clear
            // 
            Clear.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            Clear.Location = new Point(136, 275);
            Clear.Name = "Clear";
            Clear.Size = new Size(115, 42);
            Clear.TabIndex = 13;
            Clear.Text = "Limpiar";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Grid
            // 
            Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid.Location = new Point(391, 69);
            Grid.Name = "Grid";
            Grid.Size = new Size(340, 268);
            Grid.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(488, 394);
            label1.Name = "label1";
            label1.Size = new Size(300, 30);
            label1.TabIndex = 15;
            label1.Text = "OSCAR SANTIAGO DIAZ LOPEZ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Grid);
            Controls.Add(Clear);
            Controls.Add(Save);
            Controls.Add(Edad);
            Controls.Add(Nom);
            Controls.Add(txtEdad);
            Controls.Add(txtNom);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private TextBox txtEdad;
        private Label Nom;
        private Label Edad;
        private Button Save;
        private Button Clear;
        private DataGridView Grid;
        private Label label1;
    }
}
