using System;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Isles.Base
{
	// Token: 0x02000CF9 RID: 3321
	[Token(Token = "0x2000CF9")]
	public interface IIsle : IDisposable
	{
		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x060050EF RID: 20719
		[Token(Token = "0x1700105F")]
		ulong Id { [Token(Token = "0x60050EF")] get; }

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x060050F0 RID: 20720
		[Token(Token = "0x17001060")]
		bool IsCurrentIsle { [Token(Token = "0x60050F0")] get; }

		// Token: 0x060050F1 RID: 20721
		[Token(Token = "0x60050F1")]
		void SetIsCurrentIsle(bool isCurrent);

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x060050F2 RID: 20722
		[Token(Token = "0x17001061")]
		bool IsDisposed { [Token(Token = "0x60050F2")] get; }

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x060050F3 RID: 20723
		[Token(Token = "0x17001062")]
		LocationTypes LocationType { [Token(Token = "0x60050F3")] get; }
	}
}
