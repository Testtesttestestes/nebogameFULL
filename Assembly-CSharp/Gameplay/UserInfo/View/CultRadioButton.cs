using System;
using AssetContent;
using Il2CppDummyDll;
using UI.Elements.Buttons;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F2 RID: 1010
	[Token(Token = "0x20003F2")]
	public class CultRadioButton : RadioButton
	{
		// Token: 0x17000422 RID: 1058
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000422")]
		public override object Data
		{
			[Token(Token = "0x60017BD")]
			[Address(RVA = "0x6978", Offset = "0x6978", VA = "0x6978", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017BE")]
		[Address(RVA = "0x6979", Offset = "0x6979", VA = "0x6979")]
		public CultRadioButton()
		{
		}

		// Token: 0x04000C9B RID: 3227
		[Token(Token = "0x4000C9B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameRawImage _image;
	}
}
