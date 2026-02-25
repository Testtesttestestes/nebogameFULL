using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003FF RID: 1023
	[Token(Token = "0x20003FF")]
	public class TitlePlaceIconValueBackground : TitleIconValueBackground
	{
		// Token: 0x0600180E RID: 6158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180E")]
		[Address(RVA = "0x69C5", Offset = "0x69C5", VA = "0x69C5")]
		public void SetPlace(uint place)
		{
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180F")]
		[Address(RVA = "0x69C6", Offset = "0x69C6", VA = "0x69C6")]
		public TitlePlaceIconValueBackground()
		{
		}

		// Token: 0x04000CC8 RID: 3272
		[Token(Token = "0x4000CC8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Image _placeIcon;

		// Token: 0x04000CC9 RID: 3273
		[Token(Token = "0x4000CC9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected Sprite _place1;

		// Token: 0x04000CCA RID: 3274
		[Token(Token = "0x4000CCA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Sprite _place10;

		// Token: 0x04000CCB RID: 3275
		[Token(Token = "0x4000CCB")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected Sprite _place100;
	}
}
