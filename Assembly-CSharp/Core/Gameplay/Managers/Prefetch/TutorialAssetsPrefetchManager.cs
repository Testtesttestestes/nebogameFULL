using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Gameplay.AssetsPrefetch;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Prefetch
{
	// Token: 0x020011A3 RID: 4515
	[Token(Token = "0x20011A3")]
	public class TutorialAssetsPrefetchManager : AbstractPrefetchManager
	{
		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06006B4B RID: 27467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015DF")]
		public override string Name
		{
			[Token(Token = "0x6006B4B")]
			[Address(RVA = "0xB649", Offset = "0xB649", VA = "0xB649", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B4C RID: 27468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B4C")]
		[Address(RVA = "0xB64A", Offset = "0xB64A", VA = "0xB64A")]
		public TutorialAssetsPrefetchManager(IGame game)
		{
		}

		// Token: 0x06006B4D RID: 27469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B4D")]
		[Address(RVA = "0xB64B", Offset = "0xB64B", VA = "0xB64B", Slot = "12")]
		protected override void FetchRequired(out IList<IDisposable> fetchers, out UniTask[] tasks)
		{
		}

		// Token: 0x06006B4E RID: 27470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B4E")]
		[Address(RVA = "0xB64C", Offset = "0xB64C", VA = "0xB64C", Slot = "13")]
		protected override void PostFetchRequired(AssetsPrefetch[] fetchers)
		{
		}

		// Token: 0x06006B4F RID: 27471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B4F")]
		[Address(RVA = "0xB64D", Offset = "0xB64D", VA = "0xB64D", Slot = "14")]
		protected override void FetchOptionalAssets(out IList<IDisposable> fetchers)
		{
		}
	}
}
