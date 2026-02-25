using System;
using System.Threading;
using Gameplay.Accounts.Model;
using Gameplay.Accounts.Model.Data;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.Accounts.Control
{
	// Token: 0x02000DE5 RID: 3557
	[Token(Token = "0x2000DE5")]
	public class AccountsController : AbstractController<AccountsModel, AccountsEvents>
	{
		// Token: 0x060056D5 RID: 22229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D5")]
		[Address(RVA = "0xA454", Offset = "0xA454", VA = "0xA454", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D6")]
		[Address(RVA = "0xA455", Offset = "0xA455", VA = "0xA455")]
		public AccountsController(ServicesService servicesService, AccountsModel model, AccountsEvents events)
		{
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D7")]
		[Address(RVA = "0xA456", Offset = "0xA456", VA = "0xA456", Slot = "7")]
		protected override void HandleRun()
		{
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D8")]
		[Address(RVA = "0xA457", Offset = "0xA457", VA = "0xA457", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D9")]
		[Address(RVA = "0xA458", Offset = "0xA458", VA = "0xA458")]
		private void HandleDictsChangedEvent()
		{
		}

		// Token: 0x060056DA RID: 22234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DA")]
		[Address(RVA = "0xA459", Offset = "0xA459", VA = "0xA459")]
		private void HandleAccountChangedEventService(AccountInfo info)
		{
		}

		// Token: 0x060056DB RID: 22235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DB")]
		[Address(RVA = "0x1D4C", Offset = "0x1D4C", VA = "0x1D4C")]
		private void TryDetectAccountsOptionsDiff()
		{
		}

		// Token: 0x060056DC RID: 22236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DC")]
		[Address(RVA = "0xA45A", Offset = "0xA45A", VA = "0xA45A")]
		private void HandleGetAccountOptionService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060056DD RID: 22237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DD")]
		[Address(RVA = "0xA45B", Offset = "0xA45B", VA = "0xA45B")]
		private void HandleGetActivePromotionsService(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060056DE RID: 22238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DE")]
		[Address(RVA = "0xA45C", Offset = "0xA45C", VA = "0xA45C")]
		public void SetNotificationsCount(int value)
		{
		}

		// Token: 0x060056DF RID: 22239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DF")]
		[Address(RVA = "0xA45D", Offset = "0xA45D", VA = "0xA45D")]
		public void UpdatePromotion()
		{
		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056E0")]
		[Address(RVA = "0xA45E", Offset = "0xA45E", VA = "0xA45E")]
		public OpToken<IMessage, object> RequestAvailOptions()
		{
			return null;
		}

		// Token: 0x060056E1 RID: 22241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056E1")]
		[Address(RVA = "0xA45F", Offset = "0xA45F", VA = "0xA45F")]
		public void SetCurrentBrowsedAccount(IAccountDataDecorator account)
		{
		}

		// Token: 0x060056E2 RID: 22242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056E2")]
		[Address(RVA = "0xA460", Offset = "0xA460", VA = "0xA460")]
		public void BuyAccount(AccountOptionData option)
		{
		}

		// Token: 0x060056E3 RID: 22243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056E3")]
		[Address(RVA = "0xA461", Offset = "0xA461", VA = "0xA461")]
		public void StartBuyAccount(IAccountDataDecorator account, AccountOptionData option)
		{
		}

		// Token: 0x04002F00 RID: 12032
		[Token(Token = "0x4002F00")]
		[FieldOffset(Offset = "0x18")]
		private ServicesService _service;

		// Token: 0x04002F01 RID: 12033
		[Token(Token = "0x4002F01")]
		[FieldOffset(Offset = "0x1C")]
		private readonly CancellationTokenSource _operationsCancelation;
	}
}
