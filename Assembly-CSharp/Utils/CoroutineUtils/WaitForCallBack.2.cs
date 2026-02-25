using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils.CoroutineUtils
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	public class WaitForCallBack<T> : MyCustomYieldInstruction
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007C")]
		public T Result
		{
			[Token(Token = "0x600033F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000340")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000341")]
		public WaitForCallBack()
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000342")]
		public WaitForCallBack(T result)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000343")]
		public void CallBack(T result)
		{
		}
	}
}
