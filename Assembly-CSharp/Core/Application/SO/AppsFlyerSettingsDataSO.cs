using System;
using Il2CppDummyDll;
using UnityEngine;
using Utils.Data;

namespace Core.Application.SO
{
	// Token: 0x0200123E RID: 4670
	[Token(Token = "0x200123E")]
	[CreateAssetMenu(fileName = "AppsFlyerSettings", menuName = "Heavens/Platform Env Settings/AppsFlyer")]
	public class AppsFlyerSettingsDataSO : ScriptableObject
	{
		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06006EC6 RID: 28358 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001692")]
		public AppsFlyerSettingsDataSO.AppsFlyerSettings AppsFlyer
		{
			[Token(Token = "0x6006EC6")]
			[Address(RVA = "0xB944", Offset = "0xB944", VA = "0xB944")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006EC7 RID: 28359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EC7")]
		[Address(RVA = "0xB945", Offset = "0xB945", VA = "0xB945")]
		public AppsFlyerSettingsDataSO()
		{
		}

		// Token: 0x040039DF RID: 14815
		[Token(Token = "0x40039DF")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private AppsFlyerSettingsDataSO.AppsFlyerSettings _appsFlyer;

		// Token: 0x0200123F RID: 4671
		[Token(Token = "0x200123F")]
		[Serializable]
		public class AppsFlyerSettings
		{
			// Token: 0x17001693 RID: 5779
			// (get) Token: 0x06006EC8 RID: 28360 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001693")]
			public string AppId
			{
				[Token(Token = "0x6006EC8")]
				[Address(RVA = "0xB946", Offset = "0xB946", VA = "0xB946")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001694 RID: 5780
			// (get) Token: 0x06006EC9 RID: 28361 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001694")]
			public string DevKey
			{
				[Token(Token = "0x6006EC9")]
				[Address(RVA = "0xB947", Offset = "0xB947", VA = "0xB947")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001695 RID: 5781
			// (get) Token: 0x06006ECA RID: 28362 RVA: 0x00014388 File Offset: 0x00012588
			[Token(Token = "0x17001695")]
			public bool EnableDebug
			{
				[Token(Token = "0x6006ECA")]
				[Address(RVA = "0xB948", Offset = "0xB948", VA = "0xB948")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17001696 RID: 5782
			// (get) Token: 0x06006ECB RID: 28363 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001696")]
			public KeyValuePair<string, string>[] ManifestMetaData
			{
				[Token(Token = "0x6006ECB")]
				[Address(RVA = "0xB949", Offset = "0xB949", VA = "0xB949")]
				get
				{
					return null;
				}
			}

			// Token: 0x06006ECC RID: 28364 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006ECC")]
			[Address(RVA = "0xB94A", Offset = "0xB94A", VA = "0xB94A")]
			public AppsFlyerSettings()
			{
			}

			// Token: 0x040039E0 RID: 14816
			[Token(Token = "0x40039E0")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private string _appId;

			// Token: 0x040039E1 RID: 14817
			[Token(Token = "0x40039E1")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private string _devKey;

			// Token: 0x040039E2 RID: 14818
			[Token(Token = "0x40039E2")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _enableDebug;

			// Token: 0x040039E3 RID: 14819
			[Token(Token = "0x40039E3")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private KeyValuePair<string, string>[] _manifestMetaData;
		}
	}
}
