using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Application.SO
{
	// Token: 0x02001242 RID: 4674
	[Token(Token = "0x2001242")]
	[CreateAssetMenu(fileName = "GoogleSettings", menuName = "Heavens/Platform Env Settings/Google")]
	public class GoogleSettingsDataSO : ScriptableObject
	{
		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06006ED0 RID: 28368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001698")]
		public GoogleSettingsDataSO.GoogleSettings Google
		{
			[Token(Token = "0x6006ED0")]
			[Address(RVA = "0xB94E", Offset = "0xB94E", VA = "0xB94E")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ED1")]
		[Address(RVA = "0xB94F", Offset = "0xB94F", VA = "0xB94F")]
		public GoogleSettingsDataSO()
		{
		}

		// Token: 0x040039E7 RID: 14823
		[Token(Token = "0x40039E7")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private GoogleSettingsDataSO.GoogleSettings _google;

		// Token: 0x02001243 RID: 4675
		[Token(Token = "0x2001243")]
		[Serializable]
		public class GoogleSettings
		{
			// Token: 0x17001699 RID: 5785
			// (get) Token: 0x06006ED2 RID: 28370 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001699")]
			public string WebClientId
			{
				[Token(Token = "0x6006ED2")]
				[Address(RVA = "0xB950", Offset = "0xB950", VA = "0xB950")]
				get
				{
					return null;
				}
			}

			// Token: 0x06006ED3 RID: 28371 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006ED3")]
			[Address(RVA = "0xB951", Offset = "0xB951", VA = "0xB951")]
			public GoogleSettings()
			{
			}

			// Token: 0x040039E8 RID: 14824
			[Token(Token = "0x40039E8")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private string _webClientId;
		}
	}
}
