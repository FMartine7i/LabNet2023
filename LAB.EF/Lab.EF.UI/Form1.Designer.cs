namespace Lab.EF.UI
{
    partial class LabUi
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            GBEntities = new GroupBox();
            RBShippers = new RadioButton();
            RBCategories = new RadioButton();
            RBEmployees = new RadioButton();
            BAdd = new Button();
            BDelete = new Button();
            BMostrar = new Button();
            BUpdate = new Button();
            PAgregar = new Panel();
            TBCompany = new TextBox();
            LCompany = new Label();
            TBLastName = new TextBox();
            LLastName = new Label();
            TDescription = new TextBox();
            TName = new TextBox();
            LDescription = new Label();
            LName = new Label();
            NUD_ID = new NumericUpDown();
            L_ID = new Label();
            BClose = new Button();
            GBEntities.SuspendLayout();
            PAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_ID).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 33, 39);
            panel1.Location = new Point(1, 84);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(117, 408);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 33, 39);
            panel2.Location = new Point(115, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(755, 86);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 29, 33);
            panel3.Location = new Point(1, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(117, 86);
            panel3.TabIndex = 1;
            // 
            // GBEntities
            // 
            GBEntities.Controls.Add(RBShippers);
            GBEntities.Controls.Add(RBCategories);
            GBEntities.Controls.Add(RBEmployees);
            GBEntities.ForeColor = Color.WhiteSmoke;
            GBEntities.Location = new Point(167, 122);
            GBEntities.Name = "GBEntities";
            GBEntities.Size = new Size(226, 197);
            GBEntities.TabIndex = 2;
            GBEntities.TabStop = false;
            GBEntities.Text = "Entidades";
            // 
            // RBShippers
            // 
            RBShippers.AutoSize = true;
            RBShippers.Location = new Point(54, 133);
            RBShippers.Name = "RBShippers";
            RBShippers.Size = new Size(116, 24);
            RBShippers.TabIndex = 2;
            RBShippers.Text = "Expedidores";
            RBShippers.UseVisualStyleBackColor = true;
            // 
            // RBCategories
            // 
            RBCategories.AutoSize = true;
            RBCategories.Location = new Point(54, 93);
            RBCategories.Name = "RBCategories";
            RBCategories.Size = new Size(108, 24);
            RBCategories.TabIndex = 1;
            RBCategories.Text = "Categorías";
            RBCategories.UseVisualStyleBackColor = true;
            // 
            // RBEmployees
            // 
            RBEmployees.AutoSize = true;
            RBEmployees.Checked = true;
            RBEmployees.Location = new Point(54, 53);
            RBEmployees.Name = "RBEmployees";
            RBEmployees.Size = new Size(107, 24);
            RBEmployees.TabIndex = 0;
            RBEmployees.TabStop = true;
            RBEmployees.Text = "Empleados";
            RBEmployees.UseVisualStyleBackColor = true;
            // 
            // BAdd
            // 
            BAdd.BackColor = Color.FromArgb(150, 165, 55, 215);
            BAdd.FlatStyle = FlatStyle.Flat;
            BAdd.ForeColor = Color.FromArgb(201, 120, 230);
            BAdd.Location = new Point(31, 248);
            BAdd.Name = "BAdd";
            BAdd.Size = new Size(91, 33);
            BAdd.TabIndex = 3;
            BAdd.Text = "Agregar";
            BAdd.UseVisualStyleBackColor = false;
            BAdd.Click += BAdd_Click;
            // 
            // BDelete
            // 
            BDelete.BackColor = Color.FromArgb(150, 122, 55, 215);
            BDelete.FlatStyle = FlatStyle.Flat;
            BDelete.ForeColor = Color.FromArgb(162, 101, 240);
            BDelete.Location = new Point(149, 248);
            BDelete.Name = "BDelete";
            BDelete.Size = new Size(91, 33);
            BDelete.TabIndex = 4;
            BDelete.Text = "Eliminar";
            BDelete.UseVisualStyleBackColor = false;
            BDelete.Click += BDelete_Click;
            // 
            // BMostrar
            // 
            BMostrar.BackColor = Color.FromArgb(150, 140, 45, 230);
            BMostrar.FlatStyle = FlatStyle.Flat;
            BMostrar.ForeColor = Color.DeepSkyBlue;
            BMostrar.Location = new Point(207, 343);
            BMostrar.Name = "BMostrar";
            BMostrar.Size = new Size(150, 33);
            BMostrar.TabIndex = 5;
            BMostrar.Text = "Mostrar";
            BMostrar.UseVisualStyleBackColor = false;
            BMostrar.Click += BMostrar_Click;
            // 
            // BUpdate
            // 
            BUpdate.BackColor = Color.FromArgb(150, 65, 65, 215);
            BUpdate.FlatStyle = FlatStyle.Flat;
            BUpdate.ForeColor = Color.FromArgb(155, 140, 250);
            BUpdate.Location = new Point(267, 248);
            BUpdate.Name = "BUpdate";
            BUpdate.Size = new Size(91, 33);
            BUpdate.TabIndex = 6;
            BUpdate.Text = "Actualizar";
            BUpdate.UseVisualStyleBackColor = false;
            BUpdate.Click += BUpdate_Click;
            // 
            // PAgregar
            // 
            PAgregar.BackColor = Color.FromArgb(100, 120, 38, 171);
            PAgregar.Controls.Add(TBCompany);
            PAgregar.Controls.Add(LCompany);
            PAgregar.Controls.Add(TBLastName);
            PAgregar.Controls.Add(LLastName);
            PAgregar.Controls.Add(BUpdate);
            PAgregar.Controls.Add(TDescription);
            PAgregar.Controls.Add(TName);
            PAgregar.Controls.Add(BDelete);
            PAgregar.Controls.Add(LDescription);
            PAgregar.Controls.Add(LName);
            PAgregar.Controls.Add(NUD_ID);
            PAgregar.Controls.Add(L_ID);
            PAgregar.Controls.Add(BAdd);
            PAgregar.Location = new Point(417, 127);
            PAgregar.Name = "PAgregar";
            PAgregar.Size = new Size(391, 325);
            PAgregar.TabIndex = 7;
            // 
            // TBCompany
            // 
            TBCompany.BackColor = Color.FromArgb(45, 40, 48);
            TBCompany.BorderStyle = BorderStyle.FixedSingle;
            TBCompany.ForeColor = Color.FromArgb(181, 122, 235);
            TBCompany.Location = new Point(149, 184);
            TBCompany.Name = "TBCompany";
            TBCompany.Size = new Size(171, 26);
            TBCompany.TabIndex = 13;
            // 
            // LCompany
            // 
            LCompany.AutoSize = true;
            LCompany.BackColor = Color.Transparent;
            LCompany.Location = new Point(43, 186);
            LCompany.Name = "LCompany";
            LCompany.Size = new Size(90, 20);
            LCompany.TabIndex = 12;
            LCompany.Text = "Compañía:";
            // 
            // TBLastName
            // 
            TBLastName.BackColor = Color.FromArgb(45, 40, 48);
            TBLastName.BorderStyle = BorderStyle.FixedSingle;
            TBLastName.ForeColor = Color.FromArgb(181, 122, 235);
            TBLastName.Location = new Point(149, 108);
            TBLastName.Name = "TBLastName";
            TBLastName.Size = new Size(171, 26);
            TBLastName.TabIndex = 11;
            // 
            // LLastName
            // 
            LLastName.AutoSize = true;
            LLastName.BackColor = Color.Transparent;
            LLastName.Location = new Point(70, 110);
            LLastName.Name = "LLastName";
            LLastName.Size = new Size(73, 20);
            LLastName.TabIndex = 10;
            LLastName.Text = "Apellido:";
            // 
            // TDescription
            // 
            TDescription.BackColor = Color.FromArgb(45, 40, 48);
            TDescription.BorderStyle = BorderStyle.FixedSingle;
            TDescription.ForeColor = Color.FromArgb(181, 122, 235);
            TDescription.Location = new Point(149, 146);
            TDescription.Name = "TDescription";
            TDescription.Size = new Size(171, 26);
            TDescription.TabIndex = 9;
            // 
            // TName
            // 
            TName.BackColor = Color.FromArgb(45, 40, 48);
            TName.BorderStyle = BorderStyle.FixedSingle;
            TName.ForeColor = Color.FromArgb(181, 122, 235);
            TName.Location = new Point(149, 70);
            TName.Name = "TName";
            TName.Size = new Size(171, 26);
            TName.TabIndex = 8;
            // 
            // LDescription
            // 
            LDescription.AutoSize = true;
            LDescription.BackColor = Color.Transparent;
            LDescription.Location = new Point(43, 148);
            LDescription.Name = "LDescription";
            LDescription.Size = new Size(100, 20);
            LDescription.TabIndex = 7;
            LDescription.Text = "Descripción:";
            // 
            // LName
            // 
            LName.AutoSize = true;
            LName.BackColor = Color.Transparent;
            LName.Location = new Point(70, 72);
            LName.Name = "LName";
            LName.Size = new Size(72, 20);
            LName.TabIndex = 6;
            LName.Text = "Nombre:";
            // 
            // NUD_ID
            // 
            NUD_ID.BackColor = Color.FromArgb(45, 40, 48);
            NUD_ID.BorderStyle = BorderStyle.FixedSingle;
            NUD_ID.ForeColor = Color.FromArgb(181, 122, 235);
            NUD_ID.Location = new Point(149, 32);
            NUD_ID.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUD_ID.Name = "NUD_ID";
            NUD_ID.Size = new Size(54, 26);
            NUD_ID.TabIndex = 5;
            NUD_ID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // L_ID
            // 
            L_ID.AutoSize = true;
            L_ID.BackColor = Color.Transparent;
            L_ID.Location = new Point(114, 34);
            L_ID.Name = "L_ID";
            L_ID.Size = new Size(29, 20);
            L_ID.TabIndex = 4;
            L_ID.Text = "ID:";
            // 
            // BClose
            // 
            BClose.BackColor = Color.FromArgb(150, 140, 45, 230);
            BClose.FlatStyle = FlatStyle.Flat;
            BClose.ForeColor = Color.DeepSkyBlue;
            BClose.Location = new Point(207, 396);
            BClose.Name = "BClose";
            BClose.Size = new Size(150, 33);
            BClose.TabIndex = 8;
            BClose.Text = "Cerrar";
            BClose.UseVisualStyleBackColor = false;
            BClose.Click += BClose_Click;
            // 
            // LabUi
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 48);
            ClientSize = new Size(869, 491);
            Controls.Add(BClose);
            Controls.Add(BMostrar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PAgregar);
            Controls.Add(GBEntities);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "LabUi";
            Text = "LAB EF";
            GBEntities.ResumeLayout(false);
            GBEntities.PerformLayout();
            PAgregar.ResumeLayout(false);
            PAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_ID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox GBEntities;
        private RadioButton RBShippers;
        private RadioButton RBCategories;
        private RadioButton RBEmployees;
        private Button BAdd;
        private Button BDelete;
        private Button BMostrar;
        private Button BUpdate;
        private Panel PAgregar;
        private TextBox TDescription;
        private TextBox TName;
        private Label LDescription;
        private Label LName;
        private NumericUpDown NUD_ID;
        private Label L_ID;
        private TextBox TBCompany;
        private Label LCompany;
        private TextBox TBLastName;
        private Label LLastName;
        private Button BClose;
    }
}