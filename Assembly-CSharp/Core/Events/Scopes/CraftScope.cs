using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Craft;

namespace Core.Events.Scopes
{
	// Token: 0x02000FFA RID: 4090
	[Token(Token = "0x2000FFA")]
	public class CraftScope : AbstractEventBusScope
	{
		// Token: 0x06006127 RID: 24871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006127")]
		[Address(RVA = "0xAD53", Offset = "0xAD53", VA = "0xAD53", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006128")]
		[Address(RVA = "0xAD54", Offset = "0xAD54", VA = "0xAD54")]
		public CraftScope()
		{
		}

		// Token: 0x0400340B RID: 13323
		[Token(Token = "0x400340B")]
		[FieldOffset(Offset = "0x8")]
		public Action<CraftScope.CraftEventArgs> StartCraftEvent;

		// Token: 0x0400340C RID: 13324
		[Token(Token = "0x400340C")]
		[FieldOffset(Offset = "0xC")]
		public Action<CraftScope.CraftSlotsEventArgs> CraftSlotsRequestedEvent;

		// Token: 0x02000FFB RID: 4091
		[Token(Token = "0x2000FFB")]
		public class CraftEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700133A RID: 4922
			// (get) Token: 0x06006129 RID: 24873 RVA: 0x00011B80 File Offset: 0x0000FD80
			[Token(Token = "0x1700133A")]
			public uint SchemeId
			{
				[Token(Token = "0x6006129")]
				[Address(RVA = "0xAD55", Offset = "0xAD55", VA = "0xAD55")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x1700133B RID: 4923
			// (get) Token: 0x0600612A RID: 24874 RVA: 0x00011B98 File Offset: 0x0000FD98
			[Token(Token = "0x1700133B")]
			public uint Quantity
			{
				[Token(Token = "0x600612A")]
				[Address(RVA = "0xAD56", Offset = "0xAD56", VA = "0xAD56")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x0600612B RID: 24875 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600612B")]
			[Address(RVA = "0xAD57", Offset = "0xAD57", VA = "0xAD57")]
			public CraftEventArgs(App app, IGame game, uint schemeId, uint quantity)
			{
			}
		}

		// Token: 0x02000FFC RID: 4092
		[Token(Token = "0x2000FFC")]
		public class CraftSlotsEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x1700133C RID: 4924
			// (get) Token: 0x0600612C RID: 24876 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700133C")]
			public IEnumerable<UserCraftSlotInfo> Slots
			{
				[Token(Token = "0x600612C")]
				[Address(RVA = "0xAD58", Offset = "0xAD58", VA = "0xAD58")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600612D RID: 24877 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600612D")]
			[Address(RVA = "0xAD59", Offset = "0xAD59", VA = "0xAD59")]
			public CraftSlotsEventArgs(App app, IGame game, IEnumerable<UserCraftSlotInfo> slots)
			{
			}
		}
	}
}
