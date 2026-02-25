using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace I2.Loc
{
	// Token: 0x0200135A RID: 4954
	[Token(Token = "0x200135A")]
	public static class GoogleTranslation
	{
		// Token: 0x0600759E RID: 30110 RVA: 0x00015390 File Offset: 0x00013590
		[Token(Token = "0x600759E")]
		[Address(RVA = "0xBF2B", Offset = "0xBF2B", VA = "0xBF2B")]
		public static bool CanTranslate()
		{
			return default(bool);
		}

		// Token: 0x0600759F RID: 30111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600759F")]
		[Address(RVA = "0xBF2C", Offset = "0xBF2C", VA = "0xBF2C")]
		public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, GoogleTranslation.fnOnTranslated OnTranslationReady)
		{
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075A0")]
		[Address(RVA = "0xBF2D", Offset = "0xBF2D", VA = "0xBF2D")]
		public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
			return null;
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A1")]
		[Address(RVA = "0xBF2E", Offset = "0xBF2E", VA = "0xBF2E")]
		public static void Translate(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady, bool usePOST = true)
		{
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x000153A8 File Offset: 0x000135A8
		[Token(Token = "0x60075A2")]
		[Address(RVA = "0xBF2F", Offset = "0xBF2F", VA = "0xBF2F")]
		public static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true)
		{
			return default(bool);
		}

		// Token: 0x060075A3 RID: 30115 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075A3")]
		[Address(RVA = "0xBF30", Offset = "0xBF30", VA = "0xBF30")]
		public static List<string> ConvertTranslationRequest(Dictionary<string, TranslationQuery> requests, bool encodeGET)
		{
			return null;
		}

		// Token: 0x060075A4 RID: 30116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A4")]
		[Address(RVA = "0xBF31", Offset = "0xBF31", VA = "0xBF31")]
		private static void AddTranslationJob(TranslationJob job)
		{
		}

		// Token: 0x060075A5 RID: 30117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075A5")]
		[Address(RVA = "0xBF32", Offset = "0xBF32", VA = "0xBF32")]
		private static IEnumerator WaitForTranslations()
		{
			return null;
		}

		// Token: 0x060075A6 RID: 30118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075A6")]
		[Address(RVA = "0xBF33", Offset = "0xBF33", VA = "0xBF33")]
		public static string ParseTranslationResult(string html, Dictionary<string, TranslationQuery> requests)
		{
			return null;
		}

		// Token: 0x060075A7 RID: 30119 RVA: 0x000153C0 File Offset: 0x000135C0
		[Token(Token = "0x60075A7")]
		[Address(RVA = "0xBF34", Offset = "0xBF34", VA = "0xBF34")]
		public static bool IsTranslating()
		{
			return default(bool);
		}

		// Token: 0x060075A8 RID: 30120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A8")]
		[Address(RVA = "0xBF35", Offset = "0xBF35", VA = "0xBF35")]
		public static void CancelCurrentGoogleTranslations()
		{
		}

		// Token: 0x060075A9 RID: 30121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075A9")]
		[Address(RVA = "0xBF36", Offset = "0xBF36", VA = "0xBF36")]
		public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		// Token: 0x060075AA RID: 30122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075AA")]
		[Address(RVA = "0x1EE7", Offset = "0x1EE7", VA = "0x1EE7")]
		private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		// Token: 0x060075AB RID: 30123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075AB")]
		[Address(RVA = "0xBF37", Offset = "0xBF37", VA = "0xBF37")]
		public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		// Token: 0x060075AC RID: 30124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075AC")]
		[Address(RVA = "0xBF38", Offset = "0xBF38", VA = "0xBF38")]
		private static string GetTranslation(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		// Token: 0x060075AD RID: 30125 RVA: 0x000153D8 File Offset: 0x000135D8
		[Token(Token = "0x60075AD")]
		[Address(RVA = "0xBF39", Offset = "0xBF39", VA = "0xBF39")]
		private static TranslationQuery FindQueryFromOrigText(string origText, Dictionary<string, TranslationQuery> dict)
		{
			return default(TranslationQuery);
		}

		// Token: 0x060075AE RID: 30126 RVA: 0x000153F0 File Offset: 0x000135F0
		[Token(Token = "0x60075AE")]
		[Address(RVA = "0xBF3A", Offset = "0xBF3A", VA = "0xBF3A")]
		public static bool HasParameters(string text)
		{
			return default(bool);
		}

		// Token: 0x060075AF RID: 30127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075AF")]
		[Address(RVA = "0xBF3B", Offset = "0xBF3B", VA = "0xBF3B")]
		public static string GetPluralParameter(string text, bool forceTag)
		{
			return null;
		}

		// Token: 0x060075B0 RID: 30128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B0")]
		[Address(RVA = "0xBF3C", Offset = "0xBF3C", VA = "0xBF3C")]
		public static string GetPluralText(string text, string pluralType)
		{
			return null;
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x00015408 File Offset: 0x00013608
		[Token(Token = "0x60075B1")]
		[Address(RVA = "0xBF3D", Offset = "0xBF3D", VA = "0xBF3D")]
		private static int FindClosingTag(string tag, MatchCollection matches, int startIndex)
		{
			return 0;
		}

		// Token: 0x060075B2 RID: 30130 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B2")]
		[Address(RVA = "0xBF3E", Offset = "0xBF3E", VA = "0xBF3E")]
		private static string GetGoogleNoTranslateTag(int tagNumber)
		{
			return null;
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075B3")]
		[Address(RVA = "0xBF3F", Offset = "0xBF3F", VA = "0xBF3F")]
		private static void ParseNonTranslatableElements(ref TranslationQuery query)
		{
		}

		// Token: 0x060075B4 RID: 30132 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B4")]
		[Address(RVA = "0xBF40", Offset = "0xBF40", VA = "0xBF40")]
		public static string GetQueryResult(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B5")]
		[Address(RVA = "0xBF41", Offset = "0xBF41", VA = "0xBF41")]
		public static string RebuildTranslation(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B6")]
		[Address(RVA = "0x1EF1", Offset = "0x1EF1", VA = "0x1EF1")]
		private static string RebuildTranslation_Plural(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		// Token: 0x060075B7 RID: 30135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B7")]
		[Address(RVA = "0x35E1", Offset = "0x35E1", VA = "0x35E1")]
		public static string UppercaseFirst(string s)
		{
			return null;
		}

		// Token: 0x060075B8 RID: 30136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075B8")]
		[Address(RVA = "0x35E2", Offset = "0x35E2", VA = "0x35E2")]
		public static string TitleCase(string s)
		{
			return null;
		}

		// Token: 0x04003D6E RID: 15726
		[Token(Token = "0x4003D6E")]
		[FieldOffset(Offset = "0x0")]
		private static List<UnityWebRequest> mCurrentTranslations;

		// Token: 0x04003D6F RID: 15727
		[Token(Token = "0x4003D6F")]
		[FieldOffset(Offset = "0x4")]
		private static List<TranslationJob> mTranslationJobs;

		// Token: 0x0200135B RID: 4955
		// (Invoke) Token: 0x060075BB RID: 30139
		[Token(Token = "0x200135B")]
		public delegate void fnOnTranslated(string Translation, string Error);

		// Token: 0x0200135C RID: 4956
		// (Invoke) Token: 0x060075BF RID: 30143
		[Token(Token = "0x200135C")]
		public delegate void fnOnTranslationReady(Dictionary<string, TranslationQuery> dict, string error);
	}
}
