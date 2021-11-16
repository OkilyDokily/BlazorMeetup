using Microsoft.JSInterop;

namespace BlazorMeetup.Data
{
    public static class IJSRunTimeExtension
    {
        public static async void CreateMessage(this IJSRuntime jSRuntime, string message)
        {
            await jSRuntime.InvokeVoidAsync("callToastr", message);
        }
    }
}
