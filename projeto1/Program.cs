using System;
using System.Linq;
using projeto1;

public class Program
{
    public static void Main()
    {
        var listaProdutos = new List<Produto>()
        {
        new Produto {Id = 9, CategoriaId = 2, Nome = "Geladeira", Status = true, Valor = 10},
        new Produto {Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 1},
        new Produto {Id = 4, CategoriaId = 1, Nome = "Maquina de lavar", Status = false, Valor = 32},
        new Produto {Id = 3, CategoriaId = 1, Nome = "Video Game", Status = true, Valor = 99},
        new Produto {Id = 6, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 55},
        new Produto {Id = 8, CategoriaId = 1, Nome = "TV", Status = true, Valor = 45},
        new Produto {Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
        new Produto {Id = 5, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 90},
        new Produto {Id = 7, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 12},
        };

        var listaCategorias = new List<Categoria>()
        {
            new Categoria {Id = 1, Status = true, Nome = "Eletronicos"},
            new Categoria {Id = 2, Status = true, Nome = "Alimentos"},
            new Categoria {Id = 3, Status = true, Nome = "Vestuario"},
        };

        //Ordenar valores de produtos de forma crescente e decrescente
        var resultado = from produto in listaProdutos 
                        where produto.Valor < 60 
                        orderby produto.Valor descending 
                        select produto ;
        

        //Achar um produto específico
        /*var resultado = from produto in listaProdutos
                        where produto.Nome.ToLower() == "MicRoondaS".ToLower()
                        select produto;
        */

        //Achar um produto pela primeira letra
        /*var resultado = from produto in listaProdutos
                        where produto.Nome.ToLower().Substring(0, 1) == "M".ToLower()
                        select produto;
        */

        //Achar um produto pela primeira letra e com Status ativo
        /*var resultado = from produto in listaProdutos
                        where produto.Nome.ToLower().Substring(0, 1) == "M".ToLower() &&
                        produto.Status == true
                        select produto;
        */



        //Foreach Geral
        foreach (var result in resultado)
        {
            Console.WriteLine($"{result.Id} / {result.Nome} / {result.Valor} / {result.CategoriaId}");
        }


        //Select com classe especifíca
        /*var nomesValorProduto = from prod in listaProdutos select new ProdutoDto{ 
            Nome = prod.Nome + " também se pode adicionar strings!".ToUpper(), 
            Valor = prod.Valor + 10, 
            Id = prod.Id };
        
        //Foreach Especifico
        foreach (var nomesvalor in nomesValorProduto)
        {
            Console.WriteLine($"{nomesvalor.Id} | {nomesvalor.Nome} | {nomesvalor.Valor} ");
        }*/

        //Usando Group e Join

        /*var result = from prod in listaProdutos
                     group prod by prod.CategoriaId into produtosAgrupados
                     select produtosAgrupados;

        foreach (var item in result)
        {
            Console.WriteLine(item.Key);
            foreach (var prod in item)
            {
                Console.WriteLine($"Produto: {prod.Nome} | Categoria: {prod.CategoriaId}");
            }
        }*/


        /*var result = from prod in listaProdutos
                     join cat in listaCategorias
                     on prod.CategoriaId equals cat.Id
                     select new
                     {
                         Produto = prod,
                         Categoria = cat
                     };
        
        foreach (var item in result)
        {
            Console.WriteLine($"Produto: {item.Produto.Nome} | Categoria: {item.Categoria.Nome}");
        }*/

    }
}

//Classes
class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public bool Status { get; set; }
    public decimal Valor { get; set; }
    public int CategoriaId { get; set; }

}

class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public bool Status { get; set; }

}

class ProdutoDto
{
    public string Nome { get; set; }
    public decimal Valor { get; set; }
    public int Id { get; set; }
}




