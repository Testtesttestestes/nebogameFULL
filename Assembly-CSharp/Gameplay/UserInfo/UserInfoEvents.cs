using System;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInfo
{
	// Token: 0x020003EE RID: 1006
	[Token(Token = "0x20003EE")]
	public class UserInfoEvents : AbstractMVCEvents
	{
		// Token: 0x06001790 RID: 6032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001790")]
		[Address(RVA = "0x694C", Offset = "0x694C", VA = "0x694C")]
		public UserInfoEvents()
		{
		}

		// Token: 0x04000C71 RID: 3185
		[Token(Token = "0x4000C71")]
		[FieldOffset(Offset = "0x14")]
		public Action UserBasicRequestedEvent;

		// Token: 0x04000C72 RID: 3186
		[Token(Token = "0x4000C72")]
		[FieldOffset(Offset = "0x18")]
		public Action UserSkillsChangedEvent;

		// Token: 0x04000C73 RID: 3187
		[Token(Token = "0x4000C73")]
		[FieldOffset(Offset = "0x1C")]
		public Action UserEquipmentChangedEvent;

		// Token: 0x04000C74 RID: 3188
		[Token(Token = "0x4000C74")]
		[FieldOffset(Offset = "0x20")]
		public Action UserNickChangedEvent;

		// Token: 0x04000C75 RID: 3189
		[Token(Token = "0x4000C75")]
		[FieldOffset(Offset = "0x24")]
		public Action UserAprChangedEvent;

		// Token: 0x04000C76 RID: 3190
		[Token(Token = "0x4000C76")]
		[FieldOffset(Offset = "0x28")]
		public Action UserCultGenderChangedEvent;

		// Token: 0x04000C77 RID: 3191
		[Token(Token = "0x4000C77")]
		[FieldOffset(Offset = "0x2C")]
		public Action UserNickPriceChangedEvent;

		// Token: 0x04000C78 RID: 3192
		[Token(Token = "0x4000C78")]
		[FieldOffset(Offset = "0x30")]
		public Action UserAprSelectedEvent;

		// Token: 0x04000C79 RID: 3193
		[Token(Token = "0x4000C79")]
		[FieldOffset(Offset = "0x34")]
		public Action<string> UserNickGenerateCompleteEvent;

		// Token: 0x04000C7A RID: 3194
		[Token(Token = "0x4000C7A")]
		[FieldOffset(Offset = "0x38")]
		public Action<string, RepeatedField<string>> UserNickVariantsCompleteEvent;

		// Token: 0x04000C7B RID: 3195
		[Token(Token = "0x4000C7B")]
		[FieldOffset(Offset = "0x3C")]
		public Action<UserData> UserTriggersChangedEvent;
	}
}
