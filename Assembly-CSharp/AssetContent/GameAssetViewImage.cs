using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core;
using Core.Materials;
using DG.Tweening;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UnityEngine;

namespace AssetContent
{
	// Token: 0x02000E29 RID: 3625
	[Token(Token = "0x2000E29")]
	public class GameAssetViewImage : MonoBehaviour, IAsyncLoadableContent, IGameAssetContent, IRectProvider, IGrayscalable
	{
		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06005896 RID: 22678 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001205")]
		public GameAnimationView GameAnimationView
		{
			[Token(Token = "0x6005896")]
			[Address(RVA = "0xA601", Offset = "0xA601", VA = "0xA601")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x06005897 RID: 22679 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		[Token(Token = "0x17001206")]
		public bool IsReady
		{
			[Token(Token = "0x6005897")]
			[Address(RVA = "0xA602", Offset = "0xA602", VA = "0xA602", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000212 RID: 530
		// (add) Token: 0x06005898 RID: 22680 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005899 RID: 22681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000212")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x6005898")]
			[Address(RVA = "0xA603", Offset = "0xA603", VA = "0xA603", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005899")]
			[Address(RVA = "0xA604", Offset = "0xA604", VA = "0xA604", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600589A")]
		[Address(RVA = "0xA605", Offset = "0xA605", VA = "0xA605")]
		private void Awake()
		{
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600589B")]
		[Address(RVA = "0xA606", Offset = "0xA606", VA = "0xA606")]
		private void GameAnimationViewOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600589C")]
		[Address(RVA = "0xA607", Offset = "0xA607", VA = "0xA607")]
		private void LoaderOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x0600589D RID: 22685 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		// (set) Token: 0x0600589E RID: 22686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001207")]
		public bool Interactable
		{
			[Token(Token = "0x600589D")]
			[Address(RVA = "0xA608", Offset = "0xA608", VA = "0xA608")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600589E")]
			[Address(RVA = "0xA609", Offset = "0xA609", VA = "0xA609")]
			set
			{
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x0600589F RID: 22687 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058A0 RID: 22688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001208")]
		public string AssetId
		{
			[Token(Token = "0x600589F")]
			[Address(RVA = "0xA60A", Offset = "0xA60A", VA = "0xA60A", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058A0")]
			[Address(RVA = "0xA60B", Offset = "0xA60B", VA = "0xA60B", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060058A1 RID: 22689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001209")]
		public string AssetPath
		{
			[Token(Token = "0x60058A1")]
			[Address(RVA = "0xA60C", Offset = "0xA60C", VA = "0xA60C", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058A2")]
		[Address(RVA = "0xA60D", Offset = "0xA60D", VA = "0xA60D")]
		public void SetGrayscale(float value, float duration)
		{
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058A3")]
		[Address(RVA = "0xA60E", Offset = "0xA60E", VA = "0xA60E")]
		private void GrayscaleChanged(float from, float to, float duration)
		{
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058A4")]
		[Address(RVA = "0xA60F", Offset = "0xA60F", VA = "0xA60F")]
		private void OnDestroy()
		{
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		[Token(Token = "0x60058A5")]
		[Address(RVA = "0xA610", Offset = "0xA610", VA = "0xA610")]
		public bool TryGetCurrentContent(AssetDic asset, out IGameAssetContent content)
		{
			return default(bool);
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058A6")]
		[Address(RVA = "0xA611", Offset = "0xA611", VA = "0xA611", Slot = "11")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060058A7 RID: 22695 RVA: 0x0000FC00 File Offset: 0x0000DE00
		[Token(Token = "0x1700120A")]
		public Rect Rect
		{
			[Token(Token = "0x60058A7")]
			[Address(RVA = "0xA612", Offset = "0xA612", VA = "0xA612", Slot = "10")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058A8")]
		[Address(RVA = "0xA613", Offset = "0xA613", VA = "0xA613")]
		public GameAssetViewImage()
		{
		}

		// Token: 0x04002FEC RID: 12268
		[Token(Token = "0x4002FEC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ImageWithGrayscale _image;

		// Token: 0x04002FED RID: 12269
		[Token(Token = "0x4002FED")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameImageLoader _loader;

		// Token: 0x04002FEE RID: 12270
		[Token(Token = "0x4002FEE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameAnimationView _gameAnimationView;

		// Token: 0x04002FEF RID: 12271
		[Token(Token = "0x4002FEF")]
		[FieldOffset(Offset = "0x1C")]
		private string _assetId;

		// Token: 0x04002FF0 RID: 12272
		[Token(Token = "0x4002FF0")]
		[FieldOffset(Offset = "0x20")]
		private AssetDic _asset;

		// Token: 0x04002FF2 RID: 12274
		[Token(Token = "0x4002FF2")]
		[FieldOffset(Offset = "0x28")]
		private bool _interactable;

		// Token: 0x04002FF3 RID: 12275
		[Token(Token = "0x4002FF3")]
		[FieldOffset(Offset = "0x2C")]
		private float _grayscaleValue;

		// Token: 0x04002FF4 RID: 12276
		[Token(Token = "0x4002FF4")]
		[FieldOffset(Offset = "0x30")]
		private Tween _grayscaleTween;
	}
}
