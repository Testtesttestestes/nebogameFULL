using System;
using Core.Application.Managers.Configuration.Curator;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Platforms.Android.Curator
{
	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	public class CuratorDataProvider : AbstractCuratorDataProvider
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x5B57", Offset = "0x5B57", VA = "0x5B57")]
		public CuratorDataProvider(CuratorData data)
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x5B58", Offset = "0x5B58", VA = "0x5B58")]
		public CuratorDataProvider(ClientPlatform platform, CuratorService service)
		{
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x5B59", Offset = "0x5B59", VA = "0x5B59", Slot = "11")]
		public override void Run()
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x5B5A", Offset = "0x5B5A", VA = "0x5B5A", Slot = "13")]
		public override void Commit()
		{
		}

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		public const string CURATOR_BOOT_DATA_NAME = "CURATOR_BOOT_DATA";

		// Token: 0x020000D1 RID: 209
		[Token(Token = "0x20000D1")]
		[Serializable]
		private class BootData
		{
			// Token: 0x0600076D RID: 1901 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x5B5C", Offset = "0x5B5C", VA = "0x5B5C")]
			public BootData(string endpoint, string server, string sourceHost)
			{
			}

			// Token: 0x0600076E RID: 1902 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x5B5D", Offset = "0x5B5D", VA = "0x5B5D", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000297 RID: 663
			[Token(Token = "0x4000297")]
			[FieldOffset(Offset = "0x8")]
			public string Endpoint;

			// Token: 0x04000298 RID: 664
			[Token(Token = "0x4000298")]
			[FieldOffset(Offset = "0xC")]
			public string Server;

			// Token: 0x04000299 RID: 665
			[Token(Token = "0x4000299")]
			[FieldOffset(Offset = "0x10")]
			public string SourceHost;
		}
	}
}
