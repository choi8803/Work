using AspNetCoreWebApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressConsumesConstraintForFormFileParameters = true;
        options.SuppressInferBindingSourcesForParameters = true;
        options.SuppressModelStateInvalidFilter = true;
        options.SuppressMapClientErrors = true;
        options.ClientErrorMapping[StatusCodes.Status404NotFound].Link =
            "https://httpstatuses.com/404";
    });
builder.Services.AddMvc(option => option.EnableEndpointRouting = false)
    .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

builder.Services.AddDbContext<BookStoresDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BookStoresDB")));

#region [#08. Authentication] 
var jwtSection = builder.Configuration.GetSection("JWTSettings");
builder.Services.Configure<JWTSettings>(jwtSection);

//to validate the token which has been sent by clients
var appSettings = jwtSection.Get<JWTSettings>();
var key = Encoding.ASCII.GetBytes(appSettings.SecretKey);

builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = true;
    opt.SaveToken = true;
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

#endregion

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(gen =>
{
    //gen.SwaggerDoc("v1.0", new OpenApiInfo { Title = "Book Stores API", Version = "1.0" });
    gen.SwaggerDoc("api", new OpenApiInfo
    {
        Title = "API",
        Description = "API Description",
        Version = "1.0",
        Contact = new OpenApiContact
        {
            Name = "서버 정보 - Server Gitlab",
            Email = "choijh225@naver.com",
            Url = new Uri("https://github.com/choi8803/BookStore")
        }
    });
    gen.SwaggerDoc("admin", new OpenApiInfo
    {
        Title = "Admin API",
        Description = "Admin Description",
        Version = "1.0",
        Contact = new OpenApiContact
        {
            Name = "서버 정보 - Server Gitlab",
            Email = "choijh225@naver.com",
            Url = new Uri("https://github.com/choi8803/BookStore")
        }
    });
});
// /swagger/v1.0/swagger.json

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseStaticFiles();
    //app.UseOpenApi();
    //app.UseSwaggerUi3();
    //app.UseMvc();

    app.UseSwagger();
    app.UseSwaggerUI(ui =>
    {
        ui.SwaggerEndpoint("/swagger/api/swagger.json", "Api Doc");
        ui.SwaggerEndpoint("/swagger/admin/swagger.json", "Admin Doc");
    });
}

app.UseHttpsRedirection();

app.UseAuthentication();    //[#08. Authentication]
app.UseAuthorization();

app.MapControllers();

app.Run();
