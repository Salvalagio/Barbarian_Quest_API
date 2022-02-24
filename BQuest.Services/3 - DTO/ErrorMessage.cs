using System;

namespace BQuest.Services.DTO
{
    public class ErrorMessage
    {
        public string Message { get; set; }
        public Character PlayerError { get; set; }
        public Exception ExceptionErro { get; set; }

        public ErrorMessage() { }

        public ErrorMessage(string message) => 
            Message = message;

        public ErrorMessage(string message, Character playerError)
        {
            Message = message;
            PlayerError = playerError;
        }
        
        public ErrorMessage(string message, Character playerError, Exception ex)
        {
            Message = message;
            PlayerError = playerError;
            ExceptionErro = ex;
        }

    }
}
