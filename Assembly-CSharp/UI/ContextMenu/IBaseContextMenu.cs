using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ContextMenu
{
	// Token: 0x02000254 RID: 596
	[Token(Token = "0x2000254")]
	public interface IBaseContextMenu
	{
		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000E73 RID: 3699
		[Token(Token = "0x170001F0")]
		GameObject gameObject { [Token(Token = "0x6000E73")] get; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000E74 RID: 3700
		[Token(Token = "0x170001F1")]
		Transform transform { [Token(Token = "0x6000E74")] get; }
	}
}
