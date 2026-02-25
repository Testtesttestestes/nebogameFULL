using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core
{
	// Token: 0x02000E5D RID: 3677
	[Token(Token = "0x2000E5D")]
	public interface IGameAssetProvider
	{
		// Token: 0x060059F8 RID: 23032
		[Token(Token = "0x60059F8")]
		AssetDic GetAsset(string assetId);

		// Token: 0x060059F9 RID: 23033
		[Token(Token = "0x60059F9")]
		string GetAssetPath(string assetId);
	}
}
