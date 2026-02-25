using System;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Parts
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public class AprViewWhitTitle : AbstractDataRenderer<AprDicWrapper>, IAprView
	{
		// Token: 0x060009BB RID: 2491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x5D23", Offset = "0x5D23", VA = "0x5D23")]
		private void Start()
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x5D24", Offset = "0x5D24", VA = "0x5D24")]
		public void SetTitle(string value)
		{
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x5D25", Offset = "0x5D25", VA = "0x5D25", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x5D26", Offset = "0x5D26", VA = "0x5D26")]
		public AprViewWhitTitle()
		{
		}

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private AprViewSmall _aprView;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _subTitle;
	}
}
