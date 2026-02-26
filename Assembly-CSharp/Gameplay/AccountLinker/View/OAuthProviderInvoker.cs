using System;
using Il2CppDummyDll;
using Protocol.Auth2;
using UI;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000E00 RID: 3584
	[Token(Token = "0x2000E00")]
	public class OAuthProviderInvoker : EnumValueInvoker<Provider>
	{
		// Token: 0x06005764 RID: 22372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005764")]
		[Address(RVA = "0xA4DF", Offset = "0xA4DF", VA = "0xA4DF")]
		public OAuthProviderInvoker()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_AccountLinker_View_OAuthProviderInvoker___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5891f == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12551);
		    DAT_ram_00a5891f = '\x01';
		  }
		  return StringLiteral_12551;
		}
		*/

		}
	}
}
