using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using CloudsFly;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Isles.Base.View
{
	// Token: 0x02000CFB RID: 3323
	[Token(Token = "0x2000CFB")]
	public class BaseIsleView : BaseWorldObjectRenderer
	{
		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06005107 RID: 20743 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001069")]
		public ToolTip ToolTip
		{
			[Token(Token = "0x6005107")]
			[Address(RVA = "0x9EF8", Offset = "0x9EF8", VA = "0x9EF8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06005108 RID: 20744 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700106A")]
		public GameSpriteRendererLoaderInteractable BgSprite
		{
			[Token(Token = "0x6005108")]
			[Address(RVA = "0x9EF9", Offset = "0x9EF9", VA = "0x9EF9")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001EA RID: 490
		// (add) Token: 0x06005109 RID: 20745 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600510A RID: 20746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001EA")]
		public event Action OnClickEvent
		{
			[Token(Token = "0x6005109")]
			[Address(RVA = "0x9EFA", Offset = "0x9EFA", VA = "0x9EFA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600510A")]
			[Address(RVA = "0x9EFB", Offset = "0x9EFB", VA = "0x9EFB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600510B")]
		[Address(RVA = "0x9EFC", Offset = "0x9EFC", VA = "0x9EFC")]
		private void Start()
		{
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600510C")]
		[Address(RVA = "0x9EFD", Offset = "0x9EFD", VA = "0x9EFD")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600510D")]
		[Address(RVA = "0x9EFE", Offset = "0x9EFE", VA = "0x9EFE")]
		private void OnPointerClick()
		{
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600510E")]
		[Address(RVA = "0x9EFF", Offset = "0x9EFF", VA = "0x9EFF", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600510F")]
		[Address(RVA = "0x9F00", Offset = "0x9F00", VA = "0x9F00", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700106B")]
		public Dictionary<uint, BaseIsleBuildingView> BuildingViews
		{
			[Token(Token = "0x6005110")]
			[Address(RVA = "0x3029", Offset = "0x3029", VA = "0x3029")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005111")]
		[Address(RVA = "0x9F01", Offset = "0x9F01", VA = "0x9F01")]
		public BaseIsleView()
		{
		}

		// Token: 0x04002C24 RID: 11300
		[Token(Token = "0x4002C24")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BaseIsleBuildingView[] _buildings;

		// Token: 0x04002C25 RID: 11301
		[Token(Token = "0x4002C25")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameSpriteRendererLoaderInteractable _spriteLoader;

		// Token: 0x04002C26 RID: 11302
		[Token(Token = "0x4002C26")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x04002C28 RID: 11304
		[Token(Token = "0x4002C28")]
		[FieldOffset(Offset = "0x34")]
		private Dictionary<uint, BaseIsleBuildingView> _buildingViews;
	}
}
