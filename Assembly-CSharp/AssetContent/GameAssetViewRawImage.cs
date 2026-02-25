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
	// Token: 0x02000E2A RID: 3626
	[Token(Token = "0x2000E2A")]
	public class GameAssetViewRawImage : MonoBehaviour, IAsyncLoadableContent, IGameAssetContent, IRectProvider, IGrayscalable
	{
		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x060058AA RID: 22698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700120B")]
		public GameAnimationView GameAnimationView
		{
			[Token(Token = "0x60058AA")]
			[Address(RVA = "0xA615", Offset = "0xA615", VA = "0xA615")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060058AB RID: 22699 RVA: 0x0000FC18 File Offset: 0x0000DE18
		[Token(Token = "0x1700120C")]
		public bool IsReady
		{
			[Token(Token = "0x60058AB")]
			[Address(RVA = "0xA616", Offset = "0xA616", VA = "0xA616", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000213 RID: 531
		// (add) Token: 0x060058AC RID: 22700 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060058AD RID: 22701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000213")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x60058AC")]
			[Address(RVA = "0xA617", Offset = "0xA617", VA = "0xA617", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60058AD")]
			[Address(RVA = "0xA618", Offset = "0xA618", VA = "0xA618", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058AE")]
		[Address(RVA = "0xA619", Offset = "0xA619", VA = "0xA619")]
		private void Awake()
		{
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058AF")]
		[Address(RVA = "0xA61A", Offset = "0xA61A", VA = "0xA61A")]
		private void GameAnimationViewOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B0")]
		[Address(RVA = "0xA61B", Offset = "0xA61B", VA = "0xA61B")]
		private void GameRawImageLoaderOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060058B1 RID: 22705 RVA: 0x0000FC30 File Offset: 0x0000DE30
		// (set) Token: 0x060058B2 RID: 22706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700120D")]
		public bool Interactable
		{
			[Token(Token = "0x60058B1")]
			[Address(RVA = "0xA61C", Offset = "0xA61C", VA = "0xA61C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60058B2")]
			[Address(RVA = "0xA61D", Offset = "0xA61D", VA = "0xA61D")]
			set
			{
			}
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060058B3 RID: 22707 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058B4 RID: 22708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700120E")]
		public string AssetId
		{
			[Token(Token = "0x60058B3")]
			[Address(RVA = "0xA61E", Offset = "0xA61E", VA = "0xA61E", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058B4")]
			[Address(RVA = "0x1B50", Offset = "0x1B50", VA = "0x1B50", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060058B5 RID: 22709 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700120F")]
		public string AssetPath
		{
			[Token(Token = "0x60058B5")]
			[Address(RVA = "0xA61F", Offset = "0xA61F", VA = "0xA61F", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B6")]
		[Address(RVA = "0xA620", Offset = "0xA620", VA = "0xA620")]
		public void SetGrayscale(float value, float duration)
		{
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B7")]
		[Address(RVA = "0xA621", Offset = "0xA621", VA = "0xA621")]
		private void GrayscaleChanged(float from, float to, float duration)
		{
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B8")]
		[Address(RVA = "0xA622", Offset = "0xA622", VA = "0xA622")]
		private void OnDestroy()
		{
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x0000FC48 File Offset: 0x0000DE48
		[Token(Token = "0x60058B9")]
		[Address(RVA = "0xA623", Offset = "0xA623", VA = "0xA623")]
		public bool TryGetCurrentContent(AssetDic asset, out IGameAssetContent content)
		{
			return default(bool);
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058BA")]
		[Address(RVA = "0xA624", Offset = "0xA624", VA = "0xA624", Slot = "11")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060058BB RID: 22715 RVA: 0x0000FC60 File Offset: 0x0000DE60
		[Token(Token = "0x17001210")]
		public Rect Rect
		{
			[Token(Token = "0x60058BB")]
			[Address(RVA = "0xA625", Offset = "0xA625", VA = "0xA625", Slot = "10")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058BC")]
		[Address(RVA = "0xA626", Offset = "0xA626", VA = "0xA626")]
		public GameAssetViewRawImage()
		{
		}

		// Token: 0x04002FF5 RID: 12277
		[Token(Token = "0x4002FF5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RawImageWithGrayscale _gameRawImage;

		// Token: 0x04002FF6 RID: 12278
		[Token(Token = "0x4002FF6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImageLoader _gameRawImageLoader;

		// Token: 0x04002FF7 RID: 12279
		[Token(Token = "0x4002FF7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameAnimationView _gameAnimationView;

		// Token: 0x04002FF8 RID: 12280
		[Token(Token = "0x4002FF8")]
		[FieldOffset(Offset = "0x1C")]
		private string _assetId;

		// Token: 0x04002FF9 RID: 12281
		[Token(Token = "0x4002FF9")]
		[FieldOffset(Offset = "0x20")]
		private AssetDic _asset;

		// Token: 0x04002FFB RID: 12283
		[Token(Token = "0x4002FFB")]
		[FieldOffset(Offset = "0x28")]
		private bool _interactable;

		// Token: 0x04002FFC RID: 12284
		[Token(Token = "0x4002FFC")]
		[FieldOffset(Offset = "0x2C")]
		private float _grayscaleValue;

		// Token: 0x04002FFD RID: 12285
		[Token(Token = "0x4002FFD")]
		[FieldOffset(Offset = "0x30")]
		private Tween _grayscaleTween;
	}
}
