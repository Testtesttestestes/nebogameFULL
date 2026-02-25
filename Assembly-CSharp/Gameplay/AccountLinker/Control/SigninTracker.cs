using System;
using Il2CppDummyDll;
using UI.ConfirmationMessage;

namespace Gameplay.AccountLinker.Control
{
	// Token: 0x02000E26 RID: 3622
	[Token(Token = "0x2000E26")]
	public class SigninTracker : IDisposable
	{
		// Token: 0x0600585F RID: 22623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600585F")]
		[Address(RVA = "0xA5CD", Offset = "0xA5CD", VA = "0xA5CD")]
		public SigninTracker(ConfirmationMessageController confirmationMessageController, AccountLinkerEvents events)
		{
		}

		// Token: 0x06005860 RID: 22624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005860")]
		[Address(RVA = "0xA5CE", Offset = "0xA5CE", VA = "0xA5CE")]
		private void SigninTargetProviderStartedEventHandler()
		{
		}

		// Token: 0x06005861 RID: 22625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005861")]
		[Address(RVA = "0xA5CF", Offset = "0xA5CF", VA = "0xA5CF")]
		private void Unsubscribe()
		{
		}

		// Token: 0x06005862 RID: 22626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005862")]
		[Address(RVA = "0xA5D0", Offset = "0xA5D0", VA = "0xA5D0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04002FD5 RID: 12245
		[Token(Token = "0x4002FD5")]
		[FieldOffset(Offset = "0x8")]
		private readonly ConfirmationMessageController _confirmationMessageController;

		// Token: 0x04002FD6 RID: 12246
		[Token(Token = "0x4002FD6")]
		[FieldOffset(Offset = "0xC")]
		private readonly AccountLinkerEvents _events;
	}
}
