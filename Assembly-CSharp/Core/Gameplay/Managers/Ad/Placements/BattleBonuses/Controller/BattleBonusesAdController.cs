using System;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.Base.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Model;
using Il2CppDummyDll;
using Protocol.Main;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Controller
{
	// Token: 0x0200121A RID: 4634
	[Token(Token = "0x200121A")]
	public class BattleBonusesAdController : AbstractAdPlacementController<BattleBonusesAdModel, BattleBonusesAdEvents>
	{
		// Token: 0x06006DC9 RID: 28105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DC9")]
		[Address(RVA = "0xB888", Offset = "0xB888", VA = "0xB888")]
		public BattleBonusesAdController(BattleBonusesAdModel model, BattleBonusesAdEvents events, IAdController adController, AdEvents adEvents)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a5a7a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleBonusesAdModel__BattleBonusesAdEvents__HandleRun__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MedalInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController_MedalAddedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController_MedalRemovedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a7a8 = '\x01';
		  }
		  Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_object__object___AdRewardedEvent
		            (param1,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleBonusesAdModel__BattleBonusesAdEvents__HandleRun__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x130);
		        goto code_r0x8126d774;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x8126d774:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 0x18);
		  uVar8 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_MedalInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController_MedalAddedEvent__
		             ,0);
		  iVar6 = UnityEngine_UI_Image__set_sprite(uVar8,uVar3,0);
		  uVar3 = System_Action_MedalInfo__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_MedalInfo__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x1c) = iVar4;
		    uVar3 = System_Action_MedalInfo__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_MedalInfo__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x130);
		        goto code_r0x8126d896;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x8126d896:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 0x18);
		  uVar8 = *(undefined4 *)(iVar7 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar3,param1,
		                Method_Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController_MedalRemovedEvent__
		                ,0);
		  iVar6 = UnityEngine_UI_Image__set_sprite(uVar8,uVar3,0);
		  uVar3 = System_Action_uint__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,System_Action_uint__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar7 + 0x18) = iVar4;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_uint__TypeInfo);
		    if (iVar7 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar6,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar6,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCA")]
		[Address(RVA = "0xB889", Offset = "0xB889", VA = "0xB889", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController__HandleRun
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController__MedalAddedEvent
		            (param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCB")]
		[Address(RVA = "0xB88A", Offset = "0xB88A", VA = "0xB88A")]
		private void MedalRemovedEvent(uint medalId)
		{
		/* --- GHIDRA: MedalRemovedEvent ---
		void Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController__MedalRemovedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController__MedalAddedEvent
		            (param1,*(undefined4 *)(param2 + 0xc),param2);
		  return;
		}
		*/

		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCC")]
		[Address(RVA = "0xB88B", Offset = "0xB88B", VA = "0xB88B")]
		private void MedalAddedEvent(MedalInfo medalInfo)
		{
		/* --- GHIDRA: MedalAddedEvent ---
		void Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController__MedalAddedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a7a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__Contains__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25328);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3821);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3820);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10932);
		    DAT_ram_00a5a7a9 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Core_Data_Skills_SkillData___ctor
		                    (*(undefined4 *)(iVar1 + 0x10),param2,
		                     Method_System_Collections_Generic_HashSet_uint__Contains__);
		  if (iVar1 == 0) {
		    local_8 = param2;
		    uVar2 = func_ii_1081(DAT_ram_00a66958,&local_8);
		    uVar2 = func_ii_4419(StringLiteral_25328,uVar2,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_3821,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  }
		  else {
		    local_4 = param2;
		    uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    uVar2 = func_ii_4419(StringLiteral_10932,uVar2,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_3820,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006DCD RID: 28109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCD")]
		[Address(RVA = "0xB88C", Offset = "0xB88C", VA = "0xB88C")]
		private void OnMedalsChanged(uint medalId)
		{
		/* --- GHIDRA: OnMedalsChanged ---
		void Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController__OnMedalsChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a5a7aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleBonusesAdModel__BattleBonusesAdEvents__HandleStop__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MedalInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController_MedalAddedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController_MedalRemovedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a7aa = '\x01';
		  }
		  Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_object__object___HandleRun
		            (param1,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleBonusesAdModel__BattleBonusesAdEvents__HandleStop__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x130);
		        goto code_r0x8126dbeb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x8126dbeb:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 0x18);
		  uVar8 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_MedalInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController_MedalAddedEvent__
		             ,0);
		  iVar6 = func_ii_7048(uVar8,uVar3,0);
		  uVar3 = System_Action_MedalInfo__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_MedalInfo__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x1c) = iVar4;
		    uVar3 = System_Action_MedalInfo__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_MedalInfo__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x130);
		        goto code_r0x8126dd0d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x8126dd0d:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 0x18);
		  uVar8 = *(undefined4 *)(iVar7 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar3,param1,
		                Method_Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController_MedalRemovedEvent__
		                ,0);
		  iVar6 = func_ii_7048(uVar8,uVar3,0);
		  uVar3 = System_Action_uint__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,System_Action_uint__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar7 + 0x18) = iVar4;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_uint__TypeInfo);
		    if (iVar7 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar6,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar6,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006DCE RID: 28110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCE")]
		[Address(RVA = "0xB88D", Offset = "0xB88D", VA = "0xB88D", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController__HandleStop
		          (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  uint uVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined1 local_4;
		  undefined1 local_3;
		  undefined1 local_2;
		  undefined1 local_1;
		  
		  if (DAT_ram_00a5a7ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19892);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3819);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24707);
		    Mono_Security_ASN1__get_Item(&StringLiteral_192);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24288);
		    DAT_ram_00a5a7ab = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar7 = *(int **)(iVar2 + 0xc);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x8126debe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,
		                                Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo,4);
		code_r0x8126debe:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  iVar2 = *param1;
		  uVar5 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar2 + 0x104));
		  iVar2 = Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Model_BattleBonusesAdModel__InitBonusMedals
		                    (uVar5,iVar2);
		  uVar1 = 0;
		  if (iVar2 != 0) {
		    iVar6 = func_ii_8766(iVar2,0);
		    uVar1 = func_ii_7183(iVar2,*(undefined4 *)(*(int *)(iVar6 + 0x10) + 0x20),0);
		    uVar1 = uVar1 ^ 1;
		  }
		  iVar6 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,5);
		  *(undefined4 *)(iVar6 + 0x10) = StringLiteral_3819;
		  local_1 = (undefined1)uVar4;
		  uVar5 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar5 = func_ii_4419(StringLiteral_24707,uVar5,0);
		  *(undefined4 *)(iVar6 + 0x14) = uVar5;
		  local_2 = iVar2 != 0;
		  uVar5 = func_ii_1081(DAT_ram_00a66944,&local_2);
		  uVar5 = func_ii_4419(StringLiteral_24288,uVar5,0);
		  *(undefined4 *)(iVar6 + 0x18) = uVar5;
		  local_3 = (undefined1)uVar1;
		  uVar5 = func_ii_1081(DAT_ram_00a66944,&local_3);
		  uVar5 = func_ii_4419(StringLiteral_19892,uVar5,0);
		  *(undefined4 *)(iVar6 + 0x1c) = uVar5;
		  uVar1 = uVar4 & iVar2 != 0 & uVar1;
		  local_4 = (undefined1)uVar1;
		  uVar5 = func_ii_1081(DAT_ram_00a66944,&local_4);
		  uVar5 = func_ii_4419(StringLiteral_192,uVar5,0);
		  *(undefined4 *)(iVar6 + 0x20) = uVar5;
		  uVar5 = System_Single__ToString(iVar6,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar5,0);
		  if (uVar1 == 0) {
		    uVar5 = unnamed_function_1417(Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    UnityEngine_UIElements_VisualElement_VisualElementScheduledItem___Il2CppFullySharedGenericType____ctor
		              (uVar5,0,Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		  }
		  else {
		    piVar7 = (int *)param1[6];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = *(undefined4 *)(iVar2 + 0xc);
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		          goto code_r0x8126e0d3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_Managers_Ad_Controller_IAdController_TypeInfo
		                                  ,1);
		code_r0x8126e0d3:
		    uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar5,puVar3[1]);
		  }
		  return uVar5;
		}
		*/

		}

		// Token: 0x06006DCF RID: 28111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DCF")]
		[Address(RVA = "0xB88E", Offset = "0xB88E", VA = "0xB88E")]
		public WaitForCallBack<bool> IsAdAvailable()
		{
		/* --- GHIDRA: IsAdAvailable ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BattleBonuses_Controller_BattleBonusesAdController__IsAdAvailable
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a7ac == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo);
		    DAT_ram_00a5a7ac = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x8126e182;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo,2);
		code_r0x8126e182:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

			return null;
		}
	}
}
