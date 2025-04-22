namespace NumerosPrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Numeros Primos";
        }

        private void btnMost_Click(object sender, EventArgs e)
        {
            int liminferior = Convert.ToInt32(txtliminf.Text);
            int limsuperior = Convert.ToInt32(txtlimsup.Text);

            List<int> numerosPrimos = ObtenerNumerosPrimos(liminferior, limsuperior); // Esta línea de código se utiliza para llamar al método ObtenerNumerosPrimos
                                                                                      // y almacenar la lista de números primos generados en la variable numerosPrimos.

            txtnumprim.Text = string.Join(", ", numerosPrimos); // Esta línea de código se utiliza para mostrar en el formulario "txtnumprim"
                                                                // la lista de números primos generados por el método ObtenerNumerosPrimos.

        }

        private List<int> ObtenerNumerosPrimos(int liminferior, int limsuperior) // Método para obtener los números primos en un rango dado.
        {
            List<int> ObtnumerosPrimos = new List<int>();

            for (int i = liminferior; i <= limsuperior; i++)
            {
                if (Esprimo(i))
                    ObtnumerosPrimos.Add(i);
            }
            return ObtnumerosPrimos;
        }

        private bool Esprimo(int numero) // Método para verificar si un número es primo.
        {
            if (numero < 2) return false; // 0 y 1 no son primos

            if (numero > 2 && numero % 2 == 0) return false; // Números pares mayores que 2 no son primos

            for (int i = 3; i <= Math.Sqrt(numero); i += 2) // Solo verificar números impares
            {
                if (numero % i == 0) return false;
            }

            return true;
        }

        private void btnclear_Click(object sender, EventArgs e) // Limpiar los campos de texto.
        {
            txtliminf.Clear();
            txtlimsup.Clear();
            txtnumprim.Clear();
        }
    }
}
