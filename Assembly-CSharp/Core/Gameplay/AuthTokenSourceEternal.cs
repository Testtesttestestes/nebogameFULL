using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Core.Gameplay
{
	// Token: 0x0200111A RID: 4378
	[Token(Token = "0x200111A")]
	public class AuthTokenSourceEternal : IAuthTokenSource
	{
		// Token: 0x14000248 RID: 584
		// (add) Token: 0x0600669B RID: 26267 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600669C RID: 26268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000248")]
		public event Action<IAuthTokenSource> TokenChangedEvent
		{
			[Token(Token = "0x600669B")]
			[Address(RVA = "0xB21F", Offset = "0xB21F", VA = "0xB21F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600669C")]
			[Address(RVA = "0xB220", Offset = "0xB220", VA = "0xB220")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600669D RID: 26269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600669D")]
		[Address(RVA = "0x225B", Offset = "0x225B", VA = "0x225B")]
		public AuthTokenSourceEternal([NotNull] string token)
		{
		}

		// Token: 0x0600669E RID: 26270 RVA: 0x00013758 File Offset: 0x00011958
		[Token(Token = "0x600669E")]
		[Address(RVA = "0xB221", Offset = "0xB221", VA = "0xB221", Slot = "4")]
		public UniTask<string> GetToken()
		{
			return default(UniTask<string>);
		}

		// Token: 0x0600669F RID: 26271 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600669F")]
		[Address(RVA = "0xB222", Offset = "0xB222", VA = "0xB222", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040036D9 RID: 14041
		[Token(Token = "0x40036D9")]
		[FieldOffset(Offset = "0xC")]
		private readonly string _token;
	}
}
