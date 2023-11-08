using System.Net.Http.Headers;
using Newtonsoft.Json;
using Root = beactivefootballacademy.DataModel.Root;
using RootProductId = beactivefootballacademy.DataModel.ProductId.Root;

namespace beactivefootballacademy.Services
{
    public static class ProductProviderService
	{
		public static  async Task<List<Root>> GetProducts()
		{
			List<Root> result = new List<Root>();

			foreach (var product in GetProductIds().Result.result)
			{
				HttpClient client = new HttpClient();
				try
				{
					client.DefaultRequestHeaders.Authorization =
						new AuthenticationHeaderValue("Bearer", "0ypWCgHaeWxe3ZxrSxQQGAlkP5fXNPRMdrsyfmNg");
					using HttpResponseMessage response = await client.GetAsync($"https://api.printful.com/store/products/{product.id}");
					response.EnsureSuccessStatusCode();
					string responseBody = await response.Content.ReadAsStringAsync();

					result.Add(JsonConvert.DeserializeObject<Root>(responseBody));
					Console.WriteLine(responseBody);
				}
				catch (HttpRequestException e)
				{
					Console.WriteLine("\nException Caught!");
					Console.WriteLine("Message :{0} ", e.Message);
				}

				client.Dispose();
			}

			return result;
		}

		private static async Task<RootProductId> GetProductIds()
		{
			RootProductId result = new RootProductId();
			HttpClient client = new HttpClient();
			try
			{
				client.DefaultRequestHeaders.Authorization =
					new AuthenticationHeaderValue("Bearer", "0ypWCgHaeWxe3ZxrSxQQGAlkP5fXNPRMdrsyfmNg");
				using HttpResponseMessage response = await client.GetAsync($"https://api.printful.com/store/products");
				response.EnsureSuccessStatusCode();
				string responseBody = await response.Content.ReadAsStringAsync();

				result = JsonConvert.DeserializeObject<RootProductId>(responseBody);
				Console.WriteLine(responseBody);
			}
			catch (HttpRequestException e)
			{
				Console.WriteLine("\nException Caught!");
				Console.WriteLine("Message :{0} ", e.Message);
			}

			client.Dispose();

			return result;
		}
	}
}
