using System;
using Gameplay.Fresco.Events;
using Gameplay.Fresco.Model;
using Gameplay.Fresco.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Fresco;
using UnityEngine.EventSystems;

namespace Gameplay.Fresco.Controller
{
	// Token: 0x02000810 RID: 2064
	[Token(Token = "0x2000810")]
	public class FrescoEpViewMediator : AbstractCozyViewMediator<FrescoModel, Gameplay.Fresco.Events.FrescoEvents, FrescoController, FrescoEpView>
	{
		// Token: 0x060030AA RID: 12458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AA")]
		[Address(RVA = "0x810F", Offset = "0x810F", VA = "0x810F")]
		public FrescoEpViewMediator(FrescoModel model, Gameplay.Fresco.Events.FrescoEvents events, FrescoController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Fresco_Controller_FrescoEpViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a575d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Fresco__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEpViewMediator_HandleFrescoUpdatedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEpViewMediator_HandleFrescoesUpdatedEvent__)
		    ;
		    DAT_ram_00a575d8 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEpViewMediator_HandleFrescoesUpdatedEvent__,0);
		  param1_00 = (int *)func_ii_7048(uVar4,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(param2 + 0x1c) = param1_00, *param1_00 != iVar2)) {
		    System_Activator__CreateInstance(param1_00,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_Fresco__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEpViewMediator_HandleFrescoUpdatedEvent__,0);
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_Fresco__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_Fresco__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(param2 + 0x14) = iVar3;
		    uVar1 = System_Action_Fresco__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_Fresco__TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060030AB RID: 12459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AB")]
		[Address(RVA = "0x8110", Offset = "0x8110", VA = "0x8110", Slot = "21")]
		protected override void ResetEvents(Gameplay.Fresco.Events.FrescoEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Fresco_Controller_FrescoEpViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a575d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Fresco__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEpViewMediator_HandleFrescoUpdatedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEpViewMediator_HandleFrescoesUpdatedEvent__)
		    ;
		    DAT_ram_00a575d9 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEpViewMediator_HandleFrescoesUpdatedEvent__,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_00) ||
		          (*(int **)(param2 + 0x1c) = param1_00, *param1_00 != iVar2)) {
		    System_Activator__CreateInstance(param1_00,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_Fresco__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEpViewMediator_HandleFrescoUpdatedEvent__,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_Fresco__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_Fresco__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(param2 + 0x14) = iVar3;
		    uVar1 = System_Action_Fresco__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_Fresco__TypeInfo);
		    if (iVar3 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060030AC RID: 12460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AC")]
		[Address(RVA = "0x8111", Offset = "0x8111", VA = "0x8111", Slot = "22")]
		protected override void SetupEvents(Gameplay.Fresco.Events.FrescoEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Fresco_Controller_FrescoEpViewMediator__SetupEvents
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Fresco_Controller_FrescoEpViewMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060030AD RID: 12461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AD")]
		[Address(RVA = "0x8112", Offset = "0x8112", VA = "0x8112")]
		private void HandleFrescoesUpdatedEvent()
		{
		/* --- GHIDRA: HandleFrescoesUpdatedEvent ---
		void Gameplay_Fresco_Controller_FrescoEpViewMediator__HandleFrescoesUpdatedEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Fresco_Controller_FrescoEpViewMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060030AE RID: 12462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AE")]
		[Address(RVA = "0x8113", Offset = "0x8113", VA = "0x8113")]
		private void HandleFrescoUpdatedEvent(Fresco _)
		{
		/* --- GHIDRA: HandleFrescoUpdatedEvent ---
		void Gameplay_Fresco_Controller_FrescoEpViewMediator__HandleFrescoUpdatedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a575da == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEpViewMediator_HandleEpClickEvent__);
		    DAT_ram_00a575da = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param2 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEpViewMediator_HandleEpClickEvent__,0);
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060030AF RID: 12463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030AF")]
		[Address(RVA = "0x8114", Offset = "0x8114", VA = "0x8114", Slot = "23")]
		protected override void ResetView(FrescoEpView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Fresco_Controller_FrescoEpViewMediator__ResetView
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a575db == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoEpViewMediator_HandleEpClickEvent__);
		    DAT_ram_00a575db = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param2 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Fresco_Controller_FrescoEpViewMediator_HandleEpClickEvent__,0);
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(param1_01,param1_00,0);
		  Gameplay_Fresco_Controller_FrescoEpViewMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B0")]
		[Address(RVA = "0x8115", Offset = "0x8115", VA = "0x8115", Slot = "24")]
		protected override void SetupView(FrescoEpView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Fresco_Controller_FrescoEpViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  uint uVar6;
		  int local_4;
		  
		  uVar6 = 0;
		  if (DAT_ram_00a575dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEpView__get_Model__
		              );
		    DAT_ram_00a575dc = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = Gameplay_Fresco_Model_FrescoModel__SetCurrentLobbyFresco(param1[2],&local_4,0);
		  iVar4 = local_4;
		  if (iVar1 == 0) {
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar3,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		  }
		  else {
		    iVar1 = param1[2];
		    if (DAT_ram_00a57594 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		      DAT_ram_00a57594 = '\x01';
		    }
		    *(int *)(iVar1 + 0x18) = iVar4;
		    param1_00 = *(int **)(*(int *)(iVar1 + 0xc) + 8);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x80db1dbf;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80db1dbf:
		    iVar5 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))
		                      (param1_00,CONCAT44(in_register_20000014,puVar2[1]));
		    uVar3 = Core_Extensions_Dict_DictExt__GetFrescoGroupDic(uVar3,*(undefined8 *)(iVar4 + 0x10),0);
		    *(undefined4 *)(iVar1 + 0x20) = uVar3;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = *(int *)(iVar4 + 0x14);
		    iVar1 = *(int *)(param1[2] + 0x20);
		    uVar3 = *(undefined4 *)(param1[2] + 0x18);
		    if (DAT_ram_00a57561 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		                );
		      DAT_ram_00a57561 = '\x01';
		    }
		    *(int *)(iVar4 + 0x50) = iVar1;
		    *(undefined4 *)(iVar4 + 0x4c) = uVar3;
		    if (iVar1 == 0) {
		      uVar3 = 0;
		    }
		    else {
		      iVar5 = *(int *)(iVar1 + 0x24);
		      uVar3 = Core_Extensions_Dict_FrescoDicExt__GetImage(iVar1,0);
		    }
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (iVar4,uVar3,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Gameplay_Fresco_View_FrescoField__Init
		              (iVar4,*(undefined4 *)(iVar4 + 0x48),*(undefined4 *)(iVar5 + 0xc),
		               *(undefined4 *)(iVar5 + 0x10),iVar4);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B1")]
		[Address(RVA = "0x8116", Offset = "0x8116", VA = "0x8116")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Fresco_Controller_FrescoEpViewMediator__Init
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 param1_01;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a575dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEpView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_View_FrescoWindow_FrescoWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_FrescoWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12618);
		    DAT_ram_00a575dd = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1[2] + 0xc) + 0xc);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  uVar2 = *(undefined4 *)(param1[2] + 8);
		  param1_00 = unnamed_function_1417(Gameplay_Fresco_View_FrescoWindow_FrescoWindowArgs_TypeInfo);
		  UI_Windows_BaseWindowArgs__Dispose(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  *(undefined4 *)(param1_00 + 0x10) = 10;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_01,StringLiteral_12618,param1_00,
		             Method_UI_Windows_PopupController_Show_FrescoWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B2")]
		[Address(RVA = "0x8117", Offset = "0x8117", VA = "0x8117")]
		private void HandleEpClickEvent(PointerEventData _)
		{
		/* --- GHIDRA: HandleEpClickEvent ---
		void Gameplay_Fresco_Controller_FrescoEpViewMediator__HandleEpClickEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a575de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoView__get_Model__
		              );
		    DAT_ram_00a575de = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractCozyViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoView___ctor__
		            );
		  *(undefined4 *)(*(int *)(param1 + 8) + 0x38) = param5;
		  return;
		}
		*/

		}
	}
}
