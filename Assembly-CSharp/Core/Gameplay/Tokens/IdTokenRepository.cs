using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ServicesNamespace;

namespace Core.Gameplay.Tokens
{
	// Token: 0x0200112A RID: 4394
	[Token(Token = "0x200112A")]
	public class IdTokenRepository : IDisposable
	{
		// Token: 0x06006706 RID: 26374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006706")]
		[Address(RVA = "0xB241", Offset = "0xB241", VA = "0xB241")]
		public IdTokenRepository(TokenatorService service, string clientId)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Tokens_IdTokenRepository___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  int *piVar7;
		  int *piVar8;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a92c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ITokenProvider__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__ITokenProvider__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__ITokenProvider__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__ITokenProvider__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__ITokenProvider__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_string__ITokenProvider__GetEnumerator__
		              );
		    DAT_ram_00a5a92c = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 8),
		                     Method_System_Collections_Generic_Dictionary_string__ITokenProvider__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar3,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_string__ITokenProvider__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1a2,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__ITokenProvider__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    iVar1 = System_IDisposable_TypeInfo;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81296322;
		    }
		    if (iVar4 == 0) goto code_r0x81296378;
		    piVar7 = (int *)0x0;
		    iVar6 = local_8._4_4_;
		    if (local_8._4_4_ != 0) {
		      DAT_ram_009d3e38 = 0;
		      piVar7 = (int *)import::env::invoke_iii
		                                (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,
		                                 local_8._4_4_,System_IDisposable_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		      if (piVar7 == (int *)0x0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar6,iVar1)
		        ;
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81296322;
		      }
		    }
		    iVar6 = *piVar7;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8);
		        if (iVar1 == *piVar8) {
		          puVar5 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x812962bb;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar5 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,iVar1,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x812962bb:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*puVar5,piVar7,puVar5[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81296322:
		  iVar1 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar6 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar6;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar6 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81296378:
		      DAT_ram_009d3e38 = 0;
		      System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                (*(undefined4 *)(param1 + 8),
		                 Method_System_Collections_Generic_Dictionary_string__ITokenProvider__Clear__);
		      return;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x42,&local_18);
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

		// Token: 0x06006707 RID: 26375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006707")]
		[Address(RVA = "0x1E88", Offset = "0x1E88", VA = "0x1E88")]
		public ITokenProvider GetTokenProvider(string scope)
		{
			return null;
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006708")]
		[Address(RVA = "0xB242", Offset = "0xB242", VA = "0xB242", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Gameplay_Tokens_IdTokenRepository__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a92d == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    DAT_ram_00a5a92d = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar1,0.0,0);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		  Gameplay_Combat_Control_Conveyor__Next(uVar1,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 8) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  return;
		}
		*/

		}

		// Token: 0x040036EC RID: 14060
		[Token(Token = "0x40036EC")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<string, ITokenProvider> _tokens;

		// Token: 0x040036ED RID: 14061
		[Token(Token = "0x40036ED")]
		[FieldOffset(Offset = "0xC")]
		private readonly TokenatorService _service;

		// Token: 0x040036EE RID: 14062
		[Token(Token = "0x40036EE")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _clientId;
	}
}
