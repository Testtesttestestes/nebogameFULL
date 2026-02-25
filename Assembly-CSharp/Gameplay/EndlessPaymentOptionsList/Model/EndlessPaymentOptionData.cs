using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.EndlessPaymentOptionsList.Model
{
	// Token: 0x02000845 RID: 2117
	[Token(Token = "0x2000845")]
	public class EndlessPaymentOptionData : BankOptionData
	{
		// Token: 0x060031C9 RID: 12745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C9")]
		[Address(RVA = "0x8220", Offset = "0x8220", VA = "0x8220")]
		public EndlessPaymentOptionData(EndlessPaymentOptionListOptionDic optionDic)
		{
		}

		// Token: 0x04001B4D RID: 6989
		[Token(Token = "0x4001B4D")]
		[FieldOffset(Offset = "0x70")]
		public readonly EndlessPaymentOptionListOptionDic OptionDic;
	}
}
