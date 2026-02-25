using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;

namespace Core.Events.Scopes
{
	// Token: 0x02001027 RID: 4135
	[Token(Token = "0x2001027")]
	public class ShopScope : AbstractEventBusScope
	{
		// Token: 0x060061A8 RID: 25000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061A8")]
		[Address(RVA = "0xADD3", Offset = "0xADD3", VA = "0xADD3", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061A9")]
		[Address(RVA = "0xADD4", Offset = "0xADD4", VA = "0xADD4")]
		public ShopScope()
		{
		}

		// Token: 0x0400347F RID: 13439
		[Token(Token = "0x400347F")]
		[FieldOffset(Offset = "0x8")]
		public Action<ShopScope.ShopEventArgs> BuyShopArtifactEvent;

		// Token: 0x02001028 RID: 4136
		[Token(Token = "0x2001028")]
		public class ShopEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001376 RID: 4982
			// (get) Token: 0x060061AA RID: 25002 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001376")]
			public ArtifactData ShopArtifact
			{
				[Token(Token = "0x60061AA")]
				[Address(RVA = "0xADD5", Offset = "0xADD5", VA = "0xADD5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060061AB RID: 25003 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061AB")]
			[Address(RVA = "0xADD6", Offset = "0xADD6", VA = "0xADD6")]
			public ShopEventArgs(App app, IGame game, ArtifactData shopArtifact)
			{
			}
		}
	}
}
