using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003C3 RID: 963
	[Token(Token = "0x20003C3")]
	public class UserIndexView : MonoBehaviour
	{
		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003C2")]
		public UserView UserView
		{
			[Token(Token = "0x6001684")]
			[Address(RVA = "0x6845", Offset = "0x6845", VA = "0x6845")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170003C3")]
		public Button GiftButton
		{
			[Token(Token = "0x6001685")]
			[Address(RVA = "0x6846", Offset = "0x6846", VA = "0x6846")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001686")]
		[Address(RVA = "0x6847", Offset = "0x6847", VA = "0x6847")]
		public UserIndexView()
		{
		}

		// Token: 0x04000BD8 RID: 3032
		[Token(Token = "0x4000BD8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UserView _userIndexView;

		// Token: 0x04000BD9 RID: 3033
		[Token(Token = "0x4000BD9")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _giftButton;
	}
}
