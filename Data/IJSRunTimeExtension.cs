using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMeetup.Data
{
    public static class IJSRunTimeExtension
    {
        public static async void CreateMessage(this IJSRuntime jSRuntime,string message)
        {
            await jSRuntime.InvokeVoidAsync("callToastr",message);
        }
    }
}
