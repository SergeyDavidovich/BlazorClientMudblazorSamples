using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.JSInterop;

namespace BlazorClientMudblazorSamples.Client.Services.BrowserService
{
    public class BrowserService
    {
        private readonly IJSRuntime _js;

        public BrowserService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<BrowserDimension> GetDimensions()
        {
            var result= await _js.InvokeAsync<BrowserDimension>("getDimensions");
            return result;
        }

    }
    public class BrowserDimension
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
