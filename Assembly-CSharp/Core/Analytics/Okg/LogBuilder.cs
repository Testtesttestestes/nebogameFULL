using System;
using System.Collections.Generic;
using Core.Analytics.Okg.Data;
using Il2CppDummyDll;

namespace Core.Analytics.Okg
{
	// Token: 0x020012A0 RID: 4768
	[Token(Token = "0x20012A0")]
	public sealed class LogBuilder : ILogBuilder
	{
		// Token: 0x06007147 RID: 28999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007147")]
		[Address(RVA = "0xBB62", Offset = "0xBB62", VA = "0xBB62")]
		public LogBuilder()
		{
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007148")]
		[Address(RVA = "0xBB63", Offset = "0xBB63", VA = "0xBB63")]
		public LogBuilder(string initialString)
		{
		}

		// Token: 0x06007149 RID: 29001 RVA: 0x00014988 File Offset: 0x00012B88
		[Token(Token = "0x6007149")]
		[Address(RVA = "0xBB64", Offset = "0xBB64", VA = "0xBB64", Slot = "4")]
		public bool AddLine(OkgAnalyticsData record, out string error)
		{
			return default(bool);
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600714A")]
		[Address(RVA = "0xBB65", Offset = "0xBB65", VA = "0xBB65", Slot = "5")]
		public void Clear()
		{
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600714B")]
		[Address(RVA = "0xBB66", Offset = "0xBB66", VA = "0xBB66", Slot = "6")]
		public string Extract()
		{
			return null;
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600714C")]
		[Address(RVA = "0xBB67", Offset = "0xBB67", VA = "0xBB67", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04003B1B RID: 15131
		[Token(Token = "0x4003B1B")]
		[FieldOffset(Offset = "0x8")]
		private string _initialData;

		// Token: 0x04003B1C RID: 15132
		[Token(Token = "0x4003B1C")]
		[FieldOffset(Offset = "0xC")]
		private readonly List<string> _log;
	}
}
