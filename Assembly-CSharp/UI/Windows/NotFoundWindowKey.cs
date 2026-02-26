using System;
using Il2CppDummyDll;

namespace UI.Windows
{
	// Token: 0x0200027B RID: 635
	[Token(Token = "0x200027B")]
	public class NotFoundWindowKey : Exception
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021A")]
		public override string Message
		{
			[Token(Token = "0x6000F39")]
			[Address(RVA = "0x616D", Offset = "0x616D", VA = "0x616D", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x616E", Offset = "0x616E", VA = "0x616E")]
		public NotFoundWindowKey(string windowId)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Windows_NotFoundWindowKey___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a639f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11635);
		    DAT_ram_00a639f2 = '\x01';
		  }
		  uVar1 = func_ii_4419(StringLiteral_11635,*(undefined4 *)(param1 + 0x48),0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		private const string FORMAT = "Not found window key [{0}]";

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		[FieldOffset(Offset = "0x48")]
		public readonly string WindowId;
	}
}
