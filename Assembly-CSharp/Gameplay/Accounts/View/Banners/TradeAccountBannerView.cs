using System;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;

namespace Gameplay.Accounts.View.Banners
{
	// Token: 0x02000DD4 RID: 3540
	[Token(Token = "0x2000DD4")]
	public class TradeAccountBannerView : AbstractAccountBannerView<TradeAccount>
	{
		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x0600564D RID: 22093 RVA: 0x0000F840 File Offset: 0x0000DA40
		[Token(Token = "0x1700118C")]
		public override uint AccountId
		{
			[Token(Token = "0x600564D")]
			[Address(RVA = "0xA3DB", Offset = "0xA3DB", VA = "0xA3DB", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600564E")]
		[Address(RVA = "0xA3DC", Offset = "0xA3DC", VA = "0xA3DC", Slot = "12")]
		protected override string FormatBacktimeCallback(float value)
		{
			return null;
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600564F")]
		[Address(RVA = "0xA3DD", Offset = "0xA3DD", VA = "0xA3DD")]
		public TradeAccountBannerView()
		{
		}
	}
}
