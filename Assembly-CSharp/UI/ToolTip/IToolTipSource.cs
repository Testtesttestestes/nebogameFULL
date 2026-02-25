using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip
{
	// Token: 0x0200013A RID: 314
	[Token(Token = "0x200013A")]
	public interface IToolTipSource
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600096B RID: 2411
		[Token(Token = "0x1700013D")]
		IToolTipDataProvider ToolTipDataProvider { [Token(Token = "0x600096B")] get; }

		// Token: 0x0600096C RID: 2412
		[Token(Token = "0x600096C")]
		void GetStartPosition(out Vector3 position);
	}
}
