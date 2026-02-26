using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x02001319 RID: 4889
	[Token(Token = "0x2001319")]
	public class ToHomeInitialWorldMovement : AbstractWorldMovement
	{
		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x0600741D RID: 29725 RVA: 0x00014E08 File Offset: 0x00013008
		[Token(Token = "0x17001766")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x600741D")]
			[Address(RVA = "0xBDEB", Offset = "0xBDEB", VA = "0xBDEB", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x0600741E RID: 29726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600741E")]
		[Address(RVA = "0xBDEC", Offset = "0xBDEC", VA = "0xBDEC", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600741F")]
		[Address(RVA = "0xBDED", Offset = "0xBDED", VA = "0xBDED")]
		public ToHomeInitialWorldMovement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Type ---
		void CloudsFly_Movement_ToHomeInitialWorldMovement__get_Type
		               (int param1,float *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  float fVar4;
		  int iVar5;
		  uint uVar6;
		  int iVar7;
		  undefined8 local_28;
		  float4 local_20;
		  float4 local_18;
		  undefined4 local_14;
		  float4 local_10;
		  float4 local_c;
		  float4 local_4;
		  
		  if (DAT_ram_00a596a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_From_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnKill_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_CloudsFly_Movement_ToHomeInitialWorldMovement___c__DisplayClass2_0__Move_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_CloudsFly_Movement_ToHomeInitialWorldMovement___c__DisplayClass2_0__Move_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_CloudsFly_Movement_ToHomeInitialWorldMovement___c__DisplayClass2_0__Move_b__2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&CloudsFly_Movement_ToHomeInitialWorldMovement___c__DisplayClass2_0_TypeInfo);
		    DAT_ram_00a596a1 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (CloudsFly_Movement_ToHomeInitialWorldMovement___c__DisplayClass2_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 0xc) = param3;
		  *(undefined4 *)(iVar1 + 8) = param4;
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param3,0);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(iVar1 + 0xc),0);
		  func_ii_7888(&local_c,uVar3,0);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(iVar1 + 0xc),0);
		  func_ii_7888(&local_c,uVar3,0);
		  local_10 = local_4;
		  local_20 = local_4;
		  local_14 = 0xc3960000;
		  local_18 = local_c;
		  local_28 = CONCAT44(0xc3960000,local_c);
		  UnityEngine_Transform__get_position(uVar2,&local_28,0);
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(iVar1 + 0xc),0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOMove(uVar2,*param2,1.0,0,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0xc),0);
		  uVar2 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar2,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  if (DAT_ram_00a5969b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__Add__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		    DAT_ram_00a5969b = '\x01';
		  }
		  DG_Tweening_TweenSettingsExtensions__SetAutoKill_object_
		            (uVar2,0,Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		  iVar7 = Method_System_Collections_Generic_List_Tween__Add__;
		  iVar5 = *(int *)(param1 + 8);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(undefined4 *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(iVar1 + 0xc),0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOMoveX(uVar2,param2[1],2.0,0,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,7,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0xc),0);
		  uVar2 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar2,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  if (DAT_ram_00a5969b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__Add__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		    DAT_ram_00a5969b = '\x01';
		  }
		  DG_Tweening_TweenSettingsExtensions__SetAutoKill_object_
		            (uVar2,0,Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		  iVar7 = Method_System_Collections_Generic_List_Tween__Add__;
		  iVar5 = *(int *)(param1 + 8);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(undefined4 *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(iVar1 + 0xc),0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOMoveY(uVar2,param2[2],2.0,0,0);
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0xc),0);
		  uVar2 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar2,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar3,iVar1,
		             Method_CloudsFly_Movement_ToHomeInitialWorldMovement___c__DisplayClass2_0__Move_b__0__,
		             0);
		  uVar2 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar2,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  if (DAT_ram_00a5969b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__Add__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		    DAT_ram_00a5969b = '\x01';
		  }
		  DG_Tweening_TweenSettingsExtensions__SetAutoKill_object_
		            (uVar2,0,Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		  iVar7 = Method_System_Collections_Generic_List_Tween__Add__;
		  iVar5 = *(int *)(param1 + 8);
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar5 + 8) + 0xc)) {
		    *(uint *)(iVar5 + 0xc) = uVar6 + 1;
		    *(undefined4 *)(*(int *)(iVar5 + 8) + uVar6 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar5,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		  }
		  fVar4 = UnityEngine_Camera__set_farClipPlane(*(undefined4 *)(iVar1 + 0xc),0);
		  *(float *)(iVar1 + 0x10) = fVar4;
		  uVar2 = DG_Tweening_ShortcutExtensions__DOFarClipPlane
		                    (*(undefined4 *)(iVar1 + 0xc),fVar4 * 0.5,2.0,0);
		  uVar2 = DG_Tweening_Core_TweenManager__GetTweener___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar2,
		                     Method_DG_Tweening_TweenSettingsExtensions_From_TweenerCore_float__float__FloatOptions____
		                    );
		  uVar2 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar2,5,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		                    );
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0xc),0);
		  uVar2 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar2,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		                    );
		  uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar3,iVar1,
		             Method_CloudsFly_Movement_ToHomeInitialWorldMovement___c__DisplayClass2_0__Move_b__1__,
		             0);
		  uVar2 = DG_Tweening_TweenSettingsExtensions__OnComplete_object_
		                    (uVar2,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnKill_TweenerCore_float__float__FloatOptions____
		                    );
		  uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar3,iVar1,
		             Method_CloudsFly_Movement_ToHomeInitialWorldMovement___c__DisplayClass2_0__Move_b__2__,
		             0);
		  uVar2 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar2,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_float__float__FloatOptions____
		                    );
		  if (DAT_ram_00a5969b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__Add__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		    DAT_ram_00a5969b = '\x01';
		  }
		  DG_Tweening_TweenSettingsExtensions__SetAutoKill_object_
		            (uVar2,0,Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		  iVar1 = Method_System_Collections_Generic_List_Tween__Add__;
		  iVar7 = *(int *)(param1 + 8);
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar7 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar6 + 1;
		    *(undefined4 *)(*(int *)(iVar7 + 8) + uVar6 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return;
		}
		*/

}
