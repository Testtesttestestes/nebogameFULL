using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Data.Accounts
{
	// Token: 0x020010F1 RID: 4337
	[Token(Token = "0x20010F1")]
	public class AccountsStorage : IAccountRepository
	{
		// Token: 0x14000244 RID: 580
		// (add) Token: 0x0600655B RID: 25947 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600655C RID: 25948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000244")]
		public event Action AccountsChangedEvent
		{
			[Token(Token = "0x600655B")]
			[Address(RVA = "0xB124", Offset = "0xB124", VA = "0xB124")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600655C")]
			[Address(RVA = "0xB125", Offset = "0xB125", VA = "0xB125")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600655D RID: 25949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600655D")]
		[Address(RVA = "0xB126", Offset = "0xB126", VA = "0xB126")]
		public AccountsStorage(int capacity)
		{
		}

		// Token: 0x0600655E RID: 25950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600655E")]
		[Address(RVA = "0xB127", Offset = "0xB127", VA = "0xB127")]
		public void Reset()
		{
		}

		// Token: 0x0600655F RID: 25951 RVA: 0x000134E8 File Offset: 0x000116E8
		[Token(Token = "0x600655F")]
		[Address(RVA = "0x1D52", Offset = "0x1D52", VA = "0x1D52", Slot = "4")]
		public bool TryGetAccount(uint id, out IAccountData account)
		{
			return default(bool);
		}

		// Token: 0x06006560 RID: 25952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006560")]
		[Address(RVA = "0xB128", Offset = "0xB128", VA = "0xB128")]
		public void SetAccounts(params AccountInfo[] accounts)
		{
		}

		// Token: 0x0400362F RID: 13871
		[Token(Token = "0x400362F")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<IAccountData> _accounts;
	}
}
