using System;
using Core.Data;
using Gameplay.School.Model;
using Il2CppDummyDll;
using UI.Elements.RightPanel.TitledList;

namespace Gameplay.School.View
{
	// Token: 0x02000645 RID: 1605
	[Token(Token = "0x2000645")]
	public class SpellUpgradeRequirementsTitledListElementArgs : BaseTitledListElementArgs
	{
		// Token: 0x060026E2 RID: 9954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E2")]
		[Address(RVA = "0x7817", Offset = "0x7817", VA = "0x7817")]
		public SpellUpgradeRequirementsTitledListElementArgs(SchoolSpellData spellData, UserData player, UserData owner)
		{
		}

		// Token: 0x0400154F RID: 5455
		[Token(Token = "0x400154F")]
		[FieldOffset(Offset = "0x8")]
		public SchoolSpellData SpellData;

		// Token: 0x04001550 RID: 5456
		[Token(Token = "0x4001550")]
		[FieldOffset(Offset = "0xC")]
		public UserData Player;

		// Token: 0x04001551 RID: 5457
		[Token(Token = "0x4001551")]
		[FieldOffset(Offset = "0x10")]
		public UserData Owner;
	}
}
