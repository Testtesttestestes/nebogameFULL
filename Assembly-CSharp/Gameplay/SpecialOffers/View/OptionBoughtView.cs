using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SpecialOffers.View
{
	// Token: 0x020004F9 RID: 1273
	[Token(Token = "0x20004F9")]
	public class OptionBoughtView : MonoBehaviour
	{
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001E62 RID: 7778 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000583")]
		public Button Button
		{
			[Token(Token = "0x6001E62")]
			[Address(RVA = "0x6FDB", Offset = "0x6FDB", VA = "0x6FDB")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E63")]
		[Address(RVA = "0x6FDC", Offset = "0x6FDC", VA = "0x6FDC")]
		public void Init(BankOptionData option)
		{
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E64")]
		[Address(RVA = "0x6FDD", Offset = "0x6FDD", VA = "0x6FDD")]
		public OptionBoughtView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_SpecialOffers_View_OptionBoughtView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58613 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12670);
		    DAT_ram_00a58613 = '\x01';
		  }
		  return StringLiteral_12670;
		}
		*/

		}

		// Token: 0x0400107E RID: 4222
		[Token(Token = "0x400107E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400107F RID: 4223
		[Token(Token = "0x400107F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001080 RID: 4224
		[Token(Token = "0x4001080")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Button ---
		void Gameplay_SpecialOffers_View_OptionBoughtView__get_Button
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58612 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13877);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13880);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2170);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13879);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13878);
		    DAT_ram_00a58612 = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13877,1,0,1,0,0,0,0);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13879,1,0,1,0,0,0,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_2170,uVar2,0);
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13878,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x14),uVar1,0);
		  uVar1 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(param1 + 0x18),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13880,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar2,0);
		  return;
		}
		*/

}
