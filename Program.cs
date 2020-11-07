using static System.Console;
using System.Threading;

namespace TimesTableFunction
{
    class Program
    {
        /*
         * @author: Erick Escamilla Charco.
         */
        static void TablaDeMultiplicar(byte numero)
        {
            WriteLine($"Esta es la tabla de multiplicar del número {numero}");
            for (int fila = 1; fila <= 10; fila++) {
                WriteLine($"{fila} x {numero} = {fila * numero}");
            }
            WriteLine();
        } //--fin: TablaDeMultiplicar

        static void EjecutarTablaDeMultiplicar() {
            bool esNumero;
            do {
                Write("Ingrese un número entre 0 y 255: ");
                esNumero = byte.TryParse(ReadLine(), out byte numero);

                if (esNumero) {
                    TablaDeMultiplicar(numero);
                } else {
                    WriteLine("¡Usted NO ingreso un número válido!");
                }

            } while (esNumero);
        }//--fin: EjecutarTablaDeMultiplicar

        static void Main(string[] args)
        {
            EjecutarTablaDeMultiplicar();
            Thread.Sleep(1500);
        }
    }
}
