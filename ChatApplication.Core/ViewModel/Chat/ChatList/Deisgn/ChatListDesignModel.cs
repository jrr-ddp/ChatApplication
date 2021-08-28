using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Core
{

    /// <summary>
    /// The design - time data for a <see cref="ChatListViewModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();

        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Name = "Krishna",
                    Initials = "KR",
                    Message = "This is the Chap app for Shapoorji By Design Studio",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable=true
                },
                 new ChatListItemViewModel
                 {
                    Name = "Nithin",
                    Initials = "NI",
                    Message = "Nice work,Give more update",
                    ProfilePictureRGB = "fe4503",
                    IsSelected=true
                 },
                  new ChatListItemViewModel
                  {
                    Name = "Jitendhra",
                    Initials = "JI",
                    Message = "The new server is up or not, this is the server address 192.168.1.1 ?",
                    ProfilePictureRGB = "00d405",
                    
                 },
                 new ChatListItemViewModel
                 {
                    Name = "Ashish",
                    Initials = "AS",
                    Message = "Sent me the link to download this app",
                    ProfilePictureRGB = "3099c5"
                 },
                new ChatListItemViewModel
                {
                    Name = "Balvin",
                    Initials = "BA",
                    Message = "Awesome App,easy to use",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Name = "Antony",
                    Initials = "AN",
                    Message = "How to login this app",
                    ProfilePictureRGB = "00d405"
                 },
                 new ChatListItemViewModel
                {
                    Name = "Krishna",
                    Initials = "KR",
                    Message = "Nice work,Give more update",
                    ProfilePictureRGB = "3099c5"
                 },
                  new ChatListItemViewModel
                {
                    Name = "Jitendhra",
                    Initials = "JR",
                    Message = "Update the server details and use the app before launch",
                    ProfilePictureRGB = "00d405"
                 },
                     new ChatListItemViewModel
                {
                    Name = "Nithin",
                    Initials = "NI",
                    Message = "Tell me the exact date for publishing the application",
                    ProfilePictureRGB = "fe4503"
                 },
            };
        }
        #endregion
    }
}
