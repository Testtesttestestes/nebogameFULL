using System;
using Gameplay.School.Model;
using Il2CppDummyDll;
using UI.Elements.RightPanel.TitledList;

namespace Gameplay.School.View
{
	// Token: 0x02000642 RID: 1602
	[Token(Token = "0x2000642")]
	public class SpellCurrentDescriptionTitledListElementArgs : BaseTitledListElementArgs
	{
		// Token: 0x060026DA RID: 9946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026DA")]
		[Address(RVA = "0x780F", Offset = "0x780F", VA = "0x780F")]
		public SpellCurrentDescriptionTitledListElementArgs(SchoolSpellData spellData)
		{
		}

		// Token: 0x04001548 RID: 5448
		[Token(Token = "0x4001548")]
		[FieldOffset(Offset = "0x8")]
		public SchoolSpellData SpellData;
	}
}
