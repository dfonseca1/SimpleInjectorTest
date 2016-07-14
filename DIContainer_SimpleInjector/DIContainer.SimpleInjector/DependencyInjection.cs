using SimpleInjector;

namespace DIContainer.SimpleInjector {

    public static class DependencyInjection {

        /// <summary>
        /// Instância
        /// </summary>
        private static Container _instance;

        /// <summary>
        /// Objeto de sincronismo
        /// </summary>
        private static readonly object SyncObj = new object();

        /// <summary>
        /// Método para obter a instância
        /// </summary>
        /// <returns></returns>
        public static Container GetContainerInstance() {
            //Verifica se o objeto já existe
            if (_instance == null) {
                //Efetua o lock do objeto
                lock (SyncObj) {
                    //Verifica se o objeto já existe
                    if (_instance == null) {
                        //Inicializa a variáel
                        _instance = new Container();
                        _instance.Options.AllowOverridingRegistrations = true;
                    }
                }
            }

            //Retorno
            return _instance;
        }
    }
}