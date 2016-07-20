using DIContainer.Business;
using DIContainer.Business.Interfaces;
using DIContainer.Repository;
using DIContainer.Repository.Interfaces;
using DIContainer.SimpleInjector;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleInjector;


namespace DIContainer.Tests {

    [TestClass]
    public class InitializeClass {

        [AssemblyInitialize]
        public static void Initialize(TestContext testContext)
        {
            var container = DependencyInjection.GetContainerInstance();

            container.Register<ICharacterSkillsRepository, CharacterSkillsRepository>(Lifestyle.Singleton);
            container.Register<ICharacterManager, CharacterManager>(Lifestyle.Singleton);
        }

    }
}
