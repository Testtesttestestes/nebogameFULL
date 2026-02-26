using System;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;

namespace UI.ToolTip.Implementations.VO.Monster
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	public abstract class AbstractMonsterToolTipVO
	{
		// Token: 0x060009FC RID: 2556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x5D5C", Offset = "0x5D5C", VA = "0x5D5C")]
		protected AbstractMonsterToolTipVO(IDictProvider dictProvider, UserData loggedUser, MonsterData monster)
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_VO_Monster_AbstractMonsterToolTipVO___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  *(undefined4 *)(param1 + 0x14) = param5;
		  *(undefined4 *)(param1 + 0x10) = param2;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 8) = param4;
		  return;
		}
		*/

		}

		// Token: 0x060009FD RID: 2557
		[Token(Token = "0x60009FD")]
		public abstract uint GetLevel();

		// Token: 0x060009FE RID: 2558
		[Token(Token = "0x60009FE")]
		public abstract string GetTitle();

		// Token: 0x060009FF RID: 2559
		[Token(Token = "0x60009FF")]
		public abstract string GetDescription();

		// Token: 0x06000A00 RID: 2560
		[Token(Token = "0x6000A00")]
		public abstract string GetDifficultyLocaleKey();

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x8")]
		protected readonly MonsterData _monster;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0xC")]
		protected readonly UserData _loggedUser;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x10")]
		protected readonly IDictProvider _dictProvider;
	}
}
