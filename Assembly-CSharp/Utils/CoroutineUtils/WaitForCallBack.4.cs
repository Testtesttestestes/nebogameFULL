using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils.CoroutineUtils
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	public class WaitForCallBack<T1, T2, T3> : MyCustomYieldInstruction
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00002D18 File Offset: 0x00000F18
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		public ValueTuple<T1, T2, T3> Result
		{
			[Token(Token = "0x6000348")]
			[CompilerGenerated]
			get
			{
				return default(ValueTuple<T1, T2, T3>);
			}
			[Token(Token = "0x6000349")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034A")]
		public void CallBack(T1 result1, T2 result2, T3 result3)
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034B")]
		public WaitForCallBack()
		{
		}
	}
}
