using System;
using Core.Data;
using Core.Dict;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace UI.ToolTip.Implementations.VO.Monster
{
	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	public class IslandBossMonsterToolTipVO : AbstractMonsterToolTipVO
	{
		// Token: 0x06000A01 RID: 2561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x5D5D", Offset = "0x5D5D", VA = "0x5D5D")]
		public IslandBossMonsterToolTipVO(IDictProvider dictProvider, UserData loggedUser, MonsterData monster, BossInstance instance)
		{
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x5D5E", Offset = "0x5D5E", VA = "0x5D5E", Slot = "4")]
		public override uint GetLevel()
		{
			return 0U;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x5D5F", Offset = "0x5D5F", VA = "0x5D5F", Slot = "5")]
		public override string GetTitle()
		{
			return null;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x5D60", Offset = "0x5D60", VA = "0x5D60", Slot = "6")]
		public override string GetDescription()
		{
			return null;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x5D61", Offset = "0x5D61", VA = "0x5D61", Slot = "7")]
		public override string GetDifficultyLocaleKey()
		{
			return null;
		}

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x14")]
		public readonly BossInstance BossInstance;
	}
}
