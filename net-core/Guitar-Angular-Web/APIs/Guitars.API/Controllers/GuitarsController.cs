using Business.Common.Models;
using Business.Common.Services;
using DataModels.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace Guitar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuitarsController : ControllerBase
    {
        private readonly DatabaseConnService<Guitars> _databaseConnService;

        public GuitarsController(ApplicationDbContext dbContext)
        {
            _databaseConnService = new DatabaseConnService<Guitars>(dbContext);
        }

        [Produces("application/json")]
        [HttpGet]
        [Route("get/{guid}")]
        public IActionResult GetGuitar([FromRoute] string guid)
        {
            Guitars guitar = default;

            try
            {
                guitar = _databaseConnService.Find(x => x.GUID == guid);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(guitar);
        }

        [Produces("application/json")]
        [HttpPost]
        [Route("get/list")]
        public IActionResult GetGuitarList([FromBody] string search)
        {
            List<Guitars> guitars = default;

            try
            {
                //Usamos el método FindList para obtener una lista de registros de la base de datos
                guitars = _databaseConnService.FindList(x => x.Name.Contains(search) || x.Brand.Contains(search) || x.Description.Contains(search));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(guitars);
        }


        [Produces("application/json")]
        [HttpPost]
        [Route("save")]
        public IActionResult SaveGuitars([FromBody] Guitars input)
        {

            try
            {
                if (input.Id == 0)
                {
                    input.GUID = Guid.NewGuid().ToString().ToUpper();
                    input.CreatedAt = DateTime.Now;
                    input.UpdatedAt = DateTime.Now;
                }

                //Usamos el método Add para agregar un nuevo registro a la base de datos
                _databaseConnService.Add(input);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [HttpPost]
        [Route("update")]
        public IActionResult UpdateGuitars([FromBody] Guitars input)
        {

            try
            {
                //Usamos el método Update para actualizar un registro en la base de datos
                _databaseConnService.Update(input);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [Produces("application/json")]
        [HttpDelete]
        [Route("delete/{guid}")]
        public IActionResult DeleteGuitars([FromRoute] string guid)
        {

            try
            {
                //Usamos el método Delete para eliminar un registro de la base de datos
                bool deleted = _databaseConnService.Delete(guid);

                if (!deleted)
                {
                    return BadRequest("No se pudo eliminar el registro o no existe!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

    }
}
