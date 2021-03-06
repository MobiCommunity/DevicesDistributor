using DevicesDistributor.Core.Services.Abstract;
using DevicesDistributor.Core.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace DevicesDistributor.Core
{
    public static class Extensions
    {
        public static IServiceCollection AddRegisterCoreServices(this IServiceCollection serviceCollection)
        {

            serviceCollection.AddSingleton<IFridgeRepository, FridgeRepository>();
            serviceCollection.AddTransient<IFridgeService, FridgeService>();
            serviceCollection.AddTransient<ISerialNumberProviderClient, SerialNumberProviderClient>();

            return serviceCollection;
        } 
    }
}