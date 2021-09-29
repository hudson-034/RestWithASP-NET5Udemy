using DiskDoisIrmaos.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiskDoisIrmaos.Model
{
    [Table("clientes")]
    public class Cliente : BaseEntity
    {
        [Column("nome")]
        public string Nome { get; set; }

        [Column("tipo_pessoa")]
        public string TipoPessoa { get; set; }

        [Column("documento_fiscal")]
        public int DocumentoFiscal { get; set; }

        [Column("nome_social")]
        public string NomeSocial { get; set; }

        [Column("telefone_whatsapp")]
        public int TelefoneWhatsapp { get; set; }

        [Column("telefone_contato")]
        public int TelefoneContato { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("responsavel")]
        public string Responsavel { get; set; }

        [Column("endereco")]
        public string Endereco { get; set; }
    }
}
