using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.Application.SO
{
	// Token: 0x02001241 RID: 4673
	[Token(Token = "0x2001241")]
	[CreateAssetMenu(fileName = "GdprSettings", menuName = "Heavens/Platform Env Settings/Gdpr")]
	public class GdprSettingDataSO : ScriptableObject
	{
		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06006ECE RID: 28366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001697")]
		public string PlayerPrefsGdprAcceptedName
		{
			[Token(Token = "0x6006ECE")]
			[Address(RVA = "0xB94C", Offset = "0xB94C", VA = "0xB94C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006ECF RID: 28367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ECF")]
		[Address(RVA = "0xB94D", Offset = "0xB94D", VA = "0xB94D")]
		public GdprSettingDataSO()
		{
		}

		// Token: 0x040039E6 RID: 14822
		[Token(Token = "0x40039E6")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private string _playerPrefsGdprAcceptedName;
	}
}
