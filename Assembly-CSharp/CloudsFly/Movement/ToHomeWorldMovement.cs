using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly.Movement
{
	// Token: 0x0200131C RID: 4892
	[Token(Token = "0x200131C")]
	public class ToHomeWorldMovement : AbstractWorldMovement
	{
		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06007427 RID: 29735 RVA: 0x00014E38 File Offset: 0x00013038
		[Token(Token = "0x17001768")]
		public override WorldMovementTypes Type
		{
			[Token(Token = "0x6007427")]
			[Address(RVA = "0xBDF5", Offset = "0xBDF5", VA = "0xBDF5", Slot = "5")]
			get
			{
				return (WorldMovementTypes)0;
			}
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007428")]
		[Address(RVA = "0xBDF6", Offset = "0xBDF6", VA = "0xBDF6", Slot = "6")]
		public override void Move(Vector3 target, Camera camera, Action callback)
		{
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007429")]
		[Address(RVA = "0xBDF7", Offset = "0xBDF7", VA = "0xBDF7", Slot = "8")]
		public override void Dispose()
		{
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600742A")]
		[Address(RVA = "0xBDF8", Offset = "0xBDF8", VA = "0xBDF8")]
		public ToHomeWorldMovement()
		{
		}

		// Token: 0x04003CD4 RID: 15572
		[Token(Token = "0x4003CD4")]
		[FieldOffset(Offset = "0xC")]
		private Camera _camera;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Type ---
		void CloudsFly_Movement_ToHomeWorldMovement__get_Type
		               (int param1,float *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  float4 fVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  float fVar6;
		  float fVar7;
		  float fVar8;
		  uint uVar9;
		  float fVar10;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a596a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Plugins_Core_PathCore_Path_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Path__PathOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Path__PathOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_Movement_ToHomeWorldMovement___c__DisplayClass3_0__Move_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&CloudsFly_Movement_ToHomeWorldMovement___c__DisplayClass3_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3___TypeInfo);
		    DAT_ram_00a596a4 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (CloudsFly_Movement_ToHomeWorldMovement___c__DisplayClass3_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  fVar6 = *param2;
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param3,0);
		  func_ii_7888(&local_c,uVar3,0);
		  fVar1 = local_c;
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param3,0);
		  func_ii_7888(&local_c,uVar3,0);
		  uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param3,0);
		  iVar4 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector3___TypeInfo,3);
		  *(float *)(iVar4 + 0x18) = param2[2];
		  *(undefined8 *)(iVar4 + 0x10) = *(undefined8 *)param2;
		  uVar5 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param3,0);
		  func_ii_7888(&local_c,uVar5,0);
		  *(float *)(iVar4 + 0x24) = (float)local_4 + -1000.0;
		  *(float *)(iVar4 + 0x20) = (float)local_8 + 100.0;
		  fVar10 = 0.1;
		  if (fVar6 <= (float)fVar1) {
		    fVar10 = -0.1;
		  }
		  *(float *)(iVar4 + 0x1c) = (float)local_c + fVar10 * 1000.0;
		  fVar7 = param2[2];
		  fVar8 = param2[1];
		  *(float *)(iVar4 + 0x28) = fVar6 + fVar10 * 500.0;
		  *(float *)(iVar4 + 0x30) = fVar7 + -500.0;
		  *(float *)(iVar4 + 0x2c) = fVar8 + 50.0;
		  uVar5 = unnamed_function_1417(DG_Tweening_Plugins_Core_PathCore_Path_TypeInfo);
		  local_10 = 0;
		  local_18 = 0;
		  local_30 = 0;
		  local_28 = 0;
		  local_20 = 0;
		  local_38 = 0;
		  DG_Tweening_Plugins_Core_PathCore_Path__get_minInputWaypoints(uVar5,2,iVar4,100,&local_38,0);
		  uVar3 = DG_Tweening_ShortcutExtensions__DOLocalPath(uVar3,uVar5,1.5,1,0);
		  uVar3 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar3,7,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Path__PathOptions____
		                    );
		  uVar5 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar5,iVar2,
		             Method_CloudsFly_Movement_ToHomeWorldMovement___c__DisplayClass3_0__Move_b__0__,0);
		  uVar3 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar3,uVar5,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Path__PathOptions____
		                    );
		  if (DAT_ram_00a5969b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Tween__Add__);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		    DAT_ram_00a5969b = '\x01';
		  }
		  DG_Tweening_TweenSettingsExtensions__SetAutoKill_object_
		            (uVar3,0,Method_DG_Tweening_TweenSettingsExtensions_SetAutoKill_Tween___);
		  iVar2 = Method_System_Collections_Generic_List_Tween__Add__;
		  iVar4 = *(int *)(param1 + 8);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar9 = *(uint *)(iVar4 + 0xc);
		  if (uVar9 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar9 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar9 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  return;
		}
		*/

}
