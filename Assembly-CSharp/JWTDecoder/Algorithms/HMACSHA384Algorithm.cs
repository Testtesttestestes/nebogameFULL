using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace JWTDecoder.Algorithms
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	public sealed class HMACSHA384Algorithm : IJwtAlgorithm
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x5B8B", Offset = "0x5B8B", VA = "0x5B8B", Slot = "4")]
		public byte[] Sign(byte[] key, byte[] bytesToSign)
		{
		/* --- GHIDRA: Sign ---
		undefined4 JWTDecoder_Algorithms_HMACSHA384Algorithm__Sign(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b85e == '\0') {
		    Mono_Security_ASN1__get_Item(&JWTDecoder_HashAlgorithm_TypeInfo);
		    DAT_ram_00a5b85e = '\x01';
		  }
		  local_8 = 0x1ffffffff;
		  local_c = JWTDecoder_HashAlgorithm_TypeInfo;
		  uVar1 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E1")]
		public string Name
		{
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x5B8C", Offset = "0x5B8C", VA = "0x5B8C", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x170000E2")]
		public bool IsAsymmetric
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x5B8D", Offset = "0x5B8D", VA = "0x5B8D", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x5B8E", Offset = "0x5B8E", VA = "0x5B8E")]
		public HMACSHA384Algorithm()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		JWTDecoder_Algorithms_HMACSHA384Algorithm___ctor
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
		  if (DAT_ram_00a5b85f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Security_Cryptography_HMACSHA512_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a5b85f = '\x01';
		  }
		  piVar2 = (int *)unnamed_function_1417(System_Security_Cryptography_HMACSHA512_TypeInfo);
		  System_Security_Cryptography_HMACSHA512___ctor(piVar2,param2,0);
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
		      if (iVar6 != 1) goto code_r0x81388371;
		      uVar3 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x164,&local_c);
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
		code_r0x81388371:
		  piVar2 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x813883e9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x813883e9:
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
