using System;
using Il2CppDummyDll;
using Protocol.Boss;
using UI.Rewards;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Boss.View.Rewarding
{
	// Token: 0x02000B5B RID: 2907
	[Token(Token = "0x2000B5B")]
	public abstract class AbstractBossRewardingSlotView : MonoBehaviour
	{
		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x0600465E RID: 18014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DE3")]
		public Image GreenSelectedImage
		{
			[Token(Token = "0x600465E")]
			[Address(RVA = "0x94F6", Offset = "0x94F6", VA = "0x94F6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x0600465F RID: 18015 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004660 RID: 18016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE4")]
		public virtual GetTeamRewardsAns.Types.BossRewardInfo BossRewardInfo
		{
			[Token(Token = "0x600465F")]
			[Address(RVA = "0x94F7", Offset = "0x94F7", VA = "0x94F7", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004660")]
			[Address(RVA = "0x94F8", Offset = "0x94F8", VA = "0x94F8", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004661")]
		[Address(RVA = "0x94F9", Offset = "0x94F9", VA = "0x94F9")]
		private void Awake()
		{
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004662")]
		[Address(RVA = "0x94FA", Offset = "0x94FA", VA = "0x94FA")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004663")]
		[Address(RVA = "0x94FB", Offset = "0x94FB", VA = "0x94FB")]
		private void ClickHandlerOnOnClickEvent(PointerEventData data)
		{
		}

		// Token: 0x06004664 RID: 18020
		[Token(Token = "0x6004664")]
		protected abstract void HandleClick();

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		// (set) Token: 0x06004666 RID: 18022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE5")]
		public virtual bool Interactable
		{
			[Token(Token = "0x6004665")]
			[Address(RVA = "0x94FC", Offset = "0x94FC", VA = "0x94FC", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004666")]
			[Address(RVA = "0x94FD", Offset = "0x94FD", VA = "0x94FD", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004667")]
		[Address(RVA = "0x94FE", Offset = "0x94FE", VA = "0x94FE")]
		protected AbstractBossRewardingSlotView()
		{
		}

		// Token: 0x04002681 RID: 9857
		[Token(Token = "0x4002681")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04002682 RID: 9858
		[Token(Token = "0x4002682")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x04002683 RID: 9859
		[Token(Token = "0x4002683")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _greenSelectedImage;

		// Token: 0x04002684 RID: 9860
		[Token(Token = "0x4002684")]
		[FieldOffset(Offset = "0x1C")]
		private GetTeamRewardsAns.Types.BossRewardInfo _bossRewardInfo;

		// Token: 0x04002685 RID: 9861
		[Token(Token = "0x4002685")]
		[FieldOffset(Offset = "0x20")]
		private bool _interactable;
	}
}
