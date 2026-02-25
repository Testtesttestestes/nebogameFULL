using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.CaptainTab;
using Il2CppDummyDll;
using Protocol.Boss;
using TMPro;
using UnityEngine;

namespace Gameplay.Boss.View.Rewarding
{
	// Token: 0x02000B5F RID: 2911
	[Token(Token = "0x2000B5F")]
	public class BossRewardingCaptainView : MonoBehaviour
	{
		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x0600468C RID: 18060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DF3")]
		public TextMeshProUGUI RewardsContainerTitle
		{
			[Token(Token = "0x600468C")]
			[Address(RVA = "0x9522", Offset = "0x9522", VA = "0x9522")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001B7 RID: 439
		// (add) Token: 0x0600468D RID: 18061 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600468E RID: 18062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B7")]
		public event Action<BossRewardingCaptainSlotView> CaptainRewardClickEvent
		{
			[Token(Token = "0x600468D")]
			[Address(RVA = "0x9523", Offset = "0x9523", VA = "0x9523")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600468E")]
			[Address(RVA = "0x9524", Offset = "0x9524", VA = "0x9524")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x0600468F RID: 18063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DF4")]
		public List<BossRewardingCaptainSlotView> CaptainSlots
		{
			[Token(Token = "0x600468F")]
			[Address(RVA = "0x9525", Offset = "0x9525", VA = "0x9525")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06004690 RID: 18064 RVA: 0x0000D260 File Offset: 0x0000B460
		// (set) Token: 0x06004691 RID: 18065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF5")]
		public bool SelectionMode
		{
			[Token(Token = "0x6004690")]
			[Address(RVA = "0x9526", Offset = "0x9526", VA = "0x9526")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004691")]
			[Address(RVA = "0x9527", Offset = "0x9527", VA = "0x9527")]
			set
			{
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06004692 RID: 18066 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004693 RID: 18067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF6")]
		public TeamData TeamData
		{
			[Token(Token = "0x6004692")]
			[Address(RVA = "0x9528", Offset = "0x9528", VA = "0x9528")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004693")]
			[Address(RVA = "0x9529", Offset = "0x9529", VA = "0x9529")]
			set
			{
			}
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004694")]
		[Address(RVA = "0x952A", Offset = "0x952A", VA = "0x952A")]
		public void SetCaptainRewards(IList<GetTeamRewardsAns.Types.BossRewardInfo> rewards)
		{
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004695")]
		[Address(RVA = "0x952B", Offset = "0x952B", VA = "0x952B")]
		private void CaptainSlotOnClickEvent(BossRewardingCaptainSlotView obj)
		{
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004696")]
		[Address(RVA = "0x952C", Offset = "0x952C", VA = "0x952C")]
		public BossRewardingCaptainView()
		{
		}

		// Token: 0x04002697 RID: 9879
		[Token(Token = "0x4002697")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _rewardingSlotsContainer;

		// Token: 0x04002698 RID: 9880
		[Token(Token = "0x4002698")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _rewardsContainerTitle;

		// Token: 0x04002699 RID: 9881
		[Token(Token = "0x4002699")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _nickLabel;

		// Token: 0x0400269A RID: 9882
		[Token(Token = "0x400269A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BossTeamCaptainView _captainView;

		// Token: 0x0400269B RID: 9883
		[Token(Token = "0x400269B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BossRewardingCaptainSlotView _rewardingSlotPrefab;

		// Token: 0x0400269D RID: 9885
		[Token(Token = "0x400269D")]
		[FieldOffset(Offset = "0x28")]
		private List<BossRewardingCaptainSlotView> _captainSlots;

		// Token: 0x0400269E RID: 9886
		[Token(Token = "0x400269E")]
		[FieldOffset(Offset = "0x2C")]
		private bool _selectionMode;

		// Token: 0x0400269F RID: 9887
		[Token(Token = "0x400269F")]
		[FieldOffset(Offset = "0x30")]
		private TeamData _teamData;
	}
}
