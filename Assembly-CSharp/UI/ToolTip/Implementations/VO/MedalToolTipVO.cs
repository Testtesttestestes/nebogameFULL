using System;
using Core.Dict.DictWrappers.Wrappers;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using Protocol.Dic;
using Utils;

namespace UI.ToolTip.Implementations.VO
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	public class MedalToolTipVO
	{
		// Token: 0x060009FA RID: 2554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x5D5A", Offset = "0x5D5A", VA = "0x5D5A")]
		public MedalToolTipVO()
		{
		}

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x8")]
		public MedalDicWrapper MedalDic;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0xC")]
		public MedalRanks MedalRankDic;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x10")]
		public RequirementsInfoProvider RequirementsInfoProvider;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x14")]
		public BackTime Lifetime;
	}
}
