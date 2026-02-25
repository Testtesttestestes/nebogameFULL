using System;
using System.Collections;
using System.Collections.Generic;
using Gameplay.EndlessPaymentOptionsList.Control;
using Gameplay.EndlessPaymentOptionsList.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.EndlessPaymentOptionsList.View
{
	// Token: 0x0200083B RID: 2107
	[Token(Token = "0x200083B")]
	public class EndlessPaymentOptionsListWindow : ClosableBaseWindow<EndlessPaymentOptionsListWindow.EndlessPaymentOptionsListWindowArgs>
	{
		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C7")]
		public override string WindowId
		{
			[Token(Token = "0x6003191")]
			[Address(RVA = "0x81E9", Offset = "0x81E9", VA = "0x81E9", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x170009C8")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x6003192")]
			[Address(RVA = "0x81EA", Offset = "0x81EA", VA = "0x81EA", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009C9")]
		public MonoPointerClickHandler OptionClickHandler
		{
			[Token(Token = "0x6003193")]
			[Address(RVA = "0x81EB", Offset = "0x81EB", VA = "0x81EB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009CA")]
		public EndlessPaymentOptionListTitleLayoutView TitleLayout
		{
			[Token(Token = "0x6003194")]
			[Address(RVA = "0x81EC", Offset = "0x81EC", VA = "0x81EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003195 RID: 12693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003195")]
		[Address(RVA = "0x81ED", Offset = "0x81ED", VA = "0x81ED", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003196")]
		[Address(RVA = "0x81EE", Offset = "0x81EE", VA = "0x81EE", Slot = "22")]
		protected override void OnShow(EndlessPaymentOptionsListWindow.EndlessPaymentOptionsListWindowArgs args)
		{
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003197")]
		[Address(RVA = "0x1B04", Offset = "0x1B04", VA = "0x1B04")]
		private EndlessPaymentOptionView CreateItem(CardData data, in Vector3 offset)
		{
			return null;
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003198")]
		[Address(RVA = "0x81EF", Offset = "0x81EF", VA = "0x81EF")]
		public List<EndlessPaymentOptionView> CreateItems(List<CardData> optionsForDisplay, List<CardData> totalOptions)
		{
			return null;
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003199")]
		[Address(RVA = "0x81F0", Offset = "0x81F0", VA = "0x81F0")]
		private IEnumerator Shift(Vector3 offset)
		{
			return null;
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600319A")]
		[Address(RVA = "0x81F1", Offset = "0x81F1", VA = "0x81F1")]
		private IEnumerator PlayBuyRoutine(CardData removeData)
		{
			return null;
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600319B")]
		[Address(RVA = "0x81F2", Offset = "0x81F2", VA = "0x81F2")]
		private IEnumerator PlayBuyAndShiftRoutine(CardData removeData, CardData addData)
		{
			return null;
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319C")]
		[Address(RVA = "0x81F3", Offset = "0x81F3", VA = "0x81F3")]
		public void PlayBuy(CardData removeData)
		{
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319D")]
		[Address(RVA = "0x81F4", Offset = "0x81F4", VA = "0x81F4")]
		public void PlayBuyAndShift(CardData removeData, CardData addData)
		{
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319E")]
		[Address(RVA = "0x81F5", Offset = "0x81F5", VA = "0x81F5")]
		public void SetTitle(string value)
		{
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600319F")]
		[Address(RVA = "0x81F6", Offset = "0x81F6", VA = "0x81F6")]
		public EndlessPaymentOptionsListWindow()
		{
		}

		// Token: 0x04001B21 RID: 6945
		[Token(Token = "0x4001B21")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/EndlessPaymentOptionsList/EndlessPaymentOptionsListWindow";

		// Token: 0x04001B22 RID: 6946
		[Token(Token = "0x4001B22")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI[] _title;

		// Token: 0x04001B23 RID: 6947
		[Token(Token = "0x4001B23")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private EndlessPaymentOptionView _listItemsPrefab;

		// Token: 0x04001B24 RID: 6948
		[Token(Token = "0x4001B24")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Transform _itemsOwner;

		// Token: 0x04001B25 RID: 6949
		[Token(Token = "0x4001B25")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x04001B26 RID: 6950
		[Token(Token = "0x4001B26")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Transform[] _anchors;

		// Token: 0x04001B27 RID: 6951
		[Token(Token = "0x4001B27")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 _itemsOffsetOver4;

		// Token: 0x04001B28 RID: 6952
		[Token(Token = "0x4001B28")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private EndlessPaymentOptionListTitleLayoutView _titleLayout;

		// Token: 0x04001B29 RID: 6953
		[Token(Token = "0x4001B29")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public Button ShowDiscountBtn_DBG;

		// Token: 0x04001B2A RID: 6954
		[Token(Token = "0x4001B2A")]
		[FieldOffset(Offset = "0x64")]
		[NonSerialized]
		public readonly LinkedList<EndlessPaymentOptionView> Items;

		// Token: 0x04001B2B RID: 6955
		[Token(Token = "0x4001B2B")]
		[FieldOffset(Offset = "0x68")]
		private EndlessPaymentOptionsListWindowMediator _mediator;

		// Token: 0x04001B2C RID: 6956
		[Token(Token = "0x4001B2C")]
		[FieldOffset(Offset = "0x6C")]
		private readonly Queue<Coroutine> _routines;

		// Token: 0x0200083C RID: 2108
		[Token(Token = "0x200083C")]
		public class EndlessPaymentOptionsListWindowArgs : BaseWindowArgs
		{
			// Token: 0x060031A0 RID: 12704 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031A0")]
			[Address(RVA = "0x81F7", Offset = "0x81F7", VA = "0x81F7")]
			public EndlessPaymentOptionsListWindowArgs(EndlessPaymentOptionListData listData, EndlessPaymentOptionsListController controller, WindowOpenReasonSource source)
			{
			}

			// Token: 0x04001B2D RID: 6957
			[Token(Token = "0x4001B2D")]
			[FieldOffset(Offset = "0x18")]
			public readonly EndlessPaymentOptionsListController Controller;

			// Token: 0x04001B2E RID: 6958
			[Token(Token = "0x4001B2E")]
			[FieldOffset(Offset = "0x1C")]
			public readonly EndlessPaymentOptionListData ListData;
		}
	}
}
