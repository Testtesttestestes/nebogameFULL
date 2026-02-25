using System;
using Core.Application.Managers;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Platforms.WebGL
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	public class DefaultPlatformSigninProvider : AbstractPlatformSigninProvider
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x226B", Offset = "0x226B", VA = "0x226B")]
		public DefaultPlatformSigninProvider(ClientPlatform platform)
		{
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x5B1E", Offset = "0x5B1E", VA = "0x5B1E", Slot = "17")]
		public override UniTask<IPlatformSigninProvider> UpdateSigninRecord()
		{
			return default(UniTask<IPlatformSigninProvider>);
		}
	}
}
