using System;
using System.Collections.Generic;
using Gameplay.Combat.Model.SkillsChange;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Partycombat;

namespace Gameplay.VortexCombat.Model.SkillsChange
{
	// Token: 0x020003B4 RID: 948
	[Token(Token = "0x20003B4")]
	public class ShortSpellInfo : AbstractShortSpellInfo<PlayerSkillsInfo.Types.ShortSpellInfo>
	{
		// Token: 0x06001635 RID: 5685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001635")]
		[Address(RVA = "0x67F6", Offset = "0x67F6", VA = "0x67F6")]
		public ShortSpellInfo(PlayerSkillsInfo.Types.ShortSpellInfo info)
		{
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003B5")]
		public override SpellKey SpellKey
		{
			[Token(Token = "0x6001636")]
			[Address(RVA = "0x67F7", Offset = "0x67F7", VA = "0x67F7", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003B6")]
		public override IList<EffectInfo> Effects
		{
			[Token(Token = "0x6001637")]
			[Address(RVA = "0x67F8", Offset = "0x67F8", VA = "0x67F8", Slot = "8")]
			get
			{
				return null;
			}
		}
	}
}
