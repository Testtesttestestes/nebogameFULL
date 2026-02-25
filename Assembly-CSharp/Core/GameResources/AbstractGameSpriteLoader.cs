using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.GameResources
{
	// Token: 0x02000EDD RID: 3805
	[Token(Token = "0x2000EDD")]
	public abstract class AbstractGameSpriteLoader : AbstractGameResourceLoader<GameResourcesManager.SpriteReadyDelegate>
	{
		// Token: 0x06005C8E RID: 23694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8E")]
		[Address(RVA = "0xA922", Offset = "0xA922", VA = "0xA922", Slot = "5")]
		protected override void CheckIfReady()
		{
		}

		// Token: 0x06005C8F RID: 23695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8F")]
		[Address(RVA = "0xA923", Offset = "0xA923", VA = "0xA923", Slot = "6")]
		protected override void OnAssetBundleReady()
		{
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x00010998 File Offset: 0x0000EB98
		[Token(Token = "0x6005C90")]
		[Address(RVA = "0xA924", Offset = "0xA924", VA = "0xA924", Slot = "9")]
		protected virtual UniTaskVoid ProcessAssetBundle(CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C91")]
		[Address(RVA = "0xA925", Offset = "0xA925", VA = "0xA925", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C92")]
		[Address(RVA = "0xA926", Offset = "0xA926", VA = "0xA926", Slot = "8")]
		protected override void ReleaseAssetBundle()
		{
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C93")]
		[Address(RVA = "0xA927", Offset = "0xA927", VA = "0xA927")]
		protected AbstractGameSpriteLoader()
		{
		}

		// Token: 0x0400327B RID: 12923
		[Token(Token = "0x400327B")]
		[FieldOffset(Offset = "0x2C")]
		public Sprite Sprite;

		// Token: 0x0400327C RID: 12924
		[Token(Token = "0x400327C")]
		[FieldOffset(Offset = "0x30")]
		protected GameResourceCancellationToken _cancel;
	}
}
