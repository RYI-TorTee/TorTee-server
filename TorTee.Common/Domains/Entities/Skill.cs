using TorTee.Core.Domains.Entities.BaseEntities;

namespace TorTee.Core.Domains.Entities
{
    public class Skill: EntityBase<Guid>
    {
        public string SkillName { get; set; } = null!;
    }
}
