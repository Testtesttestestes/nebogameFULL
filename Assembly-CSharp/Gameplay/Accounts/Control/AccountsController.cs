using System;
using System.Threading;
using Gameplay.Accounts.Model;
using Gameplay.Accounts.Model.Data;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using ServicesNamespace;
using Utils;

namespace Gameplay.Accounts.Control
{
	// Token: 0x02000DE5 RID: 3557
	[Token(Token = "0x2000DE5")]
	public class AccountsController : AbstractController<AccountsModel, AccountsEvents>
	{
		// Token: 0x060056D5 RID: 22229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D5")]
		[Address(RVA = "0xA454", Offset = "0xA454", VA = "0xA454", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: <StartBuyAccount>b__16_0 ---
		void Gameplay_Accounts_Control_AccountsController___StartBuyAccount_b__16_0(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a588e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Control_AccountsController___c_TypeInfo);
		    DAT_ram_00a588e0 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Accounts_Control_AccountsController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Accounts_Control_AccountsController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_Accounts_Control_AccountsController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a588d5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_AccountsModel__AccountsEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    DAT_ram_00a588d5 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param3,param4,
		             Method_MVC_AbstractController_AccountsModel__AccountsEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  param1_00 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		  Gameplay_Combat_Control_Conveyor__Next(param1_00,0);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D6")]
		[Address(RVA = "0xA455", Offset = "0xA455", VA = "0xA455")]
		public AccountsController(ServicesService servicesService, AccountsModel model, AccountsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Accounts_Control_AccountsController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  uint *puVar4;
		  int *param1_01;
		  
		  if (DAT_ram_00a588d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsController_HandleAccountChangedEventService__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Control_AccountsController_HandleDictsChangedEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_AccountInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a588d6 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  param1_00 = unnamed_function_1417(System_Action_AccountInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Accounts_Control_AccountsController_HandleAccountChangedEventService__,
		             0);
		  ServicesNamespace_ServicesService__remove_AuchanBacklightChangedEvent(uVar2,param1_00,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar3 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Accounts_Control_AccountsController_HandleDictsChangedEvent__,0);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x80f3fcb3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,1);
		code_r0x80f3fcb3:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar2,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D7")]
		[Address(RVA = "0xA456", Offset = "0xA456", VA = "0xA456", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Accounts_Control_AccountsController__HandleRun(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  uint *puVar4;
		  int *param1_01;
		  
		  if (DAT_ram_00a588d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsController_HandleAccountChangedEventService__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Control_AccountsController_HandleDictsChangedEvent__);
		    Mono_Security_ASN1__get_Item(&System_Action_AccountInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a588d7 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  param1_00 = unnamed_function_1417(System_Action_AccountInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Accounts_Control_AccountsController_HandleAccountChangedEventService__,
		             0);
		  ServicesNamespace_ServicesService__add_AccountChangedEvent(uVar2,param1_00,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar3 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Accounts_Control_AccountsController_HandleDictsChangedEvent__,0);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f3fe09;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,0);
		code_r0x80f3fe09:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,uVar2,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D8")]
		[Address(RVA = "0xA457", Offset = "0xA457", VA = "0xA457", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Accounts_Control_AccountsController__HandleStop(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a588d8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AccountsController__HandleDictsChangedEvent_d__6___
		              );
		    DAT_ram_00a588d8 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_AccountLinkerController___HandleOtpTokenGen_b__22_0_d_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_AccountsController__HandleDictsChangedEvent_d__6___
		            );
		  return;
		}
		*/

		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D9")]
		[Address(RVA = "0xA458", Offset = "0xA458", VA = "0xA458")]
		private void HandleDictsChangedEvent()
		{
		/* --- GHIDRA: HandleDictsChangedEvent ---
		void Gameplay_Accounts_Control_AccountsController__HandleDictsChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a588d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_AccountInfo___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsController___c__DisplayClass7_0__HandleAccountChangedEventService_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Accounts_Control_AccountsController___c__DisplayClass7_0_TypeInfo);
		    DAT_ram_00a588d9 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Accounts_Control_AccountsController___c__DisplayClass7_0_TypeInfo)
		  ;
		  *(int **)(param2_00 + 8) = param1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = func_ii_7504(*(undefined4 *)(iVar1 + 8),0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid(Protocol_Common_AccountInfo___TypeInfo,1);
		  *(int *)(iVar1 + 0x10) = param2;
		  Core_Data_Accounts_AccountsStorage__Reset(uVar2,iVar1,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = func_ii_7485(uVar2,*(undefined4 *)(param2 + 0x10),(undefined4 *)(param2_00 + 0xc),param1);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(iVar1 + 0x1c) == 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar1 = *(int *)(iVar1 + 0x14);
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2_00 + 0xc),
		                   *(undefined4 *)(iVar1 + 0x14));
		        return;
		      }
		    }
		    else {
		      uVar2 = Gameplay_Accounts_Control_AccountsController__UpdatePromotion(param1,param1);
		      param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (param1_00,param2_00,
		                 Method_Gameplay_Accounts_Control_AccountsController___c__DisplayClass7_0__HandleAccountChangedEventService_b__0__
		                 ,0);
		      ServicesNamespace_MainService__GetUserStats
		                (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060056DA RID: 22234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DA")]
		[Address(RVA = "0xA459", Offset = "0xA459", VA = "0xA459")]
		private void HandleAccountChangedEventService(AccountInfo info)
		{
		/* --- GHIDRA: HandleAccountChangedEventService ---
		/* WARNING: Removing unreachable block (ram,0x80f41db1) */
		
		void Gameplay_Accounts_Control_AccountsController__HandleAccountChangedEventService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined4 *puVar7;
		  int *piVar8;
		  int *piVar9;
		  int *piVar10;
		  int local_48;
		  undefined8 *local_44;
		  int local_40;
		  undefined8 *puStack_3c;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_4;
		  
		  if (DAT_ram_00a588db == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_AccountOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountOptionsDic__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountOptionsDic__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountOptionsDic__get_Current__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AccountOptionData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AccountOptionData__Clear__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountOptionsDic__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AccountOptionData__Sort__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetAccountOptionsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__Contains__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsController___c__HandleGetAccountOptionService_b__9_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Control_AccountsController___c_TypeInfo);
		    DAT_ram_00a588db = '\x01';
		  }
		  local_10 = 0;
		  local_18 = 0;
		  local_1c = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  piVar8 = *(int **)(param2 + 0x20);
		  if ((piVar8 != (int *)0x0) && (Protocol_Services_ProtoGetAccountOptionsAns_TypeInfo != *piVar8)) {
		    System_Activator__CreateInstance(piVar8,Protocol_Services_ProtoGetAccountOptionsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_IAccountDataDecorator__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_IAccountDataDecorator___ctor__);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  func_ii_6335(uVar2,*(undefined4 *)(iVar3 + 0x18),
		               Method_System_Collections_Generic_List_IAccountDataDecorator__AddRange__);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_40,*(undefined4 *)(iVar3 + 0x18),
		             Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		  local_10 = local_38;
		  local_18 = CONCAT44(puStack_3c,local_40);
		  local_40 = 0;
		  puStack_3c = &local_18;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                         Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__
		                        );
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f41529;
		      }
		      if (iVar4 == 0) goto code_r0x80f4157f;
		      piVar6 = local_10._4_4_;
		      iVar3 = *local_10._4_4_;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar9) {
		            puVar7 = (undefined4 *)(piVar9[1] * 8 + iVar3 + 0x100);
		            goto code_r0x80f41474;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar7 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10._4_4_,
		                          Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,8);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f41521:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f41529;
		      }
		code_r0x80f41474:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiii(*puVar7,piVar6,&local_1c,puVar7[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f41521;
		    } while (iVar3 == 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf8,uVar2,local_1c,
		               Method_System_Collections_Generic_List_IAccountDataDecorator__AddRange__);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f41529:
		  iVar3 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar4 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_40 = iVar4;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		      if (iVar4 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f4157f:
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_40,uVar2,
		                 Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		      local_10 = local_38;
		      local_18 = CONCAT44(puStack_3c,local_40);
		      local_48 = 0;
		      local_44 = &local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                           Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__
		                          );
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar3 = global_1;
		          goto code_r0x80f420a3;
		        }
		        iVar3 = local_48;
		        if (iVar4 == 0) goto code_r0x80f42176;
		        piVar6 = local_10._4_4_;
		        iVar3 = *local_10._4_4_;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		            if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar9) {
		              puVar7 = (undefined4 *)(piVar9[1] * 8 + iVar3 + 0xe0);
		              goto code_r0x80f416b7;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10._4_4_,
		                            Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,4);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f419da:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar3 = global_1;
		          goto code_r0x80f420a3;
		        }
		code_r0x80f416b7:
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii(*puVar7,piVar6,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f419da;
		        iVar4 = *(int *)(iVar3 + 0xc);
		        *(undefined4 *)(iVar3 + 0xc) = 0;
		        *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		        if (0 < iVar4) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1bc,
		                     *(undefined4 *)(iVar3 + 8),0,iVar4,0);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80f419da;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104))
		        ;
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar3 = global_1;
		          goto code_r0x80f420a3;
		        }
		        piVar9 = *(int **)(iVar4 + 0x20);
		        iVar3 = *piVar9;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar10) {
		              puVar7 = (undefined4 *)(piVar10[1] * 8 + iVar3 + 0xd0);
		              goto code_r0x80f4182d;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar9,
		                            Core_Dict_IDictProvider_TypeInfo,2);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f419ee:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar3 = global_1;
		          goto code_r0x80f420a3;
		        }
		code_r0x80f4182d:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii(*puVar7,piVar9,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f419ee;
		        iVar3 = *piVar6;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		            if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar9) {
		              puVar7 = (undefined4 *)(piVar9[1] * 8 + iVar3 + 200);
		              goto code_r0x80f418fe;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                            Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f419f8:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar3 = global_1;
		          goto code_r0x80f420a3;
		        }
		code_r0x80f418fe:
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii(*puVar7,piVar6,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f419f8;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_iiiii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1bc,uVar2,
		                   *(undefined4 *)(iVar3 + 0xc),&local_20,0);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar3 = global_1;
		          goto code_r0x80f420a3;
		        }
		        DAT_ram_009d3e38 = 0;
		        System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                  (&local_40,local_20,
		                   Method_System_Collections_Generic_List_AccountOptionsDic__GetEnumerator__);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar3 = global_1;
		          goto code_r0x80f420a3;
		        }
		        local_28 = local_38;
		        local_30 = CONCAT44(puStack_3c,local_40);
		        local_40 = 0;
		        puStack_3c = &local_30;
		code_r0x80f41a1c:
		        do {
		          do {
		            do {
		              do {
		                DAT_ram_009d3e38 = 0;
		                iVar3 = import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_30,
		                                   Method_System_Collections_Generic_List_Enumerator_AccountOptionsDic__MoveNext__
		                                  );
		                if (DAT_ram_009d3e38 == 1) goto code_r0x80f41d29;
		                if (iVar3 == 0) {
		                  iVar4 = 9;
		                  goto code_r0x80f41d7f;
		                }
		                iVar3 = local_28._4_4_;
		                DAT_ram_009d3e38 = 0;
		                iVar4 = import::env::invoke_iiii
		                                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1bd,piVar8[3]
		                                   ,*(undefined4 *)(*(int *)(local_28._4_4_ + 0xc) + 0xc),
		                                   Method_Google_Protobuf_Collections_RepeatedField_uint__Contains__
		                                  );
		                if (DAT_ram_009d3e38 == 1) goto code_r0x80f41d29;
		              } while (iVar4 == 0);
		              DAT_ram_009d3e38 = 0;
		              iVar4 = import::env::invoke_iii
		                                (*(undefined4 *)(*param1 + 0x100),param1,
		                                 *(undefined4 *)(*param1 + 0x104));
		              if (DAT_ram_009d3e38 == 1) goto code_r0x80f41d29;
		              uVar2 = *(undefined4 *)(*(int *)(iVar3 + 0xc) + 0xc);
		              if (DAT_ram_00a588b1 == '\0') {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (0x7ff,&Gameplay_Accounts_Model_Data_AccountOptionData_TypeInfo);
		                if (DAT_ram_009d3e38 == 1) goto code_r0x80f41d29;
		                DAT_ram_00a588b1 = '\x01';
		              }
		              local_4 = (int *)0x0;
		              DAT_ram_009d3e38 = 0;
		              iVar3 = import::env::invoke_iiiii
		                                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x314,
		                                 *(undefined4 *)(*(int *)(iVar4 + 0xc) + 0x2c),uVar2,&local_4,0);
		              piVar9 = local_4;
		              if (DAT_ram_009d3e38 == 1) goto code_r0x80f41d29;
		            } while ((iVar3 == 0) || (local_4 == (int *)0x0));
		          } while (((uint)*(byte *)(*local_4 + 0xb8) <
		                    (uint)*(byte *)(Gameplay_Accounts_Model_Data_AccountOptionData_TypeInfo + 0xb8))
		                  || (*(int *)(*(int *)(*local_4 + 100) +
		                               (uint)*(byte *)(
		                                              Gameplay_Accounts_Model_Data_AccountOptionData_TypeInfo
		                                              + 0xb8) * 4 + -4) !=
		                      Gameplay_Accounts_Model_Data_AccountOptionData_TypeInfo));
		          iVar3 = *piVar6;
		          if (*(ushort *)(iVar3 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		              if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar10) {
		                puVar7 = (undefined4 *)(piVar10[1] * 8 + iVar3 + 0xe0);
		                goto code_r0x80f41c5f;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar7 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                              Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,4);
		          if (DAT_ram_009d3e38 == 1) break;
		code_r0x80f41c5f:
		          DAT_ram_009d3e38 = 0;
		          iVar4 = import::env::invoke_iii(*puVar7,piVar6,puVar7[1]);
		          iVar3 = Method_System_Collections_Generic_List_AccountOptionData__Add__;
		          if (DAT_ram_009d3e38 == 1) break;
		          *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		          uVar1 = *(uint *)(iVar4 + 0xc);
		          if (uVar1 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		            *(uint *)(iVar4 + 0xc) = uVar1 + 1;
		            *(int **)(*(int *)(iVar4 + 8) + uVar1 * 4 + 0x10) = piVar9;
		            goto code_r0x80f41a1c;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,piVar9,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		        } while (DAT_ram_009d3e38 != 1);
		code_r0x80f41d29:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar3 = global_1;
		        iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar3 != iVar4) {
		code_r0x80f4204d:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1bf,&local_40);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) goto code_r0x80f42164;
		          goto code_r0x80f420a3;
		        }
		        piVar9 = (int *)import::env::__cxa_begin_catch(uVar5);
		        local_40 = *piVar9;
		        iVar4 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar3 = global_1;
		          goto code_r0x80f4204d;
		        }
		code_r0x80f41d7f:
		        if (local_40 != 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_40);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar3 = global_1;
		          goto code_r0x80f420a3;
		        }
		        if ((iVar4 != 0) &&
		           ((((((iVar3 = local_48, iVar4 == 1 || (iVar4 == 2)) || (iVar4 == 3)) ||
		              ((iVar4 == 4 || (iVar4 == 5)))) || ((iVar4 == 6 || ((iVar4 == 7 || (iVar4 == 8))))))
		            || (iVar4 != 9)))) goto code_r0x80f42176;
		        iVar3 = *piVar6;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		            if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar9) {
		              puVar7 = (undefined4 *)(piVar9[1] * 8 + iVar3 + 0xe0);
		              goto code_r0x80f41e90;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                            Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,4);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f42080:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar3 = global_1;
		          goto code_r0x80f420a3;
		        }
		code_r0x80f41e90:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii(*puVar7,piVar6,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f42080;
		        if (*(int *)(Gameplay_Accounts_Control_AccountsController___c_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Gameplay_Accounts_Control_AccountsController___c_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80f42080;
		        }
		        puVar7 = *(undefined4 **)(Gameplay_Accounts_Control_AccountsController___c_TypeInfo + 0x5c);
		        iVar3 = puVar7[1];
		        if (iVar3 == 0) {
		          if (*(int *)(Gameplay_Accounts_Control_AccountsController___c_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       Gameplay_Accounts_Control_AccountsController___c_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) break;
		            puVar7 = *(undefined4 **)
		                      (Gameplay_Accounts_Control_AccountsController___c_TypeInfo + 0x5c);
		          }
		          uVar5 = *puVar7;
		          DAT_ram_009d3e38 = 0;
		          iVar3 = import::env::invoke_ii
		                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                             System_Comparison_AccountOptionData__TypeInfo);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0x160,iVar3,uVar5,
		                       Method_Gameplay_Accounts_Control_AccountsController___c__HandleGetAccountOptionService_b__9_0__
		                       ,0);
		            if (DAT_ram_009d3e38 != 1) {
		              *(int *)(*(int *)(Gameplay_Accounts_Control_AccountsController___c_TypeInfo + 0x5c) +
		                      4) = iVar3;
		              goto code_r0x80f41fe9;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar3 = global_1;
		          goto code_r0x80f420a3;
		        }
		code_r0x80f41fe9:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1be,uVar2,iVar3,
		                   Method_System_Collections_Generic_List_AccountOptionData__Sort__);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar3 = global_1;
		code_r0x80f420a3:
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar3) {
		        piVar8 = (int *)import::env::__cxa_begin_catch(uVar5);
		        iVar3 = *piVar8;
		        DAT_ram_009d3e38 = 0;
		        local_48 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x80f42176:
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 == 0) {
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar5 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1c0,&local_48);
		      goto joined_r0x80f4211c;
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1c1,&local_40);
		joined_r0x80f4211c:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80f42164:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060056DB RID: 22235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DB")]
		[Address(RVA = "0x1D4C", Offset = "0x1D4C", VA = "0x1D4C")]
		private void TryDetectAccountsOptionsDiff()
		{
		}

		// Token: 0x060056DC RID: 22236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DC")]
		[Address(RVA = "0xA45A", Offset = "0xA45A", VA = "0xA45A")]
		private void HandleGetAccountOptionService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetAccountOptionService ---
		void Gameplay_Accounts_Control_AccountsController__HandleGetAccountOptionService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  int iVar4;
		  uint *puVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int param1_00;
		  int *piVar9;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a588dc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PromotionsDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PromotionsDic___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_PromotionsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetActivePromotionsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    DAT_ram_00a588dc = '\x01';
		  }
		  piVar6 = *(int **)(param2 + 0x20);
		  if ((piVar6 != (int *)0x0) && (Protocol_Services_ProtoGetActivePromotionsAns_TypeInfo != *piVar6))
		  {
		    System_Activator__CreateInstance(piVar6,Protocol_Services_ProtoGetActivePromotionsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar7 = *(undefined4 *)(piVar6[3] + 0xc);
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_PromotionsDic__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (iVar2,uVar7,Method_System_Collections_Generic_List_PromotionsDic___ctor__);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (piVar6[3],
		                              Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80f422be:
		  do {
		    piVar6 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80f42352;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f42670:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f42678;
		    }
		code_r0x80f42352:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f42670;
		    if (iVar8 == 0) goto code_r0x80f426c1;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80f4242f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f42648:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f42678;
		    }
		code_r0x80f4242f:
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f42648;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f42678;
		    }
		    piVar6 = *(int **)(iVar4 + 0x20);
		    iVar8 = *piVar6;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(piVar9[1] * 8 + iVar8 + 0xd0);
		          goto code_r0x80f42549;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                        Core_Dict_IDictProvider_TypeInfo,2);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f4265c:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f42678;
		    }
		code_r0x80f42549:
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f4265c;
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1c2,param2_00,uVar7,0);
		    iVar8 = Method_System_Collections_Generic_List_PromotionsDic__Add__;
		    if (DAT_ram_009d3e38 == 1) break;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = uVar7;
		      goto code_r0x80f422be;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,uVar7,
		               *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f42678:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar7);
		    local_c = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80f426c1:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = *local_8;
		      if (piVar6 != (int *)0x0) {
		        uVar1 = 0;
		        iVar8 = *piVar6;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80f4273c;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x80f4273c:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar6,puVar5[1]);
		      }
		      if (local_c == 0) {
		        iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        if (DAT_ram_00a588af == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_PromotionsDic__AddRange__);
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_PromotionsDic__Clear__);
		          DAT_ram_00a588af = '\x01';
		        }
		        param1_00 = *(int *)(iVar8 + 0x10);
		        iVar4 = *(int *)(param1_00 + 0xc);
		        *(undefined4 *)(param1_00 + 0xc) = 0;
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        if (0 < iVar4) {
		          func_ii_2064(*(undefined4 *)(param1_00 + 8),0,iVar4,0);
		          param1_00 = *(int *)(iVar8 + 0x10);
		        }
		        func_ii_6335(param1_00,iVar2,
		                     Method_System_Collections_Generic_List_PromotionsDic__AddRange__);
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x114));
		        iVar2 = *(int *)(iVar2 + 0x1c);
		        if (iVar2 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar7 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1c3,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar7);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060056DD RID: 22237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DD")]
		[Address(RVA = "0xA45B", Offset = "0xA45B", VA = "0xA45B")]
		private void HandleGetActivePromotionsService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetActivePromotionsService ---
		void Gameplay_Accounts_Control_AccountsController__HandleGetActivePromotionsService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x38) != param2) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x38) = param2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar2 + 0x38),
		                 *(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060056DE RID: 22238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DE")]
		[Address(RVA = "0xA45C", Offset = "0xA45C", VA = "0xA45C")]
		public void SetNotificationsCount(int value)
		{
		/* --- GHIDRA: SetNotificationsCount ---
		void Gameplay_Accounts_Control_AccountsController__SetNotificationsCount
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a588dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Accounts_Control_AccountsController_HandleGetActivePromotionsService__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a588dd = '\x01';
		  }
		  param1_00 = ServicesNamespace_ServicesService__GetOptionArtikuls(*(undefined4 *)(param1 + 0x18),0)
		  ;
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Accounts_Control_AccountsController_HandleGetActivePromotionsService__,
		             0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060056DF RID: 22239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056DF")]
		[Address(RVA = "0xA45D", Offset = "0xA45D", VA = "0xA45D")]
		public void UpdatePromotion()
		{
		/* --- GHIDRA: UpdatePromotion ---
		undefined4
		Gameplay_Accounts_Control_AccountsController__UpdatePromotion(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a588de == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Control_AccountsController_HandleGetAccountOptionService__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a588de = '\x01';
		  }
		  uVar1 = ServicesNamespace_ServicesService__ReforgeUserItem(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Accounts_Control_AccountsController_HandleGetAccountOptionService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056E0")]
		[Address(RVA = "0xA45E", Offset = "0xA45E", VA = "0xA45E")]
		public OpToken<IMessage, object> RequestAvailOptions()
		{
		/* --- GHIDRA: RequestAvailOptions ---
		void Gameplay_Accounts_Control_AccountsController__RequestAvailOptions
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x1c) = param2;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060056E1 RID: 22241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056E1")]
		[Address(RVA = "0xA45F", Offset = "0xA45F", VA = "0xA45F")]
		public void SetCurrentBrowsedAccount(IAccountDataDecorator account)
		{
		/* --- GHIDRA: SetCurrentBrowsedAccount ---
		void Gameplay_Accounts_Control_AccountsController__SetCurrentBrowsedAccount
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Bank_Controller_BankController__RequestActivePromotions
		            (*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x24),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060056E2 RID: 22242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056E2")]
		[Address(RVA = "0xA460", Offset = "0xA460", VA = "0xA460")]
		public void BuyAccount(AccountOptionData option)
		{
		/* --- GHIDRA: BuyAccount ---
		void Gameplay_Accounts_Control_AccountsController__BuyAccount
		               (int *param1,int *param2,int param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000004;
		  uint *puVar1;
		  float fVar2;
		  float fVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  float fVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int param1_01;
		  int iVar9;
		  uint uVar10;
		  undefined8 uVar11;
		  int iVar12;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a588df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Control_AccountsController__StartBuyAccount_b__16_0__);
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__AccountOptionData__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__AccountOptionData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__AccountOptionData__TypeInfo
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
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
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
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27717);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22759);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2481);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19678);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2482);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3708);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2483);
		    DAT_ram_00a588df = '\x01';
		  }
		  local_8 = 0;
		  iVar12 = *param2;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar12 + 0x58) + uVar10 * 8)
		         ) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar10 * 8 + 4) * 8 + iVar12 + 0xd0);
		        goto code_r0x80f3f4ce;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar10);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3f4ce:
		  iVar12 = (**(code **)((ulonglong)*puVar1 * 4))(CONCAT44(in_register_20000004,param2),puVar1[1]);
		  if (iVar12 == 0) {
		    uVar11 = *(undefined8 *)(*(int *)(*(int *)(param3 + 0x70) + 0x10) + 0x10);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar2 = Utils_StringUtils___cctor(uVar11,0);
		    uVar7 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    iVar12 = *param2;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar12 + 0x58) + uVar10 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar10 * 8 + 4) * 8 + iVar12 + 200);
		          goto code_r0x80f3f5a1;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar10);
		    }
		    puVar1 = (uint *)func_ii_1080(param2,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo
		                                  ,1);
		code_r0x80f3f5a1:
		    iVar12 = (**(code **)((ulonglong)*puVar1 * 4))(CONCAT44(uVar7,param2),puVar1[1]);
		    uVar11 = *(undefined8 *)(iVar12 + 0x18);
		    fVar3 = Utils_StringUtils___cctor(uVar11,0);
		    uVar7 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = func_ii_7508(StringLiteral_2483,1,0,1,0,0,0,0);
		    iVar12 = *param2;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar12 + 0x58) + uVar10 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar10 * 8 + 4) * 8 + iVar12 + 0xd0);
		          goto code_r0x80f3f65b;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar10);
		    }
		    puVar1 = (uint *)func_ii_1080(param2,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo
		                                  ,2);
		code_r0x80f3f65b:
		    uVar11 = CONCAT44(uVar7,param2);
		    iVar12 = (**(code **)((ulonglong)*puVar1 * 4))(uVar11,puVar1[1]);
		    uVar7 = (undefined4)((ulonglong)uVar11 >> 0x20);
		    if (iVar12 == 0) {
		      fVar5 = 0.0;
		    }
		    else {
		      uVar10 = 0;
		      iVar12 = *param2;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		              *(int *)(*(int *)(iVar12 + 0x58) + uVar10 * 8)) {
		            puVar1 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar10 * 8 + 4) * 8 + iVar12 + 0xd0
		                             );
		            goto code_r0x80f3f6d9;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar10);
		      }
		      puVar1 = (uint *)func_ii_1080(param2,
		                                    Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,2);
		code_r0x80f3f6d9:
		      uVar11 = CONCAT44(uVar7,param2);
		      param1_00 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(uVar11,puVar1[1]);
		      uVar7 = (undefined4)((ulonglong)uVar11 >> 0x20);
		      uVar10 = 0;
		      iVar12 = *param1_00;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        do {
		          if (Core_Data_Accounts_IAccountData_TypeInfo ==
		              *(int *)(*(int *)(iVar12 + 0x58) + uVar10 * 8)) {
		            puVar1 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar10 * 8 + 4) * 8 + iVar12 + 200)
		            ;
		            goto code_r0x80f3f757;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar10);
		      }
		      puVar1 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,1);
		code_r0x80f3f757:
		      uVar11 = CONCAT44(uVar7,param1_00);
		      uVar6 = (**(code **)((ulonglong)*puVar1 * 4))(uVar11,puVar1[1]);
		      uVar7 = (undefined4)((ulonglong)uVar11 >> 0x20);
		      fVar5 = func_ii_7103(uVar6,0);
		    }
		    if (fVar3 < fVar2 + fVar5) {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      fVar2 = fVar3 - fVar5;
		      uVar6 = func_ii_7508(StringLiteral_2482,1,0,1,0,0,0,0);
		    }
		    else {
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar6 = func_ii_7508(StringLiteral_2481,1,0,1,0,0,0,0);
		      fVar3 = fVar2 + fVar5;
		    }
		    uVar10 = 0;
		    iVar12 = *param2;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar12 + 0x58) + uVar10 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar12 + 0x58) + uVar10 * 8 + 4) * 8 + iVar12 + 200);
		          goto code_r0x80f3f85c;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar10);
		    }
		    puVar1 = (uint *)func_ii_1080(param2,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo
		                                  ,1);
		code_r0x80f3f85c:
		    uVar7 = (**(code **)((ulonglong)*puVar1 * 4))(CONCAT44(uVar7,param2),puVar1[1]);
		    uVar7 = Core_GameLocalization__GetValue(uVar7,0);
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_8,StringLiteral_19678,uVar7,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    iVar12 = Mono_Security_ASN1Convert__ToOid
		                       (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    *(undefined8 *)(iVar12 + 0x10) = local_8;
		    uVar7 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar4,iVar12,0);
		    iVar12 = Mono_Security_ASN1Convert__ToOid
		                       (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,3);
		    *(undefined8 *)(iVar12 + 0x10) = local_8;
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    iVar8 = Utils_TimeUtils__DateFormat((double)fVar2,0);
		    local_10 = 0;
		    if (iVar8 == 0) {
		      iVar8 = StringLiteral_5;
		    }
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_22759,iVar8,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar12 + 0x18) = local_10;
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    iVar8 = Utils_TimeUtils__DateFormat((double)fVar3,0);
		    local_10 = 0;
		    if (iVar8 == 0) {
		      iVar8 = StringLiteral_5;
		    }
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_27717,iVar8,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar12 + 0x20) = local_10;
		    uVar4 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar6,iVar12,0);
		    iVar12 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    func_ii_8625(iVar12,0);
		    *(undefined4 *)(iVar12 + 0x1c) = uVar4;
		    *(undefined4 *)(iVar12 + 0x18) = uVar7;
		    iVar8 = unnamed_function_1417
		                      (
		                      System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                      );
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (iVar8,
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    param1_01 = unnamed_function_1417
		                          (
		                          UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                          );
		    UI_Windows_DialogWindow_DialogWindowArgs___ctor
		              (param1_01,
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar7 = func_ii_7508(StringLiteral_3708,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1_01 + 8) = uVar7;
		    iVar9 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__AccountOptionData__TypeInfo
		                      );
		    *(int *)(iVar9 + 0xc) = param3;
		    uVar7 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__AccountOptionData__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		              (uVar7,param1,
		               Method_Gameplay_Accounts_Control_AccountsController__StartBuyAccount_b__16_0__,0);
		    *(undefined4 *)(iVar9 + 0x10) = uVar7;
		    *(int *)(param1_01 + 0x14) = iVar9;
		    iVar9 = 
		    Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		    ;
		    *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		    uVar10 = *(uint *)(iVar8 + 0xc);
		    if (uVar10 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		      *(uint *)(iVar8 + 0xc) = uVar10 + 1;
		      *(int *)(*(int *)(iVar8 + 8) + uVar10 * 4 + 0x10) = param1_01;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar8,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		    }
		    *(int *)(iVar12 + 0x24) = iVar8;
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		              (iVar12,0);
		  }
		  else {
		    iVar12 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Bank_Controller_BankController__RequestActivePromotions
		              (*(undefined4 *)(*(int *)(iVar12 + 0xc) + 0x24),param3,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060056E3 RID: 22243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056E3")]
		[Address(RVA = "0xA461", Offset = "0xA461", VA = "0xA461")]
		public void StartBuyAccount(IAccountDataDecorator account, AccountOptionData option)
		{
		/* --- GHIDRA: StartBuyAccount ---
		void Gameplay_Accounts_Control_AccountsController__StartBuyAccount
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Bank_Controller_BankController__RequestActivePromotions
		            (*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x24),param3,0);
		  return;
		}
		*/

		}

		// Token: 0x04002F00 RID: 12032
		[Token(Token = "0x4002F00")]
		[FieldOffset(Offset = "0x18")]
		private ServicesService _service;

		// Token: 0x04002F01 RID: 12033
		[Token(Token = "0x4002F01")]
		[FieldOffset(Offset = "0x1C")]
		private readonly CancellationTokenSource _operationsCancelation;
	}
}
