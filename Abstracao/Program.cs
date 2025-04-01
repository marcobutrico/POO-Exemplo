// Abstracao - ligado diretamente com Heranca

//Interface - Contrato
//TrocarMarcha()
//Livro (texto, autor, ano)
//MostrarDadosLivro
//MostrarLivro

using Abstracao;

ICarro carro = new CarroManual();
carro.TrocarMarcha();

ICarro carro2 = new CarroAutomatico();
carro2.TrocarMarcha();