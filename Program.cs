using introducao_NET.models;

// variável 1 (pessoa1), new significa que uma Pessoa foi construida, ai agora ela pode ter seus atributos modificados
// isso abaixo é o chamado de instanciar um objeto, equivalente a criá-lo na memória
// ao colocar o tipo da variável, vc está declarando ela a primeira vez, caso só repita o nome ai vc está alterando a variável.

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Eduardo";
// pessoa1.Idade = 23;
// pessoa1.Apresentar();

// convertendo tipos de variáveis (chamado de cast ou casting). Exemplos reais: necessidade de converte dados vindos de uma api, que venham em string e precise passar para um inteiro por exemplo.
// diferença entre convert e parse: basicamente em relação ao tratamento de nulos. informações externas.
// o convert vai converter o null para 0 
// já o parse nao aceita valor null, retornando uma exception e fechando o programa.
// cuidado nessas conversões pois caso nao consiga converter o programa fechara por uma exception

// int a = Convert.ToInt32("5");
// int b = int.Parse("5");
// int c = 5;
// string d = c.ToString();
// Console.WriteLine(a);

// tryParse espera que dê algum erro, e caso nao converta ele nao vai encerrar o programa
//int.TryParse(a, out b);

// implementando if

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 00)
// {
//     Console.WriteLine("venda inválida");
// }

// else if (possivelVenda)
// {
//     Console.WriteLine("venda realizada");
// }
// else 
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }

// agora um programa para saber se a letra digitada é uma vogal ou não
// utilização de switch case

// Console.WriteLine("Digite uma letra ");
// string? letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//        Console.WriteLine("Vogal");
//        break;
//     default:
//        Console.WriteLine("Não é uma vogal");
//        break;   
// }


// if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
// {
//     Console.WriteLine("vogal");
// }
// else 
// {
//     Console.WriteLine("Não é uma vogal");
// }

// operador NOT ! 

// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//    Console.WriteLine("vou pedalar");
// }
// else
// {
//    Console.WriteLine("vou pedalar um outro dia");
// }


// Calculadora calc = new Calculadora();

// calc.Somar(10 , 10);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(49);

// incremento e decremento 

// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("incrementando o 10");
// numero++;

// Console.WriteLine(numero);

// laços de repetição -> for

// int num = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//    Console.WriteLine($"{num} x {contador} = {num * contador}");
// }

// laços de repetição -> while 
// cuidado no loop infinito

// int num2 = 5;
// int i = 0;

// while (i <= 10)
// {
//    Console.WriteLine($"{i + 1}° Execução: {num2} x {i} = {num2 * i}");
//    i++;

//    // sair do fluxo de execução. Exemplo: estiver procurando algo e quando achar, parar a execução.
//    if (i == 6)
//    {
//       break;
//    }
// }

// laços de repetição -> DO WHILE
// vai primeiro executar e depois checar se a condição para pausa é verdaodeira. No caso abaixo, vai executar ate o número digitado ser o 0.

// int soma = 0, numero = 0;

// do
// {
//      Console.WriteLine("Digite um número (0 irá parar a execução)");
//      numero = Convert.ToInt32(Console.ReadLine());

//      // junta valores
//      soma += numero;
     

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

// construindo um menu interativo

string? opcao;
bool exibirMenu = true;

while(exibirMenu)
{
   Console.WriteLine("-----------------------------------------");
   Console.WriteLine("Digite a sua opção:");
   Console.WriteLine("1 - Cadastrar cliente");
   Console.WriteLine("2 - Buscar cliente");
   Console.WriteLine("3 - Apagar cliente");
   Console.WriteLine("4 - Encerrar");
   Console.WriteLine("-----------------------------------------");

   opcao = Console.ReadLine();
   Console.Clear();

   switch(opcao)
   {
      case "1":
         Console.WriteLine("--> Cadastro de cliente");
         break;
      case "2":
         Console.WriteLine("--> Buscar cliente");
         break;
      case "3":
         Console.WriteLine("--> Apagar cliente");
         break;
      case "4":
         Console.WriteLine("--> Encerrar");
         // Environment.Exit(0);
         exibirMenu = false;
         break;         
      default:
         Console.WriteLine("Opção inválida");
         break;
   }
}