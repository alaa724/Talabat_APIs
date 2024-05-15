﻿namespace Route.Talabat.APIs.Extensions
{
	public static class SwaggerServicesExtension
	{
		public static IServiceCollection AddSwaggerServices(this IServiceCollection services)
		{
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

			services.AddEndpointsApiExplorer();
			services.AddSwaggerGen(options =>
			{
				options.CustomSchemaIds(type => type.ToString());
			});

			return services;
		}

		public static WebApplication UseSwaggerMiddlewares(this WebApplication app)
		{
			app.UseSwagger();
			app.UseSwaggerUI();

			return app;
		}
	}
}
