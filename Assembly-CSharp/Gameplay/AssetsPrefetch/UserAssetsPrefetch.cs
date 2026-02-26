using System;
using System.Collections.Generic;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;

namespace Gameplay.AssetsPrefetch
{
	// Token: 0x02000CC5 RID: 3269
	[Token(Token = "0x2000CC5")]
	public class UserAssetsPrefetch : IDisposable
	{
		// Token: 0x06004F99 RID: 20377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F99")]
		[Address(RVA = "0x9DB4", Offset = "0x9DB4", VA = "0x9DB4")]
		public UserAssetsPrefetch()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AssetsPrefetch_UserAssetsPrefetch___ctor(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a589d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_UserAssetsPrefetch_UserOnOnUserAprChangedEvent__);
		    DAT_ram_00a589d4 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80f59dcd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f59dcd:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  param1_00 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_AssetsPrefetch_UserAssetsPrefetch_UserOnOnUserAprChangedEvent__,0);
		  Core_Data_UserData__remove_OnUserLevelChangedEvent(uVar3,param1_00,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80f59ea6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f59ea6:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = func_ii_7112(uVar3,0);
		  Gameplay_AssetsPrefetch_UserAssetsPrefetch__Init(param1,*(undefined4 *)(iVar5 + 0x38),puVar2);
		  return;
		}
		*/

		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9A")]
		[Address(RVA = "0x9DB5", Offset = "0x9DB5", VA = "0x9DB5")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_AssetsPrefetch_UserAssetsPrefetch__Init(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint uVar5;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a589d5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_string__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_string__TypeInfo);
		    DAT_ram_00a589d5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_string__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_string___ctor__);
		  if (param2 != 0) {
		    uVar3 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId(*(undefined4 *)(param2 + 0x10),0);
		    iVar1 = Method_System_Collections_Generic_List_string__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar5 = *(uint *)(param1_00 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar3;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    uVar3 = Core_Extensions_Dict_AprDicExt__Get128AssetId(*(undefined4 *)(param2 + 0x10),0);
		    iVar1 = Method_System_Collections_Generic_List_string__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar5 = *(uint *)(param1_00 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar3;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    uVar3 = UI_Wiki_WikiUriRouter__SetData(*(undefined4 *)(param2 + 0x10),0);
		    iVar1 = Method_System_Collections_Generic_List_string__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar5 = *(uint *)(param1_00 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar3;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    uVar3 = Core_Extensions_Dict_AprDicExt__Get256AssetId(*(undefined4 *)(param2 + 0x10),0);
		    iVar1 = Method_System_Collections_Generic_List_string__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar5 = *(uint *)(param1_00 + 0xc);
		    if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar5 * 4 + 0x10) = uVar3;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,param1_00,Method_System_Collections_Generic_List_string__GetEnumerator__);
		  local_8 = local_18;
		  local_10 = CONCAT44(puStack_1c,local_20);
		  local_20 = 0;
		  puStack_1c = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_string__MoveNext__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f5a1c4;
		    }
		    if (iVar2 == 0) goto code_r0x80f5a21a;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1fd,&local_20,local_8._4_4_,
		               &local_20);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f5a1c4:
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80f5a21a:
		      DAT_ram_009d3e38 = 0;
		      if (*(int *)(param1 + 8) == 0) {
		code_r0x80f5a3cb:
		        DAT_ram_009d3e38 = 0;
		        *(int *)(param1 + 8) = param1_00;
		        return;
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_20,*(int *)(param1 + 8),
		                 Method_System_Collections_Generic_List_string__GetEnumerator__);
		      local_8 = local_18;
		      local_10 = CONCAT44(puStack_1c,local_20);
		      local_20 = 0;
		      puStack_1c = &local_10;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_string__MoveNext__);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f5a32a;
		        }
		        if (iVar2 == 0) goto code_r0x80f5a3cb;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1ff,&local_20,local_8._4_4_,
		                   &local_20);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar1 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f5a32a:
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          goto code_r0x80f5a3cb;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x200,&local_20);
		      goto joined_r0x80f5a3b7;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1fe,&local_20);
		joined_r0x80f5a3b7:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9B")]
		[Address(RVA = "0x9DB6", Offset = "0x9DB6", VA = "0x9DB6")]
		private void UserOnOnUserAprChangedEvent(AprDicWrapper apr)
		{
		/* --- GHIDRA: UserOnOnUserAprChangedEvent ---
		void Gameplay_AssetsPrefetch_UserAssetsPrefetch__UserOnOnUserAprChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a589d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AssetsPrefetch_UserAssetsPrefetch_UserOnOnUserAprChangedEvent__);
		    DAT_ram_00a589d8 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x80f5a745;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f5a745:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  param1_00 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_AssetsPrefetch_UserAssetsPrefetch_UserOnOnUserAprChangedEvent__,0);
		  Core_Data_UserData__add_OnUserAprChangedEvent(uVar3,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9C")]
		[Address(RVA = "0x1D84", Offset = "0x1D84", VA = "0x1D84")]
		private void CacheAsset(string assetId)
		{
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9D")]
		[Address(RVA = "0x1D86", Offset = "0x1D86", VA = "0x1D86")]
		private void ReleaseAsset(string assetId)
		{
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9E")]
		[Address(RVA = "0x9DB7", Offset = "0x9DB7", VA = "0x9DB7", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04002B5C RID: 11100
		[Token(Token = "0x4002B5C")]
		[FieldOffset(Offset = "0x8")]
		private List<string> _assetIds;
	}
}
