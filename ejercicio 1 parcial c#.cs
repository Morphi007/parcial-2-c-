using System;
namespace examen
{

    class producto
    {

        int codigo, precioP1 = 15, precioP2 = 10, precioP3 = 25, precioP4 = 50, precioP5 = 100, precioP6 = 200, accion, cocas = 10, chocolate = 10, galleta = 10, ciclo = 1;
        float cambio, dinero, faltante, falta;


        public void imprecio()
        {
            while (ciclo>=1)
            {

                Console.WriteLine("***************************************** **************\n");
                Console.WriteLine("          *Maquinada exprendedora MP*         ");
                Console.WriteLine("  codigo\t \t producto\t\t precio\t\t cantidad\n");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("  1     \t \t Cocola \t\t   $15   \t\t {0}\n", cocas);
                Console.WriteLine("  2     \t \t chocolate \t\t   $10   \t\t {0}\n", chocolate);
                Console.WriteLine("  3     \t \t galletas \t\t   $10   \t\t {0}\n", galleta);
               
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("\t\t\t  Menu\n");
               
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("1\t \t  delvolver   \n");
                Console.WriteLine("2\t \t  Comprar   \n");
                Console.WriteLine("3\t \t  salir   \n");
                Console.WriteLine("\n ingresa el numero de opcion que deseas");
                accion=Convert.ToInt32(Console.ReadLine());



                if (accion==1)
                {
                    Console.WriteLine("----------------------delvolver-------------------------");
                    cocas = 10;
                    chocolate = 10;
                    galleta = 10;
                }else if (accion==2){
                    Console.WriteLine("ingrese el numero de producto que quiere\n");
                    accion = Convert.ToInt32(Console.ReadLine());


                    switch(codigo){

                        case 1:
                            Console.WriteLine("seleciona cocacola\n");
                            Console.WriteLine("ingresa el dinero: ");
                           dinero = Convert.ToInt32(Console.ReadLine());
                            while (dinero<precioP1)
                            {
                                faltante = precioP1 - dinero;
                                Console.WriteLine("Falta dinero, ingrese lo que falta: {0}",faltante);
                                falta = Convert.ToInt32(Console.ReadLine());
                                dinero = dinero + falta;
                            }
                            cambio = dinero + falta;
                            Console.WriteLine("Tome su camcio {0}",cambio);
                            Console.WriteLine("Tome su bebida\n\n");
                            cocas = cocas - 1;
                            break;


                        case 2:
                            Console.WriteLine("seleciona cocacola\n");
                            Console.WriteLine("ingresa el dinero: ");
                            dinero = Convert.ToInt32(Console.ReadLine());
                            while (dinero < precioP2)
                            {
                                faltante = precioP2 - dinero;
                                Console.WriteLine("Falta dinero, ingrese lo que falta: {0}", faltante);
                                falta = Convert.ToInt32(Console.ReadLine());
                                dinero = dinero + falta;
                            }
                            cambio = dinero + falta;
                            Console.WriteLine("Tome su camcio {0}", cambio);
                            Console.WriteLine("Tome su bebida\n\n");
                            cocas = chocolate - 1;
                            break;

                        case 3:
                            Console.WriteLine("seleciona cocacola\n");
                            Console.WriteLine("ingresa el dinero: ");
                            dinero = Convert.ToInt32(Console.ReadLine());
                            while (dinero < precioP3)
                            {
                                faltante = precioP3 - dinero;
                                Console.WriteLine("Falta dinero, ingrese lo que falta: {0}", faltante);
                                falta = Convert.ToInt32(Console.ReadLine());
                                dinero = dinero + falta;
                            }
                            cambio = dinero + falta;
                            Console.WriteLine("Tome su camcio {0}", cambio);
                            Console.WriteLine("Tome su bebida\n\n");
                            cocas = galleta - 1;
                            break;
                        default:
                            Console.WriteLine("Digite un numero valido para sacar su producto");

                            break;
                       


                        

                    }


                }
                else if (accion == 3)
                {
                    Console.WriteLine("--------------------saliendo-------------------");
                    break;
                }







            }






        }








    }









    class Program
    {
        static void Main(string[] args)
        {

            producto maquina = new producto();
            maquina.imprecio();






        }
    }
}
