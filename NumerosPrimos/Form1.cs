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

            List<int> numerosPrimos = ObtenerNumerosPrimos(liminferior, limsuperior); // Esta l�nea de c�digo se utiliza para llamar al m�todo ObtenerNumerosPrimos
                                                                                      // y almacenar la lista de n�meros primos generados en la variable numerosPrimos.

            txtnumprim.Text = string.Join(", ", numerosPrimos); // Esta l�nea de c�digo se utiliza para mostrar en el formulario "txtnumprim"
                                                                // la lista de n�meros primos generados por el m�todo ObtenerNumerosPrimos.

        }

        private List<int> ObtenerNumerosPrimos(int liminferior, int limsuperior) // M�todo para obtener los n�meros primos en un rango dado.
        {
            List<int> ObtnumerosPrimos = new List<int>();

            for (int i = liminferior; i <= limsuperior; i++)
            {
                if (Esprimo(i))
                    ObtnumerosPrimos.Add(i);
            }
            return ObtnumerosPrimos;
        }

        private bool Esprimo(int numero) // M�todo para verificar si un n�mero es primo.
        {
            if (numero < 2) return false; // 0 y 1 no son primos

            if (numero > 2 && numero % 2 == 0) return false; // N�meros pares mayores que 2 no son primos

            for (int i = 3; i <= Math.Sqrt(numero); i += 2) // Solo verificar n�meros impares
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
