using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using Protocol.ClanWar;
using Protocol.Dic;
using TMPro;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Clans.Office.View.ClanTreasuryTab
{
	// Token: 0x02000A0B RID: 2571
	[Token(Token = "0x2000A0B")]
	public class ClanTreasuryView : MonoBehaviour
	{
		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06003D16 RID: 15638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C14")]
		public ResourceTable ResourceTable
		{
			[Token(Token = "0x6003D16")]
			[Address(RVA = "0x8BD6", Offset = "0x8BD6", VA = "0x8BD6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C15")]
		public ResourceInputTable ResourceInputTable
		{
			[Token(Token = "0x6003D17")]
			[Address(RVA = "0x8BD7", Offset = "0x8BD7", VA = "0x8BD7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06003D18 RID: 15640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C16")]
		public Button SubmitToTreasuryButton
		{
			[Token(Token = "0x6003D18")]
			[Address(RVA = "0x8BD8", Offset = "0x8BD8", VA = "0x8BD8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06003D19 RID: 15641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C17")]
		public Button ToEventsButton
		{
			[Token(Token = "0x6003D19")]
			[Address(RVA = "0x8BD9", Offset = "0x8BD9", VA = "0x8BD9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06003D1A RID: 15642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C18")]
		public Price Price
		{
			[Token(Token = "0x6003D1A")]
			[Address(RVA = "0x8BDA", Offset = "0x8BDA", VA = "0x8BDA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1B")]
		[Address(RVA = "0x8BDB", Offset = "0x8BDB", VA = "0x8BDB")]
		public void SetWarStatus(ClanWarInfo warInfo, BackTime backTime, Dictionaries dict)
		{
		/* --- GHIDRA: SetWarStatus ---
		void Gameplay_Clans_Office_View_ClanTreasuryTab_ClanTreasuryView__SetWarStatus
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57f1a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4304);
		    DAT_ram_00a57f1a = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4304,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1C")]
		[Address(RVA = "0x8BDC", Offset = "0x8BDC", VA = "0x8BDC")]
		public void SetNoWarStatus()
		{
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1D")]
		[Address(RVA = "0x8BDD", Offset = "0x8BDD", VA = "0x8BDD")]
		public ClanTreasuryView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanTreasuryTab_ClanTreasuryView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57f1b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Resources__ClampedNumberInput__set_Item__
		              );
		    DAT_ram_00a57f1b = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    do {
		      iVar4 = iVar3 + iVar1 * 8;
		      param1_00 = *(undefined4 *)(iVar4 + 0x14);
		      param2_00 = *(undefined4 *)(iVar4 + 0x10);
		      uVar2 = Core_Extensions_Dict_ResourceSetExt__GetValue(param2,param2_00,0);
		      uVar2 = System_Double__ToString(uVar2,0);
		      Scripts_UI_Filters_ClampedNumberInput__SetMaxValue(param1_00,uVar2,0);
		      System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		                (*(undefined4 *)(param1 + 0x14),param2_00,param1_00,
		                 Method_System_Collections_Generic_Dictionary_Resources__ClampedNumberInput__set_Item__
		                );
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x040021EC RID: 8684
		[Token(Token = "0x40021EC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ResourceTable _resourceTable;

		// Token: 0x040021ED RID: 8685
		[Token(Token = "0x40021ED")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ResourceInputTable _resourceInputTable;

		// Token: 0x040021EE RID: 8686
		[Token(Token = "0x40021EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _submitToTreasuryButton;

		// Token: 0x040021EF RID: 8687
		[Token(Token = "0x40021EF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _toEventsButton;

		// Token: 0x040021F0 RID: 8688
		[Token(Token = "0x40021F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Price _price;

		// Token: 0x040021F1 RID: 8689
		[Token(Token = "0x40021F1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _warStatusAnnotation;

		// Token: 0x040021F2 RID: 8690
		[Token(Token = "0x40021F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BacktimeRowViewDynamic _backtimeRow;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Price ---
		void Gameplay_Clans_Office_View_ClanTreasuryTab_ClanTreasuryView__get_Price
		               (int param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  double dVar4;
		  int iVar5;
		  undefined8 local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a57f19 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_BackTimeRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4250);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4298);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26061);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4265);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28645);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4325);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28319);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28322);
		    DAT_ram_00a57f19 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  iVar5 = *(int *)(param2 + 0x1c);
		  if (iVar5 != 1) {
		    if (iVar5 == 2) {
		      dVar4 = Core_Extensions_Dict_DictExt__GetIntParameter(param4,StringLiteral_28319,0);
		      if (dVar4 * 100.0 != 0.0) {
		        uVar1 = *(undefined4 *)(param1 + 0x24);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4298,1,0,1,0,0,0,0);
		        iVar5 = Mono_Security_ASN1Convert__ToOid
		                          (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		        local_8 = (float8)(dVar4 * 100.0);
		        uVar3 = func_ii_1081(DAT_ram_00a66970,&local_8);
		        uVar3 = func_ii_4419(StringLiteral_28645,uVar3,0);
		        local_10 = 0;
		        System_Text_Formatting_StringView__get_IsEmpty
		                  (&local_10,StringLiteral_26061,uVar3,
		                   Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		        *(undefined8 *)(iVar5 + 0x10) = local_10;
		        uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                          (uVar2,iVar5,0);
		        UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar2,0);
		        uVar2 = *(undefined4 *)(param1 + 0x28);
		        iVar5 = unnamed_function_1417(Core_Data_InfoRows_BackTimeRow_TypeInfo);
		        Core_Data_InfoRows_CommonRow___ctor(iVar5,param3,0);
		        uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4265,1,0,1,0,0,0,0);
		        *(undefined4 *)(iVar5 + 0xc) = uVar1;
		        UI_Requirements_RequirementsView__GetRowPrefab(uVar2,iVar5,0);
		        return;
		      }
		      Gameplay_Clans_Office_View_ClanTreasuryTab_ClanTreasuryView__SetWarStatus(param1,&local_10);
		      return;
		    }
		    if (((iVar5 == 3) || (iVar5 == 4)) || (iVar5 != 5)) {
		      Gameplay_Clans_Office_View_ClanTreasuryTab_ClanTreasuryView__SetWarStatus(param1,&local_10);
		      return;
		    }
		  }
		  dVar4 = Core_Extensions_Dict_DictExt__GetIntParameter(param4,StringLiteral_28322,0);
		  if (dVar4 * 100.0 == 0.0) {
		    Gameplay_Clans_Office_View_ClanTreasuryTab_ClanTreasuryView__SetWarStatus(param1,&local_10);
		  }
		  else {
		    uVar1 = *(undefined4 *)(param1 + 0x24);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4325,1,0,1,0,0,0,0);
		    iVar5 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    local_8 = (float8)(dVar4 * 100.0);
		    uVar3 = func_ii_1081(DAT_ram_00a66970,&local_8);
		    uVar3 = func_ii_4419(StringLiteral_28645,uVar3,0);
		    local_10 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_26061,uVar3,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar5 + 0x10) = local_10;
		    uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar2,iVar5,0);
		    UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar2,0);
		    uVar2 = *(undefined4 *)(param1 + 0x28);
		    iVar5 = unnamed_function_1417(Core_Data_InfoRows_BackTimeRow_TypeInfo);
		    Core_Data_InfoRows_CommonRow___ctor(iVar5,param3,0);
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4250,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar5 + 0xc) = uVar1;
		    UI_Requirements_RequirementsView__GetRowPrefab(uVar2,iVar5,0);
		  }
		  return;
		}
		*/

}
