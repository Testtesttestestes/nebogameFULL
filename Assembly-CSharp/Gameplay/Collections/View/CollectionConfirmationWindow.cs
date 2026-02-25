using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Collections.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009BD RID: 2493
	[Token(Token = "0x20009BD")]
	public class CollectionConfirmationWindow : ClosableBaseWindow<CollectionConfirmationWindow.CollectionConfirmationWindowArgs>
	{
		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06003BB7 RID: 15287 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BC8")]
		public override string WindowId
		{
			[Token(Token = "0x6003BB7")]
			[Address(RVA = "0x8A8D", Offset = "0x8A8D", VA = "0x8A8D", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB8")]
		[Address(RVA = "0x8A8E", Offset = "0x8A8E", VA = "0x8A8E", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB9")]
		[Address(RVA = "0x8A8F", Offset = "0x8A8F", VA = "0x8A8F")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBA")]
		[Address(RVA = "0x8A90", Offset = "0x8A90", VA = "0x8A90", Slot = "22")]
		protected override void OnShow(CollectionConfirmationWindow.CollectionConfirmationWindowArgs args)
		{
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBB")]
		[Address(RVA = "0x8A91", Offset = "0x8A91", VA = "0x8A91")]
		private void SetCollectionViews(UserData user, CollectionData data)
		{
		}

		// Token: 0x06003BBC RID: 15292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBC")]
		[Address(RVA = "0x8A92", Offset = "0x8A92", VA = "0x8A92")]
		private void UpgradeButtonClickedEventHandler()
		{
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BBD")]
		[Address(RVA = "0x8A93", Offset = "0x8A93", VA = "0x8A93")]
		public CollectionConfirmationWindow()
		{
		}

		// Token: 0x040020DA RID: 8410
		[Token(Token = "0x40020DA")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Collections/CollectionConfirmationWindow";

		// Token: 0x040020DB RID: 8411
		[Token(Token = "0x40020DB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040020DC RID: 8412
		[Token(Token = "0x40020DC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _confirmationText;

		// Token: 0x040020DD RID: 8413
		[Token(Token = "0x40020DD")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private CollectionView _currentCollection;

		// Token: 0x040020DE RID: 8414
		[Token(Token = "0x40020DE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CollectionView _nextCollection;

		// Token: 0x040020DF RID: 8415
		[Token(Token = "0x40020DF")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private CollectionRequirementsDisplay _requirements;

		// Token: 0x040020E0 RID: 8416
		[Token(Token = "0x40020E0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _transitionImage;

		// Token: 0x040020E1 RID: 8417
		[Token(Token = "0x40020E1")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _upgradeButton;

		// Token: 0x040020E2 RID: 8418
		[Token(Token = "0x40020E2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _cancelButton;

		// Token: 0x020009BE RID: 2494
		[Token(Token = "0x20009BE")]
		public class CollectionConfirmationWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003BBE RID: 15294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003BBE")]
			[Address(RVA = "0x8A94", Offset = "0x8A94", VA = "0x8A94")]
			public CollectionConfirmationWindowArgs()
			{
			}

			// Token: 0x040020E3 RID: 8419
			[Token(Token = "0x40020E3")]
			[FieldOffset(Offset = "0x18")]
			public CollectionData CollectionData;

			// Token: 0x040020E4 RID: 8420
			[Token(Token = "0x40020E4")]
			[FieldOffset(Offset = "0x1C")]
			public List<CollectionsModel.CollectionMaterial> Materials;

			// Token: 0x040020E5 RID: 8421
			[Token(Token = "0x40020E5")]
			[FieldOffset(Offset = "0x20")]
			public UserData User;

			// Token: 0x040020E6 RID: 8422
			[Token(Token = "0x40020E6")]
			[FieldOffset(Offset = "0x24")]
			public Action CollectionUpgradeRequestedEvent;
		}
	}
}
