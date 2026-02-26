using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements
{
	// Token: 0x020001ED RID: 493
	[Token(Token = "0x20001ED")]
	public class CommonElements
	{
		// Token: 0x06000CC6 RID: 3270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x5FC7", Offset = "0x5FC7", VA = "0x5FC7")]
		public CommonElements()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_CommonElements___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 8),param2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0xc),param3,0);
		  return;
		}
		*/

		}

		// Token: 0x020001EE RID: 494
		[Token(Token = "0x20001EE")]
		[Serializable]
		public class IconLabel
		{
			// Token: 0x06000CC7 RID: 3271 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x5FC8", Offset = "0x5FC8", VA = "0x5FC8")]
			public void UpdateView(string iconAssetId, string label)
			{
			}

			// Token: 0x06000CC8 RID: 3272 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CC8")]
			[Address(RVA = "0x5FC9", Offset = "0x5FC9", VA = "0x5FC9")]
			public void SetText(string text)
			{
			}

			// Token: 0x06000CC9 RID: 3273 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x5FCA", Offset = "0x5FCA", VA = "0x5FCA")]
			public IconLabel()
			{
			}

			// Token: 0x0400063E RID: 1598
			[Token(Token = "0x400063E")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private GameRawImage _icon;

			// Token: 0x0400063F RID: 1599
			[Token(Token = "0x400063F")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private TextMeshProUGUI _label;
		}
	}
}
