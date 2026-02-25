using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000696 RID: 1686
	[Token(Token = "0x2000696")]
	public class MedalsCategoryData
	{
		// Token: 0x060028BA RID: 10426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028BA")]
		[Address(RVA = "0x1C23", Offset = "0x1C23", VA = "0x1C23")]
		public MedalsCategoryData()
		{
		}

		// Token: 0x0400167D RID: 5757
		[Token(Token = "0x400167D")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		// Token: 0x0400167E RID: 5758
		[Token(Token = "0x400167E")]
		[FieldOffset(Offset = "0xC")]
		public IList<MedalData> Items;
	}
}
