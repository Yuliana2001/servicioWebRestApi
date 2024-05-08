using ejercicio_api.DAL.Entities;
using ejercicio_api.Domain.Interfaces;
using System.Text.Json;
/// <summary>
/// clase para invocar un servicio remoto, la url del servicio es:
/// </summary>

public class UserService : IUserService

{
	/// <summary>
	/// instancia de list
	/// </summary>
	public static List<User> Usuarios = new List<User>();
	/// <summary>
	/// metodo para crear usuario utilizando la url del servicio con el propósito de llenar la lista Usuarios
	/// </summary>
	/// <returns></returns>
	public async Task<User> CreateUser()
	{
		String url = "https://randomuser.me/api/";
		JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
		using (HttpClient httpClient = new HttpClient())
		{
			HttpResponseMessage response = await httpClient.GetAsync(url);
			if (response.IsSuccessStatusCode)
			{
				String content = await response.Content.ReadAsStringAsync();
				User usuario = JsonSerializer.Deserialize<User>(content, options);
				if (usuario != null)
				{
					Usuarios.Add(usuario);
					return usuario;
				}

			}

		}
		return null;
	}

	/// <summary>
	/// método que obtiene el usuario mediante el username de la lista results
	/// </summary>
	/// <param name="Username"></param>
	/// <returns></returns>

	public User GetByUsername(String Username)
	{

		for (Int32 i = 0; i < Usuarios.Count; i++)
		{
			if (Usuarios[i].Results[0].Login.Username == Username)
			{
				return Usuarios[i];
			}



		}
		return null;
	}
	/// <summary>
	/// método que retorna la lista de usuarios
	/// </summary>
	/// <returns></returns>
	public async Task<List<User>> ListUser()
	{
		return Usuarios;

	}
}

