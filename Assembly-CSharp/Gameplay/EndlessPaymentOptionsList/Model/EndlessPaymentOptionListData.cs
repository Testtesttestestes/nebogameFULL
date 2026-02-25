using System;
using Il2CppDummyDll;
using Protocol.Dic;
using Utils;

namespace Gameplay.EndlessPaymentOptionsList.Model
{
	// Token: 0x02000846 RID: 2118
	[Token(Token = "0x2000846")]
	public class EndlessPaymentOptionListData
	{
		// Token: 0x060031CA RID: 12746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CA")]
		[Address(RVA = "0x8221", Offset = "0x8221", VA = "0x8221")]
		public EndlessPaymentOptionListData(EndlessPaymentOptionListDic dic, BackTime backTime)
		{
		}

		// Token: 0x04001B4E RID: 6990
		[Token(Token = "0x4001B4E")]
		[FieldOffset(Offset = "0x8")]
		public readonly EndlessPaymentOptionListDic ListDic;

		// Token: 0x04001B4F RID: 6991
		[Token(Token = "0x4001B4F")]
		[FieldOffset(Offset = "0xC")]
		public readonly BackTime BackTime;
	}
}
