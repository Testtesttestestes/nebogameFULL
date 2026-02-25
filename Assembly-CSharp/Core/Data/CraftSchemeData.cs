using System;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Craft;
using Protocol.Dic;

namespace Core.Data
{
	// Token: 0x020010BA RID: 4282
	[Token(Token = "0x20010BA")]
	public class CraftSchemeData
	{
		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x060063DE RID: 25566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001413")]
		public string TitleToLower
		{
			[Token(Token = "0x60063DE")]
			[Address(RVA = "0xAFDB", Offset = "0xAFDB", VA = "0xAFDB")]
			get
			{
				return null;
			}
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063DF")]
		[Address(RVA = "0xAFDC", Offset = "0xAFDC", VA = "0xAFDC")]
		public CraftSchemeData(IDictProvider provider, UserScheme scheme)
		{
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E0")]
		[Address(RVA = "0xAFDD", Offset = "0xAFDD", VA = "0xAFDD")]
		public CraftSchemeData(UserScheme scheme, CraftSchemeData.CraftSchemeInfo info)
		{
		}

		// Token: 0x0400356B RID: 13675
		[Token(Token = "0x400356B")]
		[FieldOffset(Offset = "0x8")]
		public readonly UserScheme Scheme;

		// Token: 0x0400356C RID: 13676
		[Token(Token = "0x400356C")]
		[FieldOffset(Offset = "0xC")]
		public readonly CraftSchemeData.CraftSchemeInfo Info;

		// Token: 0x0400356D RID: 13677
		[Token(Token = "0x400356D")]
		[FieldOffset(Offset = "0x10")]
		private string _titleToLower;

		// Token: 0x020010BB RID: 4283
		[Token(Token = "0x20010BB")]
		public class CraftSchemeInfo
		{
			// Token: 0x060063E1 RID: 25569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60063E1")]
			[Address(RVA = "0xAFDE", Offset = "0xAFDE", VA = "0xAFDE")]
			public CraftSchemeInfo(IDictProvider provider, uint schemeId)
			{
			}

			// Token: 0x0400356E RID: 13678
			[Token(Token = "0x400356E")]
			[FieldOffset(Offset = "0x8")]
			public readonly CraftSchemeDic Dic;

			// Token: 0x0400356F RID: 13679
			[Token(Token = "0x400356F")]
			[FieldOffset(Offset = "0xC")]
			public readonly RequirementDic Requirements;

			// Token: 0x04003570 RID: 13680
			[Token(Token = "0x4003570")]
			[FieldOffset(Offset = "0x10")]
			public readonly ArtikulData Artikul;

			// Token: 0x04003571 RID: 13681
			[Token(Token = "0x4003571")]
			[FieldOffset(Offset = "0x14")]
			public readonly uint Quantity;
		}
	}
}
