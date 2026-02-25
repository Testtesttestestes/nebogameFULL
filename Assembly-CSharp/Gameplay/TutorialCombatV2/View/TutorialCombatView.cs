using System;
using Animations;
using AssetContent;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.GameField;
using Gameplay.Combat.View.Players;
using Il2CppDummyDll;
using Protocol.Combat;
using Protocol.Common;
using UnityEngine;

namespace Gameplay.TutorialCombatV2.View
{
	// Token: 0x02000446 RID: 1094
	[Token(Token = "0x2000446")]
	public class TutorialCombatView : OneOnOneCombatView
	{
		// Token: 0x060019C9 RID: 6601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x6B61", Offset = "0x6B61", VA = "0x6B61", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x6B62", Offset = "0x6B62", VA = "0x6B62", Slot = "6")]
		protected override void Start()
		{
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CB")]
		[Address(RVA = "0x6B63", Offset = "0x6B63", VA = "0x6B63")]
		private void HandleOnMouseDownEvent(BaseGameFieldMono obj)
		{
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700048B")]
		public InIdleOutSpineAnimation ResultAnimation
		{
			[Token(Token = "0x60019CC")]
			[Address(RVA = "0x6B64", Offset = "0x6B64", VA = "0x6B64")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60019CD")]
		[Address(RVA = "0x6B65", Offset = "0x6B65", VA = "0x6B65", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
			return null;
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019CE")]
		[Address(RVA = "0x6B66", Offset = "0x6B66", VA = "0x6B66", Slot = "14")]
		protected override void ShowOpponentDeath(ICombatPLayerView player)
		{
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60019CF")]
		[Address(RVA = "0x6B67", Offset = "0x6B67", VA = "0x6B67")]
		private InIdleOutSpineAnimation CreateWinOrLoseAnimation(bool isWin, Transform parent)
		{
			return null;
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D0")]
		[Address(RVA = "0x6B68", Offset = "0x6B68", VA = "0x6B68")]
		private void HideExcessFields(ProtoShowHintEvt msg)
		{
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D1")]
		[Address(RVA = "0x6B69", Offset = "0x6B69", VA = "0x6B69", Slot = "10")]
		public override void HideHint()
		{
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D2")]
		[Address(RVA = "0x6B6A", Offset = "0x6B6A", VA = "0x6B6A")]
		private void ShowFieldGlow(Point point)
		{
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D3")]
		[Address(RVA = "0x6B6B", Offset = "0x6B6B", VA = "0x6B6B")]
		private void HideFieldGlow(Point point)
		{
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D4")]
		[Address(RVA = "0x6B6C", Offset = "0x6B6C", VA = "0x6B6C")]
		private void OnEnable()
		{
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D5")]
		[Address(RVA = "0x6B6D", Offset = "0x6B6D", VA = "0x6B6D")]
		private void OnDisable()
		{
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019D6")]
		[Address(RVA = "0x6B6E", Offset = "0x6B6E", VA = "0x6B6E")]
		public TutorialCombatView()
		{
		}

		// Token: 0x04000DD8 RID: 3544
		[Token(Token = "0x4000DD8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject[] _otherViewParts;

		// Token: 0x04000DD9 RID: 3545
		[Token(Token = "0x4000DD9")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private WinCombatGameOverAnimation _winAnimation;

		// Token: 0x04000DDA RID: 3546
		[Token(Token = "0x4000DDA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private InIdleOutSpineAnimation _loseAnimation;

		// Token: 0x04000DDB RID: 3547
		[Token(Token = "0x4000DDB")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private GameObject[] _turnHintCells;

		// Token: 0x04000DDC RID: 3548
		[Token(Token = "0x4000DDC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _opponentView;

		// Token: 0x04000DDD RID: 3549
		[Token(Token = "0x4000DDD")]
		[FieldOffset(Offset = "0x84")]
		private InIdleOutSpineAnimation _resultAnimation;
	}
}
