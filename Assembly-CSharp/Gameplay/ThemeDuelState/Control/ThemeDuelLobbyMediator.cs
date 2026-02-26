using System;
using Gameplay.ThemeDuelState.Model;
using Gameplay.ThemeDuelState.View.Lobby;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI;

namespace Gameplay.ThemeDuelState.Control
{
	// Token: 0x020004D3 RID: 1235
	[Token(Token = "0x20004D3")]
	public class ThemeDuelLobbyMediator : AbstractViewMediator<ThemeDuelStateModel, ThemeDuelStateEvents, ThemeDuelStateController, ThemeDuelLobbyView>
	{
		// Token: 0x06001D61 RID: 7521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D61")]
		[Address(RVA = "0x6EE0", Offset = "0x6EE0", VA = "0x6EE0")]
		public ThemeDuelLobbyMediator(ThemeDuelStateModel model, ThemeDuelStateEvents events, ThemeDuelStateController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58592 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelStateModel__ThemeDuelStateEvents__ThemeDuelStateController__ThemeDuelLobbyView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator_ThemeDuelButtonClickedEventHandler__
		              );
		    DAT_ram_00a58592 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator_ThemeDuelButtonClickedEventHandler__
		               ,0);
		    UI_IndexButtonBasic__add_ClickEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator_ThemeDuelButtonClickedEventHandler__
		               ,0);
		    UI_IndexButtonBasic__get_CanvasGroup(uVar3,uVar1,0);
		    Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator__UpdateThemeDuel(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000544 RID: 1348
		// (set) Token: 0x06001D62 RID: 7522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000544")]
		public override ThemeDuelLobbyView View
		{
			[Token(Token = "0x6001D62")]
			[Address(RVA = "0x6EE1", Offset = "0x6EE1", VA = "0x6EE1", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000545 RID: 1349
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000545")]
		public override ThemeDuelStateEvents Events
		{
			[Token(Token = "0x6001D63")]
			[Address(RVA = "0x6EE2", Offset = "0x6EE2", VA = "0x6EE2", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D64")]
		[Address(RVA = "0x6EE3", Offset = "0x6EE3", VA = "0x6EE3")]
		private void UpdateThemeDuel(ThemeDuelDic _)
		{
		/* --- GHIDRA: UpdateThemeDuel ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator__UpdateThemeDuel
		               (int *param1,undefined4 param2)
		
		{
		  float fVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58594 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelStateModel__ThemeDuelStateEvents__ThemeDuelStateController__ThemeDuelLobbyView__get_Model__
		              );
		    DAT_ram_00a58594 = '\x01';
		  }
		  iVar3 = param1[2];
		  fVar1 = func_ii_7103(*(undefined4 *)(iVar3 + 0x34),0);
		  if (0.0 < fVar1) {
		    iVar3 = *(int *)(iVar3 + 0x10);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar2,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,(uint)(iVar3 != 0),0);
		    if (iVar3 != 0) {
		      iVar3 = param1[2];
		      if (DAT_ram_00a58587 == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_System_Nullable_long__GetValueOrDefault__);
		        DAT_ram_00a58587 = '\x01';
		      }
		      local_8 = *(undefined8 *)(iVar3 + 0x20);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar4 = *(int **)(iVar3 + 0x14);
		      uVar2 = UnityEngine_GameObject__SetActive(&local_8,0);
		      iVar3 = *piVar4;
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		                (piVar4,uVar2,*(undefined4 *)(iVar3 + 0x2d4));
		      uVar2 = 0;
		      iVar3 = param1[2];
		      fVar1 = func_ii_7103(*(undefined4 *)(iVar3 + 0x34),0);
		      if (0.0 < fVar1) {
		        uVar2 = *(undefined4 *)(iVar3 + 0x10);
		      }
		      fVar1 = func_ii_7103(*(undefined4 *)(iVar3 + 0x34),0);
		      if ((0.0 < fVar1) && (*(int *)(iVar3 + 0x10) != 0)) {
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        uVar2 = Core_Extensions_Dict_ThemeDuelDicExt__GetBtnImgBattleListAssetId(uVar2,0);
		        Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		                  (*(undefined4 *)(iVar3 + 0x18),uVar2,0);
		      }
		    }
		  }
		  else {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar2,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D65")]
		[Address(RVA = "0x6EE4", Offset = "0x6EE4", VA = "0x6EE4")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator__Init
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a58595 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuel_View_ThemeDuelWindow_ThemeDuelWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12672);
		    DAT_ram_00a58595 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_ThemeDuel_View_ThemeDuelWindow_ThemeDuelWindowArgs_TypeInfo);
		  UI_Windows_BaseWindowArgs__Dispose(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x10) = 10;
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12672,param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D66")]
		[Address(RVA = "0x6EE5", Offset = "0x6EE5", VA = "0x6EE5")]
		private void ThemeDuelButtonClickedEventHandler(IndexButtonBasic indexButtonBasic)
		{
		/* --- GHIDRA: ThemeDuelButtonClickedEventHandler ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator__ThemeDuelButtonClickedEventHandler
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined8 local_8;
		  
		  local_8 = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar3 = *(int **)(iVar1 + 0x14);
		  uVar2 = UnityEngine_GameObject__SetActive(&local_8,0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D67")]
		[Address(RVA = "0x6EE6", Offset = "0x6EE6", VA = "0x6EE6")]
		private void UpdateBalance(long eventBalance)
		{
		/* --- GHIDRA: UpdateBalance ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator__UpdateBalance
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58596 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ThemeDuelStateModel__ThemeDuelStateEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ThemeDuelService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58596 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_ThemeDuelStateModel__ThemeDuelStateEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ThemeDuelService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58593 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ThemeDuelStateModel__ThemeDuelStateEvents__ThemeDuelStateController__ThemeDuelLobbyView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ThemeDuelDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator_UpdateBalance__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator_UpdateThemeDuel__);
		    DAT_ram_00a58593 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_long__TypeInfo);
		    System_Action_Int32Enum___Invoke
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator_UpdateBalance__,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_long__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_long__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar4;
		      uVar2 = System_Action_long__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_long__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_ThemeDuelDic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator_UpdateThemeDuel__,0);
		    iVar3 = func_ii_7048(uVar5,uVar2,0);
		    uVar2 = System_Action_ThemeDuelDic__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ThemeDuelDic__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_ThemeDuelDic__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ThemeDuelDic__TypeInfo);
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
		    uVar5 = *(undefined4 *)(iVar1 + 0x20);
		    uVar2 = unnamed_function_1417(System_Action_long__TypeInfo);
		    System_Action_Int32Enum___Invoke
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator_UpdateBalance__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_long__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_long__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar4;
		      uVar2 = System_Action_long__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_long__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_ThemeDuelDic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator_UpdateThemeDuel__,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		    uVar2 = System_Action_ThemeDuelDic__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		      return;
		    }
		    iVar4 = func_ii_1082(iVar3,System_Action_ThemeDuelDic__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar1 + 0x18) = iVar4;
		    uVar2 = System_Action_ThemeDuelDic__TypeInfo;
		    iVar1 = func_ii_1082(iVar3,System_Action_ThemeDuelDic__TypeInfo);
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


		/* --- GHIDRA: set_Events ---
		void Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator__set_Events
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_ThemeDuelState_Control_ThemeDuelLobbyMediator__UpdateThemeDuel(param1,param1);
		  return;
		}
		*/

}
