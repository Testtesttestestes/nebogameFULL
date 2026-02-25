using System;
using System.Runtime.CompilerServices;
using Core;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace AssetContent.Loaders
{
	// Token: 0x02000E2F RID: 3631
	[Token(Token = "0x2000E2F")]
	public abstract class AbstractGameGraphicLoader<TGraphic, TAsset> : MonoBehaviour, IAsyncLoadableContent, IGameAssetContent, IRectProvider where TGraphic : Graphic where TAsset : UnityEngine.Object
	{
		// Token: 0x14000217 RID: 535
		// (add) Token: 0x060058EC RID: 22764 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060058ED RID: 22765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000217")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x60058EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60058ED")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x060058EE RID: 22766 RVA: 0x0000FD20 File Offset: 0x0000DF20
		// (set) Token: 0x060058EF RID: 22767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700121E")]
		public bool IsReady
		{
			[Token(Token = "0x60058EE")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60058EF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x060058F0 RID: 22768 RVA: 0x0000FD38 File Offset: 0x0000DF38
		[Token(Token = "0x1700121F")]
		public Rect Rect
		{
			[Token(Token = "0x60058F0")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x060058F1 RID: 22769 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058F2 RID: 22770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001220")]
		public string AssetId
		{
			[Token(Token = "0x60058F1")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058F2")]
			set
			{
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x060058F3 RID: 22771 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060058F4 RID: 22772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001221")]
		public string AssetPath
		{
			[Token(Token = "0x60058F3")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058F4")]
			set
			{
			}
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F5")]
		private void SetAssetPath(string value)
		{
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F6")]
		private void FailCallback(string resourceUrl)
		{
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F7")]
		private void CompleteCallback(TAsset asset, string resourceUrl)
		{
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x060058F8 RID: 22776 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001222")]
		public TGraphic AssetRender
		{
			[Token(Token = "0x60058F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F9")]
		private void OnDestroy()
		{
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058FA")]
		private void Awake()
		{
		}

		// Token: 0x060058FB RID: 22779
		[Token(Token = "0x60058FB")]
		public abstract void SetAsset(TAsset asset);

		// Token: 0x060058FC RID: 22780
		[Token(Token = "0x60058FC")]
		public abstract void ReleaseAsset(string url);

		// Token: 0x060058FD RID: 22781
		[Token(Token = "0x60058FD")]
		public abstract void LoadAsset(string url, Action<TAsset, string> successCallback, Action<string> failCallback, bool saveOnDisk);

		// Token: 0x060058FE RID: 22782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058FE")]
		protected AbstractGameGraphicLoader()
		{
		}

		// Token: 0x0400300D RID: 12301
		[Token(Token = "0x400300D")]
		[FieldOffset(Offset = "0x0")]
		private string _assetId;

		// Token: 0x0400300E RID: 12302
		[Token(Token = "0x400300E")]
		[FieldOffset(Offset = "0x0")]
		private string _assetPath;

		// Token: 0x0400300F RID: 12303
		[Token(Token = "0x400300F")]
		[FieldOffset(Offset = "0x0")]
		private TGraphic _assetRender;
	}
}
