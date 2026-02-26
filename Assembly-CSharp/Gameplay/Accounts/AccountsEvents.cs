using System;
using System.Collections.Generic;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Accounts
{
	// Token: 0x02000DC4 RID: 3524
	[Token(Token = "0x2000DC4")]
	public class AccountsEvents : AbstractMVCEvents
	{
		// Token: 0x06005601 RID: 22017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005601")]
		[Address(RVA = "0xA3A1", Offset = "0xA3A1", VA = "0xA3A1")]
		public AccountsEvents()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Accounts_AccountsEvents___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58881 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12553);
		    DAT_ram_00a58881 = '\x01';
		  }
		  return StringLiteral_12553;
		}
		*/

		}

		// Token: 0x04002E97 RID: 11927
		[Token(Token = "0x4002E97")]
		[FieldOffset(Offset = "0x14")]
		public Action<IAccountDataDecorator> AccountChangedEvent;

		// Token: 0x04002E98 RID: 11928
		[Token(Token = "0x4002E98")]
		[FieldOffset(Offset = "0x18")]
		public Action<IList<IAccountDataDecorator>> AccountStickerChangedEvent;

		// Token: 0x04002E99 RID: 11929
		[Token(Token = "0x4002E99")]
		[FieldOffset(Offset = "0x1C")]
		public Action PromotionUpdateCompleteEvent;

		// Token: 0x04002E9A RID: 11930
		[Token(Token = "0x4002E9A")]
		[FieldOffset(Offset = "0x20")]
		public Action<int> NotificationsCountChangedEvent;
	}
}
