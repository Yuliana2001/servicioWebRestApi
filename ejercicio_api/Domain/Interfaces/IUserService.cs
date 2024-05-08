using ejercicio_api.DAL.Entities;
namespace ejercicio_api.Domain.Interfaces;
/// <summary>
/// aquí contiene la estructura de los métodos, por lo que es la clase ancestro, la cual es implementada en UserService
/// </summary>
public interface IUserService
{

	User GetByUsername(String Username);
	Task<User> CreateUser();
	Task<List<User>> ListUser();


}
