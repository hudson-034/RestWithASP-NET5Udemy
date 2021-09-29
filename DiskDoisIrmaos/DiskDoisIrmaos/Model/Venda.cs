using DiskDoisIrmaos.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiskDoisIrmaos.Model
{
    [Table("vendas")]
    public class Venda : BaseEntity
    {
        [Column("cliente")]
        public Cliente Cliente { get; set; }

        [Column("valor_total")]
        public decimal ValorTotal { get; set; }

        [Column("data_compra")]
        public DateTime DataCompra { get; set; }

        [Column("frete")]
        public decimal Frete { get; set; }

        [Column("data_entrega")]
        public DateTime DataEntrega { get; set; }

        [Column("item_venda")]
        public List<Produto> ItemVenda { get; set; }

        [Column("valor_unitario")]
        public List<Decimal> ValorUnitario { get; set; }

        [Column("quantidade")]
        public List<int> Quantidade { get; set; }
    }
}
