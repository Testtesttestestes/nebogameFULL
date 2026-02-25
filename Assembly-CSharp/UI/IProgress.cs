using System;
using Il2CppDummyDll;

namespace UI
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	public interface IProgress
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600084E RID: 2126
		// (set) Token: 0x0600084F RID: 2127
		[Token(Token = "0x17000107")]
		float Value { [Token(Token = "0x600084E")] get; [Token(Token = "0x600084F")] set; }

		// Token: 0x06000850 RID: 2128
		[Token(Token = "0x6000850")]
		void SetProgress(float current, float total);
	}
}
