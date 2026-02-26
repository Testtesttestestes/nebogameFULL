using System;
using Core.Data;
using Gameplay.ArenaCombat.Model;
using Gameplay.Combat.Control;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.ArenaCombat.Control
{
	// Token: 0x02000D4B RID: 3403
	[Token(Token = "0x2000D4B")]
	public class ArenaCombatViewMediator : OneOnOneCombatViewMediator<ArenaCombatModel, ArenaCombatEvents, ArenaCombatController>
	{
		// Token: 0x06005358 RID: 21336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005358")]
		[Address(RVA = "0xA117", Offset = "0xA117", VA = "0xA117")]
		public ArenaCombatViewMediator(ArenaCombatModel model, ArenaCombatEvents events, ArenaCombatController controller)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_ArenaCombat_Control_ArenaCombatViewMediator___ctor
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a593dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__OneOnOneCombatView__ShowAwaitCombatWindow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2797);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2798);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6233);
		    DAT_ram_00a593dd = '\x01';
		  }
		  param1_00 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___RunShowCombatViewProcess
		                        (param1,param2,
		                         Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__OneOnOneCombatView__ShowAwaitCombatWindow__
		                        );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_6233,1,0,1,0,0,0,0);
		  Gameplay_Combat_View_CombatWaitingWindowMono__HideWaitingWindow(param1_00,uVar1,0);
		  iVar2 = *(int *)(*(int *)(*(int *)(param1 + 8) + 0x60) + 8);
		  if (iVar2 == 1) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_2797,1,0,1,0,0,0,0);
		  }
		  else if (iVar2 == 2) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_2798,1,0,1,0,0,0,0);
		  }
		  else {
		    uVar1 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  Core_Extensions_StringExt__Replacer(param1_00,uVar1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06005359 RID: 21337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005359")]
		[Address(RVA = "0xA118", Offset = "0xA118", VA = "0xA118", Slot = "33")]
		protected override CombatWaitingWindowMono ShowAwaitCombatWindow(BackTime backTime)
		{
		/* --- GHIDRA: ShowAwaitCombatWindow ---
		int Gameplay_ArenaCombat_Control_ArenaCombatViewMediator__ShowAwaitCombatWindow
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  byte bVar1;
		  longlong lVar2;
		  undefined4 in_register_20000014;
		  int iVar3;
		  undefined4 param1_00;
		  uint *puVar4;
		  longlong lVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 param3_00;
		  int iVar8;
		  undefined4 param1_01;
		  int *piVar9;
		  undefined8 uVar10;
		  uint uVar11;
		  byte local_10;
		  longlong local_8;
		  
		  if (DAT_ram_00a593de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__OneOnOneCombatView__HandleGameOverWindowCloseRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__get_HasValue__);
		    DAT_ram_00a593de = '\x01';
		  }
		  iVar6 = *(int *)(param1 + 8);
		  uVar7 = *(undefined4 *)(iVar6 + 0x50);
		  param3_00 = *(undefined4 *)(iVar6 + 0x5c);
		  iVar8 = *(int *)(iVar6 + 0x60);
		  param1_01 = *(undefined4 *)(iVar6 + 8);
		  iVar3 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleGameOver
		                    (param1,param2,
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__OneOnOneCombatView__HandleGameOverWindowCloseRequestEvent__
		                    );
		  if (iVar3 == 0) {
		    param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(param1_00,uVar7,0);
		    if (*(int *)(iVar8 + 8) == 0) {
		      Gameplay_ArenaCombat_Control_ArenaCombatViewMediator__HandleGameOverWindowCloseRequestEvent
		                (iVar6,param1_01,param3_00,iVar6);
		    }
		    else if (*(char *)(iVar8 + 0xc) != '\0') {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *piVar9;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar11 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar11 * 8 + 4) * 8 + iVar6 + 0x110)
		            ;
		            goto code_r0x80ffb986;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar11);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ffb986:
		      iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,CONCAT44(in_register_20000014,puVar4[1]))
		      ;
		      iVar6 = *(int *)(*(int *)(iVar6 + 0x14) + 0x24);
		      if (iVar6 == 0) {
		        System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param1_01,0);
		      }
		      else {
		        uVar10 = *(undefined8 *)(*(int *)(iVar6 + 0x10) + 0x10);
		        local_8 = 0;
		        _local_10 = 0;
		        Core_Log_Files_FileDownloadLogger__LogDownload
		                  (&local_10,uVar10,Method_System_Nullable_ulong___ctor__);
		        lVar2 = local_8;
		        bVar1 = local_10;
		        uVar7 = (undefined4)((ulonglong)uVar10 >> 0x20);
		        lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param1_01,0);
		        if ((bVar1 != 0) && (lVar2 == lVar5)) {
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar6 = *piVar9;
		          if (*(ushort *)(iVar6 + 0xb6) != 0) {
		            uVar11 = 0;
		            do {
		              if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar11 * 8)) {
		                puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar11 * 8 + 4) * 8 + iVar6 +
		                                 0x110);
		                goto code_r0x80ffba98;
		              }
		              uVar11 = uVar11 + 1;
		            } while (*(ushort *)(iVar6 + 0xb6) != uVar11);
		          }
		          puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ffba98:
		          iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,CONCAT44(uVar7,puVar4[1]));
		          uVar7 = *(undefined4 *)(iVar6 + 0x14);
		          uVar10 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param1_01,0);
		          uVar7 = Gameplay_World_Model_WorldModel__set_IsMovingOnWorldLevel(uVar7,uVar10,0);
		          Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		                    (uVar7,2,
		                     Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		                    );
		        }
		      }
		    }
		  }
		  return iVar3;
		}
		*/

			return null;
		}

		// Token: 0x0600535A RID: 21338 RVA: 0x0000F138 File Offset: 0x0000D338
		[Token(Token = "0x600535A")]
		[Address(RVA = "0xA119", Offset = "0xA119", VA = "0xA119", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
		/* --- GHIDRA: HandleGameOverWindowCloseRequestEvent ---
		void Gameplay_ArenaCombat_Control_ArenaCombatViewMediator__HandleGameOverWindowCloseRequestEvent
		               (undefined4 param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  undefined8 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  uint uVar9;
		  
		  if (DAT_ram_00a593df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a593df = '\x01';
		  }
		  if (param3 == (int *)0x0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 0x180);
		          goto code_r0x80ffbbae;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x18);
		code_r0x80ffbbae:
		    uVar7 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,CONCAT44(in_register_20000014,puVar1[1]));
		    Core_Gameplay_Managers_ClientStateManager__HandleInitializeComplete(uVar7,0);
		    return;
		  }
		  if (DAT_ram_00a593d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_IMonsterSource_TypeInfo);
		    DAT_ram_00a593d1 = '\x01';
		  }
		  piVar5 = (int *)param3[3];
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Gameplay_Isles_User_IMonsterSource_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		        puVar1 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ffbc57;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar5,Gameplay_Isles_User_IMonsterSource_TypeInfo,0);
		code_r0x80ffbc57:
		  uVar4 = CONCAT44(in_register_20000014,puVar1[1]);
		  lVar3 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,uVar4);
		  uVar7 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  if (lVar3 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar9 = 0;
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 0x110);
		          goto code_r0x80ffbd10;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ffbd10:
		    iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,CONCAT44(uVar7,puVar1[1]));
		    uVar7 = *(undefined4 *)(iVar6 + 0x14);
		    uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		    uVar7 = Gameplay_World_Model_WorldModel__set_IsMovingOnWorldLevel(uVar7,uVar4,0);
		    Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		              (uVar7,5,
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		              );
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar9 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80ffbdda;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ffbdda:
		  uVar4 = CONCAT44(uVar7,puVar1[1]);
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,uVar4);
		  uVar7 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  uVar4 = CONCAT44(uVar7,*(undefined4 *)(*param3 + 0xe4));
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param3 + 0xe0) * 4))(param3,uVar4);
		  uVar7 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar6 = Core_Extensions_Dict_DictExt__TryGetHordeDic
		                    (uVar2,*(undefined4 *)(*(int *)(iVar6 + 8) + 0xc),0);
		  if (iVar6 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar9 = 0;
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar5;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8 + 4) * 8 + iVar8 + 0x178);
		          goto code_r0x80ffbeb3;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ffbeb3:
		    uVar4 = CONCAT44(uVar7,puVar1[1]);
		    uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,uVar4);
		    uVar7 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		    iVar8 = Core_Extensions_Dict_DictExt__GetHordeMonsterDic(uVar2,*(undefined4 *)(iVar6 + 0x10),0);
		    if (*(longlong *)(iVar6 + 0x18) !=
		        *(longlong *)(*(int *)(iVar8 + *(int *)(iVar8 + 0xc) * 4 + 0xc) + 0x18)) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar9 = 0;
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8)) {
		            puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar9 * 8 + 4) * 8 + iVar6 + 0x110);
		            goto code_r0x80ffbf89;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar9);
		      }
		      puVar1 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ffbf89:
		      iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(piVar5,CONCAT44(uVar7,puVar1[1]));
		      Gameplay_Isles_User_UserIsle__CreateMvc(*(undefined4 *)(*(int *)(iVar6 + 0x14) + 0x24),0);
		    }
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600535B")]
		[Address(RVA = "0xA11A", Offset = "0xA11A", VA = "0xA11A")]
		private void ResolveMonsterOrigin(UserData user, ArenaCombatModel.AttackRequestedMonster requestedMonster)
		{
		/* --- GHIDRA: ResolveMonsterOrigin ---
		int Gameplay_ArenaCombat_Control_ArenaCombatViewMediator__ResolveMonsterOrigin
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param2_00;
		  undefined4 param2_01;
		  int iVar4;
		  int param2_02;
		  
		  if (DAT_ram_00a593e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__OneOnOneCombatView__HandleGameOverWindowNextCombatRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__OneOnOneCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10790);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10789);
		    DAT_ram_00a593e0 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 8);
		  param2_00 = *(int **)(iVar3 + 0x5c);
		  if (param2_00 == (int *)0x0) {
		    uVar1 = 1;
		  }
		  else {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param2_00 + 0xe8) * 4))
		                      (param2_00,*(undefined4 *)(*param2_00 + 0xec));
		    uVar1 = uVar1 ^ 1;
		    iVar3 = *(int *)(param1 + 8);
		  }
		  param2_01 = *(undefined4 *)(iVar3 + 0x50);
		  iVar4 = *(int *)(iVar3 + 0x60);
		  iVar3 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleGameOverWindowCloseRequestEvent
		                    (param1,param2,
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ArenaCombatModel__ArenaCombatEvents__ArenaCombatController__OneOnOneCombatView__HandleGameOverWindowNextCombatRequestEvent__
		                    );
		  if (iVar3 == 0) {
		    param2_02 = *(int *)(iVar4 + 8);
		    if (param2_02 == 0) {
		      if (uVar1 == 0) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        Gameplay_ArenaCombat_ArenaCombat__Dispose
		                  (**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c),param2_00,0);
		        return 0;
		      }
		      iVar3 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		      UI_Windows_Alert__Show(iVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = func_ii_7508(StringLiteral_10790,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar3 + 0x18) = uVar2;
		      uVar2 = func_ii_7508(StringLiteral_10789,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar3 + 0x1c) = uVar2;
		      UI_Windows_UnityInstantiator___ctor(iVar3,0);
		      uVar2 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		      DefaultNamespace_SceneAppManager__RemoveScene(uVar2,param2_01,0);
		      return 0;
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		      param2_02 = *(int *)(iVar4 + 8);
		    }
		    Gameplay_ArenaCombat_ArenaCombat__TryRun
		              (**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c),param2_02,
		               (uint)*(byte *)(iVar4 + 0xc),0,0);
		  }
		  return iVar3;
		}
		*/

		}

		// Token: 0x0600535C RID: 21340 RVA: 0x0000F150 File Offset: 0x0000D350
		[Token(Token = "0x600535C")]
		[Address(RVA = "0xA11B", Offset = "0xA11B", VA = "0xA11B", Slot = "21")]
		protected override bool HandleGameOverWindowNextCombatRequestEvent(CombatGameOverView gameOverView)
		{
		/* --- GHIDRA: HandleGameOverWindowNextCombatRequestEvent ---
		void Gameplay_ArenaCombat_Control_ArenaCombatViewMediator__HandleGameOverWindowNextCombatRequestEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a593e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_AprGridView___);
		    DAT_ram_00a593e1 = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_CellViewsHolder__InitWithExistingRootPrefab
		            (param1,0);
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_AprGridView___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}
	}
}
