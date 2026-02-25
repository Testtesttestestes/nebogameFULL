using System;
using Gameplay.Discounts.Model;
using Gameplay.School.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using UI.Elements.GenericList;

namespace UI.Elements.Buildings
{
	// Token: 0x0200024B RID: 587
	[Token(Token = "0x200024B")]
	public class SpellItemArgs : GenericListElementArgs
	{
		// Token: 0x06000E56 RID: 3670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x60DF", Offset = "0x60DF", VA = "0x60DF")]
		public SpellItemArgs(uint spellId, uint level, string imageAssetId, bool isLearning)
		{
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x1B92", Offset = "0x1B92", VA = "0x1B92")]
		public SpellItemArgs(SpellDic spellDic, uint level)
		{
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x2144", Offset = "0x2144", VA = "0x2144")]
		public SpellItemArgs(SchoolSpellData spellData)
		{
		}

		// Token: 0x04000724 RID: 1828
		[Token(Token = "0x4000724")]
		[FieldOffset(Offset = "0xC")]
		public uint SpellId;

		// Token: 0x04000725 RID: 1829
		[Token(Token = "0x4000725")]
		[FieldOffset(Offset = "0x10")]
		public string ImageAssetId;

		// Token: 0x04000726 RID: 1830
		[Token(Token = "0x4000726")]
		[FieldOffset(Offset = "0x14")]
		public uint Level;

		// Token: 0x04000727 RID: 1831
		[Token(Token = "0x4000727")]
		[FieldOffset(Offset = "0x18")]
		public bool IsLearning;

		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		[FieldOffset(Offset = "0x1C")]
		[CanBeNull]
		public IDiscountHandler DiscountHandler;
	}
}
