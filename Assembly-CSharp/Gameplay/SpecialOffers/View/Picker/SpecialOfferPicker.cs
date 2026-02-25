using System;
using System.Collections.Generic;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.SpecialOffers.View.Picker
{
	// Token: 0x02000500 RID: 1280
	[Token(Token = "0x2000500")]
	public class SpecialOfferPicker : PrefabPicker<BankOptionListElement.BankOptionListElementArgs>
	{
		// Token: 0x06001E8B RID: 7819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8B")]
		[Address(RVA = "0x6FFE", Offset = "0x6FFE", VA = "0x6FFE")]
		private void Awake()
		{
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8C")]
		[Address(RVA = "0x6FFF", Offset = "0x6FFF", VA = "0x6FFF")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8D")]
		[Address(RVA = "0x7000", Offset = "0x7000", VA = "0x7000", Slot = "5")]
		public override void ScrollTo(BankOptionListElement.BankOptionListElementArgs item)
		{
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0x7001", Offset = "0x7001", VA = "0x7001")]
		public void ScrollToIndex(int index)
		{
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8F")]
		[Address(RVA = "0x7002", Offset = "0x7002", VA = "0x7002", Slot = "4")]
		public override void Init(IList<BankOptionListElement.BankOptionListElementArgs> args)
		{
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E90")]
		[Address(RVA = "0x7003", Offset = "0x7003", VA = "0x7003")]
		public SpecialOfferPicker()
		{
		}

		// Token: 0x0400109E RID: 4254
		[Token(Token = "0x400109E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpecialOfferPickerOsaSpinner _spinner;
	}
}
