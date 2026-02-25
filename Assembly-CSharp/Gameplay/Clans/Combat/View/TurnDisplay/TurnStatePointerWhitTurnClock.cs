using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Gameplay.Combat.View.TurnDisplay;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;

namespace Gameplay.Clans.Combat.View.TurnDisplay
{
	// Token: 0x02000A96 RID: 2710
	[Token(Token = "0x2000A96")]
	public class TurnStatePointerWhitTurnClock : MonoBehaviour, ITurnStatePointer
	{
		// Token: 0x1400019B RID: 411
		// (add) Token: 0x0600410F RID: 16655 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004110 RID: 16656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400019B")]
		public event Action TimeOutEvent
		{
			[Token(Token = "0x600410F")]
			[Address(RVA = "0x8FC6", Offset = "0x8FC6", VA = "0x8FC6", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004110")]
			[Address(RVA = "0x8FC7", Offset = "0x8FC7", VA = "0x8FC7", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400019C RID: 412
		// (add) Token: 0x06004111 RID: 16657 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004112 RID: 16658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400019C")]
		public event Action TurnStateChangedEvent
		{
			[Token(Token = "0x6004111")]
			[Address(RVA = "0x8FC8", Offset = "0x8FC8", VA = "0x8FC8", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004112")]
			[Address(RVA = "0x8FC9", Offset = "0x8FC9", VA = "0x8FC9", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06004113 RID: 16659 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004114 RID: 16660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD3")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x6004113")]
			[Address(RVA = "0x8FCA", Offset = "0x8FCA", VA = "0x8FCA", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004114")]
			[Address(RVA = "0x8FCB", Offset = "0x8FCB", VA = "0x8FCB", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06004115 RID: 16661 RVA: 0x0000C828 File Offset: 0x0000AA28
		// (set) Token: 0x06004116 RID: 16662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD4")]
		public TurnStates TurnState
		{
			[Token(Token = "0x6004115")]
			[Address(RVA = "0x8FCC", Offset = "0x8FCC", VA = "0x8FCC", Slot = "8")]
			get
			{
				return TurnStates.NoTurn;
			}
			[Token(Token = "0x6004116")]
			[Address(RVA = "0x8FCD", Offset = "0x8FCD", VA = "0x8FCD")]
			private set
			{
			}
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004117")]
		[Address(RVA = "0x8FCE", Offset = "0x8FCE", VA = "0x8FCE")]
		private void HandleTurnStateChanged()
		{
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x0000C840 File Offset: 0x0000AA40
		// (set) Token: 0x06004119 RID: 16665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD5")]
		public float Timeout
		{
			[Token(Token = "0x6004118")]
			[Address(RVA = "0x8FCF", Offset = "0x8FCF", VA = "0x8FCF")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004119")]
			[Address(RVA = "0x8FD0", Offset = "0x8FD0", VA = "0x8FD0")]
			private set
			{
			}
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600411A")]
		[Address(RVA = "0x8FD1", Offset = "0x8FD1", VA = "0x8FD1")]
		private IEnumerator HandleBackTimeCoroutine(float duration)
		{
			return null;
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x0000C858 File Offset: 0x0000AA58
		[Token(Token = "0x600411B")]
		[Address(RVA = "0x8FD2", Offset = "0x8FD2", VA = "0x8FD2")]
		private bool TryGetTurnPointerElement(out TurnClock clock)
		{
			return default(bool);
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411C")]
		[Address(RVA = "0x8FD3", Offset = "0x8FD3", VA = "0x8FD3")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411D")]
		[Address(RVA = "0x8FD4", Offset = "0x8FD4", VA = "0x8FD4")]
		private void Awake()
		{
		}

		// Token: 0x0600411E RID: 16670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411E")]
		[Address(RVA = "0x8FD5", Offset = "0x8FD5", VA = "0x8FD5", Slot = "11")]
		public void SetTurnState(TurnStates state, float timeout)
		{
		}

		// Token: 0x0600411F RID: 16671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411F")]
		[Address(RVA = "0x8FD6", Offset = "0x8FD6", VA = "0x8FD6", Slot = "12")]
		public void Stop()
		{
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004120")]
		[Address(RVA = "0x8FD7", Offset = "0x8FD7", VA = "0x8FD7")]
		public TurnStatePointerWhitTurnClock()
		{
		}

		// Token: 0x0400241E RID: 9246
		[Token(Token = "0x400241E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TurnClock _leftTurnView;

		// Token: 0x0400241F RID: 9247
		[Token(Token = "0x400241F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TurnClock _rightTurnView;

		// Token: 0x04002420 RID: 9248
		[Token(Token = "0x4002420")]
		[FieldOffset(Offset = "0x18")]
		private TurnStates _turnState;

		// Token: 0x04002423 RID: 9251
		[Token(Token = "0x4002423")]
		[FieldOffset(Offset = "0x24")]
		private Coroutine _timeoutCoroutine;

		// Token: 0x04002424 RID: 9252
		[Token(Token = "0x4002424")]
		[FieldOffset(Offset = "0x28")]
		private float _timeout;
	}
}
