using API_EM_C_.src.shared.application.port;
using API_EM_C_.src.shared.infrastructure.services.Data;
using API_EM_C_.src.user.domain.port.repository;
using API_EM_C_.src.user.domain.port.usecases.v1;
using API_EM_C_.src.user.infra.repository;
using API_EM_C_.src.user.usecases.v1;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddScoped<IRepositoryUser, UserRepository>();
builder.Services.AddScoped<IFindAllUsers, FindallUsersUsecase>();
builder.Services.AddScoped<ICreateUserPort, CreateUserUseCase>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
