using System;
using System.Runtime.InteropServices;
using Core.Animations;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;

namespace Core.GameResources
{
	// Token: 0x02000ECC RID: 3788
	[Token(Token = "0x2000ECC")]
	public static class GameResourcesManager
	{
		// Token: 0x06005C48 RID: 23624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C48")]
		[Address(RVA = "0xA8EA", Offset = "0xA8EA", VA = "0xA8EA")]
		public static void GetTexture(string url, GameResourcesManager.TextureReadyDelegate completeCallback, [Optional] GameResourcesManager.ResourceFailedDelegate failCallback, bool cacheOnDevice = true)
		{
		}

		// Token: 0x06005C49 RID: 23625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C49")]
		[Address(RVA = "0xA8EB", Offset = "0xA8EB", VA = "0xA8EB")]
		public static void ReleaseTexture(string resourceUrl)
		{
		}

		// Token: 0x06005C4A RID: 23626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4A")]
		[Address(RVA = "0xA8EC", Offset = "0xA8EC", VA = "0xA8EC")]
		public static void GetSprite(string url, GameResourcesManager.SpriteReadyDelegate completeCallback, [Optional] GameResourcesManager.ResourceFailedDelegate failCallback, bool cacheOnDevice = true)
		{
		}

		// Token: 0x06005C4B RID: 23627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4B")]
		[Address(RVA = "0x1D75", Offset = "0x1D75", VA = "0x1D75")]
		public static void GetSpriteAtlas(string url, GameResourcesManager.SpriteAtlasReadyDelegate completeCallback, [Optional] GameResourcesManager.ResourceFailedDelegate failCallback, bool cacheOnDevice = true)
		{
		}

		// Token: 0x06005C4C RID: 23628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4C")]
		[Address(RVA = "0xA8ED", Offset = "0xA8ED", VA = "0xA8ED")]
		public static void GetTextMeshProSpriteAsset(string url, GameResourcesManager.TextMeshProSpriteAssetReadyDelegate completeCallback, [Optional] GameResourcesManager.ResourceFailedDelegate failCallback, bool cacheOnDevice = true)
		{
		}

		// Token: 0x06005C4D RID: 23629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4D")]
		[Address(RVA = "0xA8EE", Offset = "0xA8EE", VA = "0xA8EE")]
		public static void GetAudioClip(string url, GameResourcesManager.AudioClipReadyDelegate completeCallback, [Optional] GameResourcesManager.ResourceFailedDelegate failCallback, bool cacheOnDevice = true)
		{
		}

		// Token: 0x06005C4E RID: 23630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4E")]
		[Address(RVA = "0xA8EF", Offset = "0xA8EF", VA = "0xA8EF")]
		public static void ReleaseAudioClip(string resourceUrl)
		{
		}

		// Token: 0x06005C4F RID: 23631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C4F")]
		[Address(RVA = "0xA8F0", Offset = "0xA8F0", VA = "0xA8F0")]
		public static void ReleaseSprite(string resourceUrl)
		{
		}

		// Token: 0x06005C50 RID: 23632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C50")]
		[Address(RVA = "0xA8F1", Offset = "0xA8F1", VA = "0xA8F1")]
		public static void ReleaseTextMeshProSpriteAsset(string url)
		{
		}

		// Token: 0x06005C51 RID: 23633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C51")]
		[Address(RVA = "0x1D6F", Offset = "0x1D6F", VA = "0x1D6F")]
		public static void ReleaseSpriteAtlas(string url)
		{
		}

		// Token: 0x06005C52 RID: 23634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C52")]
		[Address(RVA = "0x1D6D", Offset = "0x1D6D", VA = "0x1D6D")]
		public static void Release(AssetDic asset)
		{
		}

