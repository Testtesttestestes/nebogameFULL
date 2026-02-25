using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Data.Accounts
{
	// Token: 0x020010F4 RID: 4340
	[Token(Token = "0x20010F4")]
	public class UserAccount : AccountDataDecorator
	{
		// Token: 0x17001492 RID: 5266
		// (get) Token: 0x06006565 RID: 25957 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006566 RID: 25958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001492")]
		public List<UserAccountLevelsDic> UserLevelAccountDics
		{
			[Token(Token = "0x6006565")]
			[Address(RVA = "0xB129", Offset = "0xB129", VA = "0xB129")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006566")]
			[Address(RVA = "0xB12A", Offset = "0xB12A", VA = "0xB12A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001493 RID: 5267
		// (get) Token: 0x06006567 RID: 25959 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001493")]
		public override string Title
		{
			[Token(Token = "0x6006567")]
			[Address(RVA = "0xB12B", Offset = "0xB12B", VA = "0xB12B", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006568")]
		[Address(RVA = "0xB12C", Offset = "0xB12C", VA = "0xB12C", Slot = "19")]
		public override void Init(uint id, Dictionaries dicts, IAccountRepository accountRepository)
		{
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006569")]
		[Address(RVA = "0xB12D", Offset = "0xB12D", VA = "0xB12D")]
		public UserAccount()
		{
		}
	}
}
