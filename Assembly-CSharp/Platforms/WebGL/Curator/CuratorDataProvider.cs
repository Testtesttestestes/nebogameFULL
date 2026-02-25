using System;
using Core.Application.Managers.Configuration.Curator;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Platforms.WebGL.Curator
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	public class CuratorDataProvider : AbstractCuratorDataProvider
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x225D", Offset = "0x225D", VA = "0x225D")]
		public CuratorDataProvider(ClientPlatform platform, CuratorService service)
		{
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x2259", Offset = "0x2259", VA = "0x2259")]
		public CuratorDataProvider(CuratorData data)
		{
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x5B3F", Offset = "0x5B3F", VA = "0x5B3F", Slot = "13")]
		public override void Commit()
		{
		}
	}
}
