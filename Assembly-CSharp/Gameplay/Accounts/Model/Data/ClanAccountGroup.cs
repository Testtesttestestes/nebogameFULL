using System;
using System.Collections.Generic;
using Core.Data.Accounts;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DDE RID: 3550
	[Token(Token = "0x2000DDE")]
	public class ClanAccountGroup : ClanAccount
	{
		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x060056AE RID: 22190 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011B0")]
		public override IAccountData Account
		{
			[Token(Token = "0x60056AE")]
			[Address(RVA = "0xA436", Offset = "0xA436", VA = "0xA436", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x0000F918 File Offset: 0x0000DB18
		[Token(Token = "0x60056AF")]
		[Address(RVA = "0xA437", Offset = "0xA437", VA = "0xA437", Slot = "20")]
		public override bool TryGetNested(out List<IAccountDataDecorator> accounts)
		{
			return default(bool);
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B0")]
		[Address(RVA = "0xA438", Offset = "0xA438", VA = "0xA438", Slot = "19")]
		public override void Init(uint id, Dictionaries dicts, IAccountRepository accountRepository)
		{
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B1")]
		[Address(RVA = "0xA439", Offset = "0xA439", VA = "0xA439")]
		public ClanAccountGroup()
		{
		}

		// Token: 0x04002EF9 RID: 12025
		[Token(Token = "0x4002EF9")]
		[FieldOffset(Offset = "0x1C")]
		private List<IAccountDataDecorator> _nested;
	}
}
