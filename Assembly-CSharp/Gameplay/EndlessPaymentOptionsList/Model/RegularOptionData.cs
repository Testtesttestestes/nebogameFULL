using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.EndlessPaymentOptionsList.Model
{
	// Token: 0x0200084E RID: 2126
	[Token(Token = "0x200084E")]
	public class RegularOptionData : BankOptionData
	{
		// Token: 0x060031F5 RID: 12789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F5")]
		[Address(RVA = "0x824B", Offset = "0x824B", VA = "0x824B")]
		public RegularOptionData(RegularOptionsDic optionDic)
		{
		}

		// Token: 0x04001B66 RID: 7014
		[Token(Token = "0x4001B66")]
		[FieldOffset(Offset = "0x70")]
		public readonly RegularOptionsDic OptionDic;
	}
}
