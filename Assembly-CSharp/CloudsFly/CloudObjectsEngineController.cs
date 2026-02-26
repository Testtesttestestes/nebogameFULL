using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CloudsFly.Movement;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012F9 RID: 4857
	[Token(Token = "0x20012F9")]
	public class CloudObjectsEngineController : MonoBehaviour
	{
		// Token: 0x14000305 RID: 773
		// (add) Token: 0x06007393 RID: 29587 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007394 RID: 29588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000305")]
		public event Action OnInitialized
		{
			[Token(Token = "0x6007393")]
			[Address(RVA = "0xBD7F", Offset = "0xBD7F", VA = "0xBD7F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007394")]
			[Address(RVA = "0xBD80", Offset = "0xBD80", VA = "0xBD80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06007395 RID: 29589 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001757")]
		public CloudsVerticalMovementAnimation VerticalMovementAnimation
		{
			[Token(Token = "0x6007395")]
			[Address(RVA = "0xBD81", Offset = "0xBD81", VA = "0xBD81")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06007396 RID: 29590 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001758")]
		public CloudBGParallax CloudBGParallax
		{
			[Token(Token = "0x6007396")]
			[Address(RVA = "0xBD82", Offset = "0xBD82", VA = "0xBD82")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x00014C58 File Offset: 0x00012E58
		[Token(Token = "0x6007397")]
		[Address(RVA = "0xBD83", Offset = "0xBD83", VA = "0xBD83")]
		private float GetCloudDistanceInternal()
		{
		/* --- GHIDRA: GetCloudDistanceInternal ---
		void CloudsFly_CloudObjectsEngineController__GetCloudDistanceInternal(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  float fVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  float fVar4;
		  int param2_00;
		  int *piVar5;
		  int iVar6;
		  int param1_02;
		  uint uVar7;
		  int iVar8;
		  undefined8 uVar9;
		  int *piVar10;
		  undefined8 local_14;
		  undefined4 local_c;
		  float4 local_8;
		  
		  uVar7 = 0;
		  iVar8 = 0;
		  if (DAT_ram_00a5967a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_CloudObjectsEngineController_GetBlockResetPositions__);
		    Mono_Security_ASN1__get_Item(&Method_CloudsFly_CloudObjectsEngineController_GetRandomRange__);
		    Mono_Security_ASN1__get_Item(&Method_CloudsFly_CloudObjectsEngineController_GetRandom__);
		    Mono_Security_ASN1__get_Item(&Method_CloudsFly_CloudObjectsEngineController_ResetPositions__);
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_CloudObjectsEngineController_SetBlockResetPositions__);
		    Mono_Security_ASN1__get_Item(&CloudsFly_EngineAndArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_float__float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_float__float__float__float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_IWorldObjectEngine_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EngineAndArgs__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_WorldObjectEngineArgs__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_WorldObjectEngineArgs__get_Item__);
		    Mono_Security_ASN1__get_Item(&CloudsFly_Movement_WorldMovementResolver_TypeInfo);
		    DAT_ram_00a5967a = '\x01';
		  }
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x10),0);
		  func_ii_7888(&local_14,uVar1,0);
		  *(undefined4 *)(param1 + 0x40) = local_c;
		  *(undefined8 *)(param1 + 0x38) = local_14;
		  fVar2 = UnityEngine_Camera__set_nearClipPlane(*(undefined4 *)(param1 + 0x10),0);
		  CloudsFly_CloudObjectsEngineController__GetWidthFromCamera(&local_8,param1,fVar2,0);
		  *(float4 *)(param1 + 0x34) = local_8;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0x148);
		        goto code_r0x81047bf1;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x81047bf1:
		  uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  param1_00 = unnamed_function_1417(CloudsFly_Movement_WorldMovementResolver_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,uVar1,0);
		  *(undefined4 *)(param1 + 0x4c) = param1_00;
		  fVar2 = UnityEngine_Camera__set_nearClipPlane(*(undefined4 *)(param1 + 0x10),0);
		  if (fVar2 < *(float *)(param1 + 0x24)) {
		    UnityEngine_Camera__get_farClipPlane(*(undefined4 *)(param1 + 0x10),*(float *)(param1 + 0x24),0)
		    ;
		  }
		  iVar6 = *(int *)(param1 + 0x2c);
		  if (0 < *(int *)(iVar6 + 0xc)) {
		    do {
		      piVar5 = (int *)System_Linq_Enumerable__ToList_object_
		                                (iVar6,iVar8,
		                                 Method_System_Collections_Generic_List_WorldObjectEngineArgs__get_Item__
		                                );
		      param1_01 = (int *)(**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe0) * 4))
		                                   (piVar5,*(undefined4 *)(*piVar5 + 0xe4));
		      iVar6 = *(int *)(param1 + 0x10);
		      piVar5[4] = iVar6;
		      piVar5[6] = *(int *)(param1 + 0x28);
		      piVar5[7] = *(int *)(param1 + 0x34);
		      fVar2 = *(float *)(param1 + 0x24);
		      fVar4 = UnityEngine_Camera__set_nearClipPlane(iVar6,0);
		      if (fVar4 <= fVar2) {
		        fVar2 = fVar4;
		      }
		      piVar5[5] = (int)fVar2;
		      uVar9 = *(undefined8 *)(param1 + 0x38);
		      piVar5[10] = *(int *)(param1 + 0x40);
		      *(undefined8 *)(piVar5 + 8) = uVar9;
		      iVar6 = unnamed_function_1417(System_Func_float__float__float__float__TypeInfo);
		      System_Func_object__object__object__object___Invoke
		                (iVar6,param1,Method_CloudsFly_CloudObjectsEngineController_GetRandomRange__,0);
		      piVar5[0xb] = iVar6;
		      iVar6 = unnamed_function_1417(System_Func_float__float__TypeInfo);
		      System_Func_float__int___Invoke
		                (iVar6,param1,Method_CloudsFly_CloudObjectsEngineController_GetRandom__,0);
		      piVar5[0xc] = iVar6;
		      iVar6 = unnamed_function_1417(System_Func_bool__TypeInfo);
		      System_Func_BackgroundSize___Invoke
		                (iVar6,param1,Method_CloudsFly_CloudObjectsEngineController_GetBlockResetPositions__
		                 ,0);
		      piVar5[0xd] = iVar6;
		      iVar6 = unnamed_function_1417(System_Action_bool__TypeInfo);
		      System_Action_AsyncGPUReadbackRequest___Invoke
		                (iVar6,param1,Method_CloudsFly_CloudObjectsEngineController_SetBlockResetPositions__
		                 ,0);
		      piVar5[0xe] = iVar6;
		      iVar6 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (iVar6,param1,Method_CloudsFly_CloudObjectsEngineController_ResetPositions__,0);
		      piVar5[0xf] = iVar6;
		      piVar5[0x10] = *(int *)(param1 + 0x4c);
		      iVar6 = *param1_01;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar7 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8);
		          if (CloudsFly_IWorldObjectEngine_TypeInfo == *piVar10) {
		            puVar3 = (uint *)(iVar6 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x81047e04;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_01,CloudsFly_IWorldObjectEngine_TypeInfo,0);
		code_r0x81047e04:
		      (**(code **)((ulonglong)*puVar3 * 4))(param1_01,piVar5,puVar3[1]);
		      param1_02 = *(int *)(param1 + 0x48);
		      param2_00 = unnamed_function_1417(CloudsFly_EngineAndArgs_TypeInfo);
		      *(int **)(param2_00 + 0xc) = piVar5;
		      *(int **)(param2_00 + 8) = param1_01;
		      iVar6 = Method_System_Collections_Generic_List_EngineAndArgs__Add__;
		      *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		      uVar7 = *(uint *)(param1_02 + 0xc);
		      if (uVar7 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		        *(uint *)(param1_02 + 0xc) = uVar7 + 1;
		        *(int *)(*(int *)(param1_02 + 8) + uVar7 * 4 + 0x10) = param2_00;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (param1_02,param2_00,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      }
		      iVar8 = iVar8 + 1;
		      iVar6 = *(int *)(param1 + 0x2c);
		    } while (iVar8 < *(int *)(iVar6 + 0xc));
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  fVar2 = UnityEngine_Camera__set_nearClipPlane(*(undefined4 *)(param1 + 0x10),0);
		  UnityEngine_Canvas__get_pixelPerfect(uVar1,fVar2 * 0.9,0);
		  iVar8 = *(int *)(param1 + 0x30);
		  if (iVar8 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar8 + 0xc) * 4))
		              (*(undefined4 *)(iVar8 + 0x20),*(undefined4 *)(iVar8 + 0x14));
		  }
		  return;
		}
		*/

			return 0f;
		}

		// Token: 0x06007398 RID: 29592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007398")]
		[Address(RVA = "0xBD84", Offset = "0xBD84", VA = "0xBD84")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void CloudsFly_CloudObjectsEngineController__Start(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  int iVar3;
		  int *param1_00;
		  int param2_01;
		  int *piVar4;
		  undefined1 auStack_c [8];
		  float4 local_4;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a5967b == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_IWorldObjectEngine_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EngineAndArgs__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EngineAndArgs__get_Item__);
		    DAT_ram_00a5967b = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x48);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar3 = System_Linq_Enumerable__ToList_object_
		                        (iVar3,param2_01,
		                         Method_System_Collections_Generic_List_EngineAndArgs__get_Item__);
		      param1_00 = *(int **)(iVar3 + 8);
		      iVar3 = *param1_00;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar4 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (CloudsFly_IWorldObjectEngine_TypeInfo == *piVar4) {
		            puVar2 = (uint *)(piVar4[1] * 8 + iVar3 + 200);
		            goto code_r0x810480ce;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_00,CloudsFly_IWorldObjectEngine_TypeInfo,1);
		code_r0x810480ce:
		      (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		      param2_01 = param2_01 + 1;
		      iVar3 = *(int *)(param1 + 0x48);
		    } while (param2_01 < *(int *)(iVar3 + 0xc));
		  }
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (param1,0);
		  func_ii_7888(auStack_c,param2_00,0);
		  if ((float)*(int *)(param1 + 0x28) < ABS((float)local_4)) {
		    CloudsFly_CloudObjectsEngineController__LateUpdate(param1,iVar3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06007399 RID: 29593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007399")]
		[Address(RVA = "0xBD85", Offset = "0xBD85", VA = "0xBD85")]
		protected void LateUpdate()
		{
		/* --- GHIDRA: LateUpdate ---
		void CloudsFly_CloudObjectsEngineController__LateUpdate(int param1,undefined4 param2)
		
		{
		  float4 param1_00;
		  float4 fVar1;
		  float4 param1_01;
		  float4 fVar2;
		  uint uVar3;
		  undefined4 uVar4;
		  float fVar5;
		  float fVar6;
		  uint *puVar7;
		  int iVar8;
		  int iVar9;
		  int *param1_02;
		  int param2_00;
		  int *piVar10;
		  undefined8 local_38;
		  float4 local_30;
		  undefined8 local_28;
		  float local_20;
		  float4 local_1c;
		  float4 local_18;
		  float4 local_14;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5967c == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_IWorldObjectEngine_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EngineAndArgs__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EngineAndArgs__get_Item__);
		    DAT_ram_00a5967c = '\x01';
		  }
		  if (*(char *)(param1 + 0x44) == '\0') {
		    uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x10),0);
		    func_ii_7888(&local_10,uVar4,0);
		    param1_00 = local_10;
		    iVar8 = *(int *)(param1 + 0x28);
		    uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x10),0);
		    func_ii_7888(&local_10,uVar4,0);
		    fVar1 = local_10;
		    uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x10),0);
		    func_ii_7888(&local_10,uVar4,0);
		    param1_01 = local_8;
		    iVar9 = *(int *)(param1 + 0x28);
		    uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x10),0);
		    func_ii_7888(&local_10,uVar4,0);
		    fVar2 = local_8;
		    uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x10),0);
		    func_ii_7888(&local_10,uVar4,0);
		    fVar5 = unnamed_function_7667((float)param1_01,(float)iVar9);
		    fVar5 = fVar5 - (float)fVar2;
		    local_20 = fVar5 + (float)local_8;
		    local_18 = (float4)((float)local_c + 0.0);
		    local_14 = (float4)local_20;
		    fVar6 = unnamed_function_7667((float)param1_00,(float)iVar8);
		    fVar6 = fVar6 - (float)fVar1;
		    local_1c = (float4)(fVar6 + (float)local_10);
		    local_28 = CONCAT44(local_18,local_1c);
		    UnityEngine_Transform__get_position(uVar4,&local_28,0);
		    iVar8 = *(int *)(param1 + 0x48);
		    if (0 < *(int *)(iVar8 + 0xc)) {
		      do {
		        iVar8 = System_Linq_Enumerable__ToList_object_
		                          (iVar8,param2_00,
		                           Method_System_Collections_Generic_List_EngineAndArgs__get_Item__);
		        param1_02 = *(int **)(iVar8 + 8);
		        local_c = 0.0;
		        iVar8 = *param1_02;
		        local_10 = (float4)fVar6;
		        local_8 = (float4)fVar5;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar3 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8);
		            if (CloudsFly_IWorldObjectEngine_TypeInfo == *piVar10) {
		              puVar7 = (uint *)(piVar10[1] * 8 + iVar8 + 0xd0);
		              goto code_r0x81048312;
		            }
		            uVar3 = uVar3 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		        }
		        puVar7 = (uint *)func_ii_1080(param1_02,CloudsFly_IWorldObjectEngine_TypeInfo,2);
		code_r0x81048312:
		        local_30 = local_8;
		        local_38 = CONCAT44(local_c,local_10);
		        (**(code **)((ulonglong)*puVar7 * 4))(param1_02,&local_38,puVar7[1]);
		        param2_00 = param2_00 + 1;
		        iVar8 = *(int *)(param1 + 0x48);
		      } while (param2_00 < *(int *)(iVar8 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600739A RID: 29594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600739A")]
		[Address(RVA = "0xBD86", Offset = "0xBD86", VA = "0xBD86")]
		private void ResetPositions()
		{
		/* --- GHIDRA: ResetPositions ---
		float CloudsFly_CloudObjectsEngineController__ResetPositions
		                (undefined4 param1,float param2,float param3,float param4,undefined4 param5)
		
		{
		  float fVar1;
		  
		  fVar1 = CloudsFly_CloudObjectsEngineController__GetRandomRange(param1,param2,param1);
		  return (param4 - param3) * fVar1 + param3;
		}
		*/

		}

		// Token: 0x0600739B RID: 29595 RVA: 0x00014C70 File Offset: 0x00012E70
		[Token(Token = "0x600739B")]
		[Address(RVA = "0xBD87", Offset = "0xBD87", VA = "0xBD87")]
		private float GetRandomRange(float distance, float left, float right)
		{
		/* --- GHIDRA: GetRandomRange ---
		float CloudsFly_CloudObjectsEngineController__GetRandomRange
		                (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  float fVar2;
		  float fVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  float fVar5;
		  float fVar6;
		  int iVar7;
		  float4 local_10;
		  float4 local_8;
		  
		  if (DAT_ram_00a5967d == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5967d = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x1c);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar4,0,0);
		  if (iVar1 == 0) {
		    param2_00 = *(undefined4 *)(param1 + 0x1c);
		    uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x10),0);
		    func_ii_7888(&local_10,uVar4,0);
		    fVar5 = *(float *)(param1 + 0x24);
		    fVar2 = UnityEngine_Camera__set_nearClipPlane(*(undefined4 *)(param1 + 0x10),0);
		    fVar6 = *(float *)(param1 + 0x24);
		    fVar3 = UnityEngine_Camera__set_nearClipPlane(*(undefined4 *)(param1 + 0x10),0);
		    if (fVar3 <= fVar6) {
		      fVar6 = fVar3;
		    }
		    if (fVar2 <= fVar5) {
		      fVar5 = fVar2;
		    }
		    if (ABS(ABS((float)local_8)) < 2.1474836e+09) {
		      iVar1 = (int)ABS((float)local_8);
		    }
		    else {
		      iVar1 = -0x80000000;
		    }
		    fVar5 = unnamed_function_7667((float)iVar1,fVar5);
		    iVar1 = **(int **)(param1 + 0x1c);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe0) * 4))
		                      (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar1 + 0xe4));
		    fVar5 = (fVar5 / fVar6) * (float)iVar1;
		    if (ABS(fVar5) < 2.1474836e+09) {
		      iVar1 = (int)fVar5;
		    }
		    else {
		      iVar1 = -0x80000000;
		    }
		    fVar5 = *(float *)(param1 + 0x24);
		    fVar6 = UnityEngine_Camera__set_nearClipPlane(*(undefined4 *)(param1 + 0x10),0);
		    if (fVar6 <= fVar5) {
		      fVar5 = fVar6;
		    }
		    iVar7 = **(int **)(param1 + 0x1c);
		    iVar7 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0xf0) * 4))
		                      (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar7 + 0xf4));
		    fVar5 = (param2 / fVar5) * (float)iVar7;
		    if (ABS(fVar5) < 2.1474836e+09) {
		      iVar7 = (int)fVar5;
		    }
		    else {
		      iVar7 = -0x80000000;
		    }
		    UnityEngine_Texture2D__SetPixels(&local_10,param2_00,iVar1,iVar7,0);
		  }
		  else {
		    local_10 = (float4)func_ii_18581(0);
		  }
		  return (float)local_10;
		}
		*/

			return 0f;
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x00014C88 File Offset: 0x00012E88
		[Token(Token = "0x600739C")]
		[Address(RVA = "0xBD88", Offset = "0xBD88", VA = "0xBD88")]
		private float GetRandom(float distance)
		{
		/* --- GHIDRA: GetRandom ---
		float CloudsFly_CloudObjectsEngineController__GetRandom(int param1,undefined4 param2)
		
		{
		  float param3;
		  undefined1 auStack_10 [8];
		  float4 local_8;
		  
		  param3 = UnityEngine_Camera__set_nearClipPlane(*(undefined4 *)(param1 + 0x10),0);
		  CloudsFly_CloudObjectsEngineController__GetWidthFromCamera(&local_8,param1,param3,auStack_10);
		  return (float)local_8;
		}
		*/

			return 0f;
		}

		// Token: 0x0600739D RID: 29597 RVA: 0x00014CA0 File Offset: 0x00012EA0
		[Token(Token = "0x600739D")]
		[Address(RVA = "0xBD89", Offset = "0xBD89", VA = "0xBD89")]
		private float GetWidthFromCameraForFar()
		{
		/* --- GHIDRA: GetWidthFromCameraForFar ---
		float CloudsFly_CloudObjectsEngineController__GetWidthFromCameraForFar
		                (undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined1 auStack_10 [8];
		  float4 local_8;
		  
		  CloudsFly_CloudObjectsEngineController__GetWidthFromCamera(&local_8,param1,param2,auStack_10);
		  return (float)local_8;
		}
		*/

			return 0f;
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x00014CB8 File Offset: 0x00012EB8
		[Token(Token = "0x600739E")]
		[Address(RVA = "0xBD8A", Offset = "0xBD8A", VA = "0xBD8A")]
		private float GetWidthFromCamera(float distanceFromCamera)
		{
		/* --- GHIDRA: GetWidthFromCamera ---
		void CloudsFly_CloudObjectsEngineController__GetWidthFromCamera
		               (float *param1,int param2,float param3,undefined4 param4)
		
		{
		  int param5;
		  undefined4 param2_00;
		  undefined8 local_50;
		  undefined4 local_48;
		  undefined8 local_40;
		  undefined8 local_38;
		  float4 local_2c;
		  float4 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5967e == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3___TypeInfo);
		    DAT_ram_00a5967e = '\x01';
		  }
		  param5 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector3___TypeInfo,4);
		  local_8 = 0x3f8000003f800000;
		  local_38 = 0x3f8000003f800000;
		  local_10 = 0;
		  local_40 = 0;
		  UnityEngine_Camera__CalculateFrustumCornersInternal
		            (*(undefined4 *)(param2 + 0x10),&local_40,param3,2,param5,0);
		  param2_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param2 + 0x10),0);
		  local_48 = *(undefined4 *)(param5 + 0x18);
		  local_50 = *(undefined8 *)(param5 + 0x10);
		  local_20 = local_50;
		  local_18 = local_48;
		  UnityEngine_Transform__InverseTransformDirection(&local_2c,param2_00,&local_50,0);
		  param1[1] = ABS((float)local_28);
		  *param1 = ABS((float)local_2c);
		  return;
		}
		*/

			return 0f;
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x00014CD0 File Offset: 0x00012ED0
		[Token(Token = "0x600739F")]
		[Address(RVA = "0xBD8B", Offset = "0xBD8B", VA = "0xBD8B")]
		private Vector2 GetSizeFromCamera(float distanceFromCamera)
		{
		/* --- GHIDRA: GetSizeFromCamera ---
		void CloudsFly_CloudObjectsEngineController__GetSizeFromCamera
		               (float *param1,int param2,float param3,undefined4 param4)
		
		{
		  int param5;
		  float fVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5967f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3___TypeInfo);
		    DAT_ram_00a5967f = '\x01';
		  }
		  param5 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector3___TypeInfo,4);
		  local_8 = 0x3f8000003f800000;
		  local_18 = 0x3f8000003f800000;
		  local_10 = 0;
		  local_20 = 0;
		  UnityEngine_Camera__CalculateFrustumCornersInternal
		            (*(undefined4 *)(param2 + 0x10),&local_20,param3,2,param5,0);
		  fVar1 = *(float *)(param5 + 0x10);
		  param1[1] = ABS(*(float *)(param5 + 0x14));
		  *param1 = ABS(fVar1);
		  return;
		}
		*/

			return default(Vector2);
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x00014CE8 File Offset: 0x00012EE8
		[Token(Token = "0x60073A0")]
		[Address(RVA = "0xBD8C", Offset = "0xBD8C", VA = "0xBD8C")]
		private Vector2 GetLocalSizeFromCamera(float distanceFromCamera)
		{
			return default(Vector2);
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x00014D00 File Offset: 0x00012F00
		[Token(Token = "0x60073A1")]
		[Address(RVA = "0xBD8D", Offset = "0xBD8D", VA = "0xBD8D")]
		private bool GetBlockResetPositions()
		{
			return default(bool);
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073A2")]
		[Address(RVA = "0xBD8E", Offset = "0xBD8E", VA = "0xBD8E")]
		private void SetBlockResetPositions(bool value)
		{
		/* --- GHIDRA: SetBlockResetPositions ---
		void CloudsFly_CloudObjectsEngineController__SetBlockResetPositions(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59680 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_WorldObjectEngineArgs___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EngineAndArgs___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_EngineAndArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_WorldObjectEngineArgs__TypeInfo);
		    DAT_ram_00a59680 = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x24) = 0x3e8461c4000;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_WorldObjectEngineArgs__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_WorldObjectEngineArgs___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_EngineAndArgs__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_EngineAndArgs___ctor__);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60073A3")]
		public T GetEngine<T>() where T : WorldObjectEngine
		{
			return null;
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60073A4")]
		public T GetEngineArgs<T>() where T : WorldObjectEngineArgs
		{
			return null;
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073A5")]
		[Address(RVA = "0xBD8F", Offset = "0xBD8F", VA = "0xBD8F")]
		public CloudObjectsEngineController()
		{
		}

		// Token: 0x04003C7E RID: 15486
		[Token(Token = "0x4003C7E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x04003C7F RID: 15487
		[Token(Token = "0x4003C7F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CloudsVerticalMovementAnimation _verticalMovementAnimation;

		// Token: 0x04003C80 RID: 15488
		[Token(Token = "0x4003C80")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Canvas _cloudsBgScaler;

		// Token: 0x04003C81 RID: 15489
		[Token(Token = "0x4003C81")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Texture2D _noizeTexture;

		// Token: 0x04003C82 RID: 15490
		[Token(Token = "0x4003C82")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CloudBGParallax _cloudBGParallax;

		// Token: 0x04003C83 RID: 15491
		[Token(Token = "0x4003C83")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _cloudDistance;

		// Token: 0x04003C84 RID: 15492
		[Token(Token = "0x4003C84")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _chunkSize;

		// Token: 0x04003C85 RID: 15493
		[Token(Token = "0x4003C85")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private List<WorldObjectEngineArgs> _engineArgs;

		// Token: 0x04003C87 RID: 15495
		[Token(Token = "0x4003C87")]
		[FieldOffset(Offset = "0x34")]
		private float _widthCamera;

		// Token: 0x04003C88 RID: 15496
		[Token(Token = "0x4003C88")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _startCameraPosition;

		// Token: 0x04003C89 RID: 15497
		[Token(Token = "0x4003C89")]
		[FieldOffset(Offset = "0x44")]
		private bool _blockResetPositions;

		// Token: 0x04003C8A RID: 15498
		[Token(Token = "0x4003C8A")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<EngineAndArgs> _enginesAndArgs;

		// Token: 0x04003C8B RID: 15499
		[Token(Token = "0x4003C8B")]
		[FieldOffset(Offset = "0x4C")]
		private WorldMovementResolver _movementResolver;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnInitialized ---
		void CloudsFly_CloudObjectsEngineController__add_OnInitialized
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a59679 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a59679 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_CloudBGParallax ---
		float CloudsFly_CloudObjectsEngineController__get_CloudBGParallax(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  float fVar2;
		  
		  fVar2 = *(float *)(param1 + 0x24);
		  fVar1 = UnityEngine_Camera__set_nearClipPlane(*(undefined4 *)(param1 + 0x10),0);
		  if (fVar1 <= fVar2) {
		    fVar2 = fVar1;
		  }
		  return fVar2;
		}
		*/


		/* --- GHIDRA: GetEngine<object> ---
		int CloudsFly_CloudObjectsEngineController__GetEngine_object_(int param1,int param2)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  
		  iVar2 = *(int *)(param2 + 0x1c);
		  if (iVar2 == 0) {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Single_WorldObjectEngineArgs___);
		    Mono_Security_ASN1__get_Item(&System_Func_WorldObjectEngineArgs__bool__TypeInfo);
		    iVar2 = *(int *)(param2 + 0x1c);
		    if (iVar2 == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param2);
		      iVar2 = *(int *)(param2 + 0x1c);
		    }
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x2c);
		  iVar2 = *(int *)(iVar2 + 4);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  if (*(int *)(iVar2 + 0x74) == 0) {
		    func_ii_306000(iVar2);
		  }
		  iVar2 = *(int *)(*(int *)(param2 + 0x1c) + 4);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x5c) + 4);
		  if (iVar2 == 0) {
		    iVar2 = *(int *)(*(int *)(param2 + 0x1c) + 4);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    if (*(int *)(iVar2 + 0x74) == 0) {
		      func_ii_306000(iVar2);
		    }
		    iVar2 = *(int *)(*(int *)(param2 + 0x1c) + 4);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    param2_00 = **(undefined4 **)(iVar2 + 0x5c);
		    iVar2 = unnamed_function_1417(System_Func_WorldObjectEngineArgs__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar2,param2_00,*(undefined4 *)(*(int *)(param2 + 0x1c) + 8),0);
		    iVar1 = *(int *)(*(int *)(param2 + 0x1c) + 4);
		    if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		      iVar1 = func_ii_1079(iVar1);
		    }
		    *(int *)(*(int *)(iVar1 + 0x5c) + 4) = iVar2;
		    iVar1 = *(int *)(*(int *)(param2 + 0x1c) + 4);
		    if ((*(byte *)(iVar1 + 0xbd) & 1) == 0) {
		      func_ii_1079(iVar1);
		    }
		  }
		  iVar1 = 0;
		  param1_00 = func_ii_6917(param1_01,iVar2,
		                           Method_System_Linq_Enumerable_Single_WorldObjectEngineArgs___);
		  iVar2 = *(int *)(*(int *)(param2 + 0x1c) + 0xc);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  if ((param1_00 != 0) && (iVar1 = func_ii_1082(param1_00,iVar2), iVar1 == 0)) {
		    System_Activator__CreateInstance(param1_00,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: GetEngineArgs<object> ---
		undefined4
		CloudsFly_CloudObjectsEngineController__GetEngineArgs_object_
		          (undefined4 param1,undefined4 param2,int param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param3 + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar2 = *(int *)(param3 + 0x1c);
		  }
		  uVar1 = (**(code **)((ulonglong)**(uint **)(iVar2 + 8) * 4))
		                    (param1,param2,0,*(uint **)(iVar2 + 8));
		  return uVar1;
		}
		*/

}
