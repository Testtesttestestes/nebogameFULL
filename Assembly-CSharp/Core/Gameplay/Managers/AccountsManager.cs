using System;
using System.Runtime.CompilerServices;
using Gameplay.Accounts.Control;
using Gameplay.Accounts.Model;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200113A RID: 4410
	[Token(Token = "0x200113A")]
	public class AccountsManager : IGameManager, IBaseManager
	{
		// Token: 0x14000254 RID: 596
		// (add) Token: 0x06006752 RID: 26450 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006753 RID: 26451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000254")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006752")]
			[Address(RVA = "0xB27E", Offset = "0xB27E", VA = "0xB27E", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006753")]
			[Address(RVA = "0xB27F", Offset = "0xB27F", VA = "0xB27F", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000255 RID: 597
		// (add) Token: 0x06006754 RID: 26452 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006755 RID: 26453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000255")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006754")]
			[Address(RVA = "0xB280", Offset = "0xB280", VA = "0xB280", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006755")]
			[Address(RVA = "0xB281", Offset = "0xB281", VA = "0xB281", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06006756 RID: 26454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001528")]
		public string Name
		{
			[Token(Token = "0x6006756")]
			[Address(RVA = "0xB282", Offset = "0xB282", VA = "0xB282", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06006757 RID: 26455 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006758 RID: 26456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001529")]
		public IGame Game
		{
			[Token(Token = "0x6006757")]
			[Address(RVA = "0xB283", Offset = "0xB283", VA = "0xB283")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006758")]
			[Address(RVA = "0xB284", Offset = "0xB284", VA = "0xB284")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06006759 RID: 26457 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600675A RID: 26458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700152A")]
		public AccountsController Controller
		{
			[Token(Token = "0x6006759")]
			[Address(RVA = "0xB285", Offset = "0xB285", VA = "0xB285")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600675A")]
			[Address(RVA = "0xB286", Offset = "0xB286", VA = "0xB286")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600675B RID: 26459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600675B")]
		[Address(RVA = "0xB287", Offset = "0xB287", VA = "0xB287")]
		public AccountsManager(IGame game)
		{
		}

		// Token: 0x0600675C RID: 26460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600675C")]
		[Address(RVA = "0xB288", Offset = "0xB288", VA = "0xB288", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x0600675D RID: 26461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600675D")]
		[Address(RVA = "0xB289", Offset = "0xB289", VA = "0xB289", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x0600675E RID: 26462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600675E")]
		[Address(RVA = "0xB28A", Offset = "0xB28A", VA = "0xB28A")]
		public void ShowAccountsListWindow()
		{
		}

		// Token: 0x0600675F RID: 26463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600675F")]
		[Address(RVA = "0xB28B", Offset = "0xB28B", VA = "0xB28B")]
		public void ShowAccountWindow(IAccountDataDecorator account)
		{
		}

		// Token: 0x06006760 RID: 26464 RVA: 0x000137E8 File Offset: 0x000119E8
		[Token(Token = "0x6006760")]
		[Address(RVA = "0xB28C", Offset = "0xB28C", VA = "0xB28C")]
		public bool TryShowAccountWindow(uint accountId)
		{
			return default(bool);
		}

		// Token: 0x06006761 RID: 26465 RVA: 0x00013800 File Offset: 0x00011A00
		[Token(Token = "0x6006761")]
		[Address(RVA = "0xB28D", Offset = "0xB28D", VA = "0xB28D")]
		public bool TryShowClanAccountsWindow()
		{
			return default(bool);
		}

		// Token: 0x0400372F RID: 14127
		[Token(Token = "0x400372F")]
		[FieldOffset(Offset = "0x18")]
		private AccountsModel _model;
	}
}
