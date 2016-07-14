using DIContainer.Business;
using DIContainer.Business.Interfaces;
using DIContainer.Repository;
using DIContainer.Repository.Interfaces;
using SimpleInjector;

namespace DIContainer.SimpleInjector {

    public class ApplicationContainer {

        public static void RegisterComponents() {
            var simpleInjectorContainer = DependencyInjection.GetContainerInstance();

            simpleInjectorContainer.Register<ICharacterSkillsRepository, CharacterSkillsRepository>(Lifestyle.Singleton);
            simpleInjectorContainer.Register<ICharacterManager, CharacterManager>(Lifestyle.Singleton);
        }
    }
}