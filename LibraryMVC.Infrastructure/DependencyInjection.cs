using LibraryMVC.Domain.Interface;
using LibraryMVC.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure (this IServiceCollection services)
        {
            services.AddTransient<IReaderRepository, ReaderRepository>();
            services.AddTransient<IBookRepository, BookRepository>();
            return services;
        }
    }
}
