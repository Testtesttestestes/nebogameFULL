using System;
using Core.Data;
using Core.Data.Skills;
using Il2CppDummyDll;
using Protocol.Dic;

namespace UI.ToolTip.Implementations.VO
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	public class SkillToolTipInUserInfoVO
	{
		// Token: 0x060009FB RID: 2555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x5D5B", Offset = "0x5D5B", VA = "0x5D5B")]
		public SkillToolTipInUserInfoVO()
		{
		}

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x8")]
		public UserSkillDic SkillDic;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0xC")]
		public UserData User;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x10")]
		public SkillData SkillData;
	}
}
