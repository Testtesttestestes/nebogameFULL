using System;
using System.Collections;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Google
{
	// Token: 0x020013C7 RID: 5063
	[Token(Token = "0x20013C7")]
	public class Future<T>
	{
		// Token: 0x060078A5 RID: 30885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078A5")]
		internal Future(FutureAPIImpl<T> impl)
		{
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x060078A6 RID: 30886 RVA: 0x00016308 File Offset: 0x00014508
		[Token(Token = "0x170017E4")]
		public bool Pending
		{
			[Token(Token = "0x60078A6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x060078A7 RID: 30887 RVA: 0x00016320 File Offset: 0x00014520
		[Token(Token = "0x170017E5")]
		private GoogleSignInStatusCode Status
		{
			[Token(Token = "0x60078A7")]
			get
			{
				return GoogleSignInStatusCode.Success;
			}
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x060078A8 RID: 30888 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017E6")]
		private T Result
		{
			[Token(Token = "0x60078A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60078A9")]
		internal IEnumerator WaitForResult(TaskCompletionSource<T> tcs)
		{
			return null;
		}

		// Token: 0x04003F10 RID: 16144
		[Token(Token = "0x4003F10")]
		[FieldOffset(Offset = "0x0")]
		private FutureAPIImpl<T> apiImpl;
	}
}
