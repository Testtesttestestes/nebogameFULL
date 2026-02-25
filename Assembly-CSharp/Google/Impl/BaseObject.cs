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
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x00016380 File Offset: 0x00014580
		[Token(Token = "0x60078D9")]
		[Address(RVA = "0xC217", Offset = "0xC217", VA = "0xC217")]
		protected HandleRef SelfPtr()
		{
			return default(HandleRef);
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60078DA")]
		[Address(RVA = "0xC218", Offset = "0xC218", VA = "0xC218", Slot = "5")]
		public virtual void Dispose()
		{
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
