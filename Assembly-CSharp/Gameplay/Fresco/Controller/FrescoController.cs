using System;
using System.Collections.Generic;
using Core.Data.Balance;
using Gameplay.Bank.Model;
using Gameplay.Fresco.Events;
using Gameplay.Fresco.Model;
using Gameplay.Fresco.View.Groups;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Fresco;
using ServicesNamespace;
using Utils;

namespace Gameplay.Fresco.Controller
{
	// Token: 0x0200080B RID: 2059
	[Token(Token = "0x200080B")]
	public class FrescoController : AbstractController<FrescoModel, Gameplay.Fresco.Events.FrescoEvents>
	{
		// Token: 0x0600305F RID: 12383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600305F")]
		[Address(RVA = "0x80C4", Offset = "0x80C4", VA = "0x80C4")]
		public FrescoController(FrescoModel model, Gameplay.Fresco.Events.FrescoEvents events, FrescoService frescoService, IBalanceSource balanceSource)
		{
		/* --- GHIDRA: <UpdateCurrentGroup>b__28_0 ---
		void Gameplay_Fresco_Controller_FrescoController___UpdateCurrentGroup_b__28_0(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a575b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Controller_FrescoController___c_TypeInfo);
		    DAT_ram_00a575b7 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Fresco_Controller_FrescoController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Fresco_Controller_FrescoController__HandleStop(param1,param1);
		  Gameplay_Fresco_Controller_FrescoController__FrescoUniversalFragmentsChangedHandler(param1,param1)
		  ;
		  Gameplay_Fresco_Controller_FrescoController__GetBankOptions(param1,param1);
		  Gameplay_Fresco_Controller_FrescoController__InstallUniversalFragments(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003060 RID: 12384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003060")]
		[Address(RVA = "0x80C5", Offset = "0x80C5", VA = "0x80C5", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Fresco_Controller_FrescoController__HandleRun(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Fresco_Controller_FrescoController__StartListen(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003061 RID: 12385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003061")]
		[Address(RVA = "0x80C6", Offset = "0x80C6", VA = "0x80C6", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Fresco_Controller_FrescoController__HandleStop(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a575a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFrescoUpdatedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFrescoUniversalFragmentsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoController_FrescoUniversalFragmentsChangedHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoController_FrescoUpdatedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoController_HandleBalanceChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_TypeInfo);
		    DAT_ram_00a575a3 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_ProtoFrescoUpdatedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Fresco_Controller_FrescoController_FrescoUpdatedHandler__,
		             0);
		  ServicesNamespace_FrescoService__get_ServiceId(uVar4,uVar2,0);
		  param1_00 = *(int **)(param1 + 0x1c);
		  uVar2 = unnamed_function_1417(Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (uVar2,param1,
		             Method_Gameplay_Fresco_Controller_FrescoController_HandleBalanceChangedEvent__,0);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_Balance_IBalanceSource_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dad901;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Data_Balance_IBalanceSource_TypeInfo,0);
		code_r0x80dad901:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_ProtoFrescoUniversalFragmentsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Fresco_Controller_FrescoController_FrescoUniversalFragmentsChangedHandler__
		             ,0);
		  ServicesNamespace_FrescoService__remove_FrescoUpdatedEvent(uVar4,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003062 RID: 12386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003062")]
		[Address(RVA = "0x80C7", Offset = "0x80C7", VA = "0x80C7")]
		private void StartListen()
		{
		/* --- GHIDRA: StartListen ---
		void Gameplay_Fresco_Controller_FrescoController__StartListen(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a575a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFrescoUpdatedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoFrescoUniversalFragmentsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoController_FrescoUniversalFragmentsChangedHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoController_FrescoUpdatedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoController_HandleBalanceChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_TypeInfo);
		    DAT_ram_00a575a4 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_ProtoFrescoUpdatedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Fresco_Controller_FrescoController_FrescoUpdatedHandler__,
		             0);
		  ServicesNamespace_FrescoService__add_FrescoUpdatedEvent(uVar4,uVar2,0);
		  param1_00 = *(int **)(param1 + 0x1c);
		  uVar2 = unnamed_function_1417(Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (uVar2,param1,
		             Method_Gameplay_Fresco_Controller_FrescoController_HandleBalanceChangedEvent__,0);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_Balance_IBalanceSource_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x80dae240;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Data_Balance_IBalanceSource_TypeInfo,1);
		code_r0x80dae240:
		  (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar2,puVar3[1]);
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_ProtoFrescoUniversalFragmentsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Fresco_Controller_FrescoController_FrescoUniversalFragmentsChangedHandler__
		             ,0);
		  ServicesNamespace_FrescoService__add_FrescoUniversalFragmentsChangedEvent(uVar4,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003063 RID: 12387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003063")]
		[Address(RVA = "0x80C8", Offset = "0x80C8", VA = "0x80C8")]
		private void StopListen()
		{
		/* --- GHIDRA: StopListen ---
		void Gameplay_Fresco_Controller_FrescoController__StopListen
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Gameplay_Fresco_Controller_FrescoController__GetUniversalFragmentsCountHandler
		            (param1,*(undefined4 *)(param2 + 0xc),param2);
		  return;
		}
		*/

		}

