using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POO2
{
    class Produto
    {
        //Atributos
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        //Metodo
        public void CalcularTotal()
        { 
            Console.WriteLine($"Valor em estoque do produto: R$ {preco* quantidadeEmEstoque}");
        }
    }
}
