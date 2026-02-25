using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Boss.Model;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Boss.View.RatingTab
{
	// Token: 0x02000B65 RID: 2917
	[Token(Token = "0x2000B65")]
	public class BossRatingListItemView : MonoBehaviour
	{
		// Token: 0x140001B9 RID: 441
		// (add) Token: 0x060046B9 RID: 18105 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060046BA RID: 18106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B9")]
		public event Action<BossCaptainRatingData> ClickEvent
		{
			[Token(Token = "0x60046B9")]
			[Address(RVA = "0x954F", Offset = "0x954F", VA = "0x954F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60046BA")]
			[Address(RVA = "0x9550", Offset = "0x9550", VA = "0x9550")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x060046BB RID: 18107 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060046BC RID: 18108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E05")]
		public BossCaptainRatingData CaptainRating
		{
			[Token(Token = "0x60046BB")]
			[Address(RVA = "0x9551", Offset = "0x9551", VA = "0x9551")]
			get
			{
				return null;
			}
			[Token(Token = "0x60046BC")]
			[Address(RVA = "0x9552", Offset = "0x9552", VA = "0x9552")]
			set
			{
			}
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046BD")]
		[Address(RVA = "0x9553", Offset = "0x9553", VA = "0x9553")]
		private void DataOnCaptainUserDataChangedEvent()
		{
		}

		// Token: 0x060046BE RID: 18110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046BE")]
		[Address(RVA = "0x9554", Offset = "0x9554", VA = "0x9554")]
		private void Awake()
		{
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046BF")]
		[Address(RVA = "0x9555", Offset = "0x9555", VA = "0x9555")]
		private void MonoPointerClickHandlerOnOnClickEvent(PointerEventData data)
		{
		}

		// Token: 0x060046C0 RID: 18112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046C0")]
		[Address(RVA = "0x9556", Offset = "0x9556", VA = "0x9556")]
		private void OnDestroy()
		{
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046C1")]
		[Address(RVA = "0x9557", Offset = "0x9557", VA = "0x9557")]
		public BossRatingListItemView()
		{
		}

		// Token: 0x040026B3 RID: 9907
		[Token(Token = "0x40026B3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _top;

		// Token: 0x040026B4 RID: 9908
		[Token(Token = "0x40026B4")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _topBG;

		// Token: 0x040026B5 RID: 9909
		[Token(Token = "0x40026B5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _myCaptainMarker;

		// Token: 0x040026B6 RID: 9910
		[Token(Token = "0x40026B6")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private UserView _avatar;

		// Token: 0x040026B7 RID: 9911
		[Token(Token = "0x40026B7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImage _cult;

		// Token: 0x040026B8 RID: 9912
		[Token(Token = "0x40026B8")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _nicname;

		// Token: 0x040026B9 RID: 9913
		[Token(Token = "0x40026B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _score;

		// Token: 0x040026BA RID: 9914
		[Token(Token = "0x40026BA")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private List<Sprite> _scoreBGList;

		// Token: 0x040026BB RID: 9915
		[Token(Token = "0x40026BB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _meScoreBG;

		// Token: 0x040026BC RID: 9916
		[Token(Token = "0x40026BC")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MonoPointerClickHandler _monoPointerClickHandler;

		// Token: 0x040026BD RID: 9917
		[Token(Token = "0x40026BD")]
		[FieldOffset(Offset = "0x38")]
		private BossCaptainRatingData _captainRating;
	}
}
