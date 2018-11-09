using CSharpDependencyInjection.ConstructorInjection;
using CSharpDependencyInjection.Logging;
using CSharpDependencyInjection.MethodInjection;
using CSharpDependencyInjection.SetterInjection;

namespace CSharpDependencyInjection
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var example1 = new ConstructorDependencyInjectionExample(new EventLogLogger());
            example1.GenerateDivideByZeroException();
            example1 = new ConstructorDependencyInjectionExample(new FileLogger());
            example1.GenerateDivideByZeroException();

            var example2 = new MethodDependencyInjectionExample();
            example2.GenerateDivideByZeroException(new EventLogLogger());
            example2.GenerateDivideByZeroException(new FileLogger());

            var example3 = new SetterDependencyInjectionExample {ErrorLogger = new FileLogger()};
            example3.GenerateDivideByZeroException();
            example3.ErrorLogger = new EventLogLogger();
            example3.GenerateDivideByZeroException();
        }
    }
}