		// Token: 0x06003064 RID: 12388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003064")]
		[Address(RVA = "0x80C9", Offset = "0x80C9", VA = "0x80C9")]
		private void FrescoUpdatedHandler(ProtoFrescoUpdatedEvt msg)
		{
		/* --- GHIDRA: FrescoUpdatedHandler ---
		void Gameplay_Fresco_Controller_FrescoController__FrescoUpdatedHandler
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003065 RID: 12389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003065")]
		[Address(RVA = "0x80CA", Offset = "0x80CA", VA = "0x80CA")]
		private void HandleBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
		{
		/* --- GHIDRA: HandleBalanceChangedEvent ---
		void Gameplay_Fresco_Controller_FrescoController__HandleBalanceChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x2c) = uVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),uVar2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003066 RID: 12390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003066")]
		[Address(RVA = "0x80CB", Offset = "0x80CB", VA = "0x80CB")]
		private void FrescoUniversalFragmentsChangedHandler(ProtoFrescoUniversalFragmentsChangedEvt msg)
		{
		/* --- GHIDRA: FrescoUniversalFragmentsChangedHandler ---
		void Gameplay_Fresco_Controller_FrescoController__FrescoUniversalFragmentsChangedHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  int *piVar10;
		  int local_10;
		  int **local_c;
		  undefined4 local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a575a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_RegularOptionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_RegularOptionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BankOptionData__TypeInfo);
		    DAT_ram_00a575a5 = '\x01';
		  }
		  local_8 = 0;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_BankOptionData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_BankOptionData___ctor__);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar8 = *(int **)(*(int *)(iVar3 + 0xc) + 8);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80dada4d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80dada4d:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  piVar8 = (int *)Core_Extensions_Dict_DictExt__GetFrescoDic(uVar5,1,0);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_RegularOptionsDic__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dadad9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar8,
		                                System_Collections_Generic_IEnumerable_RegularOptionsDic__TypeInfo,0
		                               );
		code_r0x80dadad9:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		  local_10 = 0;
		  local_c = &local_4;
		code_r0x80dadafe:
		  do {
		    do {
		      piVar8 = local_4;
		      iVar3 = *local_4;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar6 = (undefined4 *)(iVar3 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80dadba4;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar6 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80dadbe8:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dade6d;
		      }
		code_r0x80dadba4:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		      piVar8 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80dadbe8;
		      if (iVar3 == 0) goto code_r0x80dadeb6;
		      iVar3 = *local_4;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_RegularOptionsDic__TypeInfo == *piVar10) {
		            puVar6 = (undefined4 *)(iVar3 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80dadc95;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar6 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_RegularOptionsDic__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80daddad:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dade6d;
		      }
		code_r0x80dadc95:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80daddad;
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dade6d;
		      }
		      piVar8 = *(int **)(*(int *)(iVar9 + 0xc) + 0x14);
		      iVar7 = *piVar8;
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii
		                        (*(undefined4 *)(iVar7 + 0x100),piVar8,*(undefined4 *)(iVar7 + 0x104));
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dade6d;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x314,uVar5,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0xc) + 0xc) + 0xc),&local_8,0);
		      iVar7 = DAT_ram_009d3e38;
		      iVar3 = Method_System_Collections_Generic_List_BankOptionData__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dade6d;
		      }
		    } while (iVar9 == 0);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = local_8;
		      goto code_r0x80dadafe;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,local_8,
		               *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dade6d:
		  iVar3 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar7) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_10 = *piVar8;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x80dadeb6:
		      DAT_ram_009d3e38 = 0;
		      piVar8 = *local_c;
		      if (piVar8 != (int *)0x0) {
		        uVar1 = 0;
		        iVar3 = *piVar8;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		              puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80dadf31;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar8,System_IDisposable_TypeInfo,0);
		code_r0x80dadf31:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar8,puVar4[1]);
		      }
		      if (local_10 == 0) {
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        if (DAT_ram_00a57590 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_BankOptionData__AddRange__);
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_BankOptionData__Clear__);
		          DAT_ram_00a57590 = '\x01';
		        }
		        iVar9 = *(int *)(iVar3 + 0x3c);
		        iVar7 = *(int *)(iVar9 + 0xc);
		        *(undefined4 *)(iVar9 + 0xc) = 0;
		        *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		        if (0 < iVar7) {
		          func_ii_2064(*(undefined4 *)(iVar9 + 8),0,iVar7,0);
		          iVar9 = *(int *)(iVar3 + 0x3c);
		        }
		        func_ii_6335(iVar9,iVar2,Method_System_Collections_Generic_List_BankOptionData__AddRange__);
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x315,&local_10);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003067 RID: 12391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003067")]
		[Address(RVA = "0x80CC", Offset = "0x80CC", VA = "0x80CC")]
		private void GetBankOptions()
		{
		/* --- GHIDRA: GetBankOptions ---
		void Gameplay_Fresco_Controller_FrescoController__GetBankOptions(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a575a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoController_GetUserFrescoesHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a575a6 = '\x01';
		  }
		  uVar1 = ServicesNamespace_FrescoService__ServerEventHandler(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Fresco_Controller_FrescoController_GetUserFrescoesHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003068 RID: 12392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003068")]
		[Address(RVA = "0x80CD", Offset = "0x80CD", VA = "0x80CD")]
		public void GetUserFrescoes()
		{
		/* --- GHIDRA: GetUserFrescoes ---
		void Gameplay_Fresco_Controller_FrescoController__GetUserFrescoes
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a575a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoController_GetOtherUserFrescoesHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a575a7 = '\x01';
		  }
		  uVar1 = ServicesNamespace_FrescoService__GetUserFrescoes(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Fresco_Controller_FrescoController_GetOtherUserFrescoesHandler__,0);
		  local_8 = param2;
		  param3_00 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param3_00,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003069 RID: 12393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003069")]
		[Address(RVA = "0x80CE", Offset = "0x80CE", VA = "0x80CE")]
		public void GetOtherUserFrescoes(ulong userId)
		{
		/* --- GHIDRA: GetOtherUserFrescoes ---
		void Gameplay_Fresco_Controller_FrescoController__GetOtherUserFrescoes
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a575a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoController_FillFrescoSlotsHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a575a8 = '\x01';
		  }
		  uVar1 = ServicesNamespace_FrescoService__GetOtherUserFrescoes
		                    (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Fresco_Controller_FrescoController_FillFrescoSlotsHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600306A RID: 12394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306A")]
		[Address(RVA = "0x80CF", Offset = "0x80CF", VA = "0x80CF")]
		public void FillFrescoSlots(ulong frescoId, uint[] index)
		{
		/* --- GHIDRA: FillFrescoSlots ---
		void Gameplay_Fresco_Controller_FrescoController__FillFrescoSlots
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a575a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoController_CompleteFrescoHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a575a9 = '\x01';
		  }
		  uVar1 = ServicesNamespace_FrescoService__FillFrescoSlots(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Fresco_Controller_FrescoController_CompleteFrescoHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600306B RID: 12395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306B")]
		[Address(RVA = "0x80D0", Offset = "0x80D0", VA = "0x80D0")]
		public void CompleteFresco(ulong frescoId)
		{
		/* --- GHIDRA: CompleteFresco ---
		void Gameplay_Fresco_Controller_FrescoController__CompleteFresco
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a575aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoController_CollectFrescoRewardHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a575aa = '\x01';
		  }
		  uVar1 = ServicesNamespace_FrescoService__CompleteFresco(*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Fresco_Controller_FrescoController_CollectFrescoRewardHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600306C RID: 12396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306C")]
		[Address(RVA = "0x80D1", Offset = "0x80D1", VA = "0x80D1")]
		public void CollectFrescoReward(ulong frescoId)
		{
		/* --- GHIDRA: CollectFrescoReward ---
		void Gameplay_Fresco_Controller_FrescoController__CollectFrescoReward
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a575ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoController_InstallUniversalFragmentsHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a575ab = '\x01';
		  }
		  uVar1 = ServicesNamespace_FrescoService__CollectFrescoReward
		                    (*(undefined4 *)(param1 + 0x18),param2,param3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Fresco_Controller_FrescoController_InstallUniversalFragmentsHandler__,0
		            );
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600306D RID: 12397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306D")]
		[Address(RVA = "0x80D2", Offset = "0x80D2", VA = "0x80D2")]
		public void InstallUniversalFragments(ulong frescoId, uint[] index)
		{
		/* --- GHIDRA: InstallUniversalFragments ---
		void Gameplay_Fresco_Controller_FrescoController__InstallUniversalFragments
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a575ac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoController_GetUniversalFragmentsCountHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a575ac = '\x01';
		  }
		  uVar1 = ServicesNamespace_FrescoService__InstallUniversalFragments
		                    (*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Fresco_Controller_FrescoController_GetUniversalFragmentsCountHandler__,
		             0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600306E RID: 12398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306E")]
		[Address(RVA = "0x80D3", Offset = "0x80D3", VA = "0x80D3")]
		public void GetUniversalFragments()
		{
		/* --- GHIDRA: GetUniversalFragments ---
		void Gameplay_Fresco_Controller_FrescoController__GetUniversalFragments
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a575ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFrescoCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoGetUserFrescoesAns_TypeInfo);
		    DAT_ram_00a575ad = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Fresco_ProtoGetUserFrescoesAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Fresco_ProtoGetUserFrescoesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFrescoCommonErrors___
		                    );
		  if (iVar1 == 0) {
		    if (param1_00[4] == 0) {
		      uVar3 = unnamed_function_2232(&StringLiteral_9298);
		      uVar3 = func_ii_4419(uVar3,param1_00,0);
		      uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar4 = unnamed_function_1417(uVar4);
		      System_String__Concat(uVar4,uVar3,0);
		      uVar3 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_Fresco_Controller_FrescoController_GetUserFrescoesHandler__
		                        );
		      func_ii_1050(uVar4,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x10) = param1_00[4];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar3 = Gameplay_Fresco_Controller_FrescoController__ValidateData
		                      (param1,*(undefined4 *)(iVar2 + 0x10),param1);
		    *(undefined4 *)(iVar1 + 0x30) = uVar3;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    if (*(char *)((int)param1 + 9) == '\0') {
		      *(undefined1 *)((int)param1 + 9) = 1;
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar1 = *(int *)(iVar1 + 8);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600306F RID: 12399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306F")]
		[Address(RVA = "0x80D4", Offset = "0x80D4", VA = "0x80D4")]
		private void GetUserFrescoesHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetUserFrescoesHandler ---
		void Gameplay_Fresco_Controller_FrescoController__GetUserFrescoesHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  longlong *plVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int *param1_01;
		  longlong param2_00;
		  
		  if (DAT_ram_00a575ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFrescoCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoGetOtherUserFrescoesAns_TypeInfo);
		    DAT_ram_00a575ae = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Fresco_ProtoGetOtherUserFrescoesAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Fresco_ProtoGetOtherUserFrescoesAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFrescoCommonErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = param1_00[4];
		    if (iVar1 == 0) {
		      uVar3 = unnamed_function_2232(&StringLiteral_9298);
		      uVar3 = func_ii_4419(uVar3,param1_00,0);
		      uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar4 = unnamed_function_1417(uVar4);
		      System_String__Concat(uVar4,uVar3,0);
		      uVar3 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_Fresco_Controller_FrescoController_GetOtherUserFrescoesHandler__
		                        );
		      func_ii_1050(uVar4,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param2_00 = *(longlong *)(param1_00 + 6);
		    if (param2_00 == 0) {
		      param1_01 = *(int **)(param2 + 0xc);
		      if (param1_01 == (int *)0x0) {
		        System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (*(int *)(*param1_01 + 0x20) != *(int *)(DAT_ram_00a66968 + 0x20)) {
		        System_Activator__CreateInstance(param1_01,DAT_ram_00a66968);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      plVar2 = (longlong *)func_ii_15774(param1_01);
		      param2_00 = *plVar2;
		      iVar1 = param1_00[4];
		    }
		    uVar3 = Gameplay_Fresco_Controller_FrescoController__ValidateData(param1,iVar1,param1);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    if (DAT_ram_00a57592 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs___set_Item__
		                );
		      DAT_ram_00a57592 = '\x01';
		    }
		    Gameplay_WorldAxis_ClanEquipment_Model_ClanEquipmentModel_DollArtifacts___ctor
		              (*(undefined4 *)(iVar1 + 0x34),param2_00,uVar3,
		               Method_System_Collections_Generic_Dictionary_ulong__List_FrescoGroupListElementArgs___set_Item__
		              );
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003070 RID: 12400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003070")]
		[Address(RVA = "0x80D5", Offset = "0x80D5", VA = "0x80D5")]
		private void GetOtherUserFrescoesHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetOtherUserFrescoesHandler ---
		void Gameplay_Fresco_Controller_FrescoController__GetOtherUserFrescoesHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = Gameplay_Fresco_Controller_FrescoController__ValidateData
		                    (param1,*(undefined4 *)(iVar2 + 0x10),param1);
		  *(undefined4 *)(iVar1 + 0x30) = uVar3;
		  return;
		}
		*/

		}

