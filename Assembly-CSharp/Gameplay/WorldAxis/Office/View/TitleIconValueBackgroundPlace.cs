using System;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.View
{
	// Token: 0x020002E8 RID: 744
	[Token(Token = "0x20002E8")]
	public class TitleIconValueBackgroundPlace : TitleIconValueBackground
	{
		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700029B")]
		public TextMeshProUGUI Place
		{
			[Token(Token = "0x60011B7")]
			[Address(RVA = "0x63B4", Offset = "0x63B4", VA = "0x63B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B8")]
		[Address(RVA = "0x63B5", Offset = "0x63B5", VA = "0x63B5")]
		public TitleIconValueBackgroundPlace()
		{
		}

		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _place;
	}
}
