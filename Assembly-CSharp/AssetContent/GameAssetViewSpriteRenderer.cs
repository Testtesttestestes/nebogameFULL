using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core;
using Core.Materials;
using DG.Tweening;
using Gameplay.Tutorial.Guide.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UnityEngine;

namespace AssetContent
{
	// Token: 0x02000E2B RID: 3627
	[Token(Token = "0x2000E2B")]
	[DisallowMultipleComponent]
	public class GameAssetViewSpriteRenderer : MonoBehaviour, IAsyncLoadableContent, IGameAssetContent, IBoundsProvider, IGuideTargetResolveEventProvider, IGrayscalable
	{
		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060058BE RID: 22718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001211")]
		public GameAnimationView GameAnimationView
		{
			[Token(Token = "0x60058BE")]
			[Address(RVA = "0xA628", Offset = "0xA628", VA = "0xA628")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060058BF RID: 22719 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001212")]
		public SpriteRenderer SpriteRenderer
		{
			[Token(Token = "0x60058BF")]
			[Address(RVA = "0xA629", Offset = "0xA629", VA = "0xA629")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000214 RID: 532
		// (add) Token: 0x060058C0 RID: 22720 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060058C1 RID: 22721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000214")]
		public event Action<GameAssetViewSpriteRenderer> ClickedEvent
		{
			[Token(Token = "0x60058C0")]
			[Address(RVA = "0xA62A", Offset = "0xA62A", VA = "0xA62A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60058C1")]
			[Address(RVA = "0xA62B", Offset = "0xA62B", VA = "0xA62B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060058C2 RID: 22722 RVA: 0x0000FC78 File Offset: 0x0000DE78
		[Token(Token = "0x17001213")]
		public bool IsReady
		{
			[Token(Token = "0x60058C2")]
			[Address(RVA = "0xA62C", Offset = "0xA62C", VA = "0xA62C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000215 RID: 533
		// (add) Token: 0x060058C3 RID: 22723 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060058C4 RID: 22724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000215")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x60058C3")]
			[Address(RVA = "0xA62D", Offset = "0xA62D", VA = "0xA62D", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60058C4")]
			[Address(RVA = "0xA62E", Offset = "0xA62E", VA = "0xA62E", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058C5")]
		[Address(RVA = "0xA62F", Offset = "0xA62F", VA = "0xA62F")]
		private void Awake()
		{
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058C6")]
		[Address(RVA = "0xA630", Offset = "0xA630", VA = "0xA630")]
		private void GameAnimationViewOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058C7")]
		[Address(RVA = "0xA631", Offset = "0xA631", VA = "0xA631")]
		private void GameSpriteRendererLoaderInteractableOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x17001214 RID: 4628
		// (get) Token: 0x060058C8 RID: 22728 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058C9 RID: 22729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001214")]
		public string AssetId
		{
			[Token(Token = "0x60058C8")]
			[Address(RVA = "0xA632", Offset = "0xA632", VA = "0xA632", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058C9")]
			[Address(RVA = "0xA633", Offset = "0xA633", VA = "0xA633", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17001215 RID: 4629
		// (get) Token: 0x060058CA RID: 22730 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001215")]
		public string AssetPath
		{
			[Token(Token = "0x60058CA")]
			[Address(RVA = "0xA634", Offset = "0xA634", VA = "0xA634", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CB")]
		[Address(RVA = "0xA635", Offset = "0xA635", VA = "0xA635")]
		public void SetGrayscale(float value, float duration)
		{
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CC")]
		[Address(RVA = "0xA636", Offset = "0xA636", VA = "0xA636")]
		private void GrayscaleChanged(float from, float to, float duration)
		{
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058CD")]
		[Address(RVA = "0xA637", Offset = "0xA637", VA = "0xA637")]
		private void OnDestroy()
		{
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x060058CE RID: 22734 RVA: 0x0000FC90 File Offset: 0x0000DE90
		// (set) Token: 0x060058CF RID: 22735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001216")]
		public int SortingOrder
		{
			[Token(Token = "0x60058CE")]
			[Address(RVA = "0xA638", Offset = "0xA638", VA = "0xA638")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60058CF")]
			[Address(RVA = "0x1DF0", Offset = "0x1DF0", VA = "0x1DF0")]
			set
			{
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x060058D0 RID: 22736 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		// (set) Token: 0x060058D1 RID: 22737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001217")]
		public int SortingLayerId
		{
			[Token(Token = "0x60058D0")]
			[Address(RVA = "0xA639", Offset = "0xA639", VA = "0xA639")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60058D1")]
			[Address(RVA = "0x1DF2", Offset = "0x1DF2", VA = "0x1DF2")]
			set
			{
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x060058D2 RID: 22738 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		// (set) Token: 0x060058D3 RID: 22739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001218")]
		public bool Interactable
		{
			[Token(Token = "0x60058D2")]
			[Address(RVA = "0xA63A", Offset = "0xA63A", VA = "0xA63A")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60058D3")]
			[Address(RVA = "0xA63B", Offset = "0xA63B", VA = "0xA63B")]
			set
			{
			}
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058D4")]
		[Address(RVA = "0xA63C", Offset = "0xA63C", VA = "0xA63C")]
		private void GameAnimationViewOnClickEvent()
		{
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058D5")]
		[Address(RVA = "0xA63D", Offset = "0xA63D", VA = "0xA63D")]
		private void GameSpriteRendererLoaderInteractableOnClickEvent()
		{
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		[Token(Token = "0x60058D6")]
		[Address(RVA = "0xA63E", Offset = "0xA63E", VA = "0xA63E")]
		public bool TryGetCurrentContent(AssetDic asset, out IGameAssetContent content)
		{
			return default(bool);
		}

		// Token: 0x14000216 RID: 534
		// (add) Token: 0x060058D7 RID: 22743 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060058D8 RID: 22744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000216")]
		public event Action<IGuideTargetResolveEventProvider> ResolveEvent
		{
			[Token(Token = "0x60058D7")]
			[Address(RVA = "0xA63F", Offset = "0xA63F", VA = "0xA63F", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60058D8")]
			[Address(RVA = "0xA640", Offset = "0xA640", VA = "0xA640", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x060058D9 RID: 22745 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		[Token(Token = "0x17001219")]
		public Bounds Bounds
		{
			[Token(Token = "0x60058D9")]
			[Address(RVA = "0xA641", Offset = "0xA641", VA = "0xA641", Slot = "10")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058DA")]
		[Address(RVA = "0xA642", Offset = "0xA642", VA = "0xA642")]
		public void TestGrayscale(float value, float duration)
		{
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058DB")]
		[Address(RVA = "0xA643", Offset = "0xA643", VA = "0xA643", Slot = "14")]
		public void SetGrayscale(float value)
		{
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058DC")]
		[Address(RVA = "0xA644", Offset = "0xA644", VA = "0xA644")]
		public GameAssetViewSpriteRenderer()
		{
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60058DD")]
		[Address(RVA = "0xA645", Offset = "0xA645", VA = "0xA645", Slot = "13")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04002FFE RID: 12286
		[Token(Token = "0x4002FFE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameSpriteRendererLoaderInteractable _gameSpriteRendererLoaderInteractable;

		// Token: 0x04002FFF RID: 12287
		[Token(Token = "0x4002FFF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameAnimationView _gameAnimationView;

		// Token: 0x04003002 RID: 12290
		[Token(Token = "0x4003002")]
		[FieldOffset(Offset = "0x20")]
		private string _assetId;

		// Token: 0x04003003 RID: 12291
		[Token(Token = "0x4003003")]
		[FieldOffset(Offset = "0x24")]
		private AssetDic _asset;

		// Token: 0x04003004 RID: 12292
		[Token(Token = "0x4003004")]
		[FieldOffset(Offset = "0x28")]
		private float _grayscaleValue;

		// Token: 0x04003005 RID: 12293
		[Token(Token = "0x4003005")]
		[FieldOffset(Offset = "0x2C")]
		private Tween _grayscaleTween;

		// Token: 0x04003006 RID: 12294
		[Token(Token = "0x4003006")]
		[FieldOffset(Offset = "0x30")]
		private int _sortingOrder;

		// Token: 0x04003007 RID: 12295
		[Token(Token = "0x4003007")]
		[FieldOffset(Offset = "0x34")]
		private int _sortingLayerId;

		// Token: 0x04003008 RID: 12296
		[Token(Token = "0x4003008")]
		[FieldOffset(Offset = "0x38")]
		private bool _interactable;

		// Token: 0x02000E2C RID: 3628
		[Token(Token = "0x2000E2C")]
		public static class BoundsFromGASR
		{
			// Token: 0x060058DF RID: 22751 RVA: 0x0000FD08 File Offset: 0x0000DF08
			[Token(Token = "0x60058DF")]
			[Address(RVA = "0xA647", Offset = "0xA647", VA = "0xA647")]
			public static Bounds GetBounds(GameObject gameObject)
			{
				return default(Bounds);
			}
		}
	}
}
