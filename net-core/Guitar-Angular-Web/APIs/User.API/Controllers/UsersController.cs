using Business.Common.Models;
using Business.Common.Services;
using DataModels.DbModels;
using DataModels.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DatabaseConnService<Users> _databaseConnService;

        public UsersController(ApplicationDbContext dbContext)
        {
            _databaseConnService = new DatabaseConnService<Users>(dbContext);
        }

        [Produces("application/json")]
        [HttpPost]
        [Route("login")]
        public IActionResult LoginUsers([FromBody] UserLogin input)
        {
            UserInfo userInfo = default;

            try
            {
                //Encontrar el usuario por su nombre de usuario y contraseña
                var user = _databaseConnService.Find(u => u.UserName == input.UserName && u.Password == input.Password);

                //Verificar si el usuario existe
                if (user == null)
                {
                    return BadRequest("Usuario o contraseña incorrectos");
                }

                //Si el usuario existe, crear un objeto UserInfo con los datos del usuario
                if (user is not null && user.Id > 0)
                {
                    userInfo = new UserInfo(user);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(userInfo);
        }

        [Produces("application/json")]
        [HttpGet]
        [Route("get/{guid}")]
        public IActionResult GetUser([FromRoute] string guid)
        {
            try
            {
                //Usamos el método GetByGUID para obtener un registro de la base de datos
                _databaseConnService.GetByGUID(guid);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [Produces("application/json")]
        [HttpPost]
        [Route("get/list")]
        public IActionResult GetUserList([FromBody] string FirstName)
        {
            List<Users> users = default;

            try
            {
                //Usamos el método Find para obtener un registro de la base de datos using like
                users = _databaseConnService.FindList(x => x.FirstName.Contains(FirstName));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(users);
        }

        [Produces("application/json")]
        [HttpPost]
        [Route("save")]
        public IActionResult SaveUsers([FromBody] Users input)
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

        [Produces("application/json")]
        [HttpPut]
        [Route("update")]
        public IActionResult UpdateUsers([FromBody] Users input)
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
        public IActionResult DeleteUsers([FromRoute] string guid)
        {

            try
            {
                //Usamos el método Delete para eliminar un registro de la base de datos
                bool deleted = _databaseConnService.Delete(guid);

                if (deleted == false)
                    return BadRequest("No se pudo eliminar el registro o ya no existe!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}
