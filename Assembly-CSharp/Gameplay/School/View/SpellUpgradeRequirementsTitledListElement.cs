using System;
using Core.Data;
using Gameplay.School.Model;
using Il2CppDummyDll;
using UI.Elements.RightPanel.TitledList;
using UI.Requirements;
using UnityEngine;

namespace Gameplay.School.View
{
	// Token: 0x02000644 RID: 1604
	[Token(Token = "0x2000644")]
	public class SpellUpgradeRequirementsTitledListElement : BaseTitledListElement<SpellUpgradeRequirementsTitledListElementArgs>
	{
		// Token: 0x060026DF RID: 9951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026DF")]
		[Address(RVA = "0x7814", Offset = "0x7814", VA = "0x7814", Slot = "6")]
		protected override void OnInit(SpellUpgradeRequirementsTitledListElementArgs args)
		{
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E0")]
		[Address(RVA = "0x7815", Offset = "0x7815", VA = "0x7815")]
		public void UpdateSpell(SchoolSpellData SpellData, UserData Player, UserData Owner)
		{
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E1")]
		[Address(RVA = "0x7816", Offset = "0x7816", VA = "0x7816")]
		public SpellUpgradeRequirementsTitledListElement()
		{
		}

		// Token: 0x0400154E RID: 5454
		[Token(Token = "0x400154E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RequirementsView _requirements;
	}
}
