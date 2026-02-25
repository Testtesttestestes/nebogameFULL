using System;
using Il2CppDummyDll;

namespace Gameplay.Inventory.Model.Tabs
{
	// Token: 0x020006AC RID: 1708
	[Token(Token = "0x20006AC")]
	public class InventoryTabData
	{
		// Token: 0x06002951 RID: 10577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002951")]
		[Address(RVA = "0x1F96", Offset = "0x1F96", VA = "0x1F96")]
		public InventoryTabData()
		{
		}

		// Token: 0x040016FF RID: 5887
		[Token(Token = "0x40016FF")]
		[FieldOffset(Offset = "0x8")]
		public InventoryTabData.InventoryTabType Type;

		// Token: 0x04001700 RID: 5888
		[Token(Token = "0x4001700")]
		[FieldOffset(Offset = "0xC")]
		public InventoryMetaFilterData MetaFilterData;

		// Token: 0x020006AD RID: 1709
		[Token(Token = "0x20006AD")]
		public enum InventoryTabType
		{
			// Token: 0x04001702 RID: 5890
			[Token(Token = "0x4001702")]
			All = 1,
			// Token: 0x04001703 RID: 5891
			[Token(Token = "0x4001703")]
			Favorite,
			// Token: 0x04001704 RID: 5892
			[Token(Token = "0x4001704")]
			Fresh,
			// Token: 0x04001705 RID: 5893
			[Token(Token = "0x4001705")]
			ArtikulTypeFilter
		}
	}
}
