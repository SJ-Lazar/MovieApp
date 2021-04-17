using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MovieApp.Client.Shared;
using MovieApp.Shared.Entities;

namespace MovieApp.Client.Pages
{
    public partial class Counter
    {
        [Inject] private SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }
        [Inject] private IJSRuntime js { get; set; }
        [CascadingParameter] public MainLayout.AppState AppState { get; set; }
      

        private List<Movie> movies;

        protected override void OnInitialized()
        {
            movies = new List<Movie>()
            {
                new Movie() {Title = "Joker", ReleaseDate = new DateTime(2016, 11, 23)},
                new Movie() {Title = "Justice League", ReleaseDate = new DateTime(2015, 05, 01)}
            };
        }

        private int currentCount = 0;
        private static int currentCountStatic = 0;

        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            singleton.Value = currentCount;
            transient.Value = currentCount;
            currentCountStatic++;
           await js.InvokeVoidAsync("dotnetStaticInvocation");
        }

        private async Task IncrementCountJavaScript()
        {
            await js.InvokeVoidAsync("dotnetInstanceInvocation",
                DotNetObjectReference.Create(this));
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
