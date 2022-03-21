var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<CakmaKariyerContext>();
builder.Services.AddScoped<IAccountRepository,AccountRepository>();
builder.Services.AddScoped<IAccountService,AccountService>();
builder.Services.AddScoped<IRoleRepository,RoleRepository>();
builder.Services.AddScoped<IRoleService,RoleService>();
builder.Services.AddScoped<IAccountEmployerDetailRepository,AccountEmployerDetailRepository>();
builder.Services.AddScoped<IAccountEmployerDetailService,AccountEmployerDetailService>();
builder.Services.AddScoped<IAccountStudentDetailRepository,AccountStudentDetailRepository>();
builder.Services.AddScoped<IAccountStudentDetailService,AccountStudentDetailService>();
builder.Services.AddScoped<IAddressRepository,AddressRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
