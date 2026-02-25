using System;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Themeduel;

namespace Gameplay.ThemeDuelState
{
	// Token: 0x020004CD RID: 1229
	[Token(Token = "0x20004CD")]
	public class ThemeDuelStateEvents : AbstractMVCEvents
	{
		// Token: 0x06001D39 RID: 7481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D39")]
		[Address(RVA = "0x6EB8", Offset = "0x6EB8", VA = "0x6EB8")]
		public ThemeDuelStateEvents()
		{
		}

		// Token: 0x04000FE1 RID: 4065
		[Token(Token = "0x4000FE1")]
		[FieldOffset(Offset = "0x14")]
		public Action ThemeDuelStateReceived;

		// Token: 0x04000FE2 RID: 4066
		[Token(Token = "0x4000FE2")]
		[FieldOffset(Offset = "0x18")]
		public Action<ThemeDuelDic> CurrentThemeDuelChanged;

		// Token: 0x04000FE3 RID: 4067
		[Token(Token = "0x4000FE3")]
		[FieldOffset(Offset = "0x1C")]
		public Action<ProtoThemeDuelStateChangedEvt> CurrentThemeDuelStateChanged;

		// Token: 0x04000FE4 RID: 4068
		[Token(Token = "0x4000FE4")]
		[FieldOffset(Offset = "0x20")]
		public Action<long> EventBalanceChanged;

		// Token: 0x04000FE5 RID: 4069
		[Token(Token = "0x4000FE5")]
		[FieldOffset(Offset = "0x24")]
		public Action<int> EventEntryAttemptChanged;
	}
}
