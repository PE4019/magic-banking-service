namespace Magic.Banking.Service.Infrastructure.Com.GuildService.Import
{
    public interface IGuildServiceClient
    {
        bool IsMemberOfGuild(Guild guild, string memberName);
    }
}
