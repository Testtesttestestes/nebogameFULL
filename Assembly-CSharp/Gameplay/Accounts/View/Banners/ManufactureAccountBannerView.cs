using System;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;

namespace Gameplay.Accounts.View.Banners
{
	// Token: 0x02000DD3 RID: 3539
	[Token(Token = "0x2000DD3")]
	public class ManufactureAccountBannerView : AbstractAccountBannerView<ManufactureAccount>
	{
		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x0600564A RID: 22090 RVA: 0x0000F828 File Offset: 0x0000DA28
		[Token(Token = "0x1700118B")]
		public override uint AccountId
		{
			[Token(Token = "0x600564A")]
			[Address(RVA = "0xA3D8", Offset = "0xA3D8", VA = "0xA3D8", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600564B")]
		[Address(RVA = "0xA3D9", Offset = "0xA3D9", VA = "0xA3D9", Slot = "12")]
		protected override string FormatBacktimeCallback(float value)
		{
			return null;
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600564C")]
		[Address(RVA = "0xA3DA", Offset = "0xA3DA", VA = "0xA3DA")]
		public ManufactureAccountBannerView()
		{
		}
	}
}
