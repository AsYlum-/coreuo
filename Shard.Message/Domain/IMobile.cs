﻿using Shard.Message.Domain.Incoming;
using Shard.Message.Domain.Outgoing;

namespace Shard.Message.Domain
{
    public interface IMobile<TMobileEquip, TSkillInfo> : ICharacterInfo, ILoginConfirm, IMobileIncoming<TMobileEquip>, IMobileLight, IMobileStatus, IMobileUpdate, IMoveNotoriety, ISkillList<TSkillInfo>, ICharacterCreation
        where TMobileEquip : IMobileEquip
        where TSkillInfo : ISkill
    {
    }
}