using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	// Token: 0x0200136E RID: 4974
	[Token(Token = "0x200136E")]
	[ExecuteInEditMode]
	[Serializable]
	public class LanguageSourceData
	{
		// Token: 0x170017A6 RID: 6054
		// (get) Token: 0x060075FE RID: 30206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017A6")]
		public UnityEngine.Object ownerObject
		{
			[Token(Token = "0x60075FE")]
			[Address(RVA = "0xBF85", Offset = "0xBF85", VA = "0xBF85")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000307 RID: 775
		// (add) Token: 0x060075FF RID: 30207 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007600 RID: 30208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000307")]
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60075FF")]
			[Address(RVA = "0xBF86", Offset = "0xBF86", VA = "0xBF86")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6007600")]
			[Address(RVA = "0xBF87", Offset = "0xBF87", VA = "0xBF87")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06007601 RID: 30209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007601")]
		[Address(RVA = "0xBF88", Offset = "0xBF88", VA = "0xBF88")]
		public void Awake()
		{
		}

		// Token: 0x06007602 RID: 30210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007602")]
		[Address(RVA = "0xBF89", Offset = "0xBF89", VA = "0xBF89")]
		public void OnDestroy()
		{
		}

		// Token: 0x06007603 RID: 30211 RVA: 0x00015510 File Offset: 0x00013710
		[Token(Token = "0x6007603")]
		[Address(RVA = "0xBF8A", Offset = "0xBF8A", VA = "0xBF8A")]
		public bool IsEqualTo(LanguageSourceData Source)
		{
			return default(bool);
		}

		// Token: 0x06007604 RID: 30212 RVA: 0x00015528 File Offset: 0x00013728
		[Token(Token = "0x6007604")]
		[Address(RVA = "0xBF8B", Offset = "0xBF8B", VA = "0xBF8B")]
		internal bool ManagerHasASimilarSource()
		{
			return default(bool);
		}

		// Token: 0x06007605 RID: 30213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007605")]
		[Address(RVA = "0x3603", Offset = "0x3603", VA = "0x3603")]
		public void ClearAllData()
		{
		}

		// Token: 0x06007606 RID: 30214 RVA: 0x00015540 File Offset: 0x00013740
		[Token(Token = "0x6007606")]
		[Address(RVA = "0xBF8C", Offset = "0xBF8C", VA = "0xBF8C")]
		public bool IsGlobalSource()
		{
			return default(bool);
		}

		// Token: 0x06007607 RID: 30215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007607")]
		[Address(RVA = "0xBF8D", Offset = "0xBF8D", VA = "0xBF8D")]
		public void Editor_SetDirty()
		{
		}

		// Token: 0x06007608 RID: 30216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007608")]
		[Address(RVA = "0xBF8E", Offset = "0xBF8E", VA = "0xBF8E")]
		public void UpdateAssetDictionary()
		{
		}

		// Token: 0x06007609 RID: 30217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007609")]
		[Address(RVA = "0xBF8F", Offset = "0xBF8F", VA = "0xBF8F")]
		public UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		// Token: 0x0600760A RID: 30218 RVA: 0x00015558 File Offset: 0x00013758
		[Token(Token = "0x600760A")]
		[Address(RVA = "0xBF90", Offset = "0xBF90", VA = "0xBF90")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		// Token: 0x0600760B RID: 30219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760B")]
		[Address(RVA = "0xBF91", Offset = "0xBF91", VA = "0xBF91")]
		public void AddAsset(UnityEngine.Object Obj)
		{
		}

		// Token: 0x0600760C RID: 30220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600760C")]
		[Address(RVA = "0xBF92", Offset = "0xBF92", VA = "0xBF92")]
		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
			return null;
		}

		// Token: 0x0600760D RID: 30221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600760D")]
		[Address(RVA = "0x35F9", Offset = "0x35F9", VA = "0x35F9")]
		public string Export_I2CSV(string Category, char Separator = ',', bool specializationsAsRows = true, bool sortRows = true)
		{
			return null;
		}

		// Token: 0x0600760E RID: 30222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760E")]
		[Address(RVA = "0x35F1", Offset = "0x35F1", VA = "0x35F1")]
		private static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, char Separator, string forceSpecialization)
		{
		}

		// Token: 0x0600760F RID: 30223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600760F")]
		[Address(RVA = "0xBF93", Offset = "0xBF93", VA = "0xBF93")]
		private static void AppendI2Text(StringBuilder Builder, string text)
		{
		}

		// Token: 0x06007610 RID: 30224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007610")]
		[Address(RVA = "0xBF94", Offset = "0xBF94", VA = "0xBF94")]
		public string Export_CSV(string Category, char Separator = ',', bool specializationsAsRows = true, bool sortRows = true)
		{
			return null;
		}

		// Token: 0x06007611 RID: 30225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007611")]
		[Address(RVA = "0x35F6", Offset = "0x35F6", VA = "0x35F6")]
		private static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string specialization, char Separator)
		{
		}

		// Token: 0x06007612 RID: 30226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007612")]
		[Address(RVA = "0x35F4", Offset = "0x35F4", VA = "0x35F4")]
		private static void AppendString(StringBuilder Builder, string Text, char Separator)
		{
		}

		// Token: 0x06007613 RID: 30227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007613")]
		[Address(RVA = "0xBF95", Offset = "0xBF95", VA = "0xBF95")]
		private static void AppendTranslation(StringBuilder Builder, string Text, char Separator, string tags)
		{
		}

		// Token: 0x06007614 RID: 30228 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007614")]
		[Address(RVA = "0xBF96", Offset = "0xBF96", VA = "0xBF96")]
		public UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		// Token: 0x06007615 RID: 30229 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007615")]
		[Address(RVA = "0xBF97", Offset = "0xBF97", VA = "0xBF97")]
		private string Export_Google_CreateData()
		{
			return null;
		}

		// Token: 0x06007616 RID: 30230 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007616")]
		[Address(RVA = "0xBF98", Offset = "0xBF98", VA = "0xBF98")]
		public string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace, char Separator = ',')
		{
			return null;
		}

		// Token: 0x06007617 RID: 30231 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007617")]
		[Address(RVA = "0xBF99", Offset = "0xBF99", VA = "0xBF99")]
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		// Token: 0x06007618 RID: 30232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007618")]
		[Address(RVA = "0x3605", Offset = "0x3605", VA = "0x3605")]
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		// Token: 0x06007619 RID: 30233 RVA: 0x00015570 File Offset: 0x00013770
		[Token(Token = "0x6007619")]
		[Address(RVA = "0xBF9A", Offset = "0xBF9A", VA = "0xBF9A")]
		private bool ArrayContains(string MainText, params string[] texts)
		{
			return default(bool);
		}

		// Token: 0x0600761A RID: 30234 RVA: 0x00015588 File Offset: 0x00013788
		[Token(Token = "0x600761A")]
		[Address(RVA = "0xBF9B", Offset = "0xBF9B", VA = "0xBF9B")]
		public static eTermType GetTermType(string type)
		{
			return eTermType.Text;
		}

		// Token: 0x0600761B RID: 30235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600761B")]
		[Address(RVA = "0xBF9C", Offset = "0xBF9C", VA = "0xBF9C")]
		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
		}

		// Token: 0x0600761C RID: 30236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600761C")]
		[Address(RVA = "0xBF9D", Offset = "0xBF9D", VA = "0xBF9D")]
		public static void FreeUnusedLanguages()
		{
		}

		// Token: 0x0600761D RID: 30237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600761D")]
		[Address(RVA = "0xBF9E", Offset = "0xBF9E", VA = "0xBF9E")]
		public void Import_Google_FromCache()
		{
		}

		// Token: 0x0600761E RID: 30238 RVA: 0x000155A0 File Offset: 0x000137A0
		[Token(Token = "0x600761E")]
		[Address(RVA = "0xBF9F", Offset = "0xBF9F", VA = "0xBF9F")]
		private bool IsNewerVersion(string currentVersion, string newVersion)
		{
			return default(bool);
		}

		// Token: 0x0600761F RID: 30239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600761F")]
		[Address(RVA = "0xBFA0", Offset = "0xBFA0", VA = "0xBFA0")]
		public void Import_Google(bool ForceUpdate, bool justCheck)
		{
		}

		// Token: 0x06007620 RID: 30240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007620")]
		[Address(RVA = "0x35FE", Offset = "0x35FE", VA = "0x35FE")]
		private string GetSourcePlayerPrefName()
		{
			return null;
		}

		// Token: 0x06007621 RID: 30241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007621")]
		[Address(RVA = "0xBFA1", Offset = "0xBFA1", VA = "0xBFA1")]
		private IEnumerator Import_Google_Coroutine(bool forceUpdate, bool JustCheck)
		{
			return null;
		}

		// Token: 0x06007622 RID: 30242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007622")]
		[Address(RVA = "0xBFA2", Offset = "0xBFA2", VA = "0xBFA2")]
		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		// Token: 0x06007623 RID: 30243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007623")]
		[Address(RVA = "0xBFA3", Offset = "0xBFA3", VA = "0xBFA3")]
		public void ApplyDownloadedDataFromGoogle()
		{
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007624")]
		[Address(RVA = "0xBFA4", Offset = "0xBFA4", VA = "0xBFA4")]
		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
			return null;
		}

		// Token: 0x06007625 RID: 30245 RVA: 0x000155B8 File Offset: 0x000137B8
		[Token(Token = "0x6007625")]
		[Address(RVA = "0xBFA5", Offset = "0xBFA5", VA = "0xBFA5")]
		public bool HasGoogleSpreadsheet()
		{
			return default(bool);
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007626")]
		[Address(RVA = "0xBFA6", Offset = "0xBFA6", VA = "0xBFA6")]
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			return null;
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x000155D0 File Offset: 0x000137D0
		[Token(Token = "0x6007627")]
		[Address(RVA = "0xBFA7", Offset = "0xBFA7", VA = "0xBFA7")]
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
			return 0;
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007628")]
		[Address(RVA = "0xBFA8", Offset = "0xBFA8", VA = "0xBFA8")]
		public LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true)
		{
			return null;
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x000155E8 File Offset: 0x000137E8
		[Token(Token = "0x6007629")]
		[Address(RVA = "0xBFA9", Offset = "0xBFA9", VA = "0xBFA9")]
		public bool IsCurrentLanguage(int languageIndex)
		{
			return default(bool);
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x00015600 File Offset: 0x00013800
		[Token(Token = "0x600762A")]
		[Address(RVA = "0xBFAA", Offset = "0xBFAA", VA = "0xBFAA")]
		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
			return 0;
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x00015618 File Offset: 0x00013818
		[Token(Token = "0x600762B")]
		[Address(RVA = "0xBFAB", Offset = "0xBFAB", VA = "0xBFAB")]
		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			return 0;
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x00015630 File Offset: 0x00013830
		[Token(Token = "0x600762C")]
		[Address(RVA = "0xBFAC", Offset = "0xBFAC", VA = "0xBFAC")]
		public static bool AreTheSameLanguage(string Language1, string Language2)
		{
			return default(bool);
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600762D")]
		[Address(RVA = "0xBFAD", Offset = "0xBFAD", VA = "0xBFAD")]
		public static string GetLanguageWithoutRegion(string Language)
		{
			return null;
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600762E")]
		[Address(RVA = "0xBFAE", Offset = "0xBFAE", VA = "0xBFAE")]
		public void AddLanguage(string LanguageName)
		{
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600762F")]
		[Address(RVA = "0xBFAF", Offset = "0xBFAF", VA = "0xBFAF")]
		public void AddLanguage(string LanguageName, string LanguageCode)
		{
		}

		// Token: 0x06007630 RID: 30256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007630")]
		[Address(RVA = "0xBFB0", Offset = "0xBFB0", VA = "0xBFB0")]
		public void RemoveLanguage(string LanguageName)
		{
		}

		// Token: 0x06007631 RID: 30257 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007631")]
		[Address(RVA = "0xBFB1", Offset = "0xBFB1", VA = "0xBFB1")]
		public List<string> GetLanguages(bool skipDisabled = true)
		{
			return null;
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007632")]
		[Address(RVA = "0xBFB2", Offset = "0xBFB2", VA = "0xBFB2")]
		public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
			return null;
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x00015648 File Offset: 0x00013848
		[Token(Token = "0x6007633")]
		[Address(RVA = "0xBFB3", Offset = "0xBFB3", VA = "0xBFB3")]
		public bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007634")]
		[Address(RVA = "0xBFB4", Offset = "0xBFB4", VA = "0xBFB4")]
		public void EnableLanguage(string Language, bool bEnabled)
		{
		}

		// Token: 0x06007635 RID: 30261 RVA: 0x00015660 File Offset: 0x00013860
		[Token(Token = "0x6007635")]
		[Address(RVA = "0xBFB5", Offset = "0xBFB5", VA = "0xBFB5")]
		public bool AllowUnloadingLanguages()
		{
			return default(bool);
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007636")]
		[Address(RVA = "0xBFB6", Offset = "0xBFB6", VA = "0xBFB6")]
		private string GetSavedLanguageFileName(int languageIndex)
		{
			return null;
		}

		// Token: 0x06007637 RID: 30263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007637")]
		[Address(RVA = "0xBFB7", Offset = "0xBFB7", VA = "0xBFB7")]
		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
		}

		// Token: 0x06007638 RID: 30264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007638")]
		[Address(RVA = "0xBFB8", Offset = "0xBFB8", VA = "0xBFB8")]
		public void LoadAllLanguages(bool forceLoad = false)
		{
		}

		// Token: 0x06007639 RID: 30265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007639")]
		[Address(RVA = "0xBFB9", Offset = "0xBFB9", VA = "0xBFB9")]
		public void UnloadLanguage(int languageIndex)
		{
		}

		// Token: 0x0600763A RID: 30266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600763A")]
		[Address(RVA = "0x3607", Offset = "0x3607", VA = "0x3607")]
		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
		}

		// Token: 0x0600763B RID: 30267 RVA: 0x00015678 File Offset: 0x00013878
		[Token(Token = "0x600763B")]
		[Address(RVA = "0xBFBA", Offset = "0xBFBA", VA = "0xBFBA")]
		public bool HasUnloadedLanguages()
		{
			return default(bool);
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600763C")]
		[Address(RVA = "0xBFBB", Offset = "0xBFBB", VA = "0xBFBB")]
		public List<string> GetCategories(bool OnlyMainCategory = false, [Optional] List<string> Categories)
		{
			return null;
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600763D")]
		[Address(RVA = "0xBFBC", Offset = "0xBFBC", VA = "0xBFBC")]
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600763E")]
		[Address(RVA = "0x35FB", Offset = "0x35FB", VA = "0x35FB")]
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600763F")]
		[Address(RVA = "0xBFBD", Offset = "0xBFBD", VA = "0xBFBD")]
		public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = false)
		{
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007640")]
		[Address(RVA = "0xBFBE", Offset = "0xBFBE", VA = "0xBFBE")]
		public void UpdateDictionary(bool force = false)
		{
		}

		// Token: 0x06007641 RID: 30273 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007641")]
		[Address(RVA = "0xBFBF", Offset = "0xBFBF", VA = "0xBFBF")]
		public string GetTranslation(string term, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x00015690 File Offset: 0x00013890
		[Token(Token = "0x6007642")]
		[Address(RVA = "0xBFC0", Offset = "0xBFC0", VA = "0xBFC0")]
		public bool TryGetTranslation(string term, out string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return default(bool);
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x000156A8 File Offset: 0x000138A8
		[Token(Token = "0x6007643")]
		[Address(RVA = "0xBFC1", Offset = "0xBFC1", VA = "0xBFC1")]
		private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
		{
			return default(bool);
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007644")]
		[Address(RVA = "0x361D", Offset = "0x361D", VA = "0x361D")]
		public TermData AddTerm(string term)
		{
			return null;
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007645")]
		[Address(RVA = "0x361C", Offset = "0x361C", VA = "0x361C")]
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x000156C0 File Offset: 0x000138C0
		[Token(Token = "0x6007646")]
		[Address(RVA = "0xBFC2", Offset = "0xBFC2", VA = "0xBFC2")]
		public bool ContainsTerm(string term)
		{
			return default(bool);
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007647")]
		[Address(RVA = "0xBFC3", Offset = "0xBFC3", VA = "0xBFC3")]
		public List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		// Token: 0x06007648 RID: 30280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007648")]
		[Address(RVA = "0xBFC4", Offset = "0xBFC4", VA = "0xBFC4")]
		public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true)
		{
			return null;
		}

		// Token: 0x06007649 RID: 30281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007649")]
		[Address(RVA = "0xBFC5", Offset = "0xBFC5", VA = "0xBFC5")]
		public void RemoveTerm(string term)
		{
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600764A")]
		[Address(RVA = "0xBFC6", Offset = "0xBFC6", VA = "0xBFC6")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600764B")]
		[Address(RVA = "0xBFC7", Offset = "0xBFC7", VA = "0xBFC7")]
		public LanguageSourceData()
		{
		}

		// Token: 0x04003DB7 RID: 15799
		[Token(Token = "0x4003DB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[NonSerialized]
		public ILanguageSource owner;

		// Token: 0x04003DB8 RID: 15800
		[Token(Token = "0x4003DB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool UserAgreesToHaveItOnTheScene;

		// Token: 0x04003DB9 RID: 15801
		[Token(Token = "0x4003DB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		// Token: 0x04003DBA RID: 15802
		[Token(Token = "0x4003DBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		public bool GoogleLiveSyncIsUptoDate;

		// Token: 0x04003DBB RID: 15803
		[Token(Token = "0x4003DBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
		[NonSerialized]
		public bool mIsGlobalSource;

		// Token: 0x04003DBC RID: 15804
		[Token(Token = "0x4003DBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<TermData> mTerms;

		// Token: 0x04003DBD RID: 15805
		[Token(Token = "0x4003DBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool CaseInsensitiveTerms;

		// Token: 0x04003DBE RID: 15806
		[Token(Token = "0x4003DBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public Dictionary<string, TermData> mDictionary;

		// Token: 0x04003DBF RID: 15807
		[Token(Token = "0x4003DBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		// Token: 0x04003DC0 RID: 15808
		[Token(Token = "0x4003DC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mTerm_AppName;

		// Token: 0x04003DC1 RID: 15809
		[Token(Token = "0x4003DC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public List<LanguageData> mLanguages;

		// Token: 0x04003DC2 RID: 15810
		[Token(Token = "0x4003DC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IgnoreDeviceLanguage;

		// Token: 0x04003DC3 RID: 15811
		[Token(Token = "0x4003DC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		// Token: 0x04003DC4 RID: 15812
		[Token(Token = "0x4003DC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Google_WebServiceURL;

		// Token: 0x04003DC5 RID: 15813
		[Token(Token = "0x4003DC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public string Google_SpreadsheetKey;

		// Token: 0x04003DC6 RID: 15814
		[Token(Token = "0x4003DC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Google_SpreadsheetName;

		// Token: 0x04003DC7 RID: 15815
		[Token(Token = "0x4003DC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public string Google_LastUpdatedVersion;

		// Token: 0x04003DC8 RID: 15816
		[Token(Token = "0x4003DC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		// Token: 0x04003DC9 RID: 15817
		[Token(Token = "0x4003DC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

		// Token: 0x04003DCA RID: 15818
		[Token(Token = "0x4003DCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LanguageSourceData.eGoogleUpdateSynchronization GoogleUpdateSynchronization;

		// Token: 0x04003DCB RID: 15819
		[Token(Token = "0x4003DCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float GoogleUpdateDelay;

		// Token: 0x04003DCD RID: 15821
		[Token(Token = "0x4003DCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public List<UnityEngine.Object> Assets;

		// Token: 0x04003DCE RID: 15822
		[Token(Token = "0x4003DCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		// Token: 0x04003DCF RID: 15823
		[Token(Token = "0x4003DCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private string mDelayedGoogleData;

		// Token: 0x04003DD0 RID: 15824
		[Token(Token = "0x4003DD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EmptyCategory;

		// Token: 0x04003DD1 RID: 15825
		[Token(Token = "0x4003DD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static char[] CategorySeparators;

		// Token: 0x0200136F RID: 4975
		[Token(Token = "0x200136F")]
		public enum MissingTranslationAction
		{
			// Token: 0x04003DD3 RID: 15827
			[Token(Token = "0x4003DD3")]
			Empty,
			// Token: 0x04003DD4 RID: 15828
			[Token(Token = "0x4003DD4")]
			Fallback,
			// Token: 0x04003DD5 RID: 15829
			[Token(Token = "0x4003DD5")]
			ShowWarning,
			// Token: 0x04003DD6 RID: 15830
			[Token(Token = "0x4003DD6")]
			ShowTerm
		}

		// Token: 0x02001370 RID: 4976
		[Token(Token = "0x2001370")]
		public enum eAllowUnloadLanguages
		{
			// Token: 0x04003DD8 RID: 15832
			[Token(Token = "0x4003DD8")]
			Never,
			// Token: 0x04003DD9 RID: 15833
			[Token(Token = "0x4003DD9")]
			OnlyInDevice,
			// Token: 0x04003DDA RID: 15834
			[Token(Token = "0x4003DDA")]
			EditorAndDevice
		}

		// Token: 0x02001371 RID: 4977
		[Token(Token = "0x2001371")]
		public enum eGoogleUpdateFrequency
		{
			// Token: 0x04003DDC RID: 15836
			[Token(Token = "0x4003DDC")]
			Always,
			// Token: 0x04003DDD RID: 15837
			[Token(Token = "0x4003DDD")]
			Never,
			// Token: 0x04003DDE RID: 15838
			[Token(Token = "0x4003DDE")]
			Daily,
			// Token: 0x04003DDF RID: 15839
			[Token(Token = "0x4003DDF")]
			Weekly,
			// Token: 0x04003DE0 RID: 15840
			[Token(Token = "0x4003DE0")]
			Monthly,
			// Token: 0x04003DE1 RID: 15841
			[Token(Token = "0x4003DE1")]
			OnlyOnce,
			// Token: 0x04003DE2 RID: 15842
			[Token(Token = "0x4003DE2")]
			EveryOtherDay
		}

		// Token: 0x02001372 RID: 4978
		[Token(Token = "0x2001372")]
		public enum eGoogleUpdateSynchronization
		{
			// Token: 0x04003DE4 RID: 15844
			[Token(Token = "0x4003DE4")]
			Manual,
			// Token: 0x04003DE5 RID: 15845
			[Token(Token = "0x4003DE5")]
			OnSceneLoaded,
			// Token: 0x04003DE6 RID: 15846
			[Token(Token = "0x4003DE6")]
			AsSoonAsDownloaded
		}
	}
}
