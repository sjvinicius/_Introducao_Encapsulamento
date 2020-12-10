using System;
using _Introducao_Encapsulamento.Classes;

namespace _Introducao_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variaveis
            float produtoPrice;
            string novamente;


            //Instanciando Objetos
            Mastercard client = new Mastercard();

            client.ValidarToken();

            //Início Código
            Console.WriteLine("-----    Nubank");
            Console.WriteLine("-----    Seja Bem Vindo");
            Console.WriteLine("-----    Registro de Dados...");
            Console.WriteLine("-----    ---------------------");
            
            Console.Write("-----    Numero: ");
            client.Numero = Console.ReadLine();
            Console.Write("-----    Bandeira: ");
            client.Bandeira = Console.ReadLine();
            Console.Write("-----    CVV: ");
            client.Cvv = Console.ReadLine();
            Console.Write("-----    Limite: ");
            client.Limite = Console.ReadLine();
            Console.Write("-----    Saldo: ");
            client.Saldo = float.Parse( Console.ReadLine() );
            Console.WriteLine("-----    ---------------------");

            do
            {
                
                Console.WriteLine("\n\n Insira o Valor do Produto: ");
                produtoPrice = float.Parse( Console.ReadLine() );

                if (client.ValidarCompra() == true)
                {
                    
                    client.RegistrarCompra(true);

                } else {

                    client.RegistrarCompra(false);

                }


                Console.WriteLine("\n \nOperação Finalizada ");
                Console.WriteLine("\nDeseja realizar a compra de outro produto? \n\n");
                novamente = Console.ReadLine().ToUpper();
                
            } while (novamente == "SIM" || novamente == "S" || novamente == "SI");

            

        }
    }
}
