using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x02001376 RID: 4982
	[Token(Token = "0x2001376")]
	public class LocalizationReader
	{
		// Token: 0x0600765B RID: 30299 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600765B")]
		[Address(RVA = "0xBFD7", Offset = "0xBFD7", VA = "0xBFD7")]
		public static Dictionary<string, string> ReadTextAsset(TextAsset asset)
		{
			return null;
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x00015738 File Offset: 0x00013938
		[Token(Token = "0x600765C")]
		[Address(RVA = "0xBFD8", Offset = "0xBFD8", VA = "0xBFD8")]
		public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
		{
			return default(bool);
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600765D")]
		[Address(RVA = "0xBFD9", Offset = "0xBFD9", VA = "0xBFD9")]
		public static string ReadCSVfile(string Path, Encoding encoding)
		{
			return null;
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600765E")]
		[Address(RVA = "0xBFDA", Offset = "0xBFDA", VA = "0xBFDA")]
		public static List<string[]> ReadCSV(string Text, char Separator = ',')
		{
			return null;
		}

		// Token: 0x0600765F RID: 30303 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600765F")]
		[Address(RVA = "0xBFDB", Offset = "0xBFDB", VA = "0xBFDB")]
		private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
		{
			return null;
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007660")]
		[Address(RVA = "0xBFDC", Offset = "0xBFDC", VA = "0xBFDC")]
		private static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart)
		{
		}

		// Token: 0x06007661 RID: 30305 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007661")]
		[Address(RVA = "0x3604", Offset = "0x3604", VA = "0x3604")]
		public static List<string[]> ReadI2CSV(string Text)
		{
			return null;
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007662")]
		[Address(RVA = "0xBFDD", Offset = "0xBFDD", VA = "0xBFDD")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007663")]
		[Address(RVA = "0xBFDE", Offset = "0xBFDE", VA = "0xBFDE")]
		public static string EncodeString(string str)
		{
			return null;
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007664")]
		[Address(RVA = "0xBFDF", Offset = "0xBFDF", VA = "0xBFDF")]
		public static string DecodeString(string str)
		{
			return null;
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007665")]
		[Address(RVA = "0xBFE0", Offset = "0xBFE0", VA = "0xBFE0")]
		public LocalizationReader()
		{
		}
	}
}
