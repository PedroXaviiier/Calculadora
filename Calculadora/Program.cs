namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            int tipoDeConta;
            double resposta;

            do
            {

                Console.WriteLine("Infome o tipo de conta: \n" +
                                  "0 - adicao \n" +
                                  "1 - subtracao \n" +
                                  "2 - divisao \n" +
                                  "3 - multiplicacao \n" +
                                  "4 - sair");
                tipoDeConta = Convert.ToInt32(Console.ReadLine());

                while(tipoDeConta > 4 || tipoDeConta < 0)
                {

                    Console.WriteLine("Tipo invalido, tente novamente: ");

                    Console.WriteLine("Infome o tipo de conta: \n" +
                                  "0 - adicao \n" +
                                  "1 - subtracao \n" +
                                  "2 - divisao \n" +
                                  "3 - multiplicacao \n" +
                                  "4 - sair");
                    tipoDeConta = Convert.ToInt32(Console.ReadLine());
                }

                if (tipoDeConta == 4)
                    break;
                    
                Console.WriteLine("informe o primeiro numero: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("informe o segundo numero: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                switch (tipoDeConta)
                {
                    case 0: resposta = numero1 + numero2;

                        Console.WriteLine($"O resultado é: " + resposta + "\n");

                        break;

                    case 1: resposta = numero1 - numero2;

                        Console.WriteLine($"O resultado é: " + resposta + "\n");

                        break;

                    case 2: resposta = numero1 / numero2;

                        if (numero2 == 0)
                            Console.WriteLine("Indefinido");

                        else
                            Console.WriteLine($"O resultado é: " + resposta + "\n");

                        break;

                    case 3: resposta = numero1 * numero2;

                        Console.WriteLine($"O resultado é: " + resposta + "\n");

                        break;

                }

            }
            while (tipoDeConta != 4);
            


                Console.WriteLine(" obrigado por usar a calculadora ");


        }
    }
}


