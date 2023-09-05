using Linq.Data;
using LINQ.Logic;
using System.Text;

namespace LINQ.UI
{
    public partial class Form1 : Form
    {
        private readonly NorthwindContext context;
        public Form1()
        {
            InitializeComponent();
            context = new NorthwindContext();
        }

        private void BQuery_Click(object sender, EventArgs e)
        {
            string selectedOption = CBQueries.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Customers":
                    using (var customersLogic = new CustomersLogic(context))
                    {
                        var customers = customersLogic.GetCustomers();

                        StringBuilder resultText = new StringBuilder();

                        foreach (var customer in customers)
                        {
                            resultText.AppendLine($"Customer ID: {customer.CustomerID}, Nombre: {customer.ContactName}");
                        }

                        MessageBox.Show(resultText.ToString(), "Customers", MessageBoxButtons.OK);
                    }
                    break;
                case "Productos sin stock":
                    using (var productsLogic = new ProductsLogic(context))
                    {
                        var productsOutStock = productsLogic.GetProductsOutOfStock();

                        StringBuilder resultText = new StringBuilder();

                        foreach (var product in productsOutStock)
                        {
                            resultText.AppendLine($"Producto ID: {product.ProductID}, Nombre: {product.ProductName}");
                        }
                        MessageBox.Show(resultText.ToString(), "Products out of stock", MessageBoxButtons.OK);
                    }
                    break;
                case "Productos con stock que cuestan más de 3":
                    using(var productsLogic = new ProductsLogic(context))
                    {
                        var expensiveProducts = productsLogic.GetExpensiveProducts();

                        StringBuilder resultText = new StringBuilder();

                        foreach (var product in expensiveProducts)
                        {
                            resultText.AppendLine($"Producto ID: {product.ProductID}, Nombre: {product.ProductName}");
                        }
                        MessageBox.Show(resultText.ToString(), "Expensive Products", MessageBoxButtons.OK);
                    }
                    break;
                case "Customers de la región WA":
                    using (var customersLogic = new CustomersLogic(context))
                    {
                        var customers = customersLogic.CustomersFromWA();

                        StringBuilder resultText = new StringBuilder();

                        foreach (var customer in customers)
                        {
                            resultText.AppendLine($"Customer ID: {customer.CustomerID}, Nombre: {customer.ContactName}, Region: {customer.Region}");
                        }

                        MessageBox.Show(resultText.ToString(), "Customers from Region WA", MessageBoxButtons.OK);
                    }
                    break;
                case "Primer elemento o nulo de productos con ID = 789":
                    using (var productsLogic = new ProductsLogic(context))
                    {
                        var product789 = productsLogic.ProductID789();

                        if (product789 != null)
                            MessageBox.Show($"Producto ID: {product789.ProductID}, Nombre: {product789.ProductName}", "Product ID = 789", MessageBoxButtons.OK);
                        else

                            MessageBox.Show("No se encontró ningún producto con ID 789", "Product ID = 789", MessageBoxButtons.OK);
                    }
                    break;
                case "Nombre de los customers":
                    using (var customersLogic = new CustomersLogic(context))
                    {
                        var customersName = customersLogic.CustomerNames();

                        StringBuilder resultText = new StringBuilder();

                        foreach (var customer in customersName)
                        {

                            resultText.AppendLine($"{customer.LowerCaseName} - {customer.UpperCaseName}");
                        }

                        MessageBox.Show(resultText.ToString(), "Nombre de los Clientes", MessageBoxButtons.OK);
                    }
                    break;
                case "Join entre customers (WA) y Orders":
                    using (var customersLogic = new CustomersLogic(context))
                    {
                        var customersName = customersLogic.CustomersWithOrders();

                        StringBuilder resultText = new StringBuilder();

                        foreach (var customer in customersName)
                        {

                            resultText.AppendLine($"Nombre: {customer.CustomerName} - Región: WA - Fecha de orden: {customer.OrderDate}");
                        }

                        MessageBox.Show(resultText.ToString(), "Nombre de los Clientes", MessageBoxButtons.OK);
                    }
                    break;
                default:
                    MessageBox.Show("La opción ingresada no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;                
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}