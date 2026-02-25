using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Gameplay.AssetsPrefetch;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Prefetch
{
	// Token: 0x0200119E RID: 4510
	[Token(Token = "0x200119E")]
	public abstract class AbstractPrefetchManager : IGameManager, IBaseManager
	{
		// Token: 0x140002BC RID: 700
		// (add) Token: 0x06006B29 RID: 27433 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006B2A RID: 27434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002BC")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006B29")]
			[Address(RVA = "0xB62C", Offset = "0xB62C", VA = "0xB62C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006B2A")]
			[Address(RVA = "0xB62D", Offset = "0xB62D", VA = "0xB62D", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002BD RID: 701
		// (add) Token: 0x06006B2B RID: 27435 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006B2C RID: 27436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002BD")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006B2B")]
			[Address(RVA = "0xB62E", Offset = "0xB62E", VA = "0xB62E", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006B2C")]
			[Address(RVA = "0xB62F", Offset = "0xB62F", VA = "0xB62F", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06006B2D RID: 27437 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006B2E RID: 27438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015DC")]
		private protected IGame Game
		{
			[Token(Token = "0x6006B2D")]
			[Address(RVA = "0xB630", Offset = "0xB630", VA = "0xB630")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6006B2E")]
			[Address(RVA = "0xB631", Offset = "0xB631", VA = "0xB631")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006B2F RID: 27439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B2F")]
		[Address(RVA = "0xB632", Offset = "0xB632", VA = "0xB632")]
		protected AbstractPrefetchManager(IGame game)
		{
		}

		// Token: 0x06006B30 RID: 27440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B30")]
		[Address(RVA = "0xB633", Offset = "0xB633", VA = "0xB633", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B31")]
		[Address(RVA = "0xB634", Offset = "0xB634", VA = "0xB634", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006B32 RID: 27442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B32")]
		[Address(RVA = "0xB635", Offset = "0xB635", VA = "0xB635")]
		private void FetchRequiredInternal()
		{
		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B33")]
		[Address(RVA = "0xB636", Offset = "0xB636", VA = "0xB636")]
		private void FetchOptionalAssetsInternal()
		{
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06006B34 RID: 27444
		[Token(Token = "0x170015DD")]
		public abstract string Name { [Token(Token = "0x6006B34")] get; }

		// Token: 0x06006B35 RID: 27445
		[Token(Token = "0x6006B35")]
		protected abstract void FetchRequired(out IList<IDisposable> fetchers, out UniTask[] tasks);

		// Token: 0x06006B36 RID: 27446
		[Token(Token = "0x6006B36")]
		protected abstract void PostFetchRequired(AssetsPrefetch[] fetchers);

		// Token: 0x06006B37 RID: 27447
		[Token(Token = "0x6006B37")]
		protected abstract void FetchOptionalAssets(out IList<IDisposable> fetchers);

		// Token: 0x0400389D RID: 14493
		[Token(Token = "0x400389D")]
		[FieldOffset(Offset = "0x10")]
		public readonly CombatGemsAssetsPrefetch CombatGemsAssetsPrefetch;

		// Token: 0x0400389E RID: 14494
		[Token(Token = "0x400389E")]
		[FieldOffset(Offset = "0x14")]
		private readonly List<IDisposable> _assetsFetchers;
	}
}
