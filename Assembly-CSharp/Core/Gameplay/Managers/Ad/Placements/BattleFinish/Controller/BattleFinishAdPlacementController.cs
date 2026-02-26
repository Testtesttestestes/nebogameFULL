using System;
using Core.Gameplay.Managers.Ad.Controller;
using Core.Gameplay.Managers.Ad.Events;
using Core.Gameplay.Managers.Ad.Placements.Base.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleFinish.Model;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Main;
using Utils.CoroutineUtils;

namespace Core.Gameplay.Managers.Ad.Placements.BattleFinish.Controller
{
	// Token: 0x02001216 RID: 4630
	[Token(Token = "0x2001216")]
	public class BattleFinishAdPlacementController : AbstractAdPlacementController<BattleFinishAdPlacementModel, BattleFinishAdPlacementEvents>
	{
		// Token: 0x06006DB9 RID: 28089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DB9")]
		[Address(RVA = "0xB879", Offset = "0xB879", VA = "0xB879")]
		public BattleFinishAdPlacementController(BattleFinishAdPlacementModel model, BattleFinishAdPlacementEvents events, IAdController adController, AdEvents adEvents)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_Ad_Placements_BattleFinish_Controller_BattleFinishAdPlacementController___ctor
		          (int *param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  uint uVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  int *param1_00;
		  int iVar9;
		  int *param1_01;
		  int iVar10;
		  undefined1 local_6;
		  undefined1 local_5;
		  undefined1 local_4;
		  undefined1 local_3;
		  undefined1 local_2;
		  char local_1;
		  
		  if (DAT_ram_00a5a79a == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_ArtifactInfo___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3827);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26425);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21974);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24289);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20485);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24706);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24810);
		    DAT_ram_00a5a79a = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = UnityEngine_Purchasing_Utils_ProductDetailsConverter__BuildProductDescription
		                    (*(undefined4 *)(*(int *)(*(int *)(param2 + 0x20) + 8) + 0x10),
		                     Method_System_Linq_Enumerable_FirstOrDefault_ArtifactInfo___);
		  cVar1 = *(char *)(param2 + 8);
		  iVar9 = *(int *)(param2 + 0x1c);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar4 + 0xc);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x8126b9e2;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_01,
		                                Core_Gameplay_Managers_Ad_Placements_IAdPlacementData_TypeInfo,4);
		code_r0x8126b9e2:
		  uVar2 = 0;
		  uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(param1_01,puVar5[1]);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x8126ba62;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8126ba62:
		  uVar7 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		  uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		  iVar4 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar7,StringLiteral_20485,0);
		  if (iVar4 == 0) {
		    uVar2 = 1;
		  }
		  else {
		    iVar10 = *param1_00;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + iVar10 + 0x160);
		          goto code_r0x8126bb06;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		    }
		    puVar5 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x8126bb06:
		    uVar2 = 0;
		    uVar7 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		    iVar10 = *param1_00;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + iVar10 + 0x140);
		          goto code_r0x8126bb8c;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		    }
		    puVar5 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8126bb8c:
		    uVar8 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		    uVar8 = func_ii_7112(uVar8,0);
		    uVar2 = Core_Gameplay_Managers_Requirements_RequirementsManager__GetRequirementDic
		                      (uVar7,iVar4,uVar8,0);
		  }
		  iVar4 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,6);
		  *(undefined4 *)(iVar4 + 0x10) = StringLiteral_3827;
		  local_1 = cVar1;
		  uVar7 = func_ii_1081(DAT_ram_00a66944,&local_1);
		  uVar7 = func_ii_4419(StringLiteral_24810,uVar7,0);
		  *(undefined4 *)(iVar4 + 0x14) = uVar7;
		  local_2 = iVar3 != 0;
		  uVar7 = func_ii_1081(DAT_ram_00a66944,&local_2);
		  uVar7 = func_ii_4419(StringLiteral_24289,uVar7,0);
		  *(undefined4 *)(iVar4 + 0x18) = uVar7;
		  local_3 = iVar9 == 3;
		  uVar7 = func_ii_1081(DAT_ram_00a66944,&local_3);
		  uVar7 = func_ii_4419(StringLiteral_21974,uVar7,0);
		  *(undefined4 *)(iVar4 + 0x1c) = uVar7;
		  local_4 = (undefined1)uVar6;
		  uVar7 = func_ii_1081(DAT_ram_00a66944,&local_4);
		  uVar7 = func_ii_4419(StringLiteral_24706,uVar7,0);
		  *(undefined4 *)(iVar4 + 0x20) = uVar7;
		  local_5 = (undefined1)uVar2;
		  uVar7 = func_ii_1081(DAT_ram_00a66944,&local_5);
		  uVar2 = ((iVar9 == 3 && cVar1 != '\0') && iVar3 != 0) & uVar6 & uVar2;
		  local_6 = (undefined1)uVar2;
		  uVar8 = func_ii_1081(DAT_ram_00a66944,&local_6);
		  uVar7 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_26425,uVar7,uVar8,0);
		  *(undefined4 *)(iVar4 + 0x24) = uVar7;
		  uVar7 = System_Single__ToString(iVar4,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar7,0);
		  if (uVar2 == 0) {
		    uVar7 = unnamed_function_1417(Utils_CoroutineUtils_WaitForCallBack_bool__TypeInfo);
		    UnityEngine_UIElements_VisualElement_VisualElementScheduledItem___Il2CppFullySharedGenericType____ctor
		              (uVar7,0,Method_Utils_CoroutineUtils_WaitForCallBack_bool___ctor__);
		  }
		  else {
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0x268);
		          goto code_r0x8126bd9a;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		    }
		    puVar5 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x35);
		code_r0x8126bd9a:
		    iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		    uVar7 = *(undefined4 *)(iVar3 + 0x10);
		    iVar4 = *param1;
		    iVar3 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x100) * 4))
		                      (param1,*(undefined4 *)(iVar4 + 0x104));
		    uVar7 = Core_Gameplay_Managers_Ad_Controller_AbstractAdController__DestroyAllProviders
		                      (uVar7,*(undefined4 *)(iVar3 + 0xc),iVar4);
		  }
		  return uVar7;
		}
		*/

		}

		// Token: 0x06006DBA RID: 28090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006DBA")]
		[Address(RVA = "0xB87A", Offset = "0xB87A", VA = "0xB87A")]
		public WaitForCallBack<bool> IsAdAvailable(GameOverData gameOverData)
		{
		/* --- GHIDRA: IsAdAvailable ---
		void Core_Gameplay_Managers_Ad_Placements_BattleFinish_Controller_BattleFinishAdPlacementController__IsAdAvailable
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a5a79b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents__HandleRun__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_BattleFinish_Controller_BattleFinishAdPlacementController_OnDropRemoveEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a79b = '\x01';
		  }
		  Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_object__object___AdRewardedEvent
		            (param1,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents__HandleRun__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x150);
		        goto code_r0x8126beb8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x8126beb8:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x10);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar5 + 0x10),*(undefined4 *)(iVar6 + 0x114));
		  param1_01 = *(undefined4 *)(iVar5 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_Ad_Placements_BattleFinish_Controller_BattleFinishAdPlacementController_OnDropRemoveEvent__
		             ,0);
		  iVar6 = UnityEngine_UI_Image__set_sprite(param1_01,uVar3,0);
		  uVar3 = System_Action_DropTypes__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar5 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,System_Action_DropTypes__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar5 + 0x18) = iVar4;
		    uVar3 = System_Action_DropTypes__TypeInfo;
		    iVar5 = func_ii_1082(iVar6,System_Action_DropTypes__TypeInfo);
		    if (iVar5 != 0) {
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

			return null;
		}

		// Token: 0x06006DBB RID: 28091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DBB")]
		[Address(RVA = "0xB87B", Offset = "0xB87B", VA = "0xB87B", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Core_Gameplay_Managers_Ad_Placements_BattleFinish_Controller_BattleFinishAdPlacementController__HandleRun
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006DBC RID: 28092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DBC")]
		[Address(RVA = "0xB87C", Offset = "0xB87C", VA = "0xB87C")]
		private void OnDropRemoveEvent(DropTypes dropTypes)
		{
		/* --- GHIDRA: OnDropRemoveEvent ---
		void Core_Gameplay_Managers_Ad_Placements_BattleFinish_Controller_BattleFinishAdPlacementController__OnDropRemoveEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  int iVar6;
		  
		  if (DAT_ram_00a5a79c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents__HandleStop__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_BattleFinish_Controller_BattleFinishAdPlacementController_OnDropRemoveEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a79c = '\x01';
		  }
		  Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_object__object___HandleRun
		            (param1,
		             Method_Core_Gameplay_Managers_Ad_Placements_Base_Controller_AbstractAdPlacementController_BattleFinishAdPlacementModel__BattleFinishAdPlacementEvents__HandleStop__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x150);
		        goto code_r0x8126c042;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x8126c042:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x10);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar5 + 0x10),*(undefined4 *)(iVar6 + 0x114));
		  param1_01 = *(undefined4 *)(iVar5 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_Ad_Placements_BattleFinish_Controller_BattleFinishAdPlacementController_OnDropRemoveEvent__
		             ,0);
		  iVar6 = func_ii_7048(param1_01,uVar3,0);
		  uVar3 = System_Action_DropTypes__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar5 + 0x18) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,System_Action_DropTypes__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar5 + 0x18) = iVar4;
		    uVar3 = System_Action_DropTypes__TypeInfo;
		    iVar5 = func_ii_1082(iVar6,System_Action_DropTypes__TypeInfo);
		    if (iVar5 != 0) {
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

		// Token: 0x06006DBD RID: 28093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DBD")]
		[Address(RVA = "0xB87D", Offset = "0xB87D", VA = "0xB87D", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Core_Gameplay_Managers_Ad_Placements_BattleFinish_Controller_BattleFinishAdPlacementController__HandleStop
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8,undefined4 param9)
		
		{
		  if (DAT_ram_00a5a79d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents___ctor__
		              );
		    DAT_ram_00a5a79d = '\x01';
		  }
		  Unity_Services_Core_Internal_DependencyTree___ctor
		            (param1,param2,param3,param4,param5,
		             Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = param8;
		  *(undefined4 *)(param1 + 0x28) = param7;
		  *(undefined4 *)(param1 + 0x24) = param6;
		  return;
		}
		*/

		}
	}
}
