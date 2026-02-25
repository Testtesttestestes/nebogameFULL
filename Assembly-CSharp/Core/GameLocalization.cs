using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Core
{
	// Token: 0x02000E59 RID: 3673
	[Token(Token = "0x2000E59")]
	public static class GameLocalization
	{
		// Token: 0x060059E4 RID: 23012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E4")]
		[Address(RVA = "0xA708", Offset = "0xA708", VA = "0xA708")]
		public static void SetLocalizationLanguage(CultureInfo culture)
		{
		}

		// Token: 0x060059E5 RID: 23013 RVA: 0x0000FF00 File Offset: 0x0000E100
		[Token(Token = "0x60059E5")]
		[Address(RVA = "0xA709", Offset = "0xA709", VA = "0xA709")]
		public static bool IsCyrillic(CultureInfo culture)
		{
			return default(bool);
		}

		// Token: 0x060059E6 RID: 23014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E6")]
		[Address(RVA = "0xA70A", Offset = "0xA70A", VA = "0xA70A")]
		public static void UpdateLocalization(RepeatedField<UIStringDic> newLocalization)
		{
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60059E7")]
		[Address(RVA = "0x1D55", Offset = "0x1D55", VA = "0x1D55")]
		public static string GetValue(string key, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return null;
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x0000FF18 File Offset: 0x0000E118
		[Token(Token = "0x60059E8")]
		[Address(RVA = "0xA70B", Offset = "0xA70B", VA = "0xA70B")]
		public static bool TryGetValue(string key, out string value, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return default(bool);
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60059E9")]
		[Address(RVA = "0x1B5A", Offset = "0x1B5A", VA = "0x1B5A")]
		public static string GetTranslation(string key, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return null;
		}

		// Token: 0x0400309B RID: 12443
		[Token(Token = "0x400309B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<string> _cyrillicLanguageCodes;
	}
}
