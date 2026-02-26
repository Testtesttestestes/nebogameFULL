using System;
using Core.Data;
using Gameplay.Collections.Events;
using Gameplay.Collections.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;
using ServicesNamespace;
using Utils;

namespace Gameplay.Collections.Controller
{
	// Token: 0x020009E7 RID: 2535
	[Token(Token = "0x20009E7")]
	public class CollectionsController : AbstractController<CollectionsModel, CollectionsEvents>
	{
		// Token: 0x06003C89 RID: 15497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C89")]
		[Address(RVA = "0x8B50", Offset = "0x8B50", VA = "0x8B50")]
		public CollectionsController(CollectionsModel model, CollectionsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Collections_Controller_CollectionsController___ctor
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
		  
		  if (DAT_ram_00a57ed8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionsController_DependenciesChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionsController_MedalAddedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionsController_MedalRemovedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57ed8 = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x120);
		        goto code_r0x80e7adb2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80e7adb2:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 0x20);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Collections_Controller_CollectionsController_DependenciesChangedEventHandler__
		             ,0);
		  piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar8,uVar3,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar5 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar5) ||
		          (*(int **)(iVar7 + 0x14) = piVar5, *piVar5 != iVar6)) {
		    System_Activator__CreateInstance(piVar5,iVar6);
		    do {
		      halt_trap();
		    } while( true );
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
		        goto code_r0x80e7aecc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e7aecc:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 0x18);
		  uVar8 = *(undefined4 *)(iVar7 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar3,param1,
		                Method_Gameplay_Collections_Controller_CollectionsController_MedalRemovedEventHandler__
		                ,0);
		  iVar6 = UnityEngine_UI_Image__set_sprite(uVar8,uVar3,0);
		  uVar3 = System_Action_uint__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x18) = iVar4;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_uint__TypeInfo);
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
		        goto code_r0x80e7afe6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e7afe6:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 0x18);
		  uVar8 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_MedalInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Collections_Controller_CollectionsController_MedalAddedEventHandler__,0
		            );
		  iVar6 = UnityEngine_UI_Image__set_sprite(uVar8,uVar3,0);
		  uVar3 = System_Action_MedalInfo__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		    Gameplay_Collections_Controller_CollectionsController__DependenciesChangedEventHandler(param1,0)
		    ;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,System_Action_MedalInfo__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar7 + 0x1c) = iVar4;
		    uVar3 = System_Action_MedalInfo__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_MedalInfo__TypeInfo);
		    if (iVar7 != 0) {
		      Gameplay_Collections_Controller_CollectionsController__DependenciesChangedEventHandler
		                (param1,iVar6);
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

		// Token: 0x06003C8A RID: 15498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8A")]
		[Address(RVA = "0x8B51", Offset = "0x8B51", VA = "0x8B51", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Collections_Controller_CollectionsController__HandleRun
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
		  
		  if (DAT_ram_00a57ed9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionsController_DependenciesChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionsController_MedalAddedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionsController_MedalRemovedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57ed9 = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x120);
		        goto code_r0x80e7b225;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80e7b225:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 0x20);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Collections_Controller_CollectionsController_DependenciesChangedEventHandler__
		             ,0);
		  piVar5 = (int *)func_ii_7048(uVar8,uVar3,0);
		  iVar6 = System_Action_TypeInfo;
		  if (piVar5 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar5) ||
		          (*(int **)(iVar7 + 0x14) = piVar5, *piVar5 != iVar6)) {
		    System_Activator__CreateInstance(piVar5,iVar6);
		    do {
		      halt_trap();
		    } while( true );
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
		        goto code_r0x80e7b33f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e7b33f:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 0x18);
		  uVar8 = *(undefined4 *)(iVar7 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar3,param1,
		                Method_Gameplay_Collections_Controller_CollectionsController_MedalRemovedEventHandler__
		                ,0);
		  iVar6 = func_ii_7048(uVar8,uVar3,0);
		  uVar3 = System_Action_uint__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x18) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x18) = iVar4;
		    uVar3 = System_Action_uint__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_uint__TypeInfo);
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
		        goto code_r0x80e7b459;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x80e7b459:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 0x18);
		  uVar8 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_MedalInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Collections_Controller_CollectionsController_MedalAddedEventHandler__,0
		            );
		  iVar6 = func_ii_7048(uVar8,uVar3,0);
		  uVar3 = System_Action_MedalInfo__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,System_Action_MedalInfo__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar7 + 0x1c) = iVar4;
		    uVar3 = System_Action_MedalInfo__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_MedalInfo__TypeInfo);
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

		// Token: 0x06003C8B RID: 15499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8B")]
		[Address(RVA = "0x8B52", Offset = "0x8B52", VA = "0x8B52", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8C")]
		[Address(RVA = "0x8B53", Offset = "0x8B53", VA = "0x8B53")]
		public void ScheduleCheckProgress(CollectionData data)
		{
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8D")]
		[Address(RVA = "0x8B54", Offset = "0x8B54", VA = "0x8B54")]
		private void MedalAddedEventHandler(MedalInfo info)
		{
		/* --- GHIDRA: MedalAddedEventHandler ---
		void Gameplay_Collections_Controller_CollectionsController__MedalAddedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  if (param1[7] != 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Collections_Model_CollectionsModel__GetProgress(param1_00,param1[7],param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8E")]
		[Address(RVA = "0x8B55", Offset = "0x8B55", VA = "0x8B55")]
		private void MedalRemovedEventHandler(uint medalId)
		{
		/* --- GHIDRA: MedalRemovedEventHandler ---
		void Gameplay_Collections_Controller_CollectionsController__MedalRemovedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  if (param1[7] != 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Collections_Model_CollectionsModel__GetProgress(param1_00,param1[7],param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C8F")]
		[Address(RVA = "0x8B56", Offset = "0x8B56", VA = "0x8B56")]
		private void DependenciesChangedEventHandler()
		{
		/* --- GHIDRA: DependenciesChangedEventHandler ---
		void Gameplay_Collections_Controller_CollectionsController__DependenciesChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57eda == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionsController_GetUserCollectionsSuccessHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57eda = '\x01';
		  }
		  param1_01 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 8),0);
		  uVar2 = ServicesNamespace_CollectionsService__get_ServiceId(param1_01,param2_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Collections_Controller_CollectionsController_GetUserCollectionsSuccessHandler__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C90")]
		[Address(RVA = "0x8B57", Offset = "0x8B57", VA = "0x8B57")]
		private void GetUserCollections()
		{
		/* --- GHIDRA: GetUserCollections ---
		void Gameplay_Collections_Controller_CollectionsController__GetUserCollections
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a57edb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Collections_ProtoGetUserCollectionsAns_TypeInfo);
		    DAT_ram_00a57edb = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Collections_ProtoGetUserCollectionsAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_Collections_ProtoGetUserCollectionsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Collections_Model_CollectionsModel__GetAllCollections(param1_00,param1_01[3],param1);
		  *(undefined1 *)((int)param1 + 9) = 1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C91")]
		[Address(RVA = "0x8B58", Offset = "0x8B58", VA = "0x8B58")]
		private void GetUserCollectionsSuccessHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetUserCollectionsSuccessHandler ---
		void Gameplay_Collections_Controller_CollectionsController__GetUserCollectionsSuccessHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57edc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Collections_Controller_CollectionsController_ImproveUserCollectionResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a57edc = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = System_Linq_Enumerable__FirstOrDefault_uint_(param2,0);
		  uVar1 = ServicesNamespace_CollectionsService__GetUserCollections(uVar2,uVar1,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Collections_Controller_CollectionsController_ImproveUserCollectionResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C92")]
		[Address(RVA = "0x8B59", Offset = "0x8B59", VA = "0x8B59")]
		public void ImproveUserCollection(CollectionData data)
		{
		/* --- GHIDRA: ImproveUserCollection ---
		void Gameplay_Collections_Controller_CollectionsController__ImproveUserCollection
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57edd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_CollectionData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CollectionsScope_CollectionsEventArgs_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Collections_ProtoImproveUserCollectionAns_TypeInfo);
		    DAT_ram_00a57edd = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar3 = *(int **)(param2 + 0x20);
		  if ((piVar3 != (int *)0x0) &&
		     (Protocol_Collections_ProtoImproveUserCollectionAns_TypeInfo != *piVar3)) {
		    System_Activator__CreateInstance
		              (piVar3,Protocol_Collections_ProtoImproveUserCollectionAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (-1 < piVar3[3]) {
		    piVar3 = *(int **)(param2 + 0xc);
		    if (piVar3 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar3 + 0xb8) <
		           (uint)*(byte *)(Core_Data_CollectionData_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar3 + 100) +
		                   (uint)*(byte *)(Core_Data_CollectionData_TypeInfo + 0xb8) * 4 + -4) !=
		          Core_Data_CollectionData_TypeInfo)) {
		        System_Activator__CreateInstance(piVar3,Core_Data_CollectionData_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Collections_Model_CollectionsModel__PopulateCollections(uVar1,piVar3,param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x14);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    iVar2 = System_Uri___ctor(0);
		    iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x58) + 8);
		    if (iVar2 != 0) {
		      uVar1 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417
		                            (Core_Events_Scopes_CollectionsScope_CollectionsEventArgs_TypeInfo);
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		                (param1_00,uVar1,param3_00,piVar3,0);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C93")]
		[Address(RVA = "0x8B5A", Offset = "0x8B5A", VA = "0x8B5A")]
		private void ImproveUserCollectionResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: ImproveUserCollectionResultHandler ---
		void Gameplay_Collections_Controller_CollectionsController__ImproveUserCollectionResultHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57ede == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_CollectionsModel__CollectionsEvents__Dispose__);
		    DAT_ram_00a57ede = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_CollectionsModel__CollectionsEvents__Dispose__);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C94")]
		[Address(RVA = "0x8B5B", Offset = "0x8B5B", VA = "0x8B5B", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Collections_Controller_CollectionsController__Dispose
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int *param1_00;
		  
		  if (DAT_ram_00a57edf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionsWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Controller_Filters_CollectionAvailableFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Controller_Filters_CollectionSkillFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Controller_Filters_CollectionTitleFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Predicate_CollectionData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Collections_Controller_CollectionsViewMediator___c___ctor_b__2_0__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Controller_CollectionsViewMediator___c_TypeInfo);
		    DAT_ram_00a57edf = '\x01';
		  }
		  if (*(int *)(Gameplay_Collections_Controller_CollectionsViewMediator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Collections_Controller_CollectionsViewMediator___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)
		            (Gameplay_Collections_Controller_CollectionsViewMediator___c_TypeInfo + 0x5c);
		  iVar7 = puVar6[1];
		  if (iVar7 == 0) {
		    if (*(int *)(Gameplay_Collections_Controller_CollectionsViewMediator___c_TypeInfo + 0x74) == 0)
		    {
		      func_ii_306000(Gameplay_Collections_Controller_CollectionsViewMediator___c_TypeInfo);
		      puVar6 = *(undefined4 **)
		                (Gameplay_Collections_Controller_CollectionsViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar2 = *puVar6;
		    iVar7 = unnamed_function_1417(System_Predicate_CollectionData__TypeInfo);
		    func_ii_7297(iVar7,uVar2,
		                 Method_Gameplay_Collections_Controller_CollectionsViewMediator___c___ctor_b__2_0__,
		                 0);
		    *(int *)(*(int *)(Gameplay_Collections_Controller_CollectionsViewMediator___c_TypeInfo + 0x5c) +
		            4) = iVar7;
		  }
		  *(int *)(param1 + 0x1c) = iVar7;
		  uVar1 = 0;
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_CollectionsModel__CollectionsEvents__CollectionsController__CollectionsWindow___ctor__
		            );
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter___ctor__
		            );
		  uVar3 = unnamed_function_1417
		                    (Gameplay_Collections_Controller_Filters_CollectionSkillFilter_TypeInfo);
		  func_ii_10812(uVar2,1,uVar3,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter__Add__
		               );
		  uVar3 = unnamed_function_1417
		                    (Gameplay_Collections_Controller_Filters_CollectionTitleFilter_TypeInfo);
		  func_ii_10812(uVar2,4,uVar3,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter__Add__
		               );
		  uVar3 = *(undefined4 *)(param2 + 8);
		  param1_00 = *(int **)(param2 + 0x10);
		  iVar7 = *param1_00;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x160);
		        goto code_r0x80e74398;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80e74398:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  iVar7 = unnamed_function_1417
		                    (Gameplay_Collections_Controller_Filters_CollectionAvailableFilter_TypeInfo);
		  *(undefined4 *)(iVar7 + 0xc) = uVar5;
		  *(undefined4 *)(iVar7 + 8) = uVar3;
		  func_ii_10812(uVar2,5,iVar7,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__ICollectionFilter__Add__
		               );
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x0400217B RID: 8571
		[Token(Token = "0x400217B")]
		[FieldOffset(Offset = "0x18")]
		private CollectionsService _collectionService;

		// Token: 0x0400217C RID: 8572
		[Token(Token = "0x400217C")]
		[FieldOffset(Offset = "0x1C")]
		private CollectionData _scheduledData;
	}
}
