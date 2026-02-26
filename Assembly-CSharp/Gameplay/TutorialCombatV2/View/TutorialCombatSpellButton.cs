using System;
using Gameplay.Combat.View.Spells;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.TutorialCombatV2.View
{
	// Token: 0x02000445 RID: 1093
	[Token(Token = "0x2000445")]
	[AddComponentMenu("TutorialCombatV2/View/TutorialCombatSpellButton")]
	public class TutorialCombatSpellButton : CombatSpellButton
	{
		// Token: 0x060019C7 RID: 6599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C7")]
		[Address(RVA = "0x6B5F", Offset = "0x6B5F", VA = "0x6B5F", Slot = "14")]
		protected override void HandleEnabledChanged()
		{
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019C8")]
		[Address(RVA = "0x6B60", Offset = "0x6B60", VA = "0x6B60")]
		public TutorialCombatSpellButton()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialCombatV2_View_TutorialCombatSpellButton___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a583e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseGameFieldMono__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_TutorialCombatV2_View_TutorialCombatView_HandleOnMouseDownEvent__);
		    DAT_ram_00a583e9 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_BaseGameFieldMono__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_TutorialCombatV2_View_TutorialCombatView_HandleOnMouseDownEvent__,0);
		  Gameplay_Combat_View_GameField_BaseGameFieldMono__add_OnMouseDownEvent(param1_00,uVar1,0);
		  Gameplay_Combat_View_AbstractCombatView__remove_OnSpellClick(param1,0);
		  uVar1 = *(undefined4 *)(param1 + 0x84);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_Component__GetComponent_object_(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x84),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000DD7 RID: 3543
		[Token(Token = "0x4000DD7")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject _clickOnSpellint;
	}
}
