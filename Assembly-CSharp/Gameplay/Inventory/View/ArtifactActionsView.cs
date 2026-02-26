using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UnityEngine;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000655 RID: 1621
	[Token(Token = "0x2000655")]
	public class ArtifactActionsView : MonoBehaviourWithStates<ArtifactActionPopupWindow.ActionType>
	{
		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000767")]
		public ButtonWithCost CostButton
		{
			[Token(Token = "0x600274D")]
			[Address(RVA = "0x7880", Offset = "0x7880", VA = "0x7880")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000768")]
		public GameObject SaleObjectsParent
		{
			[Token(Token = "0x600274E")]
			[Address(RVA = "0x7881", Offset = "0x7881", VA = "0x7881")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000769")]
		public TextMeshProUGUI CurrentDurability
		{
			[Token(Token = "0x600274F")]
			[Address(RVA = "0x7882", Offset = "0x7882", VA = "0x7882")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700076A")]
		public TextMeshProUGUI FutureDurability
		{
			[Token(Token = "0x6002750")]
			[Address(RVA = "0x7883", Offset = "0x7883", VA = "0x7883")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002751")]
		[Address(RVA = "0x7884", Offset = "0x7884", VA = "0x7884")]
		public ArtifactActionsView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_ArtifactActionsView___ctor(int param1,int *param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a084 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_double__get_Count__);
		    DAT_ram_00a5a084 = '\x01';
		  }
		  if (param2 == (int *)0x0) {
		    return;
		  }
		  if (param2[0x1d] == 0) {
		    param2_00 = 0;
		    goto code_r0x811c0150;
		  }
		  if (*(int *)(*(int *)(*(int *)(param2[0x1d] + 0x20) + 0xc) + 0xc) < 1) {
		    param2_00 = 0;
		    goto code_r0x811c0150;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf8) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xfc));
		  if ((iVar1 == -1) ||
		     (iVar1 = Gameplay_Inventory_Model_InventoryBaseModel__GetArtifactById(param2,0), iVar1 != 0)) {
		code_r0x811c0127:
		    iVar1 = Core_Data_ArtifactData__get_IsForgeable(param2,0);
		    if (iVar1 == 0) {
		      param2_00 = 0;
		      goto code_r0x811c0150;
		    }
		    puVar3 = (undefined4 *)(param1 + 0x18);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf8) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0xfc));
		    iVar2 = Core_Data_ArtikulData__get_MaxDurability(param2,0);
		    if ((iVar2 <= iVar1) || (*(int *)(*(int *)(param2[2] + 0x10) + 0x20) - 10U < 3))
		    goto code_r0x811c0127;
		    iVar1 = Core_Data_ArtifactData__get_Rank(param2,0);
		    if ((iVar1 == 0) ||
		       (iVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf8) * 4))
		                          (param2,*(undefined4 *)(*param2 + 0xfc)), iVar1 != 0)) {
		      puVar3 = (undefined4 *)(param1 + 0x14);
		    }
		    else {
		      puVar3 = (undefined4 *)(param1 + 0x1c);
		    }
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__ActivatePanelOnlyFor
		            (*(undefined4 *)(param1 + 0x10),*puVar3,0);
		  param2_00 = 1;
		code_r0x811c0150:
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x10),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04001583 RID: 5507
		[Token(Token = "0x4001583")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _costButton;

		// Token: 0x04001584 RID: 5508
		[Token(Token = "0x4001584")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _saleObjectsParent;

		// Token: 0x04001585 RID: 5509
		[Token(Token = "0x4001585")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _currentDurability;

		// Token: 0x04001586 RID: 5510
		[Token(Token = "0x4001586")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _futureDurability;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_FutureDurability ---
		void Gameplay_Inventory_View_ArtifactActionsView__get_FutureDurability
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a083 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ArtifactActionPopupWindow_ActionType___ctor__);
		    DAT_ram_00a5a083 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_ArtifactActionPopupWindow_ActionType___ctor__)
		  ;
		  return;
		}
		*/

}
