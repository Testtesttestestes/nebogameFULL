using System;
using Core.Application.Managers;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using OKG.Heavens.External.Common;
using Protocol.Consts;

namespace Platforms.WebGL
{
	// Token: 0x020000C2 RID: 194
	[Token(Token = "0x20000C2")]
	public sealed class PlatformSigninProvider : AbstractPlatformSigninProvider
	{
		// Token: 0x06000739 RID: 1849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x226C", Offset = "0x226C", VA = "0x226C")]
		public PlatformSigninProvider(IAppHolder appHolder, ClientPlatform platform)
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x5B2E", Offset = "0x5B2E", VA = "0x5B2E", Slot = "17")]
		public override UniTask<IPlatformSigninProvider> UpdateSigninRecord()
		{
			return default(UniTask<IPlatformSigninProvider>);
		}

		// Token: 0x020000C3 RID: 195
		[Token(Token = "0x20000C3")]
		[Serializable]
		public class SigninParams
		{
			// Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x5B2F", Offset = "0x5B2F", VA = "0x5B2F")]
			public SigninParams()
			{
			}

			// Token: 0x04000270 RID: 624
			[Token(Token = "0x4000270")]
			[FieldOffset(Offset = "0x8")]
			public int p_id;

			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4000271")]
			[FieldOffset(Offset = "0xC")]
			public string user_id;

			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4000272")]
			[FieldOffset(Offset = "0x10")]
			public string token;
		}
	}
}
