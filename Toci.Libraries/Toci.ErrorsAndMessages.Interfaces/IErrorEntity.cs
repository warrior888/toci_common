using System.Collections.Generic;

namespace Toci.ErrorsAndMessages.Interfaces
{
    public interface IErrorEntity
    {
        List<string> ApplicationErrorMessage { get; set; }

        List<string> UserErrorMessage { get; set; }
    }
}