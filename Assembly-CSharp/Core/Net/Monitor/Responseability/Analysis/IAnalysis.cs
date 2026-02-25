using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability.Analysis
{
	// Token: 0x02000E9F RID: 3743
	[Token(Token = "0x2000E9F")]
	public interface IAnalysis : IDisposable
	{
		// Token: 0x06005AFF RID: 23295
		[Token(Token = "0x6005AFF")]
		bool Analyze(IEnumerable<ISrvCommand> value, out double calcValue);
	}
}
