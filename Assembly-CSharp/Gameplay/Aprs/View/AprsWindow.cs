using System;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Controller;
using Gameplay.Aprs.Events;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Filters;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D55 RID: 3413
	[Token(Token = "0x2000D55")]
	public class AprsWindow : ClosableBaseWindow<AprsWindowArgs>
	{
		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x060053B3 RID: 21427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001100")]
		public override string WindowId
		{
			[Token(Token = "0x60053B3")]
			[Address(RVA = "0xA172", Offset = "0xA172", VA = "0xA172", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x060053B4 RID: 21428 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001101")]
		public AprsOsaGridView AprsOsaGridView
		{
			[Token(Token = "0x60053B4")]
			[Address(RVA = "0xA173", Offset = "0xA173", VA = "0xA173")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001FF RID: 511
		// (add) Token: 0x060053B5 RID: 21429 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060053B6 RID: 21430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001FF")]
		public event Action<AprData> AprClickEvent
		{
			[Token(Token = "0x60053B5")]
			[Address(RVA = "0xA174", Offset = "0xA174", VA = "0xA174")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60053B6")]
			[Address(RVA = "0xA175", Offset = "0xA175", VA = "0xA175")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x060053B7 RID: 21431 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001102")]
		public TabBar TabBarView
		{
			[Token(Token = "0x60053B7")]
			[Address(RVA = "0xA176", Offset = "0xA176", VA = "0xA176")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x060053B8 RID: 21432 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001103")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x60053B8")]
			[Address(RVA = "0xA177", Offset = "0xA177", VA = "0xA177")]
			get
			{
				return null;
			}
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B9")]
		[Address(RVA = "0xA178", Offset = "0xA178", VA = "0xA178", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BA")]
		[Address(RVA = "0xA179", Offset = "0xA179", VA = "0xA179")]
		private void AprGridViewOnSelectEvent(AprGridView aprGridView)
		{
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BB")]
		[Address(RVA = "0xA17A", Offset = "0xA17A", VA = "0xA17A", Slot = "22")]
		protected override void OnShow(AprsWindowArgs args)
		{
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BC")]
		[Address(RVA = "0xA17B", Offset = "0xA17B", VA = "0xA17B")]
		private void SetupMvc()
		{
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BD")]
		[Address(RVA = "0xA17C", Offset = "0xA17C", VA = "0xA17C")]
		private void DestroyMvc()
		{
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BE")]
		[Address(RVA = "0xA17D", Offset = "0xA17D", VA = "0xA17D")]
		private void OnDestroy()
		{
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053BF")]
		[Address(RVA = "0xA17E", Offset = "0xA17E", VA = "0xA17E")]
		public AprsWindow()
		{
		}

		// Token: 0x04002D59 RID: 11609
		[Token(Token = "0x4002D59")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Aprs/AprsWindow";

		// Token: 0x04002D5A RID: 11610
		[Token(Token = "0x4002D5A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x04002D5B RID: 11611
		[Token(Token = "0x4002D5B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04002D5C RID: 11612
		[Token(Token = "0x4002D5C")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private AprsOsaGridView _aprsOsaGridView;

		// Token: 0x04002D5E RID: 11614
		[Token(Token = "0x4002D5E")]
		[FieldOffset(Offset = "0x4C")]
		private bool _isMvcInitialized;

		// Token: 0x04002D5F RID: 11615
		[Token(Token = "0x4002D5F")]
		[FieldOffset(Offset = "0x50")]
		private AprsEvents _events;

		// Token: 0x04002D60 RID: 11616
		[Token(Token = "0x4002D60")]
		[FieldOffset(Offset = "0x54")]
		private AprsModel _model;

		// Token: 0x04002D61 RID: 11617
		[Token(Token = "0x4002D61")]
		[FieldOffset(Offset = "0x58")]
		private AprsViewMediator _mediator;

		// Token: 0x04002D62 RID: 11618
		[Token(Token = "0x4002D62")]
		[FieldOffset(Offset = "0x5C")]
		private AprsController _controller;

		// Token: 0x04002D63 RID: 11619
		[Token(Token = "0x4002D63")]
		[FieldOffset(Offset = "0x60")]
		private AprsWindowArgs _windowArgs;
	}
}
