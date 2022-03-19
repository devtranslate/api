using System;

namespace DevTranslate.Api.Exceptions
{
    public class RequiredPropertyNotProvidedException : DevTranslateException
    {
        public RequiredPropertyNotProvidedException(string paramName, string message): base(message)
        {
            ParamName = paramName ?? throw new ArgumentNullException(nameof(paramName));
        }

        public string ParamName { get; }
    }
}
