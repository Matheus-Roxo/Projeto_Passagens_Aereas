using System;

namespace Projeto_Passagens_Aereas
{
  class Program
    {
        static void Main(string[] args)
        {
             string[] names = new string[2];
            string[] origin = new string[2];
            string[] destiny = new string[2];
            string[] date = new string[2];

            Console.WriteLine("Sistema de passagens aéreas");

            bool passwordValidation;

            do{

                Console.Write("Digite a sua senha: ");
                string password = Console.ReadLine();
                passwordValidation = EfetuarLogin(password);

            } while(!passwordValidation);

            int choice;
            int contador = 0;

            do{

               Console.WriteLine("Menu inicial:");
               Console.WriteLine("Selecione uma opção abaixo:");
               Console.WriteLine("[1] Cadastrar passagem");
               Console.WriteLine("[2] Listar passagens");
               Console.WriteLine("[0] Cadastrar passagem");
               choice = int.Parse(Console.ReadLine());

               switch(choice){

                   case 1:
                        string answer;

                        do{

                            if(contador < names.Length){
                                Console.Write($"Digite o nome do {contador+1}º passageiro: ");
                                names[contador] = Console.ReadLine();
                                
                                Console.Write($"Digite a origem do {contador+1}º passageiro: ");
                                origin[contador] = Console.ReadLine();

                                Console.Write($"Digite o destino do {contador+1}º passageiro: ");
                                destiny[contador] = Console.ReadLine();

                                Console.Write($"Digite a data do vôo do {contador+1}º passageiro: ");
                                date[contador] = Console.ReadLine();

                                contador++;

                            } else {

                                Console.WriteLine("O limite foi excedido.");
                            }

                            System.Console.WriteLine("Mais algum passageiro para cadastrar?");
                            System.Console.WriteLine("[S] - Sim");
                            System.Console.WriteLine("[N] - Não");
                            answer = Console.ReadLine();

                        } while (answer.ToUpper() == "S");
                        break;

                    case 2:
                        for(int i = 0; i < names.Length; i++){
                            Console.WriteLine($"Nome do {i+1}º passageiro: {names[i]}");

                            Console.WriteLine($"Origem do {i+1}º passageiro: {names[i]}");

                            Console.WriteLine($"Destino do {i+1}º passageiro: {names[i]}");

                            Console.WriteLine($"Data do vôo do {i+1}º passageiro: {names[i]}");
                        }
                        break;

                    case 0:

                        break;

                    default:
                        break;

               }

            } while (choice != 0);
            
            bool EfetuarLogin(string password){
                
                if(password == "123456"){
                    return true;

                } else {

                    Console.WriteLine("A senha está incorreta");
                    return false;
                }
            }
        }
    }
}
