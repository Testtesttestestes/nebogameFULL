using System;
using System.Runtime.CompilerServices;
using Gameplay.Bank.Controller;
using Gameplay.Bank.Events;
using Gameplay.Bank.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;
using UI.Windows;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001142 RID: 4418
	[Token(Token = "0x2001142")]
	public class BankManager : IGameManager, IBaseManager
	{
		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x060067B3 RID: 26547 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700153B")]
		public string Name
		{
			[Token(Token = "0x60067B3")]
			[Address(RVA = "0xB2DF", Offset = "0xB2DF", VA = "0xB2DF", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000260 RID: 608
		// (add) Token: 0x060067B4 RID: 26548 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067B5 RID: 26549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000260")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60067B4")]
			[Address(RVA = "0xB2E0", Offset = "0xB2E0", VA = "0xB2E0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067B5")]
			[Address(RVA = "0xB2E1", Offset = "0xB2E1", VA = "0xB2E1", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000261 RID: 609
		// (add) Token: 0x060067B6 RID: 26550 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060067B7 RID: 26551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000261")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60067B6")]
			[Address(RVA = "0xB2E2", Offset = "0xB2E2", VA = "0xB2E2", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60067B7")]
			[Address(RVA = "0xB2E3", Offset = "0xB2E3", VA = "0xB2E3", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x060067B8 RID: 26552 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700153C")]
		public PaymentBonusController PaymentBonusController
		{
			[Token(Token = "0x60067B8")]
			[Address(RVA = "0xB2E4", Offset = "0xB2E4", VA = "0xB2E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x060067B9 RID: 26553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700153D")]
		public PaymentBonusEvents PaymentBonusEvents
		{
			[Token(Token = "0x60067B9")]
			[Address(RVA = "0xB2E5", Offset = "0xB2E5", VA = "0xB2E5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x060067BA RID: 26554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700153E")]
		public PaymentBonusModel PaymentBonusModel
		{
			[Token(Token = "0x60067BA")]
			[Address(RVA = "0xB2E6", Offset = "0xB2E6", VA = "0xB2E6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x060067BB RID: 26555 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060067BC RID: 26556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700153F")]
		public IGame Game
		{
			[Token(Token = "0x60067BB")]
			[Address(RVA = "0xB2E7", Offset = "0xB2E7", VA = "0xB2E7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067BC")]
			[Address(RVA = "0xB2E8", Offset = "0xB2E8", VA = "0xB2E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060067BD RID: 26557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067BD")]
		[Address(RVA = "0xB2E9", Offset = "0xB2E9", VA = "0xB2E9")]
		public BankManager(IGame game)
		{
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x060067BE RID: 26558 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060067BF RID: 26559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001540")]
		public BankController BankController
		{
			[Token(Token = "0x60067BE")]
			[Address(RVA = "0xB2EA", Offset = "0xB2EA", VA = "0xB2EA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067BF")]
			[Address(RVA = "0xB2EB", Offset = "0xB2EB", VA = "0xB2EB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x060067C0 RID: 26560 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060067C1 RID: 26561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001541")]
		public BankEvents BankEvents
		{
			[Token(Token = "0x60067C0")]
			[Address(RVA = "0xB2EC", Offset = "0xB2EC", VA = "0xB2EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067C1")]
			[Address(RVA = "0xB2ED", Offset = "0xB2ED", VA = "0xB2ED")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x060067C2 RID: 26562 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060067C3 RID: 26563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001542")]
		public BankModel BankModel
		{
			[Token(Token = "0x60067C2")]
			[Address(RVA = "0xB2EE", Offset = "0xB2EE", VA = "0xB2EE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60067C3")]
			[Address(RVA = "0xB2EF", Offset = "0xB2EF", VA = "0xB2EF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060067C4 RID: 26564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C4")]
		[Address(RVA = "0xB2F0", Offset = "0xB2F0", VA = "0xB2F0", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x060067C5 RID: 26565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C5")]
		[Address(RVA = "0xB2F1", Offset = "0xB2F1", VA = "0xB2F1")]
		private void PaymentBonusInitEvent()
		{
		}

		// Token: 0x060067C6 RID: 26566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C6")]
		[Address(RVA = "0xB2F2", Offset = "0xB2F2", VA = "0xB2F2")]
		private void BankInitEvent()
		{
		}

		// Token: 0x060067C7 RID: 26567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C7")]
		[Address(RVA = "0xB2F3", Offset = "0xB2F3", VA = "0xB2F3")]
		private void SetupBankMvc()
		{
		}

		// Token: 0x060067C8 RID: 26568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C8")]
		[Address(RVA = "0xB2F4", Offset = "0xB2F4", VA = "0xB2F4")]
		private void DestroyBankMvc()
		{
		}

		// Token: 0x060067C9 RID: 26569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067C9")]
		[Address(RVA = "0xB2F5", Offset = "0xB2F5", VA = "0xB2F5")]
		private void SetupPaymentBonusMvc()
		{
		}

		// Token: 0x060067CA RID: 26570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CA")]
		[Address(RVA = "0xB2F6", Offset = "0xB2F6", VA = "0xB2F6")]
		private void DestroyPaymentBonusMvc()
		{
		}

		// Token: 0x060067CB RID: 26571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CB")]
		[Address(RVA = "0xB2F7", Offset = "0xB2F7", VA = "0xB2F7", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x060067CC RID: 26572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CC")]
		[Address(RVA = "0xB2F8", Offset = "0xB2F8", VA = "0xB2F8")]
		public void ShowBankWindow(OptionTypesDic.Types.OptionType optionType = OptionTypesDic.Types.OptionType.Diamond, WindowOpenReasonSource source = WindowOpenReasonSource.DefaultSource)
		{
		}

		// Token: 0x060067CD RID: 26573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CD")]
		[Address(RVA = "0xB2F9", Offset = "0xB2F9", VA = "0xB2F9")]
		public void ShowBankWindow(Resources resourceId, WindowOpenReasonSource source = WindowOpenReasonSource.DefaultSource)
		{
		}

		// Token: 0x060067CE RID: 26574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CE")]
		[Address(RVA = "0xB2FA", Offset = "0xB2FA", VA = "0xB2FA")]
		public void ShowBankOptionInfoWindow(BankOptionViewArgs bankOptionDataWrapper)
		{
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067CF")]
		[Address(RVA = "0xB2FB", Offset = "0xB2FB", VA = "0xB2FB")]
		public void SetView(UserInterfaceView view)
		{
		}

		// Token: 0x04003753 RID: 14163
		[Token(Token = "0x4003753")]
		[FieldOffset(Offset = "0x10")]
		private BankEntryPointViewMediator _entryPointViewMediator;

		// Token: 0x04003754 RID: 14164
		[Token(Token = "0x4003754")]
		[FieldOffset(Offset = "0x14")]
		private PaymentBonusController _paymentBonusController;

		// Token: 0x04003755 RID: 14165
		[Token(Token = "0x4003755")]
		[FieldOffset(Offset = "0x18")]
		private PaymentBonusEvents _paymentBonusEvents;

		// Token: 0x04003756 RID: 14166
		[Token(Token = "0x4003756")]
		[FieldOffset(Offset = "0x1C")]
		private PaymentBonusModel _paymentBonusModel;
	}
}
