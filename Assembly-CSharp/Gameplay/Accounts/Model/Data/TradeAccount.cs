using System;
using Core.Data;
using Core.Data.Accounts;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DE2 RID: 3554
	[Token(Token = "0x2000DE2")]
	public class TradeAccount : UserAccount
	{
		// Token: 0x060056BF RID: 22207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056BF")]
		[Address(RVA = "0xA43E", Offset = "0xA43E", VA = "0xA43E", Slot = "19")]
		public override void Init(uint id, Dictionaries dicts, IAccountRepository accountRepository)
		{
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056C0")]
		[Address(RVA = "0xA43F", Offset = "0xA43F", VA = "0xA43F")]
		public ResourceSet GetBalanceLimit(Resources resourceId, UserData user)
		{
			return null;
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056C1")]
		[Address(RVA = "0xA440", Offset = "0xA440", VA = "0xA440")]
		public TradeAccount()
		{
		}

		// Token: 0x04002EFC RID: 12028
		[Token(Token = "0x4002EFC")]
		[FieldOffset(Offset = "0x1C")]
		private Dictionaries _dictionaries;
	}
}
