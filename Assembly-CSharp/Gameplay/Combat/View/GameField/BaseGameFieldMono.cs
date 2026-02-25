using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core.Data.User;
using DG.Tweening;
using Gameplay.Combat.Model;
using Gameplay.Input;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x0200095F RID: 2399
	[Token(Token = "0x200095F")]
	public abstract class BaseGameFieldMono : MonoBehaviour, IInputPressHandler
	{
		// Token: 0x14000180 RID: 384
		// (add) Token: 0x060038DB RID: 14555 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060038DC RID: 14556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000180")]
		public event Action<StoneMono, StoneMono> SwapEvent
		{
			[Token(Token = "0x60038DB")]
			[Address(RVA = "0x8879", Offset = "0x8879", VA = "0x8879")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60038DC")]
			[Address(RVA = "0x887A", Offset = "0x887A", VA = "0x887A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000181 RID: 385
		// (add) Token: 0x060038DD RID: 14557 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060038DE RID: 14558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000181")]
		public event Action<BaseGameFieldMono> OnMouseDownEvent
		{
			[Token(Token = "0x60038DD")]
			[Address(RVA = "0x887B", Offset = "0x887B", VA = "0x887B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60038DE")]
			[Address(RVA = "0x887C", Offset = "0x887C", VA = "0x887C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x0000B490 File Offset: 0x00009690
		// (set) Token: 0x060038E0 RID: 14560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B32")]
		public uint RowNum
		{
			[Token(Token = "0x60038DF")]
			[Address(RVA = "0x887D", Offset = "0x887D", VA = "0x887D")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60038E0")]
			[Address(RVA = "0x887E", Offset = "0x887E", VA = "0x887E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x060038E1 RID: 14561 RVA: 0x0000B4A8 File Offset: 0x000096A8
		// (set) Token: 0x060038E2 RID: 14562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B33")]
		public uint ColNum
		{
			[Token(Token = "0x60038E1")]
			[Address(RVA = "0x887F", Offset = "0x887F", VA = "0x887F")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60038E2")]
			[Address(RVA = "0x8880", Offset = "0x8880", VA = "0x8880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x0000B4C0 File Offset: 0x000096C0
		// (set) Token: 0x060038E4 RID: 14564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B34")]
		public bool IsPressed
		{
			[Token(Token = "0x60038E3")]
			[Address(RVA = "0x8881", Offset = "0x8881", VA = "0x8881")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60038E4")]
			[Address(RVA = "0x8882", Offset = "0x8882", VA = "0x8882")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038E5")]
		[Address(RVA = "0x8883", Offset = "0x8883", VA = "0x8883", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038E6")]
		[Address(RVA = "0x8884", Offset = "0x8884", VA = "0x8884")]
		protected void SwapStones(StoneMono from, StoneMono to, float duration)
		{
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[Token(Token = "0x60038E7")]
		[Address(RVA = "0x8885", Offset = "0x8885", VA = "0x8885")]
		private bool TrySelectStone(StoneMono stone)
		{
			return default(bool);
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038E8")]
		[Address(RVA = "0x8886", Offset = "0x8886", VA = "0x8886")]
		private void DeselectCurrentStone()
		{
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60038E9")]
		[Address(RVA = "0x8887", Offset = "0x8887", VA = "0x8887")]
		private StoneMono GetStoneUnderPoint(Vector2 pos)
		{
			return null;
		}

		// Token: 0x060038EA RID: 14570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EA")]
		[Address(RVA = "0x8888", Offset = "0x8888", VA = "0x8888")]
		private void MoveToIdlePosition(StoneMono stone, float duration)
		{
		}

		// Token: 0x060038EB RID: 14571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EB")]
		[Address(RVA = "0x8889", Offset = "0x8889", VA = "0x8889")]
		private void ShowSwapWithNeighborStone(float duration)
		{
		}

		// Token: 0x060038EC RID: 14572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EC")]
		[Address(RVA = "0x888A", Offset = "0x888A", VA = "0x888A")]
		private void ClickCanceledEvent(IPlayerInput input, InputAction.CallbackContext ctx)
		{
		}

		// Token: 0x060038ED RID: 14573 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60038ED")]
		[Address(RVA = "0x888B", Offset = "0x888B", VA = "0x888B")]
		private IEnumerator DragCoroutine(Camera cam, IPlayerInput input)
		{
			return null;
		}

		// Token: 0x060038EE RID: 14574 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60038EE")]
		[Address(RVA = "0x888C", Offset = "0x888C", VA = "0x888C")]
		private IPlayerInput GetPlayerInput()
		{
			return null;
		}

		// Token: 0x060038EF RID: 14575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038EF")]
		[Address(RVA = "0x888D", Offset = "0x888D", VA = "0x888D")]
		private void SetSize(uint colNum, uint rowNum)
		{
		}

		// Token: 0x060038F0 RID: 14576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038F0")]
		[Address(RVA = "0x888E", Offset = "0x888E", VA = "0x888E", Slot = "6")]
		public virtual void InitField(GameFieldGamesData fieldData, UserSettings settings, float swapDuration)
		{
		}

		// Token: 0x060038F1 RID: 14577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038F1")]
		[Address(RVA = "0x888F", Offset = "0x888F", VA = "0x888F", Slot = "7")]
		public virtual void HandlePressDown(IPlayerInput input)
		{
		}

		// Token: 0x060038F2 RID: 14578 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x60038F2")]
		[Address(RVA = "0x37A9", Offset = "0x37A9", VA = "0x37A9")]
		public bool TryGetStoneMonoByCoords(int col, int row, out StoneMono stone)
		{
			return default(bool);
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038F3")]
		[Address(RVA = "0x8890", Offset = "0x8890", VA = "0x8890")]
		public void StopHandlePlayerInput()
		{
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038F4")]
		[Address(RVA = "0x8891", Offset = "0x8891", VA = "0x8891")]
		protected BaseGameFieldMono()
		{
		}

		// Token: 0x04001F6B RID: 8043
		[Token(Token = "0x4001F6B")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("mainCamera")]
		[SerializeField]
		protected Camera _mainCamera;

		// Token: 0x04001F6C RID: 8044
		[Token(Token = "0x4001F6C")]
		[FieldOffset(Offset = "0x1C")]
		private Coroutine _dragCoroutine;

		// Token: 0x04001F6D RID: 8045
		[Token(Token = "0x4001F6D")]
		[FieldOffset(Offset = "0x20")]
		private StoneMono _currentStone;

		// Token: 0x04001F6E RID: 8046
		[Token(Token = "0x4001F6E")]
		[FieldOffset(Offset = "0x24")]
		private StoneMono _neighborStone;

		// Token: 0x04001F6F RID: 8047
		[Token(Token = "0x4001F6F")]
		[FieldOffset(Offset = "0x28")]
		private Sequence _neighbourStoneSequence;

		// Token: 0x04001F70 RID: 8048
		[Token(Token = "0x4001F70")]
		[FieldOffset(Offset = "0x2C")]
		private IPlayerInput _playerInputCache;

		// Token: 0x04001F71 RID: 8049
		[Token(Token = "0x4001F71")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 _maxStonePosition;

		// Token: 0x04001F72 RID: 8050
		[Token(Token = "0x4001F72")]
		[FieldOffset(Offset = "0x38")]
		private float _swapDuration;

		// Token: 0x04001F73 RID: 8051
		[Token(Token = "0x4001F73")]
		[FieldOffset(Offset = "0x3C")]
		protected StoneMono[,] _allStones;
	}
}
