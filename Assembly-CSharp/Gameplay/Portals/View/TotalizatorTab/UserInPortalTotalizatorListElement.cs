using System;
using Gameplay.Portals.View.RatingTab;
using Il2CppDummyDll;
using Protocol.Portal;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Portals.View.TotalizatorTab
{
	// Token: 0x020005BD RID: 1469
	[Token(Token = "0x20005BD")]
	public class UserInPortalTotalizatorListElement : UserInPortalRatingListElement
	{
		// Token: 0x06002335 RID: 9013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002335")]
		[Address(RVA = "0x7489", Offset = "0x7489", VA = "0x7489", Slot = "12")]
		protected override void Start()
		{
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002336")]
		[Address(RVA = "0x748A", Offset = "0x748A", VA = "0x748A", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002337")]
		[Address(RVA = "0x748B", Offset = "0x748B", VA = "0x748B", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002338")]
		[Address(RVA = "0x748C", Offset = "0x748C", VA = "0x748C")]
		private void OnChoiceLose()
		{
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002339")]
		[Address(RVA = "0x748D", Offset = "0x748D", VA = "0x748D")]
		private void OnChoiceWin()
		{
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233A")]
		[Address(RVA = "0x748E", Offset = "0x748E", VA = "0x748E")]
		private void ChangeColor(Bet.Types.State state)
		{
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233B")]
		[Address(RVA = "0x748F", Offset = "0x748F", VA = "0x748F")]
		public UserInPortalTotalizatorListElement()
		{
		}

		// Token: 0x04001357 RID: 4951
		[Token(Token = "0x4001357")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _winButton;

		// Token: 0x04001358 RID: 4952
		[Token(Token = "0x4001358")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _winText;

		// Token: 0x04001359 RID: 4953
		[Token(Token = "0x4001359")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _loseButton;

		// Token: 0x0400135A RID: 4954
		[Token(Token = "0x400135A")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private TextMeshProUGUI _loseText;

		// Token: 0x0400135B RID: 4955
		[Token(Token = "0x400135B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x0400135C RID: 4956
		[Token(Token = "0x400135C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x020005BE RID: 1470
		[Token(Token = "0x20005BE")]
		public class UserInPortalTotalizatorListElementArgs : UserInPortalRatingListElement.UserInPortalRatingListElementArgs
		{
			// Token: 0x0600233C RID: 9020 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600233C")]
			[Address(RVA = "0x7490", Offset = "0x7490", VA = "0x7490")]
			public UserInPortalTotalizatorListElementArgs()
			{
			}

			// Token: 0x0400135D RID: 4957
			[Token(Token = "0x400135D")]
			[FieldOffset(Offset = "0x38")]
			public Action<ulong, Bet.Types.State> ChoiceHandler;

			// Token: 0x0400135E RID: 4958
			[Token(Token = "0x400135E")]
			[FieldOffset(Offset = "0x3C")]
			public Bet.Types.State Choice;

			// Token: 0x0400135F RID: 4959
			[Token(Token = "0x400135F")]
			[FieldOffset(Offset = "0x40")]
			public bool Locked;
		}
	}
}
