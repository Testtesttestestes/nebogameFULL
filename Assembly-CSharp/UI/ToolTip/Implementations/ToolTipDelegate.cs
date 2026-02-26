using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Implementations
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	[RequireComponent(typeof(ToolTip))]
	public class ToolTipDelegate : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x140000D3 RID: 211
		// (add) Token: 0x06000998 RID: 2456 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000999 RID: 2457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D3")]
		public event Func<BaseToolTipData> TooltipDelegate
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x5D00", Offset = "0x5D00", VA = "0x5D00")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x5D01", Offset = "0x5D01", VA = "0x5D01")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x5D02", Offset = "0x5D02", VA = "0x5D02")]
		public void Init(Func<BaseToolTipData> @delegate)
		{
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x5D03", Offset = "0x5D03", VA = "0x5D03")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x5D04", Offset = "0x5D04", VA = "0x5D04", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x5D05", Offset = "0x5D05", VA = "0x5D05")]
		public ToolTipDelegate()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_ToolTipDelegate___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  float fVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int param1_00;
		  longlong param1_01;
		  uint param2_00;
		  
		  if (DAT_ram_00a5b8db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_AprToolTipVO__HandleDataChanged__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_AprToolTipVO__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13144);
		    DAT_ram_00a5b8db = '\x01';
		  }
		  iVar6 = *(int *)(*(int *)(param1 + 0x14) + 0xc);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_13144,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar6 + 0x24) = uVar2;
		  UI_Requirements_RequirementsView__get_Data
		            (*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(*(int *)(param1 + 0x14) + 0xc),0);
		  iVar6 = **(int **)(param1 + 0x18);
		  uVar1 = CONCAT44(in_register_20000004,*(int **)(param1 + 0x18));
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x138) * 4))
		            (uVar1,*(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x1c),
		             *(undefined4 *)(iVar6 + 0x13c));
		  uVar7 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = Gameplay_Aprs_Model_AprData__set_SaleMarkersDic
		                    (*(undefined4 *)(*(int *)(param1 + 0x14) + 8),0);
		  Gameplay_Inventory_View_Info_InfoBox_TitleIconLoaderValueRow__SetIcon(uVar7,uVar3,0);
		  iVar6 = Core_Extensions_Dict_AprDicExt__IsIndividual
		                    (*(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x1c) + 0x10),
		                     0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
		  if (iVar6 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,1,0);
		    uVar3 = *(undefined4 *)(param1 + 0x24);
		    uVar7 = *(undefined4 *)
		             (*(int *)(*(int *)(*(int *)(*(int *)(param1 + 0x14) + 8) + 0x14) + 0x10) + 0x28);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar7 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar7,0);
		    piVar4 = (int *)func_ii_7307(uVar3,uVar7,0);
		    uVar1 = CONCAT44(uVar2,piVar4);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xf0) * 4))(uVar1,*(undefined4 *)(*piVar4 + 0xf4));
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  }
		  else {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		  }
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  iVar6 = *(int *)(*(int *)(param1 + 0x14) + 8);
		  if (*(int *)(iVar6 + 0x2c) == 0) {
		    param2_00 = (uint)(*(longlong *)(*(int *)(*(int *)(iVar6 + 0x14) + 0x10) + 0x40) != 0);
		  }
		  else {
		    param2_00 = 1;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,param2_00,0);
		  iVar6 = *(int *)(*(int *)(param1 + 0x14) + 8);
		  param1_00 = *(int *)(iVar6 + 0x2c);
		  if (param1_00 != 0) {
		    piVar4 = *(int **)(param1 + 0x20);
		    fVar5 = func_ii_7103(param1_00,0);
		    uVar3 = UI_ToolTip_Implementations_View_AprToolTipView__HandleDataChanged(piVar4,fVar5,piVar4);
		    if (piVar4[7] != 0) {
		      func_ii_7950(piVar4[7],0);
		      piVar4[7] = 0;
		    }
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe0) * 4))
		              (CONCAT44(uVar2,piVar4),uVar3,*(undefined4 *)(*piVar4 + 0xe4));
		    return;
		  }
		  param1_01 = *(longlong *)(*(int *)(*(int *)(iVar6 + 0x14) + 0x10) + 0x40);
		  if (param1_01 != 0) {
		    piVar4 = *(int **)(param1 + 0x20);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    fVar5 = Utils_StringUtils___cctor(param1_01,0);
		    uVar2 = (undefined4)((ulonglong)param1_01 >> 0x20);
		    uVar3 = UI_ToolTip_Implementations_View_AprToolTipView__HandleDataChanged(piVar4,fVar5,piVar4);
		    if (piVar4[7] != 0) {
		      func_ii_7950(piVar4[7],0);
		      piVar4[7] = 0;
		    }
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe0) * 4))
		              (CONCAT44(uVar2,piVar4),uVar3,*(undefined4 *)(*piVar4 + 0xe4));
		  }
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_TooltipDelegate ---
		void UI_ToolTip_Implementations_ToolTipDelegate__add_TooltipDelegate
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b8da == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_BaseToolTipData__TypeInfo);
		    DAT_ram_00a5b8da = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Func_BaseToolTipData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Func_BaseToolTipData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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
