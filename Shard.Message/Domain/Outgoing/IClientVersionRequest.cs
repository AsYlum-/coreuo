﻿namespace Shard.Message.Domain.Outgoing
{
    public interface IClientVersionRequest
    {
        internal void WriteClientVersionRequest(IData data)
        {
        }
    }
}