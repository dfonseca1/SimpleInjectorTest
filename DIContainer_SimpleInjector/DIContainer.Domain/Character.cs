using DIContainer.Domain.Interfaces;
using System.Collections.Generic;

namespace DIContainer.Domain {

    public class Character : ICharacter {
        public string NickName { get; set; }

        public List<ISkill> Skills { get; set; }

        public int Level { get; set; }
    }
}