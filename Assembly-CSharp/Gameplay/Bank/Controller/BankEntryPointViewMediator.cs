using System;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;
using UI;

namespace Gameplay.Bank.Controller
{
	// Token: 0x02000C62 RID: 3170
	[Token(Token = "0x2000C62")]
	public class BankEntryPointViewMediator : AbstractViewMediator<BankModel, BankEvents, BankController, UserInterfaceView>
	{
		// Token: 0x06004D72 RID: 19826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D72")]
		[Address(RVA = "0x9BAA", Offset = "0x9BAA", VA = "0x9BAA")]
		public BankEntryPointViewMediator(BankModel model, BankEvents events, BankController controller)
		{
		}

		// Token: 0x17000FAD RID: 4013
		// (set) Token: 0x06004D73 RID: 19827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAD")]
		public override UserInterfaceView View
		{
			[Token(Token = "0x6004D73")]
			[Address(RVA = "0x9BAB", Offset = "0x9BAB", VA = "0x9BAB", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (set) Token: 0x06004D74 RID: 19828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FAE")]
		public override BankEvents Events
		{
			[Token(Token = "0x6004D74")]
			[Address(RVA = "0x9BAC", Offset = "0x9BAC", VA = "0x9BAC", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D75")]
		[Address(RVA = "0x9BAD", Offset = "0x9BAD", VA = "0x9BAD")]
		private void ResetView()
		{
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D76")]
		[Address(RVA = "0x9BAE", Offset = "0x9BAE", VA = "0x9BAE")]
		private void SetupView()
		{
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D77")]
		[Address(RVA = "0x9BAF", Offset = "0x9BAF", VA = "0x9BAF")]
		private void HandleNotificationCountChangedEvent(int value)
		{
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D78")]
		[Address(RVA = "0x9BB0", Offset = "0x9BB0", VA = "0x9BB0")]
		private void BankButtonOnClickEvent(IndexButtonBasic btn)
		{
		}
	}
}
