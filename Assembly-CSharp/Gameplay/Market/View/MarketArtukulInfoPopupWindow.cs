using System;
using Gameplay.Inventory.View.Info;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Market.View
{
	// Token: 0x02000616 RID: 1558
	[Token(Token = "0x2000616")]
	public class MarketArtukulInfoPopupWindow : ArtikulInfoPopupWindow
	{
		// Token: 0x060025D2 RID: 9682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D2")]
		[Address(RVA = "0x7710", Offset = "0x7710", VA = "0x7710", Slot = "22")]
		protected override void OnShow(ArtikulInfoPopupWindow.ArtikulInfoPopupWindowArgs args)
		{
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D3")]
		[Address(RVA = "0x7711", Offset = "0x7711", VA = "0x7711", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D4")]
		[Address(RVA = "0x7712", Offset = "0x7712", VA = "0x7712")]
		private void MarketButtonClickedEventHandler()
		{
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D5")]
		[Address(RVA = "0x7713", Offset = "0x7713", VA = "0x7713")]
		public MarketArtukulInfoPopupWindow()
		{
		}

		// Token: 0x040014A3 RID: 5283
		[Token(Token = "0x40014A3")]
		public new const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/MarketArtikulInfoPopupWindow";

		// Token: 0x040014A4 RID: 5284
		[Token(Token = "0x40014A4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _marketButton;
	}
}
