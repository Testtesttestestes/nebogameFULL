using System;
using AssetContent;
using Gameplay.GameEvents.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.GameEvents.View
{
	// Token: 0x02000778 RID: 1912
	[Token(Token = "0x2000778")]
	public class GameEventReadView : MonoBehaviourWithStates<GameEventReadView.GameEventReadViewStates>
	{
		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008BB")]
		public RewardsRender RewardsRender
		{
			[Token(Token = "0x6002D8A")]
			[Address(RVA = "0x7E08", Offset = "0x7E08", VA = "0x7E08")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008BC")]
		public Button TakeRewardButton
		{
			[Token(Token = "0x6002D8B")]
			[Address(RVA = "0x7E09", Offset = "0x7E09", VA = "0x7E09")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008BD")]
		public ActionsOnEventBox ActionsBox
		{
			[Token(Token = "0x6002D8C")]
			[Address(RVA = "0x7E0A", Offset = "0x7E0A", VA = "0x7E0A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06002D8D RID: 11661 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008BE")]
		public ScrollRect ContentScrollRect
		{
			[Token(Token = "0x6002D8D")]
			[Address(RVA = "0x7E0B", Offset = "0x7E0B", VA = "0x7E0B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008BF")]
		public MonoPointerClickHandler BackgroundClickHandler
		{
			[Token(Token = "0x6002D8E")]
			[Address(RVA = "0x7E0C", Offset = "0x7E0C", VA = "0x7E0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002D90 RID: 11664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C0")]
		public GameEventData Data
		{
			[Token(Token = "0x6002D8F")]
			[Address(RVA = "0x7E0D", Offset = "0x7E0D", VA = "0x7E0D")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D90")]
			[Address(RVA = "0x7E0E", Offset = "0x7E0E", VA = "0x7E0E")]
			set
			{
			}
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D91")]
		[Address(RVA = "0x7E0F", Offset = "0x7E0F", VA = "0x7E0F")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D92")]
		[Address(RVA = "0x7E10", Offset = "0x7E10", VA = "0x7E10")]
		public GameEventReadView()
		{
		}

		// Token: 0x040018E9 RID: 6377
		[Token(Token = "0x40018E9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _evtTypeDBGField;

		// Token: 0x040018EA RID: 6378
		[Token(Token = "0x40018EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _descriptionField;

		// Token: 0x040018EB RID: 6379
		[Token(Token = "0x40018EB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _viewOwner;

		// Token: 0x040018EC RID: 6380
		[Token(Token = "0x40018EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x040018ED RID: 6381
		[Token(Token = "0x40018ED")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _takeRewardButton;

		// Token: 0x040018EE RID: 6382
		[Token(Token = "0x40018EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActionsOnEventBox _actionsBox;

		// Token: 0x040018EF RID: 6383
		[Token(Token = "0x40018EF")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private GameRawImage _backgroundLoader;

		// Token: 0x040018F0 RID: 6384
		[Token(Token = "0x40018F0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MonoPointerClickHandler _backgroundClickHandler;

		// Token: 0x040018F1 RID: 6385
		[Token(Token = "0x40018F1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ScrollRect _contentScrollRect;

		// Token: 0x040018F2 RID: 6386
		[Token(Token = "0x40018F2")]
		[FieldOffset(Offset = "0x40")]
		private GameEventData _data;

		// Token: 0x02000779 RID: 1913
		[Token(Token = "0x2000779")]
		public enum GameEventReadViewStates
		{
			// Token: 0x040018F4 RID: 6388
			[Token(Token = "0x40018F4")]
			UNKNOWN_STATE,
			// Token: 0x040018F5 RID: 6389
			[Token(Token = "0x40018F5")]
			TAKE_REWARD_STATE,
			// Token: 0x040018F6 RID: 6390
			[Token(Token = "0x40018F6")]
			WORK_WHIT_DROP_STATE,
			// Token: 0x040018F7 RID: 6391
			[Token(Token = "0x40018F7")]
			READ_STATE
		}
	}
}
