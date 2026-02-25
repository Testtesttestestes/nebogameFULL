using System;
using Core.Application.Managers.Configuration.Curator;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Platforms.UnityEditor.Curator
{
	// Token: 0x020000CB RID: 203
	[Token(Token = "0x20000CB")]
	public class CuratorDataProvider : AbstractCuratorDataProvider
	{
		// Token: 0x0600075E RID: 1886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x5B4D", Offset = "0x5B4D", VA = "0x5B4D")]
		public CuratorDataProvider(ClientPlatform platform, CuratorService service)
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x5B4E", Offset = "0x5B4E", VA = "0x5B4E")]
		public CuratorDataProvider(CuratorData data)
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x5B4F", Offset = "0x5B4F", VA = "0x5B4F", Slot = "13")]
		public override void Commit()
		{
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x5B50", Offset = "0x5B50", VA = "0x5B50", Slot = "11")]
		public override void Run()
		{
		}
	}
}
