using System;
using Core.Application.Managers.Connection;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Utils;

namespace Core.GameTime
{
	// Token: 0x02000EC9 RID: 3785
	[Token(Token = "0x2000EC9")]
	public class ServerTimeProvider : AbstractCurrentTimeProvider
	{
		// Token: 0x06005C2D RID: 23597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C2D")]
		[Address(RVA = "0xA8D6", Offset = "0xA8D6", VA = "0xA8D6", Slot = "6")]
		public override void Dispose()
		{
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C2E")]
		[Address(RVA = "0xA8D7", Offset = "0xA8D7", VA = "0xA8D7")]
		public ServerTimeProvider([NotNull] IPing ping)
		{
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x000108D8 File Offset: 0x0000EAD8
		[Token(Token = "0x6005C2F")]
		[Address(RVA = "0xA8D8", Offset = "0xA8D8", VA = "0xA8D8", Slot = "7")]
		public override ulong GetUnixTimeMilliseconds()
		{
			return 0UL;
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C30")]
		[Address(RVA = "0xA8D9", Offset = "0xA8D9", VA = "0xA8D9", Slot = "9")]
		protected override void HandleStop()
		{
		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C31")]
		[Address(RVA = "0xA8DA", Offset = "0xA8DA", VA = "0xA8DA", Slot = "8")]
		protected override void HandleRun()
		{
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C32")]
		[Address(RVA = "0xA8DB", Offset = "0xA8DB", VA = "0xA8DB")]
		private void Handler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C33")]
		[Address(RVA = "0xA8DC", Offset = "0xA8DC", VA = "0xA8DC")]
		private void SetUnixTime(ulong value)
		{
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005C34")]
		[Address(RVA = "0xA8DD", Offset = "0xA8DD", VA = "0xA8DD", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400325C RID: 12892
		[Token(Token = "0x400325C")]
		[FieldOffset(Offset = "0x10")]
		private readonly OpTokenRepository _tokenRepository;

		// Token: 0x0400325D RID: 12893
		[Token(Token = "0x400325D")]
		[FieldOffset(Offset = "0x14")]
		private IPing _ping;

		// Token: 0x0400325E RID: 12894
		[Token(Token = "0x400325E")]
		[FieldOffset(Offset = "0x18")]
		private ulong _serverUnixTimeMs;

		// Token: 0x0400325F RID: 12895
		[Token(Token = "0x400325F")]
		[FieldOffset(Offset = "0x20")]
		private long _clientUnixTimeMsWhenReady;
	}
}
