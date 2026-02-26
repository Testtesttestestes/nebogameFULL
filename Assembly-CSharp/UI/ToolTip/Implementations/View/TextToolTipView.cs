using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	public class TextToolTipView : BaseToolTip<string>
	{
		// Token: 0x060009B4 RID: 2484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x5D1C", Offset = "0x5D1C", VA = "0x5D1C", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_TextToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5996d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_string___ctor__);
		    DAT_ram_00a5996d = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update(param1,Method_UI_ToolTip_BaseToolTip_string___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x5D1D", Offset = "0x5D1D", VA = "0x5D1D")]
		public TextToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_TextToolTipView___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  uint uVar3;
		  undefined4 param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a5996e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ToolTip_BaseToolTip_TitleWhitListToolTipView_TitleWhitListToolTipData__HandleDataChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_ToolTip_BaseToolTip_TitleWhitListToolTipView_TitleWhitListToolTipData__get_Data__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponentInChildren_Image___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5996e = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    iVar4 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x18),*(undefined4 *)(*(int *)(param1 + 0x14) + 8),
		               *(undefined4 *)(iVar4 + 0x2d4));
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		    uVar3 = *(uint *)(*(int *)(*(int *)(param1 + 0x14) + 0xc) + 0xc);
		    if (0 < (int)uVar3) {
		      uVar1 = 0;
		      do {
		        uVar2 = *(undefined4 *)(param1 + 0x1c);
		        param1_01 = *(undefined4 *)(param1 + 0x20);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        param1_00 = (int *)func_ii_6805(param1_01,uVar2,
		                                        Method_UnityEngine_Object_Instantiate_TextMeshProUGUI___);
		        uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1_00,0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar2,1,0);
		        (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x2d0) * 4))
		                  (param1_00,
		                   *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0xc) + uVar1 * 4 + 0x10),
		                   *(undefined4 *)(*param1_00 + 0x2d4));
		        if ((uVar1 & 1) != 0) {
		          uVar2 = UI_Rewards_AbstractRewardsRender__SetRewards
		                            (param1_00,Method_UnityEngine_Component_GetComponentInChildren_Image___)
		          ;
		          func_ii_7050(uVar2,*(undefined4 *)(param1 + 0x24),0);
		        }
		        uVar1 = uVar1 + 1;
		      } while (uVar1 != uVar3);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _textField;
	}
}
