using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using Preloading;
using UnityEngine;

namespace UI.Preloader
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	public class PreloaderBackgroundLoader : MonoBehaviour
	{
		// Token: 0x06000C16 RID: 3094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x5F29", Offset = "0x5F29", VA = "0x5F29")]
		private void Awake()
		{
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x5F2A", Offset = "0x5F2A", VA = "0x5F2A")]
		private UniTask LoadBackground(string path, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x5F2B", Offset = "0x5F2B", VA = "0x5F2B")]
		private void Launch()
		{
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x5F2C", Offset = "0x5F2C", VA = "0x5F2C")]
		public PreloaderBackgroundLoader()
		{
		}

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private PreloaderView _view;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Preloader _preloader;

		// Token: 0x020001CA RID: 458
		[Token(Token = "0x20001CA")]
		public struct PreloaderBackgroundDto
		{
			// Token: 0x06000C1A RID: 3098 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x1D80", Offset = "0x1D80", VA = "0x1D80")]
			public PreloaderBackgroundDto(string assetPath, string htmlBackgroundColor, long expire)
			{
			}

			// Token: 0x06000C1B RID: 3099 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000C1B")]
			[Address(RVA = "0x5F2D", Offset = "0x5F2D", VA = "0x5F2D", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040005B4 RID: 1460
			[Token(Token = "0x40005B4")]
			[FieldOffset(Offset = "0x0")]
			public string AssetPath;

			// Token: 0x040005B5 RID: 1461
			[Token(Token = "0x40005B5")]
			[FieldOffset(Offset = "0x8")]
			public long Expire;

			// Token: 0x040005B6 RID: 1462
			[Token(Token = "0x40005B6")]
			[FieldOffset(Offset = "0x10")]
			public string HtmlBackgroundColor;
		}
	}
}
