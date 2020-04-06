using Toci.ErrorsAndMessages.Interfaces;

namespace ErrorsAndMessages.ErrorHandling
{
    public class ErrorFormatter : IErrorFormatter
    {
        public void FormatError(IErrorEntity errorEntity, string applicationErrorMessage, string userErrorMessage)
        {
            errorEntity.ApplicationErrorMessage.Add(applicationErrorMessage);
            errorEntity.UserErrorMessage.Add(userErrorMessage);
        }
    }
}