
namespace LINQ.UI
{
    public class OptionComboBox
    {
        public string Texto { get; set; }
        public int Valor { get; set; }

        public OptionComboBox(string texto, int valor)
        {
            Texto = texto;
            Valor = valor;
        }

        public override string ToString()
        {
            return Texto;
        }
    }
}
