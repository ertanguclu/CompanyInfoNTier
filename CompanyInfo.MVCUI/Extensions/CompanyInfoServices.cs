using CompanyInfo.BL.Managers.Abstract;
using CompanyInfo.BL.Managers.Concrete;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CompanyInfo.MVCUI.Extensions
{
    public static class CompanyInfoServices
    {

        public static IServiceCollection AddCompanyInfoServices(this IServiceCollection services)
        {

            services.AddScoped<IBirimManager, BirimManager>();
            services.AddScoped<IUrunManager, UrunManager>();
            services.AddScoped<IKategoriManager, KategoriManager>();
            // Burasi Generic Manager siniflari cagirmak icin gereklidir
            // Eger Entity'mizin iş kurallari yoksa bu yapiyi direk kullanabiliriz
            services.AddScoped(typeof(IManager<>), typeof(ManagerBase<>));
            return services;
        }

        public static IServiceCollection CookieAyarlariEkle(this IServiceCollection services)
        {


            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/Yasak";
                options.Cookie.Name = "IstkaCompanyInfo";
                options.Cookie.HttpOnly = true; // Tarayicidaki diger scriptler bu cooki okuyamasin
                options.Cookie.SameSite = SameSiteMode.Strict; //Bizim tarayicimiz disinda kullanilmasin 
                options.ExpireTimeSpan = TimeSpan.FromDays(1);
                options.SlidingExpiration = true;

            });


            return services;
        }

        public static string TurkceKArakterTemizle(this string str)
        {
            return str.Replace('ç', 'c').Replace('ş', 's');
        }

    }
}