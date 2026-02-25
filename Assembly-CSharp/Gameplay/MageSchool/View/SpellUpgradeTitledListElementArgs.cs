using System;
using Core.Data.Balance;
using Gameplay.School.Model;
using Il2CppDummyDll;
using UI.Elements.RightPanel.TitledList;

namespace Gameplay.MageSchool.View
{
	// Token: 0x0200063F RID: 1599
	[Token(Token = "0x200063F")]
	public class SpellUpgradeTitledListElementArgs : BaseTitledListElementArgs
	{
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060026D4 RID: 9940 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000746")]
		public IBalanceSource Balance
		{
			[Token(Token = "0x60026D4")]
			[Address(RVA = "0x7809", Offset = "0x7809", VA = "0x7809")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D5")]
		[Address(RVA = "0x780A", Offset = "0x780A", VA = "0x780A")]
		public SpellUpgradeTitledListElementArgs(SchoolSpellData spellData)
		{
		}

		// Token: 0x0400153B RID: 5435
		[Token(Token = "0x400153B")]
		[FieldOffset(Offset = "0x8")]
		public readonly SchoolSpellData SpellData;
	}
}
