namespace edu.PR.Ejercicio4._1903
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string rutaArchivo = "C:\\Users\\Carlos\\Desktop\\Cs1\\PROGRAMACION\\ficheroParaActividades\\archivoEjercicio4.txt";

            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                sw.WriteLine("Un libro (del latín liber, libri) es una obra impresa, manuscrita o pintada en una serie de hojas de papel, pergamino,");
                sw.WriteLine("vitela u otro material, unidas por un lado (es decir, encuadernadas) y protegidas con tapas, también llamadas cubiertas.");
                sw.WriteLine("Un libro puede tratar sobre cualquier tema. Según la definición de la Unesco,1​2​ un libro debe poseer veinticinco hojas");
                sw.WriteLine("mínimo (49 páginas), pues de veinticuatro hojas o menos sería un folleto; y de una hasta cuatro páginas se consideran");
                sw.WriteLine("hojas sueltas (en una o dos hojas).");

            }
            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string contenido = sr.ReadToEnd();
                Console.WriteLine("Contenido del archivo:\n" + contenido);
            }


            Console.WriteLine("-----------------------------------------------------------------------");



            Console.WriteLine("Introduzca el texto que deseas");
            string textoUsuario = Console.ReadLine();
            Console.WriteLine("Introduzca la línea que deseas introducir el texto");
            int numLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca la posicion");
            int posicion = Convert.ToInt32(Console.ReadLine());

            try
            {
                string[] contenido = File.ReadAllLines(rutaArchivo);

                if(numLinea >= 1 && numLinea <= contenido.Length)
                {
                    string linea = contenido[numLinea - 1];

                    if(posicion >= 0 && posicion <= linea.Length)
                    {
                        string nuevaLinea = linea.Insert(posicion, textoUsuario);

                        contenido[numLinea - 1] = nuevaLinea;

                        File.WriteAllLines(rutaArchivo, contenido);

                        Console.WriteLine("El texto ha sido introducido correctamente");
                    }
                    else
                    {
                        Console.WriteLine("la posicion indicada no corresponde con el texto");
                    }
                }
                else {
                    Console.WriteLine("la línea indicada no corresponde con el texto");
                }
            }
            catch (Exception ex) {

                Console.WriteLine("Error al leer/escribir el archivo: " + ex.Message);
            }




        }
    }
}
