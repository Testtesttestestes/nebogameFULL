using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001358 RID: 4952
	[Token(Token = "0x2001358")]
	public static class GoogleLanguages
	{
		// Token: 0x0600758E RID: 30094 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600758E")]
		[Address(RVA = "0xBF1E", Offset = "0xBF1E", VA = "0xBF1E")]
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
			return null;
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600758F")]
		[Address(RVA = "0xBF1F", Offset = "0xBF1F", VA = "0xBF1F")]
		public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
		{
			return null;
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x000152E8 File Offset: 0x000134E8
		[Token(Token = "0x6007590")]
		[Address(RVA = "0x1EDE", Offset = "0x1EDE", VA = "0x1EDE")]
		private static bool LanguageMatchesFilter(string Language, string[] Filters)
		{
			return default(bool);
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007591")]
		[Address(RVA = "0xBF20", Offset = "0xBF20", VA = "0xBF20")]
		public static string GetFormatedLanguageName(string Language)
		{
			return null;
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007592")]
		[Address(RVA = "0x35EE", Offset = "0x35EE", VA = "0x35EE")]
		public static string GetCodedLanguage(string Language, string code)
		{
			return null;
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007593")]
		[Address(RVA = "0xBF21", Offset = "0xBF21", VA = "0xBF21")]
		public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
		{
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007594")]
		[Address(RVA = "0x1EEA", Offset = "0x1EEA", VA = "0x1EEA")]
		public static string GetGoogleLanguageCode(string InternationalCode)
		{
			return null;
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007595")]
		[Address(RVA = "0xBF22", Offset = "0xBF22", VA = "0xBF22")]
		public static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
		{
			return null;
		}

		// Token: 0x06007596 RID: 30102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007596")]
		[Address(RVA = "0xBF23", Offset = "0xBF23", VA = "0xBF23")]
		public static List<string> GetAllInternationalCodes()
		{
			return null;
		}

		// Token: 0x06007597 RID: 30103 RVA: 0x00015300 File Offset: 0x00013500
		[Token(Token = "0x6007597")]
		[Address(RVA = "0xBF24", Offset = "0xBF24", VA = "0xBF24")]
		public static bool LanguageCode_HasJoinedWord(string languageCode)
		{
			return default(bool);
		}

		// Token: 0x06007598 RID: 30104 RVA: 0x00015318 File Offset: 0x00013518
		[Token(Token = "0x6007598")]
		[Address(RVA = "0xBF25", Offset = "0xBF25", VA = "0xBF25")]
		private static int GetPluralRule(string langCode)
		{
			return 0;
		}

		// Token: 0x06007599 RID: 30105 RVA: 0x00015330 File Offset: 0x00013530
		[Token(Token = "0x6007599")]
		[Address(RVA = "0xBF26", Offset = "0xBF26", VA = "0xBF26")]
		public static bool LanguageHasPluralType(string langCode, string pluralType)
		{
			return default(bool);
		}

		// Token: 0x0600759A RID: 30106 RVA: 0x00015348 File Offset: 0x00013548
		[Token(Token = "0x600759A")]
		[Address(RVA = "0xBF27", Offset = "0xBF27", VA = "0xBF27")]
		public static ePluralType GetPluralType(string langCode, int n)
		{
			return ePluralType.Zero;
		}

		// Token: 0x0600759B RID: 30107 RVA: 0x00015360 File Offset: 0x00013560
		[Token(Token = "0x600759B")]
		[Address(RVA = "0xBF28", Offset = "0xBF28", VA = "0xBF28")]
		public static int GetPluralTestNumber(string langCode, ePluralType pluralType)
		{
			return 0;
		}

		// Token: 0x0600759C RID: 30108 RVA: 0x00015378 File Offset: 0x00013578
		[Token(Token = "0x600759C")]
		[Address(RVA = "0xBF29", Offset = "0xBF29", VA = "0xBF29")]
		private static bool inRange(int amount, int min, int max)
		{
			return default(bool);
		}

		// Token: 0x04003D69 RID: 15721
		[Token(Token = "0x4003D69")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<string, GoogleLanguages.LanguageCodeDef> mLanguageDef;

		// Token: 0x02001359 RID: 4953
		[Token(Token = "0x2001359")]
		public struct LanguageCodeDef
		{
			// Token: 0x04003D6A RID: 15722
			[Token(Token = "0x4003D6A")]
			[FieldOffset(Offset = "0x0")]
			public string Code;

			// Token: 0x04003D6B RID: 15723
			[Token(Token = "0x4003D6B")]
			[FieldOffset(Offset = "0x4")]
			public string GoogleCode;

			// Token: 0x04003D6C RID: 15724
			[Token(Token = "0x4003D6C")]
			[FieldOffset(Offset = "0x8")]
			public bool HasJoinedWords;

			// Token: 0x04003D6D RID: 15725
			[Token(Token = "0x4003D6D")]
			[FieldOffset(Offset = "0xC")]
			public int PluralRule;
		}
	}
}
