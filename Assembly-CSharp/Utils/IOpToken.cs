using System;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	public interface IOpToken : IDisposable
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002AA RID: 682
		[Token(Token = "0x1700006B")]
		object Index { [Token(Token = "0x60002AA")] get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002AB RID: 683
		[Token(Token = "0x1700006C")]
		OpToken.OpTokenStatus Status { [Token(Token = "0x60002AB")] get; }

		// Token: 0x060002AC RID: 684
		[Token(Token = "0x60002AC")]
		void Run();

		// Token: 0x060002AD RID: 685
		[Token(Token = "0x60002AD")]
		void Cancel();
	}
}
