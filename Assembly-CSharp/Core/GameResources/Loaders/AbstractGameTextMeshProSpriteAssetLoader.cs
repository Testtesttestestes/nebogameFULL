using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Core.GameResources.Loaders
{
	// Token: 0x02000EE3 RID: 3811
	[Token(Token = "0x2000EE3")]
	public abstract class AbstractGameTextMeshProSpriteAssetLoader : AbstractGameResourceLoader<GameResourcesManager.TextMeshProSpriteAssetReadyDelegate>
	{
		// Token: 0x06005CA6 RID: 23718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005CA6")]
		[Address(RVA = "0x22A9", Offset = "0x22A9", VA = "0x22A9")]
		private static Shader GetShader()
		{
			return null;
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA7")]
		[Address(RVA = "0xA93A", Offset = "0xA93A", VA = "0xA93A", Slot = "5")]
		protected override void CheckIfReady()
		{
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA8")]
		[Address(RVA = "0xA93B", Offset = "0xA93B", VA = "0xA93B", Slot = "6")]
		protected override void OnAssetBundleReady()
		{
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x000109E0 File Offset: 0x0000EBE0
		[Token(Token = "0x6005CA9")]
		[Address(RVA = "0xA93C", Offset = "0xA93C", VA = "0xA93C", Slot = "9")]
		protected virtual UniTaskVoid ProcessAssetBundle(CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAA")]
		[Address(RVA = "0xA93D", Offset = "0xA93D", VA = "0xA93D", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x06005CAB RID: 23723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAB")]
		[Address(RVA = "0xA93E", Offset = "0xA93E", VA = "0xA93E", Slot = "8")]
		protected override void ReleaseAssetBundle()
		{
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAC")]
		[Address(RVA = "0xA93F", Offset = "0xA93F", VA = "0xA93F")]
		protected AbstractGameTextMeshProSpriteAssetLoader()
		{
		}

		// Token: 0x04003290 RID: 12944
		[Token(Token = "0x4003290")]
		[FieldOffset(Offset = "0x0")]
		private static Shader _cachedShader;

		// Token: 0x04003291 RID: 12945
		[Token(Token = "0x4003291")]
		[FieldOffset(Offset = "0x2C")]
		private TMP_SpriteAsset _asset;

		// Token: 0x04003292 RID: 12946
		[Token(Token = "0x4003292")]
		[FieldOffset(Offset = "0x30")]
		private readonly GameResourceCancellationToken _cancel;
	}
}
