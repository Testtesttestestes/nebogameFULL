using System;
using Gameplay.School.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.RightPanel.TitledList;
using UI.Price;
using UnityEngine;

namespace Gameplay.School.View
{
	// Token: 0x02000641 RID: 1601
	[Token(Token = "0x2000641")]
	public class SpellCurrentDescriptionTitledListElement : BaseTitledListElement<SpellCurrentDescriptionTitledListElementArgs>
	{
		// Token: 0x060026D7 RID: 9943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D7")]
		[Address(RVA = "0x780C", Offset = "0x780C", VA = "0x780C", Slot = "6")]
		protected override void OnInit(SpellCurrentDescriptionTitledListElementArgs args)
		{
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D8")]
		[Address(RVA = "0x780D", Offset = "0x780D", VA = "0x780D")]
		public void UpdateSpell(SchoolSpellData spellData)
		{
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026D9")]
		[Address(RVA = "0x780E", Offset = "0x780E", VA = "0x780E")]
		public SpellCurrentDescriptionTitledListElement()
		{
		}

		// Token: 0x04001542 RID: 5442
		[Token(Token = "0x4001542")]
		private const string SPELL_UPGRADE_TO_LEVEL = "SCHOOL/SPELL/UPGRADE_TO_LEVEL";

		// Token: 0x04001543 RID: 5443
		[Token(Token = "0x4001543")]
		private const string LEVEL_TAG = "value";

		// Token: 0x04001544 RID: 5444
		[Token(Token = "0x4001544")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001545 RID: 5445
		[Token(Token = "0x4001545")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001546 RID: 5446
		[Token(Token = "0x4001546")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _price;

		// Token: 0x04001547 RID: 5447
		[Token(Token = "0x4001547")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private PriceItemRenderer _manaPrice;
	}
}
