// Listas
//string[] nomes = new string[5];
//Generico
//versoes antigas do C#
//List<string> listaDeNomes2 = new List<string>();

////jeito novo de escrever
//List<string> listaDeNomes = new();

//listaDeNomes.Add("Marco");
//listaDeNomes.Add("Fulano");
//listaDeNomes.Add("Sicrano");
//listaDeNomes.Add("Beltrano");

//foreach (var item in listaDeNomes)
//{
//        Console.WriteLine(item);
//}

//listaDeNomes.Remove("Sicrano")

//POO - Programacao Orientada a Objetos
// Inicio em programacao estruturada 
// POO tem como objetivo aproximar a programacao do mundo real
// Separr nossos sistemas em partes menores

//Divido em classes e objetos

// Classe - definicao: item da vida real representado em codigo
// Toda classe tem atributos (caracteristicas) e metodos (acoes)

//Objeto - Instancia de uma classe
using POO;

//Carro carro1 = new Carro();
//carro1.modelo = "HB20";
//carro1.marca = "Hyundai";
//carro1.anoFabricacao = 2024;

//carro1.Andar();
//carro1.Parar();

//Carro carro2 = new Carro();
//carro2.modelo = "Fusca";
//carro2.marca = "VW";
//carro2.anoFabricacao = 1969;

//carro2.Andar();
//carro2.Parar();

//Carro carro3 = new Carro();

//carro3.modelo = "Silver Shadow";
//carro3.marca = "Rolls Royce";
//carro3.anoFabricacao = 2023;

//carro3.Andar();
//carro3.Parar();

//List<Carro> carros = new List<Carro>();
//carros.Add(carro1);
//carros.Add(carro2);
//carros.Add(carro3);

//*** Criando Objetos e Classes (25/03)
//using POO;
//using POO2;

//Livro livro1 = new Livro();
//livro1.titulo = "As trancas do rei careca";
//livro1.paginas = 242;
//livro1.autor = "Joao Traumatizado";


//*** Criando Objetos e Classes (25/03)
//## Criando Objetos e Classes (25/03)
//### **1 - Criando uma Classe "Livro" e Instanciando um Objeto**
//Crie uma classe chamada `Livro` com os seguintes atributos:
//- `titulo` (tipo `string`)
//- `autor` (tipo `string`)
//- `paginas` (tipo `int`)
//Depois, instancie um objeto da classe `Livro`, atribua valores aos atributos e exiba as informações no console.

//using POO2;

//Livro livro1 = new Livro();
//livro1.titulo = "As trancas do rei careca";
//livro1.paginas = 242;
//livro1.autor = "Joao Traumatizado";

//using POO2;
//Aluno pupil1 = new Aluno()
//{
//    nome = "José Inácio Bezerra",
//    idade = 25,
//    notaFinal = 8.5,
//};

//Aluno pupil2 = new Aluno()
//{
//    nome = "Maria Inácia Silva",
//    idade = 21,
//    notaFinal = 8.5,
//};

//using POO2;

//Produto produto1 = new Produto()
//{
//    nome="Sabonete",
//    preco=6.50,
//    quantidadeEmEstoque=200,
//};
//produto1.CalcularTotal();


//Console.WriteLine(pupil2.idade);

// 4 ferramentas do POO
//Classe e objeto
//Classe - Definicao (a forma do bolo / molde)
//Objeto - Instancia da classe
//Ferramentas - formas de trabalhar com POO
//Encapsulamento e Heranca
//Abstracao e Polimorfismo

//Encapsulamento - esconder comportamentos e atributos
//Evitar que sejam acessados diratamente
//Exemplo: Conta Bancaria
//Sacar() e Depositar() podem acessar o saldo

// 4 palavras
// public - atributo e metodos podem ser acesivel por qualquer um
// private - 1. esconder regras para alteracao ou listagem
// protected / internal - so pode ser acesso por ele mesmo e sua classe pai

using POO2;

Carro carro1 = new Carro();
carro1.SetModelo("Fusca");

