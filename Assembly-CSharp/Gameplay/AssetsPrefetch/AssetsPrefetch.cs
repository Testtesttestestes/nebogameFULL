using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.AssetsPrefetch
{
	// Token: 0x02000CB7 RID: 3255
	[Token(Token = "0x2000CB7")]
	public class AssetsPrefetch : IDisposable
	{
		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06004F5B RID: 20315 RVA: 0x0000E928 File Offset: 0x0000CB28
		// (set) Token: 0x06004F5C RID: 20316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001020")]
		private bool IsDisposed
		{
			[Token(Token = "0x6004F5B")]
			[Address(RVA = "0x9D83", Offset = "0x9D83", VA = "0x9D83")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F5C")]
			[Address(RVA = "0x9D84", Offset = "0x9D84", VA = "0x9D84")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004F5D RID: 20317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F5D")]
		[Address(RVA = "0x9D85", Offset = "0x9D85", VA = "0x9D85", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06004F5E RID: 20318 RVA: 0x0000E940 File Offset: 0x0000CB40
		[Token(Token = "0x6004F5E")]
		[Address(RVA = "0x1D7E", Offset = "0x1D7E", VA = "0x1D7E")]
		public UniTask Fetch(AssetDic[] assets)
		{
			return default(UniTask);
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004F5F")]
		public T[] GetContent<T>() where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06004F60 RID: 20320 RVA: 0x0000E958 File Offset: 0x0000CB58
		[Token(Token = "0x6004F60")]
		public bool TryGetContent<T>(out T[] result) where T : UnityEngine.Object
		{
			return default(bool);
		}

		// Token: 0x06004F61 RID: 20321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F61")]
		[Address(RVA = "0x9D86", Offset = "0x9D86", VA = "0x9D86")]
		private void CheckIfReady(UniTaskCompletionSource completionSource)
		{
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F62")]
		[Address(RVA = "0x9D87", Offset = "0x9D87", VA = "0x9D87")]
		private void Warm(AssetDic asset, UniTaskCompletionSource completionSource)
		{
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F63")]
		[Address(RVA = "0x9D88", Offset = "0x9D88", VA = "0x9D88")]
		public AssetsPrefetch()
		{
		}

		// Token: 0x04002B32 RID: 11058
		[Token(Token = "0x4002B32")]
		[FieldOffset(Offset = "0xC")]
		private UniTaskCompletionSource _fetchCompletionSource;

		// Token: 0x04002B33 RID: 11059
		[Token(Token = "0x4002B33")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<AssetDic> _assets;

		// Token: 0x04002B34 RID: 11060
		[Token(Token = "0x4002B34")]
		[FieldOffset(Offset = "0x14")]
		private readonly List<UnityEngine.Object> _content;

		// Token: 0x04002B35 RID: 11061
		[Token(Token = "0x4002B35")]
		[FieldOffset(Offset = "0x18")]
		private int _progress;
	}
}
