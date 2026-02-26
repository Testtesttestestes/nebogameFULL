using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Outline
{
	// Token: 0x0200046C RID: 1132
	[Token(Token = "0x200046C")]
	public class GuideOutlineRect : AbstractGuideOutline
	{
		// Token: 0x06001ADE RID: 6878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x6C68", Offset = "0x6C68", VA = "0x6C68", Slot = "4")]
		protected override void HandleSizeChanged(float width, float height)
		{
		/* --- GHIDRA: HandleSizeChanged ---
		void Gameplay_Tutorial_Guide_View_Outline_GuideOutlineRect__HandleSizeChanged
		               (int param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58463 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tutorial_Guide_View_Outline_GuideOutlineRect_StartAnimationInternal__
		              );
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a58463 = '\x01';
		  }
		  if (*(int *)(param1 + 0x2c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x2c),0,0);
		    *(undefined4 *)(param1 + 0x2c) = 0;
		  }
		  uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar1,param1,
		             Method_Gameplay_Tutorial_Guide_View_Outline_GuideOutlineRect_StartAnimationInternal__,0
		            );
		  uVar1 = DG_Tweening_DOVirtual__EasedValue(param2,uVar1,1,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x6C69", Offset = "0x6C69", VA = "0x6C69", Slot = "5")]
		public override void StartAnimation(float delay)
		{
		/* --- GHIDRA: StartAnimation ---
		void Gameplay_Tutorial_Guide_View_Outline_GuideOutlineRect__StartAnimation
		               (int param1,undefined4 param2)
		
		{
		  UnityEngine_ParticleSystem__Simulate(*(undefined4 *)(param1 + 0x14),1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x6C6A", Offset = "0x6C6A", VA = "0x6C6A")]
		private void StartAnimationInternal()
		{
		/* --- GHIDRA: StartAnimationInternal ---
		void Gameplay_Tutorial_Guide_View_Outline_GuideOutlineRect__StartAnimationInternal
		               (int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x2c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x2c),0,0);
		    *(undefined4 *)(param1 + 0x2c) = 0;
		  }
		  UnityEngine_ParticleSystem__Play(*(undefined4 *)(param1 + 0x14),1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x6C6B", Offset = "0x6C6B", VA = "0x6C6B", Slot = "6")]
		public override void StopAnimation()
		{
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x6C6C", Offset = "0x6C6C", VA = "0x6C6C")]
		public GuideOutlineRect()
		{
		}

		// Token: 0x04000E6F RID: 3695
		[Token(Token = "0x4000E6F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ParticleSystem _ps;

		// Token: 0x04000E70 RID: 3696
		[Token(Token = "0x4000E70")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem _psTop;

		// Token: 0x04000E71 RID: 3697
		[Token(Token = "0x4000E71")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ParticleSystem _psLeft;

		// Token: 0x04000E72 RID: 3698
		[Token(Token = "0x4000E72")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem _psBottom;

		// Token: 0x04000E73 RID: 3699
		[Token(Token = "0x4000E73")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ParticleSystem _psRight;

		// Token: 0x04000E74 RID: 3700
		[Token(Token = "0x4000E74")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _particlesPerPixel;

		// Token: 0x04000E75 RID: 3701
		[Token(Token = "0x4000E75")]
		[FieldOffset(Offset = "0x2C")]
		private Tween _delayedCall;
	}
}
