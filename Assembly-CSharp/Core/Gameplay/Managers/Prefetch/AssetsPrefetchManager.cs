using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Gameplay.AssetsPrefetch;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Prefetch
{
	// Token: 0x020011A1 RID: 4513
	[Token(Token = "0x20011A1")]
	public class AssetsPrefetchManager : AbstractPrefetchManager
	{
		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06006B3E RID: 27454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015DE")]
		public override string Name
		{
			[Token(Token = "0x6006B3E")]
			[Address(RVA = "0xB63C", Offset = "0xB63C", VA = "0xB63C", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B3F")]
		[Address(RVA = "0xB63D", Offset = "0xB63D", VA = "0xB63D")]
		public AssetsPrefetchManager(IGame game)
		{
		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B40")]
		[Address(RVA = "0xB63E", Offset = "0xB63E", VA = "0xB63E", Slot = "12")]
		protected override void FetchRequired(out IList<IDisposable> fetchers, out UniTask[] tasks)
		{
		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B41")]
		[Address(RVA = "0xB63F", Offset = "0xB63F", VA = "0xB63F", Slot = "13")]
		protected override void PostFetchRequired(AssetsPrefetch[] fetchers)
		{
		}

		// Token: 0x06006B42 RID: 27458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B42")]
		[Address(RVA = "0xB640", Offset = "0xB640", VA = "0xB640", Slot = "14")]
		protected override void FetchOptionalAssets(out IList<IDisposable> fetchers)
		{
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006B43")]
		[Address(RVA = "0xB641", Offset = "0xB641", VA = "0xB641")]
		private List<AssetDic> GetCultAssets()
		{
			return null;
		}
	}
}
