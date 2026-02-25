using System;
using AssetContent.Loaders;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Wiki;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Inventory.View.Info
{
	// Token: 0x0200066D RID: 1645
	[Token(Token = "0x200066D")]
	public class ArtikulInfoPopupWindow : ClosableBaseWindow<ArtikulInfoPopupWindow.ArtikulInfoPopupWindowArgs>
	{
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000792")]
		public override string WindowId
		{
			[Token(Token = "0x60027EF")]
			[Address(RVA = "0x7915", Offset = "0x7915", VA = "0x7915", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F0")]
		[Address(RVA = "0x7916", Offset = "0x7916", VA = "0x7916", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F1")]
		[Address(RVA = "0x7917", Offset = "0x7917", VA = "0x7917", Slot = "22")]
		protected override void OnShow(ArtikulInfoPopupWindow.ArtikulInfoPopupWindowArgs args)
		{
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F2")]
		[Address(RVA = "0x7918", Offset = "0x7918", VA = "0x7918")]
		public ArtikulInfoPopupWindow()
		{
		}

		// Token: 0x040015EC RID: 5612
		[Token(Token = "0x40015EC")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ArtikulInfoPopupWindow";

		// Token: 0x040015ED RID: 5613
		[Token(Token = "0x40015ED")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x040015EE RID: 5614
		[Token(Token = "0x40015EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _descriptionLabel;

		// Token: 0x040015EF RID: 5615
		[Token(Token = "0x40015EF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameRawImageLoader _qualityBigBgLoader;

		// Token: 0x040015F0 RID: 5616
		[Token(Token = "0x40015F0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x040015F1 RID: 5617
		[Token(Token = "0x40015F1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ArtifactInfoPropertiesView _propertiesView;

		// Token: 0x040015F2 RID: 5618
		[Token(Token = "0x40015F2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _descriotionGroup;

		// Token: 0x040015F3 RID: 5619
		[Token(Token = "0x40015F3")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private WikiUriRouter _wiki;

		// Token: 0x0200066E RID: 1646
		[Token(Token = "0x200066E")]
		public class ArtikulInfoPopupWindowArgs : BaseWindowArgs
		{
			// Token: 0x060027F3 RID: 10227 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60027F3")]
			[Address(RVA = "0x7919", Offset = "0x7919", VA = "0x7919")]
			public ArtikulInfoPopupWindowArgs()
			{
			}

			// Token: 0x040015F4 RID: 5620
			[Token(Token = "0x40015F4")]
			[FieldOffset(Offset = "0x18")]
			public ArtikulView ArtikulView;

			// Token: 0x040015F5 RID: 5621
			[Token(Token = "0x40015F5")]
			[FieldOffset(Offset = "0x1C")]
			public ArtikulData Data;

			// Token: 0x040015F6 RID: 5622
			[Token(Token = "0x40015F6")]
			[FieldOffset(Offset = "0x20")]
			public uint OptionId;
		}
	}
}
