using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02001004 RID: 4100
	[Token(Token = "0x2001004")]
	public class GiftsScope : AbstractEventBusScope
	{
		// Token: 0x0600613D RID: 24893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600613D")]
		[Address(RVA = "0xAD68", Offset = "0xAD68", VA = "0xAD68", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600613E RID: 24894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600613E")]
		[Address(RVA = "0xAD69", Offset = "0xAD69", VA = "0xAD69")]
		public GiftsScope()
		{
		}

		// Token: 0x04003422 RID: 13346
		[Token(Token = "0x4003422")]
		[FieldOffset(Offset = "0x8")]
		public Action<GiftsScope.GiftsEventArgs> GiftSendEvent;

		// Token: 0x02001005 RID: 4101
		[Token(Token = "0x2001005")]
		public class GiftsEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700133F RID: 4927
			// (get) Token: 0x0600613F RID: 24895 RVA: 0x00011BB0 File Offset: 0x0000FDB0
			// (set) Token: 0x06006140 RID: 24896 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700133F")]
			public ulong UserId
			{
				[Token(Token = "0x600613F")]
				[Address(RVA = "0xAD6A", Offset = "0xAD6A", VA = "0xAD6A")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x6006140")]
				[Address(RVA = "0xAD6B", Offset = "0xAD6B", VA = "0xAD6B")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17001340 RID: 4928
			// (get) Token: 0x06006141 RID: 24897 RVA: 0x00011BC8 File Offset: 0x0000FDC8
			// (set) Token: 0x06006142 RID: 24898 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001340")]
			public uint GiftId
			{
				[Token(Token = "0x6006141")]
				[Address(RVA = "0xAD6C", Offset = "0xAD6C", VA = "0xAD6C")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
				[Token(Token = "0x6006142")]
				[Address(RVA = "0xAD6D", Offset = "0xAD6D", VA = "0xAD6D")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06006143 RID: 24899 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006143")]
			[Address(RVA = "0xAD6E", Offset = "0xAD6E", VA = "0xAD6E")]
			public GiftsEventArgs(IApp app, IGame game, ulong userId, uint giftId)
			{
			}
		}
	}
}
