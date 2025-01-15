# 🚀 Aprendendo C# e Orientação a Objetos

Este repositório foi criado para documentar minha jornada de aprendizado em C#, com foco em conceitos fundamentais e avançados de programação orientada a objetos (OO). Aqui, você encontrará resumos teóricos, exemplos práticos e exercícios sobre os principais tópicos que fazem parte do curso.

## 🔍 O que estou aprendendo?

O curso cobre uma ampla gama de conceitos em C# e OO, incluindo:

- **Conceitos básicos de C# e estrutura de classes.**
- **Orientação a Objetos (OO)**: composição, herança e encapsulamento.
- **Coleções e manipulação de dados.**
- **Manipulação de arquivos.**
- **LINQ (Language Integrated Query).**
- **Lambda Expressions.**
- **Delegates e eventos.**

---

Abaixo você encontrará explicações e exemplos organizados por tópico. Este conteúdo está em constante atualização conforme avanços no curso. Vamos juntos nessa jornada!
## 🖥️ Introdução a C# e .NET

C# (pronuncia-se "C sharp") é uma linguagem de programação moderna, orientada a objetos e desenvolvida pela Microsoft. Ela é amplamente utilizada para criar aplicações robustas, incluindo sistemas desktop, web, jogos (com Unity) e muito mais.

O .NET é uma plataforma de desenvolvimento que oferece as ferramentas necessárias para construir e executar aplicações em diferentes dispositivos e sistemas operacionais. Ele fornece bibliotecas, APIs e suporte para diversas linguagens, incluindo C#.

### ✨ Vantagens do C# e .NET

- **Multiplataforma**: com .NET Core, você pode desenvolver para Windows, Linux e macOS.
- **Orientado a Objetos**: facilita o design e a organização do código.
- **Performance**: permite criar aplicações rápidas e eficientes.
- **Comunidade e suporte**: ampla documentação e comunidades ativas.

---

### 📌 Primeiro Programa em C#

O tradicional "Hello, World!" é um ótimo ponto de partida. Veja como criar um programa básico em C#:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```
## 🧠 Recapitulação de Lógica de Programação

Antes de mergulhar nos conceitos avançados de C#, é essencial relembrar os fundamentos da lógica de programação. Dois pilares importantes são as **estruturas condicionais** e as **estruturas de repetição**, que permitem criar fluxos de execução dinâmicos no código.

---

### 🔹 Estruturas Condicionais: `if` e `else`

As estruturas condicionais são usadas para tomar decisões no programa com base em condições.

#### **Exemplo em C#:**
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }
}
```
### 🔹 Estruturas de Repetição

As estruturas de repetição são usadas para executar um bloco de código várias vezes, até que uma condição seja satisfeita.

#### **Tipos de Laços em C#:**
- **`while`**: Executa enquanto a condição for verdadeira.
- **`for`**: Ideal para loops com contadores, quando você sabe de antemão o número de iterações.
- **`do-while`**: Executa o código pelo menos uma vez antes de verificar a condição.

---

#### **Exemplo com `while`:**
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int contador = 1;

        while (contador <= 5)
        {
            Console.WriteLine($"Contagem: {contador}");
            contador++; // Incrementa o contador
        }
    }
}
```
## 🏗️ Classes

Em C#, **classes** são moldes (ou templates) usados para criar objetos. Uma classe define as propriedades (atributos) e comportamentos (métodos) que um objeto pode ter. As classes são um dos pilares da programação orientada a objetos (OO) e ajudam a organizar o código em blocos reutilizáveis.

### 🔹 Definição de uma Classe

Uma classe é composta por dois principais componentes:
1. **Atributos (ou Propriedades)**: Características do objeto.
2. **Métodos (ou Funções)**: Ações que o objeto pode realizar.

#### **Exemplo de Classe em C#:**

```csharp
using System;

class Carro
{
    // Atributos
    public string Modelo;
    public string Cor;
    public int Ano;

    // Método
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Ano: {Ano}");
    }
}
```
```
class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Carro
        Carro meuCarro = new Carro();
        
        // Atribuindo valores aos atributos
        meuCarro.Modelo = "Fusca";
        meuCarro.Cor = "Azul";
        meuCarro.Ano = 1980;

        // Chamando o método da classe
        meuCarro.ExibirInformacoes();
    }
}
```
### 🔍 Explicação do Código:
**Classe Carro:* Definimos a classe com três atributos (Modelo, Cor, Ano) e um método (ExibirInformacoes).
*Objeto meuCarro:* Criamos uma instância da classe Carro e atribuimos valores aos seus atributos.
*Chamada de Método:* Usamos o método ExibirInformacoes() para exibir as propriedades do carro no console.
### 📌 Como Funciona:
Atributos são como "variáveis" de uma classe e são usados para armazenar dados sobre o objeto.
Métodos são funções dentro da classe que definem o que o objeto pode fazer, como manipular ou retornar seus dados.
