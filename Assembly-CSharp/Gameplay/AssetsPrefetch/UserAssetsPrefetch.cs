using System;
using System.Collections.Generic;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;

namespace Gameplay.AssetsPrefetch
{
	// Token: 0x02000CC5 RID: 3269
	[Token(Token = "0x2000CC5")]
	public class UserAssetsPrefetch : IDisposable
	{
		// Token: 0x06004F99 RID: 20377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F99")]
		[Address(RVA = "0x9DB4", Offset = "0x9DB4", VA = "0x9DB4")]
		public UserAssetsPrefetch()
		{
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9A")]
		[Address(RVA = "0x9DB5", Offset = "0x9DB5", VA = "0x9DB5")]
		private void Init()
		{
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9B")]
		[Address(RVA = "0x9DB6", Offset = "0x9DB6", VA = "0x9DB6")]
		private void UserOnOnUserAprChangedEvent(AprDicWrapper apr)
		{
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9C")]
		[Address(RVA = "0x1D84", Offset = "0x1D84", VA = "0x1D84")]
		private void CacheAsset(string assetId)
		{
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9D")]
		[Address(RVA = "0x1D86", Offset = "0x1D86", VA = "0x1D86")]
		private void ReleaseAsset(string assetId)
		{
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F9E")]
		[Address(RVA = "0x9DB7", Offset = "0x9DB7", VA = "0x9DB7", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04002B5C RID: 11100
		[Token(Token = "0x4002B5C")]
		[FieldOffset(Offset = "0x8")]
		private List<string> _assetIds;
	}
}
