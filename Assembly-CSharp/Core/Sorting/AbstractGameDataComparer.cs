using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Sorting
{
	// Token: 0x02000E6D RID: 3693
	[Token(Token = "0x2000E6D")]
	public abstract class AbstractGameDataComparer<T> : IGameDataComparer<T>, IComparer<T>
	{
		// Token: 0x06005A13 RID: 23059
		[Token(Token = "0x6005A13")]
		public abstract int Compare(T x, T y);

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06005A14 RID: 23060
		[Token(Token = "0x17001256")]
		public abstract string Title { [Token(Token = "0x6005A14")] get; }

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06005A15 RID: 23061 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		// (set) Token: 0x06005A16 RID: 23062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001257")]
		public bool IsDescending
		{
			[Token(Token = "0x6005A15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005A16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A17")]
		protected AbstractGameDataComparer()
		{
		}
	}
}
