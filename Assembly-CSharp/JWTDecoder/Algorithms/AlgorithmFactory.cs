using System;
using Il2CppDummyDll;

namespace JWTDecoder.Algorithms
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	public class AlgorithmFactory : IAlgorithmFactory
	{
		// Token: 0x060007AF RID: 1967 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x5B84", Offset = "0x5B84", VA = "0x5B84", Slot = "4")]
		public IJwtAlgorithm Create(string algorithmName)
		{
		/* --- GHIDRA: Create ---
		undefined4
		JWTDecoder_Algorithms_AlgorithmFactory__Create(undefined4 param1,uint param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint local_4;
		  
		  if (DAT_ram_00a5b85a == '\0') {
		    Mono_Security_ASN1__get_Item(&JWTDecoder_Algorithms_HMACSHA256Algorithm_TypeInfo);
		    Mono_Security_ASN1__get_Item(&JWTDecoder_Algorithms_HMACSHA384Algorithm_TypeInfo);
		    Mono_Security_ASN1__get_Item(&JWTDecoder_Algorithms_HMACSHA512Algorithm_TypeInfo);
		    DAT_ram_00a5b85a = '\x01';
		  }
		  if (2 < param2) {
		    local_4 = param2;
		    uVar2 = unnamed_function_2232(&JWTDecoder_HashAlgorithm_TypeInfo);
		    uVar2 = func_ii_1081(uVar2,&local_4);
		    uVar1 = unnamed_function_2232(&StringLiteral_3004);
		    uVar2 = func_ii_4419(uVar1,uVar2,0);
		    uVar1 = unnamed_function_2232(&System_NotSupportedException_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    System_Xml_Serialization_XmlReflectionImporter__ImportXmlSerializableMapping(uVar1,uVar2,0);
		    uVar2 = unnamed_function_2232(&Method_JWTDecoder_Algorithms_AlgorithmFactory_Create__);
		    func_ii_1050(uVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = unnamed_function_1417
		                    (*(undefined4 *)
		                      (&PTR_JWTDecoder_Algorithms_HMACSHA256Algorithm_TypeInfo_ram_005a3820)[param2]
		                    );
		  return uVar2;
		}
		*/

		/* --- GHIDRA: Create ---
		undefined4
		JWTDecoder_Algorithms_AlgorithmFactory__Create(undefined4 param1,uint param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint local_4;
		  
		  if (DAT_ram_00a5b85a == '\0') {
		    Mono_Security_ASN1__get_Item(&JWTDecoder_Algorithms_HMACSHA256Algorithm_TypeInfo);
		    Mono_Security_ASN1__get_Item(&JWTDecoder_Algorithms_HMACSHA384Algorithm_TypeInfo);
		    Mono_Security_ASN1__get_Item(&JWTDecoder_Algorithms_HMACSHA512Algorithm_TypeInfo);
		    DAT_ram_00a5b85a = '\x01';
		  }
		  if (2 < param2) {
		    local_4 = param2;
		    uVar2 = unnamed_function_2232(&JWTDecoder_HashAlgorithm_TypeInfo);
		    uVar2 = func_ii_1081(uVar2,&local_4);
		    uVar1 = unnamed_function_2232(&StringLiteral_3004);
		    uVar2 = func_ii_4419(uVar1,uVar2,0);
		    uVar1 = unnamed_function_2232(&System_NotSupportedException_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    System_Xml_Serialization_XmlReflectionImporter__ImportXmlSerializableMapping(uVar1,uVar2,0);
		    uVar2 = unnamed_function_2232(&Method_JWTDecoder_Algorithms_AlgorithmFactory_Create__);
		    func_ii_1050(uVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar2 = unnamed_function_1417
		                    (*(undefined4 *)
		                      (&PTR_JWTDecoder_Algorithms_HMACSHA256Algorithm_TypeInfo_ram_005a3820)[param2]
		                    );
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x5B85", Offset = "0x5B85", VA = "0x5B85", Slot = "6")]
		public virtual IJwtAlgorithm Create(HashAlgorithm algorithm)
		{
			return null;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x5B86", Offset = "0x5B86", VA = "0x5B86")]
		public AlgorithmFactory()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		JWTDecoder_Algorithms_AlgorithmFactory___ctor
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int iVar6;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5b85b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Security_Cryptography_HMACSHA256_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a5b85b = '\x01';
		  }
		  piVar2 = (int *)unnamed_function_1417(System_Security_Cryptography_HMACSHA256_TypeInfo);
		  System_Security_Cryptography_HMACSHA256___ctor(piVar2,param2,0);
		  DAT_ram_009d3e38 = 0;
		  local_c = 0;
		  local_8 = &local_4;
		  local_4 = piVar2;
		  uVar3 = import::env::invoke_iiii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1e5,piVar2,param3,0);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar5 = global_1;
		    iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar5 == iVar6) {
		      piVar2 = (int *)import::env::__cxa_begin_catch(uVar3);
		      iVar5 = *piVar2;
		      uVar3 = 0;
		      DAT_ram_009d3e38 = 0;
		      local_c = iVar5;
		      import::env::invoke_v(0x123);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) goto code_r0x81387f1f;
		      uVar3 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x162,&local_c);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
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
		code_r0x81387f1f:
		  piVar2 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x81387f97;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81387f97:
		    (**(code **)((ulonglong)*puVar4 * 4))(piVar2,puVar4[1]);
		  }
		  if (iVar5 == 0) {
		    return uVar3;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}
}
