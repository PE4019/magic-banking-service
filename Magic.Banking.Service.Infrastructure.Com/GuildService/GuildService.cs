using Magic.Banking.Service.Domain.Interface;
using Magic.Banking.Service.Infrastructure.Com.GuildService.Import;

namespace Magic.Banking.Service.Infrastructure.Com.GuildService
{
    public class GuildService : IGuildService
    {
        private GuildServiceClient _client;

        public bool IsAThief(string name)
        {
            _client = new GuildServiceClient();
            return _client.IsMemberOfGuild(Guild.Thieves, name);
        }
    }
}
