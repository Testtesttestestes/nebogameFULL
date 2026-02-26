using System;
using Gameplay.Combat.Model;
using Gameplay.VortexCombat.View.Spells;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Combat
{
	// Token: 0x0200015E RID: 350
	[Token(Token = "0x200015E")]
	public class VortexCombatSpellToolTipView : AbstractCombatSpellToolTipView<CombatSpellData>
	{
		// Token: 0x060009F1 RID: 2545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x5D51", Offset = "0x5D51", VA = "0x5D51", Slot = "10")]
		protected override void HandlePriceOfUse()
		{
		/* --- GHIDRA: HandlePriceOfUse ---
		void UI_ToolTip_Implementations_View_Combat_VortexCombatSpellToolTipView__HandlePriceOfUse
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5998b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ToolTip_Implementations_View_Combat_AbstractCombatSpellToolTipView_CombatSpellData___ctor__
		              );
		    DAT_ram_00a5998b = '\x01';
		  }
		  Gameplay_Combat_View_Spells_AbstractCombatSpellButton_object___set_Selected
		            (param1,
		             Method_UI_ToolTip_Implementations_View_Combat_AbstractCombatSpellToolTipView_CombatSpellData___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x5D52", Offset = "0x5D52", VA = "0x5D52")]
		public VortexCombatSpellToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_Combat_VortexCombatSpellToolTipView___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined1 uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_01;
		  uint param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5998c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_EffectData____HandleDataChanged__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_EffectData____get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_CombatLongEffectToolTipItemView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5998c = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar2 = *(int *)(iVar2 + param2_00 * 4 + 0x10);
		      uVar3 = *(undefined4 *)(param1 + 0x18);
		      param1_01 = *(undefined4 *)(param1 + 0x1c);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      param1_00 = func_ii_6805(param1_01,uVar3,
		                               Method_UnityEngine_Object_Instantiate_CombatLongEffectToolTipItemView___
		                              );
		      if (iVar2 != *(int *)(param1_00 + 0x2c)) {
		        *(int *)(param1_00 + 0x2c) = iVar2;
		        UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipItemView__set_Data
		                  (param1_00,param2_00);
		      }
		      param2_00 = param2_00 + 1;
		      if (param2_00 != *(uint *)(param1_00 + 0x28)) {
		        *(uint *)(param1_00 + 0x28) = param2_00;
		        if ((param2_00 & 1) == 0) {
		          if (*(char *)(param1_00 + 0x24) == '\0') {
		            uVar1 = 1;
		            goto code_r0x8109b00c;
		          }
		        }
		        else {
		          uVar1 = 0;
		          if (*(char *)(param1_00 + 0x24) != '\0') {
		code_r0x8109b00c:
		            *(undefined1 *)(param1_00 + 0x24) = uVar1;
		            uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (*(undefined4 *)(param1_00 + 0x20),0);
		            Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                      (uVar3,(uint)*(byte *)(param1_00 + 0x24),0);
		          }
		        }
		      }
		      iVar2 = *(int *)(param1 + 0x14);
		    } while ((int)param2_00 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/VortexCombatSpellToolTipView";

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected PriceItemRenderer _manaBoostPriceOfUsage;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private VortexCombatSpellButton.Config[] _configs;
	}
}
