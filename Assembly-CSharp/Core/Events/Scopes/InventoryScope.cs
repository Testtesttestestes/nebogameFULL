using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Events.Scopes
{
	// Token: 0x0200100A RID: 4106
	[Token(Token = "0x200100A")]
	public class InventoryScope : AbstractEventBusScope
	{
		// Token: 0x0600614C RID: 24908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600614C")]
		[Address(RVA = "0xAD77", Offset = "0xAD77", VA = "0xAD77", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600614D")]
		[Address(RVA = "0xAD78", Offset = "0xAD78", VA = "0xAD78")]
		public InventoryScope()
		{
		}

		// Token: 0x04003429 RID: 13353
		[Token(Token = "0x4003429")]
		[FieldOffset(Offset = "0x8")]
		public Action<InventoryScope.BuySlotEventArgs> BuySlotEvent;

		// Token: 0x0400342A RID: 13354
		[Token(Token = "0x400342A")]
		[FieldOffset(Offset = "0xC")]
		public Action<InventoryScope.UsingNumpadEventArgs> UsingNumpadEvent;

		// Token: 0x0200100B RID: 4107
		[Token(Token = "0x200100B")]
		public class BuySlotEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001343 RID: 4931
			// (get) Token: 0x0600614E RID: 24910 RVA: 0x00011BE0 File Offset: 0x0000FDE0
			[Token(Token = "0x17001343")]
			public uint Quantity
			{
				[Token(Token = "0x600614E")]
				[Address(RVA = "0xAD79", Offset = "0xAD79", VA = "0xAD79")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x17001344 RID: 4932
			// (get) Token: 0x0600614F RID: 24911 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001344")]
			public ResourceSet Price
			{
				[Token(Token = "0x600614F")]
				[Address(RVA = "0xAD7A", Offset = "0xAD7A", VA = "0xAD7A")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06006150 RID: 24912 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006150")]
			[Address(RVA = "0xAD7B", Offset = "0xAD7B", VA = "0xAD7B")]
			public BuySlotEventArgs(App app, IGame game, uint quantity, ResourceSet price)
			{
			}
		}

		// Token: 0x0200100C RID: 4108
		[Token(Token = "0x200100C")]
		public class UsingNumpadEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x06006151 RID: 24913 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006151")]
			[Address(RVA = "0xAD7C", Offset = "0xAD7C", VA = "0xAD7C")]
			public UsingNumpadEventArgs(IApp app, IGame game, string articleTitle, ulong articleId, int amount, int value)
			{
			}

			// Token: 0x17001345 RID: 4933
			// (get) Token: 0x06006152 RID: 24914 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001345")]
			public string ArticleTitle
			{
				[Token(Token = "0x6006152")]
				[Address(RVA = "0xAD7D", Offset = "0xAD7D", VA = "0xAD7D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17001346 RID: 4934
			// (get) Token: 0x06006153 RID: 24915 RVA: 0x00011BF8 File Offset: 0x0000FDF8
			[Token(Token = "0x17001346")]
			public ulong ArticleId
			{
				[Token(Token = "0x6006153")]
				[Address(RVA = "0xAD7E", Offset = "0xAD7E", VA = "0xAD7E")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
			}

			// Token: 0x17001347 RID: 4935
			// (get) Token: 0x06006154 RID: 24916 RVA: 0x00011C10 File Offset: 0x0000FE10
			[Token(Token = "0x17001347")]
			public int Amount
			{
				[Token(Token = "0x6006154")]
				[Address(RVA = "0xAD7F", Offset = "0xAD7F", VA = "0xAD7F")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001348 RID: 4936
			// (get) Token: 0x06006155 RID: 24917 RVA: 0x00011C28 File Offset: 0x0000FE28
			[Token(Token = "0x17001348")]
			public int Value
			{
				[Token(Token = "0x6006155")]
				[Address(RVA = "0xAD80", Offset = "0xAD80", VA = "0xAD80")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}
		}
	}
}
