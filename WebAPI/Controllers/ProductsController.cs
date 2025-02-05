﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    //Autofac, Ninject, CastleWindsor, StructureMap, LightInject, DryInkect --> IoC Container altyapıları sunan projler
    //[LogAspect] --> AOP  bir methodun önünde yada bir methodun sonunda veya hata verdiğinde configrasyona göre çalışan kod parçacıkları bussiness içinde business yazmaktır.   
    //hata yönetimi kodlama yönetimi performans yönetimi cash yönetimi gibi gibi şeyleri aynı sınıfa methoda fonk. a koymak orayı çorba edicektir.
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("delete")]
        //public IActionResult Delete(Product product)
        //{
        //    var result = _productService
        //}
        

    }
}
