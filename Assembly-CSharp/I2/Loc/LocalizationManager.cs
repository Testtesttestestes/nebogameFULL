using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200137B RID: 4987
	[Token(Token = "0x200137B")]
	public static class LocalizationManager
	{
		// Token: 0x0600768D RID: 30349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600768D")]
		[Address(RVA = "0xC004", Offset = "0xC004", VA = "0xC004")]
		public static void InitializeIfNeeded()
		{
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600768E")]
		[Address(RVA = "0xC005", Offset = "0xC005", VA = "0xC005")]
		public static string GetVersion()
		{
			return null;
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x000157B0 File Offset: 0x000139B0
		[Token(Token = "0x600768F")]
		[Address(RVA = "0xC006", Offset = "0xC006", VA = "0xC006")]
		public static int GetRequiredWebServiceVersion()
		{
			return 0;
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007690")]
		[Address(RVA = "0xC007", Offset = "0xC007", VA = "0xC007")]
		public static string GetWebServiceURL([Optional] LanguageSourceData source)
		{
			return null;
		}

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06007691 RID: 30353 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007692 RID: 30354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017AB")]
		public static string CurrentLanguage
		{
			[Token(Token = "0x6007691")]
			[Address(RVA = "0xC008", Offset = "0xC008", VA = "0xC008")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007692")]
			[Address(RVA = "0xC009", Offset = "0xC009", VA = "0xC009")]
			set
			{
			}
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x06007693 RID: 30355 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007694 RID: 30356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017AC")]
		public static string CurrentLanguageCode
		{
			[Token(Token = "0x6007693")]
			[Address(RVA = "0xC00A", Offset = "0xC00A", VA = "0xC00A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007694")]
			[Address(RVA = "0xC00B", Offset = "0xC00B", VA = "0xC00B")]
			set
			{
			}
		}

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x06007695 RID: 30357 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007696 RID: 30358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017AD")]
		public static string CurrentRegion
		{
			[Token(Token = "0x6007695")]
			[Address(RVA = "0xC00C", Offset = "0xC00C", VA = "0xC00C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007696")]
			[Address(RVA = "0xC00D", Offset = "0xC00D", VA = "0xC00D")]
			set
			{
			}
		}

		// Token: 0x170017AE RID: 6062
		// (get) Token: 0x06007697 RID: 30359 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007698 RID: 30360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017AE")]
		public static string CurrentRegionCode
		{
			[Token(Token = "0x6007697")]
			[Address(RVA = "0xC00E", Offset = "0xC00E", VA = "0xC00E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007698")]
			[Address(RVA = "0xC00F", Offset = "0xC00F", VA = "0xC00F")]
			set
			{
			}
		}

		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x06007699 RID: 30361 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017AF")]
		public static CultureInfo CurrentCulture
		{
			[Token(Token = "0x6007699")]
			[Address(RVA = "0xC010", Offset = "0xC010", VA = "0xC010")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600769A")]
		[Address(RVA = "0xC011", Offset = "0xC011", VA = "0xC011")]
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600769B")]
		[Address(RVA = "0xC012", Offset = "0xC012", VA = "0xC012")]
		private static CultureInfo CreateCultureForCode(string code)
		{
			return null;
		}

		// Token: 0x0600769C RID: 30364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600769C")]
		[Address(RVA = "0xC013", Offset = "0xC013", VA = "0xC013")]
		public static void EnableChangingCultureInfo(bool bEnable)
		{
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600769D")]
		[Address(RVA = "0xC014", Offset = "0xC014", VA = "0xC014")]
		private static void SetCurrentCultureInfo()
		{
		}

		// Token: 0x0600769E RID: 30366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600769E")]
		[Address(RVA = "0xC015", Offset = "0xC015", VA = "0xC015")]
		private static void SelectStartupLanguage()
		{
		}

		// Token: 0x0600769F RID: 30367 RVA: 0x000157C8 File Offset: 0x000139C8
		[Token(Token = "0x600769F")]
		[Address(RVA = "0xC016", Offset = "0xC016", VA = "0xC016")]
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
		{
			return default(bool);
		}

		// Token: 0x060076A0 RID: 30368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076A0")]
		[Address(RVA = "0xC017", Offset = "0xC017", VA = "0xC017")]
		public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
		{
			return null;
		}

		// Token: 0x060076A1 RID: 30369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076A1")]
		[Address(RVA = "0xC018", Offset = "0xC018", VA = "0xC018")]
		public static string GetLanguageCode(string Language)
		{
			return null;
		}

		// Token: 0x060076A2 RID: 30370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076A2")]
		[Address(RVA = "0xC019", Offset = "0xC019", VA = "0xC019")]
		public static string GetLanguageFromCode(string Code, bool exactMatch = true)
		{
			return null;
		}

		// Token: 0x060076A3 RID: 30371 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076A3")]
		[Address(RVA = "0xC01A", Offset = "0xC01A", VA = "0xC01A")]
		public static List<string> GetAllLanguages(bool SkipDisabled = true)
		{
			return null;
		}

		// Token: 0x060076A4 RID: 30372 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076A4")]
		[Address(RVA = "0xC01B", Offset = "0xC01B", VA = "0xC01B")]
		public static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true)
		{
			return null;
		}

		// Token: 0x060076A5 RID: 30373 RVA: 0x000157E0 File Offset: 0x000139E0
		[Token(Token = "0x60076A5")]
		[Address(RVA = "0xC01C", Offset = "0xC01C", VA = "0xC01C")]
		public static bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		// Token: 0x060076A6 RID: 30374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076A6")]
		[Address(RVA = "0xC01D", Offset = "0xC01D", VA = "0xC01D")]
		private static void LoadCurrentLanguage()
		{
		}

		// Token: 0x060076A7 RID: 30375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076A7")]
		[Address(RVA = "0xC01E", Offset = "0xC01E", VA = "0xC01E")]
		public static void PreviewLanguage(string NewLanguage)
		{
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076A8")]
		[Address(RVA = "0xC01F", Offset = "0xC01F", VA = "0xC01F")]
		public static void AutoLoadGlobalParamManagers()
		{
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076A9")]
		[Address(RVA = "0xC020", Offset = "0xC020", VA = "0xC020")]
		public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = true)
		{
		}

		// Token: 0x060076AA RID: 30378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076AA")]
		[Address(RVA = "0xC021", Offset = "0xC021", VA = "0xC021")]
		public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
		{
		}

		// Token: 0x060076AB RID: 30379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076AB")]
		[Address(RVA = "0xC022", Offset = "0xC022", VA = "0xC022")]
		public static void ApplyLocalizationParams(ref string translation, Dictionary<string, object> parameters, bool allowLocalizedParameters = true)
		{
		}

		// Token: 0x060076AC RID: 30380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076AC")]
		[Address(RVA = "0xC023", Offset = "0xC023", VA = "0xC023")]
		public static void ApplyLocalizationParams(ref string translation, LocalizationManager._GetParam getParam, bool allowLocalizedParameters = true)
		{
		}

		// Token: 0x060076AD RID: 30381 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076AD")]
		[Address(RVA = "0xC024", Offset = "0xC024", VA = "0xC024")]
		internal static string GetLocalizationParam(string ParamName, GameObject root)
		{
			return null;
		}

		// Token: 0x060076AE RID: 30382 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076AE")]
		[Address(RVA = "0xC025", Offset = "0xC025", VA = "0xC025")]
		private static string GetPluralType(MatchCollection matches, string langCode, LocalizationManager._GetParam getParam)
		{
			return null;
		}

		// Token: 0x060076AF RID: 30383 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076AF")]
		[Address(RVA = "0xC026", Offset = "0xC026", VA = "0xC026")]
		public static string ApplyRTLfix(string line)
		{
			return null;
		}

		// Token: 0x060076B0 RID: 30384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076B0")]
		[Address(RVA = "0xC027", Offset = "0xC027", VA = "0xC027")]
		public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
		{
			return null;
		}

		// Token: 0x060076B1 RID: 30385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076B1")]
		[Address(RVA = "0xC028", Offset = "0xC028", VA = "0xC028")]
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false)
		{
			return null;
		}

		// Token: 0x060076B2 RID: 30386 RVA: 0x000157F8 File Offset: 0x000139F8
		[Token(Token = "0x60076B2")]
		[Address(RVA = "0xC029", Offset = "0xC029", VA = "0xC029")]
		public static bool IsRTL(string Code)
		{
			return default(bool);
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x00015810 File Offset: 0x00013A10
		[Token(Token = "0x60076B3")]
		[Address(RVA = "0xC02A", Offset = "0xC02A", VA = "0xC02A")]
		public static bool UpdateSources()
		{
			return default(bool);
		}

		// Token: 0x060076B4 RID: 30388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076B4")]
		[Address(RVA = "0xC02B", Offset = "0xC02B", VA = "0xC02B")]
		private static void UnregisterDeletededSources()
		{
		}

		// Token: 0x060076B5 RID: 30389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076B5")]
		[Address(RVA = "0xC02C", Offset = "0xC02C", VA = "0xC02C")]
		private static void RegisterSceneSources()
		{
		}

		// Token: 0x060076B6 RID: 30390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076B6")]
		[Address(RVA = "0xC02D", Offset = "0xC02D", VA = "0xC02D")]
		private static void RegisterSourceInResources()
		{
		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x00015828 File Offset: 0x00013A28
		[Token(Token = "0x60076B7")]
		[Address(RVA = "0xC02E", Offset = "0xC02E", VA = "0xC02E")]
		private static bool AllowSyncFromGoogle(LanguageSourceData Source)
		{
			return default(bool);
		}

		// Token: 0x060076B8 RID: 30392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076B8")]
		[Address(RVA = "0xC02F", Offset = "0xC02F", VA = "0xC02F")]
		internal static void AddSource(LanguageSourceData Source)
		{
		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076B9")]
		[Address(RVA = "0xC030", Offset = "0xC030", VA = "0xC030")]
		private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
		{
			return null;
		}

		// Token: 0x060076BA RID: 30394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076BA")]
		[Address(RVA = "0xC031", Offset = "0xC031", VA = "0xC031")]
		internal static void RemoveSource(LanguageSourceData Source)
		{
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x00015840 File Offset: 0x00013A40
		[Token(Token = "0x60076BB")]
		[Address(RVA = "0xC032", Offset = "0xC032", VA = "0xC032")]
		public static bool IsGlobalSource(string SourceName)
		{
			return default(bool);
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076BC")]
		[Address(RVA = "0xC033", Offset = "0xC033", VA = "0xC033")]
		public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true)
		{
			return null;
		}

		// Token: 0x060076BD RID: 30397 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076BD")]
		[Address(RVA = "0xC034", Offset = "0xC034", VA = "0xC034")]
		public static UnityEngine.Object FindAsset(string value)
		{
			return null;
		}

		// Token: 0x060076BE RID: 30398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076BE")]
		[Address(RVA = "0xC035", Offset = "0xC035", VA = "0xC035")]
		public static void ApplyDownloadedDataFromGoogle()
		{
		}

		// Token: 0x060076BF RID: 30399 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076BF")]
		[Address(RVA = "0xC036", Offset = "0xC036", VA = "0xC036")]
		public static string GetCurrentDeviceLanguage(bool force = false)
		{
			return null;
		}

		// Token: 0x060076C0 RID: 30400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076C0")]
		[Address(RVA = "0xC037", Offset = "0xC037", VA = "0xC037")]
		private static void DetectDeviceLanguage()
		{
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076C1")]
		[Address(RVA = "0xC038", Offset = "0xC038", VA = "0xC038")]
		public static void RegisterTarget(ILocalizeTargetDescriptor desc)
		{
		}

		// Token: 0x14000308 RID: 776
		// (add) Token: 0x060076C2 RID: 30402 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060076C3 RID: 30403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000308")]
		public static event LocalizationManager.OnLocalizeCallback OnLocalizeEvent
		{
			[Token(Token = "0x60076C2")]
			[Address(RVA = "0xC039", Offset = "0xC039", VA = "0xC039")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60076C3")]
			[Address(RVA = "0xC03A", Offset = "0xC03A", VA = "0xC03A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060076C4 RID: 30404 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076C4")]
		[Address(RVA = "0xC03B", Offset = "0xC03B", VA = "0xC03B")]
		public static string GetTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return null;
		}

		// Token: 0x060076C5 RID: 30405 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076C5")]
		[Address(RVA = "0xC03C", Offset = "0xC03C", VA = "0xC03C")]
		public static string GetTermTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return null;
		}

		// Token: 0x060076C6 RID: 30406 RVA: 0x00015858 File Offset: 0x00013A58
		[Token(Token = "0x60076C6")]
		[Address(RVA = "0x3610", Offset = "0x3610", VA = "0x3610")]
		public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage, bool allowLocalizedParameters = true)
		{
			return default(bool);
		}

		// Token: 0x060076C7 RID: 30407 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076C7")]
		public static T GetTranslatedObject<T>(string AssetName, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076C8")]
		public static T GetTranslatedObjectByTermName<T>(string Term, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x060076C9 RID: 30409 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076C9")]
		[Address(RVA = "0xC03D", Offset = "0xC03D", VA = "0xC03D")]
		public static string GetAppName(string languageCode)
		{
			return null;
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076CA")]
		[Address(RVA = "0xC03E", Offset = "0xC03E", VA = "0xC03E")]
		public static void LocalizeAll(bool Force = false)
		{
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076CB")]
		[Address(RVA = "0xC03F", Offset = "0xC03F", VA = "0xC03F")]
		private static IEnumerator Coroutine_LocalizeAll()
		{
			return null;
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076CC")]
		[Address(RVA = "0xC040", Offset = "0xC040", VA = "0xC040")]
		private static void DoLocalizeAll(bool Force = false)
		{
		}

		// Token: 0x060076CD RID: 30413 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076CD")]
		[Address(RVA = "0xC041", Offset = "0xC041", VA = "0xC041")]
		public static List<string> GetCategories()
		{
			return null;
		}

		// Token: 0x060076CE RID: 30414 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076CE")]
		[Address(RVA = "0xC042", Offset = "0xC042", VA = "0xC042")]
		public static List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		// Token: 0x060076CF RID: 30415 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076CF")]
		[Address(RVA = "0xC043", Offset = "0xC043", VA = "0xC043")]
		public static TermData GetTermData(string term)
		{
			return null;
		}

		// Token: 0x060076D0 RID: 30416 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60076D0")]
		[Address(RVA = "0xC044", Offset = "0xC044", VA = "0xC044")]
		public static TermData GetTermData(string term, out LanguageSourceData source)
		{
			return null;
		}

		// Token: 0x04003E25 RID: 15909
		[Token(Token = "0x4003E25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string mCurrentLanguage;

		// Token: 0x04003E26 RID: 15910
		[Token(Token = "0x4003E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static string mLanguageCode;

		// Token: 0x04003E27 RID: 15911
		[Token(Token = "0x4003E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static CultureInfo mCurrentCulture;

		// Token: 0x04003E28 RID: 15912
		[Token(Token = "0x4003E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static bool mChangeCultureInfo;

		// Token: 0x04003E29 RID: 15913
		[Token(Token = "0x4003E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public static bool IsRight2Left;

		// Token: 0x04003E2A RID: 15914
		[Token(Token = "0x4003E2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public static bool HasJoinedWords;

		// Token: 0x04003E2B RID: 15915
		[Token(Token = "0x4003E2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static List<ILocalizationParamsManager> ParamManagers;

		// Token: 0x04003E2C RID: 15916
		[Token(Token = "0x4003E2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static LocalizationManager.FnCustomApplyLocalizationParams CustomApplyLocalizationParams;

		// Token: 0x04003E2D RID: 15917
		[Token(Token = "0x4003E2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string[] LanguagesRTL;

		// Token: 0x04003E2E RID: 15918
		[Token(Token = "0x4003E2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static List<LanguageSourceData> Sources;

		// Token: 0x04003E2F RID: 15919
		[Token(Token = "0x4003E2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] GlobalSources;

		// Token: 0x04003E30 RID: 15920
		[Token(Token = "0x4003E30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Func<LanguageSourceData, bool> Callback_AllowSyncFromGoogle;

		// Token: 0x04003E31 RID: 15921
		[Token(Token = "0x4003E31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string mCurrentDeviceLanguage;

		// Token: 0x04003E32 RID: 15922
		[Token(Token = "0x4003E32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static List<ILocalizeTargetDescriptor> mLocalizeTargets;

		// Token: 0x04003E34 RID: 15924
		[Token(Token = "0x4003E34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static bool mLocalizeIsScheduled;

		// Token: 0x04003E35 RID: 15925
		[Token(Token = "0x4003E35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private static bool mLocalizeIsScheduledWithForcedValue;

		// Token: 0x04003E36 RID: 15926
		[Token(Token = "0x4003E36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public static bool HighlightLocalizedTargets;

		// Token: 0x0200137C RID: 4988
		// (Invoke) Token: 0x060076D3 RID: 30419
		[Token(Token = "0x200137C")]
		public delegate bool FnCustomApplyLocalizationParams(ref string translation, LocalizationManager._GetParam getParam, bool allowLocalizedParameters);

		// Token: 0x0200137D RID: 4989
		// (Invoke) Token: 0x060076D7 RID: 30423
		[Token(Token = "0x200137D")]
		public delegate object _GetParam(string param);

		// Token: 0x0200137E RID: 4990
		// (Invoke) Token: 0x060076DB RID: 30427
		[Token(Token = "0x200137E")]
		public delegate void OnLocalizeCallback();
	}
}
