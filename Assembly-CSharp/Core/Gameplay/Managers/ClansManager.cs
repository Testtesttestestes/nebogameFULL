using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Data;
using Core.Money;
using Gameplay.Clans.Controller;
using Gameplay.Clans.Events;
using Gameplay.Clans.Model;
using Gameplay.Clans.Office.View;
using Gameplay.World.Controller;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Windows;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200114A RID: 4426
	[Token(Token = "0x200114A")]
	public class ClansManager : IGameManager, IBaseManager
	{
		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06006835 RID: 26677 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700155B")]
		public string Name
		{
			[Token(Token = "0x6006835")]
			[Address(RVA = "0xB361", Offset = "0xB361", VA = "0xB361", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400026E RID: 622
		// (add) Token: 0x06006836 RID: 26678 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006837 RID: 26679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400026E")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006836")]
			[Address(RVA = "0xB362", Offset = "0xB362", VA = "0xB362", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006837")]
			[Address(RVA = "0xB363", Offset = "0xB363", VA = "0xB363", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400026F RID: 623
		// (add) Token: 0x06006838 RID: 26680 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006839 RID: 26681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400026F")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006838")]
			[Address(RVA = "0xB364", Offset = "0xB364", VA = "0xB364", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006839")]
			[Address(RVA = "0xB365", Offset = "0xB365", VA = "0xB365", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x0600683A RID: 26682 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600683B RID: 26683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700155C")]
		public ClansModel Model
		{
			[Token(Token = "0x600683A")]
			[Address(RVA = "0xB366", Offset = "0xB366", VA = "0xB366")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600683B")]
			[Address(RVA = "0xB367", Offset = "0xB367", VA = "0xB367")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x0600683C RID: 26684 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600683D RID: 26685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700155D")]
		public ClansEvents Events
		{
			[Token(Token = "0x600683C")]
			[Address(RVA = "0xB368", Offset = "0xB368", VA = "0xB368")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600683D")]
			[Address(RVA = "0xB369", Offset = "0xB369", VA = "0xB369")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x0600683E RID: 26686 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600683F RID: 26687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700155E")]
		public ClansController Controller
		{
			[Token(Token = "0x600683E")]
			[Address(RVA = "0xB36A", Offset = "0xB36A", VA = "0xB36A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600683F")]
			[Address(RVA = "0xB36B", Offset = "0xB36B", VA = "0xB36B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06006840 RID: 26688 RVA: 0x000138C0 File Offset: 0x00011AC0
		[Token(Token = "0x1700155F")]
		public uint LeagueId
		{
			[Token(Token = "0x6006840")]
			[Address(RVA = "0xB36C", Offset = "0xB36C", VA = "0xB36C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06006841 RID: 26689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006841")]
		[Address(RVA = "0xB36D", Offset = "0xB36D", VA = "0xB36D", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006842 RID: 26690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006842")]
		[Address(RVA = "0xB36E", Offset = "0xB36E", VA = "0xB36E", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006843 RID: 26691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006843")]
		[Address(RVA = "0xB36F", Offset = "0xB36F", VA = "0xB36F")]
		private void HandleControllerInitEvent()
		{
		}

		// Token: 0x06006844 RID: 26692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006844")]
		[Address(RVA = "0xB370", Offset = "0xB370", VA = "0xB370")]
		public void ShowClanOfficeWindow()
		{
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006845")]
		[Address(RVA = "0xB371", Offset = "0xB371", VA = "0xB371")]
		public void AssignClanToUser()
		{
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006846")]
		[Address(RVA = "0xB372", Offset = "0xB372", VA = "0xB372")]
		public void DissociateClanFromUser()
		{
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006847")]
		[Address(RVA = "0xB373", Offset = "0xB373", VA = "0xB373")]
		public void ShowClanInfoWindow(ulong clanId, ClanInfoWindow.Tab tabToOpen = ClanInfoWindow.Tab.INFO)
		{
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006848")]
		[Address(RVA = "0xB374", Offset = "0xB374", VA = "0xB374")]
		public string GetClanCultAssetId(uint clanCultId, uint clanFlags)
		{
			return null;
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006849")]
		[Address(RVA = "0xB375", Offset = "0xB375", VA = "0xB375")]
		public List<CultDic> GetCultsByClan(uint clanCultId)
		{
			return null;
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600684A")]
		[Address(RVA = "0xB376", Offset = "0xB376", VA = "0xB376")]
		public ClanCultDic GetFractionByCult(CultDic cultDic)
		{
			return null;
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600684B")]
		[Address(RVA = "0xB377", Offset = "0xB377", VA = "0xB377")]
		public void OpenClanTreasury([Optional] Money deficientResources)
		{
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600684C")]
		[Address(RVA = "0xB378", Offset = "0xB378", VA = "0xB378")]
		public void ShowClanInfoPopupWindow(ClanData data)
		{
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600684D")]
		[Address(RVA = "0xB379", Offset = "0xB379", VA = "0xB379")]
		public DialogWindow ShowKickMemberConfirmationWindow(UserData user)
		{
			return null;
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600684E")]
		[Address(RVA = "0xB37A", Offset = "0xB37A", VA = "0xB37A")]
		public ClansManager()
		{
		}

		// Token: 0x04003786 RID: 14214
		[Token(Token = "0x4003786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private IWorldMovementProvider _worldMovement;
	}
}
