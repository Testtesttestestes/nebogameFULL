using System;
using CloudsFly.Movement;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x02001311 RID: 4881
	[Token(Token = "0x2001311")]
	public abstract class WorldObjectEngine : IWorldObjectEngine
	{
		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x060073F5 RID: 29685 RVA: 0x00014D90 File Offset: 0x00012F90
		// (set) Token: 0x060073F6 RID: 29686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001760")]
		protected bool BlockAutoReset
		{
			[Token(Token = "0x60073F5")]
			[Address(RVA = "0xBDCF", Offset = "0xBDCF", VA = "0xBDCF")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60073F6")]
			[Address(RVA = "0xBDD0", Offset = "0xBDD0", VA = "0xBDD0")]
			set
			{
			}
		}

		// Token: 0x060073F7 RID: 29687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073F7")]
		[Address(RVA = "0xBDD1", Offset = "0xBDD1", VA = "0xBDD1", Slot = "4")]
		private void Init(WorldObjectEngineArgs args)
		{
		}

		// Token: 0x060073F8 RID: 29688
		[Token(Token = "0x60073F8")]
		protected abstract void OnInit(WorldObjectEngineArgs args);

		// Token: 0x060073F9 RID: 29689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073F9")]
		[Address(RVA = "0xBDD2", Offset = "0xBDD2", VA = "0xBDD2", Slot = "5")]
		private void LateUpdate()
		{
		}

		// Token: 0x060073FA RID: 29690
		[Token(Token = "0x60073FA")]
		protected abstract void OnLateUpdate();

		// Token: 0x060073FB RID: 29691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073FB")]
		[Address(RVA = "0xBDD3", Offset = "0xBDD3", VA = "0xBDD3", Slot = "6")]
		private void ResetPositions(Vector3 deltaPos)
		{
		}

		// Token: 0x060073FC RID: 29692
		[Token(Token = "0x60073FC")]
		protected abstract void OnResetPositions(Vector3 deltaPos);

		// Token: 0x060073FD RID: 29693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073FD")]
		[Address(RVA = "0xBDD4", Offset = "0xBDD4", VA = "0xBDD4")]
		protected void ResetPositions()
		{
		}

		// Token: 0x060073FE RID: 29694 RVA: 0x00014DA8 File Offset: 0x00012FA8
		[Token(Token = "0x60073FE")]
		[Address(RVA = "0xBDD5", Offset = "0xBDD5", VA = "0xBDD5")]
		protected float GetRandomRange(float distance, float left, float right)
		{
			return 0f;
		}

		// Token: 0x060073FF RID: 29695 RVA: 0x00014DC0 File Offset: 0x00012FC0
		[Token(Token = "0x60073FF")]
		[Address(RVA = "0xBDD6", Offset = "0xBDD6", VA = "0xBDD6")]
		protected float GetRandom(float distance)
		{
			return 0f;
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007400")]
		[Address(RVA = "0xBDD7", Offset = "0xBDD7", VA = "0xBDD7")]
		protected WorldObjectEngine()
		{
		}

		// Token: 0x04003CBB RID: 15547
		[Token(Token = "0x4003CBB")]
		[FieldOffset(Offset = "0x8")]
		protected Camera _camera;

		// Token: 0x04003CBC RID: 15548
		[Token(Token = "0x4003CBC")]
		[FieldOffset(Offset = "0xC")]
		private Func<float, float, float, float> _getRandomRange;

		// Token: 0x04003CBD RID: 15549
		[Token(Token = "0x4003CBD")]
		[FieldOffset(Offset = "0x10")]
		private Func<float, float> _getRandom;

		// Token: 0x04003CBE RID: 15550
		[Token(Token = "0x4003CBE")]
		[FieldOffset(Offset = "0x14")]
		private Func<bool> _getBlockAutoReset;

		// Token: 0x04003CBF RID: 15551
		[Token(Token = "0x4003CBF")]
		[FieldOffset(Offset = "0x18")]
		private Action<bool> _setBlockAutoReset;

		// Token: 0x04003CC0 RID: 15552
		[Token(Token = "0x4003CC0")]
		[FieldOffset(Offset = "0x1C")]
		private Action _resetPositions;

		// Token: 0x04003CC1 RID: 15553
		[Token(Token = "0x4003CC1")]
		[FieldOffset(Offset = "0x20")]
		protected WorldMovementResolver _movementResolver;
	}
}
