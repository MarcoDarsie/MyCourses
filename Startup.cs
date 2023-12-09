using System.Net.Security;

public async void Configure (IApplicationBuilder app , IHostingEnvironment env)
{
    //if (env.IsDevelopment())
    if (env.IsEnviroment("Development"))
    {
        app.UseDeveloperExceptionPage();
    }
    app.UseStaticFiles();

    app.Run(async (context)) =>
    {
        string nome = ContextBoundObject.Request.Query ["nome"];
        await ContextBoundObject.Response.WriteAsync($"Hello {nome}!");
    }
}