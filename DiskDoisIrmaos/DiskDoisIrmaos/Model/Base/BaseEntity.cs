using System.ComponentModel.DataAnnotations.Schema;

namespace DiskDoisIrmaos.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
