using System.Collections.Generic;

namespace DIContainer.Domain.Interfaces {

    public interface ICharacter {
        string NickName { get; set; }

        List<ISkill> Skills { get; set; }

        int Level { get; set; }
    }
}