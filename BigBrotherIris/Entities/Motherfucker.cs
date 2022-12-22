using Volo.Abp.Domain.Entities;

namespace BigBrotherIris.Entities
{
    public class Motherfucker : Entity<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsEliminated { get; set; }
        public bool HasVoted { get; set; }
    }
}
