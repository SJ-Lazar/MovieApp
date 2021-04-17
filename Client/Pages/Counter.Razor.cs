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

        private int currentCount = 0;

      
        public void IncrementCount()
        {
            currentCount++;
        }
    }
}
