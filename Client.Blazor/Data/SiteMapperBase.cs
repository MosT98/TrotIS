using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System;


namespace Client.Blazor.Data
{
	public class SiteMapperBase : ComponentBase
	{
		private List<Location> allLocations = new List<Location>();
		readonly string URL = @"http://localhost:5009/api/locations";

		[Inject]
		IJSRuntime JSRuntime { get; set; }

		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			if(!firstRender)
			{
				GetLocations();

				await JSRuntime.InvokeAsync<Task>("initMap", allLocations);
			}
		}

		public void GetLocations()
		{
			try
			{
				HttpClient client = new HttpClient();
				client.BaseAddress = new Uri(URL);

				// Add an Accept header for JSON format.
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				// List data response.
				HttpResponseMessage response = client.GetAsync("").Result;
				if (response.IsSuccessStatusCode)
				{
					// Parse the response body.
					allLocations = response.Content.ReadAsAsync<List<Location>>().Result;
				}
				else
				{
					Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
				}

				client.Dispose();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}