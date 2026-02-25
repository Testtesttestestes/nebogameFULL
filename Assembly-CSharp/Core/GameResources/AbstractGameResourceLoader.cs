using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.GameResources
{
	// Token: 0x02000EDA RID: 3802
	[Token(Token = "0x2000EDA")]
	public abstract class AbstractGameResourceLoader<T> : IDisposable where T : Delegate
	{
		// Token: 0x06005C7B RID: 23675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7B")]
		public void Load()
		{
		}

		// Token: 0x06005C7C RID: 23676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7C")]
		private void AssetBundleSuccessHandler(AssetBundle bundle)
		{
		}

		// Token: 0x06005C7D RID: 23677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7D")]
		private void AssetBundleFailHandler()
		{
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C7E")]
		public void AddCallbacks(T successCallback, [Optional] GameResourcesManager.ResourceFailedDelegate failCallback)
		{
		}

		// Token: 0x06005C7F RID: 23679
		[Token(Token = "0x6005C7F")]
		protected abstract void CheckIfReady();

		// Token: 0x06005C80 RID: 23680
		[Token(Token = "0x6005C80")]
		protected abstract void OnAssetBundleReady();

		// Token: 0x06005C81 RID: 23681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C81")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06005C82 RID: 23682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C82")]
		protected virtual void ReleaseAssetBundle()
		{
		}

		// Token: 0x06005C83 RID: 23683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C83")]
		protected AbstractGameResourceLoader()
		{
		}

		// Token: 0x0400326A RID: 12906
		[Token(Token = "0x400326A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string Url;

		// Token: 0x0400326B RID: 12907
		[Token(Token = "0x400326B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Counter;

		// Token: 0x0400326C RID: 12908
		[Token(Token = "0x400326C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float CreatedAt;

		// Token: 0x0400326D RID: 12909
		[Token(Token = "0x400326D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool CacheOnDevice;

		// Token: 0x0400326E RID: 12910
		[Token(Token = "0x400326E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AssetBundle _assetBundle;

		// Token: 0x0400326F RID: 12911
		[Token(Token = "0x400326F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected List<T> _successCallbacks;

		// Token: 0x04003270 RID: 12912
		[Token(Token = "0x4003270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected List<GameResourcesManager.ResourceFailedDelegate> _failCallbacks;

		// Token: 0x04003271 RID: 12913
		[Token(Token = "0x4003271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool _isDisposed;

		// Token: 0x04003272 RID: 12914
		[Token(Token = "0x4003272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool _failed;

		// Token: 0x04003273 RID: 12915
		[Token(Token = "0x4003273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Tween _delayedCall;
	}
}
