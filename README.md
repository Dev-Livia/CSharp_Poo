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
## 🔹 Atributos

Em C#, **atributos** são as variáveis que definem as características de uma classe ou objeto. Eles são usados para armazenar dados sobre o estado do objeto. Os atributos são conhecidos também como **propriedades**, e podem ter diferentes modificadores de acesso, como `public`, `private`, `protected`, etc.

### 📌 Características dos Atributos

- **Tipo de Dados**: Atributos podem ser de qualquer tipo, como tipos primitivos (`int`, `string`, `bool`) ou tipos definidos pelo usuário (outras classes).
- **Modificadores de Acesso**: Atributos podem ser `public`, `private`, `protected`, entre outros, controlando o acesso a eles.
- **Inicialização**: Atributos podem ser inicializados no momento da declaração ou dentro do construtor da classe.
  
### 🔐 Encapsulamento

O **encapsulamento** é um princípio da programação orientada a objetos que visa esconder os detalhes internos de implementação de uma classe, fornecendo uma interface pública para interagir com ela. No caso dos atributos, isso significa que eles podem ser privados e acessados ou modificados somente por métodos ou propriedades públicas.

#### Modificadores de Acesso Comuns:
- **`public`**: O atributo é acessível de qualquer lugar.
- **`private`**: O atributo só pode ser acessado dentro da própria classe.
- **`protected`**: O atributo é acessível dentro da classe e em classes derivadas.
- **`internal`**: O atributo é acessível apenas dentro do mesmo assembly (projeto).

### 🚀 Dicas de Uso:
- Utilize o **encapsulamento** para proteger atributos, tornando-os privados e acessando-os por meio de métodos ou propriedades públicas.
- Atributos **privados** são úteis para evitar modificações não controladas de seus valores.
- Lembre-se de que os **atributos são essenciais** para definir o estado do objeto, ou seja, tudo que o objeto pode armazenar ou representar.

## 🔹 Métodos

Em C#, **métodos** são blocos de código definidos dentro de uma classe que realizam ações, como manipular dados ou executar operações. Eles definem o comportamento do objeto, ou seja, o que o objeto pode fazer com os dados que contém.

### 📌 Características dos Métodos

- **Declaração**: Um método é composto por um tipo de retorno (pode ser `void`, caso o método não retorne valor), um nome, e um bloco de código com a lógica a ser executada.
- **Parâmetros**: São valores passados para o método no momento de sua chamada, permitindo que ele receba e utilize dados externos.
- **Retorno**: Pode ser qualquer tipo de dado, ou `void` caso o método não retorne nada.
  
### 🔐 Tipos de Métodos

1. **Métodos de Instância**: Estão associados a objetos da classe e podem acessar os atributos e outros métodos da instância. 
   
2. **Métodos Estáticos**: Pertencem à classe, e não a uma instância específica. Eles não podem acessar diretamente os atributos de instância, mas podem acessar membros estáticos.

3. **Métodos com Parâmetros**: Permitem que dados sejam passados para o método, para que ele os utilize na execução de sua lógica.

4. **Métodos com Retorno**: O método realiza uma operação e retorna um valor, que pode ser usado por quem o chamou. Se o método não retornar nenhum valor, o tipo de retorno é `void`.

### 🚀 Dicas de Uso:

- **Métodos** devem ser usados para organizar e modularizar o código, promovendo reutilização e clareza.
- **Métodos estáticos** são mais indicados quando não há necessidade de acessar dados específicos de objetos, como em operações utilitárias.
- **Métodos de instância** devem ser usados quando é necessário acessar ou modificar atributos de objetos.
- Quando um método precisa retornar um valor, isso deve ser bem planejado para que o valor retornado seja útil e permita a continuidade de operações.

### 🧠 Melhores Práticas:

- **Modularize seu código** usando métodos para tornar o código mais limpo e fácil de entender.
- Evite **métodos muito grandes ou com muitos parâmetros**, pois isso pode dificultar a manutenção do código. Considere dividir grandes métodos em vários menores, com responsabilidades bem definidas.
- Use **nomes de métodos claros e significativos** para indicar claramente a ação que o método realiza.
## 🔹 Membros Estáticos

Em C#, **membros estáticos** são elementos de uma classe que pertencem à própria classe e não a uma instância específica dela. Isso significa que você pode acessar membros estáticos diretamente pela classe, sem a necessidade de criar um objeto da classe. Membros estáticos incluem atributos, métodos e até propriedades.

### 📌 Características dos Membros Estáticos

- **Atributos Estáticos**: São variáveis que pertencem à classe e não a um objeto específico. Eles têm o mesmo valor para todas as instâncias da classe.
- **Métodos Estáticos**: São métodos que também pertencem à classe, e não a objetos. Eles não podem acessar membros de instância diretamente, mas podem acessar membros estáticos.
- **Propriedades Estáticas**: São usadas para acessar valores estáticos de uma classe, de forma similar aos atributos estáticos.
  
### 🔐 Como Funciona

