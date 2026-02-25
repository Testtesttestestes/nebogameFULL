using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.CaptainTab;
using Il2CppDummyDll;
using Protocol.Boss;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.Boss.View.Rewarding
{
	// Token: 0x02000B5D RID: 2909
	[Token(Token = "0x2000B5D")]
	public class BossRewardingAssistantsView : MonoBehaviour
	{
		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06004675 RID: 18037 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DEB")]
		public BossRewardingAssistantSlotView[] AssistantSlots
		{
			[Token(Token = "0x6004675")]
			[Address(RVA = "0x950C", Offset = "0x950C", VA = "0x950C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06004676 RID: 18038 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DEC")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6004676")]
			[Address(RVA = "0x950D", Offset = "0x950D", VA = "0x950D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06004677 RID: 18039 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DED")]
		public GameObject BacktimeGroup
		{
			[Token(Token = "0x6004677")]
			[Address(RVA = "0x950E", Offset = "0x950E", VA = "0x950E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06004678 RID: 18040 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DEE")]
		public TextMeshProUGUI StatusLabel
		{
			[Token(Token = "0x6004678")]
			[Address(RVA = "0x950F", Offset = "0x950F", VA = "0x950F")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001B5 RID: 437
		// (add) Token: 0x06004679 RID: 18041 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600467A RID: 18042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B5")]
		public event Action<BossRewardingAssistantSlotView> SelectedAssistantSlotChangedEvent
		{
			[Token(Token = "0x6004679")]
			[Address(RVA = "0x9510", Offset = "0x9510", VA = "0x9510")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600467A")]
			[Address(RVA = "0x9511", Offset = "0x9511", VA = "0x9511")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x0600467B RID: 18043 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DEF")]
		public BossRewardingAssistantSlotView SelectedRewardingAssistantSlot
		{
			[Token(Token = "0x600467B")]
			[Address(RVA = "0x9512", Offset = "0x9512", VA = "0x9512")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x0600467C RID: 18044 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600467D RID: 18045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF0")]
		public TeamData TeamData
		{
			[Token(Token = "0x600467C")]
			[Address(RVA = "0x9513", Offset = "0x9513", VA = "0x9513")]
			get
			{
				return null;
			}
			[Token(Token = "0x600467D")]
			[Address(RVA = "0x9514", Offset = "0x9514", VA = "0x9514")]
			set
			{
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x0600467E RID: 18046 RVA: 0x0000D248 File Offset: 0x0000B448
		// (set) Token: 0x0600467F RID: 18047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF1")]
		public bool Editable
		{
			[Token(Token = "0x600467E")]
			[Address(RVA = "0x9515", Offset = "0x9515", VA = "0x9515")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600467F")]
			[Address(RVA = "0x9516", Offset = "0x9516", VA = "0x9516")]
			set
			{
			}
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004680")]
		[Address(RVA = "0x1B7D", Offset = "0x1B7D", VA = "0x1B7D")]
		public BossRewardingAssistantSlotView GetSlotById(ulong ownerId)
		{
			return null;
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004681")]
		[Address(RVA = "0x9517", Offset = "0x9517", VA = "0x9517")]
		private void Awake()
		{
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004682")]
		[Address(RVA = "0x9518", Offset = "0x9518", VA = "0x9518")]
		private void SlotOnClickEvent(BossRewardingAssistantSlotView bossRewardingSlotView)
		{
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004683")]
		[Address(RVA = "0x9519", Offset = "0x9519", VA = "0x9519")]
		public void SelectSlot(ulong? assistantId)
		{
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004684")]
		[Address(RVA = "0x951A", Offset = "0x951A", VA = "0x951A")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004685")]
		[Address(RVA = "0x951B", Offset = "0x951B", VA = "0x951B")]
		public void SetAssistantRewards(List<GetTeamRewardsAns.Types.BossRewardInfo> assistantRewards)
		{
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004686")]
		[Address(RVA = "0x951C", Offset = "0x951C", VA = "0x951C")]
		public BossRewardingAssistantsView()
		{
		}

		// Token: 0x0400268B RID: 9867
		[Token(Token = "0x400268B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BossTeamAssistantView[] _assistantViews;

		// Token: 0x0400268C RID: 9868
		[Token(Token = "0x400268C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BossRewardingAssistantSlotView[] _assistantSlots;

		// Token: 0x0400268D RID: 9869
		[Token(Token = "0x400268D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _backtimeGroup;

		// Token: 0x0400268E RID: 9870
		[Token(Token = "0x400268E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _statusLabel;

		// Token: 0x0400268F RID: 9871
		[Token(Token = "0x400268F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _totalSkillBonusLabel;

		// Token: 0x04002690 RID: 9872
		[Token(Token = "0x4002690")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SkillIconValue _totalSkillBonus;

		// Token: 0x04002691 RID: 9873
		[Token(Token = "0x4002691")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002693 RID: 9875
		[Token(Token = "0x4002693")]
		[FieldOffset(Offset = "0x30")]
		private BossRewardingAssistantSlotView _selectedRewardingAssistantSlot;

		// Token: 0x04002694 RID: 9876
		[Token(Token = "0x4002694")]
		[FieldOffset(Offset = "0x34")]
		private TeamData _teamData;

		// Token: 0x04002695 RID: 9877
		[Token(Token = "0x4002695")]
		[FieldOffset(Offset = "0x38")]
		private bool _editable;
	}
}
