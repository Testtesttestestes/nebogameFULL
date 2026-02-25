using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.User.Events
{
	// Token: 0x02000421 RID: 1057
	[Token(Token = "0x2000421")]
	public class UserEvents : AbstractMVCEvents
	{
		// Token: 0x06001900 RID: 6400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001900")]
		[Address(RVA = "0x6A9F", Offset = "0x6A9F", VA = "0x6A9F")]
		public UserEvents()
		{
		}

		// Token: 0x04000D39 RID: 3385
		[Token(Token = "0x4000D39")]
		[FieldOffset(Offset = "0x14")]
		public Action UserInfoUpdateCompleteEvent;

		// Token: 0x04000D3A RID: 3386
		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x18")]
		public Action BuyTreeLicenceSuccessEvent;

		// Token: 0x04000D3B RID: 3387
		[Token(Token = "0x4000D3B")]
		[FieldOffset(Offset = "0x1C")]
		public Action EnergyRegenStatusChangedEvent;
	}
}
