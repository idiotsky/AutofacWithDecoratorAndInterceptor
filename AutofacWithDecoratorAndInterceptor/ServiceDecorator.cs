namespace AutofacWithDecoratorAndInterceptor;

public class ServiceDecorator(IService decoratedService) : IService
{
    public void DoWork()
    {
        Console.WriteLine("Before decorated service work.");
        decoratedService.DoWork();
        Console.WriteLine("After decorated service work.");
    }
}
