using DockStore.Core.DomainObjects;
using System.Collections.Generic;

namespace DockStore.Catalogo.Domain
{
    public class Categoria : Entity
    {

        public string Nome { get; private set; }
        public int Codigo { get; private set; }
        public string Descricao { get; private set; }

        //EF Relation
        public IEnumerable<Produto> Produtos { get; set; }

        protected Categoria() { }

        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;

            Validar();
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome da categoria não pode estar vazio");
            Validacoes.ValidarSeIgual(Codigo, 0, "O campo Codigo não pode ser 0");
        }
    }
}
