using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using UnityEngine;
using UnityEngine.U2D;

namespace Core.Gameplay.Managers.Skins
{
	// Token: 0x02001188 RID: 4488
	[Token(Token = "0x2001188")]
	public class Skin : IDisposable
	{
		// Token: 0x140002B6 RID: 694
		// (add) Token: 0x06006AAD RID: 27309 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006AAE RID: 27310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B6")]
		public event Action<Skin> StopEvent
		{
			[Token(Token = "0x6006AAD")]
			[Address(RVA = "0xB5C6", Offset = "0xB5C6", VA = "0xB5C6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006AAE")]
			[Address(RVA = "0xB5C7", Offset = "0xB5C7", VA = "0xB5C7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006AAF RID: 27311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AAF")]
		[Address(RVA = "0x4455", Offset = "0x4455", VA = "0x4455", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06006AB0 RID: 27312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AB0")]
		[Address(RVA = "0xB5C8", Offset = "0xB5C8", VA = "0xB5C8")]
		private Skin(SkinPackageDic.Types.Skin skin, AssetDic asset)
		{
		}

		// Token: 0x06006AB1 RID: 27313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AB1")]
		[Address(RVA = "0xB5C9", Offset = "0xB5C9", VA = "0xB5C9")]
		private void ThrowDisposedEx()
		{
		}

		// Token: 0x06006AB2 RID: 27314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AB2")]
		[Address(RVA = "0xB5CA", Offset = "0xB5CA", VA = "0xB5CA")]
		private void ThrowWrongAssetKind(string methodName)
		{
		}

		// Token: 0x06006AB3 RID: 27315 RVA: 0x00013A28 File Offset: 0x00011C28
		[Token(Token = "0x6006AB3")]
		[Address(RVA = "0x444A", Offset = "0x444A", VA = "0x444A")]
		private UniTask<SpriteAtlas> GetAtlas(CancellationToken cancellationToken)
		{
			return default(UniTask<SpriteAtlas>);
		}

		// Token: 0x06006AB4 RID: 27316 RVA: 0x00013A40 File Offset: 0x00011C40
		[Token(Token = "0x6006AB4")]
		[Address(RVA = "0xB5CB", Offset = "0xB5CB", VA = "0xB5CB")]
		public bool IsFit(string assetName)
		{
			return default(bool);
		}

		// Token: 0x06006AB5 RID: 27317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AB5")]
		[Address(RVA = "0x4454", Offset = "0x4454", VA = "0x4454")]
		public void RiseStop()
		{
		}

		// Token: 0x06006AB6 RID: 27318 RVA: 0x00013A58 File Offset: 0x00011C58
		[Token(Token = "0x6006AB6")]
		[Address(RVA = "0x1F58", Offset = "0x1F58", VA = "0x1F58")]
		public UniTask<Sprite> GetSprite(string name, CancellationToken cancellationToken)
		{
			return default(UniTask<Sprite>);
		}

		// Token: 0x06006AB7 RID: 27319 RVA: 0x00013A70 File Offset: 0x00011C70
		[Token(Token = "0x6006AB7")]
		[Address(RVA = "0x1F52", Offset = "0x1F52", VA = "0x1F52")]
		public UniTask<string> GetAnimationAssetId(string name, CancellationToken cancellationToken)
		{
			return default(UniTask<string>);
		}

		// Token: 0x06006AB8 RID: 27320 RVA: 0x00013A88 File Offset: 0x00011C88
		[Token(Token = "0x6006AB8")]
		[Address(RVA = "0x1F5B", Offset = "0x1F5B", VA = "0x1F5B")]
		public UniTask<Texture> GetTexture(string name, CancellationToken cancellationToken)
		{
			return default(UniTask<Texture>);
		}

		// Token: 0x0400385D RID: 14429
		[Token(Token = "0x400385D")]
		[FieldOffset(Offset = "0xC")]
		[CanBeNull]
		private Dictionary<string, Texture> _textures;

		// Token: 0x0400385E RID: 14430
		[Token(Token = "0x400385E")]
		[FieldOffset(Offset = "0x10")]
		[CanBeNull]
		private SpriteAtlas _spriteAtlas;

		// Token: 0x0400385F RID: 14431
		[Token(Token = "0x400385F")]
		[FieldOffset(Offset = "0x14")]
		private bool _isDisposed;

		// Token: 0x04003860 RID: 14432
		[Token(Token = "0x4003860")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, UniTaskCompletionSource<SpriteAtlas>> _completionSourcesByPath;

		// Token: 0x04003861 RID: 14433
		[Token(Token = "0x4003861")]
		[FieldOffset(Offset = "0x1C")]
		private readonly SkinPackageDic.Types.Skin _skin;

		// Token: 0x04003862 RID: 14434
		[Token(Token = "0x4003862")]
		[FieldOffset(Offset = "0x20")]
		public readonly AssetDic Asset;

		// Token: 0x02001189 RID: 4489
		[Token(Token = "0x2001189")]
		public class Factory
		{
			// Token: 0x06006AB9 RID: 27321 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6006AB9")]
			[Address(RVA = "0xB5CC", Offset = "0xB5CC", VA = "0xB5CC")]
			public Skin Create(SkinPackageDic.Types.Skin skin, AssetDic asset)
			{
				return null;
			}

			// Token: 0x06006ABA RID: 27322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006ABA")]
			[Address(RVA = "0xB5CD", Offset = "0xB5CD", VA = "0xB5CD")]
			public Factory()
			{
			}
		}
	}
}
