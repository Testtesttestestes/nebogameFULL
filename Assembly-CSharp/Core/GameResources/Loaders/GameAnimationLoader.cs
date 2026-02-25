using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.GameResources.Loaders
{
	// Token: 0x02000EE5 RID: 3813
	[Token(Token = "0x2000EE5")]
	public class GameAnimationLoader : AbstractGameResourceLoader<GameResourcesManager.AnimationReadyDelegate>
	{
		// Token: 0x06005CAF RID: 23727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CAF")]
		[Address(RVA = "0xA942", Offset = "0xA942", VA = "0xA942", Slot = "5")]
		protected override void CheckIfReady()
		{
		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB0")]
		[Address(RVA = "0xA943", Offset = "0xA943", VA = "0xA943", Slot = "6")]
		protected override void OnAssetBundleReady()
		{
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x000109F8 File Offset: 0x0000EBF8
		[Token(Token = "0x6005CB1")]
		[Address(RVA = "0xA944", Offset = "0xA944", VA = "0xA944")]
		private UniTaskVoid ProcessAssetBundle(CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB2")]
		[Address(RVA = "0xA945", Offset = "0xA945", VA = "0xA945", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB3")]
		[Address(RVA = "0xA946", Offset = "0xA946", VA = "0xA946", Slot = "8")]
		protected override void ReleaseAssetBundle()
		{
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CB4")]
		[Address(RVA = "0xA947", Offset = "0xA947", VA = "0xA947")]
		public GameAnimationLoader()
		{
		}

		// Token: 0x04003298 RID: 12952
		[Token(Token = "0x4003298")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly int _straightAlphaInputId;

		// Token: 0x04003299 RID: 12953
		[Token(Token = "0x4003299")]
		[FieldOffset(Offset = "0x2C")]
		protected GameObject _originalGameObject;

		// Token: 0x0400329A RID: 12954
		[Token(Token = "0x400329A")]
		[FieldOffset(Offset = "0x30")]
		protected GameResourceCancellationToken _cancel;
	}
}
