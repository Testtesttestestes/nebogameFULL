using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability.Analysis
{
	// Token: 0x02000E9C RID: 3740
	[Token(Token = "0x2000E9C")]
	public abstract class AbstractAnalysis : IAnalysis, IDisposable
	{
		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06005AF5 RID: 23285 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005AF6 RID: 23286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001287")]
		public Configuration Config
		{
			[Token(Token = "0x6005AF5")]
			[Address(RVA = "0xA7D5", Offset = "0xA7D5", VA = "0xA7D5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AF6")]
			[Address(RVA = "0xA7D6", Offset = "0xA7D6", VA = "0xA7D6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AF7")]
		[Address(RVA = "0xA7D7", Offset = "0xA7D7", VA = "0xA7D7", Slot = "6")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AF8")]
		[Address(RVA = "0xA7D8", Offset = "0xA7D8", VA = "0xA7D8")]
		public AbstractAnalysis(Configuration config)
		{
		}

		// Token: 0x06005AF9 RID: 23289
		[Token(Token = "0x6005AF9")]
		public abstract bool Analyze(IEnumerable<ISrvCommand> value, out double calcValue);
	}
}
