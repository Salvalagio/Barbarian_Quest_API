using System;

namespace BQuest.Services.DTO
{
    public class ErrorMessage
    {
        public string Message { get; set; }
        public Player PlayerError { get; set; }
        public Exception ExceptionErro { get; set; }

        public ErrorMessage() { }
        public ErrorMessage(string message, Player playerError, Exception ex)
        {
            Message = message;
            PlayerError = playerError;
            ExceptionErro = ex;
        }

    }
}
