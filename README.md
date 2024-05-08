<h1>DIO | Resumo .NET e C#</h1>

Repositório para armazenar resumos sobre .NET e C#. 
[Digital Innovation One](https://www.dio.me/en).

## 📚 Documentação 
- [Documentação .NET](https://git-scm.com/doc)
- [Documentação C#](https://docs.github.com/pt)

## 💻 Resumos das Aulas

| Aulas | Resumos |
|-------|---------|
| Resumo sobre .NET | [Resumos]() |

- Plataforma de desenvolvimento unificado que permite a construção de sistemas e aplicações, para isso utiliza o C# como linguagem de programação.
- Basicamente o .NET oferece aquilo que queremos construir e o C# é a maneira que será construido.

- Algumas possibiidades: 

| Tipo de Aplicação | Tipos de projeto |
|-------------------|------------------|
| Desktop | WPF, Windows Forms, UWP |
| WEB | ASP.NET |
| CLOUD | Azure |
| MOBILE | Xamarin |
| GAMING | Unity |
| IoT (Internet of Things) | ARM32, ARM64 |
| AI | ML.NET, .NET for Apache Spark |

- Oferece soluções para desenvolvimento dessas possibiidades.

### Um pouco de história 

- Microsoft queria implementar o conceito do java de multiplataforma numa linguagem própria.
- C# começou a ser desenvolvido no final dos anos 90, primeira versão lançada em 2002.
- .NET (também era chamado de .NETCORE) atual substituiu o .NET legado (ou .NET FRAMEWORK) que era usado só no windows e sua ultima versão foi a 4.8.
- A nova mentalidade é rodar multiplataforma.

### O que é um compilador?

- Basicamente faz o trabalho de traduzir o que foi escrito em uma linguagem de alto nível para uma de baixo nível.
 
- Linguagem de alto nível: a linguagem que entendemos e escrevemos nosso código fonte.
- Linguage de baixo nível: a linguagem que a máquina entende, possui pouca abstração, sendo difícil de entender. Basicamente traduzir para binário, bastante ligadas a alocação de memória. Ex: Assembly.

### Compilador do .NET

- Entrada do código -> C# compiler -> IL code (código intermediário) -> JIT compiler (just in time) -> código nativo

- Entrada do código -> C# compiler -> IL code (código intermediário): compile time
 -> JIT compiler (just in time) -> código nativo: runtime

### O que é um transpilador?

- Basicamente faz a conversão de uma linguagem ou implementação para outra. Sua saída permanece em linguagem de alto nível. Ex: Typescript para Javascript

### Nem toda linguagem é compilada !!

- Linguagem compilada: são as que o código fonte é traduzido para o código de máquina. Ex: C#, Java.
- Linguagem interpretada: são linguagens que fazem a leitura e interpretação diretamente do código fonte. Ex: Javascript, PHP.

### O que é uma IDE? 

- Integrated Development Environment: ambiente de desenvolvimento integrado
- É um software que facilita e integra diversas facilidades para a escrita e depuração do código. Ex: Cores diferentes para diferentes classes, variáveis, metódos e etc; autocomplete, intellisense
- Basicamente é um programa que nos auxilia a desenvolver

-> Visual Studio: é a principal IDE para o .NET, com suporte para o C#, C++, Python, Node.js, Unity e mobile.
 - Oferece uma grande quantidade de informações na depuração, versão gratuíta.
 - Não disponível para Linux, e é bastante pesado, exigindo muitos recursos da máquina.

- SDK: para executar e desenvolver.
- Runtime: apenas para executar.

### O que são classes?

- A classe é basicamente o molde de um objeto. Ex: classe pessoa, atributos/propriedades nome e idade, metódo apresentar().
- Está relacionada com o conceito de abstração da POO.
- Uma abstração é transformar um objeto do mundo real em um objeto da programação, abstraindo apenas o que é necessário representar.  
- Metódos: ações que sua classe vai realizar.

### Tipos de dados

| Tipo | Representa | Até onde vai | default value |
|------|------------|--------------|---------------|
| string | cadeia de caracteres |
| char | caractere unicode |
| object | tipo de objeto |
| bool | valor booleano | true or false | false |
| byte | 8-bit | 0 ate 255 | 0 |
| decimal | decimal values with 28-29 significant digits | (+ or -)1.0 x 10e-28 ate 7.9 x 10e28 | 0.0M
| double | 64 bit double-precision floating point type | (+/-)5.0 X 10 raise to -324 ate (+/-)1.7 x 10 raise to 308 | 0 |
| int | 32 bit signed integer type | -2.bilhoes ate +2bilhoes | 0 |
| float | 32 bit single precision floating point type | -3.4 x 10 raise to 38 ate +3.4 x 10 raise to 38 | 0.0F
| long | 64 bit signed integer type | -9quinquilhoes ate +9quinquilhoes | 0L |
| uint | 32 bit unsigned integer type | 0 ate 4.bilhoes | 0 |
| short | 16 bit signed integer type | -32mil ate +32mil | 0 |
| ulong | 64 bit unsigned integer type | 0 ate 18quinquilhoes | 0 |

- decimal é ótimo para valores monetários.

### Tipos de Operadores

| Tipo | O que faz |
|------|-----------|
| operador de atribuição = | Atribui/modifica o valor | 
| Operador combinado += / -= / *= | modifica somando o valor. c += 5 é equivalente a c = c + 5. |
| operador condicional if(condição) {código} else(condição) {código} | Julga se uma condição é verdadeira para realizar determinada ação no código |
| operador comparação >, <, >=, =< | comparam determinada condição |
| operador comparação == | compara se um valor é igual a outro valor |
| operador lógico soma && | junta condições que precisam ocorrer |
| operador lógico "ou" "duas barras em pé" | pode ocorrer ou uma condição ou outras |
| operador lógico "NOT" ! | Nega uma variável, esperando o valor inverso (exemplo: em um if ele espera que o booleano seja true, mas ao passar ! na frente, o if irá espera que a condição seja falsa)|
| operador lógico != "diferente de" | compara se a condição é diferente do pedido |
| operadores aritméticos + - * / | representam as operações básicas |
| operador arimético modulo % | retorna o resto da divisão |
| operador de incremento ++ | aumenta o valor da variável em 1 |
| operador de decremento -- | diminui o valor da variável em 1 |

### Laços de Repetição

| Laço | Funcionamento |
|------|-----------|
| For | realizado para métricas especificas |
| While | realizado enquanto uma condição for verdadeira |

### .NET5 E .NET6

-> No .NET6 em diante, existe um metodo main que não aparece pois está escondido.
-> Em Versões antigas esse metodo fica explícito.

```
Em .NET5
using System;

namespace introducao_NET5.NET5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("Hello World");
        }
    }
}
```
```
Em .NET6 
Console.Writeline("Hello World");
```
### Array e Listas

-> o array é uma estrutura de dados que armazena valores do mesmo tipo, com um tamanho fixo.

-> Formas de passar o array:
1. int[] array = new int[4];
2. int[] array = new int[] {42, 75, 74, 61}; -> nesse caso pode emitir o 4 já que foram passados os valores.
3. string[] nomes = {"jan", "fev"};

-> índice: posição de um determinado valor de um array, sempre começando com zero.

| posição | valores |
|---------|---------|
| 0 | 42 |
| 1 | 75 |
| 2 | 74 |
| 3 | 61 |

1. int elemento = array[0];
2. array[0] = 42;

-> Listas são basicamente a extensão de um array, não precisando declarar o seu tamanho, e possuindo muito mais metódos para manusear o seu conteudo.

-> Como declarar uma lista: 
List<string> listaString = new List<string>();


## 🔍 Referências
- [Digital Innovation One]().
