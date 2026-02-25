using System;
using Core.Data;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x02000409 RID: 1033
	[Token(Token = "0x2000409")]
	public class UserRatingView : BaseInfoBox
	{
		// Token: 0x0600184A RID: 6218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x69FE", Offset = "0x69FE", VA = "0x69FE")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184B")]
		[Address(RVA = "0x69FF", Offset = "0x69FF", VA = "0x69FF", Slot = "5")]
		public override void UpdateInfo()
		{
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600184C")]
		[Address(RVA = "0x6A00", Offset = "0x6A00", VA = "0x6A00")]
		public UserRatingView()
		{
		}

		// Token: 0x04000CFF RID: 3327
		[Token(Token = "0x4000CFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TitleIconValueBackground _listElementPrefab;

		// Token: 0x04000D00 RID: 3328
		[Token(Token = "0x4000D00")]
		[FieldOffset(Offset = "0x1C")]
		public UserData User;
	}
}
