using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Collections.Controller;
using Il2CppDummyDll;
using TMPro;
using UI.Rewards;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009C0 RID: 2496
	[Token(Token = "0x20009C0")]
	public class CollectionInfoWindow : ClosableBaseWindow<CollectionInfoWindow.CollectionInfoWindowArgs>
	{
		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06003BCD RID: 15309 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BCD")]
		public override string WindowId
		{
			[Token(Token = "0x6003BCD")]
			[Address(RVA = "0x8AA1", Offset = "0x8AA1", VA = "0x8AA1", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06003BCE RID: 15310 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BCE")]
		public Button UpgradeButton
		{
			[Token(Token = "0x6003BCE")]
			[Address(RVA = "0x8AA2", Offset = "0x8AA2", VA = "0x8AA2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06003BCF RID: 15311 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BCF")]
		public CollectionRequirementsDisplay Requirements
		{
			[Token(Token = "0x6003BCF")]
			[Address(RVA = "0x8AA3", Offset = "0x8AA3", VA = "0x8AA3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06003BD0 RID: 15312 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BD0")]
		public Button NextButton
		{
			[Token(Token = "0x6003BD0")]
			[Address(RVA = "0x8AA4", Offset = "0x8AA4", VA = "0x8AA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06003BD1 RID: 15313 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BD1")]
		public Button PrevButton
		{
			[Token(Token = "0x6003BD1")]
			[Address(RVA = "0x8AA5", Offset = "0x8AA5", VA = "0x8AA5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06003BD2 RID: 15314 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BD2")]
		public GameObject Content
		{
			[Token(Token = "0x6003BD2")]
			[Address(RVA = "0x8AA6", Offset = "0x8AA6", VA = "0x8AA6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD3")]
		[Address(RVA = "0x8AA7", Offset = "0x8AA7", VA = "0x8AA7", Slot = "22")]
		protected override void OnShow(CollectionInfoWindow.CollectionInfoWindowArgs args)
		{
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD4")]
		[Address(RVA = "0x8AA8", Offset = "0x8AA8", VA = "0x8AA8", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD5")]
		[Address(RVA = "0x8AA9", Offset = "0x8AA9", VA = "0x8AA9")]
		public void UpdateWindow(CollectionData data, uint rankToShow)
		{
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD6")]
		[Address(RVA = "0x8AAA", Offset = "0x8AAA", VA = "0x8AAA")]
		private void SetupMVC()
		{
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD7")]
		[Address(RVA = "0x8AAB", Offset = "0x8AAB", VA = "0x8AAB")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD8")]
		[Address(RVA = "0x8AAC", Offset = "0x8AAC", VA = "0x8AAC")]
		public CollectionInfoWindow()
		{
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BD9")]
		[Address(RVA = "0x8AAD", Offset = "0x8AAD", VA = "0x8AAD")]
		[CompilerGenerated]
		private void <UpdateWindow>g__UpdateButtonText|27_0(ref CollectionInfoWindow.<>c__DisplayClass27_0 A_1)
		{
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDA")]
		[Address(RVA = "0x8AAE", Offset = "0x8AAE", VA = "0x8AAE")]
		[CompilerGenerated]
		private void <UpdateWindow>g__UpdateStatusText|27_1(ref CollectionInfoWindow.<>c__DisplayClass27_0 A_1)
		{
		}

		// Token: 0x06003BDB RID: 15323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDB")]
		[Address(RVA = "0x8AAF", Offset = "0x8AAF", VA = "0x8AAF")]
		[CompilerGenerated]
		private void <UpdateWindow>g__HandleCollectionView|27_2(ref CollectionInfoWindow.<>c__DisplayClass27_0 A_1)
		{
		}

		// Token: 0x040020F4 RID: 8436
		[Token(Token = "0x40020F4")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Collections/CollectionInfoWindow";

		// Token: 0x040020F5 RID: 8437
		[Token(Token = "0x40020F5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CollectionView _collectionView;

		// Token: 0x040020F6 RID: 8438
		[Token(Token = "0x40020F6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x040020F7 RID: 8439
		[Token(Token = "0x40020F7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _descriptionLabel;

		// Token: 0x040020F8 RID: 8440
		[Token(Token = "0x40020F8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _upgradeButton;

		// Token: 0x040020F9 RID: 8441
		[Token(Token = "0x40020F9")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private CollectionRequirementsDisplay _requirements;

		// Token: 0x040020FA RID: 8442
		[Token(Token = "0x40020FA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _nextButton;

		// Token: 0x040020FB RID: 8443
		[Token(Token = "0x40020FB")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _prevButton;

		// Token: 0x040020FC RID: 8444
		[Token(Token = "0x40020FC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _statusText;

		// Token: 0x040020FD RID: 8445
		[Token(Token = "0x40020FD")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject _descriptionGroup;

		// Token: 0x040020FE RID: 8446
		[Token(Token = "0x40020FE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _content;

		// Token: 0x040020FF RID: 8447
		[Token(Token = "0x40020FF")]
		[FieldOffset(Offset = "0x64")]
		private CollectionInfoViewMediator _mediator;

		// Token: 0x04002100 RID: 8448
		[Token(Token = "0x4002100")]
		[FieldOffset(Offset = "0x68")]
		private bool _mvcSetUp;

		// Token: 0x020009C1 RID: 2497
		[Token(Token = "0x20009C1")]
		public class CollectionInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003BDC RID: 15324 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003BDC")]
			[Address(RVA = "0x8AB0", Offset = "0x8AB0", VA = "0x8AB0")]
			public CollectionInfoWindowArgs(CollectionsController controller, UserData user, uint collectionId, uint rank)
			{
			}

			// Token: 0x04002101 RID: 8449
			[Token(Token = "0x4002101")]
			[FieldOffset(Offset = "0x18")]
			public UserData User;

			// Token: 0x04002102 RID: 8450
			[Token(Token = "0x4002102")]
			[FieldOffset(Offset = "0x1C")]
			public readonly uint CollectionId;

			// Token: 0x04002103 RID: 8451
			[Token(Token = "0x4002103")]
			[FieldOffset(Offset = "0x20")]
			public readonly CollectionsController CollectionsController;

			// Token: 0x04002104 RID: 8452
			[Token(Token = "0x4002104")]
			[FieldOffset(Offset = "0x24")]
			public readonly uint Rank;
		}
	}
}