- Membros estáticos podem ser acessados diretamente pela classe, sem a necessidade de criar uma instância.
- Eles podem ser utilizados para armazenar dados ou comportamentos que são comuns a todas as instâncias de uma classe.
- **Exemplo de uso típico**: Contadores globais, métodos de utilidade, ou valores constantes que não dependem de objetos individuais da classe.

### 🚀 Dicas de Uso:

- Use **membros estáticos** para representar dados ou comportamentos que devem ser compartilhados por todas as instâncias de uma classe.
- **Métodos estáticos** são úteis para funções de utilidade, como cálculos matemáticos ou operações que não dependem do estado de instâncias.
- Membros estáticos não podem acessar membros de instância diretamente. Para acessar atributos ou métodos de instância, você precisará de uma referência a um objeto específico.

### 🧠 Melhores Práticas:

- Use **membros estáticos** quando a lógica não depender de dados de instância, mas sim de algo comum à classe inteira.
- Evite o uso excessivo de membros estáticos, especialmente para dados que deveriam ser específicos a cada objeto, para manter a flexibilidade e o design limpo.
## 🔹 Construtores

Em C#, **construtores** são métodos especiais utilizados para inicializar objetos de uma classe. Eles são chamados automaticamente quando um novo objeto é criado, e seu principal objetivo é garantir que o objeto comece com um estado válido.

### 📌 Características dos Construtores

- **Nome**: O construtor deve ter o mesmo nome da classe.
- **Tipo de Retorno**: Construtores não possuem tipo de retorno, nem mesmo `void`.
- **Inicialização de Objetos**: Construtores podem ser usados para inicializar os atributos de uma classe no momento da criação do objeto.
  
### 🔐 Tipos de Construtores

1. **Construtor Padrão (Sem parâmetros)**: É o construtor que não recebe argumentos. Se você não declarar nenhum construtor em uma classe, o compilador cria automaticamente um construtor padrão para você.

2. **Construtor com Parâmetros**: São construtores que recebem parâmetros, permitindo a inicialização de atributos com valores específicos no momento da criação do objeto.

3. **Construtor Estático**: Não é chamado diretamente e é usado para inicializar membros estáticos de uma classe. Ele é executado automaticamente antes da criação de qualquer instância de objetos.

### 🚀 Dicas de Uso:

- Use **construtores** para garantir que seus objetos sejam inicializados corretamente com valores válidos assim que forem criados.
- Se um **construtor com parâmetros** for necessário, lembre-se de usá-lo para fornecer flexibilidade na criação de objetos com diferentes estados iniciais.
- Evite ter **muitos construtores** em uma classe, pois isso pode tornar o código mais difícil de entender. Considere usar valores padrão ou métodos de fábrica quando for o caso.

### 🧠 Melhores Práticas:

- Sempre defina um **construtor** se a classe tiver atributos obrigatórios, garantindo que o objeto sempre começará com um estado válido.
- Use **construtores com parâmetros** para tornar a criação de objetos mais flexível e controlada.
- Lembre-se que o **construtor estático** é útil apenas para inicializar membros estáticos e é chamado automaticamente quando a classe é carregada.
## 🔹 Sobrecarga

Em C#, **sobrecarga** se refere à capacidade de definir múltiplos métodos ou operadores com o mesmo nome, mas com diferentes parâmetros. Isso permite que você tenha métodos ou operadores que realizam ações semelhantes, mas com diferentes tipos ou números de parâmetros, aumentando a flexibilidade e a legibilidade do código.

### 📌 Características da Sobrecarga

- **Sobrecarga de Métodos**: É a definição de múltiplos métodos com o mesmo nome, mas com diferentes listas de parâmetros (quantidade ou tipo). Eles podem ter o mesmo ou tipos diferentes de retorno.
- **Sobrecarga de Operadores**: Permite redefinir o comportamento dos operadores em tipos personalizados (como somar dois objetos de uma classe).
  
### 🔐 Como Funciona

- **Sobrecarga de Métodos**: O compilador seleciona qual versão do método deve ser chamada com base nos parâmetros passados. Ou seja, se o número ou tipo dos parâmetros for diferente, o método correto será escolhido.
- **Sobrecarga de Operadores**: Em C#, você pode definir como os operadores padrão, como `+`, `-`, `*`, entre outros, devem funcionar quando aplicados a instâncias de suas próprias classes ou structs.

### 🚀 Dicas de Uso:

- Use **sobrecarga** para tornar seu código mais legível e organizado. Ao invés de criar métodos com nomes diferentes para ações semelhantes, você pode usar o mesmo nome e diferenciar os parâmetros.
- **Sobrecarga de operadores** é útil quando você quer que objetos da sua classe possam interagir de maneira intuitiva com os operadores, como somar, subtrair ou comparar.

### 🧠 Melhores Práticas:

- Evite a **sobrecarga excessiva de métodos**, pois muitos métodos com o mesmo nome, mas parâmetros diferentes, podem tornar o código mais difícil de entender. Certifique-se de que cada sobrecarga tem uma necessidade clara.
- Quando for sobrecarregar operadores, certifique-se de que o comportamento do operador é intuitivo e faz sentido para os objetos da sua classe.
