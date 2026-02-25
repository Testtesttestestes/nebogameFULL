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
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078E2")]
		[Address(RVA = "0xC220", Offset = "0xC220", VA = "0xC220", Slot = "8")]
		public void EnableDebugLogging(bool flag)
		{
		}

		// Token: 0x060078E3 RID: 30947 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60078E3")]
		[Address(RVA = "0xC221", Offset = "0xC221", VA = "0xC221", Slot = "6")]
		public Future<GoogleSignInUser> SignIn()
		{
			return null;
		}

		// Token: 0x060078E4 RID: 30948 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60078E4")]
		[Address(RVA = "0xC222", Offset = "0xC222", VA = "0xC222", Slot = "7")]
		public Future<GoogleSignInUser> SignInSilently()
		{
			return null;
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078E5")]
		[Address(RVA = "0xC223", Offset = "0xC223", VA = "0xC223", Slot = "9")]
		public void SignOut()
		{
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078E6")]
		[Address(RVA = "0xC224", Offset = "0xC224", VA = "0xC224", Slot = "10")]
		public void Disconnect()
		{
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
			return 0;
		}

		// Token: 0x04003F39 RID: 16185
		[Token(Token = "0x4003F39")]
		private const string DllName = "__Internal";
	}
}
