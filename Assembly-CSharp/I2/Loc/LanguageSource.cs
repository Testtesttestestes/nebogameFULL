using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200136A RID: 4970
	[Token(Token = "0x200136A")]
	[AddComponentMenu("I2/Localization/Source")]
	[ExecuteInEditMode]
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
	{
		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x060075EB RID: 30187 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060075EC RID: 30188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017A3")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60075EB")]
			[Address(RVA = "0xBF74", Offset = "0xBF74", VA = "0xBF74", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60075EC")]
			[Address(RVA = "0xBF75", Offset = "0xBF75", VA = "0xBF75", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x14000306 RID: 774
		// (add) Token: 0x060075ED RID: 30189 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060075EE RID: 30190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000306")]
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60075ED")]
			[Address(RVA = "0xBF76", Offset = "0xBF76", VA = "0xBF76")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60075EE")]
			[Address(RVA = "0xBF77", Offset = "0xBF77", VA = "0xBF77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060075EF RID: 30191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075EF")]
		[Address(RVA = "0xBF78", Offset = "0xBF78", VA = "0xBF78")]
		private void Awake()
		{
		}

		// Token: 0x060075F0 RID: 30192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F0")]
		[Address(RVA = "0xBF79", Offset = "0xBF79", VA = "0xBF79")]
		private void OnDestroy()
		{
		}

		// Token: 0x060075F1 RID: 30193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60075F1")]
		[Address(RVA = "0xBF7A", Offset = "0xBF7A", VA = "0xBF7A")]
		public string GetSourceName()
		{
			return null;
		}

		// Token: 0x060075F2 RID: 30194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F2")]
		[Address(RVA = "0xBF7B", Offset = "0xBF7B", VA = "0xBF7B", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x060075F3 RID: 30195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F3")]
		[Address(RVA = "0xBF7C", Offset = "0xBF7C", VA = "0xBF7C", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075F4")]
		[Address(RVA = "0xBF7D", Offset = "0xBF7D", VA = "0xBF7D")]
		public LanguageSource()
		{
		}

		// Token: 0x04003DA1 RID: 15777
		[Token(Token = "0x4003DA1")]
		[FieldOffset(Offset = "0x10")]
		public LanguageSourceData mSource;

		// Token: 0x04003DA2 RID: 15778
		[Token(Token = "0x4003DA2")]
		[FieldOffset(Offset = "0x14")]
		public int version;

		// Token: 0x04003DA3 RID: 15779
		[Token(Token = "0x4003DA3")]
		[FieldOffset(Offset = "0x18")]
		public bool NeverDestroy;

		// Token: 0x04003DA4 RID: 15780
		[Token(Token = "0x4003DA4")]
		[FieldOffset(Offset = "0x19")]
		public bool UserAgreesToHaveItOnTheScene;

		// Token: 0x04003DA5 RID: 15781
		[Token(Token = "0x4003DA5")]
		[FieldOffset(Offset = "0x1A")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		// Token: 0x04003DA6 RID: 15782
		[Token(Token = "0x4003DA6")]
		[FieldOffset(Offset = "0x1B")]
		public bool GoogleLiveSyncIsUptoDate;

		// Token: 0x04003DA7 RID: 15783
		[Token(Token = "0x4003DA7")]
		[FieldOffset(Offset = "0x1C")]
		public List<UnityEngine.Object> Assets;

		// Token: 0x04003DA8 RID: 15784
		[Token(Token = "0x4003DA8")]
		[FieldOffset(Offset = "0x20")]
		public string Google_WebServiceURL;

		// Token: 0x04003DA9 RID: 15785
		[Token(Token = "0x4003DA9")]
		[FieldOffset(Offset = "0x24")]
		public string Google_SpreadsheetKey;

		// Token: 0x04003DAA RID: 15786
		[Token(Token = "0x4003DAA")]
		[FieldOffset(Offset = "0x28")]
		public string Google_SpreadsheetName;

		// Token: 0x04003DAB RID: 15787
		[Token(Token = "0x4003DAB")]
		[FieldOffset(Offset = "0x2C")]
		public string Google_LastUpdatedVersion;

		// Token: 0x04003DAC RID: 15788
		[Token(Token = "0x4003DAC")]
		[FieldOffset(Offset = "0x30")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		// Token: 0x04003DAD RID: 15789
		[Token(Token = "0x4003DAD")]
		[FieldOffset(Offset = "0x34")]
		public float GoogleUpdateDelay;

		// Token: 0x04003DAF RID: 15791
		[Token(Token = "0x4003DAF")]
		[FieldOffset(Offset = "0x3C")]
		public List<LanguageData> mLanguages;

		// Token: 0x04003DB0 RID: 15792
		[Token(Token = "0x4003DB0")]
		[FieldOffset(Offset = "0x40")]
		public bool IgnoreDeviceLanguage;

		// Token: 0x04003DB1 RID: 15793
		[Token(Token = "0x4003DB1")]
		[FieldOffset(Offset = "0x44")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		// Token: 0x04003DB2 RID: 15794
		[Token(Token = "0x4003DB2")]
		[FieldOffset(Offset = "0x48")]
		public List<TermData> mTerms;

		// Token: 0x04003DB3 RID: 15795
		[Token(Token = "0x4003DB3")]
		[FieldOffset(Offset = "0x4C")]
		public bool CaseInsensitiveTerms;

		// Token: 0x04003DB4 RID: 15796
		[Token(Token = "0x4003DB4")]
		[FieldOffset(Offset = "0x50")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		// Token: 0x04003DB5 RID: 15797
		[Token(Token = "0x4003DB5")]
		[FieldOffset(Offset = "0x54")]
		public string mTerm_AppName;

		// Token: 0x0200136B RID: 4971
		// (Invoke) Token: 0x060075F6 RID: 30198
		[Token(Token = "0x200136B")]
		public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg);
	}
}
