using DiskDoisIrmaos.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiskDoisIrmaos.Model
{
    [Table("produtos")]
    public class Produto : BaseEntity
    {
        [Column("descricao_produto")]
        public string DescricaoProduto { get; set; }

        [Column("valor")]
        public decimal Valor { get; set; }

        [Column("unidade")]
        public string Unidade { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("desconto_venda")]
        public decimal DescontoVenda { get; set; }
    }
}
