using System;
using System.Collections.Generic;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000946 RID: 2374
	[Token(Token = "0x2000946")]
	public class SpellsDisplay : AbstractCombatSpellsDisplay
	{
		// Token: 0x0600382B RID: 14379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600382B")]
		[Address(RVA = "0x87E2", Offset = "0x87E2", VA = "0x87E2")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x0600382C RID: 14380 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B13")]
		public new GameObject gameObject
		{
			[Token(Token = "0x600382C")]
			[Address(RVA = "0x87E3", Offset = "0x87E3", VA = "0x87E3")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600382D")]
		[Address(RVA = "0x87E4", Offset = "0x87E4", VA = "0x87E4", Slot = "11")]
		public override CombatSpellButton GetNexButton()
		{
			return null;
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600382E")]
		[Address(RVA = "0x87E5", Offset = "0x87E5", VA = "0x87E5", Slot = "12")]
		public override void Reset()
		{
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600382F")]
		[Address(RVA = "0x87E6", Offset = "0x87E6", VA = "0x87E6", Slot = "10")]
		protected override void HandleCountChanged()
		{
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003830")]
		[Address(RVA = "0x87E7", Offset = "0x87E7", VA = "0x87E7")]
		public SpellsDisplay()
		{
		}

		// Token: 0x04001F0E RID: 7950
		[Token(Token = "0x4001F0E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CombatSpellButton _spellPrefab;

		// Token: 0x04001F0F RID: 7951
		[Token(Token = "0x4001F0F")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<CombatSpellButton> _currentButtons;

		// Token: 0x04001F10 RID: 7952
		[Token(Token = "0x4001F10")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FakeCombatSpellData _fakeData;
	}
}
