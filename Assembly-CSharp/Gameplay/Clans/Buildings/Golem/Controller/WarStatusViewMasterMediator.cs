using System;
using Core.MVC.Interfaces;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Clans.Buildings.Golem.View;
using Gameplay.Clans.ClanWars.Controller;
using Gameplay.Clans.ClanWars.Events;
using Gameplay.Clans.ClanWars.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000AE3 RID: 2787
	[Token(Token = "0x2000AE3")]
	public class WarStatusViewMasterMediator : AbstractViewMediator<ClanWarsModel, ClanWarsEvents, ClanWarsController, WarStatusWindow>, IViewMediator<WarStatusWindow>, IViewMediator
	{
		// Token: 0x06004333 RID: 17203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004333")]
		[Address(RVA = "0x91E7", Offset = "0x91E7", VA = "0x91E7")]
		public WarStatusViewMasterMediator(ClanWarsModel model, ClanWarsEvents events, ClanWarsController controller, GolemModel golemModel)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57ac4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_CombatButtonClickedEventHandler__
		              );
		    DAT_ram_00a57ac4 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x48) + 0x30) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_CombatButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x48) + 0x30) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_CombatButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__GolemStateChangedEventHandler
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000D3D RID: 3389
		// (set) Token: 0x06004334 RID: 17204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3D")]
		public override WarStatusWindow View
		{
			[Token(Token = "0x6004334")]
			[Address(RVA = "0x91E8", Offset = "0x91E8", VA = "0x91E8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06004335 RID: 17205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004335")]
		[Address(RVA = "0x91E9", Offset = "0x91E9", VA = "0x91E9")]
		private void CombatButtonClickedEventHandler()
		{
		/* --- GHIDRA: CombatButtonClickedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__CombatButtonClickedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57ac5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_GolemStateChangedEventHandler__
		              );
		    DAT_ram_00a57ac5 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    iVar4 = *(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x10) + 0xc);
		    uVar5 = *(undefined4 *)(iVar4 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_GolemStateChangedEventHandler__
		               ,0);
		    piVar3 = (int *)func_ii_7048(uVar5,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x24) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar3) ||
		            (*(int **)(iVar4 + 0x24) = piVar3, *piVar3 != iVar1)) {
		      System_Activator__CreateInstance(piVar3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  *(int *)(param1 + 0x18) = param2;
		  if (param2 != 0) {
		    iVar4 = *(int *)(*(int *)(param2 + 0x10) + 0xc);
		    uVar5 = *(undefined4 *)(iVar4 + 0x24);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_GolemStateChangedEventHandler__
		               ,0);
		    piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar3 == (int *)0x0) {
		      *(undefined4 *)(iVar4 + 0x24) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar3) || (*(int **)(iVar4 + 0x24) = piVar3, *piVar3 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar3,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000D3E RID: 3390
		// (set) Token: 0x06004336 RID: 17206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3E")]
		private GolemModel GolemModel
		{
			[Token(Token = "0x6004336")]
			[Address(RVA = "0x91EA", Offset = "0x91EA", VA = "0x91EA")]
			set
			{
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (set) Token: 0x06004337 RID: 17207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D3F")]
		public override ClanWarsEvents Events
		{
			[Token(Token = "0x6004337")]
			[Address(RVA = "0x91EB", Offset = "0x91EB", VA = "0x91EB", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004338")]
		[Address(RVA = "0x91EC", Offset = "0x91EC", VA = "0x91EC")]
		private void WarStateChangedEventHandler()
		{
		/* --- GHIDRA: WarStateChangedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__WarStateChangedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__Init(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004339 RID: 17209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004339")]
		[Address(RVA = "0x91ED", Offset = "0x91ED", VA = "0x91ED")]
		private void GolemStateChangedEventHandler()
		{
		/* --- GHIDRA: GolemStateChangedEventHandler ---
		void Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__GolemStateChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57ac7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    DAT_ram_00a57ac7 = '\x01';
		  }
		  Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__Init(param1,param1);
		  param1_00 = (int *)Gameplay_Isles_Clan_Model_ClanIsleModel__get_GolemHasShield
		                               (*(undefined4 *)(*(int *)(param1[6] + 0x10) + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x40);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe8) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xec));
		  Core_Extensions_Dict_MonsterDictExt__GetTitle(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x40);
		  uVar2 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param1_00,0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Title(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600433A RID: 17210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433A")]
		[Address(RVA = "0x91EE", Offset = "0x91EE", VA = "0x91EE")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__Init
		               (int *param1,undefined4 param2)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  longlong lVar4;
		  longlong lVar5;
		  int *piVar6;
		  int iVar7;
		  int param2_00;
		  longlong lVar8;
		  longlong lVar9;
		  uint uVar10;
		  
		  if (DAT_ram_00a57ac8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Controller_DefaultWarStatusViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Controller_DefenderWarStatusViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_WarStatusWindow__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator_TypeInfo);
		    DAT_ram_00a57ac8 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar10 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + iVar7 + 0x230);
		        goto code_r0x80e1e2a7;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e1e2a7:
		  iVar7 = (**(code **)((ulonglong)*puVar1 * 4))(piVar6,puVar1[1]);
		  lVar8 = *(longlong *)(*(int *)(iVar7 + 0x10) + 0x10);
		  piVar6 = (int *)param1[7];
		  if (piVar6 != (int *)0x0) {
		    uVar10 = 0;
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		          puVar1 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e1e338;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar6,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x80e1e338:
		    (**(code **)((ulonglong)*puVar1 * 4))(piVar6,puVar1[1]);
		  }
		  if ((*(int *)(param1[2] + 0x14) == 0) || (*(int *)(*(int *)(param1[2] + 0x14) + 0x1c) - 3U < 2)) {
		    lVar8 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1[6] + 0x1c),0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + iVar7 + 0x230);
		          goto code_r0x80e1e40f;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e1e40f:
		    iVar7 = (**(code **)((ulonglong)*puVar1 * 4))(piVar6,puVar1[1]);
		    lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar7 + 0x10) + 0x20),0);
		    iVar7 = param1[6];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    if (lVar8 == lVar4) {
		      piVar6 = (int *)unnamed_function_1417
		                                (
		                                Gameplay_Clans_Buildings_Golem_Controller_TruceStatusViewMediator_TypeInfo
		                                );
		      Gameplay_Clans_Buildings_Golem_Controller_GolemInventoryViewMediator__RenderSlotsPrice
		                (piVar6,iVar7,uVar2,uVar3,iVar7);
		    }
		    else {
		      piVar6 = (int *)unnamed_function_1417
		                                (
		                                Gameplay_Clans_Buildings_Golem_Controller_EnemyTruceStatusViewMediator_TypeInfo
		                                );
		      Gameplay_Clans_Buildings_Golem_Controller_DefenderWarStatusViewMediator__PayOffButtonClickedEventHandler
		                (piVar6,iVar7,uVar2,uVar3,iVar7);
		    }
		  }
		  else {
		    lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1[6] + 0x1c),0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + iVar7 + 0x230);
		          goto code_r0x80e1e54d;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e1e54d:
		    iVar7 = (**(code **)((ulonglong)*puVar1 * 4))(piVar6,puVar1[1]);
		    lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar7 + 0x10) + 0x20),0);
		    iVar7 = *(int *)(param1[2] + 0x14);
		    lVar9 = *(longlong *)(*(int *)(iVar7 + 0x14) + 0x10);
		    if (lVar4 == lVar5) {
		      if (lVar8 == lVar9) {
		        iVar7 = param1[6];
		        uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x13c));
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		        piVar6 = (int *)unnamed_function_1417
		                                  (
		                                  Gameplay_Clans_Buildings_Golem_Controller_DefenderWarStatusViewMediator_TypeInfo
		                                  );
		        Gameplay_Clans_Buildings_Golem_Controller_DefenderWarStatusViewMediator__get_WarInfo
		                  (piVar6,iVar7,uVar2,uVar3,0);
		      }
		      else {
		        if (lVar8 != *(longlong *)(*(int *)(iVar7 + 0x10) + 0x10)) {
		          piVar6 = (int *)param1[7];
		          goto code_r0x80e1e731;
		        }
		        iVar7 = param1[6];
		        uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x13c));
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		        piVar6 = (int *)unnamed_function_1417
		                                  (
		                                  Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator_TypeInfo
		                                  );
		        Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__get_WarInfo
		                  (piVar6,iVar7,uVar2,uVar3,0);
		      }
		    }
		    else {
		      param2_00 = param1[6];
		      lVar8 = *(longlong *)
		               (*(int *)(*(int *)(*(int *)(*(int *)(param2_00 + 0x10) + 0x10) + 0x30) + 0x1c) + 0x10
		               );
		      if (lVar8 == lVar9) {
		        uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x13c));
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		        piVar6 = (int *)unnamed_function_1417
		                                  (
		                                  Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator_TypeInfo
		                                  );
		        Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__get_WarInfo
		                  (piVar6,param2_00,uVar2,uVar3,0);
		      }
		      else {
		        lVar4 = *(longlong *)(*(int *)(iVar7 + 0x10) + 0x10);
		        uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x13c));
		        uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x14c));
		        if (lVar8 == lVar4) {
		          piVar6 = (int *)unnamed_function_1417
		                                    (
		                                    Gameplay_Clans_Buildings_Golem_Controller_DefenderWarStatusViewMediator_TypeInfo
		                                    );
		          Gameplay_Clans_Buildings_Golem_Controller_DefenderWarStatusViewMediator__get_WarInfo
		                    (piVar6,param2_00,uVar2,uVar3,0);
		        }
		        else {
		          piVar6 = (int *)unnamed_function_1417
		                                    (
		                                    Gameplay_Clans_Buildings_Golem_Controller_DefaultWarStatusViewMediator_TypeInfo
		                                    );
		          Gameplay_Clans_Buildings_Golem_Controller_AttackerWarStatusViewMediator__AccelerateButtonClickedEventHandler
		                    (piVar6,param2_00,uVar2,uVar3,0);
		        }
		      }
		    }
		  }
		  param1[7] = (int)piVar6;
		code_r0x80e1e731:
		  uVar10 = 0;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_WarStatusWindow__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + iVar7 + 200);
		        goto code_r0x80e1e7ba;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar6,Core_MVC_Interfaces_IViewMediator_WarStatusWindow__TypeInfo,1
		                               );
		code_r0x80e1e7ba:
		  (**(code **)((ulonglong)*puVar1 * 4))(piVar6,uVar2,puVar1[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600433B RID: 17211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433B")]
		[Address(RVA = "0x91EF", Offset = "0x91EF", VA = "0x91EF")]
		private void UpdateState()
		{
		/* --- GHIDRA: UpdateState ---
		void Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__UpdateState
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *param3;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57ac9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__Dispose__
		              );
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a57ac9 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x1c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)
		         ) {
		        param3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e1eaf2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param3 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x80e1eaf2:
		  (**(code **)((ulonglong)*param3 * 4))(param1_00,param3[1]);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__CombatButtonClickedEventHandler
		            (param1,0,param3);
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600433C RID: 17212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600433C")]
		[Address(RVA = "0x91F0", Offset = "0x91F0", VA = "0x91F0", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a57aca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_GolemInventoryModel___ctor__
		              );
		    DAT_ram_00a57aca = '\x01';
		  }
		  Com_TheFallenGames_OSA_Core_SubComponents_InternalState_object___set_ctVirtualInsetFromVPS_Cached
		            (param1,param2,param3,
		             Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_GolemInventoryModel___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040024FE RID: 9470
		[Token(Token = "0x40024FE")]
		[FieldOffset(Offset = "0x18")]
		private GolemModel _golemModel;

		// Token: 0x040024FF RID: 9471
		[Token(Token = "0x40024FF")]
		[FieldOffset(Offset = "0x1C")]
		private IViewMediator<WarStatusWindow> _currentMediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__set_View
		               (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  iVar1 = Gameplay_Clans_Combat_ClanCombat__InitMVC
		                    (**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c),0);
		  if (iVar1 != 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    func_ii_8753(uVar2,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_GolemModel ---
		void Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator__set_GolemModel
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57ac6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanWarsModel__ClanWarsEvents__ClanWarsController__WarStatusWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_UpdateState__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_WarStateChangedEventHandler__
		              );
		    DAT_ram_00a57ac6 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_WarStateChangedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_UpdateState__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_WarStateChangedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Buildings_Golem_Controller_WarStatusViewMasterMediator_UpdateState__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

}
