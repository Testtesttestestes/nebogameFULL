using System;
using Il2CppDummyDll;

namespace Utils.Wrappers
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public class JsonWrappers
	{
		// Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x579B", Offset = "0x579B", VA = "0x579B")]
		public JsonWrappers()
		{
		}

		// Token: 0x02000065 RID: 101
		[Token(Token = "0x2000065")]
		public class GenericJsonWrapper<T>
		{
			// Token: 0x0600032B RID: 811 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600032B")]
			public virtual T GetValue(string jsonRaw)
			{
				return null;
			}

			// Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600032C")]
			public GenericJsonWrapper()
			{
			}

			// Token: 0x0400016F RID: 367
			[Token(Token = "0x400016F")]
			[FieldOffset(Offset = "0x0")]
			public T Value;
		}

		// Token: 0x02000066 RID: 102
		[Token(Token = "0x2000066")]
		public class ArrayWrapper<T> : JsonWrappers.GenericJsonWrapper<T[]>
		{
			// Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600032D")]
			public ArrayWrapper()
			{
			}
		}
	}
}
