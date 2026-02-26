using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.Buttons
{
	// Token: 0x02000243 RID: 579
	[Token(Token = "0x2000243")]
	public class SpellButtonWithStates : ImageWithStates<SpellButtonWithStates.State>
	{
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001E8")]
		public ButtonWithCost ButtonWithCost
		{
			[Token(Token = "0x6000E39")]
			[Address(RVA = "0x60CA", Offset = "0x60CA", VA = "0x60CA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x60CB", Offset = "0x60CB", VA = "0x60CB", Slot = "4")]
		protected override void HandleCurrentStateChanged(SpellButtonWithStates.State fromState, SpellButtonWithStates.State toState)
		{
		/* --- GHIDRA: HandleCurrentStateChanged ---
		undefined4
		UI_Elements_Buttons_SpellButtonWithStates__HandleCurrentStateChanged
		          (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 *puVar1;
		  
		  if (DAT_ram_00a639a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_13881);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13882);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14641);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13883);
		    DAT_ram_00a639a6 = '\x01';
		  }
		  if (param2 - 1U < 3) {
		    puVar1 = (undefined4 *)(&PTR_StringLiteral_13882_ram_005a4cec)[param2 - 1U];
		  }
		  else {
		    puVar1 = &StringLiteral_14641;
		  }
		  return *puVar1;
		}
		*/

		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x60CC", Offset = "0x60CC", VA = "0x60CC")]
		private string GetLocalizationKey(SpellButtonWithStates.State state)
		{
		/* --- GHIDRA: GetLocalizationKey ---
		void UI_Elements_Buttons_SpellButtonWithStates__GetLocalizationKey
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a639a7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_ImageWithStates_SpellButtonWithStates_State___ctor__);
		    DAT_ram_00a639a7 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_Elements_ImageWithStates_SpellButtonWithStates_State___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x60CD", Offset = "0x60CD", VA = "0x60CD")]
		public SpellButtonWithStates()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Elements_Buttons_SpellButtonWithStates___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x14);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2c8) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0x2cc));
		  return uVar1;
		}
		*/

		}

		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x400070F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ButtonWithCost _buttonWithCost;

		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x02000244 RID: 580
		[Token(Token = "0x2000244")]
		public enum State
		{
			// Token: 0x04000712 RID: 1810
			[Token(Token = "0x4000712")]
			UNKNOWN_STATE,
			// Token: 0x04000713 RID: 1811
			[Token(Token = "0x4000713")]
			Learn,
			// Token: 0x04000714 RID: 1812
			[Token(Token = "0x4000714")]
			Upgrade,
			// Token: 0x04000715 RID: 1813
			[Token(Token = "0x4000715")]
			Accelerate
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ButtonWithCost ---
		void UI_Elements_Buttons_SpellButtonWithStates__get_ButtonWithCost
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a639a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_ImageWithStates_SpellButtonWithStates_State__HandleCurrentStateChanged__
		              );
		    DAT_ram_00a639a5 = '\x01';
		  }
		  UI_Elements_ImageWithStates_Int32Enum____ctor
		            (param1,param2,param3,
		             Method_UI_Elements_ImageWithStates_SpellButtonWithStates_State__HandleCurrentStateChanged__
		            );
		  param1_00 = *(undefined4 *)(param1 + 0x20);
		  if (DAT_ram_00a639a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_13881);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13882);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14641);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13883);
		    DAT_ram_00a639a6 = '\x01';
		  }
		  if (param3 - 1U < 3) {
		    puVar1 = (undefined4 *)(&PTR_StringLiteral_13882_ram_005a4cec)[param3 - 1U];
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
