using System;
using Gameplay.Clans.Office.Controller;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View.AboutClansTab;
using Gameplay.Clans.Office.View.ClanCreationTab;
using Gameplay.Clans.Office.View.VacanciesTab;
using Gameplay.World.Controller;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009FB RID: 2555
	[Token(Token = "0x20009FB")]
	public class ClanOfficeWindow : ClosableBaseWindow<ClanOfficeWindow.ClanOfficeWindowArgs>
	{
		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06003CD9 RID: 15577 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BFF")]
		public override string WindowId
		{
			[Token(Token = "0x6003CD9")]
			[Address(RVA = "0x8B99", Offset = "0x8B99", VA = "0x8B99", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06003CDA RID: 15578 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C00")]
		public ClanCreationView ClanCreationTab
		{
			[Token(Token = "0x6003CDA")]
			[Address(RVA = "0x8B9A", Offset = "0x8B9A", VA = "0x8B9A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06003CDB RID: 15579 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C01")]
		public VacanciesView VacanciesTab
		{
			[Token(Token = "0x6003CDB")]
			[Address(RVA = "0x8B9B", Offset = "0x8B9B", VA = "0x8B9B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06003CDC RID: 15580 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C02")]
		public AboutClansView AboutClansTab
		{
			[Token(Token = "0x6003CDC")]
			[Address(RVA = "0x8B9C", Offset = "0x8B9C", VA = "0x8B9C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x06003CDD RID: 15581 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C03")]
		public TabBar TabBar
		{
			[Token(Token = "0x6003CDD")]
			[Address(RVA = "0x8B9D", Offset = "0x8B9D", VA = "0x8B9D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CDE")]
		[Address(RVA = "0x8B9E", Offset = "0x8B9E", VA = "0x8B9E", Slot = "22")]
		protected override void OnShow(ClanOfficeWindow.ClanOfficeWindowArgs args)
		{
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CDF")]
		[Address(RVA = "0x8B9F", Offset = "0x8B9F", VA = "0x8B9F", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE0")]
		[Address(RVA = "0x8BA0", Offset = "0x8BA0", VA = "0x8BA0")]
		private void SetupMVC()
		{
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE1")]
		[Address(RVA = "0x8BA1", Offset = "0x8BA1", VA = "0x8BA1")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE2")]
		[Address(RVA = "0x8BA2", Offset = "0x8BA2", VA = "0x8BA2")]
		public ClanOfficeWindow()
		{
		}

		// Token: 0x040021BB RID: 8635
		[Token(Token = "0x40021BB")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Office/ClanOfficeWindow";

		// Token: 0x040021BC RID: 8636
		[Token(Token = "0x40021BC")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x040021BD RID: 8637
		[Token(Token = "0x40021BD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ClanCreationView _clanCreationTab;

		// Token: 0x040021BE RID: 8638
		[Token(Token = "0x40021BE")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private VacanciesView _vacanciesTab;

		// Token: 0x040021BF RID: 8639
		[Token(Token = "0x40021BF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AboutClansView _aboutClansTab;

		// Token: 0x040021C0 RID: 8640
		[Token(Token = "0x40021C0")]
		[FieldOffset(Offset = "0x4C")]
		private ClanOfficeViewMediator _mediator;

		// Token: 0x040021C1 RID: 8641
		[Token(Token = "0x40021C1")]
		[FieldOffset(Offset = "0x50")]
		private ClanOfficeController _controller;

		// Token: 0x040021C2 RID: 8642
		[Token(Token = "0x40021C2")]
		[FieldOffset(Offset = "0x54")]
		private ClanOfficeModel _model;

		// Token: 0x040021C3 RID: 8643
		[Token(Token = "0x40021C3")]
		[FieldOffset(Offset = "0x58")]
		private ClanOfficeEvents _events;

		// Token: 0x020009FC RID: 2556
		[Token(Token = "0x20009FC")]
		public class ClanOfficeWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003CE3 RID: 15587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CE3")]
			[Address(RVA = "0x8BA3", Offset = "0x8BA3", VA = "0x8BA3")]
			public ClanOfficeWindowArgs()
			{
			}

			// Token: 0x040021C4 RID: 8644
			[Token(Token = "0x40021C4")]
			[FieldOffset(Offset = "0x18")]
			public IUserIslesWorldMovement UserWorldMovement;
		}
	}
}
