using System;
using AssetContent;
using Core.Data;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View.Ratings
{
	// Token: 0x0200030D RID: 781
	[Token(Token = "0x200030D")]
	[Serializable]
	public class UserBasicViewElements
	{
		// Token: 0x0600122C RID: 4652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122C")]
		[Address(RVA = "0x6427", Offset = "0x6427", VA = "0x6427")]
		public void AssignAssets(UserData userData)
		{
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600122D")]
		[Address(RVA = "0x6428", Offset = "0x6428", VA = "0x6428")]
		public UserBasicViewElements()
		{
		}

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private GameImage _cultIcon;

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _nickname;
	}
}
