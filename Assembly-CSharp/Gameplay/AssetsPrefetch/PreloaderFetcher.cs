using System;
using Core;
using Core.Dict;
using Core.GameTime;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.AssetsPrefetch
{
	// Token: 0x02000CC1 RID: 3265
	[Token(Token = "0x2000CC1")]
	internal class PreloaderFetcher : IDisposable
	{
		// Token: 0x06004F8E RID: 20366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F8E")]
		[Address(RVA = "0x9DAB", Offset = "0x9DAB", VA = "0x9DAB", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06004F8F RID: 20367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F8F")]
		[Address(RVA = "0x9DAC", Offset = "0x9DAC", VA = "0x9DAC")]
		public PreloaderFetcher(ICurrentTimeProvider timeProvider, IDictProvider dictProvider, IGameAssetProvider assetProvider)
		{
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F90")]
		[Address(RVA = "0x1D7A", Offset = "0x1D7A", VA = "0x1D7A")]
		private void Reset()
		{
		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F91")]
		[Address(RVA = "0x9DAD", Offset = "0x9DAD", VA = "0x9DAD")]
		public void Fetch()
		{
		}

		// Token: 0x04002B4E RID: 11086
		[Token(Token = "0x4002B4E")]
		[FieldOffset(Offset = "0x8")]
		private readonly ICurrentTimeProvider _timeProvider;

		// Token: 0x04002B4F RID: 11087
		[Token(Token = "0x4002B4F")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;

		// Token: 0x04002B50 RID: 11088
		[Token(Token = "0x4002B50")]
		[FieldOffset(Offset = "0x10")]
		private readonly IGameAssetProvider _assetProvider;

		// Token: 0x04002B51 RID: 11089
		[Token(Token = "0x4002B51")]
		[FieldOffset(Offset = "0x14")]
		private readonly AssetsPrefetch _assetsPrefetch;

		// Token: 0x04002B52 RID: 11090
		[Token(Token = "0x4002B52")]
		[FieldOffset(Offset = "0x18")]
		private readonly LocalProps _localProps;
	}
}
