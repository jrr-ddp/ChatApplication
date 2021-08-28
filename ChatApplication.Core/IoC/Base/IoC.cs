using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Core
{
    /// <summary>
    /// The IoC container for our application
    /// </summary>
    public static class IoC
    {
        #region Public properties
        /// <summary>
        /// The kernel for our IoC container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();

        /// <summary>
        /// A shortcut to access the <see cref="IUIManager"/>
        /// </summary>
        public static IUIManager UI => IoC.Get<IUIManager>();

        /// <summary>
        /// A shortcut to access the <see cref="ApplicationViewModel"/>
        /// </summary>
        public static ApplicationViewModel Application => IoC.Get<ApplicationViewModel>();

        /// <summary>
        /// A shortcut to access the <see cref="SettingsViewModel"/>
        /// </summary>
        public static SettingsViewModel Settings => IoC.Get<SettingsViewModel>();
        #endregion

        #region Construction
        /// <summary>
        /// Setsup the IoC container, binds all information required and is ready for use
        /// Note: Must be called as soon as your application starts up to ensure all services can be found
        /// </summary>
        public static void Setup()
        {
            /// Bind all required ViewModels
            BindViewModels();
        }

        /// <summary>
        /// Bind all singleton ViewModels
        /// </summary>
        private static void BindViewModels()
        {
            //bind to a single instance of application viewmodel
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());

            // Bind to a single instance of Settings view model
            Kernel.Bind<SettingsViewModel>().ToConstant(new SettingsViewModel());
        }
        #endregion



        /// <summary>
        /// Gets services from the IoC, of the specified type
        /// </summary>
        /// <typeparam name="T">The type to get</typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}
