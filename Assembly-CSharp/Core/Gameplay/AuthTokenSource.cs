using System;
using Core.Gameplay.Tokens;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x02001119 RID: 4377
	[Token(Token = "0x2001119")]
	public class AuthTokenSource : IAuthTokenSource
	{
		// Token: 0x06006699 RID: 26265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006699")]
		[Address(RVA = "0xB21D", Offset = "0xB21D", VA = "0xB21D")]
		public AuthTokenSource(ITokenProvider provider)
		{
		}

		// Token: 0x0600669A RID: 26266 RVA: 0x00013740 File Offset: 0x00011940
		[Token(Token = "0x600669A")]
		[Address(RVA = "0xB21E", Offset = "0xB21E", VA = "0xB21E", Slot = "4")]
		public UniTask<string> GetToken()
		{
			return default(UniTask<string>);
		}

		// Token: 0x040036D7 RID: 14039
		[Token(Token = "0x40036D7")]
		[FieldOffset(Offset = "0x8")]
		private ITokenProvider _provider;
	}
}
