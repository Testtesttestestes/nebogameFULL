using System;
using Core.Money;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Gameplay.Portals.View.TotalizatorTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;
using Protocol.Portal;
using Protocol.Rating;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005E4 RID: 1508
	[Token(Token = "0x20005E4")]
	public class PortalsTotalizatorViewMediator : AbstractViewMediator<PortalsTotalizatorModel, PortalsEvents, PortalsTotalizatorController, PortalsTotalizatorView>, IHideableMediator
	{
		// Token: 0x0600246F RID: 9327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246F")]
		[Address(RVA = "0x75BD", Offset = "0x75BD", VA = "0x75BD")]
		public PortalsTotalizatorViewMediator(PortalsTotalizatorModel model, PortalsEvents events, PortalsTotalizatorController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57d24 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_BetRegisteredHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_BetRestrictedHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_SetNotEnough__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_ShowBets__);
		    DAT_ram_00a57d24 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_ShowBets__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x3c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x3c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x48);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_SetNotEnough__,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x48) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x48) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x40);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_BetRestrictedHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x40) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x40) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x44);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_BetRegisteredHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x44) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x44) = piVar4, *piVar4 != iVar1)) {
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x3c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_ShowBets__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x3c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x3c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x48);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_SetNotEnough__,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x48) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x48) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x40);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_BetRestrictedHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x40) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x40) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x44);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_BetRegisteredHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x44) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x44) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x170006D6 RID: 1750
		// (set) Token: 0x06002470 RID: 9328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D6")]
		public override PortalsEvents Events
		{
			[Token(Token = "0x6002470")]
			[Address(RVA = "0x75BE", Offset = "0x75BE", VA = "0x75BE", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D7")]
		public override PortalsTotalizatorView View
		{
			[Token(Token = "0x6002471")]
			[Address(RVA = "0x75BF", Offset = "0x75BF", VA = "0x75BF", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002472")]
		[Address(RVA = "0x75C0", Offset = "0x75C0", VA = "0x75C0", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__Hide(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57d26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_DoBetButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_UpdateButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57d26 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x20) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_DoBetButtonClickHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x24) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_UpdateButtonClickHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002473 RID: 9331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002473")]
		[Address(RVA = "0x75C1", Offset = "0x75C1", VA = "0x75C1")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57d27 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_DoBetButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_UpdateButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57d27 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x20) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_DoBetButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x24) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_UpdateButtonClickHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar2,0,
		             Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__set_CurrentState__);
		  Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__SetupView(param1,param1);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsTotalizatorController__ParticipantsForBetNotAvailHandler
		            (uVar2,param1);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002474 RID: 9332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002474")]
		[Address(RVA = "0x75C2", Offset = "0x75C2", VA = "0x75C2")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__SetupView
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param3;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  int *piVar6;
		  undefined8 local_18;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57d28 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12163);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28579);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12160);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28347);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25194);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12162);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12161);
		    DAT_ram_00a57d28 = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = 0;
		  param3 = func_ii_7508(StringLiteral_12162,1,0,1,0,0,0,0);
		  iVar2 = func_ii_7508(StringLiteral_12161,1,0,1,0,0,0,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(iVar3 + 0x2c);
		  uVar4 = func_ii_7508(StringLiteral_12160,1,0,1,0,0,0,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,2);
		  local_8 = 0;
		  if (param3 == 0) {
		    param3 = StringLiteral_5;
		  }
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_28347,param3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x10) = local_8;
		  local_8 = 0;
		  if (iVar2 == 0) {
		    iVar2 = StringLiteral_5;
		  }
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_25194,iVar2,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar3 + 0x18) = local_8;
		  uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar4,iVar3,0);
		  iVar2 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar4,*(undefined4 *)(iVar2 + 0x2d4));
		  piVar6 = *(int **)(param1[2] + 0x18);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x290);
		        goto code_r0x80e4d8f6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e4d8f6:
		  iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		  uVar4 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x3c) + 0x14);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar6 = *(int **)(iVar2 + 0x34);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = func_ii_7508(StringLiteral_12163,1,0,1,0,0,0,0);
		  iVar2 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_c = uVar4;
		  uVar4 = func_ii_1081(DAT_ram_00a66958,&local_c);
		  uVar4 = func_ii_4419(StringLiteral_28579,uVar4,0);
		  local_18 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_21978,uVar4,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar2 + 0x10) = local_18;
		  uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (param1_00,iVar2,0);
		  iVar2 = *piVar6;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (piVar6,uVar4,*(undefined4 *)(iVar2 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06002475 RID: 9333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002475")]
		[Address(RVA = "0x75C3", Offset = "0x75C3", VA = "0x75C3")]
		private void InitText()
		{
		/* --- GHIDRA: InitText ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__InitText
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57d29 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__set_CurrentState__);
		    DAT_ram_00a57d29 = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,4,
		             Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002476")]
		[Address(RVA = "0x75C4", Offset = "0x75C4", VA = "0x75C4")]
		private void BetRestrictedHandler()
		{
		/* --- GHIDRA: BetRestrictedHandler ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__BetRestrictedHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57d2a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28579);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12156);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20503);
		    DAT_ram_00a57d2a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar1 + 0x30);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_12155,1,0,1,0,0,0,0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_8 = *(undefined8 *)(param1[2] + 0x30);
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar3 = func_ii_4419(StringLiteral_28579,uVar3,0);
		  local_10 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_10,StringLiteral_20503,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar1 + 0x10) = local_10;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar1,0);
		  iVar1 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar1 + 0x28);
		  uVar2 = func_ii_7508(StringLiteral_12156,1,0,1,0,0,0,0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  local_18 = *(undefined8 *)(param1[2] + 0x30);
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_18);
		  uVar3 = func_ii_4419(StringLiteral_28579,uVar3,0);
		  local_20 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_20,StringLiteral_20503,uVar3,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar1 + 0x10) = local_20;
		  uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar2,iVar1,0);
		  iVar1 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (uVar2,3,
		             Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__set_CurrentState__);
		  Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__SetNotEnough(param1,&local_20);
		  return;
		}
		*/

		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002477")]
		[Address(RVA = "0x75C5", Offset = "0x75C5", VA = "0x75C5")]
		private void BetRegisteredHandler()
		{
		/* --- GHIDRA: BetRegisteredHandler ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__BetRegisteredHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57d2b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_DoBet__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12153);
		    DAT_ram_00a57d2b = '\x01';
		  }
		  param2_00 = StringLiteral_12153;
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 8) + 0x38);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_DoBet__,0);
		  Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__UpdateButtonClickHandler
		            (param1,param2_00,uVar1,param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002478")]
		[Address(RVA = "0x75C6", Offset = "0x75C6", VA = "0x75C6")]
		private void DoBetButtonClickHandler()
		{
		/* --- GHIDRA: DoBetButtonClickHandler ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__DoBetButtonClickHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param2_01;
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57d2c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsTotalizatorController_UpdateBetList__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12164);
		    DAT_ram_00a57d2c = '\x01';
		  }
		  param2_00 = StringLiteral_12164;
		  uVar1 = *(undefined4 *)(param1[2] + 0x3c);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		  param2_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param2_01,
		             Method_Gameplay_Portals_Controller_PortalsTotalizatorController_UpdateBetList__,0);
		  Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__UpdateButtonClickHandler
		            (param2_01,param2_00,uVar1,param1_00,param2_01);
		  return;
		}
		*/

		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002479")]
		[Address(RVA = "0x75C7", Offset = "0x75C7", VA = "0x75C7")]
		private void UpdateButtonClickHandler()
		{
		/* --- GHIDRA: UpdateButtonClickHandler ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__UpdateButtonClickHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  int iVar2;
		  int param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  int param1_01;
		  uint uVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57d2d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__DialogWindow__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__DialogWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__DialogWindow__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__DisplayClass14_0__ShowConfirmWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__DisplayClass14_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_26152);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17750);
		    DAT_ram_00a57d2d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__DisplayClass14_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param4;
		  iVar2 = Core_Money_Money__op_Multiply(param3,0);
		  if (iVar2 == 0) {
		    iVar2 = Core_Extensions_Dict_ResourceSetExt__ToNullableResourceSet
		                      (param3,NAN,0,StringLiteral_2556,0,0,0);
		    param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    func_ii_8625(param1_00,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(StringLiteral_17750,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1_00 + 0x18) = uVar3;
		    uVar3 = func_ii_7508(param2,1,0,1,0,0,0,0);
		    iVar4 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    local_8 = 0;
		    if (iVar2 == 0) {
		      iVar2 = StringLiteral_5;
		    }
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_8,StringLiteral_26152,iVar2,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar4 + 0x10) = local_8;
		    uVar3 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar3,iVar4,0);
		    *(undefined4 *)(param1_00 + 0x1c) = uVar3;
		    param1_01 = *(int *)(param1_00 + 0x24);
		    iVar2 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                      );
		    UI_Windows_DialogWindow_DialogWindowArgs___ctor
		              (iVar2,
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    uVar3 = UI_Windows_DialogWindow__get_WindowId(0);
		    *(undefined4 *)(iVar2 + 8) = uVar3;
		    iVar4 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__DialogWindow__TypeInfo
		                      );
		    uVar3 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__DialogWindow__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		              (uVar3,iVar1,
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__DisplayClass14_0__ShowConfirmWindow_b__0__
		               ,0);
		    *(undefined4 *)(iVar4 + 0x10) = uVar3;
		    *(int *)(iVar2 + 0x14) = iVar4;
		    iVar1 = 
		    Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		    ;
		    *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		    uVar5 = *(uint *)(param1_01 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		      *(uint *)(param1_01 + 0xc) = uVar5 + 1;
		      *(int *)(*(int *)(param1_01 + 8) + uVar5 * 4 + 0x10) = iVar2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_01,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		              (param1_00,0);
		  }
		  else {
		    iVar1 = *(int *)(iVar1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),
		               CONCAT44(in_register_20000014,*(undefined4 *)(iVar1 + 0x14)));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247A")]
		[Address(RVA = "0x75C8", Offset = "0x75C8", VA = "0x75C8")]
		private void ShowConfirmWindow(string descriptionKey, Money price, Action callback)
		{
		/* --- GHIDRA: ShowConfirmWindow ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__ShowConfirmWindow
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int *piVar8;
		  int *piVar9;
		  int iVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57d2e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__ProtoDoBetCmd_Types_BetChoice___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToList_ProtoDoBetCmd_Types_BetChoice___);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__ProtoDoBetCmd_Types_BetChoice__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_OSAGenericBase_UserInPortalsTotalizatorViewsHolder__UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__get_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__DoBet_b__15_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo);
		    DAT_ram_00a57d2e = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param1[2] + 0x2c);
		  if (*(int *)(Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo + 0x74) == 0)
		  {
		    func_ii_306000(Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)
		            (Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo + 0x5c);
		  iVar7 = puVar6[1];
		  if (iVar7 == 0) {
		    if (*(int *)(Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo + 0x74) ==
		        0) {
		      func_ii_306000(Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo);
		      puVar6 = *(undefined4 **)
		                (Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar6;
		    iVar7 = unnamed_function_1417
		                      (
		                      System_Func_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__ProtoDoBetCmd_Types_BetChoice__TypeInfo
		                      );
		    System_Linq_Enumerable__Where_object_
		              (iVar7,uVar3,
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__DoBet_b__15_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo + 0x5c
		                     ) + 4) = iVar7;
		  }
		  uVar1 = 0;
		  uVar5 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar5,iVar7,
		                     Method_System_Linq_Enumerable_Select_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__ProtoDoBetCmd_Types_BetChoice___
		                    );
		  uVar5 = System_Linq_Enumerable__Select_object__object_
		                    (uVar5,Method_System_Linq_Enumerable_ToList_ProtoDoBetCmd_Types_BetChoice___);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar8 = *(int **)(*(int *)(iVar7 + 0x1c) + 0xa0);
		  iVar7 = *piVar8;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e4e2e8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar8,
		                                System_Collections_Generic_IEnumerable_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__TypeInfo
		                                ,0);
		code_r0x80e4e2e8:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar8 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar6 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e4e3bb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e4e4f9:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e4e501;
		    }
		code_r0x80e4e3bb:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		    piVar8 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e4e4f9;
		    if (iVar7 == 0) {
		      iVar4 = 5;
		      iVar7 = 0;
		      goto code_r0x80e4e54e;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__TypeInfo
		            == *piVar9) {
		          puVar6 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e4e495;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar6 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e4e495:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		    if (DAT_ram_009d3e38 == 1) break;
		    *(undefined1 *)(iVar7 + 0x40) = 1;
		  } while( true );
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e4e501:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar7 = *piVar8;
		    iVar4 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x80e4e54e:
		      piVar8 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar10 = *local_4;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80e4e5c6;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e4e5c6:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar8,puVar2[1]);
		      }
		      if (iVar7 == 0) {
		        if ((iVar4 == 0) ||
		           ((((iVar4 != 1 && (iVar4 != 2)) && (iVar4 != 3)) && ((iVar4 != 4 && (iVar4 == 5)))))) {
		          iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          iVar4 = **(int **)(iVar7 + 0x1c);
		          (**(code **)((ulonglong)*(uint *)(iVar4 + 0x338) * 4))
		                    (*(int **)(iVar7 + 0x1c),0,0,*(undefined4 *)(iVar4 + 0x33c));
		          iVar7 = *param1;
		          uVar3 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x148) * 4))
		                            (param1,*(undefined4 *)(iVar7 + 0x14c));
		          Gameplay_Portals_Controller_PortalsTotalizatorController__UpdateModel(uVar3,uVar5,iVar7);
		        }
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x59,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 != 1) {
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600247B RID: 9339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247B")]
		[Address(RVA = "0x75C9", Offset = "0x75C9", VA = "0x75C9")]
		private void DoBet()
		{
		/* --- GHIDRA: DoBet ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__DoBet
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_Portals_Controller_PortalsTotalizatorController__ParticipantsForBetNotAvailHandler
		            (param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600247C RID: 9340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247C")]
		[Address(RVA = "0x75CA", Offset = "0x75CA", VA = "0x75CA")]
		private void RequestBetList()
		{
		/* --- GHIDRA: RequestBetList ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__RequestBetList
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__UpdatePrices(param1,param1);
		  Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__SetNotEnough(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247D")]
		[Address(RVA = "0x75CB", Offset = "0x75CB", VA = "0x75CB")]
		private void ShowBets()
		{
		/* --- GHIDRA: ShowBets ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__ShowBets
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57d2f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__set_CurrentState__);
		    DAT_ram_00a57d2f = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_00,5,
		             Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600247E RID: 9342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247E")]
		[Address(RVA = "0x75CC", Offset = "0x75CC", VA = "0x75CC")]
		private void SetNotEnough()
		{
		/* --- GHIDRA: SetNotEnough ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__SetNotEnough
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a57d30 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57d30 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x20) + 0xb8);
		  uVar3 = *(undefined4 *)(param1[2] + 0x38);
		  uVar4 = *(undefined4 *)(param1[2] + 8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar3 = Core_Money_Money__op_Explicit(uVar3,0);
		  UI_Price_Price__SetColor(uVar2,uVar4,uVar3,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x24) + 0xb8);
		  uVar4 = *(undefined4 *)(param1[2] + 8);
		  uVar2 = Core_Money_Money__op_Explicit(*(undefined4 *)(param1[2] + 0x3c),0);
		  UI_Price_Price__SetColor(uVar3,uVar4,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600247F RID: 9343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247F")]
		[Address(RVA = "0x75CD", Offset = "0x75CD", VA = "0x75CD")]
		private void UpdatePrices()
		{
		/* --- GHIDRA: UpdatePrices ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__UpdatePrices
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  longlong lVar6;
		  uint uVar7;
		  undefined4 param2_00;
		  int iVar8;
		  
		  if (DAT_ram_00a57d31 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__Bet_Types_State__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInPortalsTotalizatorViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_HandleChoice__);
		    DAT_ram_00a57d31 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar2 + 0x1c) + 0x50) != '\0') {
		    uVar7 = 0;
		    param1_00 = *(int **)(param1[2] + 0x18);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8 + 4) * 8 + iVar2 + 0x290);
		          goto code_r0x80e4e77e;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80e4e77e:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    iVar5 = *(int *)(param1[2] + 0x2c);
		    lVar6 = (longlong)*(int *)(iVar5 + 0xc);
		    bVar1 = lVar6 < (longlong)(ulonglong)*(uint *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x3c) + 0x14);
		    if (0 < lVar6) {
		      iVar2 = 0;
		      do {
		        iVar8 = *(int *)(iVar5 + iVar2 * 4 + 0x10);
		        uVar4 = unnamed_function_1417(System_Action_ulong__Bet_Types_State__TypeInfo);
		        System_Action_uint__uint___Invoke
		                  (uVar4,param1,
		                   Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator_HandleChoice__,
		                   0);
		        *(bool *)(iVar8 + 0x40) = bVar1;
		        *(undefined4 *)(iVar8 + 0x38) = uVar4;
		        iVar2 = iVar2 + 1;
		      } while (iVar2 < *(int *)(iVar5 + 0xc));
		    }
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param2_00 = 5;
		    if (!bVar1) {
		      param2_00 = 1;
		    }
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (uVar4,param2_00,
		               Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__set_CurrentState__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar8 = **(int **)(iVar2 + 0x1c);
		    (**(code **)((ulonglong)
		                 *(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar8 + 0x10) * 4))
		              (*(int **)(iVar2 + 0x1c),iVar5,
		               *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar8 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002480")]
		[Address(RVA = "0x75CE", Offset = "0x75CE", VA = "0x75CE")]
		private void UpdateOSAView()
		{
		/* --- GHIDRA: UpdateOSAView ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__UpdateOSAView
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57d32 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_FirstOrDefault_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__bool__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__DisplayClass21_0__HandleChoice_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__DisplayClass21_0_TypeInfo
		              );
		    DAT_ram_00a57d32 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__DisplayClass21_0_TypeInfo
		                    );
		  *(undefined8 *)(iVar1 + 8) = param2;
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 8) + 0x2c);
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Func_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__bool__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar1,
		             Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__DisplayClass21_0__HandleChoice_b__0__
		             ,0);
		  iVar1 = System_Func_object__bool____ctor
		                    (param1_01,param1_00,
		                     Method_System_Linq_Enumerable_FirstOrDefault_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___
		                    );
		  if (iVar1 != 0) {
		    *(undefined4 *)(iVar1 + 0x3c) = param3;
		    Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__HandleChoice(param1,iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002481")]
		[Address(RVA = "0x75CF", Offset = "0x75CF", VA = "0x75CF")]
		private void HandleChoice(ulong userID, Bet.Types.State choice)
		{
		/* --- GHIDRA: HandleChoice ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__HandleChoice
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a57d33 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Any_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__bool__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__get_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__ValidateChoices_b__22_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo);
		    DAT_ram_00a57d33 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(iVar1 + 0x18) != 5) {
		    uVar2 = *(undefined4 *)(param1[2] + 0x2c);
		    if (*(int *)(Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo + 0x74) ==
		        0) {
		      func_ii_306000(Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)
		              (Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo + 0x5c);
		    iVar1 = puVar3[2];
		    if (iVar1 == 0) {
		      if (*(int *)(Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo + 0x74)
		          == 0) {
		        func_ii_306000(Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo);
		        puVar3 = *(undefined4 **)
		                  (Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo + 0x5c);
		      }
		      uVar4 = *puVar3;
		      iVar1 = unnamed_function_1417
		                        (
		                        System_Func_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__bool__TypeInfo
		                        );
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (iVar1,uVar4,
		                 Method_Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c__ValidateChoices_b__22_0__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo +
		                       0x5c) + 8) = iVar1;
		    }
		    iVar1 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                      (uVar2,iVar1,
		                       Method_System_Linq_Enumerable_Any_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___
		                      );
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = 1;
		    if (iVar1 == 0) {
		      uVar4 = 2;
		    }
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (uVar2,uVar4,
		               Method_UI_MonoBehaviourWithStates_PortalsTotalizatorView_State__set_CurrentState__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002482")]
		[Address(RVA = "0x75D0", Offset = "0x75D0", VA = "0x75D0")]
		private void ValidateChoices()
		{
		/* --- GHIDRA: ValidateChoices ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__ValidateChoices(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57d34 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo);
		    DAT_ram_00a57d34 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Portals_Controller_PortalsTotalizatorViewMediator___c_TypeInfo + 0x5c)
		       = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001402 RID: 5122
		[Token(Token = "0x4001402")]
		[FieldOffset(Offset = "0x18")]
		private RatingPeriods _ratingPeriod;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57d25 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsTotalizatorModel__PortalsEvents__PortalsTotalizatorController__PortalsTotalizatorView__set_View__
		              );
		    DAT_ram_00a57d25 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__Hide(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Portals_Controller_PortalsTotalizatorViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

}
