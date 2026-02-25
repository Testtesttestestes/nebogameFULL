using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsHistoryTab
{
	// Token: 0x02000A1E RID: 2590
	[Token(Token = "0x2000A1E")]
	public class ClanWarsHistoryView : MonoBehaviourWithStates<ClanWarsHistoryView.HistoryState>
	{
		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06003D81 RID: 15745 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C37")]
		public ClanWarsHistoryInfoBox InfoBox
		{
			[Token(Token = "0x6003D81")]
			[Address(RVA = "0x8C40", Offset = "0x8C40", VA = "0x8C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06003D82 RID: 15746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C38")]
		public Button InfoButton
		{
			[Token(Token = "0x6003D82")]
			[Address(RVA = "0x8C41", Offset = "0x8C41", VA = "0x8C41")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06003D83 RID: 15747 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C39")]
		public Button MembersButton
		{
			[Token(Token = "0x6003D83")]
			[Address(RVA = "0x8C42", Offset = "0x8C42", VA = "0x8C42")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06003D84 RID: 15748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C3A")]
		public Button WarButton
		{
			[Token(Token = "0x6003D84")]
			[Address(RVA = "0x8C43", Offset = "0x8C43", VA = "0x8C43")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06003D85 RID: 15749 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003D86 RID: 15750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C3B")]
		public Action MoreItemsAfterNeededEvent
		{
			[Token(Token = "0x6003D85")]
			[Address(RVA = "0x8C44", Offset = "0x8C44", VA = "0x8C44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D86")]
			[Address(RVA = "0x8C45", Offset = "0x8C45", VA = "0x8C45")]
			set
			{
			}
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D87")]
		[Address(RVA = "0x8C46", Offset = "0x8C46", VA = "0x8C46")]
		public void Init(IList<ClanWarHistoryListElement.ClanWarHistoryListElementArgs> items)
		{
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D88")]
		[Address(RVA = "0x8C47", Offset = "0x8C47", VA = "0x8C47")]
		public void Add(IList<ClanWarHistoryListElement.ClanWarHistoryListElementArgs> items)
		{
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D89")]
		[Address(RVA = "0x8C48", Offset = "0x8C48", VA = "0x8C48")]
		public void Remove(int count, bool fromEnd)
		{
		}

		// Token: 0x06003D8A RID: 15754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D8A")]
		[Address(RVA = "0x8C49", Offset = "0x8C49", VA = "0x8C49")]
		public void ActivateUpperBound(bool activate)
		{
		}

		// Token: 0x06003D8B RID: 15755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D8B")]
		[Address(RVA = "0x8C4A", Offset = "0x8C4A", VA = "0x8C4A")]
		public ClanWarsHistoryView()
		{
		}

		// Token: 0x0400225B RID: 8795
		[Token(Token = "0x400225B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClanWarsHistoryOSAView _osaView;

		// Token: 0x0400225C RID: 8796
		[Token(Token = "0x400225C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClanWarsHistoryInfoBox _infoBox;

		// Token: 0x0400225D RID: 8797
		[Token(Token = "0x400225D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x0400225E RID: 8798
		[Token(Token = "0x400225E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _membersButton;

		// Token: 0x02000A1F RID: 2591
		[Token(Token = "0x2000A1F")]
		public enum HistoryState
		{
			// Token: 0x04002260 RID: 8800
			[Token(Token = "0x4002260")]
			UNKNOWN_STATE,
			// Token: 0x04002261 RID: 8801
			[Token(Token = "0x4002261")]
			COMMON,
			// Token: 0x04002262 RID: 8802
			[Token(Token = "0x4002262")]
			NO_HISTORY
		}
	}
}
