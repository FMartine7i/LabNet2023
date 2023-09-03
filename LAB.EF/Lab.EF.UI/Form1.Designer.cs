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
            RBShippers = new RadioButton();
            RBCategories = new RadioButton();
            RBEmployees = new RadioButton();
            BAdd = new Button();
            BDelete = new Button();
            BMostrar = new Button();
            BUpdate = new Button();
            PAgregar = new Panel();
            GBCategories = new GroupBox();
            TBName2 = new TextBox();
            label5 = new Label();
            LName2 = new Label();
            LDescription = new Label();
            NUD_IDCat = new NumericUpDown();
            TDescription = new TextBox();
            GBEmployees = new GroupBox();
            TName1 = new TextBox();
            L_ID = new Label();
            NUD_IDEmp = new NumericUpDown();
            TBLastName = new TextBox();
            LName1 = new Label();
            LLastName = new Label();
            GBShippers = new GroupBox();
            LCompany = new Label();
            NUD_IDShip = new NumericUpDown();
            TBCompany = new TextBox();
            label10 = new Label();
            BClose = new Button();
            panel4 = new Panel();
            GBEntities = new GroupBox();
            panel5 = new Panel();
            PAgregar.SuspendLayout();
            GBCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_IDCat).BeginInit();
            GBEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_IDEmp).BeginInit();
            GBShippers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_IDShip).BeginInit();
            panel4.SuspendLayout();
            GBEntities.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 33, 39);
            panel1.Location = new Point(1, 84);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(117, 532);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(37, 33, 39);
            panel2.Location = new Point(115, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 86);
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
            // RBShippers
            // 
            RBShippers.AutoSize = true;
            RBShippers.BackColor = Color.Transparent;
            RBShippers.Location = new Point(367, 34);
            RBShippers.Name = "RBShippers";
            RBShippers.Size = new Size(116, 24);
            RBShippers.TabIndex = 2;
            RBShippers.Text = "Expedidores";
            RBShippers.UseVisualStyleBackColor = false;
            RBShippers.CheckedChanged += RBShippers_CheckedChanged;
            // 
            // RBCategories
            // 
            RBCategories.AutoSize = true;
            RBCategories.BackColor = Color.Transparent;
            RBCategories.Checked = true;
            RBCategories.Location = new Point(66, 34);
            RBCategories.Name = "RBCategories";
            RBCategories.Size = new Size(108, 24);
            RBCategories.TabIndex = 1;
            RBCategories.TabStop = true;
            RBCategories.Text = "Categorías";
            RBCategories.UseVisualStyleBackColor = false;
            RBCategories.CheckedChanged += RBCategories_CheckedChanged;
            // 
            // RBEmployees
            // 
            RBEmployees.AutoSize = true;
            RBEmployees.BackColor = Color.Transparent;
            RBEmployees.Location = new Point(217, 34);
            RBEmployees.Name = "RBEmployees";
            RBEmployees.Size = new Size(107, 24);
            RBEmployees.TabIndex = 0;
            RBEmployees.Text = "Empleados";
            RBEmployees.UseVisualStyleBackColor = false;
            RBEmployees.CheckedChanged += RBEmployees_CheckedChanged;
            // 
            // BAdd
            // 
            BAdd.BackColor = Color.FromArgb(140, 45, 230);
            BAdd.FlatStyle = FlatStyle.Flat;
            BAdd.ForeColor = Color.White;
            BAdd.Location = new Point(196, 18);
            BAdd.Name = "BAdd";
            BAdd.Size = new Size(116, 33);
            BAdd.TabIndex = 3;
            BAdd.Text = "Agregar";
            BAdd.UseVisualStyleBackColor = false;
            BAdd.Click += BAdd_Click;
            // 
            // BDelete
            // 
            BDelete.BackColor = Color.FromArgb(65, 65, 215);
            BDelete.FlatStyle = FlatStyle.Flat;
            BDelete.ForeColor = Color.White;
            BDelete.Location = new Point(353, 18);
            BDelete.Name = "BDelete";
            BDelete.Size = new Size(116, 33);
            BDelete.TabIndex = 4;
            BDelete.Text = "Eliminar";
            BDelete.UseVisualStyleBackColor = false;
            BDelete.Click += BDelete_Click;
            // 
            // BMostrar
            // 
            BMostrar.BackColor = Color.FromArgb(165, 55, 215);
            BMostrar.FlatStyle = FlatStyle.Flat;
            BMostrar.ForeColor = Color.White;
            BMostrar.Location = new Point(39, 18);
            BMostrar.Name = "BMostrar";
            BMostrar.Size = new Size(116, 33);
            BMostrar.TabIndex = 5;
            BMostrar.Text = "Mostrar";
            BMostrar.UseVisualStyleBackColor = false;
            BMostrar.Click += BMostrar_Click;
            // 
            // BUpdate
            // 
            BUpdate.BackColor = Color.FromArgb(65, 169, 215);
            BUpdate.FlatStyle = FlatStyle.Flat;
            BUpdate.ForeColor = Color.White;
            BUpdate.Location = new Point(510, 18);
            BUpdate.Name = "BUpdate";
            BUpdate.Size = new Size(116, 33);
            BUpdate.TabIndex = 6;
            BUpdate.Text = "Actualizar";
            BUpdate.UseVisualStyleBackColor = false;
            BUpdate.Click += BUpdate_Click;
            // 
            // PAgregar
            // 
            PAgregar.BackColor = Color.FromArgb(98, 38, 171);
            PAgregar.Controls.Add(GBCategories);
            PAgregar.Controls.Add(GBEmployees);
            PAgregar.Controls.Add(GBShippers);
            PAgregar.Location = new Point(143, 256);
            PAgregar.Name = "PAgregar";
            PAgregar.Size = new Size(878, 218);
            PAgregar.TabIndex = 7;
            // 
            // GBCategories
            // 
            GBCategories.BackColor = Color.Transparent;
            GBCategories.Controls.Add(TBName2);
            GBCategories.Controls.Add(label5);
            GBCategories.Controls.Add(LName2);
            GBCategories.Controls.Add(LDescription);
            GBCategories.Controls.Add(NUD_IDCat);
            GBCategories.Controls.Add(TDescription);
            GBCategories.ForeColor = Color.FromArgb(233, 130, 240);
            GBCategories.Location = new Point(27, 29);
            GBCategories.Name = "GBCategories";
            GBCategories.Size = new Size(275, 157);
            GBCategories.TabIndex = 12;
            GBCategories.TabStop = false;
            GBCategories.Text = "Categorías";
            // 
            // TBName2
            // 
            TBName2.BackColor = Color.FromArgb(45, 40, 48);
            TBName2.BorderStyle = BorderStyle.FixedSingle;
            TBName2.ForeColor = Color.FromArgb(181, 122, 235);
            TBName2.Location = new Point(122, 70);
            TBName2.Name = "TBName2";
            TBName2.Size = new Size(135, 26);
            TBName2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(87, 32);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 4;
            label5.Text = "ID:";
            // 
            // LName2
            // 
            LName2.AutoSize = true;
            LName2.BackColor = Color.Transparent;
            LName2.Location = new Point(44, 72);
            LName2.Name = "LName2";
            LName2.Size = new Size(72, 20);
            LName2.TabIndex = 6;
            LName2.Text = "Nombre:";
            // 
            // LDescription
            // 
            LDescription.AutoSize = true;
            LDescription.BackColor = Color.Transparent;
            LDescription.Location = new Point(16, 112);
            LDescription.Name = "LDescription";
            LDescription.Size = new Size(100, 20);
            LDescription.TabIndex = 7;
            LDescription.Text = "Descripción:";
            // 
            // NUD_IDCat
            // 
            NUD_IDCat.BackColor = Color.FromArgb(45, 40, 48);
            NUD_IDCat.BorderStyle = BorderStyle.FixedSingle;
            NUD_IDCat.ForeColor = Color.FromArgb(181, 122, 235);
            NUD_IDCat.Location = new Point(122, 30);
            NUD_IDCat.Name = "NUD_IDCat";
            NUD_IDCat.Size = new Size(54, 26);
            NUD_IDCat.TabIndex = 5;
            NUD_IDCat.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TDescription
            // 
            TDescription.BackColor = Color.FromArgb(45, 40, 48);
            TDescription.BorderStyle = BorderStyle.FixedSingle;
            TDescription.ForeColor = Color.FromArgb(181, 122, 235);
            TDescription.Location = new Point(122, 110);
            TDescription.Name = "TDescription";
            TDescription.Size = new Size(135, 26);
            TDescription.TabIndex = 9;
            // 
            // GBEmployees
            // 
            GBEmployees.BackColor = Color.Transparent;
            GBEmployees.Controls.Add(TName1);
            GBEmployees.Controls.Add(L_ID);
            GBEmployees.Controls.Add(NUD_IDEmp);
            GBEmployees.Controls.Add(TBLastName);
            GBEmployees.Controls.Add(LName1);
            GBEmployees.Controls.Add(LLastName);
            GBEmployees.Enabled = false;
            GBEmployees.ForeColor = Color.FromArgb(233, 130, 240);
            GBEmployees.Location = new Point(322, 29);
            GBEmployees.Name = "GBEmployees";
            GBEmployees.Size = new Size(258, 157);
            GBEmployees.TabIndex = 3;
            GBEmployees.TabStop = false;
            GBEmployees.Text = "Empleados";
            // 
            // TName1
            // 
            TName1.BackColor = Color.FromArgb(45, 40, 48);
            TName1.BorderStyle = BorderStyle.FixedSingle;
            TName1.ForeColor = Color.FromArgb(181, 122, 235);
            TName1.Location = new Point(98, 70);
            TName1.Name = "TName1";
            TName1.Size = new Size(135, 26);
            TName1.TabIndex = 8;
            // 
            // L_ID
            // 
            L_ID.AutoSize = true;
            L_ID.BackColor = Color.Transparent;
            L_ID.Location = new Point(63, 34);
            L_ID.Name = "L_ID";
            L_ID.Size = new Size(29, 20);
            L_ID.TabIndex = 4;
            L_ID.Text = "ID:";
            // 
            // NUD_IDEmp
            // 
            NUD_IDEmp.BackColor = Color.FromArgb(45, 40, 48);
            NUD_IDEmp.BorderStyle = BorderStyle.FixedSingle;
            NUD_IDEmp.ForeColor = Color.FromArgb(181, 122, 235);
            NUD_IDEmp.Location = new Point(98, 32);
            NUD_IDEmp.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUD_IDEmp.Name = "NUD_IDEmp";
            NUD_IDEmp.Size = new Size(54, 26);
            NUD_IDEmp.TabIndex = 5;
            NUD_IDEmp.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TBLastName
            // 
            TBLastName.BackColor = Color.FromArgb(45, 40, 48);
            TBLastName.BorderStyle = BorderStyle.FixedSingle;
            TBLastName.ForeColor = Color.FromArgb(181, 122, 235);
            TBLastName.Location = new Point(98, 108);
            TBLastName.Name = "TBLastName";
            TBLastName.Size = new Size(135, 26);
            TBLastName.TabIndex = 11;
            // 
            // LName1
            // 
            LName1.AutoSize = true;
            LName1.BackColor = Color.Transparent;
            LName1.Location = new Point(19, 72);
            LName1.Name = "LName1";
            LName1.Size = new Size(72, 20);
            LName1.TabIndex = 6;
            LName1.Text = "Nombre:";
            // 
            // LLastName
            // 
            LLastName.AutoSize = true;
            LLastName.BackColor = Color.Transparent;
            LLastName.Location = new Point(19, 110);
            LLastName.Name = "LLastName";
            LLastName.Size = new Size(73, 20);
            LLastName.TabIndex = 10;
            LLastName.Text = "Apellido:";
            // 
            // GBShippers
            // 
            GBShippers.BackColor = Color.Transparent;
            GBShippers.Controls.Add(LCompany);
            GBShippers.Controls.Add(NUD_IDShip);
            GBShippers.Controls.Add(TBCompany);
            GBShippers.Controls.Add(label10);
            GBShippers.Enabled = false;
            GBShippers.ForeColor = Color.FromArgb(233, 130, 240);
            GBShippers.Location = new Point(600, 29);
            GBShippers.Name = "GBShippers";
            GBShippers.Size = new Size(254, 157);
            GBShippers.TabIndex = 12;
            GBShippers.TabStop = false;
            GBShippers.Text = "Expedidores";
            // 
            // LCompany
            // 
            LCompany.AutoSize = true;
            LCompany.BackColor = Color.Transparent;
            LCompany.Location = new Point(8, 70);
            LCompany.Name = "LCompany";
            LCompany.Size = new Size(90, 20);
            LCompany.TabIndex = 12;
            LCompany.Text = "Compañía:";
            // 
            // NUD_IDShip
            // 
            NUD_IDShip.BackColor = Color.FromArgb(45, 40, 48);
            NUD_IDShip.BorderStyle = BorderStyle.FixedSingle;
            NUD_IDShip.ForeColor = Color.FromArgb(181, 122, 235);
            NUD_IDShip.Location = new Point(104, 30);
            NUD_IDShip.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUD_IDShip.Name = "NUD_IDShip";
            NUD_IDShip.Size = new Size(54, 26);
            NUD_IDShip.TabIndex = 5;
            NUD_IDShip.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // TBCompany
            // 
            TBCompany.BackColor = Color.FromArgb(45, 40, 48);
            TBCompany.BorderStyle = BorderStyle.FixedSingle;
            TBCompany.ForeColor = Color.FromArgb(181, 122, 235);
            TBCompany.Location = new Point(104, 68);
            TBCompany.Name = "TBCompany";
            TBCompany.Size = new Size(135, 26);
            TBCompany.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(69, 34);
            label10.Name = "label10";
            label10.Size = new Size(29, 20);
            label10.TabIndex = 4;
            label10.Text = "ID:";
            // 
            // BClose
            // 
            BClose.BackColor = Color.FromArgb(150, 140, 45, 230);
            BClose.FlatStyle = FlatStyle.Flat;
            BClose.ForeColor = Color.DeepSkyBlue;
            BClose.Location = new Point(862, 522);
            BClose.Name = "BClose";
            BClose.Size = new Size(135, 33);
            BClose.TabIndex = 8;
            BClose.Text = "Cerrar";
            BClose.UseVisualStyleBackColor = false;
            BClose.Click += BClose_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(120, 38, 171);
            panel4.Controls.Add(GBEntities);
            panel4.Location = new Point(143, 112);
            panel4.Name = "panel4";
            panel4.Size = new Size(878, 114);
            panel4.TabIndex = 14;
            // 
            // GBEntities
            // 
            GBEntities.BackColor = Color.Transparent;
            GBEntities.Controls.Add(RBShippers);
            GBEntities.Controls.Add(RBEmployees);
            GBEntities.Controls.Add(RBCategories);
            GBEntities.ForeColor = Color.WhiteSmoke;
            GBEntities.Location = new Point(20, 14);
            GBEntities.Name = "GBEntities";
            GBEntities.Size = new Size(620, 80);
            GBEntities.TabIndex = 0;
            GBEntities.TabStop = false;
            GBEntities.Text = "Entidades";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(150, 85, 38, 171);
            panel5.Controls.Add(BUpdate);
            panel5.Controls.Add(BMostrar);
            panel5.Controls.Add(BAdd);
            panel5.Controls.Add(BDelete);
            panel5.Location = new Point(143, 504);
            panel5.Name = "panel5";
            panel5.Size = new Size(674, 70);
            panel5.TabIndex = 15;
            // 
            // LabUi
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 40, 48);
            ClientSize = new Size(1055, 614);
            Controls.Add(panel4);
            Controls.Add(BClose);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PAgregar);
            Controls.Add(panel5);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "LabUi";
            Text = "LAB EF";
            PAgregar.ResumeLayout(false);
            GBCategories.ResumeLayout(false);
            GBCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_IDCat).EndInit();
            GBEmployees.ResumeLayout(false);
            GBEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_IDEmp).EndInit();
            GBShippers.ResumeLayout(false);
            GBShippers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_IDShip).EndInit();
            panel4.ResumeLayout(false);
            GBEntities.ResumeLayout(false);
            GBEntities.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private RadioButton RBShippers;
        private RadioButton RBCategories;
        private RadioButton RBEmployees;
        private Button BAdd;
        private Button BDelete;
        private Button BMostrar;
        private Button BUpdate;
        private Panel PAgregar;
        private TextBox TDescription;
        private TextBox TName1;
        private Label LName1;
        private NumericUpDown NUD_IDEmp;
        private Label L_ID;
        private TextBox TBCompany;
        private Label LCompany;
        private TextBox TBLastName;
        private Label LLastName;
        private Button BClose;
        private Panel panel4;
        private TextBox TBName2;
        private Label LName2;
        private NumericUpDown NUD_IDCat;
        private Label label5;
        private Label LDescription;
        private Panel panel5;
        private NumericUpDown NUD_IDShip;
        private Label label10;
        private GroupBox GBEmployees;
        private GroupBox GBEntities;
        private GroupBox GBCategories;
        private GroupBox GBShippers;
    }
}