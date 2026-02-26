using System;
using AssetContent;
using Gameplay.Clans.Controller;
using Gameplay.Clans.Events;
using Gameplay.Clans.Model;
using Gameplay.Clans.Office.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A74 RID: 2676
	[Token(Token = "0x2000A74")]
	public class ClansButtonViewMediator : AbstractViewMediator<ClansModel, ClansEvents, ClansController, ClansButtonView>
	{
		// Token: 0x06003FA7 RID: 16295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FA7")]
		[Address(RVA = "0x8E61", Offset = "0x8E61", VA = "0x8E61")]
		public ClansButtonViewMediator(ClansModel model, ClansEvents events, ClansController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClansButtonViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5769a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClansModel__ClansEvents__ClansController__ClansButtonView__set_View__
		              );
		    DAT_ram_00a5769a = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a5769e == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_GameAnimatedButton__TypeInfo);
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_Clans_Office_Controller_ClansButtonViewMediator_ButtonClickedEventHandler__
		                );
		      DAT_ram_00a5769e = '\x01';
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_00 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = unnamed_function_1417(System_Action_GameAnimatedButton__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_Clans_Office_Controller_ClansButtonViewMediator_ButtonClickedEventHandler__
		               ,0);
		    func_ii_7668(param1_00,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Clans_Office_Controller_ClansButtonViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000CA7 RID: 3239
		// (set) Token: 0x06003FA8 RID: 16296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA7")]
		public override ClansButtonView View
		{
			[Token(Token = "0x6003FA8")]
			[Address(RVA = "0x8E62", Offset = "0x8E62", VA = "0x8E62", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (set) Token: 0x06003FA9 RID: 16297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA8")]
		public override ClansEvents Events
		{
			[Token(Token = "0x6003FA9")]
			[Address(RVA = "0x8E63", Offset = "0x8E63", VA = "0x8E63", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAA")]
		[Address(RVA = "0x8E64", Offset = "0x8E64", VA = "0x8E64")]
		private void ButtonClickedEventHandler(GameAnimatedButton btn)
		{
		/* --- GHIDRA: ButtonClickedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClansButtonViewMediator__ButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Office_Controller_ClansButtonViewMediator__UserTriggersChangedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAB")]
		[Address(RVA = "0x8E65", Offset = "0x8E65", VA = "0x8E65")]
		private void UserTriggersChangedEventHandler()
		{
		/* --- GHIDRA: UserTriggersChangedEventHandler ---
		void Gameplay_Clans_Office_Controller_ClansButtonViewMediator__UserTriggersChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 param1_01;
		  uint uVar5;
		  
		  if (DAT_ram_00a5769d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClansModel__ClansEvents__ClansController__ClansButtonView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4343);
		    DAT_ram_00a5769d = '\x01';
		  }
		  if (*(longlong *)(param1[2] + 0x10) != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x10),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    return;
		  }
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1[2] + 0xc),0);
		  iVar2 = Core_Extensions_Dict_DictExt__GetClanBuildingTypeDic(uVar1,0xd,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0x160);
		        goto code_r0x80dc52f0;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80dc52f0:
		  uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  iVar2 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                    (uVar1,*(undefined4 *)(iVar2 + 0x14),*(undefined4 *)(param1[2] + 8),0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar4 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,iVar2,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    param1_01 = *(undefined4 *)(iVar2 + 0x10);
		    uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                      (*(undefined4 *)(param1[2] + 0xc),0);
		    uVar1 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar1,StringLiteral_4343,0);
		    AssetContent_GameAnimatedButton__get_AssetId(param1_01,uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAC")]
		[Address(RVA = "0x8E66", Offset = "0x8E66", VA = "0x8E66")]
		private void CheckRestrictions()
		{
		/* --- GHIDRA: CheckRestrictions ---
		void Gameplay_Clans_Office_Controller_ClansButtonViewMediator__CheckRestrictions
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5769e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimatedButton__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClansButtonViewMediator_ButtonClickedEventHandler__
		              );
		    DAT_ram_00a5769e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_GameAnimatedButton__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_ClansButtonViewMediator_ButtonClickedEventHandler__
		             ,0);
		  func_ii_7668(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAD")]
		[Address(RVA = "0x8E67", Offset = "0x8E67", VA = "0x8E67")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Clans_Office_Controller_ClansButtonViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5769f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAnimatedButton__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClansButtonViewMediator_ButtonClickedEventHandler__
		              );
		    DAT_ram_00a5769f = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_01 = *(undefined4 *)(iVar1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_GameAnimatedButton__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_ClansButtonViewMediator_ButtonClickedEventHandler__
		             ,0);
		  Gameplay_AccountLinker_Control_SigninTracker__Dispose(param1_01,param1_00,0);
		  Gameplay_Clans_Office_Controller_ClansButtonViewMediator__UserTriggersChangedEventHandler
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAE")]
		[Address(RVA = "0x8E68", Offset = "0x8E68", VA = "0x8E68")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Clans_Office_Controller_ClansButtonViewMediator__SetupView
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a576a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_ClassModel__ClassEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a576a0 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_ClassModel__ClassEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ColossusService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Clans_Office_Controller_ClansButtonViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5769b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClansModel__ClansEvents__ClansController__ClansButtonView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClansButtonViewMediator_UserTriggersChangedEventHandler__
		              );
		    DAT_ram_00a5769b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClansButtonViewMediator_UserTriggersChangedEventHandler__
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
		    uVar5 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClansButtonViewMediator_UserTriggersChangedEventHandler__
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


		/* --- GHIDRA: set_Events ---
		void Gameplay_Clans_Office_Controller_ClansButtonViewMediator__set_Events
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5769c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5769c = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x230);
		        goto code_r0x80dc55ac;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80dc55ac:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_ClansManager__HandleControllerInitEvent(param1_00,0);
		  return;
		}
		*/

}
