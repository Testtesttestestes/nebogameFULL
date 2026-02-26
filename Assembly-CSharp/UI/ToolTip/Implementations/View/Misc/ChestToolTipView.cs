using System;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Rewards;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Misc
{
	// Token: 0x02000155 RID: 341
	[Token(Token = "0x2000155")]
	public class ChestToolTipView : BaseToolTip<PaymentBonusModel>
	{
		// Token: 0x060009D3 RID: 2515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x5D3A", Offset = "0x5D3A", VA = "0x5D3A", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_Misc_ChestToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5997c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_PaymentBonusModel___ctor__);
		    DAT_ram_00a5997c = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_ToolTip_BaseToolTip_PaymentBonusModel___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x5D3B", Offset = "0x5D3B", VA = "0x5D3B")]
		public ChestToolTipView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_Misc_ChestToolTipView___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5997d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_IItemInformationProvider__Dispose__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_IItemInformationProvider__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_IItemInformationProvider__set_Data__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a5997d = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x14);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81099c5c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,System_IDisposable_TypeInfo,0);
		code_r0x81099c5c:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  UI_ToolTip_BaseToolTip_object___get_Data
		            (param1,0,Method_UI_ToolTip_BaseToolTip_IItemInformationProvider__set_Data__);
		  return;
		}
		*/

		}

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/ChestToolTipView";

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RewardsRender _rewards;
	}
}
