using System;

namespace CSharpDependencyInjection.Contracts
{
    internal interface IErrorLogger
    {
        void LogMessage(Exception ex);
    }
}
