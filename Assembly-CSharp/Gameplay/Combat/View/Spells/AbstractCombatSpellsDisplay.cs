using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000940 RID: 2368
	[Token(Token = "0x2000940")]
	public abstract class AbstractCombatSpellsDisplay : MonoBehaviour, ICombatSpellDisplay
	{
		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06003808 RID: 14344 RVA: 0x0000B3A0 File Offset: 0x000095A0
		// (set) Token: 0x06003809 RID: 14345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B0F")]
		public virtual int Count
		{
			[Token(Token = "0x6003808")]
			[Address(RVA = "0x87C2", Offset = "0x87C2", VA = "0x87C2", Slot = "8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003809")]
			[Address(RVA = "0x87C3", Offset = "0x87C3", VA = "0x87C3", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x0600380A RID: 14346
		[Token(Token = "0x600380A")]
		protected abstract void HandleCountChanged();

		// Token: 0x0600380B RID: 14347
		[Token(Token = "0x600380B")]
		public abstract CombatSpellButton GetNexButton();

		// Token: 0x0600380C RID: 14348
		[Token(Token = "0x600380C")]
		public abstract void Reset();

		// Token: 0x0600380D RID: 14349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600380D")]
		[Address(RVA = "0x87C4", Offset = "0x87C4", VA = "0x87C4")]
		protected AbstractCombatSpellsDisplay()
		{
		}

		// Token: 0x04001EFE RID: 7934
		[Token(Token = "0x4001EFE")]
		[FieldOffset(Offset = "0x10")]
		private int _count;
	}
}
