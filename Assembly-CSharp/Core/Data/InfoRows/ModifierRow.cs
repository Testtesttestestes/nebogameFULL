using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Data.InfoRows
{
	// Token: 0x020010E3 RID: 4323
	[Token(Token = "0x20010E3")]
	public class ModifierRow : CommonRow
	{
		// Token: 0x06006523 RID: 25891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006523")]
		[Address(RVA = "0xB0F3", Offset = "0xB0F3", VA = "0xB0F3")]
		private ModifierRow(ModifierData modifier)
		{
		}

		// Token: 0x06006524 RID: 25892 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006524")]
		[Address(RVA = "0xB0F4", Offset = "0xB0F4", VA = "0xB0F4")]
		public static ModifierRow Create(ModifierData mod, SpellDic spellDic, ArtikulData artikul, MedalDic medalDic, ClanLeagueDic clanLeagueDic)
		{
			return null;
		}

		// Token: 0x0400360C RID: 13836
		[Token(Token = "0x400360C")]
		[FieldOffset(Offset = "0x10")]
		public SpellDic SpellDic;

		// Token: 0x0400360D RID: 13837
		[Token(Token = "0x400360D")]
		[FieldOffset(Offset = "0x14")]
		public ArtikulData Artikul;

		// Token: 0x0400360E RID: 13838
		[Token(Token = "0x400360E")]
		[FieldOffset(Offset = "0x18")]
		public MedalDic MedalDic;

		// Token: 0x0400360F RID: 13839
		[Token(Token = "0x400360F")]
		[FieldOffset(Offset = "0x1C")]
		public ClanLeagueDic ClanLeagueDic;

		// Token: 0x04003610 RID: 13840
		[Token(Token = "0x4003610")]
		[FieldOffset(Offset = "0x20")]
		public readonly ModifierData Modifier;
	}
}
