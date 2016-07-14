using DIContainer.Domain;
using DIContainer.Domain.Interfaces;
using DIContainer.Repository.Interfaces;
using System.Collections.Generic;

namespace DIContainer.Repository {

    public class CharacterSkillsRepository : ICharacterSkillsRepository {

        public IList<ISkill> GetSkillsForCharacter(int characterId) {
            IList<ISkill> characterSkills = new List<ISkill>()
            {
                new Skill()
                {
                    Duration = 10,
                    Damage = 100,
                    Cooldown = 5,
                    MpCost = 100,
                    Level = 1,
                    Name = "FireSword"
                }
            };

            return characterSkills;
        }
    }
}