using System;
using Il2CppDummyDll;

namespace Gameplay.Medals.Model
{
	// Token: 0x02000602 RID: 1538
	[Token(Token = "0x2000602")]
	public class MedalTabBarItemData
	{
		// Token: 0x0600255A RID: 9562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600255A")]
		[Address(RVA = "0x76A1", Offset = "0x76A1", VA = "0x76A1")]
		public MedalTabBarItemData()
		{
		}

		// Token: 0x04001472 RID: 5234
		[Token(Token = "0x4001472")]
		[FieldOffset(Offset = "0x8")]
		public MedalTabBarItemData.MedalTabType Type;

		// Token: 0x02000603 RID: 1539
		[Token(Token = "0x2000603")]
		public enum MedalTabType
		{
			// Token: 0x04001474 RID: 5236
			[Token(Token = "0x4001474")]
			All = 1,
			// Token: 0x04001475 RID: 5237
			[Token(Token = "0x4001475")]
			Type
		}
	}
}
