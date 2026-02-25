using System;
using System.Collections.Generic;
using Core.Data;
using DefaultNamespace;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Events
{
	// Token: 0x020003E8 RID: 1000
	[Token(Token = "0x20003E8")]
	public class UserInterfaceEvents : AbstractMVCEvents
	{
		// Token: 0x06001754 RID: 5972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001754")]
		[Address(RVA = "0x6911", Offset = "0x6911", VA = "0x6911")]
		public UserInterfaceEvents()
		{
		}

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x14")]
		public Action LocationChangedEvent;

		// Token: 0x04000C65 RID: 3173
		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x18")]
		public Action WorldMovementChangedEvent;

		// Token: 0x04000C66 RID: 3174
		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0x1C")]
		public Action UserInfoChangedEvent;

		// Token: 0x04000C67 RID: 3175
		[Token(Token = "0x4000C67")]
		[FieldOffset(Offset = "0x20")]
		public Action<bool> SetActiveEvent;

		// Token: 0x04000C68 RID: 3176
		[Token(Token = "0x4000C68")]
		[FieldOffset(Offset = "0x24")]
		public Action UserLevelChangedEvent;

		// Token: 0x04000C69 RID: 3177
		[Token(Token = "0x4000C69")]
		[FieldOffset(Offset = "0x28")]
		public Action<UserData> UserTriggerChangedEvent;

		// Token: 0x04000C6A RID: 3178
		[Token(Token = "0x4000C6A")]
		[FieldOffset(Offset = "0x2C")]
		public Action<UserData> NotifyUserGotNewLevelEvent;

		// Token: 0x04000C6B RID: 3179
		[Token(Token = "0x4000C6B")]
		[FieldOffset(Offset = "0x30")]
		public Action<bool> UserLevelGetRewardStateChangedEvent;

		// Token: 0x04000C6C RID: 3180
		[Token(Token = "0x4000C6C")]
		[FieldOffset(Offset = "0x34")]
		public Action<IList<Scenes>> ApplicationScenesChangedEvent;
	}
}
