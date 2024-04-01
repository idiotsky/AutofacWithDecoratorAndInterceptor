using Castle.DynamicProxy;

namespace AutofacWithDecoratorAndInterceptor;

public class LoggingInterceptor : IInterceptor
{
    public void Intercept(IInvocation invocation)
    {
        Console.WriteLine($"Intercepting call: {invocation.Method.Name}");
        invocation.Proceed();
        Console.WriteLine($"Completed call: {invocation.Method.Name}");
    }
}
