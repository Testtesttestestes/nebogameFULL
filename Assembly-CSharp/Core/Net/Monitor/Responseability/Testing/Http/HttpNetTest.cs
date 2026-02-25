using System;
using System.Runtime.CompilerServices;
using BestHTTP;
using Core.Net.Monitor.Responseability.Testing.Common;
using Il2CppDummyDll;

namespace Core.Net.Monitor.Responseability.Testing.Http
{
	// Token: 0x02000E9A RID: 3738
	[Token(Token = "0x2000E9A")]
	public class HttpNetTest : INetTest, IDisposable
	{
		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06005AE7 RID: 23271 RVA: 0x00010248 File Offset: 0x0000E448
		[Token(Token = "0x17001285")]
		public long Index
		{
			[Token(Token = "0x6005AE7")]
			[Address(RVA = "0xA7CA", Offset = "0xA7CA", VA = "0xA7CA", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE8")]
		[Address(RVA = "0xA7CB", Offset = "0xA7CB", VA = "0xA7CB", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AE9")]
		[Address(RVA = "0xA7CC", Offset = "0xA7CC", VA = "0xA7CC")]
		public HttpNetTest(Uri url, Configuration configuration, object syncMonitor)
		{
		}

		// Token: 0x06005AEA RID: 23274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AEA")]
		[Address(RVA = "0xA7CD", Offset = "0xA7CD", VA = "0xA7CD")]
		private void Stop()
		{
		}

		// Token: 0x06005AEB RID: 23275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AEB")]
		[Address(RVA = "0xA7CE", Offset = "0xA7CE", VA = "0xA7CE")]
		private void RequestCallback(HTTPRequest request, HTTPResponse response)
		{
		}

		// Token: 0x06005AEC RID: 23276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AEC")]
		[Address(RVA = "0xA7CF", Offset = "0xA7CF", VA = "0xA7CF")]
		private void Complete()
		{
		}

		// Token: 0x06005AED RID: 23277 RVA: 0x00010260 File Offset: 0x0000E460
		[Token(Token = "0x6005AED")]
		[Address(RVA = "0xA7D0", Offset = "0xA7D0", VA = "0xA7D0")]
		private long GetDuration()
		{
			return 0L;
		}

		// Token: 0x06005AEE RID: 23278 RVA: 0x00010278 File Offset: 0x0000E478
		[Token(Token = "0x6005AEE")]
		[Address(RVA = "0xA7D1", Offset = "0xA7D1", VA = "0xA7D1", Slot = "5")]
		public bool IsComplete()
		{
			return default(bool);
		}

		// Token: 0x06005AEF RID: 23279 RVA: 0x00010290 File Offset: 0x0000E490
		[Token(Token = "0x6005AEF")]
		[Address(RVA = "0xA7D2", Offset = "0xA7D2", VA = "0xA7D2")]
		private bool IsFailed()
		{
			return default(bool);
		}

		// Token: 0x06005AF0 RID: 23280 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[Token(Token = "0x6005AF0")]
		[Address(RVA = "0xA7D3", Offset = "0xA7D3", VA = "0xA7D3", Slot = "6")]
		public ResponseAbilityStatus GetStatus()
		{
			return ResponseAbilityStatus.Normal;
		}

		// Token: 0x06005AF1 RID: 23281 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005AF1")]
		[Address(RVA = "0xA7D4", Offset = "0xA7D4", VA = "0xA7D4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040031B3 RID: 12723
		[Token(Token = "0x40031B3")]
		[FieldOffset(Offset = "0x0")]
		private static long _globalIndex;

		// Token: 0x040031B4 RID: 12724
		[Token(Token = "0x40031B4")]
		[FieldOffset(Offset = "0x8")]
		private readonly HTTPRequest _request;

		// Token: 0x040031B5 RID: 12725
		[Token(Token = "0x40031B5")]
		[FieldOffset(Offset = "0xC")]
		private readonly Configuration _configuration;

		// Token: 0x040031B6 RID: 12726
		[Token(Token = "0x40031B6")]
		[FieldOffset(Offset = "0x10")]
		private readonly Uri _url;

		// Token: 0x040031B7 RID: 12727
		[Token(Token = "0x40031B7")]
		[FieldOffset(Offset = "0x14")]
		private readonly object _syncMonitor;

		// Token: 0x040031B9 RID: 12729
		[Token(Token = "0x40031B9")]
		[FieldOffset(Offset = "0x20")]
		private readonly long _startTime;

		// Token: 0x040031BA RID: 12730
		[Token(Token = "0x40031BA")]
		[FieldOffset(Offset = "0x28")]
		private bool _isComplete;

		// Token: 0x040031BB RID: 12731
		[Token(Token = "0x40031BB")]
		[FieldOffset(Offset = "0x30")]
		private long _finishTime;

		// Token: 0x040031BC RID: 12732
		[Token(Token = "0x40031BC")]
		[FieldOffset(Offset = "0x38")]
		private bool _requestIsFailed;
	}
}
