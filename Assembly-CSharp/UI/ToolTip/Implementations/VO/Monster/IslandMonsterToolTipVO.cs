using System;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;

namespace UI.ToolTip.Implementations.VO.Monster
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	public class IslandMonsterToolTipVO : AbstractMonsterToolTipVO
	{
		// Token: 0x06000A06 RID: 2566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x5D62", Offset = "0x5D62", VA = "0x5D62")]
		public IslandMonsterToolTipVO(IDictProvider dictProvider, UserData loggedUser, MonsterData monster)
		{
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x5D63", Offset = "0x5D63", VA = "0x5D63", Slot = "4")]
		public override uint GetLevel()
		{
			return 0U;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x5D64", Offset = "0x5D64", VA = "0x5D64", Slot = "5")]
		public override string GetTitle()
		{
			return null;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x5D65", Offset = "0x5D65", VA = "0x5D65", Slot = "6")]
		public override string GetDescription()
		{
			return null;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x5D66", Offset = "0x5D66", VA = "0x5D66", Slot = "7")]
		public override string GetDifficultyLocaleKey()
		{
			return null;
		}
	}
}
