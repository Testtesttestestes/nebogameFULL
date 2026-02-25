using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers;
using Gameplay.Accounts.Model.Data;
using Gameplay.Clans.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Accounts.Model
{
	// Token: 0x02000DD9 RID: 3545
	[Token(Token = "0x2000DD9")]
	public class AccountsModel : AbstractModel
	{
		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06005669 RID: 22121 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600566A RID: 22122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001198")]
		public BankManager Bank
		{
			[Token(Token = "0x6005669")]
			[Address(RVA = "0xA3F6", Offset = "0xA3F6", VA = "0xA3F6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600566A")]
			[Address(RVA = "0xA3F7", Offset = "0xA3F7", VA = "0xA3F7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x0600566B RID: 22123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001199")]
		public List<IAccountDataDecorator> AvailAccounts
		{
			[Token(Token = "0x600566B")]
			[Address(RVA = "0xA3F8", Offset = "0xA3F8", VA = "0xA3F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x0600566C RID: 22124 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600566D RID: 22125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700119A")]
		public IAccountDataDecorator CurrentBrowsedAccount
		{
			[Token(Token = "0x600566C")]
			[Address(RVA = "0xA3F9", Offset = "0xA3F9", VA = "0xA3F9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600566D")]
			[Address(RVA = "0xA3FA", Offset = "0xA3FA", VA = "0xA3FA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x0600566E RID: 22126 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600566F RID: 22127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700119B")]
		public IDictProvider Dictionaries
		{
			[Token(Token = "0x600566E")]
			[Address(RVA = "0xA3FB", Offset = "0xA3FB", VA = "0xA3FB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600566F")]
			[Address(RVA = "0xA3FC", Offset = "0xA3FC", VA = "0xA3FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06005670 RID: 22128 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005671 RID: 22129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700119C")]
		public ClansModel ClansModel
		{
			[Token(Token = "0x6005670")]
			[Address(RVA = "0xA3FD", Offset = "0xA3FD", VA = "0xA3FD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005671")]
			[Address(RVA = "0xA3FE", Offset = "0xA3FE", VA = "0xA3FE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06005672 RID: 22130 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005673 RID: 22131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700119D")]
		public BattleAccount BattleAccount
		{
			[Token(Token = "0x6005672")]
			[Address(RVA = "0xA3FF", Offset = "0xA3FF", VA = "0xA3FF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005673")]
			[Address(RVA = "0xA400", Offset = "0xA400", VA = "0xA400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06005674 RID: 22132 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005675 RID: 22133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700119E")]
		public ManufactureAccount ManufactureAccount
		{
			[Token(Token = "0x6005674")]
			[Address(RVA = "0xA401", Offset = "0xA401", VA = "0xA401")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005675")]
			[Address(RVA = "0xA402", Offset = "0xA402", VA = "0xA402")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06005676 RID: 22134 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005677 RID: 22135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700119F")]
		public TradeAccount TradeAccount
		{
			[Token(Token = "0x6005676")]
			[Address(RVA = "0xA403", Offset = "0xA403", VA = "0xA403")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005677")]
			[Address(RVA = "0xA404", Offset = "0xA404", VA = "0xA404")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06005678 RID: 22136 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005679 RID: 22137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011A0")]
		public ClanAccountGroup ClanAccountGroup
		{
			[Token(Token = "0x6005678")]
			[Address(RVA = "0xA405", Offset = "0xA405", VA = "0xA405")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005679")]
			[Address(RVA = "0xA406", Offset = "0xA406", VA = "0xA406")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x0600567A RID: 22138 RVA: 0x0000F858 File Offset: 0x0000DA58
		// (set) Token: 0x0600567B RID: 22139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011A1")]
		public int NotificationsCount
		{
			[Token(Token = "0x600567A")]
			[Address(RVA = "0xA407", Offset = "0xA407", VA = "0xA407")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600567B")]
			[Address(RVA = "0xA408", Offset = "0xA408", VA = "0xA408")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600567C")]
		[Address(RVA = "0xA409", Offset = "0xA409", VA = "0xA409", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600567D RID: 22141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600567D")]
		[Address(RVA = "0xA40A", Offset = "0xA40A", VA = "0xA40A")]
		public AccountsModel(IList<AccountOptionsDic> accountOptionsDics, IDictProvider dictionaries, ClansModel clansModel, UserData user, BankManager bank)
		{
		}

		// Token: 0x0600567E RID: 22142 RVA: 0x0000F870 File Offset: 0x0000DA70
		[Token(Token = "0x600567E")]
		[Address(RVA = "0x1D34", Offset = "0x1D34", VA = "0x1D34")]
		private bool TryFillAccount(uint id, out IAccountDataDecorator result, params IAccountDataDecorator[] accounts)
		{
			return default(bool);
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600567F")]
		[Address(RVA = "0xA40B", Offset = "0xA40B", VA = "0xA40B")]
		public void SetActivePromotions(List<PromotionsDic> promotions)
		{
		}

		// Token: 0x06005680 RID: 22144 RVA: 0x0000F888 File Offset: 0x0000DA88
		[Token(Token = "0x6005680")]
		[Address(RVA = "0x1D3E", Offset = "0x1D3E", VA = "0x1D3E")]
		public bool TryGetAccount(uint id, out IAccountDataDecorator account)
		{
			return default(bool);
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005681")]
		public T GetAccount<T>(uint id) where T : IAccountDataDecorator, new()
		{
			return null;
		}

		// Token: 0x06005682 RID: 22146 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		[Token(Token = "0x6005682")]
		[Address(RVA = "0xA40C", Offset = "0xA40C", VA = "0xA40C")]
		public bool TryGetOption(uint optionId, out AccountOptionData result)
		{
			return default(bool);
		}

		// Token: 0x04002EE5 RID: 12005
		[Token(Token = "0x4002EE5")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<PromotionsDic> ActivePromotions;

		// Token: 0x04002EE6 RID: 12006
		[Token(Token = "0x4002EE6")]
		[FieldOffset(Offset = "0x14")]
		public readonly IList<AccountOptionsDic> AccountOptions;

		// Token: 0x04002EE7 RID: 12007
		[Token(Token = "0x4002EE7")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<IAccountDataDecorator> _accountsCache;
	}
}
