using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace I2.Loc
{
	// Token: 0x02001377 RID: 4983
	[Token(Token = "0x2001377")]
	[AddComponentMenu("I2/Localization/I2 Localize")]
	public class Localize : MonoBehaviour
	{
		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x06007666 RID: 30310 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007667 RID: 30311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017A9")]
		public string Term
		{
			[Token(Token = "0x6007666")]
			[Address(RVA = "0xBFE1", Offset = "0xBFE1", VA = "0xBFE1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007667")]
			[Address(RVA = "0xBFE2", Offset = "0xBFE2", VA = "0xBFE2")]
			set
			{
			}
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06007668 RID: 30312 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06007669 RID: 30313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017AA")]
		public string SecondaryTerm
		{
			[Token(Token = "0x6007668")]
			[Address(RVA = "0xBFE3", Offset = "0xBFE3", VA = "0xBFE3")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007669")]
			[Address(RVA = "0xBFE4", Offset = "0xBFE4", VA = "0xBFE4")]
			set
			{
			}
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600766A")]
		[Address(RVA = "0xBFE5", Offset = "0xBFE5", VA = "0xBFE5")]
		private void Awake()
		{
		}

		// Token: 0x0600766B RID: 30315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600766B")]
		[Address(RVA = "0xBFE6", Offset = "0xBFE6", VA = "0xBFE6")]
		private void OnEnable()
		{
		}

		// Token: 0x0600766C RID: 30316 RVA: 0x00015750 File Offset: 0x00013950
		[Token(Token = "0x600766C")]
		[Address(RVA = "0xBFE7", Offset = "0xBFE7", VA = "0xBFE7")]
		public bool HasCallback()
		{
			return default(bool);
		}

		// Token: 0x0600766D RID: 30317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600766D")]
		[Address(RVA = "0xBFE8", Offset = "0xBFE8", VA = "0xBFE8")]
		public void OnLocalize(bool Force = false)
		{
		}

		// Token: 0x0600766E RID: 30318 RVA: 0x00015768 File Offset: 0x00013968
		[Token(Token = "0x600766E")]
		[Address(RVA = "0xBFE9", Offset = "0xBFE9", VA = "0xBFE9")]
		public bool FindTarget()
		{
			return default(bool);
		}

		// Token: 0x0600766F RID: 30319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600766F")]
		[Address(RVA = "0xBFEA", Offset = "0xBFEA", VA = "0xBFEA")]
		public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
		{
		}

		// Token: 0x06007670 RID: 30320 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007670")]
		[Address(RVA = "0xBFEB", Offset = "0xBFEB", VA = "0xBFEB")]
		public string GetMainTargetsText()
		{
			return null;
		}

		// Token: 0x06007671 RID: 30321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007671")]
		[Address(RVA = "0xBFEC", Offset = "0xBFEC", VA = "0xBFEC")]
		public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
		{
		}

		// Token: 0x06007672 RID: 30322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007672")]
		[Address(RVA = "0xBFED", Offset = "0xBFED", VA = "0xBFED")]
		public void SetTerm(string primary)
		{
		}

		// Token: 0x06007673 RID: 30323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007673")]
		[Address(RVA = "0xBFEE", Offset = "0xBFEE", VA = "0xBFEE")]
		public void SetTerm(string primary, string secondary)
		{
		}

		// Token: 0x06007674 RID: 30324 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007674")]
		internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06007675 RID: 30325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007675")]
		[Address(RVA = "0xBFEF", Offset = "0xBFEF", VA = "0xBFEF")]
		public void UpdateAssetDictionary()
		{
		}

		// Token: 0x06007676 RID: 30326 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007676")]
		internal T GetObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06007677 RID: 30327 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007677")]
		private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x06007678 RID: 30328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007678")]
		[Address(RVA = "0xBFF0", Offset = "0xBFF0", VA = "0xBFF0")]
		private void DeserializeTranslation(string translation, out string value, out string secondary)
		{
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007679")]
		public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600767A RID: 30330 RVA: 0x00015780 File Offset: 0x00013980
		[Token(Token = "0x600767A")]
		[Address(RVA = "0xBFF1", Offset = "0xBFF1", VA = "0xBFF1")]
		public bool HasTranslatedObject(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		// Token: 0x0600767B RID: 30331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600767B")]
		[Address(RVA = "0xBFF2", Offset = "0xBFF2", VA = "0xBFF2")]
		public void AddTranslatedObject(UnityEngine.Object Obj)
		{
		}

		// Token: 0x0600767C RID: 30332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600767C")]
		[Address(RVA = "0xBFF3", Offset = "0xBFF3", VA = "0xBFF3")]
		public void SetGlobalLanguage(string Language)
		{
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600767D")]
		[Address(RVA = "0xBFF4", Offset = "0xBFF4", VA = "0xBFF4")]
		public Localize()
		{
		}

		// Token: 0x04003DF9 RID: 15865
		[Token(Token = "0x4003DF9")]
		[FieldOffset(Offset = "0x10")]
		public string mTerm;

		// Token: 0x04003DFA RID: 15866
		[Token(Token = "0x4003DFA")]
		[FieldOffset(Offset = "0x14")]
		public string mTermSecondary;

		// Token: 0x04003DFB RID: 15867
		[Token(Token = "0x4003DFB")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public string FinalTerm;

		// Token: 0x04003DFC RID: 15868
		[Token(Token = "0x4003DFC")]
		[FieldOffset(Offset = "0x1C")]
		[NonSerialized]
		public string FinalSecondaryTerm;

		// Token: 0x04003DFD RID: 15869
		[Token(Token = "0x4003DFD")]
		[FieldOffset(Offset = "0x20")]
		public Localize.TermModification PrimaryTermModifier;

		// Token: 0x04003DFE RID: 15870
		[Token(Token = "0x4003DFE")]
		[FieldOffset(Offset = "0x24")]
		public Localize.TermModification SecondaryTermModifier;

		// Token: 0x04003DFF RID: 15871
		[Token(Token = "0x4003DFF")]
		[FieldOffset(Offset = "0x28")]
		public string TermPrefix;

		// Token: 0x04003E00 RID: 15872
		[Token(Token = "0x4003E00")]
		[FieldOffset(Offset = "0x2C")]
		public string TermSuffix;

		// Token: 0x04003E01 RID: 15873
		[Token(Token = "0x4003E01")]
		[FieldOffset(Offset = "0x30")]
		public bool LocalizeOnAwake;

		// Token: 0x04003E02 RID: 15874
		[Token(Token = "0x4003E02")]
		[FieldOffset(Offset = "0x34")]
		private string LastLocalizedLanguage;

		// Token: 0x04003E03 RID: 15875
		[Token(Token = "0x4003E03")]
		[FieldOffset(Offset = "0x38")]
		public bool IgnoreRTL;

		// Token: 0x04003E04 RID: 15876
		[Token(Token = "0x4003E04")]
		[FieldOffset(Offset = "0x3C")]
		public int MaxCharactersInRTL;

		// Token: 0x04003E05 RID: 15877
		[Token(Token = "0x4003E05")]
		[FieldOffset(Offset = "0x40")]
		public bool IgnoreNumbersInRTL;

		// Token: 0x04003E06 RID: 15878
		[Token(Token = "0x4003E06")]
		[FieldOffset(Offset = "0x41")]
		public bool CorrectAlignmentForRTL;

		// Token: 0x04003E07 RID: 15879
		[Token(Token = "0x4003E07")]
		[FieldOffset(Offset = "0x42")]
		public bool AddSpacesToJoinedLanguages;

		// Token: 0x04003E08 RID: 15880
		[Token(Token = "0x4003E08")]
		[FieldOffset(Offset = "0x43")]
		public bool AllowLocalizedParameters;

		// Token: 0x04003E09 RID: 15881
		[Token(Token = "0x4003E09")]
		[FieldOffset(Offset = "0x44")]
		public bool AllowParameters;

		// Token: 0x04003E0A RID: 15882
		[Token(Token = "0x4003E0A")]
		[FieldOffset(Offset = "0x48")]
		public List<UnityEngine.Object> TranslatedObjects;

		// Token: 0x04003E0B RID: 15883
		[Token(Token = "0x4003E0B")]
		[FieldOffset(Offset = "0x4C")]
		[NonSerialized]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		// Token: 0x04003E0C RID: 15884
		[Token(Token = "0x4003E0C")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent LocalizeEvent;

		// Token: 0x04003E0D RID: 15885
		[Token(Token = "0x4003E0D")]
		[FieldOffset(Offset = "0x0")]
		public static string MainTranslation;

		// Token: 0x04003E0E RID: 15886
		[Token(Token = "0x4003E0E")]
		[FieldOffset(Offset = "0x4")]
		public static string SecondaryTranslation;

		// Token: 0x04003E0F RID: 15887
		[Token(Token = "0x4003E0F")]
		[FieldOffset(Offset = "0x8")]
		public static string CallBackTerm;

		// Token: 0x04003E10 RID: 15888
		[Token(Token = "0x4003E10")]
		[FieldOffset(Offset = "0xC")]
		public static string CallBackSecondaryTerm;

		// Token: 0x04003E11 RID: 15889
		[Token(Token = "0x4003E11")]
		[FieldOffset(Offset = "0x10")]
		public static Localize CurrentLocalizeComponent;

		// Token: 0x04003E12 RID: 15890
		[Token(Token = "0x4003E12")]
		[FieldOffset(Offset = "0x54")]
		public bool AlwaysForceLocalize;

		// Token: 0x04003E13 RID: 15891
		[Token(Token = "0x4003E13")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public EventCallback LocalizeCallBack;

		// Token: 0x04003E14 RID: 15892
		[Token(Token = "0x4003E14")]
		[FieldOffset(Offset = "0x5C")]
		public bool mGUI_ShowReferences;

		// Token: 0x04003E15 RID: 15893
		[Token(Token = "0x4003E15")]
		[FieldOffset(Offset = "0x5D")]
		public bool mGUI_ShowTems;

		// Token: 0x04003E16 RID: 15894
		[Token(Token = "0x4003E16")]
		[FieldOffset(Offset = "0x5E")]
		public bool mGUI_ShowCallback;

		// Token: 0x04003E17 RID: 15895
		[Token(Token = "0x4003E17")]
		[FieldOffset(Offset = "0x60")]
		public ILocalizeTarget mLocalizeTarget;

		// Token: 0x04003E18 RID: 15896
		[Token(Token = "0x4003E18")]
		[FieldOffset(Offset = "0x64")]
		public string mLocalizeTargetName;

		// Token: 0x02001378 RID: 4984
		[Token(Token = "0x2001378")]
		public enum TermModification
		{
			// Token: 0x04003E1A RID: 15898
			[Token(Token = "0x4003E1A")]
			DontModify,
			// Token: 0x04003E1B RID: 15899
			[Token(Token = "0x4003E1B")]
			ToUpper,
			// Token: 0x04003E1C RID: 15900
			[Token(Token = "0x4003E1C")]
			ToLower,
			// Token: 0x04003E1D RID: 15901
			[Token(Token = "0x4003E1D")]
			ToUpperFirst,
			// Token: 0x04003E1E RID: 15902
			[Token(Token = "0x4003E1E")]
			ToTitle
		}
	}
}
