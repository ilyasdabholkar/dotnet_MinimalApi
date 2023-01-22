using DataAccess.Data;
using DataAccess.DbAccess;

namespace MinimalApi
{
    public static class Services
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddSingleton<ISqlDataAccess, SqlDataAccess>();
            services.AddSingleton<IUserData, UserData>();
        }
    }
}
