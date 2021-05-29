using System.ComponentModel.DataAnnotations.Schema;

namespace Fundamentos.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
