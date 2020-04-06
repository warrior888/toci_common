namespace Toci.ErrorsAndMessages.Interfaces
{
    public interface IErrorFormatter
    {
        void FormatError(IErrorEntity errorEntity, string applicationErrorMessage, string userErrorMessage);
    }
}