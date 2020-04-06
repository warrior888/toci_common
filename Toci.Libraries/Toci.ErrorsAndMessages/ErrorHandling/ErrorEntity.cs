using System.Collections.Generic;
using Toci.ErrorsAndMessages.Interfaces;

namespace ErrorsAndMessages.ErrorHandling
{
    public class ErrorEntity : IErrorEntity
    {
        public List<string> ApplicationErrorMessage { get; set; }
        public List<string> UserErrorMessage { get; set; }
    }
}