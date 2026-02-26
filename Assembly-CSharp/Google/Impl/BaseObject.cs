using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Google.Impl
{
	// Token: 0x020013CF RID: 5071
	[Token(Token = "0x20013CF")]
	internal abstract class BaseObject : IDisposable
	{
		// Token: 0x060078D8 RID: 30936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078D8")]
		[Address(RVA = "0xC216", Offset = "0xC216", VA = "0xC216")]
		public BaseObject(IntPtr intPtr)
		{
		/* --- GHIDRA: .cctor ---
		void Google_Impl_BaseObject___cctor(int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  uVar3 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar3;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (cVar1 == '\x01') {
		      *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x144;
		    }
		    else {
		      if (param2 == 0) {
		        uVar3 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar3,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		      *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x02') {
		    *(char **)(param1 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x143;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x145;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Google_Impl_BaseObject___ctor(undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54e97 == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Impl_BaseObject_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Runtime_InteropServices_HandleRef_TypeInfo);
		    DAT_ram_00a54e97 = '\x01';
		  }
		  if (*(int *)(Google_Impl_BaseObject_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_Impl_BaseObject_TypeInfo);
		  }
		  local_8 = **(undefined8 **)(Google_Impl_BaseObject_TypeInfo + 0x5c);
		  uVar1 = func_ii_1081(System_Runtime_InteropServices_HandleRef_TypeInfo,&local_8);
		  local_14 = 0xffffffff;
		  local_18 = System_Runtime_InteropServices_HandleRef_TypeInfo;
		  local_10 = *(undefined8 *)(param2 + 8);
		  iVar2 = System_IO_File__OpenWrite(&local_18,uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = unnamed_function_2232(&System_InvalidOperationException_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    uVar3 = unnamed_function_2232(&StringLiteral_3415);
		    func_ii_3057(uVar1,uVar3,0);
		    uVar3 = unnamed_function_2232(&Method_Google_Impl_BaseObject_SelfPtr__);
		    func_ii_1050(uVar1,uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *param1 = *(undefined8 *)(param2 + 8);
		  return;
		}
		*/

		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x00016380 File Offset: 0x00014580
		[Token(Token = "0x60078D9")]
		[Address(RVA = "0xC217", Offset = "0xC217", VA = "0xC217")]
		protected HandleRef SelfPtr()
		{
		/* --- GHIDRA: SelfPtr ---
		void Google_Impl_BaseObject__SelfPtr(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54e98 == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Impl_BaseObject_TypeInfo);
		    DAT_ram_00a54e98 = '\x01';
		  }
		  if (*(int *)(Google_Impl_BaseObject_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_Impl_BaseObject_TypeInfo);
		  }
		  *(undefined8 *)(param1 + 8) = **(undefined8 **)(Google_Impl_BaseObject_TypeInfo + 0x5c);
		  return;
		}
		*/

			return default(HandleRef);
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078DA")]
		[Address(RVA = "0xC218", Offset = "0xC218", VA = "0xC218", Slot = "5")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		/* WARNING: Removing unreachable block (ram,0x80b2c552) */
		/* WARNING: Removing unreachable block (ram,0x80b2c475) */
		
		undefined4 Google_Impl_BaseObject__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  int *param2_00;
		  undefined4 param2_01;
		  undefined4 local_8;
		  int local_4;
		  
		  if (DAT_ram_00a54e99 == '\0') {
		    Mono_Security_ASN1__get_Item(&byte___TypeInfo);
		    DAT_ram_00a54e99 = '\x01';
		  }
		  local_4 = (**(code **)((ulonglong)*(uint *)(param1 + 0xc) * 4))
		                      (*(undefined4 *)(param1 + 0x20),0,0,*(undefined4 *)(param1 + 0x14));
		  local_8 = 0;
		  uVar1 = func_ii_1081(DAT_ram_00a66960,&local_8);
		  iVar2 = System_UIntPtr___ctor(&local_4,uVar1,0);
		  if (iVar2 != 0) {
		    return 0;
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::invoke_iii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1b1,byte___TypeInfo,local_4
		                    );
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiiii
		              (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(param1 + 0x20),uVar1,local_4,
		               *(undefined4 *)(param1 + 0x14));
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      piVar4 = (int *)import::env::invoke_ii
		                                (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x22c,0);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::invoke_iiiiii
		                          (*(undefined4 *)(*piVar4 + 0x1f0),piVar4,uVar1,0,local_4 + -1,
		                           *(undefined4 *)(*piVar4 + 500));
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          DAT_ram_009d3e38 = 0;
		          return uVar1;
		        }
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		    }
		  }
		  iVar2 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                         *(undefined4 *)*piVar4);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 != 1) {
		        if (iVar3 != 0) {
		          piVar4 = (int *)*piVar4;
		          import::env::__cxa_end_catch();
		          uVar1 = unnamed_function_2232(&StringLiteral_7568);
		          if (piVar4 == (int *)0x0) {
		            param2_01 = 0;
		          }
		          else {
		            param2_01 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xd8) * 4))
		                                  (piVar4,*(undefined4 *)(*piVar4 + 0xdc));
		          }
		          uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,param2_01,0);
		          iVar2 = unnamed_function_2232(&UnityEngine_Debug_TypeInfo);
		          if (*(int *)(iVar2 + 0x74) == 0) {
		            func_ii_306000(iVar2);
		          }
		          Unity_Collections_NativeArray_ContactPairHeader___AsReadOnly(uVar1,0);
		          return **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		        }
		        param2_00 = (int *)unnamed_function_951(4);
		        *param2_00 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80b2c74b;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x80b2c74b:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060078DB RID: 30939 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60078DB")]
		[Address(RVA = "0xC219", Offset = "0xC219", VA = "0xC219")]
		internal static string OutParamsToString(BaseObject.OutStringMethod outStringMethod)
		{
			return null;
		}

		// Token: 0x04003F37 RID: 16183
		[Token(Token = "0x4003F37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private HandleRef selfHandleRef;

		// Token: 0x04003F38 RID: 16184
		[Token(Token = "0x4003F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HandleRef nullSelf;

		// Token: 0x020013D0 RID: 5072
		// (Invoke) Token: 0x060078DE RID: 30942
		[Token(Token = "0x20013D0")]
		internal delegate UIntPtr OutStringMethod([In] [Out] byte[] out_bytes, UIntPtr out_size);
	}
}
