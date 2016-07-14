using DIContainer.Business.Interfaces;
using DIContainer.Domain.Interfaces;
using DIContainer.Repository.Interfaces;
using System.Collections.Generic;

namespace DIContainer.Business {

    public class CharacterManager : ICharacterManager {
        private readonly ICharacterSkillsRepository _characterSkillsRepository;

        //Construtor
        public CharacterManager(ICharacterSkillsRepository characterSkillsRepository) {
            _characterSkillsRepository = characterSkillsRepository;
        }

        //Metodo que pega skills do character
        public IList<ISkill> GetCharacterSkills(int characterId) {
            return _characterSkillsRepository.GetSkillsForCharacter(characterId);
        }
    }
}