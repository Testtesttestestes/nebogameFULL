using System;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace Core.Data.Accounts
{
	// Token: 0x020010F0 RID: 4336
	[Token(Token = "0x20010F0")]
	public class AccountData : IAccountData
	{
		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x06006556 RID: 25942 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006557 RID: 25943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700148C")]
		public AccountInfo AccountInfo
		{
			[Token(Token = "0x6006556")]
			[Address(RVA = "0xB11F", Offset = "0xB11F", VA = "0xB11F", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006557")]
			[Address(RVA = "0xB120", Offset = "0xB120", VA = "0xB120")]
			set
			{
			}
		}

		// Token: 0x1700148D RID: 5261
		// (get) Token: 0x06006558 RID: 25944 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700148D")]
		public BackTime BackTime
		{
			[Token(Token = "0x6006558")]
			[Address(RVA = "0xB121", Offset = "0xB121", VA = "0xB121", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700148E RID: 5262
		// (get) Token: 0x06006559 RID: 25945 RVA: 0x000134D0 File Offset: 0x000116D0
		[Token(Token = "0x1700148E")]
		public bool IsExpired
		{
			[Token(Token = "0x6006559")]
			[Address(RVA = "0xB122", Offset = "0xB122", VA = "0xB122", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600655A RID: 25946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600655A")]
		[Address(RVA = "0xB123", Offset = "0xB123", VA = "0xB123")]
		public AccountData(AccountInfo accountInfo)
		{
		}

		// Token: 0x0400362C RID: 13868
		[Token(Token = "0x400362C")]
		[FieldOffset(Offset = "0x8")]
		private AccountInfo _accountInfo;

		// Token: 0x0400362D RID: 13869
		[Token(Token = "0x400362D")]
		[FieldOffset(Offset = "0xC")]
		private BackTime _backtime;
	}
}
