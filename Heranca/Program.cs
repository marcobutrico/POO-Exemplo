//Heranca - Classe que herda de outro
// Todo carro tem - Modelo, marca, quilometragem
// Carro eletrico - bateria, tempoDeCarga
// Carro combustao - Combustivel

using Heranca;

//CarroEletrico carroE = new CarroEletrico();
//CarroCombustao carroC = new CarroCombustao();

////carro eletrico
//carroE.modelo = "Tesla Model 3";
//carroE.marca = "Tesla";
//carroE.quilometragem = 0;
//carroE.bateria = "100 kW.h";
//carroE.tempoDeCarga = "1 h";

////carro a combustao
//carroC.modelo = "Fusca";
//carroC.marca = "Volkswagen";
//carroC.quilometragem = 0;
//carroC.combustivel = "Gasolina";

//Carro meuCarro;

//Console.WriteLine("Digite E - para carro eletrico ou P - para combustao: ");
//string tipo = Console.Read();

//if (tipo == "E")
//    {
//    meuCarro = new CarroEletrico;
//}
//else
//{
//    meuCarro = new CarroCombustao;
//}

Pessoa pessoa;

Console.WriteLine("Digite F - para pessoa fisica ou J - para pessoa juridica: ");
string tipo = Console.Read();

if (tipo == "F")
{
    pessoa = new PessoaFisica;
}
else
{
    pessoa = new PessoaJuridica;
}