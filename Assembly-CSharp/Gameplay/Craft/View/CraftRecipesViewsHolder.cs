using System;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.Craft.View
{
	// Token: 0x020008B1 RID: 2225
	[Token(Token = "0x20008B1")]
	public class CraftRecipesViewsHolder : BaseItemViewsHolder
	{
		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003444 RID: 13380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5D")]
		public CraftRecipeListElement.CraftRecipeListElementArgs CraftData
		{
			[Token(Token = "0x6003443")]
			[Address(RVA = "0x8470", Offset = "0x8470", VA = "0x8470")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003444")]
			[Address(RVA = "0x8471", Offset = "0x8471", VA = "0x8471")]
			set
			{
			}
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003445")]
		[Address(RVA = "0x8472", Offset = "0x8472", VA = "0x8472", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003446")]
		[Address(RVA = "0x8473", Offset = "0x8473", VA = "0x8473")]
		public CraftRecipesViewsHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Craft_View_CraftRecipesViewsHolder___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57cef == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CraftSlotListElement__TypeInfo);
		    DAT_ram_00a57cef = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_CraftSlotListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CraftSlotListElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04001C79 RID: 7289
		[Token(Token = "0x4001C79")]
		[FieldOffset(Offset = "0x14")]
		private CraftRecipeListElement _craftRecipeListElement;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CraftData ---
		void Gameplay_Craft_View_CraftRecipesViewsHolder__get_CraftData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Craft_View_CraftRecipeListElement__get_Data(*(undefined4 *)(param1 + 0x14),param2,param1)
		  ;
		  return;
		}
		*/


		/* --- GHIDRA: set_CraftData ---
		void Gameplay_Craft_View_CraftRecipesViewsHolder__set_CraftData(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57cee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_CraftRecipeListElement___);
		    DAT_ram_00a57cee = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_CraftRecipeListElement___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

}
