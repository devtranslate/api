using System;

namespace DevTranslate.Api.Exceptions
{
    public abstract class DevTranslateException : Exception
    {
        public DevTranslateException(string message): base(message)
        {
        }
    }
}
