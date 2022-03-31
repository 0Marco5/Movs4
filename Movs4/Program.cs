using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

using Newtonsoft.Json;

namespace the_Cryptocurrencies_bot_Movs
{
    public class API
    {
        static async Task Main(string[] args)
        {
            Mensaje m = new Mensaje();
            await m.CheckMOVRAsync();
            await m.CheckNEOAsync();
            await m.CheckORAIAsync();
            await m.CheckPDEXAsync();
            await m.CheckRMRKAsync();
            await m.CheckSDNAsync();
            await m.CheckSHIBAsync();
            await m.CheckSLPAsync();
            await m.CheckSNXAsync();
            await m.CheckSOLAsync();
            await m.CheckSTORJAsync();
            await m.CheckSXPAsync();
            await m.CheckSYLOAsync();
            await m.CheckTCPAsync();
        }
    }
}