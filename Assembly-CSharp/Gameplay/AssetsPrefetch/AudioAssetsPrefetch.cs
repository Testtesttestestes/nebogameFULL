using System;
using System.Runtime.CompilerServices;
using Core.Cache;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.AssetsPrefetch
{
	// Token: 0x02000CBB RID: 3259
	[Token(Token = "0x2000CBB")]
	public class AudioAssetsPrefetch : IDisposable
	{
		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06004F76 RID: 20342 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004F77 RID: 20343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001021")]
		public ICache<AssetDic, AudioClip> AudioCache
		{
			[Token(Token = "0x6004F76")]
			[Address(RVA = "0x9D94", Offset = "0x9D94", VA = "0x9D94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004F77")]
			[Address(RVA = "0x9D95", Offset = "0x9D95", VA = "0x9D95")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06004F78 RID: 20344 RVA: 0x0000E988 File Offset: 0x0000CB88
		// (set) Token: 0x06004F79 RID: 20345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001022")]
		public bool IsDisposed
		{
			[Token(Token = "0x6004F78")]
			[Address(RVA = "0x9D96", Offset = "0x9D96", VA = "0x9D96")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004F79")]
			[Address(RVA = "0x9D97", Offset = "0x9D97", VA = "0x9D97")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004F7A RID: 20346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F7A")]
		[Address(RVA = "0x9D98", Offset = "0x9D98", VA = "0x9D98")]
		public AudioAssetsPrefetch(ICache<AssetDic, AudioClip> audioCache, AssetDic[] assets)
		{
		}

		// Token: 0x06004F7B RID: 20347 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
		[Token(Token = "0x6004F7B")]
		[Address(RVA = "0x9D99", Offset = "0x9D99", VA = "0x9D99")]
		public UniTask Fetch()
		{
			return default(UniTask);
		}

		// Token: 0x06004F7C RID: 20348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F7C")]
		[Address(RVA = "0x9D9A", Offset = "0x9D9A", VA = "0x9D9A")]
		private void Warm(AssetDic[] assets, UniTaskCompletionSource completionSource)
		{
		}

		// Token: 0x06004F7D RID: 20349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F7D")]
		[Address(RVA = "0x9D9B", Offset = "0x9D9B", VA = "0x9D9B", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04002B3E RID: 11070
		[Token(Token = "0x4002B3E")]
		[FieldOffset(Offset = "0xC")]
		private UniTaskCompletionSource _fetchCompletionSource;

		// Token: 0x04002B3F RID: 11071
		[Token(Token = "0x4002B3F")]
		[FieldOffset(Offset = "0x10")]
		private AssetDic[] _assets;
	}
}
