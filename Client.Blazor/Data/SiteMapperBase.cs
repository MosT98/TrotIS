using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Client.Blazor.Data
{
	public class SiteMapperBase : ComponentBase
	{
		[Inject]
		IJSRuntime JSRuntime { get; set; }

		protected override async Task OnAfterRenderAsync(bool x)
		{
			await JSRuntime.InvokeAsync<Task>("initMap");
		}
	}
}
