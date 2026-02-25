using System;
using Gameplay.Clans.Office.View;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Rating.View
{
	// Token: 0x0200057F RID: 1407
	[Token(Token = "0x200057F")]
	public class MyRatingView : MonoBehaviourWithStates<MyRatingView.State>
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000623")]
		public UserInRatingListElement MyUser
		{
			[Token(Token = "0x60021A6")]
			[Address(RVA = "0x7305", Offset = "0x7305", VA = "0x7305")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000624")]
		public ClanInRatingListElement MyClan
		{
			[Token(Token = "0x60021A7")]
			[Address(RVA = "0x7306", Offset = "0x7306", VA = "0x7306")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A8")]
		[Address(RVA = "0x7307", Offset = "0x7307", VA = "0x7307")]
		public MyRatingView()
		{
		}

		// Token: 0x04001269 RID: 4713
		[Token(Token = "0x4001269")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private UserInRatingListElement _myUser;

		// Token: 0x0400126A RID: 4714
		[Token(Token = "0x400126A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClanInRatingListElement _myClan;

		// Token: 0x02000580 RID: 1408
		[Token(Token = "0x2000580")]
		public enum State
		{
			// Token: 0x0400126C RID: 4716
			[Token(Token = "0x400126C")]
			UNKNOWN_STATE,
			// Token: 0x0400126D RID: 4717
			[Token(Token = "0x400126D")]
			USER,
			// Token: 0x0400126E RID: 4718
			[Token(Token = "0x400126E")]
			CLAN,
			// Token: 0x0400126F RID: 4719
			[Token(Token = "0x400126F")]
			NO_CLAN,
			// Token: 0x04001270 RID: 4720
			[Token(Token = "0x4001270")]
			HIDE_ALL
		}
	}
}
