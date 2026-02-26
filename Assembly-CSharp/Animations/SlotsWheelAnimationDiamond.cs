using System;
using Il2CppDummyDll;

namespace Animations
{
	// Token: 0x02001335 RID: 4917
	[Token(Token = "0x2001335")]
	public class SlotsWheelAnimationDiamond : SlotsWheelAnimationBase
	{
		// Token: 0x17001773 RID: 6003
		// (get) Token: 0x0600746F RID: 29807 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001773")]
		public override string Prefix
		{
			[Token(Token = "0x600746F")]
			[Address(RVA = "0xBE3B", Offset = "0xBE3B", VA = "0xBE3B", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007470")]
		[Address(RVA = "0xBE3C", Offset = "0xBE3C", VA = "0xBE3C")]
		public SlotsWheelAnimationDiamond()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Animations_SlotsWheelAnimationDiamond___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a596b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_23011);
		    DAT_ram_00a596b7 = '\x01';
		  }
		  return StringLiteral_23011;
		}
		*/

		}
	}
}
