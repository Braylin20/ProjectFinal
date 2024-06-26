using FinalProject.Client.Pages;
using FinalProject.Client.Services;
using FinalProject.Components;
using FinalProject.Controllers;
using FinalProject.Dal;
using FinalProject.Services;
using Microsoft.EntityFrameworkCore;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddBlazorBootstrap();


var ConStr = builder.Configuration.GetConnectionString("ConStr");
builder.Services.AddDbContext<Context>(op =>
    op.UseSqlServer(ConStr)
    );

builder.Services.AddScoped(c =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.Configuration["RutaApi"] ?? "https://localhost:7174")
    }
);
builder.Services.AddHttpClient();
builder.Services.AddRadzenComponents();
//Services Api
builder.Services.AddScoped<UsuariosServices>();
builder.Services.AddScoped<DemandasServices>();
builder.Services.AddScoped<EmpleadosServices>();
builder.Services.AddScoped<SentenciasServices>();
builder.Services.AddScoped<ExpedientesServices>();
builder.Services.AddScoped<AudienciasServices>();
builder.Services.AddScoped<EmpleadoSentenciaServices>();



//Servies Client
//builder.Services.AddScoped<AudienciasServicesDto>();
builder.Services.AddScoped<DemandaServices>();
builder.Services.AddScoped<AudienciaServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();

    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(FinalProject.Client._Imports).Assembly);

app.MapControllers();
app.Run();
