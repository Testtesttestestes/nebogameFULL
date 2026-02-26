using System;
using Il2CppDummyDll;

namespace Google.Impl
{
	// Token: 0x020013D2 RID: 5074
	[Token(Token = "0x20013D2")]
	internal class NativeFuture : BaseObject, FutureAPIImpl<GoogleSignInUser>
	{
		// Token: 0x060078FB RID: 30971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078FB")]
		[Address(RVA = "0xC239", Offset = "0xC239", VA = "0xC239")]
		internal NativeFuture(IntPtr ptr)
		{
		/* --- GHIDRA: .ctor ---
		void Google_Impl_NativeFuture___ctor(int param1,undefined4 param2)
		
		{
		  undefined1 auStack_10 [8];
		  undefined1 auStack_8 [4];
		  undefined4 local_4;
		  
		  Google_Impl_BaseObject___ctor(auStack_8,param1,auStack_10);
		  import::env::GoogleSignIn_DisposeFuture(local_4);
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

		}

		// Token: 0x060078FC RID: 30972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078FC")]
		[Address(RVA = "0xC23A", Offset = "0xC23A", VA = "0xC23A", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		uint Google_Impl_NativeFuture__Dispose(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [8];
		  undefined1 auStack_8 [4];
		  undefined4 local_4;
		  
		  Google_Impl_BaseObject___ctor(auStack_8,param1,auStack_10);
		  iVar1 = import::env::GoogleSignIn_Pending(local_4);
		  return (uint)(iVar1 != 0);
		}
		*/

		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x060078FD RID: 30973 RVA: 0x000163B0 File Offset: 0x000145B0
		[Token(Token = "0x170017F4")]
		public bool Pending
		{
			[Token(Token = "0x60078FD")]
			[Address(RVA = "0xC23B", Offset = "0xC23B", VA = "0xC23B", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x060078FE RID: 30974 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017F5")]
		public GoogleSignInUser Result
		{
			[Token(Token = "0x60078FE")]
			[Address(RVA = "0xC23C", Offset = "0xC23C", VA = "0xC23C", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x060078FF RID: 30975 RVA: 0x000163C8 File Offset: 0x000145C8
		[Token(Token = "0x170017F6")]
		public GoogleSignInStatusCode Status
		{
			[Token(Token = "0x60078FF")]
			[Address(RVA = "0xC23D", Offset = "0xC23D", VA = "0xC23D", Slot = "7")]
			get
			{
				return GoogleSignInStatusCode.Success;
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Pending ---
		int Google_Impl_NativeFuture__get_Pending(undefined4 param1,undefined4 param2)
		
		{
		  char cVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  int iVar4;
		  undefined4 uVar5;
		  undefined8 local_8;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a54e9e == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Impl_BaseObject_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Google_GoogleSignInUser_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Google_Impl_BaseObject_OutStringMethod_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__2__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__3__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__4__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__5__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__6__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__7__);
		    Mono_Security_ASN1__get_Item(&Google_Impl_NativeFuture___c__DisplayClass5_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Uri_TypeInfo);
		    DAT_ram_00a54e9e = '\x01';
		  }
		  Google_Impl_BaseObject___ctor(&local_8,param1,0);
		  iVar2 = import::env::GoogleSignIn_Result(local_8._4_4_);
		  if (iVar2 != 0) {
		    iVar3 = unnamed_function_1417(Google_Impl_NativeFuture___c__DisplayClass5_0_TypeInfo);
		    param2_00 = unnamed_function_1417(Google_GoogleSignInUser_TypeInfo);
		    local_8 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty(&local_8,param2_00,iVar2,0);
		    *(undefined8 *)(iVar3 + 8) = local_8;
		    iVar4 = unnamed_function_1417(Google_Impl_BaseObject_OutStringMethod_TypeInfo);
		    iVar2 = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__0__;
		    uVar5 = *(undefined4 *)
		             (Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__0__ + 4);
		    *(int *)(iVar4 + 0x14) = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__0__
		    ;
		    *(undefined4 *)(iVar4 + 8) = uVar5;
		    *(int *)(iVar4 + 0x10) = iVar3;
		    cVar1 = *(char *)(iVar2 + 0x2e);
		    *(int *)(iVar4 + 0x20) = iVar4;
		    iVar2 = func_ii_4538(iVar2);
		    if (iVar2 == 0) {
		      if (cVar1 == '\x01') {
		        *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x144;
		      }
		      else {
		        *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		        *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		      }
		    }
		    else if (cVar1 == '\x02') {
		      *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x143;
		    }
		    else {
		      *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		      *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		    }
		    *(char **)(iVar4 + 0x1c) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x145;
		    if (*(int *)(Google_Impl_BaseObject_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Impl_BaseObject_TypeInfo);
		    }
		    uVar5 = Google_Impl_BaseObject__Dispose(iVar4,param2_00);
		    *(undefined4 *)(param2_00 + 0x14) = uVar5;
		    iVar4 = unnamed_function_1417(Google_Impl_BaseObject_OutStringMethod_TypeInfo);
		    iVar2 = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__1__;
		    uVar5 = *(undefined4 *)
		             (Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__1__ + 4);
		    *(int *)(iVar4 + 0x14) = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__1__
		    ;
		    *(undefined4 *)(iVar4 + 8) = uVar5;
		    *(int *)(iVar4 + 0x10) = iVar3;
		    cVar1 = *(char *)(iVar2 + 0x2e);
		    *(int *)(iVar4 + 0x20) = iVar4;
		    iVar2 = func_ii_4538(iVar2);
		    if (iVar2 == 0) {
		      if (cVar1 == '\x01') {
		        *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x144;
		      }
		      else {
		        *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		        *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		      }
		    }
		    else if (cVar1 == '\x02') {
		      *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x143;
		    }
		    else {
		      *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		      *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		    }
		    *(char **)(iVar4 + 0x1c) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x145;
		    uVar5 = Google_Impl_BaseObject__Dispose(iVar4,param2_00);
		    *(undefined4 *)(param2_00 + 0xc) = uVar5;
		    iVar4 = unnamed_function_1417(Google_Impl_BaseObject_OutStringMethod_TypeInfo);
		    iVar2 = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__2__;
		    uVar5 = *(undefined4 *)
		             (Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__2__ + 4);
		    *(int *)(iVar4 + 0x14) = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__2__
		    ;
		    *(undefined4 *)(iVar4 + 8) = uVar5;
		    *(int *)(iVar4 + 0x10) = iVar3;
		    cVar1 = *(char *)(iVar2 + 0x2e);
		    *(int *)(iVar4 + 0x20) = iVar4;
		    iVar2 = func_ii_4538(iVar2);
		    if (iVar2 == 0) {
		      if (cVar1 == '\x01') {
		        *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x144;
		      }
		      else {
		        *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		        *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		      }
		    }
		    else if (cVar1 == '\x02') {
		      *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x143;
		    }
		    else {
		      *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		      *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		    }
		    *(char **)(iVar4 + 0x1c) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x145;
		    uVar5 = Google_Impl_BaseObject__Dispose(iVar4,param2_00);
		    *(undefined4 *)(param2_00 + 0x1c) = uVar5;
		    iVar4 = unnamed_function_1417(Google_Impl_BaseObject_OutStringMethod_TypeInfo);
		    iVar2 = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__3__;
		    uVar5 = *(undefined4 *)
		             (Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__3__ + 4);
		    *(int *)(iVar4 + 0x14) = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__3__
		    ;
		    *(undefined4 *)(iVar4 + 8) = uVar5;
		    *(int *)(iVar4 + 0x10) = iVar3;
		    cVar1 = *(char *)(iVar2 + 0x2e);
		    *(int *)(iVar4 + 0x20) = iVar4;
		    iVar2 = func_ii_4538(iVar2);
		    if (iVar2 == 0) {
		      if (cVar1 == '\x01') {
		        *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x144;
		      }
		      else {
		        *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		        *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		      }
		    }
		    else if (cVar1 == '\x02') {
		      *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x143;
		    }
		    else {
		      *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		      *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		    }
		    *(char **)(iVar4 + 0x1c) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x145;
		    uVar5 = Google_Impl_BaseObject__Dispose(iVar4,param2_00);
		    *(undefined4 *)(param2_00 + 0x18) = uVar5;
		    iVar4 = unnamed_function_1417(Google_Impl_BaseObject_OutStringMethod_TypeInfo);
		    iVar2 = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__4__;
		    uVar5 = *(undefined4 *)
		             (Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__4__ + 4);
		    *(int *)(iVar4 + 0x14) = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__4__
		    ;
		    *(undefined4 *)(iVar4 + 8) = uVar5;
		    *(int *)(iVar4 + 0x10) = iVar3;
		    cVar1 = *(char *)(iVar2 + 0x2e);
		    *(int *)(iVar4 + 0x20) = iVar4;
		    iVar2 = func_ii_4538(iVar2);
		    if (iVar2 == 0) {
		      if (cVar1 == '\x01') {
		        *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x144;
		      }
		      else {
		        *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		        *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		      }
		    }
		    else if (cVar1 == '\x02') {
		      *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x143;
		    }
		    else {
		      *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		      *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		    }
		    *(char **)(iVar4 + 0x1c) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x145;
		    uVar5 = Google_Impl_BaseObject__Dispose(iVar4,param2_00);
		    *(undefined4 *)(param2_00 + 0x10) = uVar5;
		    iVar4 = unnamed_function_1417(Google_Impl_BaseObject_OutStringMethod_TypeInfo);
		    iVar2 = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__5__;
		    uVar5 = *(undefined4 *)
		             (Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__5__ + 4);
		    *(int *)(iVar4 + 0x14) = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__5__
		    ;
		    *(undefined4 *)(iVar4 + 8) = uVar5;
		    *(int *)(iVar4 + 0x10) = iVar3;
		    cVar1 = *(char *)(iVar2 + 0x2e);
		    *(int *)(iVar4 + 0x20) = iVar4;
		    iVar2 = func_ii_4538(iVar2);
		    if (iVar2 == 0) {
		      if (cVar1 == '\x01') {
		        *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x144;
		      }
		      else {
		        *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		        *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		      }
		    }
		    else if (cVar1 == '\x02') {
		      *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x143;
		    }
		    else {
		      *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		      *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		    }
		    *(char **)(iVar4 + 0x1c) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x145;
		    uVar5 = Google_Impl_BaseObject__Dispose(iVar4,param2_00);
		    *(undefined4 *)(param2_00 + 8) = uVar5;
		    iVar4 = unnamed_function_1417(Google_Impl_BaseObject_OutStringMethod_TypeInfo);
		    iVar2 = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__6__;
		    uVar5 = *(undefined4 *)
		             (Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__6__ + 4);
		    *(int *)(iVar4 + 0x14) = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__6__
		    ;
		    *(undefined4 *)(iVar4 + 8) = uVar5;
		    *(int *)(iVar4 + 0x10) = iVar3;
		    cVar1 = *(char *)(iVar2 + 0x2e);
		    *(int *)(iVar4 + 0x20) = iVar4;
		    iVar2 = func_ii_4538(iVar2);
		    if (iVar2 == 0) {
		      if (cVar1 == '\x01') {
		        *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x144;
		      }
		      else {
		        *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		        *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		      }
		    }
		    else if (cVar1 == '\x02') {
		      *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x143;
		    }
		    else {
		      *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		      *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		    }
		    *(char **)(iVar4 + 0x1c) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x145;
		    iVar2 = Google_Impl_BaseObject__Dispose(iVar4,param2_00);
		    if (0 < *(int *)(iVar2 + 8)) {
		      uVar5 = unnamed_function_1417(System_Uri_TypeInfo);
		      UI_Windows_ClosableBaseWindow_object___HandleCloseButton(uVar5,iVar2,0);
		      *(undefined4 *)(param2_00 + 0x20) = uVar5;
		    }
		    iVar4 = unnamed_function_1417(Google_Impl_BaseObject_OutStringMethod_TypeInfo);
		    iVar2 = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__7__;
		    uVar5 = *(undefined4 *)
		             (Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__7__ + 4);
		    *(int *)(iVar4 + 0x14) = Method_Google_Impl_NativeFuture___c__DisplayClass5_0__get_Result_b__7__
		    ;
		    *(undefined4 *)(iVar4 + 8) = uVar5;
		    *(int *)(iVar4 + 0x10) = iVar3;
		    cVar1 = *(char *)(iVar2 + 0x2e);
		    *(int *)(iVar4 + 0x20) = iVar4;
		    iVar2 = func_ii_4538(iVar2);
		    if (iVar2 == 0) {
		      if (cVar1 == '\x01') {
		        *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x144;
		      }
		      else {
		        *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		        *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		      }
		    }
		    else if (cVar1 == '\x02') {
		      *(char **)(iVar4 + 0xc) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x143;
		    }
		    else {
		      *(undefined4 *)(iVar4 + 0xc) = *(undefined4 *)(iVar4 + 8);
		      *(undefined4 *)(iVar4 + 0x20) = *(undefined4 *)(iVar4 + 0x10);
		    }
		    *(char **)(iVar4 + 0x1c) = s_struct_Uniforms___color__array<v_ram_000017c8 + 0x145;
		    if (*(int *)(Google_Impl_BaseObject_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Impl_BaseObject_TypeInfo);
		    }
		    uVar5 = Google_Impl_BaseObject__Dispose(iVar4,param2_00);
		    *(undefined4 *)(param2_00 + 0x24) = uVar5;
		  }
		  return param2_00;
		}
		*/


		/* --- GHIDRA: get_Result ---
		undefined4 Google_Impl_NativeFuture__get_Result(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined1 auStack_10 [8];
		  undefined1 auStack_8 [4];
		  undefined4 local_4;
		  
		  Google_Impl_BaseObject___ctor(auStack_8,param1,auStack_10);
		  uVar1 = import::env::GoogleSignIn_Status(local_4);
		  return uVar1;
		}
		*/

}
