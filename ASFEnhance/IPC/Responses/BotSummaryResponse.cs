﻿namespace ASFEnhance.IPC.Responses
{
    public sealed class BotSummaryResponse
    {
        public bool Success { get; set; }
        public string Currency { get; set; }
        public long Balance { get; set; }
        public string FormatBalance { get; set; }
        public string Nick { get; set; }
        public string ProfileLink { get; set; }
        public ulong SteamID { get; set; }
        public ulong FriendCode { get; set; }
    }
}
