using System;
using System.Runtime.CompilerServices;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DDB RID: 3547
	[Token(Token = "0x2000DDB")]
	public class AccountOptionData : BankOptionData
	{
		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06005692 RID: 22162 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005693 RID: 22163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011AA")]
		public AccountOptionsDic AccountOptionsDic
		{
			[Token(Token = "0x6005692")]
			[Address(RVA = "0xA41A", Offset = "0xA41A", VA = "0xA41A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005693")]
			[Address(RVA = "0xA41B", Offset = "0xA41B", VA = "0xA41B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06005694 RID: 22164 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005695 RID: 22165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011AB")]
		public AccountOptionData ParentAccountOption
		{
			[Token(Token = "0x6005694")]
			[Address(RVA = "0xA41C", Offset = "0xA41C", VA = "0xA41C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005695")]
			[Address(RVA = "0xA41D", Offset = "0xA41D", VA = "0xA41D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005696 RID: 22166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005696")]
		[Address(RVA = "0xA41E", Offset = "0xA41E", VA = "0xA41E")]
		public AccountOptionData(AccountOptionsDic optionsDic)
		{
		}
	}
}
