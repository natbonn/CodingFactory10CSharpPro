namespace WebAppStarter10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();    // δημιουργείται ο kestrel

            // Configure the HTTP request pipeline. - Φίλτρα με τη σειρά που τα καλούμε
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();  // επιβάλλει τη χρήση HTTPS
            }

            app.UseHttpsRedirection();

            app.UseRouting();       // Δρομολόγηση req mapping with controllers

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapRazorPages()     // χρησιμοποιεί έμμεσα το UseRouting
               .WithStaticAssets();

            app.Run();      // ο kestrel σηκώνεται και κλεινει με ctrl + c
        }
    }
}
