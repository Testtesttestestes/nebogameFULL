using System;
using Gameplay.UserInterface.Events;
using Gameplay.UserInterface.Model;
using Gameplay.UserInterface.View.UserGotNewLevel;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Control
{
	// Token: 0x020003EA RID: 1002
	[Token(Token = "0x20003EA")]
	public class UserGotNewLevelWindowViewMediator : AbstractViewMediator<UserInterfaceModel, UserInterfaceEvents, UserInterfaceController, UserGotNewLevelWindow>
	{
		// Token: 0x0600175D RID: 5981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175D")]
		[Address(RVA = "0x691A", Offset = "0x691A", VA = "0x691A")]
		public UserGotNewLevelWindowViewMediator(UserInterfaceModel model, UserInterfaceEvents events, UserInterfaceController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a598a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserGotNewLevelWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator_HandleUserLevelRewardGetSuccessEvent__
		              );
		    DAT_ram_00a598a8 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar2,param1,
		               Method_Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator_HandleUserLevelRewardGetSuccessEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_bool__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_bool__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x30) = iVar4;
		      uVar2 = System_Action_bool__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_bool__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x30);
		    uVar2 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar2,param1,
		               Method_Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator_HandleUserLevelRewardGetSuccessEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_bool__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x30) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_bool__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x30) = iVar4;
		    uVar2 = System_Action_bool__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_bool__TypeInfo);
		    if (iVar1 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700040F RID: 1039
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040F")]
		public override UserInterfaceEvents Events
		{
			[Token(Token = "0x600175E")]
			[Address(RVA = "0x691B", Offset = "0x691B", VA = "0x691B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000410 RID: 1040
		// (set) Token: 0x0600175F RID: 5983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000410")]
		public override UserGotNewLevelWindow View
		{
			[Token(Token = "0x600175F")]
			[Address(RVA = "0x691C", Offset = "0x691C", VA = "0x691C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001760")]
		[Address(RVA = "0x691D", Offset = "0x691D", VA = "0x691D")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a598ab == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator_HandleGetRewardButtonClickEvent__
		              );
		    DAT_ram_00a598ab = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(*(int *)(iVar1 + 0x40) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator_HandleGetRewardButtonClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001761")]
		[Address(RVA = "0x691E", Offset = "0x691E", VA = "0x691E")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar1 + 0x40),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_UserInterface_Control_UserInterfaceController__NotifyUserGoNewLevel(uVar2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001762")]
		[Address(RVA = "0x691F", Offset = "0x691F", VA = "0x691F")]
		private void HandleGetRewardButtonClickEvent()
		{
		/* --- GHIDRA: HandleGetRewardButtonClickEvent ---
		void Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator__HandleGetRewardButtonClickEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param3_00;
		  int *param1_00;
		  undefined4 param1_01;
		  int iVar5;
		  undefined4 local_30;
		  undefined4 local_2c;
		  undefined4 uStack_28;
		  undefined4 uStack_24;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  int *local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a598ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_UserGotNewLevelWindow_UserGotNewLevelWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_Names_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_Scopes_TypeInfo);
		    DAT_ram_00a598ac = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = func_ii_8093(uVar2,
		                       Method_UI_Windows_BaseWindow_UserGotNewLevelWindow_UserGotNewLevelWindowArgs__get_WindowArgs__
		                      );
		  iVar5 = **(int **)(iVar3 + 0x18);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (*(int **)(iVar3 + 0x18),*(undefined4 *)(iVar5 + 0x104));
		  param1_00 = *(int **)(iVar3 + 0x20);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x140);
		        goto code_r0x810823ce;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x810823ce:
		  iVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  param1_01 = *(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x3c);
		  local_1c = 0xffffffff;
		  local_20 = Utils_LocalProps_Scopes_TypeInfo;
		  uVar2 = Spine_SkeletonJson__GetFloat(&local_20,0);
		  local_2c = 0xffffffff;
		  uStack_28 = 0;
		  local_30 = Utils_LocalProps_Names_TypeInfo;
		  param3_00 = Spine_SkeletonJson__GetFloat(&local_30,0);
		  uVar2 = Utils_LocalProps__GetOrCreate(param1_01,uVar2,param3_00,0,0);
		  Utils_LocalProps__SetProp(uVar2,0);
		  if (param2 == 0) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(uVar2,1,0);
		  }
		  else {
		    if (DAT_ram_00a598ad == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UserGotNewLevelWindowViewMediator__HandleGetReward_d__9___
		                );
		      DAT_ram_00a598ad = '\x01';
		    }
		    local_8 = 0;
		    System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		    local_14 = CONCAT44(uStack_24,uStack_28);
		    local_20 = 0xffffffff;
		    local_1c = CONCAT44(local_2c,local_30);
		    local_c = param1;
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_UserEquipmentViewMediator__ShowAntiqGroupReview_d__13_
		              (&local_1c,&local_20,
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UserGotNewLevelWindowViewMediator__HandleGetReward_d__9___
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001763")]
		[Address(RVA = "0x6920", Offset = "0x6920", VA = "0x6920")]
		private void HandleUserLevelRewardGetSuccessEvent(bool isSuccess)
		{
		/* --- GHIDRA: HandleUserLevelRewardGetSuccessEvent ---
		void Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator__HandleUserLevelRewardGetSuccessEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a598ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UserGotNewLevelWindowViewMediator__HandleGetReward_d__9___
		              );
		    DAT_ram_00a598ad = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_UserEquipmentViewMediator__ShowAntiqGroupReview_d__13_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UserGotNewLevelWindowViewMediator__HandleGetReward_d__9___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001764")]
		[Address(RVA = "0x6921", Offset = "0x6921", VA = "0x6921")]
		private void HandleGetReward()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a598a9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserGotNewLevelWindow__set_View__
		              );
		    DAT_ram_00a598a9 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a598ab == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator_HandleGetRewardButtonClickEvent__
		                );
		      DAT_ram_00a598ab = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator_HandleGetRewardButtonClickEvent__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(param1_00,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  undefined8 in_i2q;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int param1_00;
		  int iVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  double param3;
		  int *piVar8;
		  uint uVar9;
		  int *piVar10;
		  int local_28;
		  undefined1 *puStack_24;
		  undefined8 local_20;
		  undefined1 local_18 [8];
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  uVar3 = (undefined4)((ulonglong)in_i2q >> 0x20);
		  if (DAT_ram_00a598aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserGotNewLevelWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_UserGotNewLevelWindow_ResourceRewardData__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_UserGotNewLevelWindow_ResourceRewardData__ToArray__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_UserGotNewLevelWindow_ResourceRewardData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_UserGotNewLevelWindow_ResourceRewardData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow_ResourceRewardData_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator_HandleGetRewardButtonClickEvent__
		              );
		    DAT_ram_00a598aa = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar8 = *(int **)(iVar1 + 0x3c);
		  local_4 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1[2] + 8),0);
		  uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		  iVar1 = *piVar8;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar8,uVar2,CONCAT44(uVar3,*(undefined4 *)(iVar1 + 0x2d4)));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x40) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_UserInterface_Control_UserGotNewLevelWindowViewMediator_HandleGetRewardButtonClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar3,0);
		  piVar8 = *(int **)(param1[2] + 0x10);
		  iVar1 = *piVar8;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar9 * 8 + 4) * 8 + iVar1 + 0xd0);
		        goto code_r0x81081cfd;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar9);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x81081cfd:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  uVar2 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1[2] + 8),0);
		  iVar1 = Core_Extensions_Dict_DictExt__GetCaveLevel(uVar3,uVar2,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_UserGotNewLevelWindow_ResourceRewardData__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_UserGotNewLevelWindow_ResourceRewardData___ctor__
		            );
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__GetResourcesIds(*(undefined4 *)(iVar1 + 0x40),0);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_28,uVar3,Method_System_Collections_Generic_List_Resources__GetEnumerator__);
		  local_10 = local_20;
		  local_28 = 0;
		  puStack_24 = local_18;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21f,local_18,
		                       Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81082088;
		    }
		    iVar7 = local_28;
		    if (iVar5 == 0) goto code_r0x810820d1;
		    uVar3 = local_10._4_4_;
		    piVar8 = *(int **)(param1[2] + 0x10);
		    iVar7 = *piVar8;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar10) {
		          puVar6 = (undefined4 *)(piVar10[1] * 8 + iVar7 + 0xd0);
		          goto code_r0x81081e78;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                        Core_Dict_IDictProvider_TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x81081e78:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x334,uVar2,uVar3,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81082088;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d6,uVar2,0)
		    ;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81082088;
		    }
		    DAT_ram_009d3e38 = 0;
		    param3 = func_ii_6906(*(undefined4 *)(iVar1 + 0x40),uVar3,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81082088;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow_ResourceRewardData_TypeInfo
		                      );
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8108206c:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81082088;
		    }
		    DAT_ram_009d3e38 = 0;
		    func_ii_7971(uVar3,uVar2,param3,0);
		    iVar7 = Method_System_Collections_Generic_List_UserGotNewLevelWindow_ResourceRewardData__Add__;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8108206c;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar9 = *(uint *)(param1_00 + 0xc);
		    if (uVar9 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar9 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar9 * 4 + 0x10) = uVar3;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param1_00,uVar3,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81082088:
		        iVar1 = global_1;
		        iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar1 == iVar7) {
		          piVar8 = (int *)import::env::__cxa_begin_catch(uVar3);
		          iVar7 = *piVar8;
		          DAT_ram_009d3e38 = 0;
		          local_28 = iVar7;
		          import::env::invoke_v(0x123);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 != 1) {
		code_r0x810820d1:
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 0) {
		              uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x15c));
		              uVar2 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                                (param1_00,
		                                 Method_System_Collections_Generic_List_UserGotNewLevelWindow_ResourceRewardData__ToArray__
		                                );
		              Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__ShowGetContentRoutine
		                        (uVar3,uVar2,0);
		              uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                                (param1,*(undefined4 *)(*param1 + 0x15c));
		              Gameplay_UserInterface_View_UserGotNewLevel_UserGotNewLevelWindow__SetResources
		                        (uVar3,0);
		              return;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar3 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x21,&local_28);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x81082088;
		}
		*/

}
