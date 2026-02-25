using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.Rating;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexRating.View.VoteRewardsTab
{
	// Token: 0x02000388 RID: 904
	[Token(Token = "0x2000388")]
	public class VoteRewardsView : MonoBehaviour
	{
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000377")]
		public Button SetGiftButton
		{
			[Token(Token = "0x6001512")]
			[Address(RVA = "0x66D4", Offset = "0x66D4", VA = "0x66D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001513")]
		[Address(RVA = "0x66D5", Offset = "0x66D5", VA = "0x66D5")]
		public GiftListElement[] Init(ProtoGetGreatTopAns ans, IList<GreatRewardSets> rewardSets, UserData user)
		{
			return null;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001514")]
		[Address(RVA = "0x66D6", Offset = "0x66D6", VA = "0x66D6")]
		public void UpdateRatings(ProtoGetGreatTopAns ans)
		{
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001515")]
		[Address(RVA = "0x66D7", Offset = "0x66D7", VA = "0x66D7")]
		public GiftListElement[] UpdateRewardSets(IList<GreatRewardSets> rewardSets, UserData user)
		{
			return null;
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001516")]
		[Address(RVA = "0x66D8", Offset = "0x66D8", VA = "0x66D8")]
		public VoteRewardsView()
		{
		}

		// Token: 0x04000B2A RID: 2858
		[Token(Token = "0x4000B2A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GiftListElement _giftListElementPrefab;

		// Token: 0x04000B2B RID: 2859
		[Token(Token = "0x4000B2B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _setGiftButton;

		// Token: 0x04000B2C RID: 2860
		[Token(Token = "0x4000B2C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _vortexRating;

		// Token: 0x04000B2D RID: 2861
		[Token(Token = "0x4000B2D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _likesRating;

		// Token: 0x04000B2E RID: 2862
		[Token(Token = "0x4000B2E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _giftsSent;

		// Token: 0x04000B2F RID: 2863
		[Token(Token = "0x4000B2F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _totalRating;

		// Token: 0x04000B30 RID: 2864
		[Token(Token = "0x4000B30")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _content;
	}
}
