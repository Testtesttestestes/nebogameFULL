using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;

namespace Gameplay.Combat.Model.SkillsChange
{
	// Token: 0x020009A5 RID: 2469
	[Token(Token = "0x20009A5")]
	public class ShortSpellInfo : AbstractShortSpellInfo<ProtoSkillsChangedEvt.Types.ShortSpellInfo>
	{
		// Token: 0x06003AFB RID: 15099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AFB")]
		[Address(RVA = "0x8A66", Offset = "0x8A66", VA = "0x8A66")]
		public ShortSpellInfo(ProtoSkillsChangedEvt.Types.ShortSpellInfo info)
		{
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BB4")]
		public override SpellKey SpellKey
		{
			[Token(Token = "0x6003AFC")]
			[Address(RVA = "0x8A67", Offset = "0x8A67", VA = "0x8A67", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06003AFD RID: 15101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BB5")]
		public override IList<EffectInfo> Effects
		{
			[Token(Token = "0x6003AFD")]
			[Address(RVA = "0x8A68", Offset = "0x8A68", VA = "0x8A68", Slot = "8")]
			get
			{
				return null;
			}
		}
	}
}
