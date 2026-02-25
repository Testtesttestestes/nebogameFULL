using System;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Colossus;
using Protocol.Dic;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.History
{
	// Token: 0x0200030E RID: 782
	[Token(Token = "0x200030E")]
	public class BattleHistoryListElement : SelectableListElement<BattleHistoryListElement.BattleHistoryListElementArgs>
	{
		// Token: 0x0600122E RID: 4654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122E")]
		[Address(RVA = "0x6429", Offset = "0x6429", VA = "0x6429", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122F")]
		[Address(RVA = "0x642A", Offset = "0x642A", VA = "0x642A")]
		private void PrepareView(BattleHistoryListElement.BattleHistoryListElementArgs args)
		{
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001230")]
		[Address(RVA = "0x642B", Offset = "0x642B", VA = "0x642B", Slot = "10")]
		protected override void CallElementClickedEvent(BattleHistoryListElement.BattleHistoryListElementArgs args)
		{
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001231")]
		[Address(RVA = "0x642C", Offset = "0x642C", VA = "0x642C")]
		public BattleHistoryListElement()
		{
		}

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _colossusTitle;

		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameImage _leftClanIcon;

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameImage _rightClanIcon;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _leftClanTitle;

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _rightClanTitle;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _dateTime;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ValueIconTitleValue _rowPrefab;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Image _glowImage;

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite _neutralGlow;

		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Sprite _winGlow;

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Sprite _loseGlow;

		// Token: 0x040009A5 RID: 2469
		[Token(Token = "0x40009A5")]
		[FieldOffset(Offset = "0x54")]
		private ValueIconTitleValue[] _rows;

		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		[FieldOffset(Offset = "0x58")]
		private bool _viewPrepared;

		// Token: 0x0200030F RID: 783
		[Token(Token = "0x200030F")]
		public class BattleHistoryListElementArgs : SelectableListElementArgs<BattleHistoryListElement>
		{
			// Token: 0x06001232 RID: 4658 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001232")]
			[Address(RVA = "0x642D", Offset = "0x642D", VA = "0x642D")]
			public BattleHistoryListElementArgs()
			{
			}

			// Token: 0x040009A7 RID: 2471
			[Token(Token = "0x40009A7")]
			[FieldOffset(Offset = "0x1C")]
			public ProtoGetColossusBattlesAns.Types.ColossusBattle Battle;

			// Token: 0x040009A8 RID: 2472
			[Token(Token = "0x40009A8")]
			[FieldOffset(Offset = "0x20")]
			public ColossusDic ColossusDic;

			// Token: 0x040009A9 RID: 2473
			[Token(Token = "0x40009A9")]
			[FieldOffset(Offset = "0x24")]
			public string WinnerClanCultAssetId;

			// Token: 0x040009AA RID: 2474
			[Token(Token = "0x40009AA")]
			[FieldOffset(Offset = "0x28")]
			public string LoserClanCultAssetId;

			// Token: 0x040009AB RID: 2475
			[Token(Token = "0x40009AB")]
			[FieldOffset(Offset = "0x2C")]
			public ColossusRatingDic[] ValidRatings;

			// Token: 0x040009AC RID: 2476
			[Token(Token = "0x40009AC")]
			[FieldOffset(Offset = "0x30")]
			public UserData User;
		}
	}
}
