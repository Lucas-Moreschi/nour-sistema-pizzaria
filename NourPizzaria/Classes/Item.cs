using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NourPizzaria.Classes
{
    public class Item
    {
        public int IdOP_Itens { get; set; }
        public int IdItem { get; set; }
        public int NumeroItem { get; set; }
        public string NomeItem { get; set; }
        public string Observacoes { get; set; }
        public int Quantidade { get; set; }
        public int ValorUnitario { get; set; }

        public Item(int numeroItem, string nomeItem, string observacoes, int quantidade)
        {
            NumeroItem = numeroItem;
            NomeItem = nomeItem;
            Observacoes = observacoes;
            Quantidade = quantidade;
        }

        public Item(int numeroItem, string nomeItem, string observacoes, int quantidade, int valorUnitario) 
        {
            NumeroItem = numeroItem;
            NomeItem = nomeItem;
            Observacoes = observacoes;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public Item(int idOrcItem, int idItem, string nomeItem, string observacoes, int quantidade, int valorUnitario)
        {
            IdOP_Itens = idOrcItem;
            IdItem = idItem;
            NomeItem = nomeItem;
            Observacoes = observacoes;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }

        public bool Equals(Item other)
        {
            if (other == null) return false;
            return IdOP_Itens == other.IdOP_Itens &&
                   IdItem == other.IdItem &&
                   NomeItem == other.NomeItem &&
                   Observacoes == other.Observacoes &&
                   Quantidade == other.Quantidade &&
                   ValorUnitario == other.ValorUnitario;
        }

        public Item() { }

        public override string ToString()
        {
            return $"IdOrcItem: {IdOP_Itens}, IdItem: {IdItem}, NumeroItem: {NumeroItem}, NomeItem: {NomeItem}, Quantidade: {Quantidade}, ValorUnitario: {ValorUnitario}, Observacoes: {Observacoes}";
        }

    }
}
