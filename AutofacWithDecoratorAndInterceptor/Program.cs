using Autofac;
using Autofac.Extras.DynamicProxy;
using AutofacWithDecoratorAndInterceptor;

var builder = new ContainerBuilder();

// Register the service and interceptor
builder.RegisterType<Service>().As<IService>().EnableInterfaceInterceptors().InterceptedBy(typeof(LoggingInterceptor));
builder.RegisterDecorator<ServiceDecorator, IService>();

// Enable class interceptors and register the logging interceptor to be applied to the decorator
builder.RegisterType<LoggingInterceptor>();

IContainer? container = builder.Build();

// Resolve and use the service
var service = container.Resolve<IService>();
service.DoWork();
