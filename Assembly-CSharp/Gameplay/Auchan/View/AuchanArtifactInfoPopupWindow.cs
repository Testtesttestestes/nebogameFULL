using System;
using System.Collections.Generic;
using Gameplay.Inventory.View.Info;
using Gameplay.ThemeDuelState.View.Balance;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C83 RID: 3203
	[Token(Token = "0x2000C83")]
	public class AuchanArtifactInfoPopupWindow : ArtifactInfoPopupWindow
	{
		// Token: 0x06004E24 RID: 20004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E24")]
		[Address(RVA = "0x9C57", Offset = "0x9C57", VA = "0x9C57", Slot = "22")]
		protected override void OnShow(ArtifactInfoPopupWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Auchan_View_AuchanArtifactInfoPopupWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Inventory_View_Info_ArtifactInfoPopupWindow__OnClose(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004E25 RID: 20005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E25")]
		[Address(RVA = "0x9C58", Offset = "0x9C58", VA = "0x9C58")]
		public AuchanArtifactInfoPopupWindow()
		{
		}

		// Token: 0x04002AAA RID: 10922
		[Token(Token = "0x4002AAA")]
		public new const string WINDOW_ID = "Prefabs/UI/Windows/Auchan/AuchanArtifactInfoPopupWindow";

		// Token: 0x04002AAB RID: 10923
		[Token(Token = "0x4002AAB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AuchanActionInfoDisplay _actionInfoDisplay;

		// Token: 0x04002AAC RID: 10924
		[Token(Token = "0x4002AAC")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private ThemeDuelBalanceView _themeDuelBalanceView;

		// Token: 0x04002AAD RID: 10925
		[Token(Token = "0x4002AAD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Price> _priceViews;
	}
}
