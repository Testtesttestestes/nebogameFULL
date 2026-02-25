using System;
using Gameplay.Isles.Base.View;
using Il2CppDummyDll;
using Protocol.Consts;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D20 RID: 3360
	[Token(Token = "0x2000D20")]
	public class UserIsleBuildingView : BaseIsleBuildingView
	{
		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x0600521D RID: 21021 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		[Token(Token = "0x170010B0")]
		public override uint Type
		{
			[Token(Token = "0x600521D")]
			[Address(RVA = "0x9FF4", Offset = "0x9FF4", VA = "0x9FF4", Slot = "10")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600521E RID: 21022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600521E")]
		[Address(RVA = "0x9FF5", Offset = "0x9FF5", VA = "0x9FF5")]
		public UserIsleBuildingView()
		{
		}

		// Token: 0x04002CA7 RID: 11431
		[Token(Token = "0x4002CA7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private UserBuildingTypes _type;
	}
}
