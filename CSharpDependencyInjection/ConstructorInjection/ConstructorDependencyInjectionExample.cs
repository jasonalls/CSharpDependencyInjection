using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDependencyInjection.Contracts;

namespace CSharpDependencyInjection.ConstructorInjection
{
    [SuppressMessage("ReSharper", "JoinDeclarationAndInitializer")]
    internal class ConstructorDependencyInjectionExample
    {
        private readonly IErrorLogger _logger;

        public ConstructorDependencyInjectionExample(IErrorLogger logger)
        {
            _logger = logger;
        }

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
                _logger.LogMessage(ex);
            }
        }
    }
}
