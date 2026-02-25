using System;
using AssetContent.Loaders;
using Core.Data;
using Core.MVC.Interfaces;
using Gameplay.Discounts.View;
using Gameplay.Inventory.View.Info;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000652 RID: 1618
	[Token(Token = "0x2000652")]
	public class ArtifactActionPopupWindow : ClosableBaseWindow<ArtifactActionPopupWindow.ArtifactActionPopupWindowArgs>
	{
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600273F RID: 10047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000762")]
		public override string WindowId
		{
			[Token(Token = "0x600273F")]
			[Address(RVA = "0x7872", Offset = "0x7872", VA = "0x7872", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000763")]
		public ButtonWithCost CostButton
		{
			[Token(Token = "0x6002740")]
			[Address(RVA = "0x7873", Offset = "0x7873", VA = "0x7873")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002741 RID: 10049 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000764")]
		public ArtifactActionsView ActionsView
		{
			[Token(Token = "0x6002741")]
			[Address(RVA = "0x7874", Offset = "0x7874", VA = "0x7874")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000765")]
		public DiscountGroup DiscountGroup
		{
			[Token(Token = "0x6002742")]
			[Address(RVA = "0x7875", Offset = "0x7875", VA = "0x7875")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000766")]
		public GameObject BattleAccountTip
		{
			[Token(Token = "0x6002743")]
			[Address(RVA = "0x7876", Offset = "0x7876", VA = "0x7876")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002744")]
		[Address(RVA = "0x7877", Offset = "0x7877", VA = "0x7877", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002745")]
		[Address(RVA = "0x7878", Offset = "0x7878", VA = "0x7878", Slot = "22")]
		protected override void OnShow(ArtifactActionPopupWindow.ArtifactActionPopupWindowArgs args)
		{
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002746")]
		[Address(RVA = "0x7879", Offset = "0x7879", VA = "0x7879")]
		public void DrawArtifactInfo(ArtifactData artifactData)
		{
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002747")]
		[Address(RVA = "0x787A", Offset = "0x787A", VA = "0x787A", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002748")]
		[Address(RVA = "0x787B", Offset = "0x787B", VA = "0x787B")]
		public void EnableSale(bool enable)
		{
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002749")]
		[Address(RVA = "0x787C", Offset = "0x787C", VA = "0x787C")]
		public static ArtifactActionPopupWindow Show(ArtifactActionPopupWindow.ActionType type, ArtifactView artifactView, string actionName)
		{
			return null;
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600274A")]
		[Address(RVA = "0x787D", Offset = "0x787D", VA = "0x787D")]
		public static ArtifactActionPopupWindow ShowForGolem(ArtifactActionPopupWindow.ActionType type, ArtifactView artifactView, string actionName)
		{
			return null;
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600274B")]
		[Address(RVA = "0x787E", Offset = "0x787E", VA = "0x787E")]
		public ArtifactActionPopupWindow()
		{
		}

		// Token: 0x04001572 RID: 5490
		[Token(Token = "0x4001572")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ArtifactActionPopupWindow";

		// Token: 0x04001573 RID: 5491
		[Token(Token = "0x4001573")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x04001574 RID: 5492
		[Token(Token = "0x4001574")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameRawImageLoader _qualityBigBgLoader;

		// Token: 0x04001575 RID: 5493
		[Token(Token = "0x4001575")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x04001576 RID: 5494
		[Token(Token = "0x4001576")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtifactInfoPropertiesView _propertiesView;

		// Token: 0x04001577 RID: 5495
		[Token(Token = "0x4001577")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ArtifactActionsView _actionsView;

		// Token: 0x04001578 RID: 5496
		[Token(Token = "0x4001578")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DiscountGroup _discountGroup;

		// Token: 0x04001579 RID: 5497
		[Token(Token = "0x4001579")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameObject _battleAccountTip;

		// Token: 0x0400157A RID: 5498
		[Token(Token = "0x400157A")]
		[FieldOffset(Offset = "0x58")]
		private IViewMediator<ArtifactActionPopupWindow> _mediator;

		// Token: 0x02000653 RID: 1619
		[Token(Token = "0x2000653")]
		public class ArtifactActionPopupWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600274C RID: 10060 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600274C")]
			[Address(RVA = "0x787F", Offset = "0x787F", VA = "0x787F")]
			public ArtifactActionPopupWindowArgs()
			{
			}

			// Token: 0x0400157B RID: 5499
			[Token(Token = "0x400157B")]
			[FieldOffset(Offset = "0x18")]
			public IViewMediator<ArtifactActionPopupWindow> Mediator;

			// Token: 0x0400157C RID: 5500
			[Token(Token = "0x400157C")]
			[FieldOffset(Offset = "0x1C")]
			public ArtifactActionPopupWindow.ActionType ActionType;

			// Token: 0x0400157D RID: 5501
			[Token(Token = "0x400157D")]
			[FieldOffset(Offset = "0x20")]
			public ArtifactView ArtifactView;

			// Token: 0x0400157E RID: 5502
			[Token(Token = "0x400157E")]
			[FieldOffset(Offset = "0x24")]
			public string ActionName;
		}

		// Token: 0x02000654 RID: 1620
		[Token(Token = "0x2000654")]
		public enum ActionType
		{
			// Token: 0x04001580 RID: 5504
			[Token(Token = "0x4001580")]
			UNKNOWN_STATE,
			// Token: 0x04001581 RID: 5505
			[Token(Token = "0x4001581")]
			REFORGE,
			// Token: 0x04001582 RID: 5506
			[Token(Token = "0x4001582")]
			REPAIR
		}
	}
}
