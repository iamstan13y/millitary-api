using System.ComponentModel.DataAnnotations.Schema;

namespace Millitary.API.Models.Data
{
    public class AmmoDispatch
    {
        public int Id { get; set; }
        public int SoldierId { get; set; }
        public int AmmunitionId { get; set; }
        public string? Reason { get; set; }
        public DateTime DateTaken { get; set; }
        public DateTime DateReturned { get; set; }
        public bool Status { get; set; } = false;
        public int AuthorisedById { get; set; }
        public Soldier? Soldier { get; set; }
        public Ammunition? Ammunition { get; set; }
        [ForeignKey("AuthorisedById")]
        public Soldier? AuthorisedBy { get; set; }
    }
}