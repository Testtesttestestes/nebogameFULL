using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Gameplay.Combat.Model;
using Il2CppDummyDll;

namespace Gameplay.BossCombat.Model
{
	// Token: 0x02000B3E RID: 2878
	[Token(Token = "0x2000B3E")]
	public class BossCombatSpellData : CombatSpellData
	{
		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x060045D2 RID: 17874 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060045D3 RID: 17875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC1")]
		public List<TeamData.TeamAssistantData> Assistants
		{
			[Token(Token = "0x60045D2")]
			[Address(RVA = "0x9474", Offset = "0x9474", VA = "0x9474")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045D3")]
			[Address(RVA = "0x9475", Offset = "0x9475", VA = "0x9475")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060045D4 RID: 17876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045D4")]
		[Address(RVA = "0x9476", Offset = "0x9476", VA = "0x9476")]
		public BossCombatSpellData()
		{
		}
	}
}
