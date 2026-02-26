using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using DG.Tweening;
using Gameplay.Aprs.View;
using Gameplay.Inventory.View;
using Gameplay.Medals.View;
using Gameplay.School.Model;
using Il2CppDummyDll;
using UI.Elements.Buildings;
using UnityEngine;
using Utils.Cache;

namespace UI.Toast
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	public class ToastController : MonoBehaviour
	{
		// Token: 0x06000A50 RID: 2640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x5DA3", Offset = "0x5DA3", VA = "0x5DA3")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Toast_ToastController__Awake(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  UI_Toast_ToastView__Hide(param2,param2);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param2,0);
		  func_ii_8007(uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x5DA4", Offset = "0x5DA4", VA = "0x5DA4")]
		private void OnReleaseToast(ToastView pooledObject)
		{
		/* --- GHIDRA: OnReleaseToast ---
		void UI_Toast_ToastController__OnReleaseToast(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  if (DAT_ram_00a599ad == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_16332);
		    DAT_ram_00a599ad = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UI_Toast_ToastController__Show(param1,param2,&local_4,auStack_10);
		  if (iVar1 == 0) {
		    param1_00 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_16332,local_4,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x1B6D", Offset = "0x1B6D", VA = "0x1B6D")]
		public void Show(ToastTheme theme, string message)
		{
		/* --- GHIDRA: Show ---
		undefined4
		UI_Toast_ToastController__Show(int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  uint uVar5;
		  undefined4 local_c;
		  ulonglong local_8;
		  
		  puVar1 = (uint *)0x0;
		  if (DAT_ram_00a599ae == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ICombatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_CombatModel_States__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_CombatModel_States___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_CombatModel_States__get_HasValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_ToastController_ToastData__Enqueue__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatModel_States_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5600);
		    DAT_ram_00a599ae = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (piVar3 != (int *)0x0) {
		    iVar4 = *piVar3;
		    if ((uint *)(uint)*(ushort *)(iVar4 + 0xb6) != (uint *)0x0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + (int)puVar1 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + (int)puVar1 * 8 + 4) * 8 + iVar4 +
		                           0x218);
		          goto code_r0x8109dbb8;
		        }
		        puVar1 = (uint *)((int)puVar1 + 1);
		      } while ((uint *)(uint)*(ushort *)(iVar4 + 0xb6) != puVar1);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x8109dbb8:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		    if (piVar3 != (int *)0x0) {
		      uVar5 = 0;
		      iVar4 = *piVar3;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		              *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		            puVar1 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x8109dc39;
		          }
		          uVar5 = uVar5 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		      }
		      puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x8109dc39:
		      piVar3 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		      if (piVar3 != (int *)0x0) {
		        uVar5 = 0;
		        iVar4 = *piVar3;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		              puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0xe0)
		              ;
		              goto code_r0x8109dcba;
		            }
		            uVar5 = uVar5 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar3,Gameplay_Combat_ICombat_TypeInfo,4);
		code_r0x8109dcba:
		        puVar1 = (uint *)(**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		        local_8 = 0;
		        System_Data_SqlTypes_SqlInt32___ctor
		                  (&local_8,puVar1,Method_System_Nullable_CombatModel_States___ctor__);
		        if (((local_8 & 0xffffffff00000000) == 0x200000000) && ((local_8 & 0xff) != 0)) {
		          local_c = 2;
		          uVar2 = func_ii_1081(Gameplay_Combat_Model_CombatModel_States_TypeInfo,&local_c);
		          uVar2 = func_ii_4419(StringLiteral_5600,uVar2,0);
		          *param3 = uVar2;
		          return 0;
		        }
		      }
		    }
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x38),param2,
		             Method_System_Collections_Generic_Queue_ToastController_ToastData__Enqueue__);
		  UI_Toast_ToastController__TryShow(param1,puVar1);
		  *param3 = 0;
		  return 1;
		}
		*/

		/* --- GHIDRA: Show ---
		undefined4
		UI_Toast_ToastController__Show(int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  uint uVar5;
		  undefined4 local_c;
		  ulonglong local_8;
		  
		  puVar1 = (uint *)0x0;
		  if (DAT_ram_00a599ae == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ICombatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_CombatModel_States__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_CombatModel_States___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_CombatModel_States__get_HasValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_ToastController_ToastData__Enqueue__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatModel_States_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5600);
		    DAT_ram_00a599ae = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(int **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  if (piVar3 != (int *)0x0) {
		    iVar4 = *piVar3;
		    if ((uint *)(uint)*(ushort *)(iVar4 + 0xb6) != (uint *)0x0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + (int)puVar1 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + (int)puVar1 * 8 + 4) * 8 + iVar4 +
		                           0x218);
		          goto code_r0x8109dbb8;
		        }
		        puVar1 = (uint *)((int)puVar1 + 1);
		      } while ((uint *)(uint)*(ushort *)(iVar4 + 0xb6) != puVar1);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2b);
		code_r0x8109dbb8:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		    if (piVar3 != (int *)0x0) {
		      uVar5 = 0;
		      iVar4 = *piVar3;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_Managers_ICombatManager_TypeInfo ==
		              *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		            puVar1 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x8109dc39;
		          }
		          uVar5 = uVar5 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		      }
		      puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_Managers_ICombatManager_TypeInfo,0);
		code_r0x8109dc39:
		      piVar3 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		      if (piVar3 != (int *)0x0) {
		        uVar5 = 0;
		        iVar4 = *piVar3;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		              puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0xe0)
		              ;
		              goto code_r0x8109dcba;
		            }
		            uVar5 = uVar5 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar3,Gameplay_Combat_ICombat_TypeInfo,4);
		code_r0x8109dcba:
		        puVar1 = (uint *)(**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		        local_8 = 0;
		        System_Data_SqlTypes_SqlInt32___ctor
		                  (&local_8,puVar1,Method_System_Nullable_CombatModel_States___ctor__);
		        if (((local_8 & 0xffffffff00000000) == 0x200000000) && ((local_8 & 0xff) != 0)) {
		          local_c = 2;
		          uVar2 = func_ii_1081(Gameplay_Combat_Model_CombatModel_States_TypeInfo,&local_c);
		          uVar2 = func_ii_4419(StringLiteral_5600,uVar2,0);
		          *param3 = uVar2;
		          return 0;
		        }
		      }
		    }
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__object___TryGetValue
		            (*(undefined4 *)(param1 + 0x38),param2,
		             Method_System_Collections_Generic_Queue_ToastController_ToastData__Enqueue__);
		  UI_Toast_ToastController__TryShow(param1,puVar1);
		  *param3 = 0;
		  return 1;
		}
		*/

		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x5DA5", Offset = "0x5DA5", VA = "0x5DA5")]
		public void Show(ToastController.ToastData toastData)
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x5DA6", Offset = "0x5DA6", VA = "0x5DA6")]
		private bool TryShow(ToastController.ToastData data, out string reason)
		{
		/* --- GHIDRA: TryShow ---
		void UI_Toast_ToastController__TryShow(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  float fVar2;
		  undefined4 uVar3;
		  int param1_01;
		  int iVar4;
		  uint uVar5;
		  float fVar6;
		  float fVar7;
		  int iVar8;
		  int iVar9;
		  float fVar10;
		  float fVar11;
		  undefined8 local_28;
		  undefined4 local_20;
		  float4 local_18;
		  float4 local_14;
		  undefined4 local_10;
		  float4 local_c;
		  
		  if (DAT_ram_00a599af == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ToastView__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ToastView__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ToastView__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_ToastView__Get__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_ToastController_ToastData__Dequeue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_ToastController_ToastData__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Toast_ToastController_ShiftQueue__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a599af = '\x01';
		  }
		  if (*(int *)(param1 + 0x44) == 0) {
		    iVar8 = *(int *)(param1 + 0x3c);
		    iVar9 = *(int *)(iVar8 + 0xc);
		    if ((longlong)iVar9 < (longlong)(ulonglong)*(uint *)(param1 + 0x24)) {
		      param1_01 = *(int *)(param1 + 0x38);
		      iVar4 = *(int *)(param1_01 + 0x14);
		      while (0 < iVar4) {
		        uVar3 = func_ii_7387(param1_01,
		                             Method_System_Collections_Generic_Queue_ToastController_ToastData__Dequeue__
		                            );
		        uVar1 = Gameplay_Combat_View_VFX_StoneDestroyVFX__GetPool
		                          (*(undefined4 *)(param1 + 0x34),
		                           Method_Utils_Cache_ObjectPool_ToastView__Get__);
		        param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (uVar1,0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (param1_00,1,0);
		        UI_Toast_ToastView__set_AddedAtIndex
		                  (uVar1,uVar3,*(undefined4 *)(*(int *)(param1 + 0x3c) + 0xc),param1);
		        iVar8 = Method_System_Collections_Generic_List_ToastView__Add__;
		        iVar9 = *(int *)(param1 + 0x3c);
		        *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		        uVar5 = *(uint *)(iVar9 + 0xc);
		        if (uVar5 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		          *(uint *)(iVar9 + 0xc) = uVar5 + 1;
		          *(undefined4 *)(*(int *)(iVar9 + 8) + uVar5 * 4 + 0x10) = uVar1;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar9,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		        }
		        uVar3 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (uVar1,0);
		        uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                          (uVar1,0);
		        UnityEngine_Transform___ctor(&local_c,uVar1,0);
		        local_10 = 0;
		        local_20 = 0;
		        local_18 = local_c;
		        local_14 = (float4)(float)(*(int *)(param1 + 0x28) *
		                                  (1 - *(int *)(*(int *)(param1 + 0x3c) + 0xc)));
		        local_28 = CONCAT44(local_14,local_c);
		        Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar3,&local_28,0);
		        iVar8 = *(int *)(param1 + 0x3c);
		        iVar9 = *(int *)(iVar8 + 0xc);
		        if ((longlong)(ulonglong)*(uint *)(param1 + 0x24) <= (longlong)iVar9) break;
		        param1_01 = *(int *)(param1 + 0x38);
		        iVar4 = *(int *)(param1_01 + 0x14);
		      }
		    }
		    if ((0 < iVar9) && (*(int *)(param1 + 0x40) == 0)) {
		      fVar6 = *(float *)(param1 + 0x1c);
		      iVar8 = System_Linq_Enumerable__ToList_object_
		                        (iVar8,0,Method_System_Collections_Generic_List_ToastView__get_Item__);
		      fVar10 = (float)(*(int *)(iVar8 + 0x30) + 1);
		      fVar6 = UnityEngine_Camera__set_orthographicSize(fVar6,fVar10 * fVar10,0);
		      if (DAT_ram_00a599b0 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_Queue_ToastController_ToastData__get_Count__);
		        DAT_ram_00a599b0 = '\x01';
		      }
		      fVar2 = Utils_MathUtils_MathUtils__SaferDivide
		                        ((float)*(int *)(*(int *)(param1 + 0x38) + 0x14),
		                         *(undefined4 *)(param1 + 0x30),0);
		      fVar7 = *(float *)(param1 + 0x2c);
		      uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		      DG_Tweening_Color2__op_Multiply(uVar3,param1,Method_UI_Toast_ToastController_ShiftQueue__,0);
		      fVar10 = 1.0;
		      if (fVar2 <= 1.0) {
		        fVar10 = fVar2;
		      }
		      fVar11 = 0.0;
		      if (0.0 <= fVar2) {
		        fVar11 = fVar10;
		      }
		      uVar3 = DG_Tweening_DOVirtual__EasedValue(fVar6 / (fVar7 * fVar11 + 1.0),uVar3,1,0);
		      *(undefined4 *)(param1 + 0x40) = uVar3;
		    }
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x5DA7", Offset = "0x5DA7", VA = "0x5DA7")]
		private void HandleQueue()
		{
		/* --- GHIDRA: HandleQueue ---
		float UI_Toast_ToastController__HandleQueue(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  
		  if (DAT_ram_00a599b0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_ToastController_ToastData__get_Count__);
		    DAT_ram_00a599b0 = '\x01';
		  }
		  fVar1 = Utils_MathUtils_MathUtils__SaferDivide
		                    ((float)*(int *)(*(int *)(param1 + 0x38) + 0x14),*(undefined4 *)(param1 + 0x30),
		                     0);
		  fVar3 = 1.0;
		  if (fVar1 <= 1.0) {
		    fVar3 = fVar1;
		  }
		  fVar2 = 0.0;
		  if (0.0 <= fVar1) {
		    fVar2 = fVar3;
		  }
		  return *(float *)(param1 + 0x2c) * fVar2 + 1.0;
		}
		*/

		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x5DA8", Offset = "0x5DA8", VA = "0x5DA8")]
		private float GetSpeedCoef()
		{
		/* --- GHIDRA: GetSpeedCoef ---
		void UI_Toast_ToastController__GetSpeedCoef(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int param1_00;
		  undefined4 uVar6;
		  float param3;
		  undefined1 auStack_30 [8];
		  undefined8 local_28;
		  undefined4 local_20;
		  float4 local_18;
		  float4 local_14;
		  undefined4 local_10;
		  float4 local_c;
		  
		  if (DAT_ram_00a599b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ToastView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ToastView__RemoveAt__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ToastView__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ToastView__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Toast_ToastController_OnShiftComplete__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Toast_ToastController_OnToastHideComplete__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a599b1 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x40) = 0;
		  iVar4 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x3c),0,
		                     Method_System_Collections_Generic_List_ToastView__get_Item__);
		  UnityEngine_TextCore_Glyph__set_atlasIndex
		            (*(undefined4 *)(param1 + 0x3c),0,
		             Method_System_Collections_Generic_List_ToastView__RemoveAt__);
		  uVar5 = unnamed_function_1417(System_Action_ToastView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,Method_UI_Toast_ToastController_OnToastHideComplete__,0);
		  if (DAT_ram_00a599bd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ToastView__TypeInfo);
		    DAT_ram_00a599bd = '\x01';
		  }
		  iVar3 = *(int *)(iVar4 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_00 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		    uVar6 = System_Action_ToastView__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar2 = func_ii_1082(param1_00,System_Action_ToastView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar4 + 0x24,iVar2,iVar3);
		    bVar1 = iVar2 == iVar3;
		    iVar3 = iVar2;
		    if (bVar1) {
		      UI_Toast_ToastView__Show(iVar4,auStack_30);
		      param3 = *(float *)(param1 + 0x20);
		      iVar4 = *(int *)(param1 + 0x3c);
		      if (0 < *(int *)(iVar4 + 0xc)) {
		        iVar3 = 0;
		        do {
		          uVar5 = System_Linq_Enumerable__ToList_object_
		                            (iVar4,iVar3,
		                             Method_System_Collections_Generic_List_ToastView__get_Item__);
		          uVar6 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (uVar5,0);
		          func_ii_8007(uVar6,0,0);
		          uVar6 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (uVar5,0);
		          uVar5 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (uVar5,0);
		          UnityEngine_Transform___ctor(&local_c,uVar5,0);
		          local_10 = 0;
		          local_20 = 0;
		          local_18 = local_c;
		          local_14 = (float4)(float)-(*(int *)(param1 + 0x28) * iVar3);
		          local_28 = CONCAT44(local_14,local_c);
		          uVar5 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar6,&local_28,param3,0,0);
		          DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar5,7,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		          iVar3 = iVar3 + 1;
		          iVar4 = *(int *)(param1 + 0x3c);
		        } while (iVar3 < *(int *)(iVar4 + 0xc));
		      }
		      uVar5 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		      DG_Tweening_Color2__op_Multiply
		                (uVar5,param1,Method_UI_Toast_ToastController_OnShiftComplete__,0);
		      uVar5 = DG_Tweening_DOVirtual__EasedValue(param3,uVar5,1,0);
		      *(undefined4 *)(param1 + 0x44) = uVar5;
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_00,uVar6);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return 0f;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x5DA9", Offset = "0x5DA9", VA = "0x5DA9")]
		private void ShiftQueue()
		{
		/* --- GHIDRA: ShiftQueue ---
		void UI_Toast_ToastController__ShiftQueue(int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a599b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ToastView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_ToastView__Release__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Toast_ToastController_OnToastHideComplete__);
		    DAT_ram_00a599b2 = '\x01';
		  }
		  param1_01 = unnamed_function_1417(System_Action_ToastView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,Method_UI_Toast_ToastController_OnToastHideComplete__,0);
		  if (DAT_ram_00a599be == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ToastView__TypeInfo);
		    DAT_ram_00a599be = '\x01';
		  }
		  param1_00 = *(int *)(param2 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_ToastView__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_ToastView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param2 + 0x24,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      func_ii_7070(*(undefined4 *)(param1 + 0x34),param2,
		                   Method_Utils_Cache_ObjectPool_ToastView__Release__);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x5DAA", Offset = "0x5DAA", VA = "0x5DAA")]
		private void OnToastHideComplete(ToastView toastView)
		{
		/* --- GHIDRA: OnToastHideComplete ---
		void UI_Toast_ToastController__OnToastHideComplete(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x44) = 0;
		  UI_Toast_ToastController__TryShow(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x5DAB", Offset = "0x5DAB", VA = "0x5DAB")]
		private void OnShiftComplete()
		{
		/* --- GHIDRA: OnShiftComplete ---
		void UI_Toast_ToastController__OnShiftComplete(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a599b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_Enumerator_ToastController_ToastData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ToastView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_Enumerator_ToastController_ToastData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ToastView__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ToastView__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Queue_Enumerator_ToastController_ToastData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ToastView__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ToastView__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_ToastView__Release__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_ToastController_ToastData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_ToastController_ToastData__GetEnumerator__);
		    DAT_ram_00a599b3 = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  if (*(int *)(param1 + 0x40) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x40),0,0);
		  }
		  *(undefined4 *)(param1 + 0x40) = 0;
		  if (*(int *)(param1 + 0x44) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x44),0,0);
		  }
		  *(undefined4 *)(param1 + 0x44) = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_30,*(undefined4 *)(param1 + 0x3c),
		             Method_System_Collections_Generic_List_ToastView__GetEnumerator__);
		  local_8 = local_28;
		  local_30 = 0;
		  puStack_2c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ToastView__MoveNext__);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8109e8b0;
		    }
		    if (iVar1 == 0) goto code_r0x8109e906;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    param2_00 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x30e,local_8._4_4_,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8109e8b0;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x44,param2_00,0,0);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8109e8b0;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x18,*(undefined4 *)(param1 + 0x34)
		               ,uVar2,Method_Utils_Cache_ObjectPool_ToastView__Release__);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar4 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8109e8b0:
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_30 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8109e906:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = *(int *)(param1 + 0x3c);
		      iVar1 = *(int *)(iVar4 + 0xc);
		      *(undefined4 *)(iVar4 + 0xc) = 0;
		      *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		      if (0 < iVar1) {
		        func_ii_2064(*(undefined4 *)(iVar4 + 8),0,iVar1,0);
		      }
		      System_Collections_Generic_Queue_uint___Enqueue
		                (&local_20,*(undefined4 *)(param1 + 0x38),
		                 Method_System_Collections_Generic_Queue_ToastController_ToastData__GetEnumerator__)
		      ;
		      local_30 = 0;
		      puStack_2c = &local_20;
		      do {
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar1 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x46,&local_20,
		                             Method_System_Collections_Generic_Queue_Enumerator_ToastController_ToastData__MoveNext__
		                            );
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8109eb66;
		          }
		          if (iVar1 == 0) {
		            System_Collections_Generic_Queue_object___GetEnumerator
		                      (&local_20,
		                       Method_System_Collections_Generic_Queue_Enumerator_ToastController_ToastData__Dispose__
		                      );
		            goto code_r0x8109ec0f;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x47,&local_20,
		                             Method_System_Collections_Generic_Queue_Enumerator_ToastController_ToastData__get_Current__
		                            );
		          if (DAT_ram_009d3e38 == 1) goto code_r0x8109eb54;
		          if (DAT_ram_00a599bc == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi(0x7ff,&UnityEngine_Object_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x8109eb54;
		            DAT_ram_00a599bc = '\x01';
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                            (*(undefined4 *)(iVar4 + 0x14),0);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x8109eb54;
		        } while (iVar1 == 0);
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,
		                           *(undefined4 *)(iVar4 + 0x14),0);
		        if (DAT_ram_009d3e38 == 1) break;
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar2,0);
		      } while (DAT_ram_009d3e38 != 1);
		code_r0x8109eb54:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8109eb66:
		      iVar4 = global_1;
		      iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar1) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar1 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar1;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		          System_Collections_Generic_Queue_object___GetEnumerator
		                    (&local_20,
		                     Method_System_Collections_Generic_Queue_Enumerator_ToastController_ToastData__Dispose__
		                    );
		          if (iVar1 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x8109ec0f:
		          System_Collections_Generic_Queue_MeshGenerationDeferrer_CallbackInfo____ctor
		                    (*(undefined4 *)(param1 + 0x38),
		                     Method_System_Collections_Generic_Queue_ToastController_ToastData__Clear__);
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x48,&local_30);
		      goto joined_r0x8109ebfb;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x45,&local_30);
		joined_r0x8109ebfb:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x5DAC", Offset = "0x5DAC", VA = "0x5DAC")]
		public void StopAll()
		{
		/* --- GHIDRA: StopAll ---
		void UI_Toast_ToastController__StopAll(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a599b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ToastView___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ToastView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Queue_ToastController_ToastData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Queue_ToastController_ToastData__TypeInfo);
		    DAT_ram_00a599b4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Queue_ToastController_ToastData__TypeInfo);
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (uVar1,Method_System_Collections_Generic_Queue_ToastController_ToastData___ctor__);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_ToastView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_ToastView___ctor__);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x5DAD", Offset = "0x5DAD", VA = "0x5DAD")]
		public ToastController()
		{
		}

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ToastView _toastViewPrefab;

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ToastController.ToastPrefabsStorage _toastPrefabs;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float DefaultDuration;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float ShiftDuration;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private uint _maxToastCount;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _elementSize;

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("При большом размере очереди ускоряем в coef раз скорость воспроизведений")]
		[SerializeField]
		private float _maxSpeedCoef;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Размер очереди при котором происходит максимальное ускорение")]
		[SerializeField]
		private int _maxSpeedQueueSize;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x34")]
		private GameObjectPool<ToastView> _toastPool;

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x38")]
		private Queue<ToastController.ToastData> _toastQueue;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x3C")]
		private List<ToastView> _currentToastView;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x40")]
		private Tween _updateQueueDelayedCall;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x44")]
		private Tween _shiftToastsDelayedCall;

		// Token: 0x02000172 RID: 370
		[Token(Token = "0x2000172")]
		public class ToastData : IDisposable
		{
			// Token: 0x17000152 RID: 338
			// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00003948 File Offset: 0x00001B48
			// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000152")]
			public ToastTheme Theme
			{
				[Token(Token = "0x6000A5C")]
				[Address(RVA = "0x5DAE", Offset = "0x5DAE", VA = "0x5DAE")]
				[CompilerGenerated]
				get
				{
					return ToastTheme.Unknown;
				}
				[Token(Token = "0x6000A5D")]
				[Address(RVA = "0x5DAF", Offset = "0x5DAF", VA = "0x5DAF")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000153")]
			public string Title
			{
				[Token(Token = "0x6000A5E")]
				[Address(RVA = "0x5DB0", Offset = "0x5DB0", VA = "0x5DB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A5F")]
				[Address(RVA = "0x5DB1", Offset = "0x5DB1", VA = "0x5DB1")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000154")]
			public string Message
			{
				[Token(Token = "0x6000A60")]
				[Address(RVA = "0x5DB2", Offset = "0x5DB2", VA = "0x5DB2")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A61")]
				[Address(RVA = "0x5DB3", Offset = "0x5DB3", VA = "0x5DB3")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000155")]
			public Transform Content
			{
				[Token(Token = "0x6000A62")]
				[Address(RVA = "0x5DB4", Offset = "0x5DB4", VA = "0x5DB4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000A63")]
				[Address(RVA = "0x5DB5", Offset = "0x5DB5", VA = "0x5DB5")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000A64 RID: 2660 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x5DB6", Offset = "0x5DB6", VA = "0x5DB6")]
			private static string GetTitleByTheme(ToastTheme theme)
			{
				return null;
			}

			// Token: 0x06000A65 RID: 2661 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x5DB7", Offset = "0x5DB7", VA = "0x5DB7")]
			private static string GetUiResourceIdByTheme(ToastTheme theme)
			{
				return null;
			}

			// Token: 0x06000A66 RID: 2662 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x5DB8", Offset = "0x5DB8", VA = "0x5DB8")]
			public static ToastController.ToastData Create(ToastTheme theme, string message, ArtifactData artifactData)
			{
				return null;
			}

			// Token: 0x06000A67 RID: 2663 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x5DB9", Offset = "0x5DB9", VA = "0x5DB9")]
			public static ToastController.ToastData Create(ToastTheme theme, string message, MedalDicWrapper medal)
			{
				return null;
			}

			// Token: 0x06000A68 RID: 2664 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x5DBA", Offset = "0x5DBA", VA = "0x5DBA")]
			public static ToastController.ToastData Create(ToastTheme theme, string message, AprDicWrapper apr)
			{
				return null;
			}

			// Token: 0x06000A69 RID: 2665 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x5DBB", Offset = "0x5DBB", VA = "0x5DBB")]
			public static ToastController.ToastData Create(ToastTheme theme, string message, SchoolSpellData schoolSpellData)
			{
				return null;
			}

			// Token: 0x06000A6A RID: 2666 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x5DBC", Offset = "0x5DBC", VA = "0x5DBC")]
			public static ToastController.ToastData Create(ToastTheme theme, string message)
			{
				return null;
			}

			// Token: 0x06000A6B RID: 2667 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x5DBD", Offset = "0x5DBD", VA = "0x5DBD", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x06000A6C RID: 2668 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x5DBE", Offset = "0x5DBE", VA = "0x5DBE")]
			public ToastData()
			{
			}
		}

		// Token: 0x02000173 RID: 371
		[Token(Token = "0x2000173")]
		[Serializable]
		public class ToastPrefabsStorage
		{
			// Token: 0x17000156 RID: 342
			// (get) Token: 0x06000A6D RID: 2669 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000156")]
			public MedalView MedalViewPrefab
			{
				[Token(Token = "0x6000A6D")]
				[Address(RVA = "0x5DBF", Offset = "0x5DBF", VA = "0x5DBF")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000157")]
			public ArtifactView ArtifactViewPrefab
			{
				[Token(Token = "0x6000A6E")]
				[Address(RVA = "0x5DC0", Offset = "0x5DC0", VA = "0x5DC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000A6F RID: 2671 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000158")]
			public GameRawImage GameRawImagePrefab
			{
				[Token(Token = "0x6000A6F")]
				[Address(RVA = "0x5DC1", Offset = "0x5DC1", VA = "0x5DC1")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000159")]
			public AprViewSmall AprViewSmallPrefab
			{
				[Token(Token = "0x6000A70")]
				[Address(RVA = "0x5DC2", Offset = "0x5DC2", VA = "0x5DC2")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000A71 RID: 2673 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700015A")]
			public SpellItem SpellItemPrefab
			{
				[Token(Token = "0x6000A71")]
				[Address(RVA = "0x5DC3", Offset = "0x5DC3", VA = "0x5DC3")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000A72 RID: 2674 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x5DC4", Offset = "0x5DC4", VA = "0x5DC4")]
			public ToastPrefabsStorage()
			{
			}

			// Token: 0x04000477 RID: 1143
			[Token(Token = "0x4000477")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private ArtifactView _artifactViewPrefab;

			// Token: 0x04000478 RID: 1144
			[Token(Token = "0x4000478")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private MedalView _medalViewPrefab;

			// Token: 0x04000479 RID: 1145
			[Token(Token = "0x4000479")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameRawImage _gameRawImagePrefab;

			// Token: 0x0400047A RID: 1146
			[Token(Token = "0x400047A")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private AprViewSmall _aprViewSmallPrefab;

			// Token: 0x0400047B RID: 1147
			[Token(Token = "0x400047B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private SpellItem _spellItemPrefab;
		}
	}
}
