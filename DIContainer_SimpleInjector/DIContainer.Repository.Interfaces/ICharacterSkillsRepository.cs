using DIContainer.Domain.Interfaces;
using System.Collections.Generic;

namespace DIContainer.Repository.Interfaces {

    public interface ICharacterSkillsRepository {

        IList<ISkill> GetSkillsForCharacter(int characterId);
    }
}