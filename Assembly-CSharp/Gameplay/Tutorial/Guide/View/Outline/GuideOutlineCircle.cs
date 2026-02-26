using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Outline
{
	// Token: 0x0200046A RID: 1130
	[Token(Token = "0x200046A")]
	public class GuideOutlineCircle : AbstractGuideOutline
	{
		// Token: 0x06001AD4 RID: 6868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0x6C5E", Offset = "0x6C5E", VA = "0x6C5E", Slot = "4")]
		protected override void HandleSizeChanged(float width, float height)
		{
		/* --- GHIDRA: HandleSizeChanged ---
		void Gameplay_Tutorial_Guide_View_Outline_GuideOutlineCircle__HandleSizeChanged
		               (int param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58461 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_Outline_GuideOutlineCircle_StartAnimationInternal__
		              );
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a58461 = '\x01';
		  }
		  if (*(int *)(param1 + 0x20) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x20),0,0);
		    *(undefined4 *)(param1 + 0x20) = 0;
		  }
		  uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_Outline_GuideOutlineCircle_StartAnimationInternal__
		             ,0);
		  uVar1 = DG_Tweening_DOVirtual__EasedValue(param2,uVar1,1,0);
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0x6C5F", Offset = "0x6C5F", VA = "0x6C5F", Slot = "5")]
		public override void StartAnimation(float delay)
		{
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x6C60", Offset = "0x6C60", VA = "0x6C60")]
		private void StartAnimationInternal()
		{
		/* --- GHIDRA: StartAnimationInternal ---
		void Gameplay_Tutorial_Guide_View_Outline_GuideOutlineCircle__StartAnimationInternal
		               (int param1,undefined4 param2)
		
		{
		  UnityEngine_ParticleSystem__Play(*(undefined4 *)(param1 + 0x14),1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0x6C61", Offset = "0x6C61", VA = "0x6C61", Slot = "6")]
		public override void StopAnimation()
		{
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0x6C62", Offset = "0x6C62", VA = "0x6C62")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x6C63", Offset = "0x6C63", VA = "0x6C63")]
		public GuideOutlineCircle()
		{
		}

		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000E6B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ParticleSystem _psIdle;

		// Token: 0x04000E6C RID: 3692
		[Token(Token = "0x4000E6C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem _psMain;

		// Token: 0x04000E6D RID: 3693
		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _particlesPerPixel;

		// Token: 0x04000E6E RID: 3694
		[Token(Token = "0x4000E6E")]
		[FieldOffset(Offset = "0x20")]
		private Tween _delayedCall;
	}
}
