using System;
using Core.Data;
using Gameplay.Fresco.Events;
using Gameplay.Fresco.Model;
using Gameplay.Fresco.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Fresco;

namespace Gameplay.Fresco.Controller
{
	// Token: 0x02000811 RID: 2065
	[Token(Token = "0x2000811")]
	public class FrescoViewMediator : AbstractCozyViewMediator<FrescoModel, Gameplay.Fresco.Events.FrescoEvents, FrescoController, FrescoView>
	{
		// Token: 0x060030B3 RID: 12467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B3")]
		[Address(RVA = "0x8118", Offset = "0x8118", VA = "0x8118")]
		public FrescoViewMediator(FrescoModel model, Gameplay.Fresco.Events.FrescoEvents events, FrescoController controller, UserData owner)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Fresco_Controller_FrescoViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a575df == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Fresco__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoViewMediator_FrescoUpdatedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoViewMediator_FrescoesUpdatedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoViewMediator_OtherFrescoesUpdatedHandler__);
		    DAT_ram_00a575df = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoViewMediator_OtherFrescoesUpdatedHandler__,0);
		  piVar2 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x20) = 0;
		  }
		  else if ((*piVar2 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x20) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(iVar3);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoViewMediator_FrescoesUpdatedHandler__,0);
		  piVar2 = (int *)func_ii_7048(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar2) ||
		          (*(int **)(param2 + 0x1c) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_Fresco__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoViewMediator_FrescoUpdatedHandler__,0);
		  iVar3 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_Fresco__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar3,System_Action_Fresco__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(param2 + 0x14) = iVar4;
		    uVar1 = System_Action_Fresco__TypeInfo;
		    iVar4 = func_ii_1082(iVar3,System_Action_Fresco__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar3,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar3,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B4")]
		[Address(RVA = "0x8119", Offset = "0x8119", VA = "0x8119", Slot = "21")]
		protected override void ResetEvents(Gameplay.Fresco.Events.FrescoEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Fresco_Controller_FrescoViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a575e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Fresco__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoViewMediator_FrescoUpdatedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoViewMediator_FrescoesUpdatedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoViewMediator_OtherFrescoesUpdatedHandler__);
		    DAT_ram_00a575e0 = '\x01';
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoViewMediator_OtherFrescoesUpdatedHandler__,0);
		  piVar2 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x20) = 0;
		  }
		  else if ((*piVar2 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x20) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x1c);
		  uVar1 = unnamed_function_1417(iVar3);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoViewMediator_FrescoesUpdatedHandler__,0);
		  piVar2 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  iVar3 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x1c) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar2) ||
		          (*(int **)(param2 + 0x1c) = piVar2, *piVar2 != iVar3)) {
		    System_Activator__CreateInstance(piVar2,iVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar5 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_Fresco__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoViewMediator_FrescoUpdatedHandler__,0);
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  uVar1 = System_Action_Fresco__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		    return;
		  }
		  iVar4 = func_ii_1082(iVar3,System_Action_Fresco__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(param2 + 0x14) = iVar4;
		    uVar1 = System_Action_Fresco__TypeInfo;
		    iVar4 = func_ii_1082(iVar3,System_Action_Fresco__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar3,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar3,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B5")]
		[Address(RVA = "0x811A", Offset = "0x811A", VA = "0x811A", Slot = "22")]
		protected override void SetupEvents(Gameplay.Fresco.Events.FrescoEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Fresco_Controller_FrescoViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a575e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoViewMediator_CollectionsButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoViewMediator_HandleTabBarChangeEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a575e1 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoViewMediator_HandleTabBarChangeEvent__,0);
		  UI_Tabs_TabBar__add_ChangeEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoViewMediator_CollectionsButtonClickHandler__,0)
		  ;
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B6")]
		[Address(RVA = "0x811B", Offset = "0x811B", VA = "0x811B", Slot = "23")]
		protected override void ResetView(FrescoView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Fresco_Controller_FrescoViewMediator__ResetView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a575e2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs___Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoViewMediator_CollectionsButtonClickHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoViewMediator_HandleTabBarChangeEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a575e2 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoViewMediator_HandleTabBarChangeEvent__,0);
		  UI_Tabs_CategoryTabBarItemView___ctor(uVar3,uVar1,0);
		  uVar3 = *(undefined4 *)(*(int *)(param2 + 0x10) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Fresco_Controller_FrescoViewMediator_CollectionsButtonClickHandler__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		  iVar4 = param1[2];
		  if (*(int *)(iVar4 + 8) != *(int *)(iVar4 + 0x38)) {
		    uVar1 = *(undefined4 *)(iVar4 + 0x34);
		    uVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(int *)(iVar4 + 0x38),0);
		    Gameplay_GameEvents_Model_GameEventsModel__GetEvent
		              (uVar1,uVar2,
		               Method_System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs___Remove__
		              );
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    uVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1[2] + 0x38),0);
		    Gameplay_Fresco_Controller_FrescoController__GetUserFrescoes(uVar1,uVar2,param1);
		  }
		  Gameplay_Fresco_Controller_FrescoViewMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B7")]
		[Address(RVA = "0x811C", Offset = "0x811C", VA = "0x811C", Slot = "24")]
		protected override void SetupView(FrescoView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Fresco_Controller_FrescoViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  double param2_00;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a575e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInFrescoGroupViewsHolder__GetNormalizedPosition__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInFrescoGroupViewsHolder__SetNormalizedPosition__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInFrescoGroupViewsHolder__get_IsInitialized__
		              );
		    DAT_ram_00a575e3 = '\x01';
		  }
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar2);
		  if (*(char *)(*(int *)(iVar1 + 0x18) + 0x50) != '\0') {
		    uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar2);
		    uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    param2_00 = Com_TheFallenGames_OSA_Core_OSA_object__object___GetMaxNumObjectsToKeepInMemory
		                          (*(undefined4 *)(iVar1 + 0x18),
		                           Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInFrescoGroupViewsHolder__GetNormalizedPosition__
		                          );
		    iVar1 = param1[2];
		    if (*(int *)(iVar1 + 8) == *(int *)(iVar1 + 0x38)) {
		      Gameplay_Fresco_Controller_FrescoViewMediator__InitView(param1,param1);
		      uVar2 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c));
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar2);
		      iVar5 = **(int **)(iVar1 + 0x18);
		      uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),*(undefined4 *)(param1[2] + 0x30));
		      (**(code **)((ulonglong)
		                   *(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar5 + 0x10) * 4))
		                (*(int **)(iVar1 + 0x18),uVar2,
		                 *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar5 + 0x14));
		      uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    }
		    else {
		      uVar3 = *(undefined4 *)(iVar1 + 0x34);
		      uVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(int *)(iVar1 + 0x38),0);
		      iVar1 = Google_Protobuf_Collections_RepeatedField_ulong___GetEnumerator
		                        (uVar3,uVar2,
		                         Method_System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs___ContainsKey__
		                        );
		      uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      if (iVar1 != 0) {
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c)));
		        piVar4 = *(int **)(iVar1 + 0x18);
		        uVar3 = *(undefined4 *)(param1[2] + 0x34);
		        uVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                          (*(undefined4 *)(param1[2] + 0x38),0);
		        uVar3 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                          (uVar3,uVar2,
		                           Method_System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs___get_Item__
		                          );
		        iVar1 = *piVar4;
		        uVar2 = CONCAT44((int)((ulonglong)uVar2 >> 0x20),uVar3);
		        (**(code **)((ulonglong)
		                     *(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar1 + 0x10) * 4))
		                  (piVar4,uVar2,
		                   *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar1 + 0x14));
		        uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c)));
		    func_ii_5663(*(undefined4 *)(iVar1 + 0x18),param2_00,
		                 Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInFrescoGroupViewsHolder__SetNormalizedPosition__
		                );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B8")]
		[Address(RVA = "0x811D", Offset = "0x811D", VA = "0x811D")]
		private void InitView()
		{
		/* --- GHIDRA: InitView ---
		void Gameplay_Fresco_Controller_FrescoViewMediator__InitView(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a575e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_FrescoGroupListElementArgs__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_FrescoGroupListElementArgs__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_FrescoGroupListElementArgs__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoViewMediator_OnFrescoClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_FrescoGroupListElementArgs__GetEnumerator__);
		    DAT_ram_00a575e4 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(*(int *)(param1 + 8) + 0x30),
		             Method_System_Collections_Generic_List_FrescoGroupListElementArgs__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_FrescoGroupListElementArgs__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80db27e3:
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x317,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
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
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar1 = local_8._4_4_;
		    uVar3 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_ulong__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80db27d1:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80db27e3;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x316,uVar3,param1,
		               Method_Gameplay_Fresco_Controller_FrescoViewMediator_OnFrescoClickHandler__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80db27d1;
		    *(undefined4 *)(iVar1 + 0x10) = uVar3;
		  } while( true );
		}
		*/

		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B9")]
		[Address(RVA = "0x811E", Offset = "0x811E", VA = "0x811E")]
		private void FillClickHandler()
		{
		/* --- GHIDRA: FillClickHandler ---
		void Gameplay_Fresco_Controller_FrescoViewMediator__FillClickHandler(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param3;
		  undefined4 param2_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a575e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_View_CollectionsWindow_CollectionsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_CollectionsWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Close_FrescoWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_GetWindows_CollectionsWindow___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_HasOpenWindow_CollectionsWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_CollectionsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12600);
		    DAT_ram_00a575e5 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0xc) + 0xc);
		  iVar1 = UI_Windows_PopupController__GetWindows_object_
		                    (param1_00,Method_UI_Windows_PopupController_HasOpenWindow_CollectionsWindow___)
		  ;
		  if (iVar1 != 0) {
		    uVar2 = UI_Windows_PopupController__GetLastWindow_object_
		                      (param1_00,Method_UI_Windows_PopupController_GetWindows_CollectionsWindow___);
		    uVar2 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                      (uVar2,Method_System_Linq_Enumerable_Last_CollectionsWindow___);
		    UI_Windows_PopupController__CloseAll(param1_00,uVar2,0);
		    return;
		  }
		  iVar1 = *(int *)(param1 + 8);
		  param3 = *(undefined4 *)(iVar1 + 8);
		  param2_00 = *(undefined4 *)(iVar1 + 0x38);
		  param4 = *(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x20);
		  uVar2 = unnamed_function_1417
		                    (Gameplay_Collections_View_CollectionsWindow_CollectionsWindowArgs_TypeInfo);
		  Gameplay_Collections_View_CollectionsWindow___ctor(uVar2,param2_00,param3,param4,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12600,uVar2,
		             Method_UI_Windows_PopupController_Show_CollectionsWindow___);
		  DG_Tweening_Plugins_Core_PluginsManager__GetDefaultPlugin___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (param1_00,1,Method_UI_Windows_PopupController_Close_FrescoWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060030BA RID: 12474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BA")]
		[Address(RVA = "0x811F", Offset = "0x811F", VA = "0x811F")]
		private void CollectionsButtonClickHandler()
		{
		/* --- GHIDRA: CollectionsButtonClickHandler ---
		void Gameplay_Fresco_Controller_FrescoViewMediator__CollectionsButtonClickHandler
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a575e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_Fresco___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Fresco_View_FrescoEditWindow_FrescoEditWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Fresco__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_FrescoEditWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoViewMediator___c__DisplayClass8_0__OnFrescoClickHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Fresco_Controller_FrescoViewMediator___c__DisplayClass8_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12617);
		    DAT_ram_00a575e6 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Fresco_Controller_FrescoViewMediator___c__DisplayClass8_0_TypeInfo);
		  *(undefined8 *)(iVar1 + 8) = param2;
		  iVar3 = param1[2];
		  if (*(int *)(iVar3 + 8) == *(int *)(iVar3 + 0x38)) {
		    uVar4 = *(undefined4 *)(iVar3 + 0x10);
		    uVar2 = unnamed_function_1417(System_Func_Fresco__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar2,iVar1,
		               Method_Gameplay_Fresco_Controller_FrescoViewMediator___c__DisplayClass8_0__OnFrescoClickHandler_b__0__
		               ,0);
		    uVar2 = System_Func_object__bool____ctor
		                      (uVar4,uVar2,Method_System_Linq_Enumerable_FirstOrDefault_Fresco___);
		    Gameplay_Fresco_Model_FrescoModel__SetOtherFrescoData(param1[2],uVar2,param1);
		    uVar4 = *(undefined4 *)(*(int *)(param1[2] + 0xc) + 0xc);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x14c));
		    iVar1 = unnamed_function_1417
		                      (Gameplay_Fresco_View_FrescoEditWindow_FrescoEditWindowArgs_TypeInfo);
		    UI_Windows_BaseWindowArgs__Dispose(iVar1,0);
		    *(undefined4 *)(iVar1 + 0x18) = uVar2;
		    Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		              (uVar4,StringLiteral_12617,iVar1,
		               Method_UI_Windows_PopupController_Show_FrescoEditWindow___);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060030BB RID: 12475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BB")]
		[Address(RVA = "0x8120", Offset = "0x8120", VA = "0x8120")]
		private void OnFrescoClickHandler(ulong frescoId)
		{
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BC")]
		[Address(RVA = "0x8121", Offset = "0x8121", VA = "0x8121")]
		private void FrescoesUpdatedHandler()
		{
		/* --- GHIDRA: FrescoesUpdatedHandler ---
		void Gameplay_Fresco_Controller_FrescoViewMediator__FrescoesUpdatedHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Fresco_Controller_FrescoViewMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060030BD RID: 12477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BD")]
		[Address(RVA = "0x8122", Offset = "0x8122", VA = "0x8122")]
		private void FrescoUpdatedHandler(Fresco _)
		{
		/* --- GHIDRA: FrescoUpdatedHandler ---
		void Gameplay_Fresco_Controller_FrescoViewMediator__FrescoUpdatedHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Fresco_Controller_FrescoViewMediator__SetupView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060030BE RID: 12478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BE")]
		[Address(RVA = "0x8123", Offset = "0x8123", VA = "0x8123")]
		private void OtherFrescoesUpdatedHandler()
		{
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BF")]
		[Address(RVA = "0x8124", Offset = "0x8124", VA = "0x8124")]
		private void HandleTabBarChangeEvent()
		{
		}
	}
}
