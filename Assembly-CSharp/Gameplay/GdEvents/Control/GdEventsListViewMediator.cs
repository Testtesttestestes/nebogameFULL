using System;
using System.Collections.Generic;
using Gameplay.GdEvents.Model;
using Gameplay.GdEvents.Model.Categories;
using Gameplay.GdEvents.View.EventsList;
using Il2CppDummyDll;
using MVC;
using UI.Windows;

namespace Gameplay.GdEvents.Control
{
	// Token: 0x02000768 RID: 1896
	[Token(Token = "0x2000768")]
	public class GdEventsListViewMediator : AbstractViewMediator<GdEventsModel, GdEventsEvents, GdEventsController, GdEventsListView>
	{
		// Token: 0x06002D26 RID: 11558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D26")]
		[Address(RVA = "0x7DA4", Offset = "0x7DA4", VA = "0x7DA4", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_GdEvents_Control_GdEventsListViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5a30f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsListView___ctor__
		              );
		    DAT_ram_00a5a30f = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsListView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D27")]
		[Address(RVA = "0x7DA5", Offset = "0x7DA5", VA = "0x7DA5")]
		public GdEventsListViewMediator(GdEventsModel model, GdEventsEvents events, GdEventsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_Control_GdEventsListViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5a310 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsListView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_GdEventData__GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_HandleCategoriesContentChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_HandleCurrentEventChangedEvent__
		              );
		    DAT_ram_00a5a310 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_GdEventData__GdEventData__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,
		               Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_HandleCurrentEventChangedEvent__
		               ,0);
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_GdEventData__GdEventData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_GdEventData__GdEventData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_GdEventData__GdEventData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_GdEventData__GdEventData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_HandleCategoriesContentChangedEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x14) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x18);
		    uVar2 = unnamed_function_1417(System_Action_GdEventData__GdEventData__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar2,param1,
		               Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_HandleCurrentEventChangedEvent__
		               ,0);
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_GdEventData__GdEventData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x18) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_GdEventData__GdEventData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x18) = iVar4;
		      uVar2 = System_Action_GdEventData__GdEventData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_GdEventData__GdEventData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_HandleCategoriesContentChangedEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar3 + 0x14) = piVar5, *piVar5 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170008B0 RID: 2224
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B0")]
		public override GdEventsEvents Events
		{
			[Token(Token = "0x6002D28")]
			[Address(RVA = "0x7DA6", Offset = "0x7DA6", VA = "0x7DA6", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D29")]
		[Address(RVA = "0x7DA7", Offset = "0x7DA7", VA = "0x7DA7")]
		private void HandleCurrentEventChangedEvent(GdEventData from, GdEventData to)
		{
		/* --- GHIDRA: HandleCurrentEventChangedEvent ---
		void Gameplay_GdEvents_Control_GdEventsListViewMediator__HandleCurrentEventChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  uVar1 = Gameplay_GdEvents_Control_GdEventsController__SetCurrentEvent(uVar1,param1);
		  Gameplay_GdEvents_Control_GdEventsListViewMediator__ResetView(param1,uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2A")]
		[Address(RVA = "0x7DA8", Offset = "0x7DA8", VA = "0x7DA8")]
		private void HandleCategoriesContentChangedEvent()
		{
		/* --- GHIDRA: HandleCategoriesContentChangedEvent ---
		void Gameplay_GdEvents_Control_GdEventsListViewMediator__HandleCategoriesContentChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a311 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsListView__set_View__
		              );
		    DAT_ram_00a5a311 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_GdEvents_Control_GdEventsListViewMediator__SetupView(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_GdEvents_Control_GdEventsListViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170008B1 RID: 2225
		// (set) Token: 0x06002D2B RID: 11563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008B1")]
		public override GdEventsListView View
		{
			[Token(Token = "0x6002D2B")]
			[Address(RVA = "0x7DA9", Offset = "0x7DA9", VA = "0x7DA9", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2C")]
		[Address(RVA = "0x7DAA", Offset = "0x7DAA", VA = "0x7DAA")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_GdEvents_Control_GdEventsListViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a5a313 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CellModel__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_HandleListClickEvent__);
		    DAT_ram_00a5a313 = '\x01';
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar3 = *(int *)(iVar3 + 0x14);
		  param1_01 = unnamed_function_1417(System_Action_CellModel__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_HandleListClickEvent__,0);
		  if (DAT_ram_00a5a299 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CellModel__TypeInfo);
		    DAT_ram_00a5a299 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0xb0);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_CellModel__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_CellModel__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0xb0,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2D")]
		[Address(RVA = "0x7DAB", Offset = "0x7DAB", VA = "0x7DAB")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		/* WARNING: Removing unreachable block (ram,0x811ffeaf) */
		
		void Gameplay_GdEvents_Control_GdEventsListViewMediator__ResetView
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int *piVar8;
		  int *piVar9;
		  int iVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a314 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_View_EventsList_CategoryModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_object__CellModel__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_AbstractGdEventCatData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_AbstractGdEventCatData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_LinqExtensions_Convert_CellModel___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CategoryModel__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CellModel___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CategoryModel___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CellModel__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CategoryModel__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Control_GdEventsListViewMediator___c__DisplayData_b__11_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Control_GdEventsListViewMediator___c_TypeInfo);
		    DAT_ram_00a5a314 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_CategoryModel__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_CategoryModel___ctor__);
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_AbstractGdEventCatData__TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811ffc68;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_AbstractGdEventCatData__TypeInfo
		                                ,0);
		code_r0x811ffc68:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x811ffca3:
		  do {
		    piVar8 = local_4;
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x811ffd37;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81200162:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8120016a;
		    }
		code_r0x811ffd37:
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii(*puVar4,piVar8,puVar4[1]);
		    piVar8 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81200162;
		    if (iVar10 == 0) {
		      iVar10 = 5;
		      goto code_r0x812001b7;
		    }
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_AbstractGdEventCatData__TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x811ffe1b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_AbstractGdEventCatData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x812000cc:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8120016a;
		    }
		code_r0x811ffe1b:
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii(*puVar4,piVar8,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x812000cc;
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_GdEvents_View_EventsList_CategoryModel_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8120016a;
		    }
		    *(undefined4 *)(iVar7 + 8) = *(undefined4 *)(iVar10 + 8);
		    uVar6 = *(undefined4 *)(iVar10 + 0xc);
		    if (*(int *)(Gameplay_GdEvents_Control_GdEventsListViewMediator___c_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Gameplay_GdEvents_Control_GdEventsListViewMediator___c_TypeInfo);
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8120016a;
		      }
		    }
		    puVar4 = *(undefined4 **)
		              (Gameplay_GdEvents_Control_GdEventsListViewMediator___c_TypeInfo + 0x5c);
		    iVar10 = puVar4[1];
		    if (iVar10 == 0) {
		      if (*(int *)(Gameplay_GdEvents_Control_GdEventsListViewMediator___c_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Gameplay_GdEvents_Control_GdEventsListViewMediator___c_TypeInfo);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x8120016a;
		        }
		        puVar4 = *(undefined4 **)
		                  (Gameplay_GdEvents_Control_GdEventsListViewMediator___c_TypeInfo + 0x5c);
		      }
		      uVar5 = *puVar4;
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_ii
		                         (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                          System_Func_object__CellModel__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x227,iVar10,uVar5,
		                   Method_Gameplay_GdEvents_Control_GdEventsListViewMediator___c__DisplayData_b__11_0__
		                   ,0);
		        if (DAT_ram_009d3e38 != 1) {
		          *(int *)(*(int *)(Gameplay_GdEvents_Control_GdEventsListViewMediator___c_TypeInfo + 0x5c)
		                  + 4) = iVar10;
		          goto code_r0x811fffdc;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8120016a;
		    }
		code_r0x811fffdc:
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x298,uVar6,iVar10,
		                       Method_Sirenix_Utilities_LinqExtensions_Convert_CellModel___);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8120016a;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Collections_Generic_List_CellModel__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x299,uVar5,uVar6,
		               Method_System_Collections_Generic_List_CellModel___ctor__);
		    if (DAT_ram_009d3e38 == 1) break;
		    *(undefined4 *)(iVar7 + 0xc) = uVar5;
		    iVar10 = Method_System_Collections_Generic_List_CategoryModel__Add__;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = iVar7;
		      goto code_r0x811ffca3;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar7,
		               *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8120016a:
		  iVar10 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar7) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar6);
		    local_c = *piVar8;
		    iVar10 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x812001b7:
		      DAT_ram_009d3e38 = 0;
		      piVar8 = *local_8;
		      if (piVar8 != (int *)0x0) {
		        uVar1 = 0;
		        iVar7 = *piVar8;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81200232;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar8,System_IDisposable_TypeInfo,0);
		code_r0x81200232:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		      }
		      if (local_c == 0) {
		        if ((iVar10 == 0) ||
		           ((((iVar10 != 1 && (iVar10 != 2)) && (iVar10 != 3)) && ((iVar10 != 4 && (iVar10 == 5)))))
		           ) {
		          iVar10 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                             (param1,*(undefined4 *)(*param1 + 0x15c));
		          piVar8 = *(int **)(iVar10 + 0x14);
		          if (DAT_ram_00a5a2a0 == '\0') {
		            Mono_Security_ASN1__get_Item
		                      (&Method_System_Collections_Generic_List_CellModel__get_Count__);
		            DAT_ram_00a5a2a0 = '\x01';
		          }
		          piVar8[0x2e] = iVar2;
		          iVar10 = *(int *)(piVar8[4] + 0x58);
		          iVar2 = Gameplay_GdEvents_View_EventsList_MyCellGroupViewsHolder_GridWithCategoriesDataUtil__CreateItemModelInRowSeparatingCategories
		                            (iVar10,iVar2,piVar8);
		          piVar8[0x2d] = iVar2;
		          piVar8[0x2f] = iVar10;
		          (**(code **)((ulonglong)*(uint *)(*piVar8 + 0x340) * 4))
		                    (piVar8,*(undefined4 *)(iVar2 + 0xc),0,1,*(undefined4 *)(*piVar8 + 0x344));
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x29a,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar6);
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

		// Token: 0x06002D2E RID: 11566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2E")]
		[Address(RVA = "0x7DAC", Offset = "0x7DAC", VA = "0x7DAC")]
		private void DisplayData(IList<AbstractGdEventCatData> categories)
		{
		/* --- GHIDRA: DisplayData ---
		void Gameplay_GdEvents_Control_GdEventsListViewMediator__DisplayData
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_GdEvents_Control_GdEventsController__HandleGetGameEventsRewardsInfoService
		            (param1_00,*(undefined4 *)(param2 + 0x14),param1);
		  return;
		}
		*/

		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D2F")]
		[Address(RVA = "0x7DAD", Offset = "0x7DAD", VA = "0x7DAD")]
		private void HandleListClickEvent(CellModel data)
		{
		/* --- GHIDRA: HandleListClickEvent ---
		void Gameplay_GdEvents_Control_GdEventsListViewMediator__HandleListClickEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a315 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_View_EventView_GdEventWindow_GdEventWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_GdEventWindowOnClose__);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_GdEventWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12622);
		    DAT_ram_00a5a315 = '\x01';
		  }
		  piVar4 = *(int **)(param1[2] + 0x3c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x811ffa1f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x811ffa1f:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x811ffaa1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x811ffaa1:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		  param1_00 = unnamed_function_1417
		                        (Gameplay_GdEvents_View_EventView_GdEventWindow_GdEventWindowArgs_TypeInfo);
		  Gameplay_GdEvents_View_EventView_GdEventWindow___ctor(param1_00,param2_00,uVar3);
		  iVar5 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar3,StringLiteral_12622,param1_00,
		                     Method_UI_Windows_PopupController_Show_GdEventWindow___);
		  param1[6] = iVar5;
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_GdEventWindowOnClose__,0);
		  UI_Windows_BaseWindow__get_IsActiveResourceBar(iVar5,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D30")]
		[Address(RVA = "0x7DAE", Offset = "0x7DAE", VA = "0x7DAE")]
		private void ShowEvtWindow()
		{
		/* --- GHIDRA: ShowEvtWindow ---
		void Gameplay_GdEvents_Control_GdEventsListViewMediator__ShowEvtWindow
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a316 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_GdEventWindowOnClose__);
		    DAT_ram_00a5a316 = '\x01';
		  }
		  param1_00 = param1[6];
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_GdEventWindowOnClose__,0);
		  UI_Windows_BaseWindow__add_onClose(param1_00,uVar1,0);
		  param1[6] = 0;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  Gameplay_GdEvents_Control_GdEventsController__HandleGetGameEventsRewardsInfoService
		            (uVar1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D31")]
		[Address(RVA = "0x7DAF", Offset = "0x7DAF", VA = "0x7DAF")]
		private void GdEventWindowOnClose()
		{
		/* --- GHIDRA: GdEventWindowOnClose ---
		int Gameplay_GdEvents_Control_GdEventsListViewMediator__GdEventWindowOnClose
		              (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a317 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GdEventsModel__GdEventsEvents__GdEventsController__GdEventsListView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a317 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar4,0,0);
		  if (iVar2 != 0) {
		    piVar5 = *(int **)(*(int *)(param1 + 8) + 0x3c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		          goto code_r0x811ff5dd;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x811ff5dd:
		    piVar5 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    uVar1 = 0;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe8);
		          goto code_r0x811ff65f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,5);
		code_r0x811ff65f:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    UI_Windows_PopupController__Show(uVar4,*(undefined4 *)(param1 + 0x18),0,0);
		  }
		  return iVar2;
		}
		*/

		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x00008B68 File Offset: 0x00006D68
		[Token(Token = "0x6002D32")]
		[Address(RVA = "0x7DB0", Offset = "0x7DB0", VA = "0x7DB0")]
		private bool TryClosePopupWindow()
		{
		/* --- GHIDRA: TryClosePopupWindow ---
		void Gameplay_GdEvents_Control_GdEventsListViewMediator__TryClosePopupWindow(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a318 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Control_GdEventsListViewMediator___c_TypeInfo);
		    DAT_ram_00a5a318 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_GdEvents_Control_GdEventsListViewMediator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_GdEvents_Control_GdEventsListViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x040018C7 RID: 6343
		[Token(Token = "0x40018C7")]
		[FieldOffset(Offset = "0x18")]
		private BaseWindow _gdEventWindow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_GdEvents_Control_GdEventsListViewMediator__set_Events
		               (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  if (param2 != 0) {
		    Gameplay_GdEvents_Control_GdEventsListViewMediator__GdEventWindowOnClose(param1,param1);
		  }
		  if (param3 != 0) {
		    Gameplay_GdEvents_Control_GdEventsListViewMediator__HandleListClickEvent(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_GdEvents_Control_GdEventsListViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  uint uVar2;
		  int param1_00;
		  int iVar3;
		  int *piVar4;
		  int iVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  int param1_01;
		  
		  if (DAT_ram_00a5a312 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CellModel__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_HandleListClickEvent__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8329);
		    DAT_ram_00a5a312 = '\x01';
		  }
		  piVar4 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  if (DAT_ram_00a5a30c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_IRewardProvider_TypeInfo);
		    DAT_ram_00a5a30c = '\x01';
		  }
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                    (piVar4,*(undefined4 *)(*piVar4 + 0x104));
		  uVar2 = 0;
		  piVar4 = *(int **)(iVar5 + 0x2c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_GdEvents_Model_IRewardProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar6 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81200583;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar4,Gameplay_GdEvents_Model_IRewardProvider_TypeInfo,0);
		code_r0x81200583:
		  (**(code **)((ulonglong)*puVar6 * 4))(piVar4,puVar6[1]);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  piVar4 = *(int **)(iVar5 + 0x10);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar7 = func_ii_7508(StringLiteral_8329,1,0,1,0,0,0,0);
		  iVar5 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (piVar4,uVar7,*(undefined4 *)(iVar5 + 0x2d4));
		  iVar5 = *param1;
		  uVar7 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x148) * 4))
		                    (param1,*(undefined4 *)(iVar5 + 0x14c));
		  uVar7 = Gameplay_GdEvents_Control_GdEventsController__SetCurrentEvent(uVar7,iVar5);
		  Gameplay_GdEvents_Control_GdEventsListViewMediator__ResetView(param1,uVar7,iVar5);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = *(int *)(iVar5 + 0x14);
		  uVar7 = unnamed_function_1417(System_Action_CellModel__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar7,param1,
		             Method_Gameplay_GdEvents_Control_GdEventsListViewMediator_HandleListClickEvent__,0);
		  if (DAT_ram_00a5a298 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CellModel__TypeInfo);
		    DAT_ram_00a5a298 = '\x01';
		  }
		  param1_00 = *(int *)(iVar5 + 0xb0);
		  while( true ) {
		    iVar3 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,uVar7,0);
		    param2_00 = System_Action_CellModel__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar3 = func_ii_1082(param1_01,System_Action_CellModel__TypeInfo), iVar3 == 0)) break;
		    iVar3 = func_ii_4329(iVar5 + 0xb0,iVar3,param1_00);
		    bVar1 = iVar3 == param1_00;
		    param1_00 = iVar3;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
