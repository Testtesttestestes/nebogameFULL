using System;
using Gameplay.Inventory.View.Chest;
using Gameplay.Medals.Controller;
using Gameplay.Medals.Events;
using Gameplay.Medals.Model;
using Il2CppDummyDll;
using UI.Filters;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Medals.View
{
	// Token: 0x020005FB RID: 1531
	[Token(Token = "0x20005FB")]
	public class MedalsWindow : ClosableBaseWindow<MedalsWindowArgs>
	{
		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006F8")]
		public override string WindowId
		{
			[Token(Token = "0x600252C")]
			[Address(RVA = "0x7675", Offset = "0x7675", VA = "0x7675", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006F9")]
		public TabBar TabBarView
		{
			[Token(Token = "0x600252D")]
			[Address(RVA = "0x7676", Offset = "0x7676", VA = "0x7676")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006FA")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x600252E")]
			[Address(RVA = "0x7677", Offset = "0x7677", VA = "0x7677")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006FB")]
		public MedalsGridView MedalsGridView
		{
			[Token(Token = "0x600252F")]
			[Address(RVA = "0x7678", Offset = "0x7678", VA = "0x7678")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002530")]
		[Address(RVA = "0x7679", Offset = "0x7679", VA = "0x7679", Slot = "22")]
		protected override void OnShow(MedalsWindowArgs args)
		{
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002531")]
		[Address(RVA = "0x767A", Offset = "0x767A", VA = "0x767A")]
		private void SetupMvc()
		{
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002532")]
		[Address(RVA = "0x767B", Offset = "0x767B", VA = "0x767B")]
		private void DestroyMvc()
		{
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002533")]
		[Address(RVA = "0x767C", Offset = "0x767C", VA = "0x767C")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002534")]
		[Address(RVA = "0x767D", Offset = "0x767D", VA = "0x767D")]
		public MedalsWindow()
		{
		}

		// Token: 0x04001454 RID: 5204
		[Token(Token = "0x4001454")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Medals/MedalsWindow";

		// Token: 0x04001455 RID: 5205
		[Token(Token = "0x4001455")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x04001456 RID: 5206
		[Token(Token = "0x4001456")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MedalsGridView _medalsGridView;

		// Token: 0x04001457 RID: 5207
		[Token(Token = "0x4001457")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04001458 RID: 5208
		[Token(Token = "0x4001458")]
		[FieldOffset(Offset = "0x48")]
		private bool _isMvcInitialized;

		// Token: 0x04001459 RID: 5209
		[Token(Token = "0x4001459")]
		[FieldOffset(Offset = "0x4C")]
		private MedalsEvents _events;

		// Token: 0x0400145A RID: 5210
		[Token(Token = "0x400145A")]
		[FieldOffset(Offset = "0x50")]
		private MedalsModel _model;

		// Token: 0x0400145B RID: 5211
		[Token(Token = "0x400145B")]
		[FieldOffset(Offset = "0x54")]
		private MedalsViewMediator _mediator;

		// Token: 0x0400145C RID: 5212
		[Token(Token = "0x400145C")]
		[FieldOffset(Offset = "0x58")]
		private MedalsController _controller;

		// Token: 0x0400145D RID: 5213
		[Token(Token = "0x400145D")]
		[FieldOffset(Offset = "0x5C")]
		private MedalsWindowArgs _windowArgs;
	}
}
