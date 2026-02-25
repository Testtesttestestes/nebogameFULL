using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02000FFF RID: 4095
	[Token(Token = "0x2000FFF")]
	public class DiscountsScope : AbstractEventBusScope
	{
		// Token: 0x06006132 RID: 24882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006132")]
		[Address(RVA = "0xAD5E", Offset = "0xAD5E", VA = "0xAD5E", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006133")]
		[Address(RVA = "0xAD5F", Offset = "0xAD5F", VA = "0xAD5F")]
		public DiscountsScope()
		{
		}

		// Token: 0x04003412 RID: 13330
		[Token(Token = "0x4003412")]
		[FieldOffset(Offset = "0x8")]
		public Action<DiscountsScope.DiscountClickEventArgs> DiscountClickEvent;

		// Token: 0x02001000 RID: 4096
		[Token(Token = "0x2001000")]
		public class DiscountClickEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700133E RID: 4926
			// (get) Token: 0x06006134 RID: 24884 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700133E")]
			public DiscountData DiscountData
			{
				[Token(Token = "0x6006134")]
				[Address(RVA = "0xAD60", Offset = "0xAD60", VA = "0xAD60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006135 RID: 24885 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006135")]
			[Address(RVA = "0xAD61", Offset = "0xAD61", VA = "0xAD61")]
			public DiscountClickEventArgs(App app, IGame game, DiscountData discountData)
			{
			}
		}
	}
}
