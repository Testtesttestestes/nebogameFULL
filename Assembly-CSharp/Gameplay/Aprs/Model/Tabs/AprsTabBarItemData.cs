using System;
using Il2CppDummyDll;

namespace Gameplay.Aprs.Model.Tabs
{
	// Token: 0x02000D67 RID: 3431
	[Token(Token = "0x2000D67")]
	public class AprsTabBarItemData
	{
		// Token: 0x0600542B RID: 21547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600542B")]
		[Address(RVA = "0xA1E2", Offset = "0xA1E2", VA = "0xA1E2")]
		public AprsTabBarItemData()
		{
		}

		// Token: 0x04002D94 RID: 11668
		[Token(Token = "0x4002D94")]
		[FieldOffset(Offset = "0x8")]
		public AprsTabBarItemData.AprsTabType Type;

		// Token: 0x02000D68 RID: 3432
		[Token(Token = "0x2000D68")]
		public enum AprsTabType
		{
			// Token: 0x04002D96 RID: 11670
			[Token(Token = "0x4002D96")]
			All = 1,
			// Token: 0x04002D97 RID: 11671
			[Token(Token = "0x4002D97")]
			Category
		}
	}
}
