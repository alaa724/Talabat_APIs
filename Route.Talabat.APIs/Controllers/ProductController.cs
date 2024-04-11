﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Talabat.Core.Entities;
using Talabat.Core.Repository.Contract;

namespace Route.Talabat.APIs.Controllers
{
	
	public class ProductController : BaseApiController
	{
		private readonly IGenericRepository<Product> _productsRepo;

		public ProductController(IGenericRepository<Product> productsRepo) 
		{
			_productsRepo = productsRepo;
		}
	}
}
