using System;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	// Token: 0x0200136C RID: 4972
	[Token(Token = "0x200136C")]
	[CreateAssetMenu(fileName = "I2Languages", menuName = "I2 Localization/LanguageSource", order = 1)]
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		// Token: 0x170017A4 RID: 6052
		// (get) Token: 0x060075F9 RID: 30201 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060075FA RID: 30202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170017A4")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60075F9")]
			[Address(RVA = "0xBF82", Offset = "0xBF82", VA = "0xBF82", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60075FA")]
			[Address(RVA = "0xBF83", Offset = "0xBF83", VA = "0xBF83", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x060075FB RID: 30203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60075FB")]
		[Address(RVA = "0xBF84", Offset = "0xBF84", VA = "0xBF84")]
		public LanguageSourceAsset()
		{
		}

		// Token: 0x04003DB6 RID: 15798
		[Token(Token = "0x4003DB6")]
		[FieldOffset(Offset = "0xC")]
		public LanguageSourceData mSource;
	}
}
