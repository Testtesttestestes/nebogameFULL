using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200027F RID: 639
	[Token(Token = "0x200027F")]
	public class UnityInstantiator : IInstantiator
	{
		// Token: 0x06000F41 RID: 3905 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F41")]
		public T Instantiate<T>(T original, Transform container) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F42")]
		[Address(RVA = "0x6175", Offset = "0x6175", VA = "0x6175")]
		public UnityInstantiator()
		{
		}
	}
}
