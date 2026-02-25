using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.VortexCombat.Model
{
	// Token: 0x020003B0 RID: 944
	[Token(Token = "0x20003B0")]
	public class VortexCombatEventData : CombatEventData
	{
		// Token: 0x0600161F RID: 5663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600161F")]
		[Address(RVA = "0x67E0", Offset = "0x67E0", VA = "0x67E0")]
		public VortexCombatEventData(CombatEventDic eventDic)
		{
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003AD")]
		public override string AnimationAssetId
		{
			[Token(Token = "0x6001620")]
			[Address(RVA = "0x67E1", Offset = "0x67E1", VA = "0x67E1", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
}
