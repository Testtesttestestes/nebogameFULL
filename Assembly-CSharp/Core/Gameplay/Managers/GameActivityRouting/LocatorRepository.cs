using System;
using System.Collections.Generic;
using Core.Rounting;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.GameActivityRouting
{
	// Token: 0x020011C7 RID: 4551
	[Token(Token = "0x20011C7")]
	public class LocatorRepository : ILocatorRepository, IDisposable
	{
		// Token: 0x06006C6A RID: 27754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C6A")]
		[Address(RVA = "0xB756", Offset = "0xB756", VA = "0xB756", Slot = "5")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Gameplay_Managers_GameActivityRouting_LocatorRepository__Dispose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 param2_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a6f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ILocator___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ILocator__TypeInfo);
		    DAT_ram_00a5a6f4 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xc) = param2;
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ILocator__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ILocator___ctor__);
		  *(int *)(param1 + 8) = param1_00;
		  param2_00 = *(undefined4 *)(param1 + 0xc);
		  if (DAT_ram_00a5a6f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ILocator__Add__);
		    DAT_ram_00a5a6f5 = '\x01';
		    param1_00 = *(int *)(param1 + 8);
		  }
		  iVar1 = Method_System_Collections_Generic_List_ILocator__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2_00;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x06006C6B RID: 27755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C6B")]
		[Address(RVA = "0xB757", Offset = "0xB757", VA = "0xB757")]
		public LocatorRepository(ILocator defaultLocator)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_LocatorRepository___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a6f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ILocator__Add__);
		    DAT_ram_00a5a6f5 = '\x01';
		  }
		  iVar1 = Method_System_Collections_Generic_List_ILocator__Add__;
		  param1_00 = *(int *)(param1 + 8);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C6C")]
		[Address(RVA = "0xB758", Offset = "0xB758", VA = "0xB758")]
		public void Add(ILocator locator)
		{
		/* --- GHIDRA: Add ---
		int Core_Gameplay_Managers_GameActivityRouting_LocatorRepository__Add
		              (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  int *piVar9;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a6f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_string___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ILocator__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ILocator__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ILocator__get_Current__);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_ILocator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ILocator__GetEnumerator__);
		    DAT_ram_00a5a6f6 = '\x01';
		  }
		  *param3 = *(undefined4 *)(param1 + 0xc);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 8),
		             Method_System_Collections_Generic_List_ILocator__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ILocator__MoveNext__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8125d178;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return 0;
		    }
		    piVar7 = local_8._4_4_;
		    iVar8 = *local_8._4_4_;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (Core_Rounting_ILocator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(piVar9[1] * 8 + iVar8 + 200);
		          goto code_r0x8125cce2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        Core_Rounting_ILocator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8125d170:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8125d178:
		      iVar8 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar8 == iVar2) {
		        piVar7 = (int *)import::env::__cxa_begin_catch(uVar6);
		        iVar2 = *piVar7;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return 0;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar6 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x32d,&local_20);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
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
		code_r0x8125cce2:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8125d170;
		    if (iVar8 == 0) goto code_r0x8125cfd5;
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (Core_Rounting_ILocator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(piVar9[1] * 8 + iVar8 + 200);
		          goto code_r0x8125cdd4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                        Core_Rounting_ILocator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8125cea0:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8125d178;
		    }
		code_r0x8125cdd4:
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8125cea0;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x32a,param2,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8125d178;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = System_Collections_CollectionBase___ctor(uVar6,uVar4,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8125d178;
		    }
		    if (iVar5 != 0) {
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (Core_Rounting_ILocator_TypeInfo == *piVar9) {
		            puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x8125cf29;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                          Core_Rounting_ILocator_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x8125cf29:
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x32b,param2,0);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8125d178;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar5 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x32c,uVar6,uVar4,
		                             Method_System_Linq_Enumerable_Contains_string___);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x8125d178;
		          }
		          if (iVar5 == 0) goto code_r0x8125cfd5;
		          goto code_r0x8125d134;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8125d178;
		    }
		code_r0x8125cfd5:
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (Core_Rounting_ILocator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x8125d086;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                        Core_Rounting_ILocator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8125d148:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8125d178;
		    }
		code_r0x8125d086:
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8125d148;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x32b,param2,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8125d178;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x32c,uVar6,uVar4,
		                       Method_System_Linq_Enumerable_Contains_string___);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8125d178;
		    }
		    if (iVar5 != 0) {
		code_r0x8125d134:
		      DAT_ram_009d3e38 = 0;
		      *param3 = piVar7;
		      return iVar2;
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x00014028 File Offset: 0x00012228
		[Token(Token = "0x6006C6D")]
		[Address(RVA = "0xB759", Offset = "0xB759", VA = "0xB759", Slot = "4")]
		public bool TryGetLocator(Uri uri, out ILocator locator)
		{
		/* --- GHIDRA: TryGetLocator ---
		void Core_Gameplay_Managers_GameActivityRouting_LocatorRepository__TryGetLocator
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6f7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
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

			return default(bool);
		}

		// Token: 0x040038FF RID: 14591
		[Token(Token = "0x40038FF")]
		[FieldOffset(Offset = "0x8")]
		private readonly List<ILocator> _locators;

		// Token: 0x04003900 RID: 14592
		[Token(Token = "0x4003900")]
		[FieldOffset(Offset = "0xC")]
		private ILocator _defaultLocator;
	}
}
