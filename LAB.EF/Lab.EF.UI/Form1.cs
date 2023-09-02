using Lab.EF.Logic;
using Lab.EF.Entities;
using Lab.EF.Data;

namespace Lab.EF.UI
{
    public partial class LabUi : Form
    {
        public LabUi()
        {
            InitializeComponent();
        }

        private void BMostrar_Click(object sender, EventArgs e)
        {

            if (RBCategories.Checked == true)
            {
                CategoriesLogic categoriesLogic = new CategoriesLogic();
                List<string> categoryList = new List<string>(); // creo una lista para guardar cada elemento de la categoría

                foreach (Categories category in categoriesLogic.GetAll())
                {
                    categoryList.Add($"{category.CategoryID} - {category.CategoryName} - {category.Description}");   // agrego a la lista cada una de las categorías
                }

                string categoriesText = string.Join("\n", categoryList);
                MessageBox.Show(categoriesText, "Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (RBEmployees.Checked == true)
            {
                EmployeesLogic employeesLogic = new EmployeesLogic();
                List<string> employeesList = new List<string>(); // creo una lista para guardar cada elemento de la categoría

                foreach (Employees employees in employeesLogic.GetAll())
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
            if (RBCategories.Checked == true)
            {
                if (TName.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Nombre' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TDescription.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Descripción' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TBLastName.Text.Length > 0)
                {
                    MessageBox.Show("El campo 'Apellido' no está disponible para la entidad 'Categorías'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBLastName.Clear();
                }
                else if (TBCompany.Text.Length > 0)
                {
                    MessageBox.Show("El campo 'Compañía' no está disponible para la entidad 'Categorías'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBCompany.Clear();
                }
                else
                {
                    CategoriesLogic categoriesLogic = new CategoriesLogic();

                    categoriesLogic.Add(new Categories
                    {
                        CategoryID = Convert.ToInt32(NUD_ID.Value),
                        CategoryName = TName.Text,
                        Description = TDescription.Text,
                    });
                }
            }
            else if (RBEmployees.Checked == true)
            {
                if (TName.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Nombre' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TBLastName.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Apellido' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TDescription.Text.Length > 0)
                {
                    MessageBox.Show("El campo 'Descripción' no está disponible para la entidad 'Empleados'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TDescription.Clear();
                }
                else if (TBCompany.Text.Length > 0)
                {
                    MessageBox.Show("El campo 'Compañía' no está disponible para la entidad 'Empleados'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBCompany.Clear();
                }
                else
                {
                    EmployeesLogic employeesLogic = new EmployeesLogic();

                    employeesLogic.Add(new Employees
                    {
                        EmployeeID = Convert.ToInt32(NUD_ID.Value),
                        FirstName = TName.Text,
                        LastName = TBLastName.Text,
                    });
                }
            }
            else
            {
                if (TName.Text.Length > 0)
                {
                    MessageBox.Show("El campo 'Nombre' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TName.Clear();
                }
                else if (TBLastName.Text.Length > 0)
                {
                    MessageBox.Show("El campo 'Apellido' no está disponible para la entidad 'Categorías'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TDescription.Clear();
                }
                else if (TBCompany.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Compañía' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ShippersLogic shippersLogic = new ShippersLogic();

                    shippersLogic.Add(new Shippers
                    {
                        ShipperID = Convert.ToInt32(NUD_ID.Value),
                        CompanyName = TBCompany.Text,
                    });
                }
            }
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(NUD_ID.Value);

            if (RBCategories.Checked == true)
            {
                CategoriesLogic categoriesLogic = new CategoriesLogic();

                categoriesLogic.Delete(id);
            }
            else if (RBEmployees.Checked == true)
            {
                EmployeesLogic employeesLogic = new EmployeesLogic();

                employeesLogic.Delete(id);
            }
            else
            {
                ShippersLogic shippersLogic = new ShippersLogic();

                shippersLogic.Delete(id);
            }
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            if (RBCategories.Checked == true)
            {
                if (TDescription.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Descripción' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TBLastName.Text.Length > 0)
                {
                    MessageBox.Show("El campo 'Apellido' no está disponible para la entidad 'Categorías'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TDescription.Clear();
                }
                else if (TBCompany.Text.Length > 0)
                {
                    MessageBox.Show("El campo 'Compañía' no está disponible para la entidad 'Categorías'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBCompany.Clear();
                }
                else
                {
                    CategoriesLogic categoriesLogic = new CategoriesLogic();

                    categoriesLogic.Update(new Categories
                    {
                        Description = TDescription.Text,
                        CategoryID = Convert.ToInt32(NUD_ID.Value)
                    });
                }
            }
            else if (RBEmployees.Checked == true)
            {
                if (TDescription.Text.Length > 0)
                {
                    MessageBox.Show("El campo 'Descripción' no está disponible para la entidad 'Empleados'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TBLastName.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Apellido' está vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TDescription.Clear();
                }
                else if (TBCompany.Text.Length > 0)
                {
                    MessageBox.Show("El campo 'Compañía' no está disponible para la entidad 'Empleados'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBCompany.Clear();
                }
                else
                {
                    EmployeesLogic employeesLogic = new EmployeesLogic();

                    employeesLogic.Update(new Employees
                    {
                        EmployeeID = Convert.ToInt32(NUD_ID.Value),
                        FirstName = TName.Text,
                        LastName = TBLastName.Text,
                    });
                }
            }
            else
            {
                if (TDescription.Text.Length == 0)
                {
                    MessageBox.Show("El campo 'Descripción' no está disponible para la entidad 'Expedidores'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (TBLastName.Text.Length > 0)
                {
                    MessageBox.Show("El campo 'Apellido' no está disponible para la entidad 'Expedidores'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TDescription.Clear();
                }
                else if (TName.Text.Length > 0)
                {
                    MessageBox.Show("El campo 'Nombre' no está disponible para la entidad 'Expedidores'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TDescription.Clear();
                }
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
                        ShipperID = Convert.ToInt32(NUD_ID.Value),
                        CompanyName = TBCompany.Text,
                    });
                }
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}