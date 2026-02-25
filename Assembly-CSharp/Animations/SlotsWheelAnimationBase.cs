using System;
using System.Runtime.CompilerServices;
using Core.Animations;
using Il2CppDummyDll;
using Spine;
using UnityEngine;

namespace Animations
{
	// Token: 0x02001333 RID: 4915
	[Token(Token = "0x2001333")]
	public class SlotsWheelAnimationBase : GameSpineUiAnimation
	{
		// Token: 0x17001772 RID: 6002
		// (get) Token: 0x06007464 RID: 29796 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001772")]
		public virtual string Prefix
		{
			[Token(Token = "0x6007464")]
			[Address(RVA = "0xBE30", Offset = "0xBE30", VA = "0xBE30", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06007465 RID: 29797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007465")]
		[Address(RVA = "0xBE31", Offset = "0xBE31", VA = "0xBE31")]
		public void Init(SlotsWheelAnimationBase.SlotsWheelState state)
		{
		}

		// Token: 0x06007466 RID: 29798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007466")]
		[Address(RVA = "0xBE32", Offset = "0xBE32", VA = "0xBE32")]
		public void Spin()
		{
		}

		// Token: 0x06007467 RID: 29799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007467")]
		[Address(RVA = "0xBE33", Offset = "0xBE33", VA = "0xBE33")]
		public void Stop(SlotsWheelAnimationBase.SlotsWheelState state)
		{
		}

		// Token: 0x06007468 RID: 29800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007468")]
		[Address(RVA = "0xBE34", Offset = "0xBE34", VA = "0xBE34")]
		public void Reset(SlotsWheelAnimationBase.SlotsWheelState state)
		{
		}

		// Token: 0x06007469 RID: 29801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007469")]
		[Address(RVA = "0xBE35", Offset = "0xBE35", VA = "0xBE35")]
		private void AnimationStopStateOnComplete(TrackEntry trackEntry)
		{
		}

		// Token: 0x0600746A RID: 29802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600746A")]
		[Address(RVA = "0xBE36", Offset = "0xBE36", VA = "0xBE36")]
		private void AnimationStateOnComplete(TrackEntry trackEntry)
		{
		}

		// Token: 0x0600746B RID: 29803 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600746B")]
		[Address(RVA = "0xBE37", Offset = "0xBE37", VA = "0xBE37")]
		private string GetStartAnimationName(SlotsWheelAnimationBase.SlotsWheelState state)
		{
			return null;
		}

		// Token: 0x0600746C RID: 29804 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600746C")]
		[Address(RVA = "0xBE38", Offset = "0xBE38", VA = "0xBE38")]
		private string GetStopAnimationName(SlotsWheelAnimationBase.SlotsWheelState state)
		{
			return null;
		}

		// Token: 0x0600746D RID: 29805 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600746D")]
		[Address(RVA = "0xBE39", Offset = "0xBE39", VA = "0xBE39")]
		private string GetNameWithPrefix(string name)
		{
			return null;
		}

		// Token: 0x0600746E RID: 29806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600746E")]
		[Address(RVA = "0xBE3A", Offset = "0xBE3A", VA = "0xBE3A")]
		public SlotsWheelAnimationBase()
		{
		}

		// Token: 0x04003CFD RID: 15613
		[Token(Token = "0x4003CFD")]
		public const string CHEST_START = "chest_start";

		// Token: 0x04003CFE RID: 15614
		[Token(Token = "0x4003CFE")]
		public const string CHEST_STOP = "chest_stop";

		// Token: 0x04003CFF RID: 15615
		[Token(Token = "0x4003CFF")]
		public const string CLOVER_START = "clover_start";

		// Token: 0x04003D00 RID: 15616
		[Token(Token = "0x4003D00")]
		public const string CLOVER_STOP = "clover_stop";

		// Token: 0x04003D01 RID: 15617
		[Token(Token = "0x4003D01")]
		public const string DIAMOND_START = "diamond_start";

		// Token: 0x04003D02 RID: 15618
		[Token(Token = "0x4003D02")]
		public const string DIAMOND_STOP = "diamond_stop";

		// Token: 0x04003D03 RID: 15619
		[Token(Token = "0x4003D03")]
		public const string ENERGY_START = "energy_start";

		// Token: 0x04003D04 RID: 15620
		[Token(Token = "0x4003D04")]
		public const string ENERGY_STOP = "energy_stop";

		// Token: 0x04003D05 RID: 15621
		[Token(Token = "0x4003D05")]
		public const string ETHYR_START = "ethyr_start";

		// Token: 0x04003D06 RID: 15622
		[Token(Token = "0x4003D06")]
		public const string ETHYR_STOP = "ethyr_stop";

		// Token: 0x04003D07 RID: 15623
		[Token(Token = "0x4003D07")]
		public const string CRYSTAL_START = "crystal_start";

		// Token: 0x04003D08 RID: 15624
		[Token(Token = "0x4003D08")]
		public const string CRYSTAL_STOP = "crystal_stop";

		// Token: 0x04003D09 RID: 15625
		[Token(Token = "0x4003D09")]
		public const string SPIN = "spin";

		// Token: 0x04003D0A RID: 15626
		[Token(Token = "0x4003D0A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ParticleSystem _ps1;

		// Token: 0x04003D0B RID: 15627
		[Token(Token = "0x4003D0B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ParticleSystem _ps2;

		// Token: 0x04003D0C RID: 15628
		[Token(Token = "0x4003D0C")]
		[FieldOffset(Offset = "0x3C")]
		private SlotsWheelAnimationBase.SlotsWheelState _currentState;

		// Token: 0x02001334 RID: 4916
		[Token(Token = "0x2001334")]
		public enum SlotsWheelState
		{
			// Token: 0x04003D0E RID: 15630
			[Token(Token = "0x4003D0E")]
			DiamondChest = 5,
			// Token: 0x04003D0F RID: 15631
			[Token(Token = "0x4003D0F")]
			Clover = 1,
			// Token: 0x04003D10 RID: 15632
			[Token(Token = "0x4003D10")]
			Diamond = 3,
			// Token: 0x04003D11 RID: 15633
			[Token(Token = "0x4003D11")]
			Energy,
			// Token: 0x04003D12 RID: 15634
			[Token(Token = "0x4003D12")]
			Ethyr = 6,
			// Token: 0x04003D13 RID: 15635
			[Token(Token = "0x4003D13")]
			Crystal = 2,
			// Token: 0x04003D14 RID: 15636
			[Token(Token = "0x4003D14")]
			OnyxChest = 7
		}
	}
}
