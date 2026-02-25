using System;
using System.Runtime.CompilerServices;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.ClanWars;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Il2CppDummyDll;
using Protocol.ClanWar;
using Protocol.Common;
using Protocol.Dic;
using UI.Windows;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001148 RID: 4424
	[Token(Token = "0x2001148")]
	public class ClanWarsManager : IGameManager, IBaseManager, IClanWars
	{
		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x0600681B RID: 26651 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001555")]
		public string Name
		{
			[Token(Token = "0x600681B")]
			[Address(RVA = "0xB347", Offset = "0xB347", VA = "0xB347", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400026C RID: 620
		// (add) Token: 0x0600681C RID: 26652 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600681D RID: 26653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400026C")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600681C")]
			[Address(RVA = "0xB348", Offset = "0xB348", VA = "0xB348", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600681D")]
			[Address(RVA = "0xB349", Offset = "0xB349", VA = "0xB349", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400026D RID: 621
		// (add) Token: 0x0600681E RID: 26654 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600681F RID: 26655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400026D")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600681E")]
			[Address(RVA = "0xB34A", Offset = "0xB34A", VA = "0xB34A", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600681F")]
			[Address(RVA = "0xB34B", Offset = "0xB34B", VA = "0xB34B", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06006820 RID: 26656 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006821 RID: 26657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001556")]
		public ClanWarsModel Model
		{
			[Token(Token = "0x6006820")]
			[Address(RVA = "0xB34C", Offset = "0xB34C", VA = "0xB34C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006821")]
			[Address(RVA = "0xB34D", Offset = "0xB34D", VA = "0xB34D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06006822 RID: 26658 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006823 RID: 26659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001557")]
		public ClanWarsEvents Events
		{
			[Token(Token = "0x6006822")]
			[Address(RVA = "0xB34E", Offset = "0xB34E", VA = "0xB34E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006823")]
			[Address(RVA = "0xB34F", Offset = "0xB34F", VA = "0xB34F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06006824 RID: 26660 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006825 RID: 26661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001558")]
		public ClanWarsController Controller
		{
			[Token(Token = "0x6006824")]
			[Address(RVA = "0xB350", Offset = "0xB350", VA = "0xB350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006825")]
			[Address(RVA = "0xB351", Offset = "0xB351", VA = "0xB351")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06006826 RID: 26662 RVA: 0x00013890 File Offset: 0x00011A90
		[Token(Token = "0x17001559")]
		public bool WarsDisabled
		{
			[Token(Token = "0x6006826")]
			[Address(RVA = "0xB352", Offset = "0xB352", VA = "0xB352")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06006827 RID: 26663 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700155A")]
		public SeasonLeagueDic CurrentSeasonLeagueDic
		{
			[Token(Token = "0x6006827")]
			[Address(RVA = "0xB353", Offset = "0xB353", VA = "0xB353")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006828")]
		[Address(RVA = "0xB354", Offset = "0xB354", VA = "0xB354", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006829 RID: 26665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006829")]
		[Address(RVA = "0xB355", Offset = "0xB355", VA = "0xB355", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x0600682A RID: 26666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600682A")]
		[Address(RVA = "0xB356", Offset = "0xB356", VA = "0xB356")]
		private void HandleControllerInitEvent()
		{
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600682B")]
		[Address(RVA = "0xB357", Offset = "0xB357", VA = "0xB357")]
		public ResourceSet GetPayOffCost()
		{
			return null;
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600682C")]
		[Address(RVA = "0xB358", Offset = "0xB358", VA = "0xB358")]
		public ResourceSet GetGolemRestorePriceByLevel(uint level, float leftTimer)
		{
			return null;
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600682D")]
		[Address(RVA = "0xB359", Offset = "0xB359", VA = "0xB359")]
		public void OpenWarStatusWindow(GolemModel golemModel)
		{
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600682E")]
		[Address(RVA = "0xB35A", Offset = "0xB35A", VA = "0xB35A")]
		public DialogWindow ShowDeclareWarDialogWindow(ulong clanId, ResourceSet cost, int ratingPoints, string clanName)
		{
			return null;
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600682F")]
		[Address(RVA = "0xB35B", Offset = "0xB35B", VA = "0xB35B")]
		public DialogWindow ShowDeclareWarDialogWindow(ProtoGetWarsHistoryAns.Types.WarHistoryRecord record)
		{
			return null;
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x000138A8 File Offset: 0x00011AA8
		[Token(Token = "0x6006830")]
		[Address(RVA = "0xB35C", Offset = "0xB35C", VA = "0xB35C", Slot = "11")]
		public bool TryGetActiveWar(out ProtoGetActiveWarInfoAns.Types.ActiveWarInfo activeWar)
		{
			return default(bool);
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006831")]
		[Address(RVA = "0xB35D", Offset = "0xB35D", VA = "0xB35D", Slot = "12")]
		public void RequestUpdateActiveWar()
		{
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006832")]
		[Address(RVA = "0xB35E", Offset = "0xB35E", VA = "0xB35E")]
		public ClanWarsManager()
		{
		}
	}
}
