using System;
using Gameplay.Announcements.Model;
using Gameplay.Announcements.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Announcements.Control
{
	// Token: 0x02000DA8 RID: 3496
	[Token(Token = "0x2000DA8")]
	public class AnnouncementsViewMediator : AbstractViewMediator<AnnouncementsModel, AnnouncementsEvents, AnnouncementsController, AnnouncementsView>
	{
		// Token: 0x06005577 RID: 21879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005577")]
		[Address(RVA = "0xA317", Offset = "0xA317", VA = "0xA317")]
		public AnnouncementsViewMediator(AnnouncementsModel model, AnnouncementsEvents events, AnnouncementsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Announcements_Control_AnnouncementsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5883a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AnnouncementsModel__AnnouncementsEvents__AnnouncementsController__AnnouncementsView__set_View__
		              );
		    DAT_ram_00a5883a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5883b == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_Announcements_Control_AnnouncementsViewMediator_HandleActivityButtonClickEvent__
		                );
		      Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		      DAT_ram_00a5883b = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(*(int *)(iVar2 + 0x38) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Announcements_Control_AnnouncementsViewMediator_HandleActivityButtonClickEvent__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(param1_00,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Announcements_Control_AnnouncementsViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700115A RID: 4442
		// (set) Token: 0x06005578 RID: 21880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700115A")]
		public override AnnouncementsView View
		{
			[Token(Token = "0x6005578")]
			[Address(RVA = "0xA318", Offset = "0xA318", VA = "0xA318", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005579")]
		[Address(RVA = "0xA319", Offset = "0xA319", VA = "0xA319")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Announcements_Control_AnnouncementsViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 param1_01;
		  int param3;
		  
		  if (DAT_ram_00a5883c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Announcements_Control_AnnouncementsViewMediator_HandleActivityButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5883c = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar1);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  param1_01 = *(undefined4 *)(*(int *)(iVar2 + 0x38) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Announcements_Control_AnnouncementsViewMediator_HandleActivityButtonClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x14c)));
		  piVar4 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		  param3 = *piVar4;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(param3 + 0x130) * 4))
		                    (piVar4,*(undefined4 *)(param3 + 0x134));
		  Gameplay_Announcements_Control_AnnouncementsController__RequestList
		            (uVar3,*(undefined8 *)(*(int *)(iVar2 + 8) + 0x10),param3);
		  return;
		}
		*/

		}

		// Token: 0x0600557A RID: 21882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557A")]
		[Address(RVA = "0xA31A", Offset = "0xA31A", VA = "0xA31A")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Announcements_Control_AnnouncementsViewMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 param2_00;
		  
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		                        (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  Gameplay_Announcements_Control_AnnouncementsViewMediator__HandleActivityButtonClickEvent
		            (param1,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600557B RID: 21883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557B")]
		[Address(RVA = "0xA31B", Offset = "0xA31B", VA = "0xA31B")]
		private void HandleActivityButtonClickEvent()
		{
		/* --- GHIDRA: HandleActivityButtonClickEvent ---
		void Gameplay_Announcements_Control_AnnouncementsViewMediator__HandleActivityButtonClickEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  uint *puVar3;
		  int iVar4;
		  int *piVar5;
		  int *local_8;
		  undefined4 local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5883d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AnnouncementsModel__AnnouncementsEvents__AnnouncementsController__AnnouncementsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Rounting_ILocatorRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_ILocator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_GameActivityRouting_IRouter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Close_AnnouncementsWindow___);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    DAT_ram_00a5883d = '\x01';
		  }
		  local_4 = 0;
		  local_8 = (int *)0x0;
		  iVar4 = *(int *)(*(int *)(param2 + 8) + 0x20);
		  if (iVar4 != 0) {
		    uVar1 = *(undefined4 *)(iVar4 + 0x10);
		  }
		  if (*(int *)(System_Uri_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Uri_TypeInfo);
		  }
		  iVar4 = func_ii_16334(uVar1,0,&local_4,0);
		  if (iVar4 != 0) {
		    uVar2 = 0;
		    piVar5 = *(int **)(*(int *)(param1 + 8) + 0x14);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_GameActivityRouting_IRouter_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f3377e;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_Managers_GameActivityRouting_IRouter_TypeInfo
		                                  ,0);
		code_r0x80f3377e:
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    uVar1 = local_4;
		    uVar2 = 0;
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Rounting_ILocatorRepository_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f3380a;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Rounting_ILocatorRepository_TypeInfo,0);
		code_r0x80f3380a:
		    iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,uVar1,&local_8,puVar3[1]);
		    uVar1 = local_4;
		    piVar5 = local_8;
		    if (iVar4 != 0) {
		      uVar2 = 0;
		      iVar4 = *local_8;
		      if (*(ushort *)(iVar4 + 0xb6) != 0) {
		        do {
		          if (Core_Rounting_ILocator_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0xd0);
		            goto code_r0x80f33893;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		      }
		      puVar3 = (uint *)func_ii_1080(local_8,Core_Rounting_ILocator_TypeInfo,2);
		code_r0x80f33893:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar5,uVar1,puVar3[1]);
		    }
		  }
		  if (*(int *)(param1 + 8) != 0) {
		    DG_Tweening_Plugins_Core_PluginsManager__GetDefaultPlugin___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		              (*(undefined4 *)(*(int *)(param1 + 8) + 0x1c),2,
		               Method_UI_Windows_PopupController_Close_AnnouncementsWindow___);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600557C RID: 21884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600557C")]
		[Address(RVA = "0xA31C", Offset = "0xA31C", VA = "0xA31C")]
		private void HandleAnnouncementActivity(AnnouncementsData announcement)
		{
		/* --- GHIDRA: HandleAnnouncementActivity ---
		void Gameplay_Announcements_Control_AnnouncementsViewMediator__HandleAnnouncementActivity
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  int *local_4;
		  
		  if (DAT_ram_00a5883e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5883e = '\x01';
		  }
		  local_4 = (int *)0x0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x268);
		        goto code_r0x80f339a1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x35);
		code_r0x80f339a1:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar4 = Core_Gameplay_Managers_Ad_Model_AbstractAdModel__TryGetAdPlacementData
		                    (*(undefined4 *)(iVar4 + 0x14),3,&local_4,0);
		  piVar3 = local_4;
		  if (iVar4 != 0) {
		    if (local_4 != (int *)0x0) {
		      if (((uint)*(byte *)(*local_4 + 0xb8) <
		           (uint)*(byte *)(
		                          Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager_TypeInfo
		                          + 0xb8)) ||
		         (*(int *)(*(int *)(*local_4 + 100) +
		                   (uint)*(byte *)(
		                                  Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager_TypeInfo
		                                  + 0xb8) * 4 + -4) !=
		          Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager_TypeInfo))
		      {
		        System_Activator__CreateInstance
		                  (local_4,
		                   Core_Gameplay_Managers_Ad_Placements_EnergyRegen_EnergyRegenAdPlacementManager_TypeInfo
		                  );
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    if (DAT_ram_00a5883f == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_Ad_EnergyRegenAd_View_EnergyRegenAdEntryView__HandleAdAvailability_d__3_TypeInfo
		                );
		      DAT_ram_00a5883f = '\x01';
		    }
		    iVar4 = unnamed_function_1417
		                      (
		                      Gameplay_Ad_EnergyRegenAd_View_EnergyRegenAdEntryView__HandleAdAvailability_d__3_TypeInfo
		                      );
		    *(undefined4 *)(iVar4 + 0x18) = param1;
		    *(undefined4 *)(iVar4 + 8) = 0;
		    *(undefined4 *)(iVar4 + 0x14) = param2;
		    *(int **)(iVar4 + 0x10) = piVar3;
		    UnityEngine_MonoBehaviour__StartCoroutine(param1,iVar4,0);
		  }
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Announcements_Control_AnnouncementsViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5883b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Announcements_Control_AnnouncementsViewMediator_HandleActivityButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5883b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(*(int *)(iVar1 + 0x38) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Announcements_Control_AnnouncementsViewMediator_HandleActivityButtonClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

}
