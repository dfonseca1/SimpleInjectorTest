using DIContainer.Business.Interfaces;
using DIContainer.SimpleInjector;

namespace Application {

    public class Program {

        public static void Main() {
            Config();

            var simpleInjectorContainer = DependencyInjection.GetContainerInstance();

            var characterManager =
                simpleInjectorContainer.GetInstance<ICharacterManager>();

            int characterId = 1;

            var characterSkillsList = characterManager.GetCharacterSkills(characterId);
        }

        private static void Config() {
            //Registrando as dependencias
            ApplicationContainer.RegisterComponents();
        }
    }
}