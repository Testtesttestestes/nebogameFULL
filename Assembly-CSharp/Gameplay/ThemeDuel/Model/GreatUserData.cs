using System;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Rating;

namespace Gameplay.ThemeDuel.Model
{
	// Token: 0x020004E6 RID: 1254
	[Token(Token = "0x20004E6")]
	public class GreatUserData
	{
		// Token: 0x06001DFB RID: 7675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFB")]
		[Address(RVA = "0x6F79", Offset = "0x6F79", VA = "0x6F79")]
		public GreatUserData()
		{
		}

		// Token: 0x04001052 RID: 4178
		[Token(Token = "0x4001052")]
		[FieldOffset(Offset = "0x8")]
		public GreatUserTopInfo UserTopInfo;

		// Token: 0x04001053 RID: 4179
		[Token(Token = "0x4001053")]
		[FieldOffset(Offset = "0xC")]
		public AprDic AprDic;

		// Token: 0x04001054 RID: 4180
		[Token(Token = "0x4001054")]
		[FieldOffset(Offset = "0x10")]
		public RewardData[] Rewards;

		// Token: 0x04001055 RID: 4181
		[Token(Token = "0x4001055")]
		[FieldOffset(Offset = "0x14")]
		public bool Voted;
	}
}
