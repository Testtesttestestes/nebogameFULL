using System;
using AssetContent;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Duel.View
{
	// Token: 0x0200085C RID: 2140
	[Token(Token = "0x200085C")]
	public class MarshalUserView : MonoBehaviour
	{
		// Token: 0x0600324A RID: 12874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600324A")]
		[Address(RVA = "0x82A0", Offset = "0x82A0", VA = "0x82A0")]
		public void Init(UserData user, UserManager userManager)
		{
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600324B")]
		[Address(RVA = "0x82A1", Offset = "0x82A1", VA = "0x82A1")]
		public MarshalUserView()
		{
		}

		// Token: 0x04001B7F RID: 7039
		[Token(Token = "0x4001B7F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x04001B80 RID: 7040
		[Token(Token = "0x4001B80")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private UserNickCultLevelExpView _userInfoBar;
	}
}
