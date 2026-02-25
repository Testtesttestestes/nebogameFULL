using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.GameResources.Loaders
{
	// Token: 0x02000EE1 RID: 3809
	[Token(Token = "0x2000EE1")]
	public abstract class AbstractGameAudioClipLoader : AbstractGameResourceLoader<GameResourcesManager.AudioClipReadyDelegate>
	{
		// Token: 0x06005C9E RID: 23710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9E")]
		[Address(RVA = "0xA932", Offset = "0xA932", VA = "0xA932", Slot = "5")]
		protected override void CheckIfReady()
		{
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C9F")]
		[Address(RVA = "0xA933", Offset = "0xA933", VA = "0xA933", Slot = "6")]
		protected override void OnAssetBundleReady()
		{
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x000109C8 File Offset: 0x0000EBC8
		[Token(Token = "0x6005CA0")]
		[Address(RVA = "0xA934", Offset = "0xA934", VA = "0xA934", Slot = "9")]
		protected virtual UniTaskVoid ProcessAssetBundle(CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA1")]
		[Address(RVA = "0xA935", Offset = "0xA935", VA = "0xA935", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0xA936", Offset = "0xA936", VA = "0xA936", Slot = "8")]
		protected override void ReleaseAssetBundle()
		{
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CA3")]
		[Address(RVA = "0xA937", Offset = "0xA937", VA = "0xA937")]
		protected AbstractGameAudioClipLoader()
		{
		}

		// Token: 0x04003289 RID: 12937
		[Token(Token = "0x4003289")]
		[FieldOffset(Offset = "0x2C")]
		public AudioClip AudioClip;

		// Token: 0x0400328A RID: 12938
		[Token(Token = "0x400328A")]
		[FieldOffset(Offset = "0x30")]
		protected GameResourceCancellationToken _cancel;
	}
}
