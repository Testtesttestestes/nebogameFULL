using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Outline
{
	// Token: 0x0200046E RID: 1134
	[Token(Token = "0x200046E")]
	public class PulseAnimationSimple : AbstractGuideOutline
	{
		// Token: 0x06001AE7 RID: 6887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE7")]
		[Address(RVA = "0x6C71", Offset = "0x6C71", VA = "0x6C71", Slot = "5")]
		public override void StartAnimation(float delay)
		{
		/* --- GHIDRA: StartAnimation ---
		void Gameplay_Tutorial_Guide_View_Outline_PulseAnimationSimple__StartAnimation
		               (int param1,undefined4 param2)
		
		{
		  Utils_TweenContainer__AddTween(*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE8")]
		[Address(RVA = "0x6C72", Offset = "0x6C72", VA = "0x6C72", Slot = "6")]
		public override void StopAnimation()
		{
		/* --- GHIDRA: StopAnimation ---
		void Gameplay_Tutorial_Guide_View_Outline_PulseAnimationSimple__StopAnimation
		               (int param1,float param2,float param3,undefined4 param4)
		
		{
		  float fVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int iVar3;
		  undefined8 uVar4;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  fVar1 = UnityEngine_Camera__set_orthographicSize
		                    (*(float *)(param1 + 0x14),
		                     *(float *)(param1 + 0x14) -
		                     (*(float *)(param1 + 0x18) + *(float *)(param1 + 0x18)),0);
		  iVar2 = *(int *)(*(int *)(param1 + 0x1c) + 8);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    uVar4 = CONCAT44(fVar1 * param3,fVar1 * param2);
		    iVar3 = 0;
		    do {
		      param1_00 = UnityEngine_UI_Graphic__get_depth(*(undefined4 *)(iVar2 + iVar3 * 4 + 0x10),0);
		      local_10 = uVar4;
		      local_8 = uVar4;
		      UnityEngine_RectTransform__get_sizeDelta(param1_00,&local_10,0);
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x6C73", Offset = "0x6C73", VA = "0x6C73", Slot = "4")]
		protected override void HandleSizeChanged(float width, float height)
		{
		/* --- GHIDRA: HandleSizeChanged ---
		void Gameplay_Tutorial_Guide_View_Outline_PulseAnimationSimple__HandleSizeChanged
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58466 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_View_Outline_PulseAnimation_TypeInfo);
		    DAT_ram_00a58466 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x14) = 0x41e0000043800000;
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
		  *(int *)(param1 + 0x1c) = iVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x6C74", Offset = "0x6C74", VA = "0x6C74")]
		public PulseAnimationSimple()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_View_Outline_PulseAnimationSimple___ctor
		               (int param1,float param2,float param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  float fVar3;
		  undefined8 local_10;
		  float4 local_8;
		  float4 local_4;
		  
		  iVar2 = 0;
		  iVar1 = *(int *)(*(int *)(param1 + 0x18) + 8);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      param1_00 = UnityEngine_UI_Graphic__get_depth(*(undefined4 *)(iVar1 + iVar2 * 4 + 0x10),0);
		      fVar3 = *(float *)(param1 + 0x14) + *(float *)(param1 + 0x14);
		      local_4 = (float4)(fVar3 + param3);
		      local_8 = (float4)(fVar3 + param2);
		      local_10 = CONCAT44(local_4,local_8);
		      UnityEngine_RectTransform__get_sizeDelta(param1_00,&local_10,0);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000E7A RID: 3706
		[Token(Token = "0x4000E7A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _textureSize;

		// Token: 0x04000E7B RID: 3707
		[Token(Token = "0x4000E7B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _indent;

		// Token: 0x04000E7C RID: 3708
		[Token(Token = "0x4000E7C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PulseAnimation _animation;
	}
}
