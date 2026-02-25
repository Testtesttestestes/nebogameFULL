using System;
using Core.Files;
using Core.Gameplay.Managers.Configuration;
using Il2CppDummyDll;

namespace Core.AssetBundles.Android
{
	// Token: 0x02001115 RID: 4373
	[Token(Token = "0x2001115")]
	public class AssetBundleLoader : AbstractAssetBundleLoader
	{
		// Token: 0x060065FC RID: 26108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065FC")]
		[Address(RVA = "0xB181", Offset = "0xB181", VA = "0xB181")]
		public AssetBundleLoader(IFileManager fileProvider, IPlatformConfigurationProvider configurationProvider, string path, bool cacheOnDevice)
		{
		}

		// Token: 0x0400368B RID: 13963
		[Token(Token = "0x400368B")]
		public const string PLATFORM_NAME = "android";
	}
}
