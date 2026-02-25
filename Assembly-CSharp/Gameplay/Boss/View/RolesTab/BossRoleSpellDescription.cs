using System;
using Core.Data.Spells;
using Il2CppDummyDll;
using TMPro;
using UI.Price;
using UnityEngine;

namespace Gameplay.Boss.View.RolesTab
{
	// Token: 0x02000B59 RID: 2905
	[Token(Token = "0x2000B59")]
	public class BossRoleSpellDescription : MonoBehaviour
	{
		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x0600464D RID: 17997 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600464E RID: 17998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DDB")]
		public SpellData Spell
		{
			[Token(Token = "0x600464D")]
			[Address(RVA = "0x94E6", Offset = "0x94E6", VA = "0x94E6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600464E")]
			[Address(RVA = "0x94E7", Offset = "0x94E7", VA = "0x94E7")]
			set
			{
			}
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600464F")]
		[Address(RVA = "0x94E8", Offset = "0x94E8", VA = "0x94E8")]
		public BossRoleSpellDescription()
		{
		}

		// Token: 0x04002671 RID: 9841
		[Token(Token = "0x4002671")]
		private const string LEVEL_TAG = "value";

		// Token: 0x04002672 RID: 9842
		[Token(Token = "0x4002672")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002673 RID: 9843
		[Token(Token = "0x4002673")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Price _price;

		// Token: 0x04002674 RID: 9844
		[Token(Token = "0x4002674")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PriceItemRenderer _manaPrice;

		// Token: 0x04002675 RID: 9845
		[Token(Token = "0x4002675")]
		[FieldOffset(Offset = "0x1C")]
		private SpellData _spell;
	}
}
