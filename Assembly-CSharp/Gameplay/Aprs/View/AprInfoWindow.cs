using System;
using AssetContent;
using Gameplay.Aprs.Controller;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Price;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D50 RID: 3408
	[Token(Token = "0x2000D50")]
	public class AprInfoWindow : ClosableBaseWindow<AprInfoWindowArgs>
	{
		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06005378 RID: 21368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010F3")]
		public override string WindowId
		{
			[Token(Token = "0x6005378")]
			[Address(RVA = "0xA137", Offset = "0xA137", VA = "0xA137", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06005379 RID: 21369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010F4")]
		public Button UseButton
		{
			[Token(Token = "0x6005379")]
			[Address(RVA = "0xA138", Offset = "0xA138", VA = "0xA138")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x0600537A RID: 21370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010F5")]
		public Button PrevButton
		{
			[Token(Token = "0x600537A")]
			[Address(RVA = "0xA139", Offset = "0xA139", VA = "0xA139")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x0600537B RID: 21371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010F6")]
		public Button NextButton
		{
			[Token(Token = "0x600537B")]
			[Address(RVA = "0xA13A", Offset = "0xA13A", VA = "0xA13A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x0600537C RID: 21372 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010F7")]
		public Button BuyButton
		{
			[Token(Token = "0x600537C")]
			[Address(RVA = "0xA13B", Offset = "0xA13B", VA = "0xA13B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x0600537D RID: 21373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010F8")]
		public Price Price
		{
			[Token(Token = "0x600537D")]
			[Address(RVA = "0xA13C", Offset = "0xA13C", VA = "0xA13C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x0600537E RID: 21374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010F9")]
		public AprDiscountView DiscountView
		{
			[Token(Token = "0x600537E")]
			[Address(RVA = "0xA13D", Offset = "0xA13D", VA = "0xA13D")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600537F")]
		[Address(RVA = "0xA13E", Offset = "0xA13E", VA = "0xA13E")]
		public void SetCurrentAprData(AprData data)
		{
		}

		// Token: 0x06005380 RID: 21376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005380")]
		[Address(RVA = "0xA13F", Offset = "0xA13F", VA = "0xA13F")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005381")]
		[Address(RVA = "0xA140", Offset = "0xA140", VA = "0xA140", Slot = "22")]
		protected override void OnShow(AprInfoWindowArgs args)
		{
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005382")]
		[Address(RVA = "0xA141", Offset = "0xA141", VA = "0xA141")]
		public AprInfoWindow()
		{
		}

		// Token: 0x04002D36 RID: 11574
		[Token(Token = "0x4002D36")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Aprs/AprInfoWindow";

		// Token: 0x04002D37 RID: 11575
		[Token(Token = "0x4002D37")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Button _prevButton;

		// Token: 0x04002D38 RID: 11576
		[Token(Token = "0x4002D38")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Button _nextButton;

		// Token: 0x04002D39 RID: 11577
		[Token(Token = "0x4002D39")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameAssetViewRawImage _aprView;

		// Token: 0x04002D3A RID: 11578
		[Token(Token = "0x4002D3A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _useButton;

		// Token: 0x04002D3B RID: 11579
		[Token(Token = "0x4002D3B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _buyButton;

		// Token: 0x04002D3C RID: 11580
		[Token(Token = "0x4002D3C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Price _price;

		// Token: 0x04002D3D RID: 11581
		[Token(Token = "0x4002D3D")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private AprInfoView _aprInfoView;

		// Token: 0x04002D3E RID: 11582
		[Token(Token = "0x4002D3E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AprDiscountView _discountView;

		// Token: 0x04002D3F RID: 11583
		[Token(Token = "0x4002D3F")]
		[FieldOffset(Offset = "0x5C")]
		private AprInfoWindowMediator _mediator;
	}
}