		// Token: 0x06005C53 RID: 23635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C53")]
		[Address(RVA = "0xA8F2", Offset = "0xA8F2", VA = "0xA8F2")]
		public static void GetAnimation(string url, GameResourcesManager.AnimationReadyDelegate completeCallback, [Optional] GameResourcesManager.ResourceFailedDelegate failCallback, bool cacheOnDevice = true)
		{
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C54")]
		[Address(RVA = "0xA8F3", Offset = "0xA8F3", VA = "0xA8F3")]
		public static void ReleaseAnimation(string resourceUrl)
		{
		}

		// Token: 0x06005C55 RID: 23637 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005C55")]
		[Address(RVA = "0xA8F4", Offset = "0xA8F4", VA = "0xA8F4")]
		public static string GetResourcesInfoString()
		{
			return null;
		}

		// Token: 0x06005C56 RID: 23638 RVA: 0x00010938 File Offset: 0x0000EB38
		[Token(Token = "0x6005C56")]
		[Address(RVA = "0xA8F5", Offset = "0xA8F5", VA = "0xA8F5")]
		public static int GetTotalTexturesCount()
		{
			return 0;
		}

		// Token: 0x06005C57 RID: 23639 RVA: 0x00010950 File Offset: 0x0000EB50
		[Token(Token = "0x6005C57")]
		[Address(RVA = "0xA8F6", Offset = "0xA8F6", VA = "0xA8F6")]
		public static int GetTotalSpritesCount()
		{
			return 0;
		}

		// Token: 0x06005C58 RID: 23640 RVA: 0x00010968 File Offset: 0x0000EB68
		[Token(Token = "0x6005C58")]
		[Address(RVA = "0xA8F7", Offset = "0xA8F7", VA = "0xA8F7")]
		public static int GetTotalAnimationsCount()
		{
			return 0;
		}

		// Token: 0x04003264 RID: 12900
		[Token(Token = "0x4003264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly GameTexturesFabric _gameTexturesFabric;

		// Token: 0x04003265 RID: 12901
		[Token(Token = "0x4003265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly GameSpritesFabric _gameSpritesFabric;

		// Token: 0x04003266 RID: 12902
		[Token(Token = "0x4003266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly GameSpriteAtlasFabric _gameSpriteAtlasFabric;

		// Token: 0x04003267 RID: 12903
		[Token(Token = "0x4003267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly GameTextMeshProSpriteAssetFabric _gameTextMeshProSpriteAssetFabric;

		// Token: 0x04003268 RID: 12904
		[Token(Token = "0x4003268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly GameAnimationsFabric _gameAnimationsFabric;

		// Token: 0x04003269 RID: 12905
		[Token(Token = "0x4003269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly AudioFabric _gameAudioFabric;

		// Token: 0x02000ECD RID: 3789
		// (Invoke) Token: 0x06005C5A RID: 23642
		[Token(Token = "0x2000ECD")]
		public delegate void ResourceFailedDelegate(string resourceUrl);

		// Token: 0x02000ECE RID: 3790
		// (Invoke) Token: 0x06005C5E RID: 23646
		[Token(Token = "0x2000ECE")]
		public delegate void TextureReadyDelegate(Texture2D texture2D, string resourceUrl);

		// Token: 0x02000ECF RID: 3791
		// (Invoke) Token: 0x06005C62 RID: 23650
		[Token(Token = "0x2000ECF")]
		public delegate void SpriteReadyDelegate(Sprite sprite, string resourceUrl);

		// Token: 0x02000ED0 RID: 3792
		// (Invoke) Token: 0x06005C66 RID: 23654
		[Token(Token = "0x2000ED0")]
		public delegate void SpriteAtlasReadyDelegate(SpriteAtlas atlas, string resourceUrl);

		// Token: 0x02000ED1 RID: 3793
		// (Invoke) Token: 0x06005C6A RID: 23658
		[Token(Token = "0x2000ED1")]
		public delegate void TextMeshProSpriteAssetReadyDelegate(TMP_SpriteAsset atlas, string resourceUrl);

		// Token: 0x02000ED2 RID: 3794
		// (Invoke) Token: 0x06005C6E RID: 23662
		[Token(Token = "0x2000ED2")]
		public delegate void AudioClipReadyDelegate(AudioClip audioClip, string resourceUrl);

		// Token: 0x02000ED3 RID: 3795
		// (Invoke) Token: 0x06005C72 RID: 23666
		[Token(Token = "0x2000ED3")]
		public delegate void AnimationReadyDelegate(IGameAnimation iGameAnimation, string resourceUrl);
	}
}
