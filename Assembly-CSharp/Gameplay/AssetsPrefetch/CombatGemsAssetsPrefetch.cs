using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.U2D;

namespace Gameplay.AssetsPrefetch
{
	// Token: 0x02000CBD RID: 3261
	[Token(Token = "0x2000CBD")]
	public class CombatGemsAssetsPrefetch : IDisposable
	{
		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06004F80 RID: 20352 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
		// (set) Token: 0x06004F81 RID: 20353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001023")]
		public bool IsDisposed
		{
			[Token(Token = "0x6004F80")]
			[Address(RVA = "0x9D9E", Offset = "0x9D9E", VA = "0x9D9E")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F81")]
			[Address(RVA = "0x9D9F", Offset = "0x9D9F", VA = "0x9D9F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004F82 RID: 20354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F82")]
		[Address(RVA = "0x9DA0", Offset = "0x9DA0", VA = "0x9DA0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06004F83 RID: 20355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F83")]
		[Address(RVA = "0x9DA1", Offset = "0x9DA1", VA = "0x9DA1")]
		public CombatGemsAssetsPrefetch(DictManager dictProvider)
		{
		}

		// Token: 0x06004F84 RID: 20356 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		[Token(Token = "0x6004F84")]
		[Address(RVA = "0x9DA2", Offset = "0x9DA2", VA = "0x9DA2")]
		public bool TryGetGemsSpriteAtlas(uint setId, out SpriteAtlas atlas)
		{
			return default(bool);
		}

		// Token: 0x06004F85 RID: 20357 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		[Token(Token = "0x6004F85")]
		[Address(RVA = "0x220A", Offset = "0x220A", VA = "0x220A")]
		public UniTask Fetch()
		{
			return default(UniTask);
		}

		// Token: 0x06004F86 RID: 20358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F86")]
		[Address(RVA = "0x9DA3", Offset = "0x9DA3", VA = "0x9DA3")]
		private void CheckIfReady(UniTaskCompletionSource completionSource)
		{
		}

		// Token: 0x04002B42 RID: 11074
		[Token(Token = "0x4002B42")]
		[FieldOffset(Offset = "0x8")]
		public readonly DictManager DictProvider;

		// Token: 0x04002B43 RID: 11075
		[Token(Token = "0x4002B43")]
		[FieldOffset(Offset = "0xC")]
		private UniTaskCompletionSource _fetchCompletionSource;

		// Token: 0x04002B44 RID: 11076
		[Token(Token = "0x4002B44")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<uint, CombatGemsAssetsPrefetch.GemsSpriteAtlasVo> _gemsSpriteAtlas;

		// Token: 0x04002B45 RID: 11077
		[Token(Token = "0x4002B45")]
		[FieldOffset(Offset = "0x14")]
		private int _gemsSpriteAtlasсCurrentProgress;

		// Token: 0x04002B46 RID: 11078
		[Token(Token = "0x4002B46")]
		[FieldOffset(Offset = "0x18")]
		private int _gemsSpriteAtlasсTotalProgress;

		// Token: 0x02000CBE RID: 3262
		[Token(Token = "0x2000CBE")]
		private class GemsSpriteAtlasVo
		{
			// Token: 0x06004F89 RID: 20361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004F89")]
			[Address(RVA = "0x9DA6", Offset = "0x9DA6", VA = "0x9DA6")]
			public GemsSpriteAtlasVo(uint setId, string path, SpriteAtlas atlas)
			{
			}

			// Token: 0x04002B48 RID: 11080
			[Token(Token = "0x4002B48")]
			[FieldOffset(Offset = "0x8")]
			public readonly uint SetId;

			// Token: 0x04002B49 RID: 11081
			[Token(Token = "0x4002B49")]
			[FieldOffset(Offset = "0xC")]
			public readonly SpriteAtlas Atlas;

			// Token: 0x04002B4A RID: 11082
			[Token(Token = "0x4002B4A")]
			[FieldOffset(Offset = "0x10")]
			public readonly string Path;
		}
	}
}
