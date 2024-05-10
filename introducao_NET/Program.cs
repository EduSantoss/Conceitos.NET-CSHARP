using introducao_NET.Common.Models;

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

// string? opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//    Console.WriteLine("-----------------------------------------");
//    Console.WriteLine("Digite a sua opção:");
//    Console.WriteLine("1 - Cadastrar cliente");
//    Console.WriteLine("2 - Buscar cliente");
//    Console.WriteLine("3 - Apagar cliente");
//    Console.WriteLine("4 - Encerrar");
//    Console.WriteLine("-----------------------------------------");

//    opcao = Console.ReadLine();
//    Console.Clear();

//    switch(opcao)
//    {
//       case "1":
//          Console.WriteLine("--> Cadastro de cliente");
//          break;
//       case "2":
//          Console.WriteLine("--> Buscar cliente");
//          break;
//       case "3":
//          Console.WriteLine("--> Apagar cliente");
//          break;
//       case "4":
//          Console.WriteLine("--> Encerrar");
//          // Environment.Exit(0);
//          exibirMenu = false;
//          break;         
//       default:
//          Console.WriteLine("Opção inválida");
//          break;
//    }
// }

// declarando array -> tentar acessar uma posição inexistente irá quebrar o código

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

// basicamente o que o resize faz, porém aqui é criado propriamente o novo array, nome diferente.
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// redimensionando o tamanho de um array, situações que o código já está compilado.
// Array.Resize cria uma cópia do array antigo com novos espaços, copiando os elementos do antigo para o novo.
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


Console.WriteLine("Percorrendo o Array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
     Console.WriteLine($"Posição N° {contador} -> {arrayInteiros[contador]}");
}

// Console.WriteLine("Percorrendo o Array com o FOREACH");
// mais simples, porém sem contador, se precisar dele teria q criar por fora
// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//      Console.WriteLine($"Posição N° {contadorForeach} -> {valor}");
//      contadorForeach++;
// }

// declarando uma lista -> basicamente uma extensão para um array melhorado, não é preciso definir o tamanho, mais fácil de manusear

List<string?> itens = new List<string?>(3);

// TODO: Solicite os itens ao usuário
for (int contador = 0; contador < itens.Capacity; contador++)
{
     itens.Add(Console.ReadLine());
}

// Exibe a lista de itens
Console.WriteLine("Lista de itens:");
foreach (string? item in itens)
{
     Console.WriteLine($"- {item}");
}

List<string> listaString = new List<string>(3);

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

//listaString.Add(Console.ReadLine());

// debugando e vendo o funcionamento de uma lista
Console.WriteLine($"Itens na minha lista: {listaString.Count} -> Capacidade: {listaString.Capacity}");
listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} -> Capacidade: {listaString.Capacity}");
listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} -> Capacidade: {listaString.Capacity}");


Console.WriteLine("Percorrendo a lista com o FOR");
for (int contador = 0; contador < listaString.Count; contador++)
{
     Console.WriteLine($"Posição N° {contador} -> {listaString[contador]}");
}

Console.WriteLine("Percorrendo a lista com o FOREACH");
int contadorForeach = 0;
foreach (string item in listaString)
{
     Console.WriteLine($"Posição N° {contadorForeach} -> {item}");
     contadorForeach++;
}





