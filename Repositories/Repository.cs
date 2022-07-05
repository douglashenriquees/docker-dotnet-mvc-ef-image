using System.Collections.Generic;
using mvc1.Models;

namespace mvc1.Repositories;

public class Repository : IRepository
{
    private Produto[] produtos = new Produto[]
    {
            new Produto() { ProdutoId = 10, Nome = "Caneta", Categoria = "Material", Preco = 2.0M },
            new Produto() { ProdutoId = 20, Nome = "Borracha", Categoria = "Material", Preco = 1.5M },
            new Produto() { ProdutoId = 30, Nome = "Estojo", Categoria = "Material", Preco = 3.0M }
    };

    public IEnumerable<Produto> Produtos { get => produtos; }
}