using System;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Rating.View
{
	// Token: 0x0200057B RID: 1403
	[Token(Token = "0x200057B")]
	public class MyCommonRatingView : MonoBehaviourWithStates<MyCommonRatingView.State>
	{
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000621")]
		public MyUserInRatingListElement MyUser
		{
			[Token(Token = "0x60021A2")]
			[Address(RVA = "0x7301", Offset = "0x7301", VA = "0x7301")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A3")]
		[Address(RVA = "0x7302", Offset = "0x7302", VA = "0x7302")]
		public MyCommonRatingView()
		{
		}

		// Token: 0x0400125F RID: 4703
		[Token(Token = "0x400125F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private MyUserInRatingListElement _myUser;

		// Token: 0x0200057C RID: 1404
		[Token(Token = "0x200057C")]
		public enum State
		{
			// Token: 0x04001261 RID: 4705
			[Token(Token = "0x4001261")]
			UNKNOWN_STATE,
			// Token: 0x04001262 RID: 4706
			[Token(Token = "0x4001262")]
			USER,
			// Token: 0x04001263 RID: 4707
			[Token(Token = "0x4001263")]
			HIDE_ALL
		}
	}
}
