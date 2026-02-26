using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Outline
{
	// Token: 0x0200046F RID: 1135
	[Token(Token = "0x200046F")]
	public class PulseAnimationSliced : AbstractGuideOutline
	{
		// Token: 0x06001AEB RID: 6891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEB")]
		[Address(RVA = "0x6C75", Offset = "0x6C75", VA = "0x6C75", Slot = "4")]
		protected override void HandleSizeChanged(float width, float height)
		{
		/* --- GHIDRA: HandleSizeChanged ---
		void Gameplay_Tutorial_Guide_View_Outline_PulseAnimationSliced__HandleSizeChanged
		               (int param1,float param2,undefined4 param3)
		
		{
		  Gameplay_Tutorial_Guide_View_Outline_PulseAnimation__get_Images
		            (*(undefined4 *)(param1 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEC")]
		[Address(RVA = "0x6C76", Offset = "0x6C76", VA = "0x6C76", Slot = "5")]
		public override void StartAnimation(float delay)
		{
		/* --- GHIDRA: StartAnimation ---
		void Gameplay_Tutorial_Guide_View_Outline_PulseAnimationSliced__StartAnimation
		               (int param1,undefined4 param2)
		
		{
		  Utils_TweenContainer__AddTween(*(undefined4 *)(*(int *)(param1 + 0x18) + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AED")]
		[Address(RVA = "0x6C77", Offset = "0x6C77", VA = "0x6C77", Slot = "6")]
		public override void StopAnimation()
		{
		/* --- GHIDRA: StopAnimation ---
		void Gameplay_Tutorial_Guide_View_Outline_PulseAnimationSliced__StopAnimation
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58467 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_View_Outline_PulseAnimation_TypeInfo);
		    DAT_ram_00a58467 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = 0x41e00000;
		  iVar1 = unnamed_function_1417(Gameplay_Tutorial_Guide_View_Outline_PulseAnimation_TypeInfo);
		  if (DAT_ram_00a58465 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a58465 = '\x01';
		  }
		  *(undefined4 *)(iVar1 + 0x14) = 0x40400000;
		  *(undefined8 *)(iVar1 + 0xc) = 0x4248000042480000;
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(iVar1 + 0x18) = param1_00;
		  *(int *)(param1 + 0x18) = iVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEE")]
		[Address(RVA = "0x6C78", Offset = "0x6C78", VA = "0x6C78")]
		public PulseAnimationSliced()
		{
		}

		// Token: 0x04000E7D RID: 3709
		[Token(Token = "0x4000E7D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _indent;

		// Token: 0x04000E7E RID: 3710
		[Token(Token = "0x4000E7E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PulseAnimation _animation;
	}
}
