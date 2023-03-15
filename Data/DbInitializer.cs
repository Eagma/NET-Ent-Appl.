public static class DbInitializer
{
    public static void Initialize(NewsDbContext context)
    {
        context.Database.EnsureCreated();
    }
}
