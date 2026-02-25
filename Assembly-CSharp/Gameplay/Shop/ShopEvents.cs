using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Shop
{
	// Token: 0x02000546 RID: 1350
	[Token(Token = "0x2000546")]
	public class ShopEvents : AbstractMVCEvents
	{
		// Token: 0x06002068 RID: 8296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002068")]
		[Address(RVA = "0x71CD", Offset = "0x71CD", VA = "0x71CD")]
		public ShopEvents()
		{
		}

		// Token: 0x040011B0 RID: 4528
		[Token(Token = "0x40011B0")]
		[FieldOffset(Offset = "0x14")]
		public Action OnItemsUpdatedEvent;
	}
}
