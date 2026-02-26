using System;
using Core.Application;
using Gameplay.Combat.Control;
using Gameplay.Combat.View;
using Gameplay.Portals.Combat.Model;
using Gameplay.Portals.Combat.View;
using Gameplay.Portals.Model;
using Il2CppDummyDll;

namespace Gameplay.Portals.Combat.Control
{
	// Token: 0x020005EE RID: 1518
	[Token(Token = "0x20005EE")]
	public class PortalCombatViewMediator : AbstractOneOnOneCombatViewMediator<PortalCombatModel, PortalCombatEvents, PortalCombatController, PortalCombatView>
	{
		// Token: 0x060024D1 RID: 9425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D1")]
		[Address(RVA = "0x761F", Offset = "0x761F", VA = "0x761F")]
		public PortalCombatViewMediator(PortalCombatModel model, PortalCombatEvents events, PortalCombatController controller)
		{
		/* --- GHIDRA: <>n__1 ---
		void Gameplay_Portals_Combat_Control_PortalCombatViewMediator____n__1(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57d73 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Portals_Combat_Control_PortalCombatViewMediator___c_TypeInfo);
		    DAT_ram_00a57d73 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Portals_Combat_Control_PortalCombatViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Portals_Combat_Control_PortalCombatViewMediator___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <>n__0 ---
		void Gameplay_Portals_Combat_Control_PortalCombatViewMediator____n__0
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d72 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__HandleGameOver__
		              );
		    DAT_ram_00a57d72 = '\x01';
		  }
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_object___PortalCombatViewMediator__HandleGameOver_d__9_
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__HandleGameOver__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Combat_Control_PortalCombatViewMediator___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57d67 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__HandleResetView__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Combat_Control_PortalCombatViewMediator_HandleGetRewardButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Combat_Control_PortalCombatViewMediator_HandleShopButtonClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57d67 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_object__object__object__object___HandleOtherPlayerTriggersChangedEvent
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__HandleResetView__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x70) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Combat_Control_PortalCombatViewMediator_HandleShopButtonClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x74) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Portals_Combat_Control_PortalCombatViewMediator_HandleGetRewardButtonClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D2")]
		[Address(RVA = "0x7620", Offset = "0x7620", VA = "0x7620", Slot = "32")]
		protected override void HandleResetView()
		{
		/* --- GHIDRA: HandleResetView ---
		void Gameplay_Portals_Combat_Control_PortalCombatViewMediator__HandleResetView
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_48;
		  undefined8 local_40;
		  undefined4 local_38;
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57d68 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PortalCombatViewMediator__HandleSetupView_d__2___
		              );
		    DAT_ram_00a57d68 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_48,0);
		  local_2c = local_40;
		  local_38 = 0xffffffff;
		  local_34 = local_48;
		  local_24 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_PortalCombatViewMediator__HandleGameOver_d__9_
		            ((uint)&local_38 | 4,&local_38,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PortalCombatViewMediator__HandleSetupView_d__2___
		            );
		  return;
		}
		*/

		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D3")]
		[Address(RVA = "0x7621", Offset = "0x7621", VA = "0x7621", Slot = "31")]
		protected override void HandleSetupView()
		{
		/* --- GHIDRA: HandleSetupView ---
		void Gameplay_Portals_Combat_Control_PortalCombatViewMediator__HandleSetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57d69 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Combat_Control_PortalCombatViewMediator_DropRemovedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Combat_Control_PortalCombatViewMediator_StageChangedHandler__
		              );
		    DAT_ram_00a57d69 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x70);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Combat_Control_PortalCombatViewMediator_StageChangedHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x70) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x70) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x74);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Combat_Control_PortalCombatViewMediator_DropRemovedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x74) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x74) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___ValidateUserBalance
		            (param1,param2,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__set_Events__
		            );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x70);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Combat_Control_PortalCombatViewMediator_StageChangedHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x70) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x70) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x74);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Combat_Control_PortalCombatViewMediator_DropRemovedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x74) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x74) = piVar4, *piVar4 != iVar1))
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

		// Token: 0x170006DF RID: 1759
		// (set) Token: 0x060024D4 RID: 9428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006DF")]
		public override PortalCombatEvents Events
		{
			[Token(Token = "0x60024D4")]
			[Address(RVA = "0x7622", Offset = "0x7622", VA = "0x7622", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D5")]
		[Address(RVA = "0x7623", Offset = "0x7623", VA = "0x7623")]
		private void DropRemovedEventHandler()
		{
		/* --- GHIDRA: DropRemovedEventHandler ---
		void Gameplay_Portals_Combat_Control_PortalCombatViewMediator__DropRemovedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57d6a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_RewardToBalanceTweener___);
		    DAT_ram_00a57d6a = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (*(undefined4 *)(iVar1 + 0x28),&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_RewardToBalanceTweener___);
		  if (iVar1 != 0) {
		    Gameplay_Combat_View_RewardToBalanceTweener__get_Ballance
		              (local_4,*(undefined4 *)(*(int *)(param1[2] + 0x10) + 0x20),0.0,0);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar1 + 0x74),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0x7624", Offset = "0x7624", VA = "0x7624")]
		private void HandleGetRewardButtonClickEvent()
		{
		/* --- GHIDRA: HandleGetRewardButtonClickEvent ---
		void Gameplay_Portals_Combat_Control_PortalCombatViewMediator__HandleGetRewardButtonClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 param2_01;
		  int param1_02;
		  
		  if (DAT_ram_00a57d6b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__HandleGameOverWindowCloseRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57d6b = '\x01';
		  }
		  param1_01 = *(int **)(param1[2] + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x80e54d8d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e54d8d:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  param2_01 = *(undefined4 *)(param1[2] + 0x50);
		  param1_02 = *param1;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(param1_02 + 0x158) * 4))
		                    (param1,*(undefined4 *)(param1_02 + 0x15c));
		  iVar3 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleGameOver
		                    (param1,*(undefined4 *)(iVar3 + 0x28),
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__HandleGameOverWindowCloseRequestEvent__
		                    );
		  if (iVar3 == 0) {
		    param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_01,0);
		    Gameplay_Portals_Combat_Control_PortalCombatViewMediator__HandleShopButtonClickEvent
		              (param1_02,param2_00,4,param1_02);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D7")]
		[Address(RVA = "0x7625", Offset = "0x7625", VA = "0x7625")]
		private void HandleShopButtonClickEvent()
		{
		/* --- GHIDRA: HandleShopButtonClickEvent ---
		void Gameplay_Portals_Combat_Control_PortalCombatViewMediator__HandleShopButtonClickEvent
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a57d6c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_PortalsWindow___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_View_PortalsWindow_PortalsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12659);
		    DAT_ram_00a57d6c = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x80e54e9a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Application_IApp_TypeInfo,5);
		code_r0x80e54e9a:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar3 = unnamed_function_1417(Gameplay_Portals_View_PortalsWindow_PortalsWindowArgs_TypeInfo);
		  Core_Browser_BrowserWindow___ctor(iVar3,param3,0);
		  *(undefined4 *)(iVar3 + 0x10) = 0xd;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12659,iVar3,
		             Method_UI_Windows_PopupController_Show_PortalsWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D8")]
		[Address(RVA = "0x7626", Offset = "0x7626", VA = "0x7626")]
		private void OpenPortalWindow(IApp app, PortalsTargets target)
		{
		/* --- GHIDRA: OpenPortalWindow ---
		void Gameplay_Portals_Combat_Control_PortalCombatViewMediator__OpenPortalWindow
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57d6d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PortalCombatViewMediator__HandleGameOver_d__9___
		              );
		    DAT_ram_00a57d6d = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_PlatformSigninManager__SigninToTargetProvider_d__25_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PortalCombatViewMediator__HandleGameOver_d__9___
		            );
		  return;
		}
		*/

		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024D9")]
		[Address(RVA = "0x7627", Offset = "0x7627", VA = "0x7627", Slot = "37")]
		protected override void HandleGameOver()
		{
		/* --- GHIDRA: HandleGameOver ---
		int Gameplay_Portals_Combat_Control_PortalCombatViewMediator__HandleGameOver
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a57d6e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__HandleGameOverWindowCloseRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57d6e = '\x01';
		  }
		  param1_01 = *(int **)(*(int *)(param1 + 8) + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x80e5500a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80e5500a:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  param2_01 = *(undefined4 *)(*(int *)(param1 + 8) + 0x50);
		  iVar3 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleGameOver
		                    (param1,param2,
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__HandleGameOverWindowCloseRequestEvent__
		                    );
		  if (iVar3 == 0) {
		    param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    DefaultNamespace_SceneAppManager__RemoveScene(param1_00,param2_01,0);
		    Gameplay_Portals_Combat_Control_PortalCombatViewMediator__HandleShopButtonClickEvent
		              (0,param2_00,10,0);
		  }
		  return iVar3;
		}
		*/

		}

		// Token: 0x060024DA RID: 9434 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x60024DA")]
		[Address(RVA = "0x7628", Offset = "0x7628", VA = "0x7628", Slot = "22")]
		protected override bool HandleGameOverWindowCloseRequestEvent(CombatGameOverView view)
		{
		/* --- GHIDRA: HandleGameOverWindowCloseRequestEvent ---
		int Gameplay_Portals_Combat_Control_PortalCombatViewMediator__HandleGameOverWindowCloseRequestEvent
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a57d6f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__HandleGameOverWindowNextCombatRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__get_Model__
		              );
		    DAT_ram_00a57d6f = '\x01';
		  }
		  iVar1 = **(int **)(param1 + 8);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x120) * 4))
		                        (*(int **)(param1 + 8),*(undefined4 *)(iVar1 + 0x124));
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x5c);
		  iVar1 = Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleGameOverWindowCloseRequestEvent
		                    (param1,param2,
		                     Method_Gameplay_Combat_Control_AbstractCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__HandleGameOverWindowNextCombatRequestEvent__
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Portals_Combat_PortalCombat__InitMVC(param1_00,param2_00,0);
		  }
		  return iVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060024DB RID: 9435 RVA: 0x00007098 File Offset: 0x00005298
		[Token(Token = "0x60024DB")]
		[Address(RVA = "0x7629", Offset = "0x7629", VA = "0x7629", Slot = "21")]
		protected override bool HandleGameOverWindowNextCombatRequestEvent(CombatGameOverView gameOverView)
		{
		/* --- GHIDRA: HandleGameOverWindowNextCombatRequestEvent ---
		void Gameplay_Portals_Combat_Control_PortalCombatViewMediator__HandleGameOverWindowNextCombatRequestEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d71 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__HandleSetupView__
		              );
		    DAT_ram_00a57d71 = '\x01';
		  }
		  Gameplay_Portals_Combat_Control_PortalCombatViewMediator__StageChangedHandler
		            (param1,
		             Method_Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_PortalCombatModel__PortalCombatEvents__PortalCombatController__PortalCombatView__HandleSetupView__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060024DC RID: 9436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x1BE4", Offset = "0x1BE4", VA = "0x1BE4")]
		private void StageChangedHandler()
		{
		/* --- GHIDRA: StageChangedHandler ---
		void Gameplay_Portals_Combat_Control_PortalCombatViewMediator__StageChangedHandler
		               (int *param1,int param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5cdc3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a5cdc3 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___HandleSelectedSpellChangedEvent
		            (param1,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 0x60) + 0x54));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x58);
		  param1_00 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (param1_00,param1,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 0x60) + 0x50),0);
		  Gameplay_Combat_View_Players_SkillsInfo___cctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Portals_Combat_Control_PortalCombatViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Portals_Combat_Control_PortalCombatViewMediator__DropRemovedEventHandler(param1,param1);
		  return;
		}
		*/

}
