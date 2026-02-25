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
		}

		// Token: 0x060078FC RID: 30972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078FC")]
		[Address(RVA = "0xC23A", Offset = "0xC23A", VA = "0xC23A", Slot = "5")]
		public override void Dispose()
		{
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
}
