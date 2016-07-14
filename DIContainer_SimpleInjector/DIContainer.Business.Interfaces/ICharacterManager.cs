using DIContainer.Domain.Interfaces;
using System.Collections.Generic;

namespace DIContainer.Business.Interfaces {

    public interface ICharacterManager {

        IList<ISkill> GetCharacterSkills(int characterId);
    }
}