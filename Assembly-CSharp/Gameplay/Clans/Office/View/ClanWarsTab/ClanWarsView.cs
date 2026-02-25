using System;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanPoliticsTab;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsHistoryTab;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsRewardsTab;
using Il2CppDummyDll;
using UI.Tabs;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanWarsTab
{
	// Token: 0x02000A16 RID: 2582
	[Token(Token = "0x2000A16")]
	public class ClanWarsView : MonoBehaviour
	{
		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x06003D65 RID: 15717 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C30")]
		public TabBar TabBar
		{
			[Token(Token = "0x6003D65")]
			[Address(RVA = "0x8C25", Offset = "0x8C25", VA = "0x8C25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06003D66 RID: 15718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C31")]
		public ClanWarsRewardsView ClanWarsRewardsTab
		{
			[Token(Token = "0x6003D66")]
			[Address(RVA = "0x8C26", Offset = "0x8C26", VA = "0x8C26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06003D67 RID: 15719 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C32")]
		public ClanPoliticsView ClanPoliticsTab
		{
			[Token(Token = "0x6003D67")]
			[Address(RVA = "0x8C27", Offset = "0x8C27", VA = "0x8C27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06003D68 RID: 15720 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C33")]
		public ClanWarsHistoryView HistoryTab
		{
			[Token(Token = "0x6003D68")]
			[Address(RVA = "0x8C28", Offset = "0x8C28", VA = "0x8C28")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D69")]
		[Address(RVA = "0x8C29", Offset = "0x8C29", VA = "0x8C29")]
		public ClanWarsView()
		{
		}

		// Token: 0x0400223B RID: 8763
		[Token(Token = "0x400223B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x0400223C RID: 8764
		[Token(Token = "0x400223C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ClanWarsRewardsView _clanWarsRewardsTab;

		// Token: 0x0400223D RID: 8765
		[Token(Token = "0x400223D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ClanPoliticsView _clanPoliticsTab;

		// Token: 0x0400223E RID: 8766
		[Token(Token = "0x400223E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClanWarsHistoryView _historyTab;
	}
}
