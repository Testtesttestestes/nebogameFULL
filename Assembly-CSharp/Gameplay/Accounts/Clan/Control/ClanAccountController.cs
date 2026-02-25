using System;
using Gameplay.Accounts.Clan.Model;
using Gameplay.Accounts.Control;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Accounts.Clan.Control
{
	// Token: 0x02000DF0 RID: 3568
	[Token(Token = "0x2000DF0")]
	public class ClanAccountController : AbstractController<ClanAccountModel, AccountsEvents>
	{
		// Token: 0x06005718 RID: 22296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005718")]
		[Address(RVA = "0xA494", Offset = "0xA494", VA = "0xA494", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06005719 RID: 22297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005719")]
		[Address(RVA = "0xA495", Offset = "0xA495", VA = "0xA495")]
		public ClanAccountController(AccountsController accountsController, ClanAccountModel model, AccountsEvents events)
		{
		}

		// Token: 0x0600571A RID: 22298 RVA: 0x0000F978 File Offset: 0x0000DB78
		[Token(Token = "0x600571A")]
		[Address(RVA = "0xA496", Offset = "0xA496", VA = "0xA496")]
		public bool TryBuyAccount(IAccountDataDecorator account, AccountOptionData accountOption, out BuyRejectedReason rejectReason)
		{
			return default(bool);
		}

		// Token: 0x04002F25 RID: 12069
		[Token(Token = "0x4002F25")]
		[FieldOffset(Offset = "0x18")]
		private AccountsController _accountsController;
	}
}
