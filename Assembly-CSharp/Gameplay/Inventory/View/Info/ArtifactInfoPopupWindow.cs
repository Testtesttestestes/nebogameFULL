using System;
using AssetContent.Loaders;
using Core.Data;
using Core.Gameplay.Managers.Inventory;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using Protocol.Main;
using TMPro;
using UI.Wiki;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Inventory.View.Info
{
	// Token: 0x02000668 RID: 1640
	[Token(Token = "0x2000668")]
	public class ArtifactInfoPopupWindow : ClosableBaseWindow<ArtifactInfoPopupWindowArgs>
	{
		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060027D8 RID: 10200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700078B")]
		public override string WindowId
		{
			[Token(Token = "0x60027D8")]
			[Address(RVA = "0x78FE", Offset = "0x78FE", VA = "0x78FE", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x78FF", Offset = "0x78FF", VA = "0x78FF", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DA")]
		[Address(RVA = "0x7900", Offset = "0x7900", VA = "0x7900", Slot = "22")]
		protected override void OnShow(ArtifactInfoPopupWindowArgs args)
		{
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DB")]
		[Address(RVA = "0x7901", Offset = "0x7901", VA = "0x7901")]
		protected void InventoryChangedEvent()
		{
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DC")]
		[Address(RVA = "0x7902", Offset = "0x7902", VA = "0x7902")]
		private void ArtifactChangedEventHandler()
		{
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DD")]
		[Address(RVA = "0x7903", Offset = "0x7903", VA = "0x7903")]
		protected void OnArtifactDropRemoveEvent(DropTypes dropTypes, ArtifactData artifactData)
		{
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DE")]
		[Address(RVA = "0x7904", Offset = "0x7904", VA = "0x7904")]
		private void HandleArtifactChanged(ArtifactData data)
		{
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027DF")]
		[Address(RVA = "0x7905", Offset = "0x7905", VA = "0x7905")]
		private void DrawArtifactInfo(ArtifactData artifactData)
		{
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x7906", Offset = "0x7906", VA = "0x7906", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x7907", Offset = "0x7907", VA = "0x7907")]
		public ArtifactInfoPopupWindow()
		{
		}

		// Token: 0x040015D3 RID: 5587
		[Token(Token = "0x40015D3")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ArtifactInfoPopupWindow";

		// Token: 0x040015D4 RID: 5588
		[Token(Token = "0x40015D4")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x040015D5 RID: 5589
		[Token(Token = "0x40015D5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _descriptionLabel;

		// Token: 0x040015D6 RID: 5590
		[Token(Token = "0x40015D6")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameRawImageLoader _qualityBigBgLoader;

		// Token: 0x040015D7 RID: 5591
		[Token(Token = "0x40015D7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x040015D8 RID: 5592
		[Token(Token = "0x40015D8")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ArtifactInfoPropertiesView _propertiesView;

		// Token: 0x040015D9 RID: 5593
		[Token(Token = "0x40015D9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactNotesView _notesView;

		// Token: 0x040015DA RID: 5594
		[Token(Token = "0x40015DA")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ArtifactInfoActionButtonsView _actionButtonsView;

		// Token: 0x040015DB RID: 5595
		[Token(Token = "0x40015DB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _descriptionGroup;

		// Token: 0x040015DC RID: 5596
		[Token(Token = "0x40015DC")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private WikiUriRouter _wiki;

		// Token: 0x040015DD RID: 5597
		[Token(Token = "0x40015DD")]
		[FieldOffset(Offset = "0x60")]
		private IInventoryManager _inventoryManager;

		// Token: 0x040015DE RID: 5598
		[Token(Token = "0x40015DE")]
		[FieldOffset(Offset = "0x64")]
		private UserData _user;
	}
}
