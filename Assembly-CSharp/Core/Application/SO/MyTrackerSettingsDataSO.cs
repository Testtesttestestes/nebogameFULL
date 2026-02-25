using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Application.SO
{
	// Token: 0x02001247 RID: 4679
	[Token(Token = "0x2001247")]
	[CreateAssetMenu(fileName = "MyTrackerSettings", menuName = "Heavens/Platform Env Settings/MyTracker")]
	public class MyTrackerSettingsDataSO : ScriptableObject
	{
		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06006EE1 RID: 28385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016A1")]
		public MyTrackerSettingsDataSO.MyTrackerSettings MyTracker
		{
			[Token(Token = "0x6006EE1")]
			[Address(RVA = "0xB95F", Offset = "0xB95F", VA = "0xB95F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006EE2 RID: 28386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EE2")]
		[Address(RVA = "0xB960", Offset = "0xB960", VA = "0xB960")]
		public MyTrackerSettingsDataSO()
		{
		}

		// Token: 0x040039F2 RID: 14834
		[Token(Token = "0x40039F2")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private MyTrackerSettingsDataSO.MyTrackerSettings _myTracker;

		// Token: 0x02001248 RID: 4680
		[Token(Token = "0x2001248")]
		[Serializable]
		public class MyTrackerSettings
		{
			// Token: 0x170016A2 RID: 5794
			// (get) Token: 0x06006EE3 RID: 28387 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170016A2")]
			public string SDKKey
			{
				[Token(Token = "0x6006EE3")]
				[Address(RVA = "0xB961", Offset = "0xB961", VA = "0xB961")]
				get
				{
					return null;
				}
			}

			// Token: 0x170016A3 RID: 5795
			// (get) Token: 0x06006EE4 RID: 28388 RVA: 0x00014400 File Offset: 0x00012600
			[Token(Token = "0x170016A3")]
			public bool EnableDebug
			{
				[Token(Token = "0x6006EE4")]
				[Address(RVA = "0xB962", Offset = "0xB962", VA = "0xB962")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06006EE5 RID: 28389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006EE5")]
			[Address(RVA = "0xB963", Offset = "0xB963", VA = "0xB963")]
			public MyTrackerSettings()
			{
			}

			// Token: 0x040039F3 RID: 14835
			[Token(Token = "0x40039F3")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private string _sdkKey;

			// Token: 0x040039F4 RID: 14836
			[Token(Token = "0x40039F4")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private bool _enableDebug;
		}
	}
}
