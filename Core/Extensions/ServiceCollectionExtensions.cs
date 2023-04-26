using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Extensions
{
    // Bu islemle, bizim core katmani dahil olmak uzere ekleyecegimiz butun injectionlari bir arada toplayabilecegimiz bir yapiya donustu
    public static class ServiceCollectionExtensions
    {
        // 'this' neyi genisletmek istiyoruz anlamina geliyor

        public static IServiceCollection AddDependencyResolvers(this IServiceCollection serviceCollection, ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.Load(serviceCollection);
            }
            return ServiceTool.Create(serviceCollection);
        }
    }
}
