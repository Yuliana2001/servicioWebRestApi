using System.Text.Json.Serialization;

namespace ejercicio_api.DAL.Entities
{

	/// <summary>
	/// Creación de clases con sus respectivos atributos
	/// </summary>
	public class User
	{
		[JsonPropertyName("results")]
		public Result[] Results { get; set; }
		[JsonPropertyName("info")]
		public Info Info { get; set; }
	}

	public class Info
	{
		[JsonPropertyName("seed")]

		public String Seed { get; set; }
		[JsonPropertyName("results")]
		public Int32 Results { get; set; }
		[JsonPropertyName("page")]
		public Int32 Page { get; set; }
		[JsonPropertyName("version")]
		public String Version { get; set; }
	}

	public class Result
	{
		[JsonPropertyName("gender")]
		public String Gender { get; set; }
		[JsonPropertyName("name")]
		public Name Name { get; set; }
		[JsonPropertyName("location")]
		public Location Location { get; set; }
		[JsonPropertyName("email")]
		public String Email { get; set; }
		[JsonPropertyName("login")]
		public Login Login { get; set; }
		[JsonPropertyName("dob")]
		public Dob Dob { get; set; }
		[JsonPropertyName("registered")]
		public Registered Registered { get; set; }
		[JsonPropertyName("phone")]
		public String Phone { get; set; }
		[JsonPropertyName("cell")]
		public String Cell { get; set; }
		[JsonPropertyName("id")]
		public Id Id { get; set; }
		[JsonPropertyName("picture")]
		public Picture Picture { get; set; }
		[JsonPropertyName("nat")]
		public String Nat { get; set; }
	}

	public class Name
	{
		[JsonPropertyName("title")]
		public String Title { get; set; }
		[JsonPropertyName("first")]
		public String First { get; set; }
		[JsonPropertyName("last")]
		public String Last { get; set; }
	}

	public class Location
	{
		[JsonPropertyName("street")]
		public Street Street { get; set; }
		[JsonPropertyName("city")]
		public String City { get; set; }
		[JsonPropertyName("state")]
		public String State { get; set; }
		[JsonPropertyName("country")]
		public String Country { get; set; }
		[JsonPropertyName("postcode")]
		public Int64 Postcode { get; set; }
		[JsonPropertyName("coordinates")]
		public Coordinates Coordinates { get; set; }
		[JsonPropertyName("timezone")]
		public Timezone Timezone { get; set; }
	}

	public class Street
	{
		[JsonPropertyName("number")]
		public Int32 Number { get; set; }
		[JsonPropertyName("name")]
		public String Name { get; set; }
	}

	public class Coordinates
	{
		[JsonPropertyName("latitude")]
		public String Latitude { get; set; }
		[JsonPropertyName("longitude")]
		public String Longitude { get; set; }
	}

	public class Timezone
	{
		[JsonPropertyName("offset")]
		public String Offset { get; set; }
		[JsonPropertyName("description")]
		public String Description { get; set; }
	}

	public class Login
	{
		[JsonPropertyName("uuid")]
		public String Uuid { get; set; }
		[JsonPropertyName("username")]
		public String Username { get; set; }
		[JsonPropertyName("password")]
		public String Password { get; set; }
		[JsonPropertyName("salt")]
		public String Salt { get; set; }
		[JsonPropertyName("md5")]
		public String Md5 { get; set; }
		[JsonPropertyName("sha1")]
		public String Sha1 { get; set; }
		[JsonPropertyName("sha256")]
		public String Sha256 { get; set; }
	}

	public class Dob
	{
		[JsonPropertyName("date")]
		public DateTime Date { get; set; }
		[JsonPropertyName("age")]
		public Int32 Age { get; set; }
	}

	public class Registered
	{
		[JsonPropertyName("date")]
		public DateTime Date { get; set; }
		[JsonPropertyName("age")]
		public Int32 Age { get; set; }
	}

	public class Id
	{
		[JsonPropertyName("name")]
		public String Name { get; set; }
		[JsonPropertyName("value")]
		public String Value { get; set; }
	}

	public class Picture
	{
		[JsonPropertyName("large")]
		public String Large { get; set; }
		[JsonPropertyName("medium")]
		public String Medium { get; set; }
		[JsonPropertyName("thumbnail")]
		public String Thumbnail { get; set; }
	}

}
