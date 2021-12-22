using FullApp.Services.Interfaces;

namespace FullApp.Services
{
    public class MessageService : IMessageService
    {
#region Implementation of IMessageService

        /// <inheritdoc />
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }

#endregion
    }
}
