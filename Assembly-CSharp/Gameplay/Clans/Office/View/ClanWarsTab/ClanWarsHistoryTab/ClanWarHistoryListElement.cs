using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.ClanWar;
using Protocol.Dic;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsHistoryTab
{
	// Token: 0x02000A19 RID: 2585
	[Token(Token = "0x2000A19")]
	public class ClanWarHistoryListElement : SelectableListElement<ClanWarHistoryListElement.ClanWarHistoryListElementArgs>
	{
		// Token: 0x06003D75 RID: 15733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D75")]
		[Address(RVA = "0x8C34", Offset = "0x8C34", VA = "0x8C34", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D76")]
		[Address(RVA = "0x8C35", Offset = "0x8C35", VA = "0x8C35", Slot = "10")]
		protected override void CallElementClickedEvent(ClanWarHistoryListElement.ClanWarHistoryListElementArgs args)
		{
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D77")]
		[Address(RVA = "0x8C36", Offset = "0x8C36", VA = "0x8C36")]
		public ClanWarHistoryListElement()
		{
		}

		// Token: 0x0400224C RID: 8780
		[Token(Token = "0x400224C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameImage _resultImage;

		// Token: 0x0400224D RID: 8781
		[Token(Token = "0x400224D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _resultTitle;

		// Token: 0x0400224E RID: 8782
		[Token(Token = "0x400224E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _myClanTitle;

		// Token: 0x0400224F RID: 8783
		[Token(Token = "0x400224F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _enemyClanTitle;

		// Token: 0x02000A1A RID: 2586
		[Token(Token = "0x2000A1A")]
		public class ClanWarHistoryListElementArgs : SelectableListElementArgs<ClanWarHistoryListElement>
		{
			// Token: 0x06003D78 RID: 15736 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D78")]
			[Address(RVA = "0x8C37", Offset = "0x8C37", VA = "0x8C37")]
			public ClanWarHistoryListElementArgs()
			{
			}

			// Token: 0x04002250 RID: 8784
			[Token(Token = "0x4002250")]
			[FieldOffset(Offset = "0x1C")]
			public string MyClanTitle;

			// Token: 0x04002251 RID: 8785
			[Token(Token = "0x4002251")]
			[FieldOffset(Offset = "0x20")]
			public ProtoGetWarsHistoryAns.Types.WarHistoryRecord WarRecord;

			// Token: 0x04002252 RID: 8786
			[Token(Token = "0x4002252")]
			[FieldOffset(Offset = "0x24")]
			public ClanWarResultDic ClanWarResultDic;
		}
	}
}
