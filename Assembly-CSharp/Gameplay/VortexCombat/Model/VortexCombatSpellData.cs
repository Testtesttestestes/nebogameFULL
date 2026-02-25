using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;

namespace Gameplay.VortexCombat.Model
{
	// Token: 0x020003B3 RID: 947
	[Token(Token = "0x20003B3")]
	public class VortexCombatSpellData : CombatSpellData
	{
		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003B4")]
		public override string AnimationAssetId
		{
			[Token(Token = "0x6001633")]
			[Address(RVA = "0x67F4", Offset = "0x67F4", VA = "0x67F4", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001634")]
		[Address(RVA = "0x67F5", Offset = "0x67F5", VA = "0x67F5")]
		public VortexCombatSpellData()
		{
		}
	}
}
