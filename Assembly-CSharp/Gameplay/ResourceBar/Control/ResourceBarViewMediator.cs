using System;
using Gameplay.ResourceBar.Events;
using Gameplay.ResourceBar.Model;
using Gameplay.ResourceBar.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Consts;

namespace Gameplay.ResourceBar.Control
{
	// Token: 0x02000557 RID: 1367
	[Token(Token = "0x2000557")]
	public class ResourceBarViewMediator : AbstractCozyViewMediator<ResourceBarModel, ResourceBarEvents, ResourceBarController, ResourceBarView>
	{
		// Token: 0x060020E6 RID: 8422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E6")]
		[Address(RVA = "0x7249", Offset = "0x7249", VA = "0x7249")]
		public ResourceBarViewMediator(ResourceBarModel model, ResourceBarEvents events, ResourceBarController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ResourceBar_Control_ResourceBarViewMediator___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58344 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_HandleBalanceChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_HandlePopupStateChangedEvent__
		              );
		    DAT_ram_00a58344 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (uVar1,param1,
		             Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_HandleBalanceChangedEvent__
		             ,0);
		  param1_00 = (int *)func_ii_7048(uVar4,uVar1,0);
		  iVar2 = Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else if ((Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo != *param1_00) ||
		          (*(int **)(param2 + 0x14) = param1_00, *param1_00 != iVar2)) {
		    System_Activator__CreateInstance(param1_00,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar1,param1,
		             Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_HandlePopupStateChangedEvent__
		             ,0);
		  iVar2 = func_ii_7048(uVar4,uVar1,0);
		  uVar1 = System_Action_int__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(param2 + 0x18) = iVar3;
		    uVar1 = System_Action_int__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
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

		// Token: 0x060020E7 RID: 8423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x724A", Offset = "0x724A", VA = "0x724A", Slot = "21")]
		protected override void ResetEvents(ResourceBarEvents events)
		{
		/* --- GHIDRA: ResetEvents ---
		void Gameplay_ResourceBar_Control_ResourceBarViewMediator__ResetEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58345 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_HandleBalanceChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_HandlePopupStateChangedEvent__
		              );
		    DAT_ram_00a58345 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (uVar1,param1,
		             Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_HandleBalanceChangedEvent__
		             ,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  iVar2 = Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(param2 + 0x14) = 0;
		  }
		  else if ((Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo != *param1_00) ||
		          (*(int **)(param2 + 0x14) = param1_00, *param1_00 != iVar2)) {
		    System_Activator__CreateInstance(param1_00,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = *(undefined4 *)(param2 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar1,param1,
		             Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_HandlePopupStateChangedEvent__
		             ,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  uVar1 = System_Action_int__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(param2 + 0x18) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(param2 + 0x18) = iVar3;
		    uVar1 = System_Action_int__TypeInfo;
		    iVar3 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
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

		// Token: 0x060020E8 RID: 8424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x724B", Offset = "0x724B", VA = "0x724B", Slot = "22")]
		protected override void SetupEvents(ResourceBarEvents events)
		{
		/* --- GHIDRA: SetupEvents ---
		void Gameplay_ResourceBar_Control_ResourceBarViewMediator__SetupEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a58346 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_Resources__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_HandleGameObjectIsEnableChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_ViewOnClickOnResourceViewEvent__
		              );
		    DAT_ram_00a58346 = '\x01';
		  }
		  uVar5 = unnamed_function_1417(System_Action_Resources__TypeInfo);
		  System_Action_int___Invoke
		            (uVar5,param1,
		             Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_ViewOnClickOnResourceViewEvent__
		             ,0);
		  if (DAT_ram_00a58337 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Resources__TypeInfo);
		    DAT_ram_00a58337 = '\x01';
		  }
		  iVar3 = *(int *)(param2 + 0x28);
		  while( true ) {
		    iVar4 = 0;
		    iVar6 = func_ii_7048(iVar3,uVar5,0);
		    uVar2 = System_Action_Resources__TypeInfo;
		    if ((iVar6 != 0) && (iVar4 = func_ii_1082(iVar6,System_Action_Resources__TypeInfo), iVar4 == 0))
		    break;
		    iVar4 = func_ii_4329(param2 + 0x28,iVar4,iVar3);
		    bVar1 = iVar4 == iVar3;
		    iVar3 = iVar4;
		    if (bVar1) {
		      uVar5 = unnamed_function_1417(System_Action_bool__TypeInfo);
		      System_Action_AsyncGPUReadbackRequest___Invoke
		                (uVar5,param1,
		                 Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_HandleGameObjectIsEnableChangedEvent__
		                 ,0);
		      if (DAT_ram_00a58339 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		        DAT_ram_00a58339 = '\x01';
		      }
		      iVar3 = *(int *)(param2 + 0x2c);
		      while( true ) {
		        iVar4 = 0;
		        iVar6 = func_ii_7048(iVar3,uVar5,0);
		        uVar2 = System_Action_bool__TypeInfo;
		        if ((iVar6 != 0) && (iVar4 = func_ii_1082(iVar6,System_Action_bool__TypeInfo), iVar4 == 0))
		        break;
		        iVar4 = func_ii_4329(param2 + 0x2c,iVar4,iVar3);
		        bVar1 = iVar4 == iVar3;
		        iVar3 = iVar4;
		        if (bVar1) {
		          return;
		        }
		      }
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x724C", Offset = "0x724C", VA = "0x724C", Slot = "23")]
		protected override void ResetView(ResourceBarView view)
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_ResourceBar_Control_ResourceBarViewMediator__ResetView
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 *puVar7;
		  undefined4 param2_00;
		  int *piVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58347 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ResourceBarModel__ResourceBarEvents__ResourceBarController__ResourceBarView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_Resources__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Resources__ResourceBarItemView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Resources__ResourceBarItemView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Resources__ResourceBarItemView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_HandleGameObjectIsEnableChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_ViewOnClickOnResourceViewEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Resources__ResourceBarItemView__GetEnumerator__
		              );
		    DAT_ram_00a58347 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar4 = unnamed_function_1417(System_Action_Resources__TypeInfo);
		  System_Action_int___Invoke
		            (uVar4,param1,
		             Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_ViewOnClickOnResourceViewEvent__
		             ,0);
		  if (DAT_ram_00a58336 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Resources__TypeInfo);
		    DAT_ram_00a58336 = '\x01';
		  }
		  iVar6 = *(int *)(param2 + 0x28);
		  do {
		    iVar3 = 0;
		    iVar5 = UnityEngine_UI_Image__set_sprite(iVar6,uVar4,0);
		    uVar9 = System_Action_Resources__TypeInfo;
		    if ((iVar5 != 0) && (iVar3 = func_ii_1082(iVar5,System_Action_Resources__TypeInfo), iVar3 == 0))
		    {
		      System_Activator__CreateInstance(iVar5,uVar9);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = func_ii_4329(param2 + 0x28,iVar3,iVar6);
		    bVar1 = iVar3 != iVar6;
		    iVar6 = iVar3;
		  } while (bVar1);
		  uVar4 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar4,param1,
		             Method_Gameplay_ResourceBar_Control_ResourceBarViewMediator_HandleGameObjectIsEnableChangedEvent__
		             ,0);
		  if (DAT_ram_00a58338 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a58338 = '\x01';
		  }
		  iVar6 = *(int *)(param2 + 0x2c);
		  do {
		    iVar3 = 0;
		    iVar5 = UnityEngine_UI_Image__set_sprite(iVar6,uVar4,0);
		    uVar9 = System_Action_bool__TypeInfo;
		    if ((iVar5 != 0) && (iVar3 = func_ii_1082(iVar5,System_Action_bool__TypeInfo), iVar3 == 0)) {
		      System_Activator__CreateInstance(iVar5,uVar9);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar3 = func_ii_4329(param2 + 0x2c,iVar3,iVar6);
		    bVar1 = iVar3 != iVar6;
		    iVar6 = iVar3;
		  } while (bVar1);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar4 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar6 + 0x24),
		                     Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar4,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_Resources__ResourceBarItemView__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = &local_10;
		code_r0x80ed39f9:
		  DAT_ram_009d3e38 = 0;
		  iVar3 = import::env::invoke_iii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,&local_10,
		                     Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Resources__ResourceBarItemView__MoveNext__
		                    );
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    if (iVar3 == 0) goto code_r0x80ed3ea5;
		    iVar6 = local_8._4_4_;
		    piVar8 = *(int **)(param1[2] + 0x18);
		    iVar3 = *piVar8;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		        if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		          puVar7 = (undefined4 *)(piVar10[1] * 8 + iVar3 + 0x140);
		          goto code_r0x80ed3ad9;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                        Core_Gameplay_IGame_TypeInfo,0x10);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ed3e15:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		code_r0x80ed3ad9:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar7,piVar8,puVar7[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ed3e15;
		      uVar4 = *(undefined4 *)(iVar3 + 0x14);
		      piVar8 = *(int **)(param1[2] + 0x18);
		      iVar3 = *piVar8;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		            puVar7 = (undefined4 *)(piVar10[1] * 8 + iVar3 + 0x1f8);
		            goto code_r0x80ed3bb9;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar7 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                          Core_Gameplay_IGame_TypeInfo,0x27);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80ed3e1f:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		code_r0x80ed3bb9:
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii(*puVar7,piVar8,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80ed3e1f;
		        iVar5 = **(int **)(iVar3 + 0x14);
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii
		                          (*(undefined4 *)(iVar5 + 0x100),*(int **)(iVar3 + 0x14),
		                           *(undefined4 *)(iVar5 + 0x104));
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          uVar9 = *(undefined4 *)(iVar5 + 0x30);
		          piVar8 = *(int **)(param1[2] + 0x10);
		          iVar3 = *piVar8;
		          if (*(ushort *)(iVar3 + 0xb6) != 0) {
		            uVar2 = 0;
		            do {
		              piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8);
		              if (Core_Dict_IDictProvider_TypeInfo == *piVar10) {
		                puVar7 = (undefined4 *)(piVar10[1] * 8 + iVar3 + 0xd0);
		                goto code_r0x80ed3ce2;
		              }
		              uVar2 = uVar2 + 1;
		            } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar7 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                              Core_Dict_IDictProvider_TypeInfo,2);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x80ed3ce2:
		            DAT_ram_009d3e38 = 0;
		            param2_00 = import::env::invoke_iii(*puVar7,piVar8,puVar7[1]);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80ed3e33;
		            DAT_ram_009d3e38 = 0;
		            iVar3 = import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x334,param2_00,
		                               *(undefined4 *)(iVar6 + 0x24),0);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x80ed3d58;
		            goto code_r0x80ed3e3d;
		          }
		code_r0x80ed3e33:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		      }
		    }
		  }
		code_r0x80ed3e4f:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar3 = *piVar8;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      iVar6 = 0;
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80ed3ea5:
		      DAT_ram_009d3e38 = 0;
		      UI_Windows_PopupController__BringWindowToFront(*(undefined4 *)(param1[2] + 0x14),0);
		      Gameplay_ResourceBar_Control_ResourceBarViewMediator__SetupView(param1,iVar6,iVar6);
		      Gameplay_ResourceBar_Control_ResourceBarViewMediator__ViewOnOnEnable(param1,iVar6);
		      if (DAT_ram_00a58335 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_UnityEngine_Component_GetComponent_ShowHideUIElementByRestrictions___);
		        DAT_ram_00a58335 = '\x01';
		      }
		      uVar4 = func_ii_5677(param2,
		                           Method_UnityEngine_Component_GetComponent_ShowHideUIElementByRestrictions___
		                          );
		      iVar6 = param1[2];
		      Gameplay_UserInterface_View_RankView_RankImages___ctor
		                (uVar4,*(undefined4 *)(iVar6 + 8),*(undefined4 *)(iVar6 + 0xc),
		                 *(undefined4 *)(iVar6 + 0x10),0);
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x145,&local_20);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
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
		code_r0x80ed3d58:
		  *(undefined4 *)(iVar6 + 0x50) = uVar9;
		  *(undefined4 *)(iVar6 + 0x4c) = uVar4;
		  if ((*(int *)(iVar6 + 0x54) != iVar3) && (*(int *)(iVar6 + 0x54) = iVar3, iVar3 != 0)) {
		    iVar5 = *(int *)(iVar6 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x335,iVar3,0)
		    ;
		    if (DAT_ram_009d3e38 != 1) {
		      *(undefined4 *)(iVar5 + 0x28) = uVar4;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x62,
		                 *(undefined4 *)(iVar5 + 0x10),uVar4,0);
		      if (DAT_ram_009d3e38 != 1) {
		        *(int *)(*(int *)(iVar6 + 0x1c) + 0x2c) = iVar6;
		        *(int *)(*(int *)(iVar6 + 0x20) + 0x2c) = iVar6;
		        goto code_r0x80ed39f9;
		      }
		    }
		code_r0x80ed3e3d:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80ed3e4f;
		  }
		  goto code_r0x80ed39f9;
		}
		*/

		}

		// Token: 0x060020EA RID: 8426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x724D", Offset = "0x724D", VA = "0x724D", Slot = "24")]
		protected override void SetupView(ResourceBarView view)
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_ResourceBar_Control_ResourceBarViewMediator__SetupView
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  char cVar1;
		  undefined1 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  int iVar7;
		  uint uVar8;
		  uint uVar9;
		  int *piVar10;
		  undefined4 uVar11;
		  int iVar12;
		  int iVar13;
		  undefined8 uVar14;
		  uint uVar15;
		  uint uVar16;
		  undefined1 auStack_40 [8];
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  int local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar7 = 0;
		  uVar16 = 0;
		  uVar9 = 0;
		  if (DAT_ram_00a58348 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ResourceBarModel__ResourceBarEvents__ResourceBarController__ResourceBarView__get_Model__
		              );
		    DAT_ram_00a58348 = '\x01';
		  }
		  local_14 = 0;
		  iVar3 = UI_Windows_PopupController__TryGetLayer(*(undefined4 *)(param1[2] + 0x14),&local_14,0);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar3 == 0) {
		    *(undefined1 *)(iVar4 + 0x41) = 1;
		    iVar7 = *(int *)(iVar4 + 0x10);
		    uVar8 = *(uint *)(iVar7 + 0xc);
		    if (0 < (int)uVar8) {
		      iVar3 = 0;
		      if (3 < uVar8) {
		        iVar4 = iVar7 + 0x10;
		        do {
		          uVar15 = iVar3 * 4;
		          *(undefined1 *)(*(int *)(iVar4 + uVar15) + 0x44) = 1;
		          *(undefined1 *)(*(int *)(iVar4 + (uVar15 | 4)) + 0x44) = 1;
		          *(undefined1 *)(*(int *)(iVar4 + (uVar15 | 8)) + 0x44) = 1;
		          *(undefined1 *)(*(int *)(iVar4 + (uVar15 | 0xc)) + 0x44) = 1;
		          iVar3 = iVar3 + 4;
		          uVar16 = uVar16 + 4;
		        } while (uVar16 != (uVar8 & 0xfffffffc));
		      }
		      if ((uVar8 & 3) != 0) {
		        do {
		          *(undefined1 *)(*(int *)(iVar7 + iVar3 * 4 + 0x10) + 0x44) = 1;
		          iVar3 = iVar3 + 1;
		          uVar9 = uVar9 + 1;
		        } while (uVar9 != (uVar8 & 3));
		      }
		    }
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar5,0);
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    piVar10 = *(int **)(iVar3 + 0x10);
		    if (DAT_ram_00a5833e == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_Scenes__TypeInfo);
		      DAT_ram_00a5833e = '\x01';
		    }
		    uVar11 = *(undefined4 *)(iVar7 + 0x1c);
		    iVar3 = *piVar10;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar16 = 0;
		      do {
		        if (System_Collections_Generic_ICollection_Scenes__TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar16 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar16 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x80ed4378;
		        }
		        uVar16 = uVar16 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar16);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar10,System_Collections_Generic_ICollection_Scenes__TypeInfo,4)
		    ;
		code_r0x80ed4378:
		    iVar3 = (**(code **)((ulonglong)*puVar6 * 4))(piVar10,uVar11,puVar6[1]);
		    if (iVar3 == 0) {
		      uVar16 = 0;
		    }
		    else {
		      uVar16 = (uint)(*(char *)(iVar7 + 0x20) != '\0');
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,uVar16,0);
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = UI_UserContextMenu_ContextElements_VisitIsleUserContextMenuElement___ctor
		                      (*(undefined4 *)(iVar7 + 0x14),*(undefined4 *)(iVar3 + 0x18),0);
		    iVar7 = *(int *)(iVar7 + 0x10);
		    if (0 < *(int *)(iVar7 + 0xc)) {
		      iVar4 = 0;
		      do {
		        iVar12 = *(int *)(*(int *)(iVar7 + iVar4 * 4 + 0x10) + 0x10);
		        local_20 = *(undefined8 *)(iVar3 + 0x14);
		        local_28 = *(undefined8 *)(iVar3 + 0xc);
		        uVar2 = *(undefined1 *)(iVar3 + 0x1c);
		        uVar14 = *(undefined8 *)(iVar3 + 0xc);
		        *(undefined8 *)(iVar12 + 0x20) = *(undefined8 *)(iVar3 + 0x14);
		        *(undefined8 *)(iVar12 + 0x18) = uVar14;
		        iVar13 = **(int **)(iVar12 + 0x14);
		        local_10 = local_28;
		        local_8 = local_20;
		        (**(code **)((ulonglong)*(uint *)(iVar13 + 0x178) * 4))
		                  (*(int **)(iVar12 + 0x14),&local_28,*(undefined4 *)(iVar13 + 0x17c));
		        *(undefined1 *)(iVar12 + 0x2c) = uVar2;
		        iVar4 = iVar4 + 1;
		      } while (iVar4 < *(int *)(iVar7 + 0xc));
		    }
		  }
		  else {
		    Gameplay_ResourceBar_View_ResourceBarView__get_IsInteractive
		              (iVar4,(uint)*(byte *)(*(int *)(local_14 + 0x30) + 0xc),auStack_40);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = UI_UserContextMenu_ContextElements_VisitIsleUserContextMenuElement___ctor
		                      (*(undefined4 *)(iVar3 + 0x14),*(undefined4 *)(local_14 + 0x14),0);
		    iVar3 = *(int *)(iVar3 + 0x10);
		    if (0 < *(int *)(iVar3 + 0xc)) {
		      do {
		        iVar12 = *(int *)(*(int *)(iVar3 + iVar7 * 4 + 0x10) + 0x10);
		        local_30 = *(undefined8 *)(iVar4 + 0x14);
		        local_38 = *(undefined8 *)(iVar4 + 0xc);
		        uVar2 = *(undefined1 *)(iVar4 + 0x1c);
		        uVar14 = *(undefined8 *)(iVar4 + 0xc);
		        *(undefined8 *)(iVar12 + 0x20) = *(undefined8 *)(iVar4 + 0x14);
		        *(undefined8 *)(iVar12 + 0x18) = uVar14;
		        iVar13 = **(int **)(iVar12 + 0x14);
		        local_10 = local_38;
		        local_8 = local_30;
		        (**(code **)((ulonglong)*(uint *)(iVar13 + 0x178) * 4))
		                  (*(int **)(iVar12 + 0x14),&local_38,*(undefined4 *)(iVar13 + 0x17c));
		        *(undefined1 *)(iVar12 + 0x2c) = uVar2;
		        iVar7 = iVar7 + 1;
		      } while (iVar7 < *(int *)(iVar3 + 0xc));
		    }
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (uVar5,0);
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    piVar10 = *(int **)(iVar3 + 0x10);
		    cVar1 = *(char *)(local_14 + 0x18);
		    if (DAT_ram_00a5833e == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_Scenes__TypeInfo);
		      DAT_ram_00a5833e = '\x01';
		    }
		    uVar16 = 0;
		    uVar11 = *(undefined4 *)(iVar7 + 0x1c);
		    iVar3 = *piVar10;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_ICollection_Scenes__TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar16 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar16 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x80ed41ac;
		        }
		        uVar16 = uVar16 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar16);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar10,System_Collections_Generic_ICollection_Scenes__TypeInfo,4)
		    ;
		code_r0x80ed41ac:
		    iVar3 = (**(code **)((ulonglong)*puVar6 * 4))(piVar10,uVar11,puVar6[1]);
		    if (iVar3 == 0) {
		      uVar16 = 0;
		    }
		    else {
		      uVar16 = (uint)(*(char *)(iVar7 + 0x20) != '\0');
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,uVar16 & cVar1 != '\0',0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EB")]
		[Address(RVA = "0x724E", Offset = "0x724E", VA = "0x724E")]
		private void HandlePopupStateChangedEvent(int visiblefullscreenwndcount)
		{
		/* --- GHIDRA: HandlePopupStateChangedEvent ---
		void Gameplay_ResourceBar_Control_ResourceBarViewMediator__HandlePopupStateChangedEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  if (param2 == 0) {
		    Gameplay_ResourceBar_Control_ResourceBarViewMediator__ViewOnClickOnResourceViewEvent
		              (param1,param1);
		    return;
		  }
		  Gameplay_ResourceBar_Control_ResourceBarViewMediator__ViewOnOnEnable(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EC")]
		[Address(RVA = "0x724F", Offset = "0x724F", VA = "0x724F")]
		private void HandleGameObjectIsEnableChangedEvent(bool value)
		{
		/* --- GHIDRA: HandleGameObjectIsEnableChangedEvent ---
		/* WARNING: Removing unreachable block (ram,0x80ed4e0b) */
		
		void Gameplay_ResourceBar_Control_ResourceBarViewMediator__HandleGameObjectIsEnableChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  float8 fVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param2_00;
		  int *piVar5;
		  double dVar6;
		  undefined1 auStack_50 [8];
		  int local_48;
		  undefined1 *puStack_44;
		  undefined8 local_40;
		  undefined8 local_38;
		  float8 local_30;
		  int local_24;
		  undefined1 local_20 [8];
		  undefined8 local_18;
		  undefined8 local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a58349 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ValueTuple_Money_MoneyType__double___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ValueTuple_Money_MoneyType__double___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ValueTuple_Money_MoneyType__double___get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_ValueTuple_Money_MoneyType__double___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a58349 = '\x01';
		  }
		  local_24 = 0;
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__GetQuotient(param3,0);
		  System_Collections_Generic_List_VisualTreeDataBindingsUpdater_VersionInfo___ForEach
		            (&local_48,uVar3,
		             Method_System_Collections_Generic_List_ValueTuple_Money_MoneyType__double___GetEnumerator__
		            );
		  local_8 = local_30;
		  local_10 = local_38;
		  local_18 = local_40;
		  local_48 = 0;
		  puStack_44 = local_20;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x14a,local_20,
		                         Method_System_Collections_Generic_List_Enumerator_ValueTuple_Money_MoneyType__double___MoveNext__
		                        );
		      fVar2 = local_8;
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ed4edb;
		      }
		      if (iVar4 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      uVar3 = (undefined4)local_10;
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Core_Money_Money_MoneyType_TypeInfo);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80ed4edb;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      param2_00 = func_ii_7278(uVar3,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ed4edb;
		      }
		      DAT_ram_009d3e38 = 0;
		      dVar6 = func_ii_6906(param2,param2_00,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ed4edb;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ed4edb;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar3 = func_ii_7278(uVar3,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ed4edb;
		      }
		      if (DAT_ram_00a5833d == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (0x7ff,&
		                         Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__TryGetValue__
		                  );
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a5833d = '\x01';
		          goto code_r0x80ed4ce7;
		        }
		code_r0x80ed4ebd:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ed4edb;
		      }
		code_r0x80ed4ce7:
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x14b,
		                         *(undefined4 *)(iVar4 + 0x24),uVar3,&local_24,
		                         Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__TryGetValue__
		                        );
		      iVar1 = local_24;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ed4ebd;
		    } while (iVar4 == 0);
		    if (DAT_ram_00a5832c == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&
		                       Method_System_Collections_Generic_Queue_ResourceBarItemView_ResourceDeltaData__Enqueue__
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&Gameplay_ResourceBar_View_ResourceBarItemView_ResourceDeltaData_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_00a5832c = '\x01';
		    }
		    uVar3 = *(undefined4 *)(iVar1 + 0x3c);
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_ResourceBar_View_ResourceBarItemView_ResourceDeltaData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    *(double *)(iVar4 + 8) = dVar6;
		    *(float8 *)(iVar4 + 0x10) = fVar2;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x14c,uVar3,iVar4,
		               Method_System_Collections_Generic_Queue_ResourceBarItemView_ResourceDeltaData__Enqueue__
		              );
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x14d,iVar1,auStack_50);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ed4edb:
		  iVar1 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar4 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_48 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar4 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x14e,&local_48);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
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

		// Token: 0x060020ED RID: 8429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x7250", Offset = "0x7250", VA = "0x7250")]
		private void HandleBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
		{
		/* --- GHIDRA: HandleBalanceChangedEvent ---
		void Gameplay_ResourceBar_Control_ResourceBarViewMediator__HandleBalanceChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5834a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ResourceBarModel__ResourceBarEvents__ResourceBarController__ResourceBarView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5834a = '\x01';
		  }
		  param1_01 = *(int **)(*(int *)(param1 + 8) + 0x18);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 400);
		        goto code_r0x80ed504d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x80ed504d:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_BankManager__ShowBankWindow(param1_00,param2,1,0);
		  return;
		}
		*/

		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EE")]
		[Address(RVA = "0x7251", Offset = "0x7251", VA = "0x7251")]
		private void ViewOnClickOnResourceViewEvent(Resources resourceId)
		{
		/* --- GHIDRA: ViewOnClickOnResourceViewEvent ---
		void Gameplay_ResourceBar_Control_ResourceBarViewMediator__ViewOnClickOnResourceViewEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5834b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Resources__ResourceBarItemView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Resources__ResourceBarItemView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Resources__ResourceBarItemView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Resources__ResourceBarItemView__GetEnumerator__
		              );
		    DAT_ram_00a5834b = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar1 + 0x24),
		                     Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_Resources__ResourceBarItemView__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Resources__ResourceBarItemView__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ed49c2;
		    }
		    iVar1 = local_18;
		    if (iVar3 == 0) goto code_r0x80ed4a0b;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x148,local_8._4_4_,auStack_20);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ed49c2:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x80ed4a0b:
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x149,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
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

		// Token: 0x060020EF RID: 8431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EF")]
		[Address(RVA = "0x7252", Offset = "0x7252", VA = "0x7252")]
		private void ViewOnOnDisable()
		{
		/* --- GHIDRA: ViewOnOnDisable ---
		void Gameplay_ResourceBar_Control_ResourceBarViewMediator__ViewOnOnDisable
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_ResourceBar_Control_ResourceBarViewMediator__ViewOnOnEnable(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F0")]
		[Address(RVA = "0x7253", Offset = "0x7253", VA = "0x7253")]
		private void ViewOnOnEnable()
		{
		/* --- GHIDRA: ViewOnOnEnable ---
		void Gameplay_ResourceBar_Control_ResourceBarViewMediator__ViewOnOnEnable
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  double param2_00;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5834c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ResourceBarModel__ResourceBarEvents__ResourceBarController__ResourceBarView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Resources__ResourceBarItemView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Resources__ResourceBarItemView__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Resources__ResourceBarItemView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Resources__ResourceBarItemView__GetEnumerator__
		              );
		    DAT_ram_00a5834c = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar1 + 0x24),
		                     Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_Resources__ResourceBarItemView__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xa1,&local_10,
		                         Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_Resources__ResourceBarItemView__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ed4798;
		      }
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      iVar1 = local_8._4_4_;
		      DAT_ram_009d3e38 = 0;
		      param2_00 = func_ii_6906(*(undefined4 *)(*(int *)(param1[2] + 8) + 0x78),
		                               *(undefined4 *)(local_8._4_4_ + 0x24),0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ed4786;
		      if (DAT_ram_00a58329 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(0x7ff,&Utils_StringUtils_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80ed4786;
		        DAT_ram_00a58329 = '\x01';
		      }
		      *(double *)(iVar1 + 0x58) = param2_00;
		      iVar1 = *(int *)(iVar1 + 0x10);
		      if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Utils_StringUtils_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80ed4786;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_idi
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x146,param2_00,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ed4786;
		      piVar4 = *(int **)(iVar1 + 0x14);
		      iVar3 = *piVar4;
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::invoke_iii
		                            (*(undefined4 *)(iVar3 + 0x2c8),piVar4,*(undefined4 *)(iVar3 + 0x2cc));
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ed4786;
		      DAT_ram_009d3e38 = 0;
		      iVar3 = System_Collections_CollectionBase___ctor(param1_00,uVar2,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ed4786;
		    } while (iVar3 != 0);
		    piVar4 = *(int **)(iVar1 + 0x14);
		    iVar1 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (*(undefined4 *)(iVar1 + 0x2d0),piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x80ed4786:
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ed4798:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x147,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar2);
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

		// Token: 0x060020F1 RID: 8433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F1")]
		[Address(RVA = "0x7254", Offset = "0x7254", VA = "0x7254")]
		private void DisplayBalance()
		{
		/* --- GHIDRA: DisplayBalance ---
		void Gameplay_ResourceBar_Control_ResourceBarViewMediator__DisplayBalance
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5834d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_MonoBehaviourWithStates_ClientStateChangedDelegate_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_CultsFade_HandleStateChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__remove_CurrentStateChangedEvent__
		              );
		    DAT_ram_00a5834d = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417
		                        (
		                        UI_MonoBehaviourWithStates_ClientStateChangedDelegate_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__TypeInfo
		                        );
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate_ByteEnum___Invoke
		            (param1_00,param1,Method_Gameplay_RegisterV2_View_CultsFade_HandleStateChangedEvent__,0)
		  ;
		  UI_MonoBehaviourWithStates_Int32Enum___get_CurrentState
		            (param1_01,param1_00,
		             Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__remove_CurrentStateChangedEvent__
		            );
		  return;
		}
		*/

		}
	}
}
