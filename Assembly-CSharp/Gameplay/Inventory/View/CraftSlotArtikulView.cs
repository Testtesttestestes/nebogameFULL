using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Craft;

namespace Gameplay.Inventory.View
{
	// Token: 0x0200065E RID: 1630
	[Token(Token = "0x200065E")]
	public sealed class CraftSlotArtikulView : ArtikulView
	{
		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06002797 RID: 10135 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002798 RID: 10136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077B")]
		public override ArtikulData Data
		{
			[Token(Token = "0x6002797")]
			[Address(RVA = "0x78C8", Offset = "0x78C8", VA = "0x78C8", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002798")]
			[Address(RVA = "0x78C9", Offset = "0x78C9", VA = "0x78C9", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002799")]
		[Address(RVA = "0x78CA", Offset = "0x78CA", VA = "0x78CA")]
		public void SetData(CraftSchemeData.CraftSchemeInfo schemeInfo, UserCraftSlotInfo info)
		{
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600279A")]
		[Address(RVA = "0x78CB", Offset = "0x78CB", VA = "0x78CB", Slot = "10")]
		public override void Dispose()
		{
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600279B")]
		[Address(RVA = "0x78CC", Offset = "0x78CC", VA = "0x78CC")]
		public CraftSlotArtikulView()
		{
		}
	}
}
