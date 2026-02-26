using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Google.Impl
{
	// Token: 0x020013D1 RID: 5073
	[Token(Token = "0x20013D1")]
	internal class GoogleSignInImpl : BaseObject, ISignInImpl
	{
		// Token: 0x060078E1 RID: 30945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078E1")]
		[Address(RVA = "0xC21F", Offset = "0xC21F", VA = "0xC21F")]
		internal GoogleSignInImpl(GoogleSignInConfiguration configuration)
		{
		/* --- GHIDRA: .ctor ---
		void Google_Impl_GoogleSignInImpl___ctor(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined1 auStack_10 [8];
		  undefined1 auStack_8 [4];
		  undefined4 local_4;
		  
		  Google_Impl_BaseObject___ctor(auStack_8,param1,auStack_10);
		  import::env::GoogleSignIn_EnableDebugLogging(local_4,param2);
		  return;
		}
		*/

		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078E2")]
		[Address(RVA = "0xC220", Offset = "0xC220", VA = "0xC220", Slot = "8")]
		public void EnableDebugLogging(bool flag)
		{
		/* --- GHIDRA: EnableDebugLogging ---
		undefined4 Google_Impl_GoogleSignInImpl__EnableDebugLogging(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  undefined1 auStack_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54e9b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Future_GoogleSignInUser___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Future_GoogleSignInUser__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Google_Impl_NativeFuture_TypeInfo);
		    DAT_ram_00a54e9b = '\x01';
		  }
		  Google_Impl_BaseObject___ctor(&local_8,param1,auStack_10);
		  uVar1 = import::env::GoogleSignIn_SignIn(local_8._4_4_);
		  param2_00 = unnamed_function_1417(Google_Impl_NativeFuture_TypeInfo);
		  if (DAT_ram_00a54e9d == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Impl_BaseObject_TypeInfo);
		    DAT_ram_00a54e9d = '\x01';
		  }
		  if (*(int *)(Google_Impl_BaseObject_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_Impl_BaseObject_TypeInfo);
		  }
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty(&local_8,param2_00,uVar1,0);
		  *(undefined8 *)(param2_00 + 8) = local_8;
		  uVar1 = unnamed_function_1417(Google_Future_GoogleSignInUser__TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,param2_00,Method_Google_Future_GoogleSignInUser___ctor__);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060078E3 RID: 30947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60078E3")]
		[Address(RVA = "0xC221", Offset = "0xC221", VA = "0xC221", Slot = "6")]
		public Future<GoogleSignInUser> SignIn()
		{
		/* --- GHIDRA: SignIn ---
		undefined4 Google_Impl_GoogleSignInImpl__SignIn(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  undefined1 auStack_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54e9c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Future_GoogleSignInUser___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Future_GoogleSignInUser__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Google_Impl_NativeFuture_TypeInfo);
		    DAT_ram_00a54e9c = '\x01';
		  }
		  Google_Impl_BaseObject___ctor(&local_8,param1,auStack_10);
		  uVar1 = import::env::GoogleSignIn_SignInSilently(local_8._4_4_);
		  param2_00 = unnamed_function_1417(Google_Impl_NativeFuture_TypeInfo);
		  if (DAT_ram_00a54e9d == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Impl_BaseObject_TypeInfo);
		    DAT_ram_00a54e9d = '\x01';
		  }
		  if (*(int *)(Google_Impl_BaseObject_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_Impl_BaseObject_TypeInfo);
		  }
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty(&local_8,param2_00,uVar1,0);
		  *(undefined8 *)(param2_00 + 8) = local_8;
		  uVar1 = unnamed_function_1417(Google_Future_GoogleSignInUser__TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,param2_00,Method_Google_Future_GoogleSignInUser___ctor__);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060078E4 RID: 30948 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60078E4")]
		[Address(RVA = "0xC222", Offset = "0xC222", VA = "0xC222", Slot = "7")]
		public Future<GoogleSignInUser> SignInSilently()
		{
		/* --- GHIDRA: SignInSilently ---
		void Google_Impl_GoogleSignInImpl__SignInSilently(undefined4 param1,undefined4 param2)
		
		{
		  undefined1 auStack_10 [8];
		  undefined1 auStack_8 [4];
		  undefined4 local_4;
		  
		  Google_Impl_BaseObject___ctor(auStack_8,param1,auStack_10);
		  import::env::GoogleSignIn_Signout(local_4);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078E5")]
		[Address(RVA = "0xC223", Offset = "0xC223", VA = "0xC223", Slot = "9")]
		public void SignOut()
		{
		/* --- GHIDRA: SignOut ---
		void Google_Impl_GoogleSignInImpl__SignOut(undefined4 param1,undefined4 param2)
		
		{
		  undefined1 auStack_10 [8];
		  undefined1 auStack_8 [4];
		  undefined4 local_4;
		  
		  Google_Impl_BaseObject___ctor(auStack_8,param1,auStack_10);
		  import::env::GoogleSignIn_Disconnect(local_4);
		  return;
		}
		*/

		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078E6")]
		[Address(RVA = "0xC224", Offset = "0xC224", VA = "0xC224", Slot = "10")]
		public void Disconnect()
		{
		/* --- GHIDRA: Disconnect ---
		undefined4 Google_Impl_GoogleSignInImpl__Disconnect(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = import::env::GoogleSignIn_Create(param1);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060078E7 RID: 30951
		[Token(Token = "0x60078E7")]
		[Address(RVA = "0xC225", Offset = "0xC225", VA = "0xC225")]
		[PreserveSig]
		private static extern IntPtr GoogleSignIn_Create(IntPtr data);

		// Token: 0x060078E8 RID: 30952
		[Token(Token = "0x60078E8")]
		[Address(RVA = "0xC226", Offset = "0xC226", VA = "0xC226")]
		[PreserveSig]
		private static extern void GoogleSignIn_EnableDebugLogging(HandleRef self, bool flag);

		// Token: 0x060078E9 RID: 30953
		[Token(Token = "0x60078E9")]
		[Address(RVA = "0xC227", Offset = "0xC227", VA = "0xC227")]
		[PreserveSig]
		private static extern bool GoogleSignIn_Configure(HandleRef self, bool useGameSignIn, string webClientId, bool requestAuthCode, bool forceTokenRefresh, bool requestEmail, bool requestIdToken, bool hidePopups, string[] additionalScopes, int scopeCount, string accountName);

		// Token: 0x060078EA RID: 30954
		[Token(Token = "0x60078EA")]
		[Address(RVA = "0xC228", Offset = "0xC228", VA = "0xC228")]
		[PreserveSig]
		private static extern IntPtr GoogleSignIn_SignIn(HandleRef self);

		// Token: 0x060078EB RID: 30955
		[Token(Token = "0x60078EB")]
		[Address(RVA = "0xC229", Offset = "0xC229", VA = "0xC229")]
		[PreserveSig]
		private static extern IntPtr GoogleSignIn_SignInSilently(HandleRef self);

		// Token: 0x060078EC RID: 30956
		[Token(Token = "0x60078EC")]
		[Address(RVA = "0xC22A", Offset = "0xC22A", VA = "0xC22A")]
		[PreserveSig]
		private static extern void GoogleSignIn_Signout(HandleRef self);

		// Token: 0x060078ED RID: 30957
		[Token(Token = "0x60078ED")]
		[Address(RVA = "0xC22B", Offset = "0xC22B", VA = "0xC22B")]
		[PreserveSig]
		private static extern void GoogleSignIn_Disconnect(HandleRef self);

		// Token: 0x060078EE RID: 30958
		[Token(Token = "0x60078EE")]
		[Address(RVA = "0xC22C", Offset = "0xC22C", VA = "0xC22C")]
		[PreserveSig]
		internal static extern void GoogleSignIn_DisposeFuture(HandleRef self);

		// Token: 0x060078EF RID: 30959
		[Token(Token = "0x60078EF")]
		[Address(RVA = "0xC22D", Offset = "0xC22D", VA = "0xC22D")]
		[PreserveSig]
		internal static extern bool GoogleSignIn_Pending(HandleRef self);

		// Token: 0x060078F0 RID: 30960
		[Token(Token = "0x60078F0")]
		[Address(RVA = "0xC22E", Offset = "0xC22E", VA = "0xC22E")]
		[PreserveSig]
		internal static extern IntPtr GoogleSignIn_Result(HandleRef self);

		// Token: 0x060078F1 RID: 30961
		[Token(Token = "0x60078F1")]
		[Address(RVA = "0xC22F", Offset = "0xC22F", VA = "0xC22F")]
		[PreserveSig]
		internal static extern int GoogleSignIn_Status(HandleRef self);

		// Token: 0x060078F2 RID: 30962
		[Token(Token = "0x60078F2")]
		[Address(RVA = "0xC230", Offset = "0xC230", VA = "0xC230")]
		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetServerAuthCode(HandleRef self, [In] [Out] byte[] bytes, UIntPtr len);

		// Token: 0x060078F3 RID: 30963
		[Token(Token = "0x60078F3")]
		[Address(RVA = "0xC231", Offset = "0xC231", VA = "0xC231")]
		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetDisplayName(HandleRef self, [In] [Out] byte[] bytes, UIntPtr len);

		// Token: 0x060078F4 RID: 30964
		[Token(Token = "0x60078F4")]
		[Address(RVA = "0xC232", Offset = "0xC232", VA = "0xC232")]
		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetEmail(HandleRef self, [In] [Out] byte[] bytes, UIntPtr len);

		// Token: 0x060078F5 RID: 30965
		[Token(Token = "0x60078F5")]
		[Address(RVA = "0xC233", Offset = "0xC233", VA = "0xC233")]
		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetFamilyName(HandleRef self, [In] [Out] byte[] bytes, UIntPtr len);

		// Token: 0x060078F6 RID: 30966
		[Token(Token = "0x60078F6")]
		[Address(RVA = "0xC234", Offset = "0xC234", VA = "0xC234")]
		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetGivenName(HandleRef self, [In] [Out] byte[] bytes, UIntPtr len);

		// Token: 0x060078F7 RID: 30967
		[Token(Token = "0x60078F7")]
		[Address(RVA = "0xC235", Offset = "0xC235", VA = "0xC235")]
		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetIdToken(HandleRef self, [In] [Out] byte[] bytes, UIntPtr len);

		// Token: 0x060078F8 RID: 30968
		[Token(Token = "0x60078F8")]
		[Address(RVA = "0xC236", Offset = "0xC236", VA = "0xC236")]
		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetImageUrl(HandleRef self, [In] [Out] byte[] bytes, UIntPtr len);

		// Token: 0x060078F9 RID: 30969
		[Token(Token = "0x60078F9")]
		[Address(RVA = "0xC237", Offset = "0xC237", VA = "0xC237")]
		[PreserveSig]
		internal static extern UIntPtr GoogleSignIn_GetUserId(HandleRef self, [In] [Out] byte[] bytes, UIntPtr len);

		// Token: 0x060078FA RID: 30970 RVA: 0x00016398 File Offset: 0x00014598
		[Token(Token = "0x60078FA")]
		[Address(RVA = "0xC238", Offset = "0xC238", VA = "0xC238")]
		private static IntPtr GetPlayerActivity()
		{
		/* --- GHIDRA: GetPlayerActivity ---
		void Google_Impl_GoogleSignInImpl__GetPlayerActivity(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54e9d == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Impl_BaseObject_TypeInfo);
		    DAT_ram_00a54e9d = '\x01';
		  }
		  if (*(int *)(Google_Impl_BaseObject_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_Impl_BaseObject_TypeInfo);
		  }
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty(&local_8,param1,param2,0);
		  *(undefined8 *)(param1 + 8) = local_8;
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x04003F39 RID: 16185
		[Token(Token = "0x4003F39")]
		private const string DllName = "__Internal";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: GoogleSignIn_Create ---
		void Google_Impl_GoogleSignInImpl__GoogleSignIn_Create
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  import::env::GoogleSignIn_EnableDebugLogging(*(undefined4 *)(param1 + 4),param2);
		  return;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_EnableDebugLogging ---
		uint Google_Impl_GoogleSignInImpl__GoogleSignIn_EnableDebugLogging
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8,int param9,undefined4 param10,
		               undefined4 param11,undefined4 param12)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  void *param9_00;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 *puVar5;
		  
		  param1_00 = *(undefined4 *)(param1 + 4);
		  param3_00 = unnamed_function_1428(param3);
		  if (param9 == 0) {
		    param9_00 = (void *)0x0;
		  }
		  else {
		    iVar1 = 0;
		    iVar3 = *(int *)(param9 + 0xc);
		    param9_00 = export::malloc(iVar3 * 4 + 4);
		    *(undefined4 *)((int)param9_00 + iVar3 * 4) = 0;
		    if (0 < iVar3) {
		      do {
		        uVar2 = unnamed_function_1428(*(undefined4 *)(iVar1 * 4 + param9 + 0x10));
		        *(undefined4 *)((int)param9_00 + iVar1 * 4) = uVar2;
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != iVar3);
		    }
		  }
		  uVar2 = unnamed_function_1428(param11);
		  iVar1 = import::env::GoogleSignIn_Configure
		                    (param1_00,param2,param3_00,param4,param5,param6,param7,param8,param9_00,param10
		                     ,uVar2);
		  unnamed_function_1427(param3_00);
		  if (param9_00 != (void *)0x0) {
		    if (param9 != 0) {
		      iVar3 = 0;
		      iVar4 = *(int *)(param9 + 0xc);
		      if (0 < iVar4) {
		        do {
		          puVar5 = (undefined4 *)((int)param9_00 + iVar3 * 4);
		          unnamed_function_1427(*puVar5);
		          *puVar5 = 0;
		          iVar3 = iVar3 + 1;
		        } while (iVar3 != iVar4);
		      }
		    }
		    unnamed_function_1427(param9_00);
		  }
		  unnamed_function_1427(uVar2);
		  return (uint)(iVar1 != 0);
		}
		*/


		/* --- GHIDRA: GoogleSignIn_Configure ---
		undefined4 Google_Impl_GoogleSignInImpl__GoogleSignIn_Configure(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = import::env::GoogleSignIn_SignIn(*(undefined4 *)(param1 + 4));
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_SignIn ---
		undefined4 Google_Impl_GoogleSignInImpl__GoogleSignIn_SignIn(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = import::env::GoogleSignIn_SignInSilently(*(undefined4 *)(param1 + 4));
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_SignInSilently ---
		void Google_Impl_GoogleSignInImpl__GoogleSignIn_SignInSilently(int param1,undefined4 param2)
		
		{
		  import::env::GoogleSignIn_Signout(*(undefined4 *)(param1 + 4));
		  return;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_Signout ---
		void Google_Impl_GoogleSignInImpl__GoogleSignIn_Signout(int param1,undefined4 param2)
		
		{
		  import::env::GoogleSignIn_Disconnect(*(undefined4 *)(param1 + 4));
		  return;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_Disconnect ---
		void Google_Impl_GoogleSignInImpl__GoogleSignIn_Disconnect(int param1,undefined4 param2)
		
		{
		  import::env::GoogleSignIn_DisposeFuture(*(undefined4 *)(param1 + 4));
		  return;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_DisposeFuture ---
		uint Google_Impl_GoogleSignInImpl__GoogleSignIn_DisposeFuture(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = import::env::GoogleSignIn_Pending(*(undefined4 *)(param1 + 4));
		  return (uint)(iVar1 != 0);
		}
		*/


		/* --- GHIDRA: GoogleSignIn_Pending ---
		undefined4 Google_Impl_GoogleSignInImpl__GoogleSignIn_Pending(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = import::env::GoogleSignIn_Result(*(undefined4 *)(param1 + 4));
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_Result ---
		undefined4 Google_Impl_GoogleSignInImpl__GoogleSignIn_Result(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = import::env::GoogleSignIn_Status(*(undefined4 *)(param1 + 4));
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_Status ---
		undefined4
		Google_Impl_GoogleSignInImpl__GoogleSignIn_Status
		          (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  param2_00 = param2 + 0x10;
		  if (param2 == 0) {
		    param2_00 = 0;
		  }
		  uVar1 = import::env::GoogleSignIn_GetServerAuthCode(*(undefined4 *)(param1 + 4),param2_00,param3);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_GetServerAuthCode ---
		undefined4
		Google_Impl_GoogleSignInImpl__GoogleSignIn_GetServerAuthCode
		          (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  param2_00 = param2 + 0x10;
		  if (param2 == 0) {
		    param2_00 = 0;
		  }
		  uVar1 = import::env::GoogleSignIn_GetDisplayName(*(undefined4 *)(param1 + 4),param2_00,param3);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_GetDisplayName ---
		undefined4
		Google_Impl_GoogleSignInImpl__GoogleSignIn_GetDisplayName
		          (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  param2_00 = param2 + 0x10;
		  if (param2 == 0) {
		    param2_00 = 0;
		  }
		  uVar1 = import::env::GoogleSignIn_GetEmail(*(undefined4 *)(param1 + 4),param2_00,param3);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_GetEmail ---
		undefined4
		Google_Impl_GoogleSignInImpl__GoogleSignIn_GetEmail
		          (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  param2_00 = param2 + 0x10;
		  if (param2 == 0) {
		    param2_00 = 0;
		  }
		  uVar1 = import::env::GoogleSignIn_GetFamilyName(*(undefined4 *)(param1 + 4),param2_00,param3);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_GetFamilyName ---
		undefined4
		Google_Impl_GoogleSignInImpl__GoogleSignIn_GetFamilyName
		          (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  param2_00 = param2 + 0x10;
		  if (param2 == 0) {
		    param2_00 = 0;
		  }
		  uVar1 = import::env::GoogleSignIn_GetGivenName(*(undefined4 *)(param1 + 4),param2_00,param3);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_GetGivenName ---
		undefined4
		Google_Impl_GoogleSignInImpl__GoogleSignIn_GetGivenName
		          (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  param2_00 = param2 + 0x10;
		  if (param2 == 0) {
		    param2_00 = 0;
		  }
		  uVar1 = import::env::GoogleSignIn_GetIdToken(*(undefined4 *)(param1 + 4),param2_00,param3);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_GetIdToken ---
		undefined4
		Google_Impl_GoogleSignInImpl__GoogleSignIn_GetIdToken
		          (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  param2_00 = param2 + 0x10;
		  if (param2 == 0) {
		    param2_00 = 0;
		  }
		  uVar1 = import::env::GoogleSignIn_GetImageUrl(*(undefined4 *)(param1 + 4),param2_00,param3);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GoogleSignIn_GetImageUrl ---
		undefined4
		Google_Impl_GoogleSignInImpl__GoogleSignIn_GetImageUrl
		          (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  
		  param2_00 = param2 + 0x10;
		  if (param2 == 0) {
		    param2_00 = 0;
		  }
		  uVar1 = import::env::GoogleSignIn_GetUserId(*(undefined4 *)(param1 + 4),param2_00,param3);
		  return uVar1;
		}
		*/

}
