using System;
using Gameplay.Portals.View.RatingTab;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Rating.View
{
	// Token: 0x0200057D RID: 1405
	[Token(Token = "0x200057D")]
	public class MyPortalRatingView : MonoBehaviourWithStates<MyPortalRatingView.State>
	{
		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000622")]
		public UserInPortalRatingListElement MyUser
		{
			[Token(Token = "0x60021A4")]
			[Address(RVA = "0x7303", Offset = "0x7303", VA = "0x7303")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A5")]
		[Address(RVA = "0x7304", Offset = "0x7304", VA = "0x7304")]
		public MyPortalRatingView()
		{
		}

		// Token: 0x04001264 RID: 4708
		[Token(Token = "0x4001264")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private UserInPortalRatingListElement _myUser;

		// Token: 0x0200057E RID: 1406
		[Token(Token = "0x200057E")]
		public enum State
		{
			// Token: 0x04001266 RID: 4710
			[Token(Token = "0x4001266")]
			UNKNOWN_STATE,
			// Token: 0x04001267 RID: 4711
			[Token(Token = "0x4001267")]
			USER,
			// Token: 0x04001268 RID: 4712
			[Token(Token = "0x4001268")]
			HIDE_ALL
		}
	}
}
