using System;
using Il2CppDummyDll;

namespace Gameplay.Combat.Model
{
	// Token: 0x0200099B RID: 2459
	[Token(Token = "0x200099B")]
	public class FakeCombatSpellData : CombatSpellData
	{
		// Token: 0x06003AD8 RID: 15064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD8")]
		[Address(RVA = "0x8A4D", Offset = "0x8A4D", VA = "0x8A4D")]
		public FakeCombatSpellData()
		{
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06003AD9 RID: 15065 RVA: 0x0000BE20 File Offset: 0x0000A020
		[Token(Token = "0x17000BA6")]
		public override bool Enabled
		{
			[Token(Token = "0x6003AD9")]
			[Address(RVA = "0x8A4E", Offset = "0x8A4E", VA = "0x8A4E", Slot = "7")]
			get
			{
				return default(bool);
			}
		}
	}
}
