using System;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.Buttons
{
	// Token: 0x02000241 RID: 577
	[Token(Token = "0x2000241")]
	public class ButtonWithCost : Button
	{
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E4")]
		public Price Price
		{
			[Token(Token = "0x6000E31")]
			[Address(RVA = "0x60C3", Offset = "0x60C3", VA = "0x60C3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x60C4", Offset = "0x60C4", VA = "0x60C4")]
		public ButtonWithCost()
		{
		}

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x400070B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Price _price;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Price ---
		void UI_Elements_Buttons_ButtonWithCost__get_Price(undefined4 param1,undefined4 param2)
		
		{
		  UnityEngine_UI_AnimationTriggers___ctor(param1,0);
		  return;
		}
		*/

}
