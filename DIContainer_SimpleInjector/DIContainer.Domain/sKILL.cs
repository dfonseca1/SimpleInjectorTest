using DIContainer.Domain.Interfaces;

namespace DIContainer.Domain {

    public class Skill : ISkill {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Cooldown { get; set; }
        public int MpCost { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }
    }
}