		// Token: 0x06003071 RID: 12401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003071")]
		[Address(RVA = "0x80D6", Offset = "0x80D6", VA = "0x80D6")]
		private void ValidateData()
		{
		/* --- GHIDRA: ValidateData ---
		undefined4
		Gameplay_Fresco_Controller_FrescoController__ValidateData
		          (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int param2_00;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  undefined4 uVar5;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a575af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_GroupBy_Fresco_Types_FrescoDic__ulong___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_Fresco__Fresco_Types_FrescoDic___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_IGrouping_ulong__Fresco_Types_FrescoDic___FrescoGroupListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToList_FrescoGroupListElementArgs___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_Fresco_Types_FrescoDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_Fresco__Fresco_Types_FrescoDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Fresco_Types_FrescoDic__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Fresco_Types_FrescoDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_IGrouping_ulong__Fresco_Types_FrescoDic___FrescoGroupListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoController___c__GetData_b__21_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoController___c__GetData_b__21_2__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoController___c__DisplayClass21_0__GetData_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Fresco_Controller_FrescoController___c__DisplayClass21_0__GetData_b__3__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Fresco_Controller_FrescoController___c__DisplayClass21_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Controller_FrescoController___c_TypeInfo);
		    DAT_ram_00a575af = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Fresco_Controller_FrescoController___c__DisplayClass21_0_TypeInfo)
		  ;
		  *(undefined4 *)(param2_00 + 0x10) = param2;
		  *(int **)(param2_00 + 0xc) = param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(*(int *)(iVar2 + 0xc) + 8);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x80dae463;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80dae463:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  *(undefined4 *)(param2_00 + 8) = uVar4;
		  uVar5 = *(undefined4 *)(param2_00 + 0x10);
		  uVar4 = unnamed_function_1417(System_Func_Fresco__Fresco_Types_FrescoDic__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar4,param2_00,
		             Method_Gameplay_Fresco_Controller_FrescoController___c__DisplayClass21_0__GetData_b__0__
		             ,0);
		  uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar5,uVar4,
		                     Method_System_Linq_Enumerable_Select_Fresco__Fresco_Types_FrescoDic___);
		  if (*(int *)(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo + 0x5c);
		  iVar2 = puVar6[1];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar6;
		    iVar2 = unnamed_function_1417(System_Func_Fresco_Types_FrescoDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar2,uVar5,Method_Gameplay_Fresco_Controller_FrescoController___c__GetData_b__21_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo + 0x5c) + 4) = iVar2;
		  }
		  uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar4,iVar2,Method_System_Linq_Enumerable_Where_Fresco_Types_FrescoDic___);
		  if (*(int *)(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo + 0x5c);
		  iVar2 = puVar6[2];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar6;
		    iVar2 = unnamed_function_1417(System_Func_Fresco_Types_FrescoDic__ulong__TypeInfo);
		    func_ii_7542(iVar2,uVar5,
		                 Method_Gameplay_Fresco_Controller_FrescoController___c__GetData_b__21_2__,0);
		    *(int *)(*(int *)(Gameplay_Fresco_Controller_FrescoController___c_TypeInfo + 0x5c) + 8) = iVar2;
		  }
		  uVar4 = System_Linq_Enumerable__GroupBy_object__uint_
		                    (uVar4,iVar2,
		                     Method_System_Linq_Enumerable_GroupBy_Fresco_Types_FrescoDic__ulong___);
		  uVar5 = unnamed_function_1417
		                    (
		                    System_Func_IGrouping_ulong__Fresco_Types_FrescoDic___FrescoGroupListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar5,param2_00,
		             Method_Gameplay_Fresco_Controller_FrescoController___c__DisplayClass21_0__GetData_b__3__
		             ,0);
		  uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar4,uVar5,
		                     Method_System_Linq_Enumerable_Select_IGrouping_ulong__Fresco_Types_FrescoDic___FrescoGroupListElementArgs___
		                    );
		  uVar4 = System_Linq_Enumerable__Select_object__object_
		                    (uVar4,Method_System_Linq_Enumerable_ToList_FrescoGroupListElementArgs___);
		  return uVar4;
		}
		*/

		}

