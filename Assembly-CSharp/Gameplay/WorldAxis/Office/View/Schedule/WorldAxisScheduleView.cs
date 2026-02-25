using System;
using System.Collections.Generic;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.Schedule
{
	// Token: 0x020002F2 RID: 754
	[Token(Token = "0x20002F2")]
	public class WorldAxisScheduleView : MonoBehaviour
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A4")]
		private Dictionary<ColossusBattleData.State, Sprite> BgByStateDict
		{
			[Token(Token = "0x60011D3")]
			[Address(RVA = "0x1DCF", Offset = "0x1DCF", VA = "0x1DCF")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A5")]
		private Dictionary<ColossusBattleData.State, Sprite> SwordsIconByStateDict
		{
			[Token(Token = "0x60011D4")]
			[Address(RVA = "0x1DD0", Offset = "0x1DD0", VA = "0x1DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A6")]
		public TopRatingTable TopRatingTable
		{
			[Token(Token = "0x60011D5")]
			[Address(RVA = "0x63D0", Offset = "0x63D0", VA = "0x63D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A7")]
		public TextMeshProUGUI ColossusBattleHeader
		{
			[Token(Token = "0x60011D6")]
			[Address(RVA = "0x63D1", Offset = "0x63D1", VA = "0x63D1")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A8")]
		public BacktimeViewUGUI Backtime
		{
			[Token(Token = "0x60011D7")]
			[Address(RVA = "0x63D2", Offset = "0x63D2", VA = "0x63D2")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002A9")]
		public TextMeshProUGUI ParticipationDescription
		{
			[Token(Token = "0x60011D8")]
			[Address(RVA = "0x63D3", Offset = "0x63D3", VA = "0x63D3")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AA")]
		public Button RedButton
		{
			[Token(Token = "0x60011D9")]
			[Address(RVA = "0x63D4", Offset = "0x63D4", VA = "0x63D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AB")]
		public Button ToWorldAxisButton
		{
			[Token(Token = "0x60011DA")]
			[Address(RVA = "0x63D5", Offset = "0x63D5", VA = "0x63D5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AC")]
		public Button ColossusInfoButton
		{
			[Token(Token = "0x60011DB")]
			[Address(RVA = "0x63D6", Offset = "0x63D6", VA = "0x63D6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002AD")]
		public GameAssetViewRawImage ColossusAvatar
		{
			[Token(Token = "0x60011DC")]
			[Address(RVA = "0x63D7", Offset = "0x63D7", VA = "0x63D7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011DD")]
		[Address(RVA = "0x63D8", Offset = "0x63D8", VA = "0x63D8")]
		public void InitBattles(IEnumerable<ColossusBattleListElement.ColossusBattleListElementArgs> battles)
		{
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011DE")]
		[Address(RVA = "0x63D9", Offset = "0x63D9", VA = "0x63D9")]
		public WorldAxisScheduleView()
		{
		}

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _colossusAvatar;

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ColossusBattleListElement _listElementPrefab;

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x400093F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TopRatingTable _topRatingTable;

		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _colossusBattleHeader;

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BacktimeViewUGUI _backtime;

		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _participationDescription;

		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x4000943")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _redButton;

		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x4000944")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _toWorldAxisButton;

		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x4000945")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _colossusInfoButton;

		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private WorldAxisScheduleView.SpriteByState[] _bgByState;

		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private WorldAxisScheduleView.SpriteByState[] _swordsIconByState;

		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<ColossusBattleData.State, Sprite> _bgByStateDict;

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		[FieldOffset(Offset = "0x44")]
		private Dictionary<ColossusBattleData.State, Sprite> _swordsIconByStateDict;

		// Token: 0x020002F3 RID: 755
		[Token(Token = "0x20002F3")]
		[Serializable]
		public class SpriteByState
		{
			// Token: 0x060011DF RID: 4575 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011DF")]
			[Address(RVA = "0x63DA", Offset = "0x63DA", VA = "0x63DA")]
			public SpriteByState()
			{
			}

			// Token: 0x0400094A RID: 2378
			[Token(Token = "0x400094A")]
			[FieldOffset(Offset = "0x8")]
			public ColossusBattleData.State State;

			// Token: 0x0400094B RID: 2379
			[Token(Token = "0x400094B")]
			[FieldOffset(Offset = "0xC")]
			public Sprite Sprite;
		}
	}
}
