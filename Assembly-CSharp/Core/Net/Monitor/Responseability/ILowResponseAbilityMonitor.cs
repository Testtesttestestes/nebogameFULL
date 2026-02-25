using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability
{
	// Token: 0x02000E95 RID: 3733
	[Token(Token = "0x2000E95")]
	public interface ILowResponseAbilityMonitor : IDisposable
	{
		// Token: 0x14000223 RID: 547
		// (add) Token: 0x06005AC6 RID: 23238
		// (remove) Token: 0x06005AC7 RID: 23239
		[Token(Token = "0x14000223")]
		event Action<ResponseAbilityStatus> ResponseAbilityChangedEvent;

		// Token: 0x14000224 RID: 548
		// (add) Token: 0x06005AC8 RID: 23240
		// (remove) Token: 0x06005AC9 RID: 23241
		[Token(Token = "0x14000224")]
		event Action<bool> ResponseTimeExceededEvent;

		// Token: 0x06005ACA RID: 23242
		[Token(Token = "0x6005ACA")]
		void Monitor(IEnumerable<ISrvCommand> value);

		// Token: 0x06005ACB RID: 23243
		[Token(Token = "0x6005ACB")]
		void Monitor(ISrvAnswer value);
	}
}
