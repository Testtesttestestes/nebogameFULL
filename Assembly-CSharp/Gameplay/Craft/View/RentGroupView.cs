using System;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UnityEngine;

namespace Gameplay.Craft.View
{
	// Token: 0x020008BF RID: 2239
	[Token(Token = "0x20008BF")]
	public class RentGroupView : MonoBehaviour
	{
		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x0600348E RID: 13454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A6F")]
		public ButtonWithCost RentButton
		{
			[Token(Token = "0x600348E")]
			[Address(RVA = "0x84B8", Offset = "0x84B8", VA = "0x84B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600348F")]
		[Address(RVA = "0x84B9", Offset = "0x84B9", VA = "0x84B9")]
		public void ShowDisabledRent(UserData user, CraftSlotListElement element)
		{
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003490")]
		[Address(RVA = "0x84BA", Offset = "0x84BA", VA = "0x84BA")]
		public void ShowEmptyRent(long expirationTime)
		{
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003491")]
		[Address(RVA = "0x84BB", Offset = "0x84BB", VA = "0x84BB")]
		public void ShowFilledRent(long expirationTime)
		{
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003492")]
		[Address(RVA = "0x84BC", Offset = "0x84BC", VA = "0x84BC")]
		private void ShowTimer(long expirationTime)
		{
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003493")]
		[Address(RVA = "0x84BD", Offset = "0x84BD", VA = "0x84BD")]
		public void ResolveSlot(UserData user, CraftSlotListElement element, long expirationTime)
		{
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003494")]
		[Address(RVA = "0x84BE", Offset = "0x84BE", VA = "0x84BE")]
		public RentGroupView()
		{
		}

		// Token: 0x04001CC7 RID: 7367
		[Token(Token = "0x4001CC7")]
		private const string LOCALIZATION_RENT_SLOT_ANNOTATION = "CRAFT/RENT_SLOT_ANNOTATION";

		// Token: 0x04001CC8 RID: 7368
		[Token(Token = "0x4001CC8")]
		private const string LOCALIZATION_CRAFT_START_CONDITION = "CRAFT/CRAFT_START_CONDITION";

		// Token: 0x04001CC9 RID: 7369
		[Token(Token = "0x4001CC9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ButtonWithCost _rentButton;

		// Token: 0x04001CCA RID: 7370
		[Token(Token = "0x4001CCA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001CCB RID: 7371
		[Token(Token = "0x4001CCB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _timer;
	}
}
