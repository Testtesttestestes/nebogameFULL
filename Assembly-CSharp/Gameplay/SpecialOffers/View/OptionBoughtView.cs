using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SpecialOffers.View
{
	// Token: 0x020004F9 RID: 1273
	[Token(Token = "0x20004F9")]
	public class OptionBoughtView : MonoBehaviour
	{
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000583")]
		public Button Button
		{
			[Token(Token = "0x6001E62")]
			[Address(RVA = "0x6FDB", Offset = "0x6FDB", VA = "0x6FDB")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E63")]
		[Address(RVA = "0x6FDC", Offset = "0x6FDC", VA = "0x6FDC")]
		public void Init(BankOptionData option)
		{
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E64")]
		[Address(RVA = "0x6FDD", Offset = "0x6FDD", VA = "0x6FDD")]
		public OptionBoughtView()
		{
		}

		// Token: 0x0400107E RID: 4222
		[Token(Token = "0x400107E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400107F RID: 4223
		[Token(Token = "0x400107F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001080 RID: 4224
		[Token(Token = "0x4001080")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;
	}
}
