using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;
using UI;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Rating.View
{
	// Token: 0x02000582 RID: 1410
	[Token(Token = "0x2000582")]
	public class RatingRewardsView : MonoBehaviourWithStates<RatingRewardsView.State>
	{
		// Token: 0x060021AC RID: 8620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021AC")]
		[Address(RVA = "0x730B", Offset = "0x730B", VA = "0x730B")]
		public void SetRewards(IList<RatingRewardsView.RatingRewardArgs> rewards)
		{
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021AD")]
		[Address(RVA = "0x730C", Offset = "0x730C", VA = "0x730C")]
		public RatingRewardsView()
		{
		}

		// Token: 0x04001271 RID: 4721
		[Token(Token = "0x4001271")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RewardsRender _rewardsRendererPrefab;

		// Token: 0x04001272 RID: 4722
		[Token(Token = "0x4001272")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _separator;

		// Token: 0x04001273 RID: 4723
		[Token(Token = "0x4001273")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x02000583 RID: 1411
		[Token(Token = "0x2000583")]
		public enum State : byte
		{
			// Token: 0x04001275 RID: 4725
			[Token(Token = "0x4001275")]
			UNKNOWN_STATE,
			// Token: 0x04001276 RID: 4726
			[Token(Token = "0x4001276")]
			DEFAULT,
			// Token: 0x04001277 RID: 4727
			[Token(Token = "0x4001277")]
			EMPTY
		}

		// Token: 0x02000584 RID: 1412
		[Token(Token = "0x2000584")]
		public class RatingRewardArgs
		{
			// Token: 0x060021AE RID: 8622 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60021AE")]
			[Address(RVA = "0x730D", Offset = "0x730D", VA = "0x730D")]
			public RatingRewardArgs()
			{
			}

			// Token: 0x04001278 RID: 4728
			[Token(Token = "0x4001278")]
			[FieldOffset(Offset = "0x8")]
			public RewardData[] Rewards;

			// Token: 0x04001279 RID: 4729
			[Token(Token = "0x4001279")]
			[FieldOffset(Offset = "0xC")]
			public string Title;
		}
	}
}
