namespace CodeEvents.Api.Data.Extensions;

using Microsoft.EntityFrameworkCore;
using CodeEvents.Api.Data;
    public static class ApplicationBuilderExtensions
    {
        public static async Task<IApplicationBuilder> SeedDataAsync(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var db = serviceProvider.GetRequiredService<CodeEventsApiContext>();

                //db.Database.EnsureDeleted();
                //db.Database.Migrate();

                
                try
                {
                    await SeedData.InitAsync(db);
                }
                catch (Exception e)
                {

                    throw;
                }
            }

            return app;

        }
    }
