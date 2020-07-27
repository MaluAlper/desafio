using System;

namespace desafio
{
    class Program
    {
        static void Main(string[] args)

     

        {
            int x, y, resultado ;
            string operacao, resp;


            Console.Write("Digite um valor: ");
            x=int.Parse(Console.ReadLine());

           Console.Write("Sinal Operador: ");
           operacao = Console.ReadLine();


            Console.Write("Digite outro valor: ");
            y=int.Parse(Console.ReadLine());

            switch(operacao)
            {
                case "+":
                resultado=x+y;
                Console.WriteLine("O valor é: " + resultado);
                break;

                case "-":
                resultado=x-y;
                Console.WriteLine("O valor é: " + resultado);
                break;

                case "/":
                resultado=x/y;
                Console.WriteLine("O valor é: " + resultado);
                break;

                case "*":
                resultado=x*y;
                Console.WriteLine("O valor é: " + resultado);
                break;
                
                case "%":
                resultado=x*y/100;
                Console.WriteLine("O valor é: " + resultado);
                break;

                             
                       }
             Console.Write("Deseja continuar? ");
                resp = Console.ReadLine();

                if (resp == "N")
                {
                    Console.ReadKey();
                }
                else if
                
                 (resp == "S")
                              
                {  Console.Write("Digite novamente:" );
                }
                return ;
               
    
                }
                    
        }
    }

                    

                     
                
            

                
          
            
            
         
         


                    




        
    

