using System;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;

namespace Gameplay.Accounts.View.Banners
{
	// Token: 0x02000DD1 RID: 3537
	[Token(Token = "0x2000DD1")]
	public class BattleAccountBannerView : AbstractAccountBannerView<BattleAccount>
	{
		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06005646 RID: 22086 RVA: 0x0000F810 File Offset: 0x0000DA10
		[Token(Token = "0x1700118A")]
		public override uint AccountId
		{
			[Token(Token = "0x6005646")]
			[Address(RVA = "0xA3D4", Offset = "0xA3D4", VA = "0xA3D4", Slot = "6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005647")]
		[Address(RVA = "0xA3D5", Offset = "0xA3D5", VA = "0xA3D5")]
		public BattleAccountBannerView()
		{
		}
	}
}
