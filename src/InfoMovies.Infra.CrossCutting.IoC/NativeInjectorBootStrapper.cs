﻿using InfoMovies.Infra.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace InfoMovies.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // criar a classe services
            //services.AddScoped<InfoMoviesContext>();
        }
    }
}
