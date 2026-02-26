using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GameEvents.View.ActionsOnEvens
{
	// Token: 0x0200078F RID: 1935
	[Token(Token = "0x200078F")]
	public class ActionOnEventCheckBox : AbstractActionOnEventView
	{
		// Token: 0x06002DFF RID: 11775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFF")]
		[Address(RVA = "0x7E7D", Offset = "0x7E7D", VA = "0x7E7D")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventCheckBox__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a574b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventCheckBox_HandleOnValueChanged__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a574b4 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,
		             Method_Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventCheckBox_HandleOnValueChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  return;
		}
		*/

		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E00")]
		[Address(RVA = "0x7E7E", Offset = "0x7E7E", VA = "0x7E7E")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventCheckBox__Awake
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined1 *)(*(int *)(param1 + 0x14) + 0x18) = (undefined1)param2;
		  return;
		}
		*/

		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E01")]
		[Address(RVA = "0x7E7F", Offset = "0x7E7F", VA = "0x7E7F")]
		private void HandleOnValueChanged(bool selected)
		{
		/* --- GHIDRA: HandleOnValueChanged ---
		void Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventCheckBox__HandleOnValueChanged
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),
		             *(undefined4 *)(iVar1 + 0x2d4));
		  func_ii_7603(*(undefined4 *)(param1 + 0x18),(uint)*(byte *)(*(int *)(param1 + 0x14) + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E02")]
		[Address(RVA = "0x7E80", Offset = "0x7E80", VA = "0x7E80", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E03")]
		[Address(RVA = "0x7E81", Offset = "0x7E81", VA = "0x7E81")]
		public ActionOnEventCheckBox()
		{
		}

		// Token: 0x04001936 RID: 6454
		[Token(Token = "0x4001936")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Toggle _checkBox;
	}
}
