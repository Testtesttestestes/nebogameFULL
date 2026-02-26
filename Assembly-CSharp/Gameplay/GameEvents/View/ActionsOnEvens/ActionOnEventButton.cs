using System;
using Gameplay.GameEvents.Model.ActionsOnEvents;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GameEvents.View.ActionsOnEvens
{
	// Token: 0x0200078E RID: 1934
	[Token(Token = "0x200078E")]
	public class ActionOnEventButton : AbstractActionOnEventView
	{
		// Token: 0x06002DFA RID: 11770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFA")]
		[Address(RVA = "0x7E78", Offset = "0x7E78", VA = "0x7E78")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventButton__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a574b2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventButton_HandleOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a574b2 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventButton_HandleOnClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFB")]
		[Address(RVA = "0x7E79", Offset = "0x7E79", VA = "0x7E79")]
		private void Awake()
		{
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFC")]
		[Address(RVA = "0x7E7A", Offset = "0x7E7A", VA = "0x7E7A", Slot = "4")]
		public override void SetOnTriggeredCallback(EventHandler<AbstractActionOnEvent> callback)
		{
		/* --- GHIDRA: SetOnTriggeredCallback ---
		void Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventButton__SetOnTriggeredCallback
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  *(undefined1 *)(iVar1 + 0x18) = 1;
		  iVar2 = *(int *)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,iVar1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFD")]
		[Address(RVA = "0x7E7B", Offset = "0x7E7B", VA = "0x7E7B")]
		private void HandleOnClickEvent()
		{
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFE")]
		[Address(RVA = "0x7E7C", Offset = "0x7E7C", VA = "0x7E7C")]
		public ActionOnEventButton()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventButton___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a574b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventCheckBox_HandleOnValueChanged__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a574b3 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,
		             Method_Gameplay_GameEvents_View_ActionsOnEvens_ActionOnEventCheckBox_HandleOnValueChanged__
		             ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  return;
		}
		*/

		}

		// Token: 0x04001934 RID: 6452
		[Token(Token = "0x4001934")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;

		// Token: 0x04001935 RID: 6453
		[Token(Token = "0x4001935")]
		[FieldOffset(Offset = "0x1C")]
		private EventHandler<AbstractActionOnEvent> _onTriggeredCallback;
	}
}
