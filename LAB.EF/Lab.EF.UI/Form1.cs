using Lab.EF.Logic;
using Lab.EF.Entities;
using Lab.EF.Entities.DTOs;

namespace Lab.EF.UI
{
    public partial class LabUi : Form
    {
        public LabUi()
        {
            InitializeComponent();
        }

        #region Activacion GroupBoxes
        private void RBEmployees_CheckedChanged(object sender, EventArgs e)
        {
            GBEmployees.Enabled = RBEmployees.Checked;
            GBCategories.Enabled = false;
            GBShippers.Enabled = false;
        }

        private void RBCategories_CheckedChanged(object sender, EventArgs e)
        {
            GBCategories.Enabled = RBCategories.Checked;
            GBEmployees.Enabled = false;
            GBShippers.Enabled = false;
        }

        private void RBShippers_CheckedChanged(object sender, EventArgs e)
        {
            GBShippers.Enabled = RBShippers.Checked;
            GBCategories.Enabled = false;
            GBEmployees.Enabled = false;
        }
        #endregion

        #region funciones
        public void LimpiarScreen()
        {
            TBCompany.Clear();
            TName1.Clear();
            TBName2.Clear();
            TDescription.Clear();
            TBLastName.Clear();
        }
        #endregion

        private void BMostrar_Click(object sender, EventArgs e)
        {

            if (RBCategories.Checked == true)
            {
                CategoriesLogic categoriesLogic = new CategoriesLogic();
                List<string> categoryList = new List<string>(); // creo una lista para guardar cada elemento de la categoría

                foreach (CategoriesDTO category in categoriesLogic.GetAll())
                {
                    categoryList.Add($"{category.CategoryID} - {category.CategoryName} - {category.CategoryDescription}");   // agrego a la lista cada una de las categorías
                }

                string categoriesText = string.Join("\n", categoryList);
                MessageBox.Show(categoriesText, "Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (RBEmployees.Checked == true)
            {
                EmployeesLogic employeesLogic = new EmployeesLogic();
                List<string> employeesList = new List<string>(); // creo una lista para guardar cada elemento de la categoría

                foreach (EmployeesDTO employees in employeesLogic.GetAll())
                {
                    employeesList.Add($"{employees.EmployeeID} - {employees.FirstName} - {employees.LastName}");   // agrego a la lista cada una de las categorías
                }

                string employeesText = string.Join("\n", employeesList);
                MessageBox.Show(employeesText, "Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ShippersLogic shippersLogic = new ShippersLogic();
                List<string> shippersList = new List<string>();

                foreach (Shippers shipper in shippersLogic.GetAll())
                {
                    shippersList.Add($"{shipper.ShipperID} - {shipper.CompanyName}");
                }

                string shippersText = string.Join("\n", shippersList);
                MessageBox.Show(shippersText, "Shippers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            int idCat = Convert.ToInt32(NUD_IDCat.Value);

            CategoriesLogic categoriesLogic = new CategoriesLogic();

            if (RBCategories.Checked == true)
            {
                if (TBName2.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Nombre' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TDescription.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Descripción' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (categoriesLogic.CategoryExists(idCat))
                {
                    MessageBox.Show("La ID ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    categoriesLogic.Add(new CategoriesDTO
                    {
                        CategoryID = idCat,
                        CategoryName = TBName2.Text,
                        CategoryDescription = TDescription.Text,
                    });
                }
            }
            else if (RBEmployees.Checked == true)
            {
                if (TName1.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Nombre' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TBLastName.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Apellido' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EmployeesLogic employeesLogic = new EmployeesLogic();

                    employeesLogic.Add(new EmployeesDTO
                    {
                        EmployeeID = Convert.ToInt32(NUD_IDEmp.Value),
                        FirstName = TName1.Text,
                        LastName = TBLastName.Text,
                    });
                }
            }
            else
            {
                if (TBCompany.Text.Length == 0)
                    MessageBox.Show("El campo 'Compañía' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    ShippersLogic shippersLogic = new ShippersLogic();

                    shippersLogic.Add(new Shippers
                    {
                        ShipperID = Convert.ToInt32(NUD_IDShip.Value),
                        CompanyName = TBCompany.Text,
                    });
                }
            }

            LimpiarScreen();
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            int idCat = Convert.ToInt32(NUD_IDCat.Value);

            CategoriesLogic categoriesLogic = new CategoriesLogic();

            if (RBCategories.Checked == true)
            {
                if (categoriesLogic.CategoryExists(idCat))
                    categoriesLogic.Delete(Convert.ToInt32(NUD_IDCat.Value));
                else
                    MessageBox.Show($"La id {idCat} no se encuentra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (RBEmployees.Checked == true)
            {
                EmployeesLogic employeesLogic = new EmployeesLogic();

                employeesLogic.Delete(Convert.ToInt32(NUD_IDEmp.Value));
            }
            else
            {
                ShippersLogic shippersLogic = new ShippersLogic();

                shippersLogic.Delete(Convert.ToInt32(NUD_IDShip.Value));
            }
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            if (RBCategories.Checked == true)
            {
                if (TDescription.Text.Length == 0)
                    MessageBox.Show("El campo 'Descripción' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    CategoriesLogic categoriesLogic = new CategoriesLogic();

                    categoriesLogic.Update(new CategoriesDTO
                    {
                        CategoryDescription = TDescription.Text,
                        CategoryID = Convert.ToInt32(NUD_IDEmp.Value)
                    });
                }
            }
            else if (RBEmployees.Checked == true)
            {
                if (TBLastName.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Apellido' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TDescription.Clear();
                }
                else
                {
                    EmployeesLogic employeesLogic = new EmployeesLogic();

                    employeesLogic.Update(new EmployeesDTO
                    {
                        EmployeeID = Convert.ToInt32(NUD_IDEmp.Value),
                        FirstName = TName1.Text,
                        LastName = TBLastName.Text,
                    });
                }
            }
            else
            {
                if (TDescription.Text.Length == 0)
                    MessageBox.Show("El campo 'Descripción' no está disponible para la entidad 'Expedidores'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (TBCompany.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Compañía' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBCompany.Clear();
                }
                else
                {
                    ShippersLogic shippersLogic = new ShippersLogic();

                    shippersLogic.Update(new Shippers
                    {
                        ShipperID = Convert.ToInt32(NUD_IDEmp.Value),
                        CompanyName = TBCompany.Text,
                    });
                }
            }
            LimpiarScreen();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}