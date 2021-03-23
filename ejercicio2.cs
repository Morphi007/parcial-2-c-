using System;



namespace parcial_ejercicio2
{
    class empleado
    {
        private string[] nombres;
        private float[] salario;

        public void Cargar()
        {
            nombres = new string[6];
            salario = new float[6];
            for (int n = 1; n < nombres.Length; n++)
            {
                Console.Write("Ingrese el nombre del empleado:{0} ", n);

                nombres[n] = Console.ReadLine();
                Console.Write("Ingrese el sueldo:");
                string carga;
                carga = Console.ReadLine();
                salario[n] = float.Parse(carga);
            }
        }

        public void MayorSueldo()
        {
            float mayor;
            int pos;
            mayor = salario[0];
            pos = 0;
            for (int i = 1; i < nombres.Length; i++)
            {
                if (salario[i] > mayor)
                {
                    mayor = salario[i];
                    pos = i;
                }
            }
            Console.WriteLine("El empleado con sueldo mayor es " + nombres[pos]);
            Console.WriteLine("Tiene un sueldo:" + mayor);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            empleado empleado = new empleado();
            empleado.Cargar();
            empleado.MayorSueldo();
        }
    }
}
