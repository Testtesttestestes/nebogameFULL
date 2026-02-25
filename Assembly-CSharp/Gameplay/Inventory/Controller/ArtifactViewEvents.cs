using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;

namespace Gameplay.Inventory.Controller
{
	// Token: 0x020006B0 RID: 1712
	[Token(Token = "0x20006B0")]
	[Obsolete("Bad quality code. Is Required refactoring. Dont use as tutorial/example")]
	public static class ArtifactViewEvents
	{
		// Token: 0x0400170D RID: 5901
		[Token(Token = "0x400170D")]
		[FieldOffset(Offset = "0x0")]
		public static Action<IArtifactView> RequestBuyInTdShopItemEvent;

		// Token: 0x0400170E RID: 5902
		[Token(Token = "0x400170E")]
		[FieldOffset(Offset = "0x4")]
		public static Action<IArtifactView> RequestBuyInPortalsShopItemEvent;

		// Token: 0x0400170F RID: 5903
		[Token(Token = "0x400170F")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ArtifactData, bool> RequestBuyAuchanItemEvent;

		// Token: 0x04001710 RID: 5904
		[Token(Token = "0x4001710")]
		[FieldOffset(Offset = "0xC")]
		public static Func<ArtifactData, bool> RequestBuyAuchanItemAndEquipEvent;

		// Token: 0x04001711 RID: 5905
		[Token(Token = "0x4001711")]
		[FieldOffset(Offset = "0x10")]
		public static Action ArtifactSuccessfullyBoughtEvent;
	}
}
