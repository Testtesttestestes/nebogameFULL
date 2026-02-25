using System;
using System.Runtime.CompilerServices;
using AssetContent;
using CloudsFly;
using Core;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Isles.Base.View
{
	// Token: 0x02000CFA RID: 3322
	[Token(Token = "0x2000CFA")]
	public abstract class BaseIsleBuildingView : BaseWorldObjectRenderer
	{
		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x060050F4 RID: 20724 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001063")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x60050F4")]
			[Address(RVA = "0x1E1F", Offset = "0x1E1F", VA = "0x1E1F")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001E9 RID: 489
		// (add) Token: 0x060050F5 RID: 20725 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060050F6 RID: 20726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E9")]
		public event Action<uint> ClickedEvent
		{
			[Token(Token = "0x60050F5")]
			[Address(RVA = "0x3027", Offset = "0x3027", VA = "0x3027")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60050F6")]
			[Address(RVA = "0x3024", Offset = "0x3024", VA = "0x3024")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x060050F7 RID: 20727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001064")]
		public GameAssetViewSpriteRenderer AssetViewSpriteRenderer
		{
			[Token(Token = "0x60050F7")]
			[Address(RVA = "0x9EEB", Offset = "0x9EEB", VA = "0x9EEB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x060050F8 RID: 20728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001065")]
		private string UpgradeAnimationAssetId
		{
			[Token(Token = "0x60050F8")]
			[Address(RVA = "0x9EEC", Offset = "0x9EEC", VA = "0x9EEC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x060050F9 RID: 20729
		[Token(Token = "0x17001066")]
		public abstract uint Type { [Token(Token = "0x60050F9")] get; }

		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x060050FA RID: 20730 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		// (set) Token: 0x060050FB RID: 20731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001067")]
		public bool Interactable
		{
			[Token(Token = "0x60050FA")]
			[Address(RVA = "0x9EED", Offset = "0x9EED", VA = "0x9EED")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60050FB")]
			[Address(RVA = "0x1E21", Offset = "0x1E21", VA = "0x1E21")]
			set
			{
			}
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FC")]
		[Address(RVA = "0x9EEE", Offset = "0x9EEE", VA = "0x9EEE", Slot = "11")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FD")]
		[Address(RVA = "0x9EEF", Offset = "0x9EEF", VA = "0x9EEF")]
		private void AssetViewSpriteRendererOnReadyEvent(IAsyncLoadableContent obj)
		{
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FE")]
		[Address(RVA = "0x9EF0", Offset = "0x9EF0", VA = "0x9EF0")]
		private void AssetViewSpriteRendererOnClickedEvent(GameAssetViewSpriteRenderer gameAssetViewSpriteRenderer)
		{
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050FF")]
		[Address(RVA = "0x9EF1", Offset = "0x9EF1", VA = "0x9EF1", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06005100 RID: 20736 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005101 RID: 20737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001068")]
		public BaseBuildingData BuildingData
		{
			[Token(Token = "0x6005100")]
			[Address(RVA = "0x9EF2", Offset = "0x9EF2", VA = "0x9EF2")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005101")]
			[Address(RVA = "0x3025", Offset = "0x3025", VA = "0x3025")]
			set
			{
			}
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005102")]
		[Address(RVA = "0x9EF3", Offset = "0x9EF3", VA = "0x9EF3", Slot = "13")]
		protected virtual void HandleBuildingDataChanged()
		{
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005103")]
		[Address(RVA = "0x9EF4", Offset = "0x9EF4", VA = "0x9EF4")]
		protected void ValidateUpgradingAnimation()
		{
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005104")]
		[Address(RVA = "0x9EF5", Offset = "0x9EF5", VA = "0x9EF5", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005105")]
		[Address(RVA = "0x9EF6", Offset = "0x9EF6", VA = "0x9EF6", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005106")]
		[Address(RVA = "0x9EF7", Offset = "0x9EF7", VA = "0x9EF7")]
		protected BaseIsleBuildingView()
		{
		}

		// Token: 0x04002C1E RID: 11294
		[Token(Token = "0x4002C1E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _assetViewSpriteRenderer;

		// Token: 0x04002C1F RID: 11295
		[Token(Token = "0x4002C1F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _upgradeAnimation;

		// Token: 0x04002C20 RID: 11296
		[Token(Token = "0x4002C20")]
		[FieldOffset(Offset = "0x2C")]
		private IGuideTarget _guideTarget;

		// Token: 0x04002C22 RID: 11298
		[Token(Token = "0x4002C22")]
		[FieldOffset(Offset = "0x34")]
		private string _upgradeAnimationAssetId;

		// Token: 0x04002C23 RID: 11299
		[Token(Token = "0x4002C23")]
		[FieldOffset(Offset = "0x38")]
		private BaseBuildingData _buildingData;
	}
}
