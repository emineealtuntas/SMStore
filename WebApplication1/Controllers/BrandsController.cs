using Microsoft.AspNetCore.Mvc;
using SMStore.Entities;
using SMStore.Service.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SMStore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IRepository<Brand> _repository;

        public BrandsController(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        // GET: api/<BrandsController>
        [HttpGet]
        public async Task<IEnumerable<Brand>> GetAsync()
        {
            return await _repository.GetAllAsync();
        }

        // GET api/<BrandsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetAsync(int id)
        {
            var data = await _repository.FindAsync(id);
            if (data is null) return NotFound();
            return data;
        }

        // POST api/<BrandsController>
        [HttpPost]
        public async Task<ActionResult<Brand>> PostAsync([FromBody] Brand brand) 
        {
            await _repository.AddAsync(brand);
            await _repository.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = brand.Id }, brand); 
        }


        // PUT api/<BrandsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, Brand brand)
        {
            _repository.Update(brand);
            await _repository.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<BrandsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var data = _repository.Find(id);
            _repository.Delete(data);
            await _repository.SaveChangesAsync();

            return Ok();
        }
    }
}
