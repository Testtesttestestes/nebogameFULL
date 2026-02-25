using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Animations;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View
{
	// Token: 0x0200051B RID: 1307
	[Token(Token = "0x200051B")]
	[RequireComponent(typeof(Button))]
	public class SlotWheelsView : MonoBehaviour
	{
		// Token: 0x14000138 RID: 312
		// (add) Token: 0x06001F1A RID: 7962 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001F1B RID: 7963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000138")]
		public event Action WheelsStoppedSpinningEvent
		{
			[Token(Token = "0x6001F1A")]
			[Address(RVA = "0x7081", Offset = "0x7081", VA = "0x7081")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001F1B")]
			[Address(RVA = "0x7082", Offset = "0x7082", VA = "0x7082")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0x7083", Offset = "0x7083", VA = "0x7083")]
		private void Start()
		{
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1D")]
		[Address(RVA = "0x7084", Offset = "0x7084", VA = "0x7084")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1E")]
		[Address(RVA = "0x7085", Offset = "0x7085", VA = "0x7085")]
		public void Init()
		{
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0x7086", Offset = "0x7086", VA = "0x7086")]
		public void StartSpinning(IList<uint> resultSlotIds)
		{
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F20")]
		[Address(RVA = "0x7087", Offset = "0x7087", VA = "0x7087")]
		public void UpdateSpinButton(Action callback, string localizationKey)
		{
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x7088", Offset = "0x7088", VA = "0x7088")]
		public void StopSpin()
		{
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F22")]
		[Address(RVA = "0x7089", Offset = "0x7089", VA = "0x7089")]
		private void StopSpin(IList<uint> resultSlotIds)
		{
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x708A", Offset = "0x708A", VA = "0x708A")]
		public void AbortSpin()
		{
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001F24")]
		[Address(RVA = "0x708B", Offset = "0x708B", VA = "0x708B")]
		private IEnumerator StopSpinDelayed(float delay, IList<uint> resultSlotIds)
		{
			return null;
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x708C", Offset = "0x708C", VA = "0x708C")]
		private IEnumerator StoppingSpin(IList<uint> resultSlotIds)
		{
			return null;
		}

		// Token: 0x06001F26 RID: 7974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F26")]
		[Address(RVA = "0x708D", Offset = "0x708D", VA = "0x708D")]
		public SlotWheelsView()
		{
		}

		// Token: 0x040010DC RID: 4316
		[Token(Token = "0x40010DC")]
		private const float STOP_SPIN_DELAY = 2f;

		// Token: 0x040010DD RID: 4317
		[Token(Token = "0x40010DD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SlotsWheelAnimationBase _wheel1;

		// Token: 0x040010DE RID: 4318
		[Token(Token = "0x40010DE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SlotsWheelAnimationBase _wheel2;

		// Token: 0x040010DF RID: 4319
		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SlotsWheelAnimationBase _wheel3;

		// Token: 0x040010E0 RID: 4320
		[Token(Token = "0x40010E0")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _spinButton;

		// Token: 0x040010E1 RID: 4321
		[Token(Token = "0x40010E1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _areaButton;

		// Token: 0x040010E3 RID: 4323
		[Token(Token = "0x40010E3")]
		[FieldOffset(Offset = "0x28")]
		private Coroutine _stopSpinDelayedRoutine;

		// Token: 0x040010E4 RID: 4324
		[Token(Token = "0x40010E4")]
		[FieldOffset(Offset = "0x2C")]
		private Coroutine _stoppingSpinRoutine;

		// Token: 0x040010E5 RID: 4325
		[Token(Token = "0x40010E5")]
		[FieldOffset(Offset = "0x30")]
		private IList<uint> _resultSlotIds;

		// Token: 0x040010E6 RID: 4326
		[Token(Token = "0x40010E6")]
		[FieldOffset(Offset = "0x34")]
		private bool _stoppingFlag;
	}
}
