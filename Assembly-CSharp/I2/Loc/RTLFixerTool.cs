using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x020013B0 RID: 5040
	[Token(Token = "0x20013B0")]
	internal class RTLFixerTool
	{
		// Token: 0x060077D3 RID: 30675 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077D3")]
		[Address(RVA = "0xC12E", Offset = "0xC12E", VA = "0xC12E")]
		internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		// Token: 0x060077D4 RID: 30676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077D4")]
		[Address(RVA = "0xC12F", Offset = "0xC12F", VA = "0xC12F")]
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		// Token: 0x060077D5 RID: 30677 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60077D5")]
		[Address(RVA = "0xC130", Offset = "0xC130", VA = "0xC130")]
		internal static string FixLine(string str)
		{
			return null;
		}

		// Token: 0x060077D6 RID: 30678 RVA: 0x00016008 File Offset: 0x00014208
		[Token(Token = "0x60077D6")]
		[Address(RVA = "0xC131", Offset = "0xC131", VA = "0xC131")]
		internal static bool IsIgnoredCharacter(char ch)
		{
			return default(bool);
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x00016020 File Offset: 0x00014220
		[Token(Token = "0x60077D7")]
		[Address(RVA = "0xC132", Offset = "0xC132", VA = "0xC132")]
		internal static bool IsLeadingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x00016038 File Offset: 0x00014238
		[Token(Token = "0x60077D8")]
		[Address(RVA = "0xC133", Offset = "0xC133", VA = "0xC133")]
		internal static bool IsFinishingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x00016050 File Offset: 0x00014250
		[Token(Token = "0x60077D9")]
		[Address(RVA = "0xC134", Offset = "0xC134", VA = "0xC134")]
		internal static bool IsMiddleLetter(char[] letters, int index)
		{
			return default(bool);
		}

		// Token: 0x060077DA RID: 30682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077DA")]
		[Address(RVA = "0xC135", Offset = "0xC135", VA = "0xC135")]
		public RTLFixerTool()
		{
		}

		// Token: 0x04003EDF RID: 16095
		[Token(Token = "0x4003EDF")]
		[FieldOffset(Offset = "0x0")]
		internal static bool showTashkeel;

		// Token: 0x04003EE0 RID: 16096
		[Token(Token = "0x4003EE0")]
		[FieldOffset(Offset = "0x1")]
		internal static bool useHinduNumbers;
	}
}
