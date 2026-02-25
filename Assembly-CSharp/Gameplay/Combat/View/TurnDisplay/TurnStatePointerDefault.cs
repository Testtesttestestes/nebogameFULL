using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Combat;
using TMPro;
using UnityEngine;
using Utils;

namespace Gameplay.Combat.View.TurnDisplay
{
	// Token: 0x02000938 RID: 2360
	[Token(Token = "0x2000938")]
	public class TurnStatePointerDefault : MonoBehaviour, ITurnStatePointer
	{
		// Token: 0x1400017A RID: 378
		// (add) Token: 0x060037B8 RID: 14264 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060037B9 RID: 14265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400017A")]
		public event Action TimeOutEvent
		{
			[Token(Token = "0x60037B8")]
			[Address(RVA = "0x879A", Offset = "0x879A", VA = "0x879A", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60037B9")]
			[Address(RVA = "0x879B", Offset = "0x879B", VA = "0x879B", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400017B RID: 379
		// (add) Token: 0x060037BA RID: 14266 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060037BB RID: 14267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400017B")]
		public event Action TurnStateChangedEvent
		{
			[Token(Token = "0x60037BA")]
			[Address(RVA = "0x879C", Offset = "0x879C", VA = "0x879C", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60037BB")]
			[Address(RVA = "0x879D", Offset = "0x879D", VA = "0x879D", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060037BC RID: 14268 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060037BD RID: 14269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFD")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x60037BC")]
			[Address(RVA = "0x879E", Offset = "0x879E", VA = "0x879E", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037BD")]
			[Address(RVA = "0x879F", Offset = "0x879F", VA = "0x879F", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060037BE RID: 14270 RVA: 0x0000B2C8 File Offset: 0x000094C8
		// (set) Token: 0x060037BF RID: 14271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFE")]
		public TurnStates TurnState
		{
			[Token(Token = "0x60037BE")]
			[Address(RVA = "0x87A0", Offset = "0x87A0", VA = "0x87A0", Slot = "8")]
			get
			{
				return TurnStates.NoTurn;
			}
			[Token(Token = "0x60037BF")]
			[Address(RVA = "0x87A1", Offset = "0x87A1", VA = "0x87A1")]
			private set
			{
			}
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C0")]
		[Address(RVA = "0x87A2", Offset = "0x87A2", VA = "0x87A2")]
		private void HandleTurnStateChanged()
		{
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060037C1 RID: 14273 RVA: 0x0000B2E0 File Offset: 0x000094E0
		// (set) Token: 0x060037C2 RID: 14274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFF")]
		public float Timeout
		{
			[Token(Token = "0x60037C1")]
			[Address(RVA = "0x87A3", Offset = "0x87A3", VA = "0x87A3")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60037C2")]
			[Address(RVA = "0x87A4", Offset = "0x87A4", VA = "0x87A4")]
			private set
			{
			}
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60037C3")]
		[Address(RVA = "0x87A5", Offset = "0x87A5", VA = "0x87A5")]
		private IEnumerator HandleBackTimeCoroutine(TextMeshProUGUI display, BackTime backTime)
		{
			return null;
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[Token(Token = "0x60037C4")]
		[Address(RVA = "0x87A6", Offset = "0x87A6", VA = "0x87A6")]
		private bool TryGetTurnPointerElement(out TextMeshProUGUI display)
		{
			return default(bool);
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C5")]
		[Address(RVA = "0x87A7", Offset = "0x87A7", VA = "0x87A7")]
		private void Awake()
		{
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C6")]
		[Address(RVA = "0x87A8", Offset = "0x87A8", VA = "0x87A8", Slot = "11")]
		public void SetTurnState(TurnStates state, float timeout)
		{
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C7")]
		[Address(RVA = "0x87A9", Offset = "0x87A9", VA = "0x87A9", Slot = "12")]
		public void Stop()
		{
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037C8")]
		[Address(RVA = "0x87AA", Offset = "0x87AA", VA = "0x87AA")]
		public TurnStatePointerDefault()
		{
		}

		// Token: 0x04001EC9 RID: 7881
		[Token(Token = "0x4001EC9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _leftTextField;

		// Token: 0x04001ECA RID: 7882
		[Token(Token = "0x4001ECA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _rightTextField;

		// Token: 0x04001ECB RID: 7883
		[Token(Token = "0x4001ECB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _leftTurnView;

		// Token: 0x04001ECC RID: 7884
		[Token(Token = "0x4001ECC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _rightTurnView;

		// Token: 0x04001ECD RID: 7885
		[Token(Token = "0x4001ECD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _timeLeftWarningValue;

		// Token: 0x04001ECE RID: 7886
		[Token(Token = "0x4001ECE")]
		[FieldOffset(Offset = "0x24")]
		private TurnStates _turnState;

		// Token: 0x04001ED2 RID: 7890
		[Token(Token = "0x4001ED2")]
		[FieldOffset(Offset = "0x34")]
		private Coroutine _timeoutCoroutine;

		// Token: 0x04001ED3 RID: 7891
		[Token(Token = "0x4001ED3")]
		[FieldOffset(Offset = "0x38")]
		private float _timeout;
	}
}
