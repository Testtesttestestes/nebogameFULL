using System;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth2;

namespace Gameplay.RegisterV2.Events
{
	// Token: 0x0200056B RID: 1387
	[Token(Token = "0x200056B")]
	public class RegisterEvents : AbstractMVCEvents, IDisposable
	{
		// Token: 0x0600215F RID: 8543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600215F")]
		[Address(RVA = "0x72C1", Offset = "0x72C1", VA = "0x72C1", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002160")]
		[Address(RVA = "0x72C2", Offset = "0x72C2", VA = "0x72C2")]
		public RegisterEvents()
		{
		}

		// Token: 0x04001244 RID: 4676
		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0x14")]
		public Action NickGeneratedEvent;

		// Token: 0x04001245 RID: 4677
		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0x18")]
		public Action RegistrationProcessCompleteEvent;

		// Token: 0x04001246 RID: 4678
		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0x1C")]
		public Action<RepeatedField<string>, RegisterCmd.Types.Result> InvalidNickErrorEvent;
	}
}
