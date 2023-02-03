using Microsoft.AspNetCore.Http.Features;
using TarjetaPresentacion.API.Helpers;

namespace TarjetaPresentacion.API.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) {

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin() //Se puede cambiar este  metodo AllowAnyOrigin() que permite recibir peticiones desde cualquier punto y  usar en cambio WithOrigins("http://www.something.com") que recibira peticiones  solo de esa punto
                                      .AllowAnyMethod() //En vez de usar AllowAnyMethod() que  permite recibir cualquier metodo HTTP, se puede usar WithMethods("POST", "GET")  que permitira solo metodos HTTP especificos
                                      .AllowAnyHeader()); //Los mismos cambios se pueden aplicar para  AllowAnyHeader(), que podria usar, por ejemplo el metodo WithHeaders("accept",  "content-type") que permitira solo headers especificos

                //Cuando intento poner este metodo me sale error, al hacer un request
                //'The CORS protocol does not allow specifying a wildcard (any) origin and credentials at the same time. Configure the CORS policy by listing individual origins if credentials needs to be supported.'
                //TODO : VERIFICAR OTRA VEZ DESPUES DE IMPLEMENTAR EL TOKEN
                //.AllowCredentials());
            });

        }

        public static void ConfigureDefaults(this IServiceCollection services)
        {

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.Configure<FormOptions>(o => {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = 26214400; // 25MB (1MB = 1048576)
                //o.MultipartBodyLengthLimit = int.MaxValue; // 128MB aprox es el maximo (pero no dejara guardar esa cantidad por el CORS)
                o.MemoryBufferThreshold = int.MaxValue; // 

                o.MultipartBoundaryLengthLimit = int.MaxValue;
                o.MultipartHeadersCountLimit = int.MaxValue;
                o.MultipartHeadersLengthLimit = int.MaxValue;
            });

            services.AddScoped<StatusCodeBuilder>();
        }
    }
}
