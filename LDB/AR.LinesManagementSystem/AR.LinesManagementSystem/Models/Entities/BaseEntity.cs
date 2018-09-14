using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AR.LinesManagementSystem.Models
{
    public class BaseEntityWithAudit : IBaseEntityWithAudit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTime.Now;
        public int UpdatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; } = DateTime.Now;
        //public bool IsActive { get; set; }
    }

    public interface IBaseEntityWithAudit
    {
        int Id { get; set; }
        int CreatedBy { get; set; }
        DateTimeOffset CreatedAt { get; set; }
        int UpdatedBy { get; set; }
        DateTimeOffset UpdatedAt { get; set; }
        //bool IsActive { get; set; }
    }
}
