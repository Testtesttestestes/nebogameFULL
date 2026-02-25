using System;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace UI.Windows
{
	// Token: 0x02000273 RID: 627
	[Token(Token = "0x2000273")]
	public interface IWindowWithCloseBackButtons
	{
		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000F0B RID: 3851
		[Token(Token = "0x17000215")]
		Button CloseButton { [Token(Token = "0x6000F0B")] get; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000F0C RID: 3852
		[Token(Token = "0x17000216")]
		Button BackButton { [Token(Token = "0x6000F0C")] get; }

		// Token: 0x06000F0D RID: 3853
		[Token(Token = "0x6000F0D")]
		void Close(WindowCloseReason windowCloseReason);
	}
}
