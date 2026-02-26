using System;
using Gameplay.Input;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UI.Activation
{
	// Token: 0x0200025A RID: 602
	[Token(Token = "0x200025A")]
	public class DeActivateWhenInputAnyWay : MonoBehaviour
	{
		// Token: 0x06000E88 RID: 3720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E88")]
		[Address(RVA = "0x6109", Offset = "0x6109", VA = "0x6109")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Activation_DeActivateWhenInputAnyWay__Awake(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a639c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Activation_DeActivateWhenInputAnyWay_PlayerInputControllerOnPressStartedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Input_IPlayerInput_TypeInfo);
		    DAT_ram_00a639c9 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x10);
		  param1_00 = unnamed_function_1417
		                        (System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo);
		  System_Action_object__ulong___Invoke
		            (param1_00,param1,
		             Method_UI_Activation_DeActivateWhenInputAnyWay_PlayerInputControllerOnPressStartedEvent__
		             ,0);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Input_IPlayerInput_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x823264fe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Gameplay_Input_IPlayerInput_TypeInfo,2);
		code_r0x823264fe:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E89")]
		[Address(RVA = "0x610A", Offset = "0x610A", VA = "0x610A")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void UI_Activation_DeActivateWhenInputAnyWay__OnEnable(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a639ca == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Activation_DeActivateWhenInputAnyWay_PlayerInputControllerOnPressStartedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Input_IPlayerInput_TypeInfo);
		    DAT_ram_00a639ca = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x10);
		  param1_00 = unnamed_function_1417
		                        (System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo);
		  System_Action_object__ulong___Invoke
		            (param1_00,param1,
		             Method_UI_Activation_DeActivateWhenInputAnyWay_PlayerInputControllerOnPressStartedEvent__
		             ,0);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Input_IPlayerInput_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x823265d4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Gameplay_Input_IPlayerInput_TypeInfo,3);
		code_r0x823265d4:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8A")]
		[Address(RVA = "0x610B", Offset = "0x610B", VA = "0x610B")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void UI_Activation_DeActivateWhenInputAnyWay__OnDisable(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a639cb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Activation_DeActivateWhenInputAnyWay_PlayerInputControllerOnPressStartedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Input_IPlayerInput_TypeInfo);
		    DAT_ram_00a639cb = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x10);
		  param1_00 = unnamed_function_1417
		                        (System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo);
		  System_Action_object__ulong___Invoke
		            (param1_00,param1,
		             Method_UI_Activation_DeActivateWhenInputAnyWay_PlayerInputControllerOnPressStartedEvent__
		             ,0);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Input_IPlayerInput_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x823266aa;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Gameplay_Input_IPlayerInput_TypeInfo,3);
		code_r0x823266aa:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8B")]
		[Address(RVA = "0x610C", Offset = "0x610C", VA = "0x610C")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Activation_DeActivateWhenInputAnyWay__OnDestroy
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a639cc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_SwitchActivation___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a639cc = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_SwitchActivation___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_Component__GetComponent_object_(uVar1,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a639cd == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&UI_Activation_SwitchActivation__DelayedSetActiveRoutine_d__3_TypeInfo);
		      DAT_ram_00a639cd = '\x01';
		    }
		    iVar2 = unnamed_function_1417
		                      (UI_Activation_SwitchActivation__DelayedSetActiveRoutine_d__3_TypeInfo);
		    *(undefined1 *)(iVar2 + 0x18) = 0;
		    *(undefined4 *)(iVar2 + 0x14) = uVar1;
		    *(undefined4 *)(iVar2 + 8) = 0;
		    *(undefined4 *)(iVar2 + 0x10) = 1;
		    UnityEngine_MonoBehaviour__StartCoroutine(uVar1,iVar2,0);
		    return;
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8C")]
		[Address(RVA = "0x610D", Offset = "0x610D", VA = "0x610D")]
		private void PlayerInputControllerOnPressStartedEvent(IPlayerInput input, InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E8D")]
		[Address(RVA = "0x610E", Offset = "0x610E", VA = "0x610E")]
		public DeActivateWhenInputAnyWay()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Activation_DeActivateWhenInputAnyWay___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  uint uVar1;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  param1_01 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  uVar1 = func_ii_7305(param1_01,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,uVar1 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x10")]
		private IPlayerInput _playerInputController;
	}
}
