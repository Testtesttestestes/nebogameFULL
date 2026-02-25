using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils.CoroutineUtils
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	public class WaitForCallBack<T1, T2> : MyCustomYieldInstruction
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00002D00 File Offset: 0x00000F00
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007D")]
		public ValueTuple<T1, T2> Result
		{
			[Token(Token = "0x6000344")]
			[CompilerGenerated]
			get
			{
				return default(ValueTuple<T1, T2>);
			}
			[Token(Token = "0x6000345")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000346")]
		public void CallBack(T1 result1, T2 result2)
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000347")]
		public WaitForCallBack()
		{
		}
	}
}