		// Token: 0x06003072 RID: 12402 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003072")]
		[Address(RVA = "0x80D7", Offset = "0x80D7", VA = "0x80D7")]
		private List<FrescoGroupListElementArgs> GetData(RepeatedField<Fresco> frescoes)
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_Fresco_Controller_FrescoController__GetData
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a575b0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFrescoCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoFillFrescoSlotsAns_TypeInfo);
		    DAT_ram_00a575b0 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Fresco_ProtoFillFrescoSlotsAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Fresco_ProtoFillFrescoSlotsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFrescoCommonErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Fresco_Controller_FrescoController__GetUniversalFragmentsCountHandler
		              (param1,param1_00[4],param1_00);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003073")]
		[Address(RVA = "0x80D8", Offset = "0x80D8", VA = "0x80D8")]
		private void FillFrescoSlotsHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: FillFrescoSlotsHandler ---
		void Gameplay_Fresco_Controller_FrescoController__FillFrescoSlotsHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a575b1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFrescoCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoCompleteFrescoAns_TypeInfo);
		    DAT_ram_00a575b1 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Fresco_ProtoCompleteFrescoAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Fresco_ProtoCompleteFrescoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFrescoCommonErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Fresco_Controller_FrescoController__GetUniversalFragmentsCountHandler
		              (param1,param1_00[4],param1_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003074 RID: 12404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003074")]
		[Address(RVA = "0x80D9", Offset = "0x80D9", VA = "0x80D9")]
		private void CompleteFrescoHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: CompleteFrescoHandler ---
		void Gameplay_Fresco_Controller_FrescoController__CompleteFrescoHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a575b2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFrescoCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoCollectFrescoRewardAns_TypeInfo);
		    DAT_ram_00a575b2 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Fresco_ProtoCollectFrescoRewardAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Fresco_ProtoCollectFrescoRewardAns_TypeInfo)
		    ;
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFrescoCommonErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Fresco_Controller_FrescoController__GetUniversalFragmentsCountHandler
		              (param1,param1_00[4],param1_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003075 RID: 12405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003075")]
		[Address(RVA = "0x80DA", Offset = "0x80DA", VA = "0x80DA")]
		private void CollectFrescoRewardHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: CollectFrescoRewardHandler ---
		void Gameplay_Fresco_Controller_FrescoController__CollectFrescoRewardHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a575b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFrescoCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoInstallUniversalFragmentsAns_TypeInfo);
		    DAT_ram_00a575b3 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Fresco_ProtoInstallUniversalFragmentsAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Fresco_ProtoInstallUniversalFragmentsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFrescoCommonErrors___
		                    );
		  if (iVar1 == 0) {
		    Gameplay_Fresco_Controller_FrescoController__GetUniversalFragmentsCountHandler
		              (param1,param1_00[4],param1);
		    iVar2 = param1_00[5];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x2c) = iVar2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x24);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),iVar2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003076 RID: 12406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003076")]
		[Address(RVA = "0x80DB", Offset = "0x80DB", VA = "0x80DB")]
		private void InstallUniversalFragmentsHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: InstallUniversalFragmentsHandler ---
		void Gameplay_Fresco_Controller_FrescoController__InstallUniversalFragmentsHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a575b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Fresco_ProtoGetUniversalFragmentsCountAns_TypeInfo);
		    DAT_ram_00a575b4 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Fresco_ProtoGetUniversalFragmentsCountAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Fresco_ProtoGetUniversalFragmentsCountAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = param1_00[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar1 + 0x2c) = iVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),iVar2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003077 RID: 12407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003077")]
		[Address(RVA = "0x80DC", Offset = "0x80DC", VA = "0x80DC")]
		private void GetUniversalFragmentsCountHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetUniversalFragmentsCountHandler ---
		void Gameplay_Fresco_Controller_FrescoController__GetUniversalFragmentsCountHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Fresco_Model_FrescoModel___ctor(uVar1,param2,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = Gameplay_Fresco_Controller_FrescoController__ValidateData
		                    (param1,*(undefined4 *)(iVar3 + 0x10),param1);
		  *(undefined4 *)(iVar2 + 0x30) = uVar1;
		  Gameplay_Fresco_Controller_FrescoController__UpdateFresco(param1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x14);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param2,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003078 RID: 12408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003078")]
		[Address(RVA = "0x80DD", Offset = "0x80DD", VA = "0x80DD")]
		private void UpdateFresco(Fresco fresco)
		{
		/* --- GHIDRA: UpdateFresco ---
		void Gameplay_Fresco_Controller_FrescoController__UpdateFresco(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a575b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_FrescoGroupListElementArgs___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Fresco_Controller_FrescoController__UpdateCurrentGroup_b__28_0__);
		    Mono_Security_ASN1__get_Item(&System_Func_FrescoGroupListElementArgs__bool__TypeInfo);
		    DAT_ram_00a575b5 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x14) != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_01 = *(undefined4 *)(iVar2 + 0x30);
		    param1_00 = unnamed_function_1417(System_Func_FrescoGroupListElementArgs__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,param1,
		               Method_Gameplay_Fresco_Controller_FrescoController__UpdateCurrentGroup_b__28_0__,0);
		    iVar2 = func_ii_7423(param1_01,param1_00,
		                         Method_System_Linq_Enumerable_First_FrescoGroupListElementArgs___);
		    *(undefined4 *)(iVar1 + 0x24) = *(undefined4 *)(iVar2 + 0x18);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003079 RID: 12409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003079")]
		[Address(RVA = "0x80DE", Offset = "0x80DE", VA = "0x80DE")]
		private void UpdateCurrentGroup()
		{
		/* --- GHIDRA: UpdateCurrentGroup ---
		void Gameplay_Fresco_Controller_FrescoController__UpdateCurrentGroup
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x2c) = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600307A RID: 12410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307A")]
		[Address(RVA = "0x80DF", Offset = "0x80DF", VA = "0x80DF")]
		private void UpdateBalance(uint count)
		{
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307B")]
		[Address(RVA = "0x80E0", Offset = "0x80E0", VA = "0x80E0")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_Fresco_Controller_FrescoController__ValidateInit
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Bank_Controller_BankController__RequestActivePromotions
		            (*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x14),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600307C RID: 12412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307C")]
		[Address(RVA = "0x80E1", Offset = "0x80E1", VA = "0x80E1")]
		public void Buy(BankOptionData option)
		{
		/* --- GHIDRA: Buy ---
		undefined4
		Gameplay_Fresco_Controller_FrescoController__Buy(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a575b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__ContainsKey__
		              );
		    DAT_ram_00a575b6 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param2 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = System_Collections_Generic_SortedDictionary_object__object___Clear
		                    (uVar2,*(undefined4 *)(iVar1 + 0x14),
		                     Method_System_Collections_Generic_SortedDictionary_Fresco__Fresco_Types_FrescoDic__ContainsKey__
		                    );
		  return uVar2;
		}
		*/

		}

		// Token: 0x04001A86 RID: 6790
		[Token(Token = "0x4001A86")]
		[FieldOffset(Offset = "0x18")]
		private readonly FrescoService _frescoService;

		// Token: 0x04001A87 RID: 6791
		[Token(Token = "0x4001A87")]
		[FieldOffset(Offset = "0x1C")]
		private readonly IBalanceSource _balanceSource;
	}
}
