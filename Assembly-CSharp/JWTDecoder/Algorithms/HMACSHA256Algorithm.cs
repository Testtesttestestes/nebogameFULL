using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace JWTDecoder.Algorithms
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	public sealed class HMACSHA256Algorithm : IJwtAlgorithm
	{
		// Token: 0x060007B2 RID: 1970 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x5B87", Offset = "0x5B87", VA = "0x5B87", Slot = "4")]
		public byte[] Sign(byte[] key, byte[] bytesToSign)
		{
		/* --- GHIDRA: Sign ---
		undefined4 JWTDecoder_Algorithms_HMACSHA256Algorithm__Sign(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b85c == '\0') {
		    Mono_Security_ASN1__get_Item(&JWTDecoder_HashAlgorithm_TypeInfo);
		    DAT_ram_00a5b85c = '\x01';
		  }
		  local_8 = 0xffffffff;
		  local_c = JWTDecoder_HashAlgorithm_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000DF")]
		public string Name
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x5B88", Offset = "0x5B88", VA = "0x5B88", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x170000E0")]
		public bool IsAsymmetric
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x5B89", Offset = "0x5B89", VA = "0x5B89", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x5B8A", Offset = "0x5B8A", VA = "0x5B8A")]
		public HMACSHA256Algorithm()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		JWTDecoder_Algorithms_HMACSHA256Algorithm___ctor
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
		  if (DAT_ram_00a5b85d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Security_Cryptography_HMACSHA384_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a5b85d = '\x01';
		  }
		  piVar2 = (int *)unnamed_function_1417(System_Security_Cryptography_HMACSHA384_TypeInfo);
		  System_Security_Cryptography_HMACSHA384___ctor(piVar2,param2,0);
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
		      if (iVar6 != 1) goto code_r0x81388148;
		      uVar3 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x163,&local_c);
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
		code_r0x81388148:
		  piVar2 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x813881c0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x813881c0:
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
