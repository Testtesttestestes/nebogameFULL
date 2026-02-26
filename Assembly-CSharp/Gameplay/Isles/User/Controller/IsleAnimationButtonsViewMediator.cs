using System;
using Gameplay.Isles.User.View;
using Gameplay.World.Controller;
using Gameplay.World.Events;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D31 RID: 3377
	[Token(Token = "0x2000D31")]
	public class IsleAnimationButtonsViewMediator : AbstractCozyViewMediator<WorldModel, WorldControllerEvents, WorldController, IsleAnimationButtonsView>
	{
		// Token: 0x0600529A RID: 21146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529A")]
		[Address(RVA = "0xA070", Offset = "0xA070", VA = "0xA070")]
		public IsleAnimationButtonsViewMediator(IsleAnimationButtonsView view, WorldModel model, WorldControllerEvents events, WorldController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58d97 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleAnimationInfoChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleDictChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleWorldLocationChangedEvent__
		              );
		    DAT_ram_00a58d97 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleAnimationInfoChangedEvent__
		             ,0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x24) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x24) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleWorldLocationChangedEvent__
		             ,0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x14) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x28);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleDictChangedEvent__
		             ,0);
		  piVar3 = (int *)func_ii_7048(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x28) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(param2 + 0x28) = piVar3, *piVar3 == iVar1))
		  {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600529B RID: 21147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529B")]
		[Address(RVA = "0xA071", Offset = "0xA071", VA = "0xA071", Slot = "21")]
		protected override void ResetEvents(WorldControllerEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58d98 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleAnimationInfoChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleDictChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleWorldLocationChangedEvent__
		              );
		    DAT_ram_00a58d98 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x24);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleAnimationInfoChangedEvent__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x24) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x24) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleWorldLocationChangedEvent__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else if ((*piVar3 != System_Action_TypeInfo) ||
		          (*(int **)(param2 + 0x14) = piVar3, *piVar3 != iVar1)) {
		    System_Activator__CreateInstance(piVar3,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x28);
		  uVar2 = unnamed_function_1417(iVar1);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleDictChangedEvent__
		             ,0);
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x28) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *piVar3) && (*(int **)(param2 + 0x28) = piVar3, *piVar3 == iVar1))
		  {
		    return;
		  }
		  System_Activator__CreateInstance(piVar3,iVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600529C RID: 21148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529C")]
		[Address(RVA = "0xA072", Offset = "0xA072", VA = "0xA072", Slot = "22")]
		protected override void SetupEvents(WorldControllerEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a58d99 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_ViewOnButtonClickedEvent__
		              );
		    DAT_ram_00a58d99 = '\x01';
		  }
		  param1_01 = unnamed_function_1417(System_Action_IsleAnimationsDic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_ViewOnButtonClickedEvent__
		             ,0);
		  if (DAT_ram_00a58d29 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationsDic__TypeInfo);
		    DAT_ram_00a58d29 = '\x01';
		  }
		  param1_00 = *(int *)(param2 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_IsleAnimationsDic__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_IsleAnimationsDic__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param2 + 0x1c,iVar2,param1_00);
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

		// Token: 0x0600529D RID: 21149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529D")]
		[Address(RVA = "0xA073", Offset = "0xA073", VA = "0xA073", Slot = "23")]
		protected override void ResetView(IsleAnimationButtonsView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__ResetView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58d9a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_ViewOnButtonClickedEvent__
		              );
		    DAT_ram_00a58d9a = '\x01';
		  }
		  uVar3 = unnamed_function_1417(System_Action_IsleAnimationsDic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_ViewOnButtonClickedEvent__
		             ,0);
		  if (DAT_ram_00a58d28 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationsDic__TypeInfo);
		    DAT_ram_00a58d28 = '\x01';
		  }
		  iVar4 = *(int *)(param2 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_00 = UnityEngine_UI_Image__set_sprite(iVar4,uVar3,0);
		    param2_00 = System_Action_IsleAnimationsDic__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar2 = func_ii_1082(param1_00,System_Action_IsleAnimationsDic__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param2 + 0x1c,iVar2,iVar4);
		    bVar1 = iVar2 == iVar4;
		    iVar4 = iVar2;
		    if (bVar1) {
		      Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__HandleSliderButtonLongTapEvent
		                (param1,iVar2);
		      if (DAT_ram_00a58da0 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__IsleAnimationButtonsView__get_Model__
		                  );
		        DAT_ram_00a58da0 = '\x01';
		      }
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar2 = *(int *)(param1[2] + 0x1c);
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar4 + 0x14),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,(uint)(iVar2 == 1),0);
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      Gameplay_World_Controller_WorldController__DisposeIsle(uVar3,0);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_00,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600529E RID: 21150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529E")]
		[Address(RVA = "0xA074", Offset = "0xA074", VA = "0xA074", Slot = "24")]
		protected override void SetupView(IsleAnimationButtonsView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__SetupView
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__HandleSliderButtonLongTapEvent
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600529F RID: 21151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529F")]
		[Address(RVA = "0xA075", Offset = "0xA075", VA = "0xA075")]
		private void HandleDictChangedEvent()
		{
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A0")]
		[Address(RVA = "0xA076", Offset = "0xA076", VA = "0xA076")]
		private void HandleWorldLocationChangedEvent()
		{
		/* --- GHIDRA: HandleWorldLocationChangedEvent ---
		void Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__HandleWorldLocationChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint param3;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  float fVar4;
		  int *piVar5;
		  int local_24;
		  undefined8 *local_20;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined4 local_10;
		  int iStack_c;
		  undefined4 local_8;
		  undefined4 uStack_4;
		  
		  if (DAT_ram_00a58d9b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__IsleAnimationButtonsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_IsleAnimationsDic__GameAnimatedButton__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_IsleAnimationsDic__GameAnimatedButton__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_IsleAnimationsDic__GameAnimatedButton__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_IsleAnimationsDic__GameAnimatedButton__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_IsleAnimationsDic__GameAnimatedButton__get_Key__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_IsleAnimationsDic__GameAnimatedButton__get_Value__
		              );
		    DAT_ram_00a58d9b = '\x01';
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  iStack_c = 0;
		  local_18 = 0;
		  local_1c = 0;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 == 0) {
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,*(undefined4 *)(iVar2 + 0x20),
		             Method_System_Collections_Generic_Dictionary_IsleAnimationsDic__GameAnimatedButton__GetEnumerator__
		            );
		  local_24 = 0;
		  local_20 = &local_18;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_IsleAnimationsDic__GameAnimatedButton__MoveNext__
		                      );
		    uVar1 = local_8;
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa8167;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x284,
		                       *(undefined4 *)(param1[2] + 0x3c),*(undefined4 *)(iStack_c + 0xc),&local_1c,0
		                      );
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa8167;
		    }
		    param3 = 1;
		    if (iVar3 != 0) {
		      DAT_ram_009d3e38 = 0;
		      fVar4 = import::env::invoke_fii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x39,local_1c,0);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80fa8167;
		      }
		      param3 = (uint)(fVar4 <= 0.0);
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x285,uVar1,param3,0)
		    ;
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar2 != 1);
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fa8167:
		  iVar2 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar1);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x287,&local_24);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar1);
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

		// Token: 0x060052A1 RID: 21153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A1")]
		[Address(RVA = "0xA077", Offset = "0xA077", VA = "0xA077")]
		private void HandleAnimationInfoChangedEvent()
		{
		/* --- GHIDRA: HandleAnimationInfoChangedEvent ---
		void Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__HandleAnimationInfoChangedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  int iVar3;
		  int iVar4;
		  float fVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  uint *puVar10;
		  undefined8 uVar11;
		  undefined4 uVar12;
		  undefined4 uVar13;
		  undefined4 uVar14;
		  int *piVar15;
		  uint uVar16;
		  ulonglong param1_00;
		  undefined8 uVar17;
		  longlong param2_00;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58d9c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__IsleAnimationButtonsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_Args_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
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
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleSliderButtonLongTapEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_SelectedLaunchValueDialogOnSelectedEvent__
		              );
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
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_IsleAnimationMultipleLaunchesDialog___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c__DisplayClass8_0__ViewOnButtonClickedEvent_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c__DisplayClass8_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12644);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9147);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27717);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9148);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9152);
		    DAT_ram_00a58d9c = '\x01';
		  }
		  local_4 = 0;
		  iVar3 = unnamed_function_1417
		                    (
		                    Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c__DisplayClass8_0_TypeInfo
		                    );
		  *(int *)(iVar3 + 0xc) = param2;
		  *(int *)(iVar3 + 8) = param1;
		  iVar4 = Gameplay_Isles_User_View_IsleAnimationButtonsView__AddButton
		                    (*(undefined4 *)(*(int *)(param1 + 8) + 0x3c),*(undefined4 *)(param2 + 0xc),
		                     &local_4,0);
		  if ((iVar4 == 0) || (fVar5 = func_ii_7103(local_4,0), fVar5 <= 0.0)) {
		    uVar11 = Gameplay_World_Model_WorldModel__GetCurrentIsle(*(undefined4 *)(param1 + 8),0);
		    iVar4 = (int)uVar11;
		    if (iVar4 < 1) {
		      iVar4 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		      func_ii_8625(iVar4,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9147,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar4 + 0x18) = uVar6;
		      uVar6 = Core_Extensions_Dict_IsleAnimationsDicExt__GetAnimationAssetId
		                        (*(undefined4 *)(iVar3 + 0xc),0);
		      *(undefined4 *)(iVar4 + 0x1c) = uVar6;
		      iVar7 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (iVar7,
		                 Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		                );
		      iVar8 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		      UI_Windows_DialogWindow_DialogWindowArgs___ctor
		                (iVar8,
		                 Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		                );
		      *(undefined4 *)(iVar8 + 0xc) = 3;
		      uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9152,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar8 + 8) = uVar6;
		      iVar9 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		      uVar6 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		                (uVar6,iVar3,
		                 Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c__DisplayClass8_0__ViewOnButtonClickedEvent_b__0__
		                 ,0);
		      *(undefined4 *)(iVar9 + 8) = uVar6;
		      *(int *)(iVar8 + 0x14) = iVar9;
		      iVar9 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		      uVar6 = *(undefined4 *)(*(int *)(iVar3 + 0xc) + 0x10);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      uVar6 = Core_Money_Money__op_Explicit(uVar6,0);
		      *(undefined4 *)(iVar9 + 8) = uVar6;
		      piVar15 = *(int **)(*(int *)(param1 + 8) + 0xc);
		      iVar3 = *piVar15;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar16 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar16 * 8)) {
		            puVar10 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar16 * 8 + 4) * 8 + iVar3 + 0x140
		                              );
		            goto code_r0x80fa8a8e;
		          }
		          uVar16 = uVar16 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar16);
		      }
		      puVar10 = (uint *)func_ii_1080(piVar15,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80fa8a8e:
		      uVar6 = (**(code **)((ulonglong)*puVar10 * 4))
		                        (CONCAT44(in_register_20000004,piVar15),
		                         CONCAT44(in_register_20000014,puVar10[1]));
		      uVar6 = func_ii_7112(uVar6,0);
		      *(undefined4 *)(iVar9 + 0xc) = uVar6;
		      *(int *)(iVar8 + 0x10) = iVar9;
		      iVar3 = 
		      Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		      ;
		      *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		      uVar16 = *(uint *)(iVar7 + 0xc);
		      if (uVar16 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		        *(uint *)(iVar7 + 0xc) = uVar16 + 1;
		        *(int *)(*(int *)(iVar7 + 8) + uVar16 * 4 + 0x10) = iVar8;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar7,iVar8,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		      }
		      *(int *)(iVar4 + 0x24) = iVar7;
		      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                (iVar4,0);
		    }
		    else {
		      iVar7 = *(int *)(*(int *)(param1 + 8) + 0x18);
		      if (iVar7 == 0) {
		        param1_00 = 1;
		      }
		      else {
		        param1_00 = (ulonglong)*(uint *)(iVar7 + 0x18);
		      }
		      if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Math_TypeInfo);
		      }
		      param2_00 = (longlong)iVar4;
		      uVar11 = System_Math__Max(param1_00,param2_00,0);
		      uVar12 = (undefined4)((ulonglong)param2_00 >> 0x20);
		      uVar6 = (undefined4)(param1_00 >> 0x20);
		      piVar15 = *(int **)(*(int *)(param1 + 8) + 0xc);
		      iVar7 = *piVar15;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar16 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar16 * 8)) {
		            puVar10 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar16 * 8 + 4) * 8 + iVar7 + 0xe0)
		            ;
		            goto code_r0x80fa8620;
		          }
		          uVar16 = uVar16 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar16);
		      }
		      puVar10 = (uint *)func_ii_1080(piVar15,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80fa8620:
		      uVar17 = CONCAT44(uVar6,piVar15);
		      uVar2 = CONCAT44(uVar12,puVar10[1]);
		      piVar15 = (int *)(**(code **)((ulonglong)*puVar10 * 4))(uVar17,uVar2);
		      uVar12 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      uVar6 = (undefined4)((ulonglong)uVar17 >> 0x20);
		      uVar16 = 0;
		      iVar7 = *piVar15;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar16 * 8)) {
		            puVar10 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar16 * 8 + 4) * 8 + iVar7 + 0xe8)
		            ;
		            goto code_r0x80fa86a2;
		          }
		          uVar16 = uVar16 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar16);
		      }
		      puVar10 = (uint *)func_ii_1080(piVar15,Core_Application_IApp_TypeInfo,5);
		code_r0x80fa86a2:
		      uVar6 = (**(code **)((ulonglong)*puVar10 * 4))
		                        (CONCAT44(uVar6,piVar15),CONCAT44(uVar12,puVar10[1]));
		      uVar12 = *(undefined4 *)(*(int *)(iVar3 + 0xc) + 0x10);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      uVar12 = Core_Money_Money__op_Explicit(uVar12,0);
		      uVar13 = *(undefined4 *)(iVar3 + 0xc);
		      uVar14 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		      uVar17 = *(undefined8 *)(*(int *)(*(int *)(param1 + 8) + 0x24) + 0x18);
		      iVar7 = unnamed_function_1417
		                        (Gameplay_Isles_User_View_IsleAnimationMultipleLaunchesDialog_Args_TypeInfo)
		      ;
		      if (DAT_ram_00a58d3a == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_IsleAnimationMultipleLaunchesDialog_Args___ctor__
		                  );
		        DAT_ram_00a58d3a = '\x01';
		      }
		      UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		                (iVar7,
		                 Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_IsleAnimationMultipleLaunchesDialog_Args___ctor__
		                );
		      *(undefined8 *)(iVar7 + 0x48) = uVar17;
		      *(undefined4 *)(iVar7 + 0x40) = uVar13;
		      *(undefined4 *)(iVar7 + 0x38) = uVar12;
		      *(int *)(iVar7 + 0x34) = iVar4;
		      *(undefined4 *)(iVar7 + 0x30) = 1;
		      *(int *)(iVar7 + 0x2c) = (int)uVar11;
		      *(undefined4 *)(iVar7 + 0x3c) = uVar14;
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar12 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9147,1,0,1,0,0,0,0);
		      *(undefined4 *)(iVar7 + 0x18) = uVar12;
		      uVar12 = Core_Extensions_Dict_IsleAnimationsDicExt__GetDescription
		                         (*(undefined4 *)(iVar3 + 0xc),0);
		      *(undefined4 *)(iVar7 + 0x1c) = uVar12;
		      iVar3 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                        (uVar6,StringLiteral_12644,iVar7,
		                         Method_UI_Windows_PopupController_Show_IsleAnimationMultipleLaunchesDialog___
		                        );
		      uVar6 = unnamed_function_1417(System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar6,param1,
		                 Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleSliderButtonLongTapEvent__
		                 ,0);
		      if (DAT_ram_00a58d32 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo);
		        DAT_ram_00a58d32 = '\x01';
		      }
		      iVar4 = *(int *)(iVar3 + 0x68);
		      do {
		        iVar7 = 0;
		        iVar8 = UnityEngine_UI_Image__set_sprite(iVar4,uVar6,0);
		        uVar12 = System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo;
		        if ((iVar8 != 0) &&
		           (iVar7 = func_ii_1082(iVar8,System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo),
		           iVar7 == 0)) {
		          System_Activator__CreateInstance(iVar8,uVar12);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar7 = func_ii_4329(iVar3 + 0x68,iVar7,iVar4);
		        bVar1 = iVar7 != iVar4;
		        iVar4 = iVar7;
		      } while (bVar1);
		      uVar6 = unnamed_function_1417(System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar6,param1,
		                 Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_SelectedLaunchValueDialogOnSelectedEvent__
		                 ,0);
		      if (DAT_ram_00a58d30 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo);
		        DAT_ram_00a58d30 = '\x01';
		      }
		      iVar4 = *(int *)(iVar3 + 100);
		      do {
		        iVar7 = 0;
		        iVar8 = UnityEngine_UI_Image__set_sprite(iVar4,uVar6,0);
		        uVar12 = System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo;
		        if ((iVar8 != 0) &&
		           (iVar7 = func_ii_1082(iVar8,System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo),
		           iVar7 == 0)) {
		          System_Activator__CreateInstance(iVar8,uVar12);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar7 = func_ii_4329(iVar3 + 100,iVar7,iVar4);
		        bVar1 = iVar7 != iVar4;
		        iVar4 = iVar7;
		      } while (bVar1);
		    }
		  }
		  else {
		    piVar15 = *(int **)(*(int *)(param1 + 8) + 0xc);
		    iVar3 = *piVar15;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar16 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar16 * 8)) {
		          puVar10 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar16 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x80fa8415;
		        }
		        uVar16 = uVar16 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar16);
		    }
		    puVar10 = (uint *)func_ii_1080(piVar15,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80fa8415:
		    uVar11 = CONCAT44(in_register_20000004,piVar15);
		    uVar17 = CONCAT44(in_register_20000014,puVar10[1]);
		    piVar15 = (int *)(**(code **)((ulonglong)*puVar10 * 4))(uVar11,uVar17);
		    uVar12 = (undefined4)((ulonglong)uVar17 >> 0x20);
		    uVar6 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    uVar16 = 0;
		    iVar3 = *piVar15;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar16 * 8)) {
		          puVar10 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar16 * 8 + 4) * 8 + iVar3 + 0xf0);
		          goto code_r0x80fa8497;
		        }
		        uVar16 = uVar16 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar16);
		    }
		    puVar10 = (uint *)func_ii_1080(piVar15,Core_Application_IApp_TypeInfo,6);
		code_r0x80fa8497:
		    uVar6 = (**(code **)((ulonglong)*puVar10 * 4))
		                      (CONCAT44(uVar6,piVar15),CONCAT44(uVar12,puVar10[1]));
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar12 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9148,1,0,1,0,0,0,0);
		    iVar3 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    fVar5 = func_ii_7103(local_4,0);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    uVar13 = Utils_TimeUtils__DateFormat((double)fVar5,0);
		    local_10 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_27717,uVar13,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar3 + 0x10) = local_10;
		    uVar12 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                       (uVar12,iVar3,0);
		    Core_Application_App__get_ToastController(uVar6,1,uVar12,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A2")]
		[Address(RVA = "0xA078", Offset = "0xA078", VA = "0xA078")]
		private void ViewOnButtonClickedEvent(IsleAnimationsDic dict)
		{
		/* --- GHIDRA: ViewOnButtonClickedEvent ---
		void Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__ViewOnButtonClickedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  undefined8 param3_00;
		  
		  if (DAT_ram_00a58d9d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_IsleAnimationMultipleLaunchesDialog_Args__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleSliderButtonLongTapEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo);
		    DAT_ram_00a58d9d = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator_HandleSliderButtonLongTapEvent__
		             ,0);
		  if (DAT_ram_00a58d33 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo);
		    DAT_ram_00a58d33 = '\x01';
		  }
		  iVar4 = *(int *)(param2 + 0x68);
		  while( true ) {
		    iVar3 = 0;
		    param1_00 = func_ii_7048(iVar4,uVar2,0);
		    uVar5 = System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar3 = func_ii_1082(param1_00,System_Action_IsleAnimationMultipleLaunchesDialog__TypeInfo),
		       iVar3 == 0)) break;
		    iVar3 = func_ii_4329(param2 + 0x68,iVar3,iVar4);
		    bVar1 = iVar3 == iVar4;
		    iVar4 = iVar3;
		    if (bVar1) {
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      iVar4 = func_ii_8093(param2,
		                           Method_UI_Windows_BaseWindow_IsleAnimationMultipleLaunchesDialog_Args__get_WindowArgs__
		                          );
		      param2_00 = *(undefined4 *)(*(int *)(iVar4 + 0x40) + 0xc);
		      iVar4 = func_ii_8093(param2,
		                           Method_UI_Windows_BaseWindow_IsleAnimationMultipleLaunchesDialog_Args__get_WindowArgs__
		                          );
		      param3_00 = *(undefined8 *)(iVar4 + 0x48);
		      uVar5 = UI_Elements_Sliders_SliderWithButtons__set_MaxValue(*(undefined4 *)(param2 + 0x54),0);
		      param1_01 = unnamed_function_1417(Gameplay_World_Model_IsleAnimationRequestVo_TypeInfo);
		      Gameplay_World_Model_ClanCurseData__set_BackTime(param1_01,param2_00,param3_00,uVar5,0);
		      Gameplay_World_Controller_WorldController__HandleServiceGetAnimationsInfo(uVar2,param1_01,0);
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_00,uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A3")]
		[Address(RVA = "0xA079", Offset = "0xA079", VA = "0xA079")]
		private void SelectedLaunchValueDialogOnSelectedEvent(IsleAnimationMultipleLaunchesDialog dialog)
		{
		/* --- GHIDRA: SelectedLaunchValueDialogOnSelectedEvent ---
		void Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__SelectedLaunchValueDialogOnSelectedEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 uVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 param5;
		  
		  if (DAT_ram_00a58d9e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__IsleAnimationButtonsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_IsleAnimationMultipleLaunchesDialog_Args__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_int__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_int__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SmallGames_View_SpinPickerDialogWindow_SpinPickerDialogWindowArgs_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c__HandleSliderButtonLongTapEvent_b__10_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c__DisplayClass10_0__HandleSliderButtonLongTapEvent_g__SpinDialogOnSelectedEvent_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c__DisplayClass10_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9149);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9150);
		    DAT_ram_00a58d9e = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c__DisplayClass10_0_TypeInfo
		                        );
		  *(int *)(param2_00 + 0x10) = param2;
		  *(int *)(param2_00 + 0xc) = param1;
		  uVar1 = UI_Elements_Sliders_SliderWithButtons__set_MaxValue(*(undefined4 *)(param2 + 0x54),0);
		  uVar3 = Gameplay_World_Model_WorldModel__GetCurrentIsle(*(undefined4 *)(param1 + 8),0);
		  uVar2 = System_Linq_Error__NotSupported(1,(int)uVar3,0);
		  if (*(int *)(Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c_TypeInfo + 0x74)
		      == 0) {
		    func_ii_306000(Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)
		            (Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c_TypeInfo + 0x5c);
		  iVar5 = puVar4[1];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c_TypeInfo + 0x74
		                ) == 0) {
		      func_ii_306000(Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c_TypeInfo);
		      puVar4 = *(undefined4 **)
		                (Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c_TypeInfo + 0x5c
		                );
		    }
		    uVar6 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_int__uint__TypeInfo);
		    System_Func_int__float___Invoke
		              (iVar5,uVar6,
		               Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c__HandleSliderButtonLongTapEvent_b__10_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c_TypeInfo +
		                     0x5c) + 4) = iVar5;
		  }
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,iVar5,Method_System_Linq_Enumerable_Select_int__uint___);
		  uVar2 = System_Linq_Enumerable__OrderBy_uint__uint_
		                    (uVar2,Method_System_Linq_Enumerable_ToArray_uint___);
		  iVar5 = func_ii_8093(*(undefined4 *)(param2_00 + 0x10),
		                       Method_UI_Windows_BaseWindow_IsleAnimationMultipleLaunchesDialog_Args__get_WindowArgs__
		                      );
		  uVar6 = *(undefined4 *)(iVar5 + 0x38);
		  param5 = *(undefined4 *)(*(int *)(param1 + 8) + 8);
		  iVar5 = unnamed_function_1417
		                    (
		                    Gameplay_SmallGames_View_SpinPickerDialogWindow_SpinPickerDialogWindowArgs_TypeInfo
		                    );
		  Gameplay_SmallGames_View_SpinPickerDialogWindow___ctor(iVar5,uVar1,uVar2,uVar6,param5,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_9150,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar5 + 0x18) = uVar1;
		  uVar1 = func_ii_7508(StringLiteral_9149,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar5 + 0x1c) = uVar1;
		  uVar1 = Gameplay_SmallGames_View_SpinPickerDialogWindow__HandleContent(iVar5,0);
		  *(undefined4 *)(param2_00 + 8) = uVar1;
		  uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar2,param2_00,
		                Method_Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c__DisplayClass10_0__HandleSliderButtonLongTapEvent_g__SpinDialogOnSelectedEvent_0__
		                ,0);
		  Gameplay_SmallGames_View_SpinPickerDialogWindow__set_SelectedAttemptsNum(uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A4")]
		[Address(RVA = "0xA07A", Offset = "0xA07A", VA = "0xA07A")]
		private void HandleSliderButtonLongTapEvent(IsleAnimationMultipleLaunchesDialog dialog)
		{
		/* --- GHIDRA: HandleSliderButtonLongTapEvent ---
		void Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__HandleSliderButtonLongTapEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  float fVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int *piVar9;
		  int local_10;
		  int **local_c;
		  undefined4 local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58d9f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__IsleAnimationButtonsView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_IsleAnimationsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_IsleAnimationsDic__GetEnumerator__)
		    ;
		    DAT_ram_00a58d9f = '\x01';
		  }
		  local_8 = 0;
		  iVar8 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar8 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar8 + 0x15c));
		  Gameplay_Isles_User_View_IsleAnimationButtonsView__ButtonOnClickEvent(uVar2,iVar8);
		  piVar7 = *(int **)(param1[2] + 0xc);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x80fa7a35;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80fa7a35:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  iVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar8 + 0x160),
		                              Method_Google_Protobuf_Collections_RepeatedField_IsleAnimationsDic__GetEnumerator__
		                             );
		  local_10 = 0;
		  local_c = &local_4;
		  do {
		    piVar7 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80fa7b27;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80fa7b6f:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa7dbf;
		    }
		code_r0x80fa7b27:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80fa7b6f;
		    if (iVar8 == 0) {
		      iVar8 = 0;
		      goto code_r0x80fa7e08;
		    }
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_IsleAnimationsDic__TypeInfo == *piVar9) {
		          puVar4 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80fa7c12;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_IsleAnimationsDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80fa7d8f:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa7dbf;
		    }
		code_r0x80fa7c12:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80fa7d8f;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa7dbf;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x283,uVar2,iVar8,iVar8);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa7dbf;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x284,
		                       *(undefined4 *)(param1[2] + 0x3c),*(undefined4 *)(iVar8 + 0xc),&local_8,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa7dbf;
		    }
		    uVar1 = 1;
		    if (iVar6 != 0) {
		      DAT_ram_009d3e38 = 0;
		      fVar5 = import::env::invoke_fii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x39,local_8,0);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80fa7dbf;
		      }
		      uVar1 = (uint)(fVar5 <= 0.0);
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x285,uVar2,uVar1,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar8 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fa7dbf:
		  iVar8 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar8 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_10 = iVar8;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80fa7e08:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80fa7e80;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80fa7e80:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		      }
		      if (iVar8 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x286,&local_10);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A5")]
		[Address(RVA = "0xA07B", Offset = "0xA07B", VA = "0xA07B")]
		private void UpdateAnimationButtons()
		{
		/* --- GHIDRA: UpdateAnimationButtons ---
		void Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__UpdateAnimationButtons
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58da0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_WorldModel__WorldControllerEvents__WorldController__IsleAnimationButtonsView__get_Model__
		              );
		    DAT_ram_00a58da0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(param1[2] + 0x1c);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(iVar2 == 1),0);
		  return;
		}
		*/

		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052A6")]
		[Address(RVA = "0xA07C", Offset = "0xA07C", VA = "0xA07C")]
		private void ValidateButtonsAvailability()
		{
		/* --- GHIDRA: ValidateButtonsAvailability ---
		void Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator__ValidateButtonsAvailability
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58da1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c_TypeInfo);
		    DAT_ram_00a58da1 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c_TypeInfo);
		  **(undefined4 **)
		    (Gameplay_Isles_User_Controller_IsleAnimationButtonsViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}
	}
}
