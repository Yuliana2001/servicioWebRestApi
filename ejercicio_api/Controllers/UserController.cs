using ejercicio_api.DAL.Entities;
using ejercicio_api.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ejercicio_api.Controllers
{
	/// <summary>
	/// Dentro del controlador se crearon 3 métodos
	/// </summary>
	[Route("api/[controller]")]
	[ApiController]

	public class UserController : ControllerBase
	{
		private readonly IUserService _userService;
		public UserController(IUserService userService)
		{
			this._userService = userService;
		}


		/// <summary>
		/// CreateUser -> POST
		/// </summary>
		/// <returns></returns>
		[HttpPost, ActionName("Post")]
		[Route("CreateUser")]
		public async Task<ActionResult<User>> CreateUser()
		{
			return await this._userService.CreateUser();
		}

		/// <summary>
		/// GetUser -> GET -> Recibe como parámetro el login como String
		/// </summary>
		/// <returns></returns>
		[HttpGet, ActionName("Get")]
		[Route("ListUsers")]
		public async Task<ActionResult<List<User>>> ListUser()
		{
			List<User> usuarios = await this._userService.ListUser();
			if (usuarios != null)
			{
				return usuarios;
			}
			return null;
		}
		/// <summary>
		/// ListUsers -> GET
		/// </summary>
		/// <param name="Username"></param>
		/// <returns></returns>
		[HttpGet, ActionName("Get")]
		[Route("GetByIdAsync/{Username}")]
		public ActionResult<User> GetByUsername(String Username)
		{
			if (Username == null) return this.BadRequest("Id es requerido!");
			User usuario = this._userService.GetByUsername(Username);
			return usuario;
		}

	}
}

