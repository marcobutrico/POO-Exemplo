using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Classe - definicao: item da vida real representado em codigo
// Toda classe tem atributos (caracteristicas) e metodos (acoes)

namespace POO
{
    class Carro     //por padrao todas as classes sao publicas
    {
        //Atributos
        //Nomenclatura
        //Sempre que for privada, utilizar _
        public string marca;
        private string _modelo;
        public int anoFabricacao;

        //Metodos
        public void Andar()
        {
            Console.WriteLine("O carro esta andando!");
        }
        public void Parar()
        {
            Console.WriteLine("O carro esta parado!");
        }
        public void MostrarInformacoes()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano de Fabricacao {anoFabricacao}");
        }

        public string GetModelo()
        { 
            return _modelo;
        }

        public void SetModelo(string mod)
        {
            if (mod == "Fiesta" || mod == "HB20")
            {
                modelo = mod;
            }
            else
            {
                Console.WriteLine("Operacao invalida");
            }
        }
    }
}
