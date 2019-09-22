using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using MagicCardsGraphQL.Data;
using MagicCardsGraphQL.GraphQL;
using MagicCardsGraphQL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace MagicCardsGraphQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<MagicCardsDbContext>(options =>
                options.UseSqlServer(Configuration["ConnectionStrings:MagicCards"]));

            services.AddTransient<CardsRepository>();

            services.AddScoped<IDependencyResolver>(x => new FuncDependencyResolver(x.GetRequiredService));
            services.AddScoped<MagicCardsSchema>();

            services.AddGraphQL(x => { x.ExposeExceptions = true; })
                .AddGraphTypes(ServiceLifetime.Scoped); // Searches all product types and registered them in the container
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MagicCardsDbContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseGraphQL<MagicCardsSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions()); // /ui/playground
            dbContext.Seed();
        }
    }
}
