using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace BlazorMeetup.Data
{
    public class DiscordRequestService
    {
        private readonly HttpClient http;
        private readonly TokenProvider tokenProvider;

        public DiscordRequestService(IHttpClientFactory clientFactory,
            TokenProvider tokenProvider)
        {
            http = clientFactory.CreateClient();
            this.tokenProvider = tokenProvider;
        }

        public async Task<List<Server>> GetServersAsync()
        {

            string token = tokenProvider.AccessToken;

            Console.WriteLine(token + " token from get server async");
            List<Server> servers = new();
            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://discord.com/api/v8/oauth2/users/@me/guilds");
            request.Headers.Add("Authorization", $"Bearer {token}");
            var response = await http.SendAsync(request);
            try
            {
                response.EnsureSuccessStatusCode();
                Console.WriteLine("success");
                Console.WriteLine(response.StatusCode.ToString());
            }
            catch
            {
                Console.WriteLine("oof something went wrong");
            }
            return servers;
        }
    }
}