namespace RazorMVC.Data
{
    public static class DbInitializer
    {
        public static void Initialize(FavouritesDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
