using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Rounting
{
	// Token: 0x02000E80 RID: 3712
	[Token(Token = "0x2000E80")]
	public class LocatorPayload
	{
		// Token: 0x06005A55 RID: 23125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A55")]
		[Address(RVA = "0xA756", Offset = "0xA756", VA = "0xA756")]
		public LocatorPayload(Dictionary<string, string> args, string fragment)
		{
		}

		// Token: 0x06005A56 RID: 23126 RVA: 0x00010110 File Offset: 0x0000E310
		[Token(Token = "0x6005A56")]
		[Address(RVA = "0xA757", Offset = "0xA757", VA = "0xA757")]
		public bool TryGetRequiredArgValue(string name, AbstractPathNode node, out string value)
		{
			return default(bool);
		}

		// Token: 0x06005A57 RID: 23127 RVA: 0x00010128 File Offset: 0x0000E328
		[Token(Token = "0x6005A57")]
		[Address(RVA = "0xA758", Offset = "0xA758", VA = "0xA758")]
		public bool TryGetOptionalArgValue(string name, out string value)
		{
			return default(bool);
		}

		// Token: 0x06005A58 RID: 23128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005A58")]
		[Address(RVA = "0xA759", Offset = "0xA759", VA = "0xA759", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400314D RID: 12621
		[Token(Token = "0x400314D")]
		[FieldOffset(Offset = "0x8")]
		public readonly Dictionary<string, string> Args;

		// Token: 0x0400314E RID: 12622
		[Token(Token = "0x400314E")]
		[FieldOffset(Offset = "0xC")]
		public readonly string Fragment;
	}
}
