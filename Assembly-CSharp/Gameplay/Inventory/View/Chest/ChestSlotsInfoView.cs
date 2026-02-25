using System;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000683 RID: 1667
	[Token(Token = "0x2000683")]
	public class ChestSlotsInfoView : MonoBehaviour
	{
		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A5")]
		public ButtonWithCost BuyButton
		{
			[Token(Token = "0x6002858")]
			[Address(RVA = "0x7978", Offset = "0x7978", VA = "0x7978")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002859")]
		[Address(RVA = "0x7979", Offset = "0x7979", VA = "0x7979")]
		public void SetSlotsCount(long empty, long total)
		{
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285A")]
		[Address(RVA = "0x797A", Offset = "0x797A", VA = "0x797A")]
		public ChestSlotsInfoView()
		{
		}

		// Token: 0x04001640 RID: 5696
		[Token(Token = "0x4001640")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04001641 RID: 5697
		[Token(Token = "0x4001641")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ButtonWithCost _buyButton;
	}
}
