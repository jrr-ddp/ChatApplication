using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Core
{
    /// <summary>
    /// The design-time data for a <see cref="SettingsViewModel"/>
    /// </summary>
    public class SettingsDesignModel : SettingsViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static SettingsDesignModel Instance => new SettingsDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SettingsDesignModel()
        {
            Name = new TextEntryViewModel { Label = "Name", OriginalText = "Jitendhra Ramasamy" };
            Username = new TextEntryViewModel { Label = "Username", OriginalText = "Jithu" };
            Password = new PasswordEntryViewModel { Label = "Password", FakePassword = "******" };
            Email = new TextEntryViewModel { Label = "Email", OriginalText = "jitendhra.ramasamy@shapoorji.com" };
        }

        #endregion
    }
}
