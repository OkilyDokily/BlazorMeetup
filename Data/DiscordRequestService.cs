using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;


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

        public async Task GetServersAsync(string id, MeetupService meetupService)
        {

            string token = tokenProvider.AccessToken;

            var request = new HttpRequestMessage(HttpMethod.Get,
                "https://discord.com/api/v6/users/@me/guilds");
            request.Headers.Add("Authorization", $"Bearer {token}");
            var response = await http.SendAsync(request);
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch
            {
                Console.WriteLine("oof something went wrong");
                return;
            }
            if (response.StatusCode.ToString() == "OK")
            {

                string jsonString = await response.Content.ReadAsStringAsync();
                List<Server> servers = JsonConvert.DeserializeObject<List<Server>>(jsonString);
                servers.ForEach(x => x.AttendeeId = id);
                meetupService.AddServers(servers, id);
            }
        }
    }
}