using System;
using System.Runtime.CompilerServices;
using Animations;
using Core.Data;
using Gameplay.Ad.BattleFinishAd.View;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Animations;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Common;
using UI;
using UI.Elements.Buttons;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Combat.View
{
	// Token: 0x02000916 RID: 2326
	[Token(Token = "0x2000916")]
	public class CombatGameOverView : MonoBehaviourWithStates<CombatGameOverView.CombatGameOverViewStates>
	{
		// Token: 0x14000175 RID: 373
		// (add) Token: 0x060036CE RID: 14030 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060036CF RID: 14031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000175")]
		public event Func<CombatGameOverView, bool> CloseRequestEvent
		{
			[Token(Token = "0x60036CE")]
			[Address(RVA = "0x86BD", Offset = "0x86BD", VA = "0x86BD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60036CF")]
			[Address(RVA = "0x86BE", Offset = "0x86BE", VA = "0x86BE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000176 RID: 374
		// (add) Token: 0x060036D0 RID: 14032 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060036D1 RID: 14033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000176")]
		public event Func<CombatGameOverView, bool> NextCombatRequestEvent
		{
			[Token(Token = "0x60036D0")]
			[Address(RVA = "0x86BF", Offset = "0x86BF", VA = "0x86BF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60036D1")]
			[Address(RVA = "0x86C0", Offset = "0x86C0", VA = "0x86C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x060036D2 RID: 14034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AD0")]
		public IndexButtonBasic ChestButton
		{
			[Token(Token = "0x60036D2")]
			[Address(RVA = "0x86C1", Offset = "0x86C1", VA = "0x86C1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x060036D3 RID: 14035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AD1")]
		public ButtonWithCost RunCombatButton
		{
			[Token(Token = "0x60036D3")]
			[Address(RVA = "0x86C2", Offset = "0x86C2", VA = "0x86C2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x060036D4 RID: 14036 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AD2")]
		public RewardsRender RewardsRender
		{
			[Token(Token = "0x60036D4")]
			[Address(RVA = "0x86C3", Offset = "0x86C3", VA = "0x86C3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x060036D5 RID: 14037 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060036D6 RID: 14038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD3")]
		public CombatGameOverView.CombatGameOverViewArgs Args
		{
			[Token(Token = "0x60036D5")]
			[Address(RVA = "0x86C4", Offset = "0x86C4", VA = "0x86C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036D6")]
			[Address(RVA = "0x86C5", Offset = "0x86C5", VA = "0x86C5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036D7")]
		[Address(RVA = "0x86C6", Offset = "0x86C6", VA = "0x86C6")]
		private void OnDestroy()
		{
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036D8")]
		[Address(RVA = "0x86C7", Offset = "0x86C7", VA = "0x86C7", Slot = "5")]
		public virtual CombatGameOverView Show(CombatGameOverView.CombatGameOverViewArgs args)
		{
			return null;
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036D9")]
		[Address(RVA = "0x86C8", Offset = "0x86C8", VA = "0x86C8")]
		public void Hide()
		{
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036DA")]
		[Address(RVA = "0x86C9", Offset = "0x86C9", VA = "0x86C9", Slot = "6")]
		protected virtual InIdleOutSpineAnimation CreateResultAnimation(GameOverData gameOverData, Transform parent)
		{
			return null;
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DB")]
		[Address(RVA = "0x86CA", Offset = "0x86CA", VA = "0x86CA")]
		public void HandleRunCombatButtonOnClickEvent()
		{
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DC")]
		[Address(RVA = "0x86CB", Offset = "0x86CB", VA = "0x86CB")]
		private void HandleCloseButtonClickEvent()
		{
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DD")]
		[Address(RVA = "0x86CC", Offset = "0x86CC", VA = "0x86CC")]
		public CombatGameOverView()
		{
		}

		// Token: 0x04001DFC RID: 7676
		[Token(Token = "0x4001DFC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RewardsRender _rewardsBox;

		// Token: 0x04001DFD RID: 7677
		[Token(Token = "0x4001DFD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ButtonWithCost _runCombatButton;

		// Token: 0x04001DFE RID: 7678
		[Token(Token = "0x4001DFE")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _closeButton;

		// Token: 0x04001DFF RID: 7679
		[Token(Token = "0x4001DFF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _animationContainer;

		// Token: 0x04001E00 RID: 7680
		[Token(Token = "0x4001E00")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected WinCombatGameOverAnimation _winAnimation;

		// Token: 0x04001E01 RID: 7681
		[Token(Token = "0x4001E01")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected InIdleOutSpineAnimation _loseAnimation;

		// Token: 0x04001E02 RID: 7682
		[Token(Token = "0x4001E02")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BattleFinishAdEntryView _battleFinishAdEntryView;

		// Token: 0x04001E03 RID: 7683
		[Token(Token = "0x4001E03")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private IndexButtonBasic _chestButton;

		// Token: 0x04001E04 RID: 7684
		[Token(Token = "0x4001E04")]
		[FieldOffset(Offset = "0x3C")]
		private InIdleOutSpineAnimation _resultAnimation;

		// Token: 0x02000917 RID: 2327
		[Token(Token = "0x2000917")]
		public enum CombatGameOverViewStates
		{
			// Token: 0x04001E09 RID: 7689
			[Token(Token = "0x4001E09")]
			UNKNOWN,
			// Token: 0x04001E0A RID: 7690
			[Token(Token = "0x4001E0A")]
			DEFAULT,
			// Token: 0x04001E0B RID: 7691
			[Token(Token = "0x4001E0B")]
			EMPTY
		}

		// Token: 0x02000918 RID: 2328
		[Token(Token = "0x2000918")]
		public class CombatGameOverViewArgs
		{
			// Token: 0x060036DE RID: 14046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036DE")]
			[Address(RVA = "0x86CD", Offset = "0x86CD", VA = "0x86CD")]
			public CombatGameOverViewArgs(UserData user, GameOverData gameOverData, ResourceSet nextCombatCost)
			{
			}

			// Token: 0x060036DF RID: 14047 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036DF")]
			[Address(RVA = "0x86CE", Offset = "0x86CE", VA = "0x86CE")]
			public CombatGameOverViewArgs(UserData user, GameOverData gameOverData)
			{
			}

			// Token: 0x04001E0C RID: 7692
			[Token(Token = "0x4001E0C")]
			[FieldOffset(Offset = "0x8")]
			public readonly GameOverData GameOverData;

			// Token: 0x04001E0D RID: 7693
			[Token(Token = "0x4001E0D")]
			[FieldOffset(Offset = "0xC")]
			public readonly UserData User;

			// Token: 0x04001E0E RID: 7694
			[Token(Token = "0x4001E0E")]
			[FieldOffset(Offset = "0x10")]
			[CanBeNull]
			public readonly ResourceSet NextCombatCost;
		}
	}
}
