using System.ComponentModel.DataAnnotations.Schema;

namespace Camadas.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
