using System;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x0200094C RID: 2380
	[Token(Token = "0x200094C")]
	[Serializable]
	public class CombatUserBalanceItem
	{
		// Token: 0x0600385C RID: 14428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385C")]
		[Address(RVA = "0x8813", Offset = "0x8813", VA = "0x8813")]
		public CombatUserBalanceItem()
		{
		}

		// Token: 0x04001F31 RID: 7985
		[Token(Token = "0x4001F31")]
		[FieldOffset(Offset = "0x8")]
		public Resources ResourceId;

		// Token: 0x04001F32 RID: 7986
		[Token(Token = "0x4001F32")]
		[FieldOffset(Offset = "0xC")]
		public CombatUserBalanceItemRenderer ItemRenderer;
	}
}
