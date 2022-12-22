using Volo.Abp.Domain.Entities;

namespace BigBrotherIris.Entities
{
    public class PollResult: Entity<Guid>
    {
        public string PollId { get; set; }
        public string PollName { get; set; }
        public List<PollResultMotherfucker> Motherfuckers { get; set; }
        public DateTime PollStartDate { get; set; }
        public DateTime PollEndDate { get; set; }
    }
}
