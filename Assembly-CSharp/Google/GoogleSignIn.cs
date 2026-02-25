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
		}

		// Token: 0x060078B6 RID: 30902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078B6")]
		[Address(RVA = "0xC1F9", Offset = "0xC1F9", VA = "0xC1F9")]
		public void EnableDebugLogging(bool flag)
		{
		}

		// Token: 0x060078B7 RID: 30903 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60078B7")]
		[Address(RVA = "0xC1FA", Offset = "0xC1FA", VA = "0xC1FA")]
		public Task<GoogleSignInUser> SignIn()
		{
			return null;
		}

		// Token: 0x060078B8 RID: 30904 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60078B8")]
		[Address(RVA = "0xC1FB", Offset = "0xC1FB", VA = "0xC1FB")]
		public Task<GoogleSignInUser> SignInSilently()
		{
			return null;
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078B9")]
		[Address(RVA = "0xC1FC", Offset = "0xC1FC", VA = "0xC1FC")]
		public void SignOut()
		{
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078BA")]
		[Address(RVA = "0xC1FD", Offset = "0xC1FD", VA = "0xC1FD")]
		public void Disconnect()
		{
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
}
