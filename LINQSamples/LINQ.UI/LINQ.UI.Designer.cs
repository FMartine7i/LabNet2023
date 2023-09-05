namespace LINQ.UI
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
            CBQueries = new ComboBox();
            BClose = new Button();
            BQuery = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CBQueries
            // 
            CBQueries.AutoCompleteCustomSource.AddRange(new string[] { "Customers", "Productos sin stock", "Productos con stock que cuestan más de 3", "Customers de la región WA", "Primer elemento o nulo de productos con ID = 789", "Nombre de los customers", "Join entre customers (WA) y Orders", "Primeros 3 customers de WA", "Lista de productos ordenados por nombre", "Productos ordenados por unit in stock DESC", "Categorías asociadas a los productos", "Customers con cantidad de ordenes asociadas" });
            CBQueries.BackColor = Color.FromArgb(31, 25, 36);
            CBQueries.FlatStyle = FlatStyle.Flat;
            CBQueries.ForeColor = Color.FromArgb(190, 150, 250);
            CBQueries.FormattingEnabled = true;
            CBQueries.Items.AddRange(new object[] { "Customers", "Productos sin stock", "Productos con stock que cuestan más de 3", "Customers de la región WA", "Primer elemento o nulo de productos con ID = 789", "Nombre de los customers", "Join entre customers (WA) y Orders", "Primeros 3 customers de WA", "Lista de productos ordenados por nombre", "Productos ordenados por units in stock DESC", "Categorías asociadas a los productos", "Primer elemento de Productos", "Customers con cantidad de ordenes asociadas" });
            CBQueries.Location = new Point(144, 86);
            CBQueries.Margin = new Padding(4);
            CBQueries.Name = "CBQueries";
            CBQueries.Size = new Size(328, 28);
            CBQueries.TabIndex = 0;
            // 
            // BClose
            // 
            BClose.FlatStyle = FlatStyle.Flat;
            BClose.Location = new Point(379, 213);
            BClose.Margin = new Padding(4);
            BClose.Name = "BClose";
            BClose.Size = new Size(117, 37);
            BClose.TabIndex = 1;
            BClose.Text = "Cerrar";
            BClose.UseVisualStyleBackColor = true;
            BClose.Click += BClose_Click;
            // 
            // BQuery
            // 
            BQuery.FlatStyle = FlatStyle.Flat;
            BQuery.Location = new Point(235, 213);
            BQuery.Margin = new Padding(4);
            BQuery.Name = "BQuery";
            BQuery.Size = new Size(117, 37);
            BQuery.TabIndex = 2;
            BQuery.Text = "Consultar";
            BQuery.UseVisualStyleBackColor = true;
            BQuery.Click += BQuery_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(150, 148, 0, 211);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(BClose);
            panel1.Controls.Add(BQuery);
            panel1.Location = new Point(40, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(539, 267);
            panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.ForeColor = Color.FromArgb(190, 150, 250);
            groupBox1.Location = new Point(43, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Queries";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 36, 47);
            ClientSize = new Size(617, 316);
            Controls.Add(CBQueries);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(190, 150, 250);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CBQueries;
        private Button BClose;
        private Button BQuery;
        private Panel panel1;
        private GroupBox groupBox1;
    }
}