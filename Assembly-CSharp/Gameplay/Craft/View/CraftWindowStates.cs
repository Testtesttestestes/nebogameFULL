using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Craft.View
{
	// Token: 0x020008BB RID: 2235
	[Token(Token = "0x20008BB")]
	public class CraftWindowStates : MonoBehaviourWithStates<CraftWindowStates.State>
	{
		// Token: 0x06003486 RID: 13446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003486")]
		[Address(RVA = "0x84B0", Offset = "0x84B0", VA = "0x84B0")]
		public CraftWindowStates()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Craft_View_CraftWindowStates___ctor
		               (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a63a18 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__);
		    DAT_ram_00a63a18 = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,1,
		             Method_UI_MonoBehaviourWithStates_ManufactureGroupView_State__set_CurrentState__);
		  Gameplay_Craft_View_ManufactureGroupView__ResolveSlotState(param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x020008BC RID: 2236
		[Token(Token = "0x20008BC")]
		public enum State
		{
			// Token: 0x04001CBC RID: 7356
			[Token(Token = "0x4001CBC")]
			UNKNOWN_STATE,
			// Token: 0x04001CBD RID: 7357
			[Token(Token = "0x4001CBD")]
			RECIPES,
			// Token: 0x04001CBE RID: 7358
			[Token(Token = "0x4001CBE")]
			MANUFACTURE,
			// Token: 0x04001CBF RID: 7359
			[Token(Token = "0x4001CBF")]
			NO_RECIPES
		}
	}
}
