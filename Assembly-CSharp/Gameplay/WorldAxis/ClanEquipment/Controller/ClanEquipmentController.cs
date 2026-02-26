using System;
using Core.Data;
using Gameplay.WorldAxis.ClanEquipment.Events;
using Gameplay.WorldAxis.ClanEquipment.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using ServicesNamespace;
using Utils;

namespace Gameplay.WorldAxis.ClanEquipment.Controller
{
	// Token: 0x02000351 RID: 849
	[Token(Token = "0x2000351")]
	public class ClanEquipmentController : AbstractController<ClanEquipmentModel, ClanEquipmentEvents>
	{
		// Token: 0x0600135F RID: 4959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600135F")]
		[Address(RVA = "0x654F", Offset = "0x654F", VA = "0x654F")]
		public ClanEquipmentController(ClanEquipmentModel model, ClanEquipmentEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController__HandleRun(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001360")]
		[Address(RVA = "0x6550", Offset = "0x6550", VA = "0x6550", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController__HandleRun
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58c44 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController_GetDollArtifactsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58c44 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ColossusService__TakeOffDollArtifacts
		                        (*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController_GetDollArtifactsResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001361")]
		[Address(RVA = "0x6551", Offset = "0x6551", VA = "0x6551")]
		public void GetDollArtifacts()
		{
		/* --- GHIDRA: GetDollArtifacts ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController__GetDollArtifacts
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  int param1_01;
		  uint uVar6;
		  
		  if (DAT_ram_00a58c45 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ProtoGetDollArtsAns_Types_DollsOwner__ulong___)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ulong___);
		    Mono_Security_ASN1__get_Item(&System_Func_ProtoGetDollArtsAns_Types_DollsOwner__ulong__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Colossus_ProtoGetDollArtsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c__GetDollArtifactsResultHandler_b__4_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c__DisplayClass4_0__GetDollArtifactsResultHandler_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c__DisplayClass4_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c_TypeInfo);
		    DAT_ram_00a58c45 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c__DisplayClass4_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 8) = param1;
		  iVar4 = Protocol_Colossus_ProtoGetDollArtsAns_TypeInfo;
		  piVar3 = *(int **)(param2 + 0x20);
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2_00 + 0xc) = 0;
		  }
		  else if ((Protocol_Colossus_ProtoGetDollArtsAns_TypeInfo != *piVar3) ||
		          (*(int **)(param2_00 + 0xc) = piVar3, *piVar3 != iVar4)) {
		    System_Activator__CreateInstance(piVar3,iVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = piVar3[4];
		  if (*(int *)(Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c_TypeInfo +
		              0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c_TypeInfo)
		    ;
		  }
		  puVar5 = *(undefined4 **)
		            (Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c_TypeInfo + 0x5c
		            );
		  param1_01 = puVar5[1];
		  if (param1_01 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c_TypeInfo +
		                0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c_TypeInfo
		                    );
		      puVar5 = *(undefined4 **)
		                (Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c_TypeInfo +
		                0x5c);
		    }
		    uVar1 = *puVar5;
		    param1_01 = unnamed_function_1417
		                          (System_Func_ProtoGetDollArtsAns_Types_DollsOwner__ulong__TypeInfo);
		    func_ii_7542(param1_01,uVar1,
		                 Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c__GetDollArtifactsResultHandler_b__4_0__
		                 ,0);
		    *(int *)(*(int *)(
		                     Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c_TypeInfo
		                     + 0x5c) + 4) = param1_01;
		  }
		  uVar1 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (iVar4,param1_01,
		                     Method_System_Linq_Enumerable_Select_ProtoGetDollArtsAns_Types_DollsOwner__ulong___
		                    );
		  uVar1 = System_Linq_Enumerable__ToArray_PlayerLoopSystem_
		                    (uVar1,Method_System_Linq_Enumerable_ToArray_ulong___);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x158);
		        goto code_r0x80f8ee4c;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80f8ee4c:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  piVar3 = *(int **)(iVar4 + 0x14);
		  uVar6 = 0;
		  param1_00 = unnamed_function_1417(Core_Cache_CacheResultCallback_UserData__TypeInfo);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		            (param1_00,param2_00,
		             Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c__DisplayClass4_0__GetDollArtifactsResultHandler_b__1__
		             ,0);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x80f8eef2;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Cache_ICache_ulong__UserData__TypeInfo,1);
		code_r0x80f8eef2:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1_00,uVar1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001362")]
		[Address(RVA = "0x6552", Offset = "0x6552", VA = "0x6552")]
		private void GetDollArtifactsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetDollArtifactsResultHandler ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController__GetDollArtifactsResultHandler
		               (int *param1,undefined8 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel__get_FiltersData
		            (param1_00,*(undefined4 *)(param4 + 0x10),param3,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001363")]
		[Address(RVA = "0x6553", Offset = "0x6553", VA = "0x6553")]
		private void UsersRequestedEventHandler(long operationIndex, UserData[] data, ProtoGetDollArtsAns msg)
		{
		/* --- GHIDRA: UsersRequestedEventHandler ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController__UsersRequestedEventHandler
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58c46 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController_TakeOffArtifactsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&Method_System_ValueTuple_ulong__ulong_____ctor__);
		    Mono_Security_ASN1__get_Item(&System_ValueTuple_ulong__ulong____TypeInfo);
		    DAT_ram_00a58c46 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ColossusService__GetHeroesRating
		                    (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController_TakeOffArtifactsResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_8 = 0;
		  local_10 = 0;
		  System_ValueTuple_uint__uint___ToString
		            (&local_10,param2,param3,Method_System_ValueTuple_ulong__ulong_____ctor__);
		  local_18 = local_8;
		  local_20 = local_10;
		  uVar2 = func_ii_1081(System_ValueTuple_ulong__ulong____TypeInfo,&local_20);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,uVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001364")]
		[Address(RVA = "0x6554", Offset = "0x6554", VA = "0x6554")]
		public void TakeOffArtifacts(ulong userId, params ulong[] dollIds)
		{
		/* --- GHIDRA: TakeOffArtifacts ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController__TakeOffArtifacts
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined8 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 param1_00;
		  undefined8 uVar9;
		  
		  if (DAT_ram_00a58c47 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_First_ClanEquipmentModel_DollsOwner___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedStackableChangesErrors___
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_ClanEquipmentModel_DollsOwner__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c__DisplayClass7_0__TakeOffArtifactsResultHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c__DisplayClass7_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_ValueTuple_ulong__ulong____TypeInfo);
		    DAT_ram_00a58c47 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c__DisplayClass7_0_TypeInfo
		                    );
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar7 = *(int **)(param2 + 0x20);
		  if ((piVar7 != (int *)0x0) && (Protocol_Main_ProtoStackableChangesAns_TypeInfo != *piVar7)) {
		    System_Activator__CreateInstance(piVar7,Protocol_Main_ProtoStackableChangesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar7[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedStackableChangesErrors___
		                    );
		  if (iVar3 == 0) {
		    piVar7 = *(int **)(param2 + 0xc);
		    if (piVar7 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar7 + 0x20) != *(int *)(System_ValueTuple_ulong__ulong____TypeInfo + 0x20)) {
		      System_Activator__CreateInstance(piVar7,System_ValueTuple_ulong__ulong____TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar4 = (undefined8 *)func_ii_15774(piVar7);
		    iVar8 = *(int *)(puVar4 + 1);
		    *(undefined8 *)(iVar2 + 8) = *puVar4;
		    uVar9 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar9);
		    uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		    param1_00 = *(undefined4 *)(iVar3 + 0x34);
		    uVar5 = unnamed_function_1417(System_Func_ClanEquipmentModel_DollsOwner__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar5,iVar2,
		               Method_Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c__DisplayClass7_0__TakeOffArtifactsResultHandler_b__0__
		               ,0);
		    iVar2 = func_ii_7423(param1_00,uVar5,
		                         Method_System_Linq_Enumerable_First_ClanEquipmentModel_DollsOwner___);
		    if (0 < *(int *)(iVar8 + 0xc)) {
		      iVar3 = 0;
		      do {
		        uVar9 = *(undefined8 *)(iVar8 + iVar3 * 8 + 0x10);
		        iVar6 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                          (*(undefined4 *)(iVar2 + 0xc),uVar9,
		                           Method_System_Collections_Generic_Dictionary_ulong__ClanEquipmentModel_DollArtifacts__get_Item__
		                          );
		        uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		        uVar5 = Mono_Security_ASN1Convert__ToOid(Core_Data_ArtifactData___TypeInfo,0);
		        *(undefined4 *)(iVar6 + 0xc) = uVar5;
		        iVar3 = iVar3 + 1;
		      } while (iVar3 < *(int *)(iVar8 + 0xc));
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x114)));
		    iVar2 = *(int *)(iVar2 + 0x18);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001365 RID: 4965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001365")]
		[Address(RVA = "0x6555", Offset = "0x6555", VA = "0x6555")]
		private void TakeOffArtifactsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: TakeOffArtifactsResultHandler ---
		void Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController__TakeOffArtifactsResultHandler
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58c48 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c_TypeInfo);
		    DAT_ram_00a58c48 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (Gameplay_WorldAxis_ClanEquipment_Controller_ClanEquipmentController___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000A6B RID: 2667
		[Token(Token = "0x4000A6B")]
		[FieldOffset(Offset = "0x18")]
		private ColossusService _service;
	}
}
