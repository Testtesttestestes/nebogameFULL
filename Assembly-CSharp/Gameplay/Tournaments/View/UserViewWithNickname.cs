using System;
using Core.Data;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004B6 RID: 1206
	[Token(Token = "0x20004B6")]
	public class UserViewWithNickname : MonoBehaviour
	{
		// Token: 0x06001C81 RID: 7297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C81")]
		[Address(RVA = "0x6E00", Offset = "0x6E00", VA = "0x6E00")]
		public void Init(UserData userData)
		{
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C82")]
		[Address(RVA = "0x6E01", Offset = "0x6E01", VA = "0x6E01")]
		public UserViewWithNickname()
		{
		}

		// Token: 0x04000F87 RID: 3975
		[Token(Token = "0x4000F87")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x04000F88 RID: 3976
		[Token(Token = "0x4000F88")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _nickname;
	}
}
