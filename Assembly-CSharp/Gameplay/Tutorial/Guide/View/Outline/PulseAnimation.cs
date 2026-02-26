using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Tutorial.Guide.View.Outline
{
	// Token: 0x0200046D RID: 1133
	[Token(Token = "0x200046D")]
	[Serializable]
	public class PulseAnimation
	{
		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004AE")]
		public Image[] Images
		{
			[Token(Token = "0x6001AE3")]
			[Address(RVA = "0x6C6D", Offset = "0x6C6D", VA = "0x6C6D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE4")]
		[Address(RVA = "0x6C6E", Offset = "0x6C6E", VA = "0x6C6E")]
		public void Play()
		{
		/* --- GHIDRA: Play ---
		void Gameplay_Tutorial_Guide_View_Outline_PulseAnimation__Play(int param1,undefined4 param2)
		
		{
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE5")]
		[Address(RVA = "0x6C6F", Offset = "0x6C6F", VA = "0x6C6F")]
		public void Stop()
		{
		/* --- GHIDRA: Stop ---
		void Gameplay_Tutorial_Guide_View_Outline_PulseAnimation__Stop(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58465 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TweenContainer_TypeInfo);
		    DAT_ram_00a58465 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = 0x40400000;
		  *(undefined8 *)(param1 + 0xc) = 0x4248000042480000;
		  param1_00 = unnamed_function_1417(Utils_TweenContainer_TypeInfo);
		  Utils_TweenContainer__Dispose(param1_00,0);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0x6C70", Offset = "0x6C70", VA = "0x6C70")]
		public PulseAnimation()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tutorial_Guide_View_Outline_PulseAnimation___ctor
		               (int param1,float param2,undefined4 param3)
		
		{
		  Gameplay_Tutorial_Guide_View_Outline_PulseAnimation__get_Images
		            (*(undefined4 *)(param1 + 0x1c),param1);
		  return;
		}
		*/

		}

		// Token: 0x04000E76 RID: 3702
		[Token(Token = "0x4000E76")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Image[] _images;

		// Token: 0x04000E77 RID: 3703
		[Token(Token = "0x4000E77")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Vector2 _sizeOffset;

		// Token: 0x04000E78 RID: 3704
		[Token(Token = "0x4000E78")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _interval;

		// Token: 0x04000E79 RID: 3705
		[Token(Token = "0x4000E79")]
		[FieldOffset(Offset = "0x18")]
		private TweenContainer _tweenContainer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Images ---
		void Gameplay_Tutorial_Guide_View_Outline_PulseAnimation__get_Images(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  float fVar2;
		  int iVar3;
		  float param2_01;
		  int iVar4;
		  int *param1_00;
		  undefined8 local_40;
		  undefined8 local_38;
		  ulonglong local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  uint local_18;
		  undefined8 local_10;
		  uint local_8;
		  undefined4 local_4;
		  
		  iVar4 = 0;
		  param2_01 = 0.0;
		  if (DAT_ram_00a58464 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Color__Color__ColorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Vector2__Vector2__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a58464 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 8);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      param1_00 = *(int **)(iVar3 + iVar4 * 4 + 0x10);
		      (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x170) * 4))
		                (&local_10,param1_00,*(undefined4 *)(*param1_00 + 0x174));
		      local_18 = local_8;
		      local_20 = local_10;
		      local_4 = 0;
		      local_30 = (ulonglong)local_8;
		      local_38 = local_10;
		      (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x178) * 4))
		                (param1_00,&local_38,*(undefined4 *)(*param1_00 + 0x17c));
		      uVar1 = UnityEngine_UI_Graphic__get_depth(param1_00,0);
		      param2_00 = UnityEngine_UI_Graphic__get_depth(param1_00,0);
		      UnityEngine_RectTransform__set_anchoredPosition(&local_10,param2_00,0);
		      local_40 = CONCAT44((float)((ulonglong)local_10 >> 0x20) +
		                          (float)((ulonglong)*(undefined8 *)(param1 + 0xc) >> 0x20),
		                          (float)local_10 + (float)*(undefined8 *)(param1 + 0xc));
		      local_28 = local_40;
		      uVar1 = DG_Tweening_DOTweenModuleUI__DOPivotY(uVar1,&local_40,*(float *)(param1 + 0x14),0,0);
		      uVar1 = DG_Tweening_ShortcutExtensions__DOScale
		                        (uVar1,1,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector2__Vector2__VectorOptions____
		                        );
		      uVar1 = DG_Tweening_DOTweenModuleUI__DOFade
		                        (uVar1,param2_01,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Vector2__Vector2__VectorOptions____
		                        );
		      uVar1 = DG_Tweening_TweenSettingsExtensions__SetLink_object_
		                        (uVar1,0xffffffff,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Vector2__Vector2__VectorOptions____
		                        );
		      Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x18),uVar1,0);
		      uVar1 = func_ii_9125(param1_00,1.0,*(float *)(param1 + 0x14) * 0.5,0);
		      uVar1 = DG_Tweening_DOTweenModuleUI__DOFade
		                        (uVar1,param2_01,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_Color__Color__ColorOptions____
		                        );
		      uVar1 = DG_Tweening_TweenSettingsExtensions__SetLoops_object_
		                        (uVar1,0xffffffff,1,
		                         Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Color__Color__ColorOptions____
		                        );
		      Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x18),uVar1,0);
		      fVar2 = Utils_MathUtils_MathUtils__SaferDivide
		                        (*(float *)(param1 + 0x14),*(undefined4 *)(*(int *)(param1 + 8) + 0xc),0);
		      param2_01 = param2_01 + fVar2;
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

}
