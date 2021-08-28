using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChatApplication.Core
{
    /// <summary>
    /// The view model for Login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
         #region Public Properties
       
        /// <summary>
        /// The email for the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The Command to Login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register for a new account
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>

        public LoginViewModel()
        {
            //Create Commands
            LoginCommand = new RelayParameterizedCommand(async (parameter) =>await LoginAsync(parameter));
            RegisterCommand = new RelayCommand(async () => await RegisterAsync());
        }
        #endregion
        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from view for the users password </param>
        /// <returns></returns>
        public async Task LoginAsync(object parameter)
        {
            await RunCommandAsync(() => LoginIsRunning, async () =>
            {
                // TODO: Fake a login...
                await Task.Delay(1000);

                // OK successfully logged in... now get users data
                // TODO: Ask server for users info

                // TODO: Remove this with real information pulled from our database in future
                IoC.Settings.Name = new TextEntryViewModel { Label = "Name", OriginalText = $"Jitendra Ramasamy {DateTime.Now.ToLocalTime()}" };
                IoC.Settings.Username = new TextEntryViewModel { Label = "Username", OriginalText = "Jithu" };
                IoC.Settings.Password = new PasswordEntryViewModel { Label = "Password", FakePassword = "********" };
                IoC.Settings.Email = new TextEntryViewModel { Label = "Email", OriginalText = "Jitendhra.ramasamy@shapoorji.com" };


                //Go to Chat Page
                // IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Chat);
                IoC.Application.GoToPage(ApplicationPage.Chat);

                //var email = Email;

                //Important: Never store unsecure password in variable like this
                // var pass = (parameter as IHavePassword).SecurePassword.Unsecure();

            });
        }

        /// <summary>
        /// Takes the user to the register page
        /// </summary>
        /// <returns></returns>
        public async Task RegisterAsync()
        {
            //Go to register page?
            IoC.Application.GoToPage(ApplicationPage.Register);
            //ViewModelApplication.GoToPage(ApplicationPage.Register);

            // IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Register);
            //((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Register;
            await Task.Delay(1);
        }

    }
}
