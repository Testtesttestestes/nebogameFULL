using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Clans.Combat.Model
{
	// Token: 0x02000A9B RID: 2715
	[Token(Token = "0x2000A9B")]
	public class ClanCombatEventData : CombatEventData
	{
		// Token: 0x06004150 RID: 16720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004150")]
		[Address(RVA = "0x9007", Offset = "0x9007", VA = "0x9007")]
		public ClanCombatEventData(CombatEventDic eventDic)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Clans_Combat_Model_ClanCombatEventData___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_CombatEventDicExt__GetAnimationAssetId(*(undefined4 *)(param1 + 8),0)
		  ;
		  return uVar1;
		}
		*/

		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06004151 RID: 16721 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000CE2")]
		public override string AnimationAssetId
		{
			[Token(Token = "0x6004151")]
			[Address(RVA = "0x9008", Offset = "0x9008", VA = "0x9008", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
}
