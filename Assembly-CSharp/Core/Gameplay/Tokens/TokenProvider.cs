using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Tokenator;
using ServicesNamespace;
using Utils;

namespace Core.Gameplay.Tokens
{
	// Token: 0x0200112C RID: 4396
	[Token(Token = "0x200112C")]
	public class TokenProvider : ITokenProvider, IDisposable
	{
		// Token: 0x0600670B RID: 26379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670B")]
		[Address(RVA = "0xB243", Offset = "0xB243", VA = "0xB243")]
		public TokenProvider(string clientId, string scope, TokenatorService tokenatorService)
		{
		}

		// Token: 0x0600670C RID: 26380 RVA: 0x00013788 File Offset: 0x00011988
		[Token(Token = "0x600670C")]
		[Address(RVA = "0xB244", Offset = "0xB244", VA = "0xB244", Slot = "4")]
		public UniTask<string> GetTokenAsync()
		{
			return default(UniTask<string>);
		}

		// Token: 0x0600670D RID: 26381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670D")]
		[Address(RVA = "0xB245", Offset = "0xB245", VA = "0xB245")]
		private void GetTokenResultHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x0600670E RID: 26382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670E")]
		[Address(RVA = "0xB246", Offset = "0xB246", VA = "0xB246", Slot = "5")]
		public void Cancel()
		{
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600670F")]
		[Address(RVA = "0xB247", Offset = "0xB247", VA = "0xB247", Slot = "6")]
		private void Dispose()
		{
		}

		// Token: 0x040036EF RID: 14063
		[Token(Token = "0x40036EF")]
		[FieldOffset(Offset = "0x8")]
		private readonly string _scope;

		// Token: 0x040036F0 RID: 14064
		[Token(Token = "0x40036F0")]
		[FieldOffset(Offset = "0xC")]
		private readonly string _clientId;

		// Token: 0x040036F1 RID: 14065
		[Token(Token = "0x40036F1")]
		[FieldOffset(Offset = "0x10")]
		private TokenatorService _service;

		// Token: 0x040036F2 RID: 14066
		[Token(Token = "0x40036F2")]
		[FieldOffset(Offset = "0x14")]
		private GenIDTokenCmd.Types.Ans _token;

		// Token: 0x040036F3 RID: 14067
		[Token(Token = "0x40036F3")]
		[FieldOffset(Offset = "0x18")]
		private BackTime _backtime;

		// Token: 0x040036F4 RID: 14068
		[Token(Token = "0x40036F4")]
		[FieldOffset(Offset = "0x1C")]
		private CancellationTokenSource _cancellationSource;

		// Token: 0x040036F5 RID: 14069
		[Token(Token = "0x40036F5")]
		[FieldOffset(Offset = "0x20")]
		private UniTaskCompletionSource<string> _completionSource;
	}
}
