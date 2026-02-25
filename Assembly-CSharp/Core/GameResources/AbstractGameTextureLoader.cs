using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.GameResources
{
	// Token: 0x02000EDF RID: 3807
	[Token(Token = "0x2000EDF")]
	public abstract class AbstractGameTextureLoader : AbstractGameResourceLoader<GameResourcesManager.TextureReadyDelegate>
	{
		// Token: 0x06005C96 RID: 23702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C96")]
		[Address(RVA = "0xA92A", Offset = "0xA92A", VA = "0xA92A", Slot = "5")]
		protected override void CheckIfReady()
		{
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C97")]
		[Address(RVA = "0xA92B", Offset = "0xA92B", VA = "0xA92B", Slot = "6")]
		protected override void OnAssetBundleReady()
		{
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x000109B0 File Offset: 0x0000EBB0
		[Token(Token = "0x6005C98")]
		[Address(RVA = "0xA92C", Offset = "0xA92C", VA = "0xA92C", Slot = "9")]
		protected virtual UniTaskVoid ProcessAssetBundle(CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C99")]
		[Address(RVA = "0xA92D", Offset = "0xA92D", VA = "0xA92D", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9A")]
		[Address(RVA = "0xA92E", Offset = "0xA92E", VA = "0xA92E", Slot = "8")]
		protected override void ReleaseAssetBundle()
		{
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0xA92F", Offset = "0xA92F", VA = "0xA92F")]
		protected AbstractGameTextureLoader()
		{
		}

		// Token: 0x04003282 RID: 12930
		[Token(Token = "0x4003282")]
		[FieldOffset(Offset = "0x2C")]
		public Texture2D Texture;

		// Token: 0x04003283 RID: 12931
		[Token(Token = "0x4003283")]
		[FieldOffset(Offset = "0x30")]
		protected GameResourceCancellationToken _cancel;
	}
}
