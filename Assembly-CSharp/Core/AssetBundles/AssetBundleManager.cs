using System;
using System.Collections.Generic;
using Core.AssetBundles.WebGL;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.AssetBundles
{
	// Token: 0x02001113 RID: 4371
	[Token(Token = "0x2001113")]
	public static class AssetBundleManager
	{
		// Token: 0x060065F7 RID: 26103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F7")]
		[Address(RVA = "0xB17D", Offset = "0xB17D", VA = "0xB17D")]
		public static void LoadAssetBundle(string url, Action<AssetBundle> successCallback, Action failCallback, bool cacheOnDevice)
		{
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F8")]
		[Address(RVA = "0xB17E", Offset = "0xB17E", VA = "0xB17E")]
		public static void ReleaseAssetBundle(string url)
		{
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F9")]
		[Address(RVA = "0xB17F", Offset = "0xB17F", VA = "0xB17F")]
		private static void DisposeCompleteEventHandler(string url)
		{
		}

		// Token: 0x04003689 RID: 13961
		[Token(Token = "0x4003689")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, AssetBundleLoader> _storage;
	}
}
