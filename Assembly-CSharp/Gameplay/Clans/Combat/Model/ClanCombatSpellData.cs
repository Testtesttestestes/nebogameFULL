using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;

namespace Gameplay.Clans.Combat.Model
{
	// Token: 0x02000A9E RID: 2718
	[Token(Token = "0x2000A9E")]
	public class ClanCombatSpellData : CombatSpellData
	{
		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x0600416F RID: 16751 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CEB")]
		public override string AnimationAssetId
		{
			[Token(Token = "0x600416F")]
			[Address(RVA = "0x9026", Offset = "0x9026", VA = "0x9026", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004170")]
		[Address(RVA = "0x9027", Offset = "0x9027", VA = "0x9027")]
		public ClanCombatSpellData()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Combat_Model_ClanCombatSpellData___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  undefined8 param3_00;
		  
		  param3_00 = Core_Data_UserData__get_UserId(param5,0);
		  Gameplay_Combat_Model_GameFieldGamesData___ctor(param1,param3,param3_00,param6,2,param7,0);
		  *(undefined4 *)(param1 + 0x2c) = param5;
		  *(undefined4 *)(param1 + 0x28) = param4;
		  *(undefined4 *)(param1 + 0x24) = param2;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AnimationAssetId ---
		void Gameplay_Clans_Combat_Model_ClanCombatSpellData__get_AnimationAssetId
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Combat_Model_CombatSpellData__get_AnimationAssetId(param1,0);
		  return;
		}
		*/

}
