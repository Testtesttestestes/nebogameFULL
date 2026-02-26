using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Combat.Factories;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.TeamCombat.Model
{
	// Token: 0x0200098F RID: 2447
	[Token(Token = "0x200098F")]
	public class TeamCombatPlayer : CombatPlayer
	{
		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06003A5C RID: 14940 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		// (set) Token: 0x06003A5D RID: 14941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B6C")]
		public bool IsTurn
		{
			[Token(Token = "0x6003A5C")]
			[Address(RVA = "0x89D2", Offset = "0x89D2", VA = "0x89D2")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A5D")]
			[Address(RVA = "0x89D3", Offset = "0x89D3", VA = "0x89D3")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06003A5E RID: 14942 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		// (set) Token: 0x06003A5F RID: 14943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B6D")]
		public bool IsMyPlayer
		{
			[Token(Token = "0x6003A5E")]
			[Address(RVA = "0x89D4", Offset = "0x89D4", VA = "0x89D4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A5F")]
			[Address(RVA = "0x89D5", Offset = "0x89D5", VA = "0x89D5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A60")]
		[Address(RVA = "0x89D6", Offset = "0x89D6", VA = "0x89D6")]
		public TeamCombatPlayer(PlayerInfo playerInfo, UserData user, ICombatSpellDataFactory spellFactory)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsMyPlayer ---
		void Gameplay_Combat_TeamCombat_Model_TeamCombatPlayer__set_IsMyPlayer
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  Gameplay_Combat_Model_CombatPlayer__Dispose(param1,param2,param3,param4,param4);
		  return;
		}
		*/

}
