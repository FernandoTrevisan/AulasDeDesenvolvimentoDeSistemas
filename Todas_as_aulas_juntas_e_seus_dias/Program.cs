using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todas_as_aulas_juntas_e_seus_dias
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * aula dia 16/02/2022
            //console background cor muda 
            Console.BackgroundColor = ConsoleColor.Black;


            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("ola mundo");

            Console.WriteLine(2 + 2);

            Console.WriteLine("qual o valor de ");

            Console.WriteLine("3+3");

            Console.WriteLine("o valor é:" + (3 + 3));



            //faz som de beep
            Console.Beep();

            //adendo

            //dgitando o nome
            Console.WriteLine("digite seu nome");
            string nome = Console.ReadLine();
            //digitando idade
            Console.WriteLine("digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            //adendo


            //clear apaga o que esta pra cima do que eu esquecrevi 
            Console.Clear();


            // cria um loop //
            while (true)
            {
                Console.Beep();
            }

            Console.ReadKey();
            */

            /* 
             * aula dia 23/02/2022
            string nome, curso, cidade;

            Console.WriteLine("dite seu nome: ");
            nome = Console.ReadLine();


            Console.WriteLine("dite seu curso: ");
            curso = Console.ReadLine();

            Console.WriteLine("dite sua cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("seu nome é " + nome);
            Console.WriteLine("seu curso é " + curso);
            Console.WriteLine("sua cidade é " + cidade);

            Console.WriteLine("o nome digitado: " + nome + "    o curso digitado: " + curso + "    cidade digitada:" + cidade);

            Console.ReadKey();
            */

            /*
                string modelo, marca, cor, ano, quilometragem;

            Console.WriteLine("digite modelo do veiculo:");
            modelo = Console.ReadLine();

            Console.WriteLine("digite a cor do veiculo:");
            cor = Console.ReadLine();

                Console.WriteLine("digite ano do veiculo:");
                ano = Console.ReadLine();

                Console.WriteLine("digite marca do veiculo:");
                marca = Console.ReadLine();

            Console.WriteLine("digite quilometragem do veiculo:");
            quilometragem = Console.ReadLine();

                Console.WriteLine("seu veiculo é do modelo" + modelo +
                 "\nseu veiculo é da marca:" + marca +
                "\nseu veiculo é da cor:" + cor +
                "\nseu veiculo é do ano:" + ano +
                "\nseu veiculo é da quilometragem:" + quilometragem);

                Console.ReadKey();

                */



            /*
             *  Console.WriteLine("digite o primeiro número");
            int n1=int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo número");
            int n2 = int.Parse(Console.ReadLine());

            double resultado = n1 +n2;

            Console.Write("O resultado da soma é " +resultado );

            Console.ReadKey(); 
            */

            /*

            Console.WriteLine("valor gasto em transporte: ");

            double transporte = double.Parse(Console.ReadLine());

            Console.WriteLine("valor gasto em xerox: ");

            double xerox = double.Parse(Console.ReadLine());

            Console.WriteLine("valor gasto em cantina: ");

            double cantina = double.Parse(Console.ReadLine());

            Console.WriteLine("valor gasto em apm: ");

            double apm = double.Parse(Console.ReadLine());

            double resultado = transporte + xerox + cantina + apm;

            Console.WriteLine("o total gasto de: R$" + resultado);

            Console.ReadKey();

          */

            /* 
             *  aula dia 9/03/2022
             * calculadoura
             
            Console.WriteLine("informe o primeiro numero");

             double valor1 = double.Parse(Console.ReadLine());

             Console.WriteLine("informe o segundo numero ");

             double valor2 = double.Parse(Console.ReadLine());



             double soma = valor1 + valor2;

             double sub = valor1 - valor2;

           double mult = valor1 * valor2;

             double div = valor1 / valor2;



             Console.WriteLine("resultado da soma é : " + soma);

             Console.WriteLine("resultado da subitraçao é : " + sub);

             Console.WriteLine("resultado da multiplicaçao é : " + mult);

             Console.WriteLine("resultado da divisao é : " + div);
            
            Console.ReadKey();
            */

            /* idade de 3 alunos e saber a media da sala entre os alunos 
            
            Console.WriteLine("digite a idade do primeiro aluno: ");

            double aluno1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite  a idade do segundo aluno: ");

            double aluno2 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite a idade do terceiro aluno: ");

            double aluno3 = double.Parse(Console.ReadLine());





            double resultado = (aluno1 + aluno2 + aluno3) / 3;

            Console.WriteLine("o total é : " + resultado);
            
            Console.ReadKey();
             */

            /* distancia do carro em litros pra km calculadora de preço
            
            Console.WriteLine("informe o valor do litro: ");

            double valor_do_litro = double.Parse(Console.ReadLine());

            Console.WriteLine("informe a distancia da viagem: ");

            double valor_da_distancia = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o consumo do veiculo (km/litro): ");

            double quantos_km = double.Parse(Console.ReadLine());


            double gasto = (valor_da_distancia / quantos_km) * valor_do_litro;

            Console.WriteLine("o valor gasto foi de R$ : " + gasto.ToString("F2"));

            Console.ReadKey();

            */

            /* total dos dias vividos 
            
            Console.WriteLine("informe sua idade em anos:");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("informe sua idade em meses:");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("informe sua idade em dias:");
            int dias = int.Parse(Console.ReadLine());

            int tota_dias = (anos * 365) + (meses * 30) + dias;

            Console.WriteLine("o total de dias vividos é " + tota_dias);


            Console.ReadKey();

            */

            /* mudando valores 
            string a,b,c;

            Console.WriteLine("informe o valor de A:");
            a= Console.ReadLine();

            Console.WriteLine("informe o valor de B:");
            b= Console.ReadLine();

            c = a;

            a = b;

            b = c;

            Console.WriteLine("o novo valor de A é:" + a);
            Console.WriteLine("o novo valor de B é:" + b);

            Console.ReadKey();
            */


            /*
             * aula dia 16/03/2022

            /* ex3
            
            Console.Write("informe o salario fixo: ");
                double fixo = double.Parse(Console.ReadLine());

            Console.Write("informe a quantidade de peças vendidas:");
                int qtde = int.Parse(Console.ReadLine());

            Console.Write("informe o valor da comissao por peça:");
                double comissao = double.Parse(Console.ReadLine());

            Console.Write("informe a kilometragem percorrida: ");
            int km = int.Parse(Console.ReadLine());

            Console.Write("informe o valor por km percorrido");
            double valor_km = double.Parse(Console.ReadLine());

            double salario_final = fixo + (qtde * comissao) + (km * valor_km);

            Console.WriteLine("salario final do vendedor:" + salario_final.ToString("c"));

            Console.ReadKey();
            
             */

            /* ex4

            Console.Write("informe o raio do circulo é:");
              double raio = double.Parse(Console.ReadLine());

            double area = raio * 3.14;
            double diametro = 2 * raio;
            double perimetro = 2 * 3.14 * raio;
            
            Console.WriteLine("a area do circulo é:" + area +
                "diametro do circulo é:" + diametro +
                "o perimetro do circulo é:" + perimetro);
            
           console.ReadKey();

            */

            /* ex5
            */



            /* 
             * aula dia 30/03/2022
             * desafio 1 e 2 

            Console.Write("digite os graus em celcius?");
            int celsius = int.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine("graus em fahrenheit: " + fahrenheit);

            Console.Write("digite os graus em fahrenheit? ");
            int fahrenheit1 = int.Parse(Console.ReadLine());

            double celsius1 = (fahrenheit1  - 32  ) / 1.8;

            Console.WriteLine("graus em fahrenheit: " + celsius1);

            Console.ReadKey();
           
          */

            /*
            double qtde, valor, total;

            Console.Write("digite a quantidade do primeiro produto:  ");
            int qtde = int.Parse(Console.ReadLine());

            Console.Write("digite a quantidade do segundo produto:  ");
            qtde += int.Parse(Console.ReadLine());

            Console.Write("digite a quantidade do terceiro produto:  ");
            qtde += int.Parse(Console.ReadLine());

            Console.Write("digite a quantidade do primeiro produto:  ");
            int valor = int.Parse(Console.ReadLine());

            Console.Write("digite a quantidade do segundo produto:  ");
            valor += int.Parse(Console.ReadLine());

            Console.Write("digite a quantidade do terceiro produto:  ");
            valor += int.Parse(Console.ReadLine());


            double total = qtde * valor;

            Console.WriteLine("quantidade");


            Console.ReadKey();
            */

            /* 
             * aula dia 06/04/2022
             * utilizaçao do toupper e lower // if / else

            Console.Write("você gosta de programaçao?(S/N): ");
            
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
                Console.WriteLine("SIM");

            else
                Console.WriteLine("NÃO");

            Console.ReadKey();
            */

            /* ex 2
             
            Console.WriteLine("informe a quantidade comprada: ");
            double qtde = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o valor unitario: ");
            double valor = double.Parse(Console.ReadLine());

            double total = qtde * valor;

            if (qtde >= 100)
            {
                Console.Write("informe a % de desconto: ");
                double desconto = double.Parse(Console.ReadLine());

                total -= total * (desconto / 100);
            }        
            
                Console.WriteLine("informe o valor total da compra é: " + total.ToString("c"));
                
                Console.ReadKey();

            */

            /* ex3
             
            Console.Write("informe a renda familiar: ");
            double renda = double.Parse(Console.ReadLine());

            Console.Write("informe o valor gasto com alimentação: ");
            double alimentaçao = double.Parse(Console.ReadLine());

            Console.Write("informe o valor gasto com a farmacia: ");
            double farmacia = double.Parse(Console.ReadLine());

            Console.Write("informe o valor gasto com vestuario: ");
            double vestuario = double.Parse(Console.ReadLine());

            Console.Write("informe o valor dos outros gastos: ");
            double outros = double.Parse(Console.ReadLine());

            double final = renda - (alimentaçao + farmacia + vestuario + outros);

            if (final > 0)

                Console.WriteLine("ufa, esse mes a renda foi suficiente, sobraram " + final.ToString("c"));

            else
                Console.WriteLine("infelizmente a renda nao foi suficiente, faltaram " + (final * -1).ToString("c"));
            
            Console.ReadKey();

            */

            /* 
             * aula dia 13/04/2022
             
             * opçao correta sem erros
            
            Console.WriteLine("informe o sexo do usuario");
            string sexo = Console.ReadLine().ToUpper();

            if (sexo == "M")
                Console.WriteLine("o usuario é do sexo nasculino");
            else if (sexo == "F")
                Console.WriteLine("o usuario é do sexo feminino");
            else
                Console.WriteLine("opçao invalida");

            Console.ReadKey();
            */


            /*
            Console.Write("informe o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("informe o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("informe a operação que deseja utilizar (+,-,*,/): ");
            string op = Console.ReadLine();

            if (op == "+")
            {
                double res = n1 + n2;
                Console.WriteLine($"o resultado é: {res}");

            }
            else if (op == "-")
            {
                double res = n1 - n2;
                Console.WriteLine($"o resultado é: {res}");

            }

            else if (op == "*")
            {
                double res = n1 * n2;
                Console.WriteLine($"o resultado é: {res}");

            }

            else if (op == "/")
            {
                double res = n1 / n2;
                Console.WriteLine($"o resultado é: {res}");

            }

            else
                Console.WriteLine("opção invalidada");

            Console.ReadKey();

            */

            /*  dia 27/04/2022 

            Console.WriteLine("iformne o tipo da figura \nQ - quadrado \nR - Retangulo \nT - trapezio \nL losangulo");
            string figura = Console.ReadLine().ToUpper();

            double lado, area, base1, base2, diag1, diag2;
            switch (figura)
            {
                case "Q":
                    Console.WriteLine("informe o lado do quadrado");
                    lado = double.Parse(Console.ReadLine());
                    area = lado * lado;

                    Console.WriteLine("a area do quadrado é: " + area.ToString("F3"));

                    break;

                case "R":

                    Console.WriteLine("informe o lado do retangulo");
                    lado = double.Parse(Console.ReadLine());
                    Console.WriteLine("informe a altura do retangulo");
                    double altura = double.Parse(Console.ReadLine());
                    area = lado * altura;

                    Console.WriteLine("a area do retangulo é: " + area.ToString("F3"));

                    break;

                    Console.WriteLine("informe a primeira base do trapezio");
                    base1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("informe a segunda base do trapezio");
                    base2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("informe a altura do trapezio");
                    altura = double.Parse(Console.ReadLine());

                    area = ((base1 + base2) * altura) / 2;

                    Console.WriteLine("a area do trapezio é:" + area.ToString("F3"));

                case "L":

                    Console.WriteLine("informe a primeira diagonal do losango");
                    diag1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("informe a segunda diagonal do losango");
                    diag2 = double.Parse(Console.ReadLine());
                    area = (diag1 * diag2) / 2;

                    Console.WriteLine("a area do losango é: " + area.ToString("F3"));

                    break;

                default:

                    Console.WriteLine("figura não encontrada");

                    break;

            }


            Console.ReadKey();

            */


            /* dia 04/05/2022 

            int cont = 1;

            while(cont < 101)
            {
                Console.WriteLine(cont);
                cont++;

            }

            Console.ReadKey();
            
            int cont = 100;

            while (cont >= 1)
            {
                Console.WriteLine(cont);
                cont--;

            }

            Console.ReadKey();

            

            Console.Write("informe qual numero voce quer os mutiplos?");
            int mult = int.Parse(Console.ReadLine());

            int cont = mult;

            while (cont <= 100)
            {
                Console.WriteLine(cont);
                cont += mult;

            }


            Console.ReadKey();

            

            int cont = 0;

            while (cont <= 100)
            {
                Console.WriteLine(cont);
                cont += 2;

            }

            Console.ReadKey();

            


            Console.WriteLine("digite 0 para pares ou 1 para 1mpares: ");
            int opcao = int.Parse(Console.ReadLine());

            int cont = opcao;


            while (cont <= 20 )
            {
                Console.WriteLine(cont);
                cont += 2;
            }

            Console.ReadKey();
            */




















        }
    }
}
