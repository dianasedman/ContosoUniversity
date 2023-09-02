namespace ContosoUniversity.Data;

//For NET 6
//https://learn.microsoft.com/en-us/training/modules/persist-data-ef-core/4-interacting-data

public static class Extensions
{
    public static void CreateDbIfNotExists(this IHost host)
    {
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<SchoolContext>();
                context.Database.EnsureCreated();
                DbInitializer.Initialize(context);
            }
        }
    }
}