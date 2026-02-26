using System;
using System.Collections.Generic;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI.Windows;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D36 RID: 3382
	[Token(Token = "0x2000D36")]
	public class IsleBonusesViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, IsleBonusesView>
	{
		// Token: 0x060052B1 RID: 21169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B1")]
		[Address(RVA = "0xA087", Offset = "0xA087", VA = "0xA087")]
		public IsleBonusesViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Controller_IsleBonusesViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a58da8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleBonusesView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_DiamondIsleFoundEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_IsCurrentChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_IsleBonusCollected__);
		    DAT_ram_00a58da8 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_IsCurrentChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x40);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_IsleBonusCollected__
		                  ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x40) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x40) = iVar5;
		      uVar3 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x44);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_DiamondIsleFoundEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
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
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_IsCurrentChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x40);
		    uVar3 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar3,param1,
		                  Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_IsleBonusCollected__
		                  ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = System_Action_uint__TypeInfo;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x40) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x40) = iVar5;
		      uVar3 = System_Action_uint__TypeInfo;
		      iVar1 = func_ii_1082(iVar2,System_Action_uint__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x44);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_DiamondIsleFoundEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
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

		// Token: 0x170010DB RID: 4315
		// (set) Token: 0x060052B2 RID: 21170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DB")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x60052B2")]
			[Address(RVA = "0xA088", Offset = "0xA088", VA = "0xA088", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B3")]
		[Address(RVA = "0xA089", Offset = "0xA089", VA = "0xA089")]
		private void DiamondIsleFoundEvent()
		{
		/* --- GHIDRA: DiamondIsleFoundEvent ---
		void Gameplay_Isles_User_Controller_IsleBonusesViewMediator__DiamondIsleFoundEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Isles_User_View_IsleBonusesView__ApplySortingLayerId(param1_00,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B4")]
		[Address(RVA = "0xA08A", Offset = "0xA08A", VA = "0xA08A")]
		private void IsleBonusCollected(uint positionId)
		{
		/* --- GHIDRA: IsleBonusCollected ---
		void Gameplay_Isles_User_Controller_IsleBonusesViewMediator__IsleBonusCollected
		               (int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a58daa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleBonusesView__get_Model__
		              );
		    DAT_ram_00a58daa = '\x01';
		  }
		  Gameplay_Isles_User_Controller_IsleBonusesViewMediator__ViewOnBonusClickedEvent(param1,param1);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  *(undefined1 *)(param1_00 + 0x38) = *(undefined1 *)(param1[2] + 0x2c);
		  Gameplay_Isles_User_View_IsleBonusesView__set_Interabtable(param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B5")]
		[Address(RVA = "0xA08B", Offset = "0xA08B", VA = "0xA08B")]
		private void IsCurrentChangedEvent()
		{
		/* --- GHIDRA: IsCurrentChangedEvent ---
		void Gameplay_Isles_User_Controller_IsleBonusesViewMediator__IsCurrentChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a58dab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleBonusesView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_ViewOnBonusClickedEvent__
		              );
		    DAT_ram_00a58dab = '\x01';
		  }
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar5 != 0) {
		    iVar5 = *param1;
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x158) * 4))
		                      (param1,*(undefined4 *)(iVar5 + 0x15c));
		    Gameplay_Isles_User_View_IsleBonusesView__ShowBonusCollected(uVar4,iVar5);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar4,param1,
		                  Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_ViewOnBonusClickedEvent__
		                  ,0);
		    if (DAT_ram_00a58d4b == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		      DAT_ram_00a58d4b = '\x01';
		    }
		    iVar7 = *(int *)(iVar5 + 0x2c);
		    do {
		      iVar3 = 0;
		      iVar6 = func_ii_7048(iVar7,uVar4,0);
		      uVar2 = System_Action_uint__TypeInfo;
		      if ((iVar6 != 0) && (iVar3 = func_ii_1082(iVar6,System_Action_uint__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x2c,iVar3,iVar7);
		      bVar1 = iVar3 != iVar7;
		      iVar7 = iVar3;
		    } while (bVar1);
		  }
		  param1[5] = param2;
		  iVar7 = *param1;
		  uVar4 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x158) * 4))
		                    (param1,*(undefined4 *)(iVar7 + 0x15c));
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar5 != 0) {
		    Gameplay_Isles_User_Controller_IsleBonusesViewMediator__ViewOnBonusClickedEvent(param1,iVar7);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = unnamed_function_1417(System_Action_uint__TypeInfo);
		    func_ii_12322(uVar4,param1,
		                  Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_ViewOnBonusClickedEvent__
		                  ,0);
		    if (DAT_ram_00a58d4a == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		      DAT_ram_00a58d4a = '\x01';
		    }
		    iVar7 = *(int *)(iVar5 + 0x2c);
		    do {
		      iVar3 = 0;
		      iVar6 = UnityEngine_UI_Image__set_sprite(iVar7,uVar4,0);
		      uVar2 = System_Action_uint__TypeInfo;
		      if ((iVar6 != 0) && (iVar3 = func_ii_1082(iVar6,System_Action_uint__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x2c,iVar3,iVar7);
		      bVar1 = iVar3 != iVar7;
		      iVar7 = iVar3;
		    } while (bVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170010DC RID: 4316
		// (set) Token: 0x060052B6 RID: 21174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010DC")]
		public override IsleBonusesView View
		{
			[Token(Token = "0x60052B6")]
			[Address(RVA = "0xA08C", Offset = "0xA08C", VA = "0xA08C", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B7")]
		[Address(RVA = "0xA08D", Offset = "0xA08D", VA = "0xA08D")]
		private void ViewOnBonusClickedEvent(uint positionId)
		{
		/* --- GHIDRA: ViewOnBonusClickedEvent ---
		void Gameplay_Isles_User_Controller_IsleBonusesViewMediator__ViewOnBonusClickedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 param3;
		  undefined4 param4;
		  int iVar7;
		  undefined1 auStack_40 [8];
		  undefined8 local_38;
		  float4 local_30;
		  float4 local_2c;
		  int local_28;
		  undefined8 *local_24;
		  undefined8 local_20;
		  undefined4 local_18;
		  int iStack_14;
		  int local_10;
		  undefined4 uStack_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58dad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleBonusesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TreeBonusAnimation__TreeBonusPosition__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_TreeBonusAnimation__TreeBonusPosition__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_TreeBonusAnimation__TreeBonusPosition__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_TreeBonusAnimation__TreeBonusPosition__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_TreeBonusAnimation__TreeBonusPosition__get_Key__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_TreeBonusAnimation__TreeBonusPosition__get_Value__
		              );
		    DAT_ram_00a58dad = '\x01';
		  }
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  iStack_14 = 0;
		  local_20 = 0;
		  if ((*(int *)(param1[2] + 0x34) == 0) || (*(char *)(param1[2] + 0x2c) == '\0')) {
		    return;
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Isles_User_View_IsleBonusesView__ShowBonusCollected(uVar2,auStack_40);
		  uVar2 = Gameplay_Isles_User_Controller_IsleBonusesViewMediator__SetupBonuses(param1,auStack_40);
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_20,uVar2,
		             Method_System_Collections_Generic_Dictionary_TreeBonusAnimation__TreeBonusPosition__GetEnumerator__
		            );
		  local_28 = 0;
		  local_24 = &local_20;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_20,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_TreeBonusAnimation__TreeBonusPosition__MoveNext__
		                      );
		    iVar1 = local_10;
		    iVar5 = iStack_14;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa9b9a;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa9b9a;
		    }
		    param3 = *(undefined4 *)(iVar5 + 0x10);
		    iVar7 = param1[2];
		    iVar3 = *(int *)(iVar7 + 0x34);
		    if (iVar3 == 0) {
		      param4 = 0;
		    }
		    else {
		      local_4 = *(undefined4 *)(iVar3 + 0x10);
		      DAT_ram_009d3e38 = 0;
		      iVar4 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_4,2,0);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80fa9b9a;
		      }
		      if (iVar4 == 0) {
		        iVar7 = *(int *)(iVar7 + 0x34);
		        if (iVar7 == 0) {
		          param4 = 0;
		        }
		        else {
		          param4 = *(undefined4 *)(iVar7 + 0x14);
		        }
		      }
		      else {
		        param4 = 2;
		      }
		    }
		    local_2c = (float4)(float)*(int *)(*(int *)(iVar1 + 0x14) + 0x10);
		    local_30 = (float4)(float)*(int *)(*(int *)(iVar1 + 0x14) + 0xc);
		    DAT_ram_009d3e38 = 0;
		    local_38 = CONCAT44(local_2c,local_30);
		    import::env::invoke_viiiiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x289,uVar2,param3,param4,iVar5,
		               &local_38,auStack_40);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fa9b9a:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar5 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_28 = iVar5;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      if (iVar5 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x28a,&local_28);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
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

		// Token: 0x060052B8 RID: 21176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052B8")]
		[Address(RVA = "0xA08E", Offset = "0xA08E", VA = "0xA08E")]
		private void SetupBonuses()
		{
		/* --- GHIDRA: SetupBonuses ---
		int Gameplay_Isles_User_Controller_IsleBonusesViewMediator__SetupBonuses
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  uint uVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  int *piVar6;
		  uint *puVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  int local_10;
		  int **local_c;
		  undefined4 local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58dae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleBonusesView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TreeBonusAnimation__Add__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TreeBonusAnimation__TreeBonusPosition__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TreeBonusAnimation__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TreeBonusAnimation___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TreeBonusAnimation__TreeBonusPosition___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_TreeBonusAnimation__TreeBonusPosition__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__TreeBonusAnimation__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_TreeBonusPosition__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TreeBonusPosition__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TreeBonusAnimation__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TreeBonusAnimation__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    DAT_ram_00a58dae = '\x01';
		  }
		  local_8 = 0;
		  iVar8 = *(int *)(param1 + 0x18);
		  if (iVar8 == 0) {
		    iVar2 = 0;
		    iVar8 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_Dictionary_TreeBonusAnimation__TreeBonusPosition__TypeInfo
		                      );
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (iVar8,
		               Method_System_Collections_Generic_Dictionary_TreeBonusAnimation__TreeBonusPosition___ctor__
		              );
		    *(int *)(param1 + 0x18) = iVar8;
		    if (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x38) + 0x30) + 0xc) != 0) {
		      uVar4 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_uint__TreeBonusAnimation__TypeInfo);
		      System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		                (uVar4,
		                 Method_System_Collections_Generic_Dictionary_uint__TreeBonusAnimation___ctor__);
		      iVar9 = *(int *)(param1 + 8);
		      iVar8 = *(int *)(*(int *)(*(int *)(iVar9 + 0x34) + 0x18) + 0xc);
		      if (0 < iVar8) {
		        do {
		          iVar9 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x34) + 0x18),iVar2,
		                             Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		          if (iVar9 != 0) {
		            iVar9 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                              (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x34) + 0x18),iVar2,
		                               Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		            iVar9 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                              (*(undefined4 *)(*(int *)(*(int *)(param1 + 8) + 0x38) + 0x30),
		                               (iVar9 + -1) * iVar8 + iVar2,
		                               Method_Google_Protobuf_Collections_RepeatedField_TreeBonusAnimation__get_Item__
		                              );
		            System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		                      (uVar4,*(undefined4 *)(iVar9 + 0x10),iVar9,
		                       Method_System_Collections_Generic_Dictionary_uint__TreeBonusAnimation__Add__)
		            ;
		          }
		          iVar2 = iVar2 + 1;
		        } while (iVar2 != iVar8);
		        iVar9 = *(int *)(param1 + 8);
		      }
		      local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (*(undefined4 *)(*(int *)(iVar9 + 0x38) + 0x2c),
		                                  Method_Google_Protobuf_Collections_RepeatedField_TreeBonusPosition__GetEnumerator__
		                                 );
		      local_10 = 0;
		      local_c = &local_4;
		      do {
		        do {
		          piVar6 = local_4;
		          iVar8 = *local_4;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            uVar3 = 0;
		            do {
		              piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		                puVar5 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		                goto code_r0x80fa9eb6;
		              }
		              uVar3 = uVar3 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar5 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		            iVar8 = 1;
		code_r0x80fa9f02:
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80faa091;
		          }
		code_r0x80fa9eb6:
		          DAT_ram_009d3e38 = 0;
		          iVar8 = import::env::invoke_iii(*puVar5,piVar6,puVar5[1]);
		          piVar6 = local_4;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80fa9f02;
		          if (iVar8 == 0) {
		            iVar9 = 9;
		            iVar2 = 0;
		            goto code_r0x80faa0de;
		          }
		          iVar8 = *local_4;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            uVar3 = 0;
		            do {
		              piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8);
		              if (System_Collections_Generic_IEnumerator_TreeBonusPosition__TypeInfo == *piVar10) {
		                puVar5 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		                goto code_r0x80fa9fab;
		              }
		              uVar3 = uVar3 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar5 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                              System_Collections_Generic_IEnumerator_TreeBonusPosition__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x80faa033:
		            iVar8 = 1;
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80faa091;
		          }
		code_r0x80fa9fab:
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iii(*puVar5,piVar6,puVar5[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80faa033;
		          DAT_ram_009d3e38 = 0;
		          iVar9 = import::env::invoke_iiiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39d,uVar4,
		                             *(undefined4 *)(iVar2 + 0xc),&local_8,
		                             Method_System_Collections_Generic_Dictionary_uint__TreeBonusAnimation__TryGetValue__
		                            );
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar8 = 1;
		            goto code_r0x80faa091;
		          }
		        } while (iVar9 == 0);
		        iVar8 = *(int *)(param1 + 0x18);
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x4b,iVar8,local_8,iVar2,
		                   Method_System_Collections_Generic_Dictionary_TreeBonusAnimation__TreeBonusPosition__Add__
		                  );
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar2 != 1);
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80faa091:
		      iVar2 = global_1;
		      iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 == iVar9) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar2 = *piVar6;
		        iVar9 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_10 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		code_r0x80faa0de:
		          piVar6 = local_4;
		          iVar1 = System_IDisposable_TypeInfo;
		          DAT_ram_009d3e38 = 0;
		          if (local_4 != (int *)0x0) {
		            uVar3 = 0;
		            iVar8 = *local_4;
		            if (*(ushort *)(iVar8 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8)) {
		                  puVar7 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80faa156;
		                }
		                uVar3 = uVar3 + 1;
		              } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		            }
		            puVar7 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80faa156:
		            (**(code **)((ulonglong)*puVar7 * 4))(piVar6,puVar7[1]);
		            iVar8 = iVar1;
		          }
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          if (iVar9 != 0) {
		            if (iVar9 == 1) {
		              return iVar8;
		            }
		            if (iVar9 == 2) {
		              return iVar8;
		            }
		            if (iVar9 == 3) {
		              return iVar8;
		            }
		            if (iVar9 == 4) {
		              return iVar8;
		            }
		            if (iVar9 == 5) {
		              return iVar8;
		            }
		            if (iVar9 == 6) {
		              return iVar8;
		            }
		            if (iVar9 == 7) {
		              return iVar8;
		            }
		            if (iVar9 == 8) {
		              return iVar8;
		            }
		            if (iVar9 != 9) {
		              return iVar8;
		            }
		          }
		          return *(undefined4 *)(param1 + 0x18);
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x28b,&local_10);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return iVar8;
		}
		*/

		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60052B9")]
		[Address(RVA = "0xA08F", Offset = "0xA08F", VA = "0xA08F")]
		private Dictionary<TreeBonusAnimation, TreeBonusPosition> GetActualBonusDic()
		{
		/* --- GHIDRA: GetActualBonusDic ---
		void Gameplay_Isles_User_Controller_IsleBonusesViewMediator__GetActualBonusDic
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a58daf == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10316);
		    DAT_ram_00a58daf = '\x01';
		  }
		  Gameplay_Isles_User_Controller_IsleBonusesViewMediator__ConfirmSpentLicenseCallback(param1,param1)
		  ;
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3_00 = func_ii_7508(StringLiteral_10316,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,1,param3_00,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060052BA RID: 21178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BA")]
		[Address(RVA = "0xA090", Offset = "0xA090", VA = "0xA090")]
		private void ConfirmSpentLicenseCallback(BaseDialogWindow<DialogWindow.DialogWindowArgs> window)
		{
		/* --- GHIDRA: ConfirmSpentLicenseCallback ---
		void Gameplay_Isles_User_Controller_IsleBonusesViewMediator__ConfirmSpentLicenseCallback
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 param2_00;
		  uint uVar7;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58db0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_TreeBonusAnimation__TreeBonusPosition__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_TreeBonusAnimation__TreeBonusPosition__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_TreeBonusAnimation__TreeBonusPosition__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_TreeBonusAnimation__TreeBonusPosition__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_TreeBonusAnimation__TreeBonusPosition__get_Key__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_uint__TypeInfo);
		    DAT_ram_00a58db0 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_uint___ctor__);
		  uVar3 = Gameplay_Isles_User_Controller_IsleBonusesViewMediator__SetupBonuses(param1,iVar2);
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,uVar3,
		             Method_System_Collections_Generic_Dictionary_TreeBonusAnimation__TreeBonusPosition__GetEnumerator__
		            );
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x158,&local_18,
		                         Method_System_Collections_Generic_Dictionary_Enumerator_TreeBonusAnimation__TreeBonusPosition__MoveNext__
		                        );
		      iVar5 = DAT_ram_009d3e38;
		      iVar1 = Method_System_Collections_Generic_List_uint__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80faac74;
		      }
		      if (iVar4 == 0) goto code_r0x80faacca;
		      uVar3 = *(undefined4 *)(local_10._4_4_ + 0x10);
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      uVar7 = *(uint *)(iVar2 + 0xc);
		      if (*(uint *)(*(int *)(iVar2 + 8) + 0xc) <= uVar7) break;
		      *(uint *)(iVar2 + 0xc) = uVar7 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar7 * 4 + 0x10) = uVar3;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x37a,iVar2,uVar3,
		               *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80faac74:
		  iVar1 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar5 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar5;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar5 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80faacca:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x14c));
		      param2_00 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                            (iVar2,Method_System_Collections_Generic_List_uint__ToArray__);
		      Gameplay_Isles_User_Controller_UserIsleController___ctor(uVar3,param2_00,0);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x28c,&local_20);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060052BB RID: 21179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BB")]
		[Address(RVA = "0xA091", Offset = "0xA091", VA = "0xA091")]
		private void OnAgreeButtonClicked()
		{
		/* --- GHIDRA: OnAgreeButtonClicked ---
		void Gameplay_Isles_User_Controller_IsleBonusesViewMediator__OnAgreeButtonClicked
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58db1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleBonusesView__Dispose__
		              );
		    DAT_ram_00a58db1 = '\x01';
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleBonusesView__Dispose__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060052BC RID: 21180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BC")]
		[Address(RVA = "0xA092", Offset = "0xA092", VA = "0xA092", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Isles_User_Controller_IsleBonusesViewMediator__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58db2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleDecorationsView___ctor__
		              );
		    DAT_ram_00a58db2 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleDecorationsView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002CFA RID: 11514
		[Token(Token = "0x4002CFA")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<TreeBonusAnimation, TreeBonusPosition> _actualBonusDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Isles_User_Controller_IsleBonusesViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a58da9 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6148);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6149);
		    DAT_ram_00a58da9 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Isles_User_View_IsleBonusesView__ShowBonusCollected(uVar1,param1);
		  Gameplay_Isles_User_Controller_IsleBonusesViewMediator__ViewOnBonusClickedEvent(param1,param1);
		  param1_00 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		  UI_Windows_Alert__Show(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6149,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6148,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  UI_Windows_UnityInstantiator___ctor(param1_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Isles_User_Controller_IsleBonusesViewMediator__set_View
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int param1_00;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  uint uVar10;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58dac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleBonusesView__get_Model__
		              );
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
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_ConfirmSpentLicenseCallback__
		              );
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
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_DialogWindow___);
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_Resources_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22658);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25315);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10315);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22122);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12610);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10317);
		    DAT_ram_00a58dac = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x18) != '\0') {
		    return;
		  }
		  iVar7 = *(int *)(*(int *)(param1 + 8) + 0x34);
		  if (iVar7 != 0) {
		    local_10 = *(undefined4 *)(iVar7 + 0x10);
		    iVar9 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_10,1,0);
		    if (iVar9 != 0) {
		      Gameplay_Isles_User_Controller_IsleBonusesViewMediator__ConfirmSpentLicenseCallback
		                (param1,iVar7);
		      return;
		    }
		    iVar7 = *(int *)(param1 + 8);
		    iVar9 = *(int *)(iVar7 + 0x34);
		    if (iVar9 != 0) {
		      local_10 = *(undefined4 *)(iVar9 + 0x10);
		      iVar9 = UnityEngine_InputForUI_PointerEvent_ButtonsState__Set(&local_10,2,0);
		      if (iVar9 == 0) {
		        iVar7 = *(int *)(iVar7 + 0x34);
		        if (iVar7 == 0) {
		          uVar3 = 0;
		        }
		        else {
		          uVar3 = *(undefined4 *)(iVar7 + 0x14);
		        }
		      }
		      else {
		        uVar3 = 2;
		      }
		      goto code_r0x80faa5de;
		    }
		  }
		  uVar3 = 0;
		code_r0x80faa5de:
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar8;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar10 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x80faa679;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar10);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80faa679:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		  iVar7 = func_ii_7112(uVar2,0);
		  if (*(int *)(iVar7 + 0x60) == 0) {
		    UI_Windows_RestoreArtifactWindow_RestoreArtifactWindowArgs___InitInstance_b__5_0(0);
		  }
		  else {
		    local_c = 0xffffffff;
		    local_10 = Protocol_Consts_Resources_TypeInfo;
		    local_8 = uVar3;
		    uVar3 = Spine_SkeletonJson__GetFloat(&local_10,0);
		    uVar3 = System_Uri__get_Authority(uVar3,0);
		    uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_10315,uVar3,0);
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    iVar7 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    func_ii_8625(iVar7,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = func_ii_7508(StringLiteral_10317,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar7 + 0x18) = uVar4;
		    uVar3 = func_ii_7508(uVar3,1,0,1,0,0,0,0);
		    uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		              (uVar4,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar9 = *piVar8;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + iVar9 + 0x140);
		          goto code_r0x80faa7f0;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80faa7f0:
		    uVar5 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		    iVar9 = func_ii_7112(uVar5,0);
		    local_4 = *(undefined4 *)(iVar9 + 0x60);
		    uVar5 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar4,StringLiteral_22122,uVar5,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar9 = *piVar8;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + iVar9 + 0x140);
		          goto code_r0x80faa8cd;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80faa8cd:
		    uVar5 = (**(code **)((ulonglong)*puVar1 * 4))(piVar8,puVar1[1]);
		    iVar9 = func_ii_7112(uVar5,0);
		    local_4 = *(undefined4 *)(iVar9 + 100);
		    uVar5 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    System_Reflection_FieldInfo__get_IsStatic
		              (uVar4,StringLiteral_25315,uVar5,
		               Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    uVar3 = Core_GameLocalization__GetTranslation(uVar3,uVar4,0);
		    *(undefined4 *)(iVar7 + 0x1c) = uVar3;
		    param1_00 = unnamed_function_1417
		                          (
		                          System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                          );
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    iVar6 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                      );
		    UI_Windows_DialogWindow_DialogWindowArgs___ctor
		              (iVar6,
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    uVar3 = UI_Windows_DialogWindow__get_WindowId(0);
		    *(undefined4 *)(iVar6 + 8) = uVar3;
		    iVar9 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                      );
		    uVar3 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		              (uVar3,param1,
		               Method_Gameplay_Isles_User_Controller_IsleBonusesViewMediator_ConfirmSpentLicenseCallback__
		               ,0);
		    *(undefined4 *)(iVar9 + 8) = uVar3;
		    *(int *)(iVar6 + 0x14) = iVar9;
		    *(undefined4 *)(iVar6 + 0x18) = StringLiteral_22658;
		    iVar9 = 
		    Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		    ;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar10 = *(uint *)(param1_00 + 0xc);
		    if (uVar10 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar10 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar10 * 4 + 0x10) = iVar6;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		    }
		    iVar6 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                      );
		    UI_Windows_DialogWindow_DialogWindowArgs___ctor
		              (iVar6,
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    uVar3 = UI_Windows_DialogWindow__get_YES_LABEL(0);
		    *(undefined4 *)(iVar6 + 8) = uVar3;
		    iVar9 = 
		    Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		    ;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar10 = *(uint *)(param1_00 + 0xc);
		    if (uVar10 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar10 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar10 * 4 + 0x10) = iVar6;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		    }
		    *(int *)(iVar7 + 0x24) = param1_00;
		    Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		              (uVar2,StringLiteral_12610,iVar7,
		               Method_UI_Windows_PopupController_Show_DialogWindow___);
		  }
		  return;
		}
		*/

}
