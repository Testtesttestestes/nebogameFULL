using System;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x0200030C RID: 780
	[Token(Token = "0x200030C")]
	[Serializable]
	public class UserInRatingViewElements : UserBasicViewElements
	{
		// Token: 0x0600122A RID: 4650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122A")]
		[Address(RVA = "0x6425", Offset = "0x6425", VA = "0x6425")]
		public void AssignAssets(UserData userData, string place)
		{
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122B")]
		[Address(RVA = "0x6426", Offset = "0x6426", VA = "0x6426")]
		public UserInRatingViewElements()
		{
		}

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _place;
	}
}
