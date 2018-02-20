using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTAuthorization.Entities;
using JWTAuthorization.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnet_grocery_list.Controllers
    {
        [Route("api/groceryList")]
        public class GroceryListController : Controller
        {
            private readonly GroceryListContext Context;

            public GroceryListController(GroceryListContext context)
            {
                Context = context;

                if (Context.GroceryList.Count() == 0)
                {
                    Context.GroceryList.Add(new GroceryItem { Description = "Item1" });
                    Context.SaveChanges();
                }
            }

            [HttpGet]
            public IEnumerable<GroceryItem> GetAll()
            {
                return Context.GroceryList.ToList();
        }

            [HttpGet("{id}", Name = "GetGroceryItem")]
            public IActionResult GetById(long id)
            {
                var item = Context.GroceryList.FirstOrDefault(t => t.Id == id);
                if (item == null)
                {
                    return NotFound();
                }
            return new ObjectResult(item);
           
            }

            [HttpPost]
            public IActionResult Create([FromBody] GroceryItem item)
            {
                if (item == null)
                {
                    return BadRequest();
                }

                Context.GroceryList.Add(item);
                Context.SaveChanges();

                return CreatedAtRoute("GetGroceryItem", new { id = item.Id }, item);
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(long id)
            {
                var item = Context.GroceryList.First(t => t.Id == id);
                if (item == null)
                {
                    return NotFound();
                }

                Context.GroceryList.Remove(item);
                Context.SaveChanges();
                return new NoContentResult();
            }
        }
    }
