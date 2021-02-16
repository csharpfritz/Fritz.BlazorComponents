using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fritz.BlazorComponents
{

	public partial class VirtualList
	{

		[Inject]
		private IJSRuntime JS { get; set; }

		private IJSObjectReference _JsModule;

		protected override async Task OnInitializedAsync()

		{

			_JsModule = await JS.InvokeAsync<IJSObjectReference>(
				"import", $"{Constants.BaseContentFolder}/VirtualList.js");

			await base.OnInitializedAsync();

		}



	}

}
