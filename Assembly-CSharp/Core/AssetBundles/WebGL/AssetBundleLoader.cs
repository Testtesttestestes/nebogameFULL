using System;
using Core.Files;
using Core.Gameplay.Managers.Configuration;
using Il2CppDummyDll;

namespace Core.AssetBundles.WebGL
{
	// Token: 0x02001114 RID: 4372
	[Token(Token = "0x2001114")]
	public class AssetBundleLoader : AbstractAssetBundleLoader
	{
		// Token: 0x060065FB RID: 26107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065FB")]
		[Address(RVA = "0x4469", Offset = "0x4469", VA = "0x4469")]
		public AssetBundleLoader(IFileManager fileProvider, IPlatformConfigurationProvider configurationProvider, string path, bool cacheOnDevice)
		{
		}

		// Token: 0x0400368A RID: 13962
		[Token(Token = "0x400368A")]
		public const string PLATFORM_NAME = "webgl";
	}
}
