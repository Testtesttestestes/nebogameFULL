using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x02000271 RID: 625
	[Token(Token = "0x2000271")]
	public interface IInstantiator
	{
		// Token: 0x06000F01 RID: 3841
		[Token(Token = "0x6000F01")]
		T Instantiate<T>(T original, Transform container) where T : UnityEngine.Object;
	}
}
