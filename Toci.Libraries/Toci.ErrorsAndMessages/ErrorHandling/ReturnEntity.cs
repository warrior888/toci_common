using Toci.ErrorsAndMessages.Interfaces;

namespace ErrorsAndMessages.ErrorHandling
{
    public class ReturnEntity<TEntity> : IReturnEntity<TEntity>
    {
        public TEntity Result { get; set; }
        public IErrorEntity Error { get; set; }
        public bool IsError { get; set ; }
    }
}
    