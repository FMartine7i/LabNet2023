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
            if (CBQueries.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una opci�n antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                case "Productos con stock que cuestan m�s de 3":
                    using (var productsLogic = new ProductsLogic(context))
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
                case "Customers de la regi�n WA":
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

                            MessageBox.Show("No se encontr� ning�n producto con ID 789", "Product ID = 789", MessageBoxButtons.OK);
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

                            resultText.AppendLine($"Nombre: {customer.CustomerName} - Regi�n: WA - Fecha de orden: {customer.OrderDate}");
                        }

                        MessageBox.Show(resultText.ToString(), "Nombre de los Clientes", MessageBoxButtons.OK);
                    }
                    break;
                case "Primeros 3 customers de WA":
                    using (var customersLogic = new CustomersLogic(context))
                    {
                        var customers = customersLogic.Get3FirstCustomers();

                        StringBuilder resultText = new StringBuilder();

                        foreach (var customer in customers)
                        {
                            resultText.AppendLine($"Customer ID: {customer.CustomerID}, Nombre: {customer.ContactName}");
                        }

                        MessageBox.Show(resultText.ToString(), "First 3 Customers", MessageBoxButtons.OK);
                    }
                    break;
                case "Lista de productos ordenados por nombre":
                    using (var productsLogic = new ProductsLogic(context))
                    {
                        var products = productsLogic.OrderByName();

                        StringBuilder resultText = new StringBuilder();

                        foreach (var product in products)
                        {
                            resultText.AppendLine($"Name: {product.ProductName}");
                        }

                        MessageBox.Show(resultText.ToString(), "Order by Name", MessageBoxButtons.OK);
                    }
                    break;
                case "Productos ordenados por units in stock DESC":
                    using (var productsLogic = new ProductsLogic(context))
                    {
                        var products = productsLogic.OrderByUnit();

                        StringBuilder resultText = new StringBuilder();

                        foreach (var product in products)
                        {
                            resultText.AppendLine($"Units in stock: {product.UnitsInStock} - Name: {product.ProductName}");
                        }

                        MessageBox.Show(resultText.ToString(), "Ordenado por unidades en stock", MessageBoxButtons.OK);
                    }
                    break;
                case "Categor�as asociadas a los productos":
                    using (var categoriesLogic = new CategoriesLogic(context))
                    {
                        var categories = categoriesLogic.JoinProducts();

                        StringBuilder resultText = new StringBuilder();

                        foreach (var category in categories)
                        {
                            resultText.AppendLine($"Category ID: {category.CategoryID}, Category Name: {category.CategoryName} ");
                        }

                        MessageBox.Show(resultText.ToString(), "Categor�as con productos");
                    }
                    break;
                case "Primer elemento de Productos":
                    using (var productsLogic = new ProductsLogic(context))
                    {
                        var products = productsLogic.FirstElement();

                        MessageBox.Show($"El primer elemento en Products es: {products.ProductName}");
                    }
                    break;
                case "Customers con cantidad de ordenes asociadas":
                    using (var customersLogic = new CustomersLogic(context))
                    {
                        var customers = customersLogic.OrderCount();

                        StringBuilder resultText = new StringBuilder();

                        foreach (var customer in customers)
                        {
                            resultText.AppendLine($"Customer ID: {customer.CustomerName} - Order count: {customer.TotalOrders} - Last order date: {customer.LastOrderDate}");
                        }

                        MessageBox.Show(resultText.ToString(), "Order Count", MessageBoxButtons.OK);
                    }
                    break;
                default:
                    MessageBox.Show("La opci�n ingresada no es v�lida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}