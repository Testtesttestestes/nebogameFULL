using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability.Analysis
{
	// Token: 0x02000E9D RID: 3741
	[Token(Token = "0x2000E9D")]
	public class AverageAnalysis : AbstractAnalysis
	{
		// Token: 0x06005AFA RID: 23290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AFA")]
		[Address(RVA = "0xA7D9", Offset = "0xA7D9", VA = "0xA7D9")]
		public AverageAnalysis(Configuration config)
		{
		}

		// Token: 0x06005AFB RID: 23291 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[Token(Token = "0x6005AFB")]
		[Address(RVA = "0xA7DA", Offset = "0xA7DA", VA = "0xA7DA", Slot = "7")]
		public override bool Analyze(IEnumerable<ISrvCommand> value, out double calcValue)
		{
			return default(bool);
		}

		// Token: 0x040031BE RID: 12734
		[Token(Token = "0x40031BE")]
		[FieldOffset(Offset = "0xC")]
		private Queue<LatencyDto> _latencies;
	}
}
