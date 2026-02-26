using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.RightPanel.TitledList;
using UnityEngine;

namespace Gameplay.Discounts.View
{
	// Token: 0x02000894 RID: 2196
	[Token(Token = "0x2000894")]
	public class DiscountInfoTitledListElement : BaseTitledListElement<DiscountInfoTitledListElementArgs>
	{
		// Token: 0x060033C8 RID: 13256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C8")]
		[Address(RVA = "0x8400", Offset = "0x8400", VA = "0x8400", Slot = "6")]
		protected override void OnInit(DiscountInfoTitledListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void Gameplay_Discounts_View_DiscountInfoTitledListElement__OnInit
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57caf == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_DiscountInfoTitledListElementArgs___ctor__
		              );
		    DAT_ram_00a57caf = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_UI_Elements_RightPanel_TitledList_BaseTitledListElement_DiscountInfoTitledListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033C9")]
		[Address(RVA = "0x8401", Offset = "0x8401", VA = "0x8401")]
		public DiscountInfoTitledListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Discounts_View_DiscountInfoTitledListElement___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57cb0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Discounts_View_DiscountListElement_ButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&UnityEngine_Events_UnityAction_DiscountListElement_DiscountListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Events_UnityEvent_DiscountListElement_DiscountListElementArgs__AddListener__
		              );
		    DAT_ram_00a57cb0 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param2 + 0xc) + 8);
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417
		                    (
		                    UnityEngine_Events_UnityAction_DiscountListElement_DiscountListElementArgs__TypeInfo
		                    );
		  func_ii_7054(uVar1,param1,
		               Method_Gameplay_Discounts_View_DiscountListElement_ButtonClickedEventHandler__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,
		             Method_UnityEngine_Events_UnityEvent_DiscountListElement_DiscountListElementArgs__AddListener__
		            );
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = Core_Extensions_Dict_DictExt___c__DisplayClass96_0___GetTournamentDic_b__0(param1_00,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = Core_Extensions_Dict_DiscountsDicExt__GetIconAssetId(param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  uVar1 = Core_Extensions_Dict_DiscountsDicExt__GetTitle(param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (*(undefined4 *)(param1 + 0x2c),*(undefined4 *)(*(int *)(param2 + 0xc) + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x04001C30 RID: 7216
		[Token(Token = "0x4001C30")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _value;

		// Token: 0x04001C31 RID: 7217
		[Token(Token = "0x4001C31")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BacktimeViewUGUI _backtime;

		// Token: 0x04001C32 RID: 7218
		[Token(Token = "0x4001C32")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _backtimeRow;
	}
}
