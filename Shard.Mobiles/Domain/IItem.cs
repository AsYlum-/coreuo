﻿namespace Shard.Mobiles.Domain
{
    public interface IItem<TItem> :
        IEntity<TItem>
        where TItem : IItem<TItem>
    {
    }
}
