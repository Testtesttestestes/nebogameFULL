using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Discounts.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Discounts.View
{
	// Token: 0x02000897 RID: 2199
	[Token(Token = "0x2000897")]
	public class DiscountsWindow : ClosableBaseWindow<DiscountsWindow.DicountsWindowArgs>
	{
		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x060033CE RID: 13262 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A43")]
		public override string WindowId
		{
			[Token(Token = "0x60033CE")]
			[Address(RVA = "0x8406", Offset = "0x8406", VA = "0x8406", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CF")]
		[Address(RVA = "0x8407", Offset = "0x8407", VA = "0x8407", Slot = "22")]
		protected override void OnShow(DiscountsWindow.DicountsWindowArgs args)
		{
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D0")]
		[Address(RVA = "0x8408", Offset = "0x8408", VA = "0x8408", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D1")]
		[Address(RVA = "0x8409", Offset = "0x8409", VA = "0x8409")]
		public void Init(IEnumerable<DiscountData> discounts)
		{
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D2")]
		[Address(RVA = "0x840A", Offset = "0x840A", VA = "0x840A")]
		private void SetupMVC()
		{
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D3")]
		[Address(RVA = "0x840B", Offset = "0x840B", VA = "0x840B")]
		private void DestroyMVC()
		{
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D4")]
		[Address(RVA = "0x840C", Offset = "0x840C", VA = "0x840C")]
		public DiscountsWindow()
		{
		}

		// Token: 0x04001C38 RID: 7224
		[Token(Token = "0x4001C38")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Discounts/DiscountsWindow";

		// Token: 0x04001C39 RID: 7225
		[Token(Token = "0x4001C39")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private DiscountListElement _listElementPrefab;

		// Token: 0x04001C3A RID: 7226
		[Token(Token = "0x4001C3A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x04001C3B RID: 7227
		[Token(Token = "0x4001C3B")]
		[FieldOffset(Offset = "0x44")]
		private DiscountsViewMediator _mediator;

		// Token: 0x04001C3C RID: 7228
		[Token(Token = "0x4001C3C")]
		[FieldOffset(Offset = "0x48")]
		private bool _mvcSetUp;

		// Token: 0x02000898 RID: 2200
		[Token(Token = "0x2000898")]
		public class DicountsWindowArgs : BaseWindowArgs
		{
			// Token: 0x060033D5 RID: 13269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60033D5")]
			[Address(RVA = "0x840D", Offset = "0x840D", VA = "0x840D")]
			public DicountsWindowArgs()
			{
			}

			// Token: 0x04001C3D RID: 7229
			[Token(Token = "0x4001C3D")]
			[FieldOffset(Offset = "0x18")]
			public DiscountsController Controller;
		}
	}
}
