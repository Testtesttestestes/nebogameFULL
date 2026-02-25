using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability.Analysis
{
	// Token: 0x02000EA0 RID: 3744
	[Token(Token = "0x2000EA0")]
	public class MedianAnalysis : AbstractAnalysis
	{
		// Token: 0x06005B00 RID: 23296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B00")]
		[Address(RVA = "0xA7DE", Offset = "0xA7DE", VA = "0xA7DE", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B01")]
		[Address(RVA = "0xA7DF", Offset = "0xA7DF", VA = "0xA7DF")]
		public MedianAnalysis(Configuration config)
		{
		}

		// Token: 0x06005B02 RID: 23298 RVA: 0x000102F0 File Offset: 0x0000E4F0
		[Token(Token = "0x6005B02")]
		[Address(RVA = "0xA7E0", Offset = "0xA7E0", VA = "0xA7E0", Slot = "7")]
		public override bool Analyze(IEnumerable<ISrvCommand> value, out double calcValue)
		{
			return default(bool);
		}

		// Token: 0x06005B03 RID: 23299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B03")]
		[Address(RVA = "0x363E", Offset = "0x363E", VA = "0x363E")]
		private void Shift(List<LatencyDto> arr)
		{
		}

		// Token: 0x06005B04 RID: 23300 RVA: 0x00010308 File Offset: 0x0000E508
		[Token(Token = "0x6005B04")]
		[Address(RVA = "0xA7E1", Offset = "0xA7E1", VA = "0xA7E1")]
		private long GetMedian(List<LatencyDto> arr)
		{
			return 0L;
		}

		// Token: 0x040031C1 RID: 12737
		[Token(Token = "0x40031C1")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<LatencyDto> _latencies;
	}
}
