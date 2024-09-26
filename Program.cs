using System;
using System.Text.RegularExpressions;
namespace cadastro_console
{
    internal class Program
    {
        static float escolha_genero;
        static string email;
        static string senha;
        static string nome;
        static void Main(string[] args)
        {
            bool informou_certo = false; // Variável principal pra criar os loops do código.
            int genero_informado = 0;

            while (!informou_certo)
            {
                while (!informou_certo) // Começa o cadastro.
                {
                    Console.WriteLine("------------| TELA DE CADASTRO EM C# |------------");

                    TipoGenero(); // Função para informar o tipo de gênero do usuário.

                    switch (escolha_genero)
                    {
                        case 1:
                            genero_informado = 1;
                            informou_certo = true;
                            break;
                        case 2:
                            genero_informado = 2;
                            informou_certo = true;
                            break;
                        case 3:
                            genero_informado = 3;
                            informou_certo = true;
                            break;
                    }

                }
                informou_certo = false;

                while (!informou_certo)
                {
                    Console.Clear();
                    while (!informou_certo) // Nome do usuário.
                    {
                        Console.WriteLine("Informe seu nome: ");

                        string caracteres_invalidos = @"^[A-Z]{1}[a-zA-Z\s]+$"; // Faz um regex para verificar se o usuário inseriu o nome corretamente.
                        nome = Console.ReadLine();

                        if (Regex.IsMatch(nome, caracteres_invalidos)) // Nome informado corretamente.
                        {
                            informou_certo = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Você informou seu nome incorretamente.");
                        }
                    }
                    informou_certo = false;

                    while (!informou_certo) // Cadastro do email do usuário.
                    {
                        Console.WriteLine("Digite seu e-mail: ");
                        string caracteres_validos = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(?:\.[a-zA-Z]{2,})?$"; // Regex pra verificar se o email e domínio são válidos.
                        email = Console.ReadLine();
                        if (Regex.IsMatch(email, caracteres_validos))
                        {
                            bool informou_certo2 = false;
                            while (!informou_certo2)
                            {
                                Console.Clear();
                                Console.WriteLine("Confirme seu email digitando novamente:"); // Pede para o usuário confirmar o email caso ele insira incorretamente.
                                string confirmar_email = Console.ReadLine();
                                if (confirmar_email == email)
                                {
                                    informou_certo = true;
                                    informou_certo2 = true;
                                }
                                else
                                {
                                    bool informou_certo3 = false;
                                    while (!informou_certo3)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Você digitou errado o email! Deseja:\n[1] - Reinformá-lo\n[2] - Criar um novo email");
                                        int escolha = int.Parse(Console.ReadLine());
                                        switch (escolha)
                                        {
                                            case 1:
                                                informou_certo3 = true;
                                                Console.Clear();
                                                break;
                                            case 2:
                                                informou_certo2 = true;
                                                informou_certo3 = true;
                                                Console.Clear();
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Você digitou errado o email.");
                        }
                    }
                    Console.Clear();
                    informou_certo = false;
                    
                    Console.WriteLine($"Seu email: {email}");
                    Console.WriteLine("Pressione Qualquer tecla para continuar..");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Agora, vamos criar uma senha!");

                    informou_certo = false;

                    while (!informou_certo) // Cadastro da senha do usuário.
                    {
                        Console.WriteLine("Informe sua senha: ");
                        senha = Console.ReadLine();
                        Console.Clear();

                        bool informou_certo2 = false;

                        while (!informou_certo2) // Pede para o usuário confirmar a senha caso ele insira incorretamente.
                        {
                            Console.WriteLine("Confirme sua senha digitando-a novamente: ");
                            string confirmar_senha = Console.ReadLine();
                            if (confirmar_senha != senha)
                            {
                                bool informou_certo3 = false;
                                while (!informou_certo3)
                                {
                                    Console.WriteLine("Você digitou errado a senha! Deseja:\n[1] - Reinformá-la\n[2] - Criar uma nova senha");
                                    int escolha = int.Parse(Console.ReadLine());
                                    switch (escolha)
                                    {
                                        case 1:
                                            informou_certo3 = true;
                                            Console.Clear();
                                            break;
                                        case 2:
                                            informou_certo2 = true;
                                            informou_certo3 = true;
                                            Console.Clear();
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                informou_certo = true;
                                break;
                            }
                        }
                    }
                }

                // Conclui o cadastro do usuário.

                Console.Clear();
                Console.WriteLine("CADASTRO CONCLUÍDO COM ÊXITO!");
                Console.WriteLine("Agora, vamos fazer o login!");

                informou_certo = false;

                while (!informou_certo) // Começa o login, pedindo o email cadastrado do usuário.
                {
                    Console.Write("Digite seu email: ");
                    string login_email = Console.ReadLine();

                    if (login_email != email) // Confirma se o email foi digitado corretamente.
                    {
                        Console.WriteLine("Você informou seu email incorretamente!");
                        Console.WriteLine("Pressione qualquer tecla para digitar seu email novamente..");
                        Console.ReadKey();
                    }
                    else
                    {
                        informou_certo = true;
                    }
                }
                informou_certo = false;
                while (!informou_certo)
                {
                    Console.WriteLine("Digite sua senha: ");
                    string login_senha = Console.ReadLine();
                    string confirmar_senha = senha;

                    if (login_senha != confirmar_senha) // Confirma se a senha foi digitada corretamente.
                    {
                        Console.WriteLine("Você informou a senha incorretamente!");
                        Console.WriteLine("Pressione qualquer tecla para continuar..");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        break;
                    }
                }
                Console.Clear();

                switch (escolha_genero) // Dependendo do gênero escolhido anteriormente, o programa mostrará outras saudações ao usuário.
                {
                    case 1:
                        Console.WriteLine($"Bem-Vindo, {nome}!");
                        Console.WriteLine($"Hoje é {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}"); // Informa a data atual em formato de DD/MM/AAAA.
                        Console.WriteLine($"Agora são {DateTime.Now.Hour}:{DateTime.Now.Minute}"); // Informa as horas e minutos atuais em formato de HH:MM.
                        break;
                    case 2:
                        Console.WriteLine($"Bem-Vinda, {nome}!");
                        Console.WriteLine($"Hoje é {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}");
                        Console.WriteLine($"Agora são {DateTime.Now.Hour}:{DateTime.Now.Minute}");
                        break;
                    case 3:
                        Console.WriteLine($"Olá, {nome}!");
                        Console.WriteLine($"Hoje é {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}");
                        Console.WriteLine($"Agora são {DateTime.Now.Hour}:{DateTime.Now.Minute}");
                        break;
                }
                Console.WriteLine("\nFIM DO PROGRAMA!");
                Console.WriteLine("Pressione qualquer tecla pra sair..");
                Console.ReadKey();
                informou_certo = true; // Acaba o programa.
            }
        }
        static void TipoGenero() // Função do tipo de gênero do usuário.
        {
            Console.WriteLine("Para começar, informe seu gênero:");
            Console.WriteLine("1 - Masculino\n2 - Feminino\n3 - Outro");
            escolha_genero = float.Parse(Console.ReadLine());
            Console.Clear();
        }
    }
}