using System;
using System.Diagnostics.CodeAnalysis;
using CSharpDependencyInjection.Contracts;

namespace CSharpDependencyInjection.MethodInjection
{
    [SuppressMessage("ReSharper", "JoinDeclarationAndInitializer")]
    internal class MethodDependencyInjectionExample
    {
        public void GenerateDivideByZeroException(IErrorLogger logger)
        {
            try
            {
                int firstNumber, secondNumber;
                firstNumber = 100;
                secondNumber = 0;
                var result = firstNumber / secondNumber;
                Console.WriteLine($"Result is : {result}");
            }
            catch (DivideByZeroException ex)
            {
                logger.LogMessage(ex);
            }
        }
    }
}
