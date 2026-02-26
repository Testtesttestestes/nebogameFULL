using System;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;

namespace Gameplay.AccountLinker
{
	// Token: 0x02000DF3 RID: 3571
	[Token(Token = "0x2000DF3")]
	public class AccountLinkerEvents : AbstractMVCEvents
	{
		// Token: 0x06005730 RID: 22320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005730")]
		[Address(RVA = "0xA4AB", Offset = "0xA4AB", VA = "0xA4AB")]
		public AccountLinkerEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_AccountLinkerEvents___ctor(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(*(int *)(param1 + 0x1c) + 0x58) = 2;
		  return;
		}
		*/

		}

		// Token: 0x04002F28 RID: 12072
		[Token(Token = "0x4002F28")]
		[FieldOffset(Offset = "0x14")]
		public Action<string> CodeReadyEvent;

		// Token: 0x04002F29 RID: 12073
		[Token(Token = "0x4002F29")]
		[FieldOffset(Offset = "0x18")]
		public Action<int> SetEmailErrorEvent;

		// Token: 0x04002F2A RID: 12074
		[Token(Token = "0x4002F2A")]
		[FieldOffset(Offset = "0x1C")]
		public Action StartResolveAdditionalUsersEvent;

		// Token: 0x04002F2B RID: 12075
		[Token(Token = "0x4002F2B")]
		[FieldOffset(Offset = "0x20")]
		public Action SigninTargetProviderStartedEvent;

		// Token: 0x04002F2C RID: 12076
		[Token(Token = "0x4002F2C")]
		[FieldOffset(Offset = "0x24")]
		public Action SigninTargetProviderSuccessEvent;

		// Token: 0x04002F2D RID: 12077
		[Token(Token = "0x4002F2D")]
		[FieldOffset(Offset = "0x28")]
		public Action SigninTargetProviderFailedEvent;

		// Token: 0x04002F2E RID: 12078
		[Token(Token = "0x4002F2E")]
		[FieldOffset(Offset = "0x2C")]
		public Action LinkageProcessSuccessEvent;

		// Token: 0x04002F2F RID: 12079
		[Token(Token = "0x4002F2F")]
		[FieldOffset(Offset = "0x30")]
		public Action SetUserSuccessEvent;

		// Token: 0x04002F30 RID: 12080
		[Token(Token = "0x4002F30")]
		[FieldOffset(Offset = "0x34")]
		public Action<OTPTokenGenCmd.Types.Result> SetCodeErrorEvent;

		// Token: 0x04002F31 RID: 12081
		[Token(Token = "0x4002F31")]
		[FieldOffset(Offset = "0x38")]
		public Action<string, uint, RepeatedField<string>> InvalidNickErrorEvent;
	}
}
