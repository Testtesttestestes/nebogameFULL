using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Misc
{
	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x20001D6")]
	[AddComponentMenu("UI/Dynamic Grid Layout Group")]
	public class DynamicGridLayoutGroup : GridLayoutGroup
	{
		// Token: 0x06000C4C RID: 3148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4C")]
		[Address(RVA = "0x5F5B", Offset = "0x5F5B", VA = "0x5F5B", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		/* --- GHIDRA: SetLayoutHorizontal ---
		void UI_Misc_DynamicGridLayoutGroup__SetLayoutHorizontal(undefined4 param1,undefined4 param2)
		
		{
		  UI_Misc_DynamicGridLayoutGroup__SetLayoutVertical(param1,1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x5F5C", Offset = "0x5F5C", VA = "0x5F5C", Slot = "38")]
		public override void SetLayoutVertical()
		{
		/* --- GHIDRA: SetLayoutVertical ---
		void UI_Misc_DynamicGridLayoutGroup__SetLayoutVertical(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  float fVar5;
		  int iVar6;
		  uint uVar7;
		  float *pfVar8;
		  float fVar9;
		  float *pfVar10;
		  float fVar11;
		  float fVar12;
		  float fVar13;
		  int iVar14;
		  int iVar15;
		  int iVar16;
		  float fVar17;
		  int iVar18;
		  int iVar19;
		  int iVar20;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined1 auStack_28 [8];
		  float4 local_20;
		  float4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63910 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RectTransform__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RectTransform__get_Item__);
		    DAT_ram_00a63910 = '\x01';
		  }
		  iVar6 = *(int *)(*(int *)(param1 + 0x38) + 0xc);
		  if (param2 == 0) {
		    if (0 < iVar6) {
		      iVar1 = 0;
		      do {
		        uVar4 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x38),iVar1,
		                           Method_System_Collections_Generic_List_RectTransform__get_Item__);
		        if (DAT_ram_00a648f4 == '\0') {
		          Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		          DAT_ram_00a648f4 = '\x01';
		        }
		        local_30 = *(undefined8 *)(*(int *)(UnityEngine_Vector2_TypeInfo + 0x5c) + 0x10);
		        local_8 = local_30;
		        UnityEngine_RectTransform__get_anchorMin(uVar4,&local_30,0);
		        if (DAT_ram_00a648f4 == '\0') {
		          Mono_Security_ASN1__get_Item(&UnityEngine_Vector2_TypeInfo);
		          DAT_ram_00a648f4 = '\x01';
		        }
		        local_38 = *(undefined8 *)(*(int *)(UnityEngine_Vector2_TypeInfo + 0x5c) + 0x10);
		        local_10 = local_38;
		        UnityEngine_RectTransform__get_anchorMax(uVar4,&local_38,0);
		        local_40 = *(undefined8 *)(param1 + 0x44);
		        local_18 = local_40;
		        UnityEngine_RectTransform__get_sizeDelta(uVar4,&local_40,0);
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != iVar6);
		    }
		  }
		  else {
		    uVar4 = UnityEngine_UI_LayoutGroup__set_childAlignment(param1,0);
		    UnityEngine_RectTransform__remove_reapplyDrivenProperties(auStack_28,uVar4,0);
		    uVar4 = UnityEngine_UI_LayoutGroup__set_childAlignment(param1,0);
		    UnityEngine_RectTransform__remove_reapplyDrivenProperties(auStack_28,uVar4,0);
		    if (*(int *)(param1 + 0x54) == 1) {
		      iVar1 = 1;
		      iVar15 = *(int *)(param1 + 0x58);
		      if (iVar15 < iVar6) {
		        iVar1 = iVar6 / iVar15 + (uint)(0 < iVar6 - (iVar6 / iVar15) * iVar15);
		      }
		    }
		    else if (*(int *)(param1 + 0x54) == 2) {
		      iVar15 = 1;
		      iVar1 = *(int *)(param1 + 0x58);
		      if (iVar1 < iVar6) {
		        iVar15 = iVar6 / iVar1 + (uint)(0 < iVar6 - iVar1 * (iVar6 / iVar1));
		      }
		    }
		    else {
		      iVar1 = 0x7fffffff;
		      iVar15 = 0x7fffffff;
		      if (0.0 < *(float *)(param1 + 0x44) + *(float *)(param1 + 0x4c)) {
		        iVar15 = UnityEngine_RectOffset__set_bottom(*(undefined4 *)(param1 + 0x10),0);
		        fVar17 = *(float *)(param1 + 0x4c);
		        fVar9 = *(float *)(param1 + 0x44);
		        if (DAT_ram_00a648ed == '\0') {
		          Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		          DAT_ram_00a648ed = '\x01';
		        }
		        if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_Math_TypeInfo);
		        }
		        fVar17 = FLOOR((fVar17 + ((float)local_20 - (float)iVar15) + 0.001) / (fVar17 + fVar9));
		        if (ABS(fVar17) < 2.1474836e+09) {
		          iVar18 = (int)fVar17;
		        }
		        else {
		          iVar18 = -0x80000000;
		        }
		        iVar15 = 1;
		        if (1 < iVar18) {
		          iVar15 = iVar18;
		        }
		      }
		      if (0.0 < *(float *)(param1 + 0x48) + *(float *)(param1 + 0x50)) {
		        iVar1 = UnityEngine_RectOffset__get_horizontal(*(undefined4 *)(param1 + 0x10),0);
		        fVar17 = *(float *)(param1 + 0x50);
		        fVar9 = *(float *)(param1 + 0x48);
		        if (DAT_ram_00a648ed == '\0') {
		          Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		          DAT_ram_00a648ed = '\x01';
		        }
		        if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_Math_TypeInfo);
		        }
		        fVar17 = FLOOR((fVar17 + ((float)local_1c - (float)iVar1) + 0.001) / (fVar17 + fVar9));
		        if (ABS(fVar17) < 2.1474836e+09) {
		          iVar18 = (int)fVar17;
		        }
		        else {
		          iVar18 = -0x80000000;
		        }
		        iVar1 = 1;
		        if (1 < iVar18) {
		          iVar1 = iVar18;
		        }
		      }
		    }
		    uVar7 = *(uint *)(param1 + 0x3c);
		    if (*(int *)(param1 + 0x40) == 0) {
		      if (DAT_ram_00a63a16 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		        DAT_ram_00a63a16 = '\x01';
		      }
		      if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Math_TypeInfo);
		      }
		      iVar18 = iVar15;
		      if (iVar6 <= iVar15) {
		        iVar18 = iVar6;
		      }
		      iVar3 = 1;
		      if (0 < iVar15) {
		        iVar3 = iVar18;
		      }
		      fVar17 = CEIL((float)iVar6 / (float)iVar15);
		      if (ABS(fVar17) < 2.1474836e+09) {
		        iVar18 = (int)fVar17;
		      }
		      else {
		        iVar18 = -0x80000000;
		      }
		      iVar2 = iVar1;
		      if (iVar18 <= iVar1) {
		        iVar2 = iVar18;
		      }
		      iVar18 = 1;
		      if (0 < iVar1) {
		        iVar18 = iVar2;
		      }
		    }
		    else {
		      if (DAT_ram_00a63a16 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		        DAT_ram_00a63a16 = '\x01';
		      }
		      if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Math_TypeInfo);
		      }
		      iVar2 = iVar1;
		      if (iVar6 <= iVar1) {
		        iVar2 = iVar6;
		      }
		      fVar17 = CEIL((float)iVar6 / (float)iVar1);
		      if (ABS(fVar17) < 2.1474836e+09) {
		        iVar18 = (int)fVar17;
		      }
		      else {
		        iVar18 = -0x80000000;
		      }
		      iVar19 = iVar15;
		      if (iVar18 <= iVar15) {
		        iVar19 = iVar18;
		      }
		      iVar3 = 1;
		      if (0 < iVar15) {
		        iVar3 = iVar19;
		      }
		      iVar15 = iVar1;
		      iVar18 = 1;
		      if (0 < iVar1) {
		        iVar18 = iVar2;
		      }
		    }
		    pfVar8 = (float *)(param1 + 0x50);
		    fVar9 = *pfVar8;
		    pfVar10 = (float *)(param1 + 0x48);
		    fVar11 = *pfVar10;
		    fVar17 = UnityEngine_UI_LayoutGroup__GetTotalFlexibleSize
		                       (param1,0,*(float *)(param1 + 0x44) * (float)iVar3 +
		                                 *(float *)(param1 + 0x4c) * (float)(iVar3 + -1),0);
		    fVar9 = UnityEngine_UI_LayoutGroup__GetTotalFlexibleSize
		                      (param1,1,fVar11 * (float)iVar18 + fVar9 * (float)(iVar18 + -1),0);
		    fVar11 = *pfVar10;
		    fVar12 = *pfVar8;
		    iVar1 = iVar6 % iVar15;
		    if (iVar6 % iVar15 == 0) {
		      iVar1 = iVar15;
		    }
		    iVar19 = *(int *)(param1 + 0x40);
		    iVar2 = iVar3;
		    if (iVar19 == 0) {
		      iVar2 = iVar1;
		    }
		    fVar5 = UnityEngine_UI_LayoutGroup__GetTotalFlexibleSize
		                      (param1,0,*(float *)(param1 + 0x44) * (float)iVar2 +
		                                *(float *)(param1 + 0x4c) * (float)(iVar2 + -1),0);
		    iVar2 = iVar1;
		    if (iVar19 != 1) {
		      iVar2 = iVar18;
		    }
		    fVar11 = UnityEngine_UI_LayoutGroup__GetTotalFlexibleSize
		                       (param1,1,fVar11 * (float)iVar2 + fVar12 * (float)(iVar2 + -1),0);
		    if (0 < iVar6) {
		      iVar2 = 0;
		      do {
		        fVar13 = fVar9;
		        fVar12 = fVar17;
		        if (iVar6 - iVar1 <= iVar2) {
		          fVar13 = fVar11;
		          fVar12 = fVar5;
		        }
		        iVar19 = iVar2 + 1;
		        if (*(int *)(param1 + 0x40) == 0) {
		          iVar16 = iVar2 % iVar15;
		          iVar14 = iVar2 / iVar15;
		        }
		        else {
		          iVar16 = iVar2 / iVar15;
		          iVar14 = iVar2 - iVar16 * iVar15;
		        }
		        uVar4 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x38),iVar2,
		                           Method_System_Collections_Generic_List_RectTransform__get_Item__);
		        iVar20 = (iVar3 + -1) - iVar16;
		        if ((uVar7 & 0x80000001) != 1) {
		          iVar20 = iVar16;
		        }
		        UnityEngine_UI_LayoutGroup__SetChildAlongAxisWithScale
		                  (param1,uVar4,0,
		                   fVar12 + (*(float *)(param1 + 0x44) + *(float *)(param1 + 0x4c)) * (float)iVar20,
		                   *(float *)(param1 + 0x44),0);
		        uVar4 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x38),iVar2,
		                           Method_System_Collections_Generic_List_RectTransform__get_Item__);
		        iVar2 = (iVar18 + -1) - iVar14;
		        if ((uVar7 & 0xfffffffe) != 2) {
		          iVar2 = iVar14;
		        }
		        UnityEngine_UI_LayoutGroup__SetChildAlongAxisWithScale
		                  (param1,uVar4,1,fVar13 + (*pfVar10 + *pfVar8) * (float)iVar2,*pfVar10,0);
		        iVar2 = iVar19;
		      } while (iVar19 != iVar6);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x5F5D", Offset = "0x5F5D", VA = "0x5F5D")]
		private void SetCellsAlongAxis(int axis)
		{
		/* --- GHIDRA: SetCellsAlongAxis ---
		void UI_Misc_DynamicGridLayoutGroup__SetCellsAlongAxis(undefined4 param1,undefined4 param2)
		
		{
		  UnityEngine_UI_GridLayoutGroup__set_constraintCount(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x5F5E", Offset = "0x5F5E", VA = "0x5F5E")]
		public DynamicGridLayoutGroup()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Misc_DynamicGridLayoutGroup___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63911 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		    DAT_ram_00a63911 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    return *(undefined4 *)(param1 + 0x18);
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return uVar1;
		}
		*/

		}
	}
}
