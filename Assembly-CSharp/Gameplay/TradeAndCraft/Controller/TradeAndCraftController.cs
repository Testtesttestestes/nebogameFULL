using System;
using Gameplay.TradeAndCraft.Events;
using Gameplay.TradeAndCraft.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.TradeAndCraft.Controller
{
	// Token: 0x0200049F RID: 1183
	[Token(Token = "0x200049F")]
	public class TradeAndCraftController : AbstractController<TradeAndCraftModel, TradeAndCraftEvents>
	{
		// Token: 0x06001BEE RID: 7150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0x6D6D", Offset = "0x6D6D", VA = "0x6D6D")]
		public TradeAndCraftController(TradeAndCraftModel model, TradeAndCraftEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TradeAndCraft_Controller_TradeAndCraftController___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a584d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TradeAndCraftModel__TradeAndCraftEvents__TradeAndCraftController__TradeAndCraftWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a584d3 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_TradeAndCraftModel__TradeAndCraftEvents__TradeAndCraftController__TradeAndCraftWindow___ctor__
		            );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x80ef8791;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80ef8791:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0x18) = *(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20);
		  return;
		}
		*/

		}
	}
}
