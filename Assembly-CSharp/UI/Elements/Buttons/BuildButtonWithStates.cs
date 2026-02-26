using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.Buttons
{
	// Token: 0x0200023F RID: 575
	[Token(Token = "0x200023F")]
	public class BuildButtonWithStates : ImageWithStates<BuildButtonWithStates.State>
	{
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E3")]
		public ButtonWithCost ButtonWithCost
		{
			[Token(Token = "0x6000E2D")]
			[Address(RVA = "0x60BF", Offset = "0x60BF", VA = "0x60BF")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x60C0", Offset = "0x60C0", VA = "0x60C0", Slot = "4")]
		protected override void HandleCurrentStateChanged(BuildButtonWithStates.State fromState, BuildButtonWithStates.State toState)
		{
		/* --- GHIDRA: HandleCurrentStateChanged ---
		undefined4
		UI_Elements_Buttons_BuildButtonWithStates__HandleCurrentStateChanged
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  
		  if (DAT_ram_00a639a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3695);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3694);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3702);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14641);
		    DAT_ram_00a639a3 = '\x01';
		  }
		  if (param2 - 1U < 3) {
		    puVar1 = (undefined4 *)(&PTR_StringLiteral_3695_ram_005a4ce0)[param2 - 1U];
		  }
		  else {
		    puVar1 = &StringLiteral_14641;
		  }
		  return *puVar1;
		}
		*/

		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x60C1", Offset = "0x60C1", VA = "0x60C1")]
		private string GetLocalizationKey(BuildButtonWithStates.State state)
		{
		/* --- GHIDRA: GetLocalizationKey ---
		void UI_Elements_Buttons_BuildButtonWithStates__GetLocalizationKey
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a639a4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_ImageWithStates_BuildButtonWithStates_State___ctor__);
		    DAT_ram_00a639a4 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_Elements_ImageWithStates_BuildButtonWithStates_State___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x60C2", Offset = "0x60C2", VA = "0x60C2")]
		public BuildButtonWithStates()
		{
		}

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x02000240 RID: 576
		[Token(Token = "0x2000240")]
		public enum State
		{
			// Token: 0x04000707 RID: 1799
			[Token(Token = "0x4000707")]
			UNKNOWN_STATE,
			// Token: 0x04000708 RID: 1800
			[Token(Token = "0x4000708")]
			Build,
			// Token: 0x04000709 RID: 1801
			[Token(Token = "0x4000709")]
			Upgrade,
			// Token: 0x0400070A RID: 1802
			[Token(Token = "0x400070A")]
			Accelerate
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ButtonWithCost ---
		void UI_Elements_Buttons_BuildButtonWithStates__get_ButtonWithCost
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a639a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_ImageWithStates_BuildButtonWithStates_State__HandleCurrentStateChanged__
		              );
		    DAT_ram_00a639a2 = '\x01';
		  }
		  UI_Elements_ImageWithStates_Int32Enum____ctor
		            (param1,param2,param3,
		             Method_UI_Elements_ImageWithStates_BuildButtonWithStates_State__HandleCurrentStateChanged__
		            );
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  if (DAT_ram_00a639a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_3695);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3694);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3702);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14641);
		    DAT_ram_00a639a3 = '\x01';
		  }
		  if (param3 - 1U < 3) {
		    puVar1 = (undefined4 *)(&PTR_StringLiteral_3695_ram_005a4ce0)[param3 - 1U];
		  }
		  else {
		    puVar1 = &StringLiteral_14641;
		  }
		  uVar2 = *puVar1;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar2,0);
		  return;
		}
		*/

}
