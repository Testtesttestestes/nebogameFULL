using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.Combat.View.TurnDisplay;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Combat;
using Sirenix.OdinInspector;
using UI.Elements.ProgressBars;
using UnityEngine;

namespace Gameplay.Combat.View.GameField.Hint
{
	// Token: 0x02000974 RID: 2420
	[Token(Token = "0x2000974")]
	public class IdleHint : SerializedMonoBehaviour
	{
		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06003993 RID: 14739 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x17000B4E")]
		private TurnStates CurrentState
		{
			[Token(Token = "0x6003993")]
			[Address(RVA = "0x8924", Offset = "0x8924", VA = "0x8924")]
			get
			{
				return TurnStates.NoTurn;
			}
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003994")]
		[Address(RVA = "0x8925", Offset = "0x8925", VA = "0x8925")]
		protected void Start()
		{
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003995")]
		[Address(RVA = "0x8926", Offset = "0x8926", VA = "0x8926")]
		protected void OnDestroy()
		{
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003996")]
		[Address(RVA = "0x8927", Offset = "0x8927", VA = "0x8927")]
		private void StopHint()
		{
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003997")]
		[Address(RVA = "0x8928", Offset = "0x8928", VA = "0x8928")]
		private void HandleOnMouseDownEvent(BaseGameFieldMono _)
		{
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003998")]
		[Address(RVA = "0x8929", Offset = "0x8929", VA = "0x8929")]
		private void HandleSwapEvent(StoneMono _, StoneMono __)
		{
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003999")]
		[Address(RVA = "0x892A", Offset = "0x892A", VA = "0x892A")]
		private void RestartHint()
		{
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600399A")]
		[Address(RVA = "0x892B", Offset = "0x892B", VA = "0x892B")]
		private IEnumerator HintCor()
		{
			return null;
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399B")]
		[Address(RVA = "0x892C", Offset = "0x892C", VA = "0x892C")]
		private void CalculateHint()
		{
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x600399C")]
		[Address(RVA = "0x19E8", Offset = "0x19E8", VA = "0x19E8")]
		private bool CheckHint(StonesTypes type)
		{
			return default(bool);
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399D")]
		[Address(RVA = "0x892D", Offset = "0x892D", VA = "0x892D")]
		private void ShufflePatterns()
		{
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x600399E")]
		[Address(RVA = "0x892E", Offset = "0x892E", VA = "0x892E")]
		private bool CheckStone(int col, int row, StonesTypes type, HintPatternSO hintPattern, bool transpose, bool invertX, bool invertY)
		{
			return default(bool);
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399F")]
		[Address(RVA = "0x892F", Offset = "0x892F", VA = "0x892F")]
		private void ShowHint(IdleHint.HintInfo info)
		{
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60039A0")]
		[Address(RVA = "0x8930", Offset = "0x8930", VA = "0x8930")]
		private IEnumerator HintCor(IdleHint.HintInfo info)
		{
			return null;
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A1")]
		[Address(RVA = "0x8931", Offset = "0x8931", VA = "0x8931")]
		private void Bump(StoneMono src, StoneMono dst)
		{
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x60039A2")]
		[Address(RVA = "0x8932", Offset = "0x8932", VA = "0x8932")]
		private bool CheckForSwap(Vector2Int coords, StonesTypes stoneType, Vector2Int baseOffset, Vector2Int offset, ref IdleHint.HintInfo info, StoneMono neighbor, HintPatternSO hintPattern, bool transpose, bool invertX, bool invertY)
		{
			return default(bool);
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x60039A3")]
		[Address(RVA = "0x8933", Offset = "0x8933", VA = "0x8933")]
		private bool IsEqualType(Vector2Int coords, StonesTypes stoneType, Vector2Int offset, out StoneMono neighbor)
		{
			return default(bool);
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x60039A4")]
		[Address(RVA = "0x8934", Offset = "0x8934", VA = "0x8934")]
		private bool IsInField(int col, int row)
		{
			return default(bool);
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A5")]
		[Address(RVA = "0x8935", Offset = "0x8935", VA = "0x8935")]
		public IdleHint()
		{
		}

		// Token: 0x04001FDF RID: 8159
		[Token(Token = "0x4001FDF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameFieldMono _field;

		// Token: 0x04001FE0 RID: 8160
		[Token(Token = "0x4001FE0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ITurnStatePointer _turnPointer;

		// Token: 0x04001FE1 RID: 8161
		[Token(Token = "0x4001FE1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ProgressBar _playerHpBar;

		// Token: 0x04001FE2 RID: 8162
		[Token(Token = "0x4001FE2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _waitDuration;

		// Token: 0x04001FE3 RID: 8163
		[Token(Token = "0x4001FE3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _delay;

		// Token: 0x04001FE4 RID: 8164
		[Token(Token = "0x4001FE4")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private List<StonesTypes> _priority;

		// Token: 0x04001FE5 RID: 8165
		[Token(Token = "0x4001FE5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<HintPatternSO> _patterns;

		// Token: 0x04001FE6 RID: 8166
		[Token(Token = "0x4001FE6")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool _shufflePatterns;

		// Token: 0x04001FE7 RID: 8167
		[Token(Token = "0x4001FE7")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine _hintCor;

		// Token: 0x04001FE8 RID: 8168
		[Token(Token = "0x4001FE8")]
		[FieldOffset(Offset = "0x54")]
		private Coroutine _bumpCor;

		// Token: 0x02000975 RID: 2421
		[Token(Token = "0x2000975")]
		private class HintInfo
		{
			// Token: 0x060039AA RID: 14762 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039AA")]
			[Address(RVA = "0x893A", Offset = "0x893A", VA = "0x893A")]
			public void TryAddStone([NotNull] StoneMono value)
			{
			}

			// Token: 0x060039AB RID: 14763 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x60039AB")]
			[Address(RVA = "0x893B", Offset = "0x893B", VA = "0x893B")]
			public IEnumerable<StoneMono> GetStones()
			{
				return null;
			}

			// Token: 0x060039AC RID: 14764 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039AC")]
			[Address(RVA = "0x893C", Offset = "0x893C", VA = "0x893C")]
			public void SetSource([CanBeNull] StoneMono value)
			{
			}

			// Token: 0x060039AD RID: 14765 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039AD")]
			[Address(RVA = "0x893D", Offset = "0x893D", VA = "0x893D")]
			public void SetDestination([CanBeNull] StoneMono value)
			{
			}

			// Token: 0x060039AE RID: 14766 RVA: 0x0000B808 File Offset: 0x00009A08
			[Token(Token = "0x60039AE")]
			[Address(RVA = "0x893E", Offset = "0x893E", VA = "0x893E")]
			public bool TryGetSource(out StoneMono stone)
			{
				return default(bool);
			}

			// Token: 0x060039AF RID: 14767 RVA: 0x0000B820 File Offset: 0x00009A20
			[Token(Token = "0x60039AF")]
			[Address(RVA = "0x893F", Offset = "0x893F", VA = "0x893F")]
			public bool TryGetDestination(out StoneMono stone)
			{
				return default(bool);
			}

			// Token: 0x060039B0 RID: 14768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039B0")]
			[Address(RVA = "0x8940", Offset = "0x8940", VA = "0x8940")]
			public HintInfo()
			{
			}

			// Token: 0x04001FE9 RID: 8169
			[Token(Token = "0x4001FE9")]
			[FieldOffset(Offset = "0x8")]
			[CanBeNull]
			private StoneMono _source;

			// Token: 0x04001FEA RID: 8170
			[Token(Token = "0x4001FEA")]
			[FieldOffset(Offset = "0xC")]
			[CanBeNull]
			private StoneMono _destination;

			// Token: 0x04001FEB RID: 8171
			[Token(Token = "0x4001FEB")]
			[FieldOffset(Offset = "0x10")]
			private readonly List<StoneMono> _stones;
		}
	}
}
