namespace DIContainer.Domain.Interfaces {

    public interface ISkill {
        int Id { get; set; }
        string Name { get; set; }
        int Duration { get; set; }
        int Cooldown { get; set; }
        int MpCost { get; set; }
        int Damage { get; set; }
        int Level { get; set; }
    }
}