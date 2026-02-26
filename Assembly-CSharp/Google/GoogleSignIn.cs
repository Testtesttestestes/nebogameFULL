using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Google.Impl;
using Il2CppDummyDll;

namespace Google
{
	// Token: 0x020013C9 RID: 5065
	[Token(Token = "0x20013C9")]
	public class GoogleSignIn
	{
		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x060078B3 RID: 30899 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060078B2 RID: 30898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017E9")]
		public static GoogleSignInConfiguration Configuration
		{
			[Token(Token = "0x60078B3")]
			[Address(RVA = "0xC1F6", Offset = "0xC1F6", VA = "0xC1F6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60078B2")]
			[Address(RVA = "0xC1F5", Offset = "0xC1F5", VA = "0xC1F5")]
			set
			{
			}
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x060078B4 RID: 30900 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017EA")]
		public static GoogleSignIn DefaultInstance
		{
			[Token(Token = "0x60078B4")]
			[Address(RVA = "0xC1F7", Offset = "0xC1F7", VA = "0xC1F7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060078B5 RID: 30901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078B5")]
		[Address(RVA = "0xC1F8", Offset = "0xC1F8", VA = "0xC1F8")]
		internal GoogleSignIn(GoogleSignInImpl impl)
		{
		/* --- GHIDRA: .ctor ---
		void Google_GoogleSignIn___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a54e8e == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_ISignInImpl_TypeInfo);
		    DAT_ram_00a54e8e = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Google_ISignInImpl_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80b2bce0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Google_ISignInImpl_TypeInfo,2);
		code_r0x80b2bce0:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		void Google_GoogleSignIn___cctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a54e8b == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_GoogleSignIn_TypeInfo);
		    DAT_ram_00a54e8b = '\x01';
		  }
		  if (*(int *)(Google_GoogleSignIn_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_GoogleSignIn_TypeInfo);
		  }
		  piVar3 = *(int **)(Google_GoogleSignIn_TypeInfo + 0x5c);
		  if (*piVar3 != 0) {
		    if (*(int *)(Google_GoogleSignIn_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_GoogleSignIn_TypeInfo);
		      piVar3 = *(int **)(Google_GoogleSignIn_TypeInfo + 0x5c);
		    }
		    iVar4 = piVar3[1];
		    if (iVar4 != param1) {
		      if (*(int *)(Google_GoogleSignIn_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Google_GoogleSignIn_TypeInfo);
		        iVar4 = *(int *)(*(int *)(Google_GoogleSignIn_TypeInfo + 0x5c) + 4);
		      }
		      if (iVar4 != 0) {
		        uVar1 = unnamed_function_2232(&Google_GoogleSignIn_SignInException_TypeInfo);
		        uVar1 = unnamed_function_1417(uVar1);
		        uVar2 = unnamed_function_2232(&StringLiteral_6431);
		        Google_GoogleSignIn_SignInException___ctor(uVar1,6,uVar2,uVar1);
		        uVar2 = unnamed_function_2232(&Method_Google_GoogleSignIn_set_Configuration__);
		        func_ii_1050(uVar1,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  if (*(int *)(Google_GoogleSignIn_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_GoogleSignIn_TypeInfo);
		  }
		  *(int *)(*(int *)(Google_GoogleSignIn_TypeInfo + 0x5c) + 4) = param1;
		  return;
		}
		*/

		}

		// Token: 0x060078B6 RID: 30902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078B6")]
		[Address(RVA = "0xC1F9", Offset = "0xC1F9", VA = "0xC1F9")]
		public void EnableDebugLogging(bool flag)
		{
		/* --- GHIDRA: EnableDebugLogging ---
		undefined4 Google_GoogleSignIn__EnableDebugLogging(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param1_00;
		  undefined4 param1_01;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_02;
		  int iVar4;
		  
		  if (DAT_ram_00a54e8f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Future_GoogleSignInUser__WaitForResult__);
		    Mono_Security_ASN1__get_Item(&Google_ISignInImpl_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Threading_Tasks_TaskCompletionSource_GoogleSignInUser___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Threading_Tasks_TaskCompletionSource_GoogleSignInUser__get_Task__);
		    Mono_Security_ASN1__get_Item
		              (&System_Threading_Tasks_TaskCompletionSource_GoogleSignInUser__TypeInfo);
		    DAT_ram_00a54e8f = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Threading_Tasks_TaskCompletionSource_GoogleSignInUser__TypeInfo);
		  Unity_Services_Core_ServicesInitializationException___ctor
		            (param1_00,Method_System_Threading_Tasks_TaskCompletionSource_GoogleSignInUser___ctor__)
		  ;
		  param1_01 = Google_Impl_NativeFuture___c__DisplayClass5_0___get_Result_b__7(param1);
		  param1_02 = *(int **)(param1 + 8);
		  iVar4 = *param1_02;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Google_ISignInImpl_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80b2bdca;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Google_ISignInImpl_TypeInfo,0);
		code_r0x80b2bdca:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  uVar3 = Google_Future_object____WaitForResult_b__8_0
		                    (uVar3,param1_00,Method_Google_Future_GoogleSignInUser__WaitForResult__);
		  UnityEngine_MonoBehaviour__StartCoroutine(param1_01,uVar3,0);
		  return *(undefined4 *)(param1_00 + 8);
		}
		*/

		}

		// Token: 0x060078B7 RID: 30903 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60078B7")]
		[Address(RVA = "0xC1FA", Offset = "0xC1FA", VA = "0xC1FA")]
		public Task<GoogleSignInUser> SignIn()
		{
		/* --- GHIDRA: SignIn ---
		undefined4 Google_GoogleSignIn__SignIn(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param1_00;
		  undefined4 param1_01;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_02;
		  int iVar4;
		  
		  if (DAT_ram_00a54e90 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Future_GoogleSignInUser__WaitForResult__);
		    Mono_Security_ASN1__get_Item(&Google_ISignInImpl_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Threading_Tasks_TaskCompletionSource_GoogleSignInUser___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Threading_Tasks_TaskCompletionSource_GoogleSignInUser__get_Task__);
		    Mono_Security_ASN1__get_Item
		              (&System_Threading_Tasks_TaskCompletionSource_GoogleSignInUser__TypeInfo);
		    DAT_ram_00a54e90 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Threading_Tasks_TaskCompletionSource_GoogleSignInUser__TypeInfo);
		  Unity_Services_Core_ServicesInitializationException___ctor
		            (param1_00,Method_System_Threading_Tasks_TaskCompletionSource_GoogleSignInUser___ctor__)
		  ;
		  param1_01 = Google_Impl_NativeFuture___c__DisplayClass5_0___get_Result_b__7(param1);
		  param1_02 = *(int **)(param1 + 8);
		  iVar4 = *param1_02;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Google_ISignInImpl_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x80b2bfba;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Google_ISignInImpl_TypeInfo,1);
		code_r0x80b2bfba:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  uVar3 = Google_Future_object____WaitForResult_b__8_0
		                    (uVar3,param1_00,Method_Google_Future_GoogleSignInUser__WaitForResult__);
		  UnityEngine_MonoBehaviour__StartCoroutine(param1_01,uVar3,0);
		  return *(undefined4 *)(param1_00 + 8);
		}
		*/

			return null;
		}

		// Token: 0x060078B8 RID: 30904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60078B8")]
		[Address(RVA = "0xC1FB", Offset = "0xC1FB", VA = "0xC1FB")]
		public Task<GoogleSignInUser> SignInSilently()
		{
		/* --- GHIDRA: SignInSilently ---
		void Google_GoogleSignIn__SignInSilently(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a54e91 == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_GoogleSignIn_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Google_ISignInImpl_TypeInfo);
		    DAT_ram_00a54e91 = '\x01';
		  }
		  uVar1 = 0;
		  if (*(int *)(Google_GoogleSignIn_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_GoogleSignIn_TypeInfo);
		  }
		  *(undefined4 *)(*(int *)(Google_GoogleSignIn_TypeInfo + 0x5c) + 4) = 0;
		  param1_00 = *(int **)(param1 + 8);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Google_ISignInImpl_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x80b2c0ae;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Google_ISignInImpl_TypeInfo,3);
		code_r0x80b2c0ae:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078B9")]
		[Address(RVA = "0xC1FC", Offset = "0xC1FC", VA = "0xC1FC")]
		public void SignOut()
		{
		/* --- GHIDRA: SignOut ---
		void Google_GoogleSignIn__SignOut(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a54e92 == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_ISignInImpl_TypeInfo);
		    DAT_ram_00a54e92 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Google_ISignInImpl_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x80b2c155;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Google_ISignInImpl_TypeInfo,4);
		code_r0x80b2c155:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x060078BA RID: 30906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078BA")]
		[Address(RVA = "0xC1FD", Offset = "0xC1FD", VA = "0xC1FD")]
		public void Disconnect()
		{
		/* --- GHIDRA: Disconnect ---
		void Google_GoogleSignIn__Disconnect(int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a54e93 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Exception_TypeInfo);
		    DAT_ram_00a54e93 = '\x01';
		  }
		  if (*(int *)(System_Exception_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Exception_TypeInfo);
		  }
		  System_Exception__Init(param1,0);
		  *(undefined4 *)(param1 + 0x48) = param2;
		  return;
		}
		*/

		}

		// Token: 0x04003F15 RID: 16149
		[Token(Token = "0x4003F15")]
		[FieldOffset(Offset = "0x0")]
		private static GoogleSignIn theInstance;

		// Token: 0x04003F16 RID: 16150
		[Token(Token = "0x4003F16")]
		[FieldOffset(Offset = "0x4")]
		private static GoogleSignInConfiguration theConfiguration;

		// Token: 0x04003F17 RID: 16151
		[Token(Token = "0x4003F17")]
		[FieldOffset(Offset = "0x8")]
		private ISignInImpl impl;

		// Token: 0x020013CA RID: 5066
		[Token(Token = "0x20013CA")]
		[Serializable]
		public class SignInException : Exception
		{
			// Token: 0x060078BB RID: 30907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60078BB")]
			[Address(RVA = "0xC1FE", Offset = "0xC1FE", VA = "0xC1FE")]
			internal SignInException(GoogleSignInStatusCode status)
			{
			}

			// Token: 0x060078BC RID: 30908 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60078BC")]
			[Address(RVA = "0xC1FF", Offset = "0xC1FF", VA = "0xC1FF")]
			public SignInException(GoogleSignInStatusCode status, string message)
			{
			}

			// Token: 0x060078BD RID: 30909 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60078BD")]
			[Address(RVA = "0xC200", Offset = "0xC200", VA = "0xC200")]
			public SignInException(GoogleSignInStatusCode status, string message, Exception innerException)
			{
			}

			// Token: 0x060078BE RID: 30910 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60078BE")]
			[Address(RVA = "0xC201", Offset = "0xC201", VA = "0xC201")]
			protected SignInException(GoogleSignInStatusCode status, SerializationInfo info, StreamingContext context)
			{
			}

			// Token: 0x170017EB RID: 6123
			// (get) Token: 0x060078BF RID: 30911 RVA: 0x00016368 File Offset: 0x00014568
			// (set) Token: 0x060078C0 RID: 30912 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170017EB")]
			public GoogleSignInStatusCode Status
			{
				[Token(Token = "0x60078BF")]
				[Address(RVA = "0xC202", Offset = "0xC202", VA = "0xC202")]
				[CompilerGenerated]
				get
				{
					return GoogleSignInStatusCode.Success;
				}
				[Token(Token = "0x60078C0")]
				[Address(RVA = "0xC203", Offset = "0xC203", VA = "0xC203")]
				[CompilerGenerated]
				internal set
				{
				}
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Configuration ---
		undefined4 Google_GoogleSignIn__set_Configuration(undefined4 param1)
		
		{
		  if (DAT_ram_00a54e8c == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_GoogleSignIn_TypeInfo);
		    DAT_ram_00a54e8c = '\x01';
		  }
		  if (*(int *)(Google_GoogleSignIn_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_GoogleSignIn_TypeInfo);
		  }
		  return *(undefined4 *)(*(int *)(Google_GoogleSignIn_TypeInfo + 0x5c) + 4);
		}
		*/


		/* --- GHIDRA: get_Configuration ---
		int Google_GoogleSignIn__get_Configuration(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a54e8d == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_GoogleSignIn_TypeInfo);
		    DAT_ram_00a54e8d = '\x01';
		  }
		  if (*(int *)(Google_GoogleSignIn_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_GoogleSignIn_TypeInfo);
		  }
		  iVar3 = **(int **)(Google_GoogleSignIn_TypeInfo + 0x5c);
		  if (iVar3 != 0) {
		    if (*(int *)(Google_GoogleSignIn_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_GoogleSignIn_TypeInfo);
		      iVar3 = **(int **)(Google_GoogleSignIn_TypeInfo + 0x5c);
		    }
		    return iVar3;
		  }
		  uVar1 = unnamed_function_2232(&Google_GoogleSignIn_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar1,0,uVar1);
		  uVar2 = unnamed_function_2232(&Google_GoogleSignIn_TypeInfo);
		  unnamed_function_151018(uVar2);
		  iVar3 = unnamed_function_2232(&Google_GoogleSignIn_TypeInfo);
		  **(undefined4 **)(iVar3 + 0x5c) = uVar1;
		  unnamed_function_2232(&Google_GoogleSignIn_TypeInfo);
		  uVar1 = unnamed_function_2232(&Google_GoogleSignIn_SignInException_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_16181);
		  Google_GoogleSignIn_SignInException___ctor(uVar1,6,uVar2,uVar1);
		  uVar2 = unnamed_function_2232(&Method_Google_GoogleSignIn_get_DefaultInstance__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
