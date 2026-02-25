using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Gameplay.AccountLinker.Control
{
	// Token: 0x02000E23 RID: 3619
	[Token(Token = "0x2000E23")]
	public class NebogameSiteHelper : IDisposable
	{
		// Token: 0x1400020B RID: 523
		// (add) Token: 0x06005853 RID: 22611 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005854 RID: 22612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400020B")]
		public event Action<int> SetEmailErrorEvent
		{
			[Token(Token = "0x6005853")]
			[Address(RVA = "0xA5C2", Offset = "0xA5C2", VA = "0xA5C2")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005854")]
			[Address(RVA = "0xA5C3", Offset = "0xA5C3", VA = "0xA5C3")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400020C RID: 524
		// (add) Token: 0x06005855 RID: 22613 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005856 RID: 22614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400020C")]
		public event Action SetEmailCompleteEvent
		{
			[Token(Token = "0x6005855")]
			[Address(RVA = "0xA5C4", Offset = "0xA5C4", VA = "0xA5C4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005856")]
			[Address(RVA = "0xA5C5", Offset = "0xA5C5", VA = "0xA5C5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005857")]
		[Address(RVA = "0xA5C6", Offset = "0xA5C6", VA = "0xA5C6", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005858")]
		[Address(RVA = "0xA5C7", Offset = "0xA5C7", VA = "0xA5C7")]
		private void RequestSetEmailAndPass(string email, string password)
		{
		}

		// Token: 0x06005859 RID: 22617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005859")]
		[Address(RVA = "0xA5C8", Offset = "0xA5C8", VA = "0xA5C8")]
		public void InvokeOAuth(Provider provider)
		{
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		[Token(Token = "0x600585A")]
		[Address(RVA = "0xA5C9", Offset = "0xA5C9", VA = "0xA5C9")]
		public bool TrySetEmailAndPass(string email, string password)
		{
			return default(bool);
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600585B")]
		[Address(RVA = "0xA5CA", Offset = "0xA5CA", VA = "0xA5CA")]
		public NebogameSiteHelper()
		{
		}

		// Token: 0x04002FCA RID: 12234
		[Token(Token = "0x4002FCA")]
		public const string PAGE_FOR_OAUTH = "/bonuses.php?action=set_social_network&sn_ref_id=";

		// Token: 0x02000E24 RID: 3620
		[Token(Token = "0x2000E24")]
		[Serializable]
		public class SetEmailResponse
		{
			// Token: 0x0600585C RID: 22620 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600585C")]
			[Address(RVA = "0xA5CB", Offset = "0xA5CB", VA = "0xA5CB")]
			public SetEmailResponse()
			{
			}

			// Token: 0x04002FCD RID: 12237
			[Token(Token = "0x4002FCD")]
			[FieldOffset(Offset = "0x8")]
			public int success;

			// Token: 0x04002FCE RID: 12238
			[Token(Token = "0x4002FCE")]
			[FieldOffset(Offset = "0xC")]
			public int error_code;
		}
	}
}
