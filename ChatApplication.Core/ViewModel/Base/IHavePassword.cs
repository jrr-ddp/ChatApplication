﻿using System.Security;

namespace ChatApplication.Core
{
    /// <summary>
    /// An interface for a class that can provide a secure password
    /// </summary>
    public interface IHavePassword
    {
        /// <summary>
        /// The secure password
        /// </summary>
        SecureString SecurePassword { get; }
    }
}
