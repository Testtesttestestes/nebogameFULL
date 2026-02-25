using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ContextMenu
{
	// Token: 0x02000255 RID: 597
	[Token(Token = "0x2000255")]
	public interface IContextMenu<in T> : IBaseContextMenu
	{
		// Token: 0x06000E75 RID: 3701
		[Token(Token = "0x6000E75")]
		void Show(T options);

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000E76 RID: 3702
		[Token(Token = "0x170001F2")]
		Vector2 MenuSize { [Token(Token = "0x6000E76")] get; }
	}
}
