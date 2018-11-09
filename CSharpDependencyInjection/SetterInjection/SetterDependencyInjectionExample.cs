using System;
using System.Diagnostics.CodeAnalysis;
using CSharpDependencyInjection.Contracts;

namespace CSharpDependencyInjection.SetterInjection
{
    [SuppressMessage("ReSharper", "JoinDeclarationAndInitializer")]
    internal class SetterDependencyInjectionExample
    {
        public IErrorLogger ErrorLogger { get; set; }

        public void GenerateDivideByZeroException()
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
                ErrorLogger.LogMessage(ex);
            }
        }
    }
}
