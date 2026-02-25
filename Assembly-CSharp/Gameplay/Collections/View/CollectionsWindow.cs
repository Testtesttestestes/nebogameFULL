using System;
using System.Collections.Generic;
using Core.Data;
using Core.Gameplay;
using Gameplay.Collections.Controller;
using Gameplay.Collections.Events;
using Gameplay.Collections.Model;
using Gameplay.Collections.Model.Factories;
using Il2CppDummyDll;
using UI.Filters;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009CC RID: 2508
	[Token(Token = "0x20009CC")]
	public class CollectionsWindow : ClosableBaseWindow<CollectionsWindow.CollectionsWindowArgs>
	{
		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06003C11 RID: 15377 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BD8")]
		public override string WindowId
		{
			[Token(Token = "0x6003C11")]
			[Address(RVA = "0x8AE0", Offset = "0x8AE0", VA = "0x8AE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06003C12 RID: 15378 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BD9")]
		public TabBar TabBarView
		{
			[Token(Token = "0x6003C12")]
			[Address(RVA = "0x8AE1", Offset = "0x8AE1", VA = "0x8AE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06003C13 RID: 15379 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BDA")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x6003C13")]
			[Address(RVA = "0x8AE2", Offset = "0x8AE2", VA = "0x8AE2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06003C14 RID: 15380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BDB")]
		public Button FrescoButton
		{
			[Token(Token = "0x6003C14")]
			[Address(RVA = "0x8AE3", Offset = "0x8AE3", VA = "0x8AE3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C15")]
		[Address(RVA = "0x8AE4", Offset = "0x8AE4", VA = "0x8AE4", Slot = "22")]
		protected override void OnShow(CollectionsWindow.CollectionsWindowArgs args)
		{
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C16")]
		[Address(RVA = "0x8AE5", Offset = "0x8AE5", VA = "0x8AE5", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06003C17 RID: 15383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C17")]
		[Address(RVA = "0x8AE6", Offset = "0x8AE6", VA = "0x8AE6")]
		public void Init(IList<CollectionListElement.CollectionListElementArgs> items)
		{
		}

		// Token: 0x06003C18 RID: 15384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C18")]
		[Address(RVA = "0x8AE7", Offset = "0x8AE7", VA = "0x8AE7")]
		private void SetupMVC()
		{
		}

		// Token: 0x06003C19 RID: 15385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C19")]
		[Address(RVA = "0x8AE8", Offset = "0x8AE8", VA = "0x8AE8")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C1A")]
		[Address(RVA = "0x8AE9", Offset = "0x8AE9", VA = "0x8AE9")]
		public CollectionsWindow()
		{
		}

		// Token: 0x04002124 RID: 8484
		[Token(Token = "0x4002124")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Collections/CollectionsWindow";

		// Token: 0x04002125 RID: 8485
		[Token(Token = "0x4002125")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CollectionsOSAView _collectionsOSAView;

		// Token: 0x04002126 RID: 8486
		[Token(Token = "0x4002126")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x04002127 RID: 8487
		[Token(Token = "0x4002127")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04002128 RID: 8488
		[Token(Token = "0x4002128")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _frescoButton;

		// Token: 0x04002129 RID: 8489
		[Token(Token = "0x4002129")]
		[FieldOffset(Offset = "0x4C")]
		private CollectionDataFactory _collectionDataFactory;

		// Token: 0x0400212A RID: 8490
		[Token(Token = "0x400212A")]
		[FieldOffset(Offset = "0x50")]
		private CollectionsModel _model;

		// Token: 0x0400212B RID: 8491
		[Token(Token = "0x400212B")]
		[FieldOffset(Offset = "0x54")]
		private CollectionsEvents _events;

		// Token: 0x0400212C RID: 8492
		[Token(Token = "0x400212C")]
		[FieldOffset(Offset = "0x58")]
		private CollectionsController _controller;

		// Token: 0x0400212D RID: 8493
		[Token(Token = "0x400212D")]
		[FieldOffset(Offset = "0x5C")]
		private CollectionsViewMediator _mediator;

		// Token: 0x0400212E RID: 8494
		[Token(Token = "0x400212E")]
		[FieldOffset(Offset = "0x60")]
		private bool _mvcSetUp;

		// Token: 0x020009CD RID: 2509
		[Token(Token = "0x20009CD")]
		public class CollectionsWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003C1B RID: 15387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C1B")]
			[Address(RVA = "0x8AEA", Offset = "0x8AEA", VA = "0x8AEA")]
			public CollectionsWindowArgs(UserData owner, UserData loggedUser, IGame game)
			{
			}

			// Token: 0x06003C1C RID: 15388 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003C1C")]
			[Address(RVA = "0x8AEB", Offset = "0x8AEB", VA = "0x8AEB")]
			public CollectionsWindowArgs(CollectionsController controller)
			{
			}

			// Token: 0x0400212F RID: 8495
			[Token(Token = "0x400212F")]
			[FieldOffset(Offset = "0x18")]
			public readonly CollectionsController Controller;

			// Token: 0x04002130 RID: 8496
			[Token(Token = "0x4002130")]
			[FieldOffset(Offset = "0x1C")]
			public readonly UserData Owner;

			// Token: 0x04002131 RID: 8497
			[Token(Token = "0x4002131")]
			[FieldOffset(Offset = "0x20")]
			public readonly UserData LoggedUser;

			// Token: 0x04002132 RID: 8498
			[Token(Token = "0x4002132")]
			[FieldOffset(Offset = "0x24")]
			public readonly IGame Game;

			// Token: 0x04002133 RID: 8499
			[Token(Token = "0x4002133")]
			[FieldOffset(Offset = "0x28")]
			public Predicate<CollectionData> CustomFilter;
		}
	}
}
