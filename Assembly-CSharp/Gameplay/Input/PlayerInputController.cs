using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace Gameplay.Input
{
	// Token: 0x020006F3 RID: 1779
	[Token(Token = "0x20006F3")]
	public class PlayerInputController : MonoBehaviour, IPlayerInput
	{
		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06002A9D RID: 10909 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000816")]
		public Pointer CurrentPointer
		{
			[Token(Token = "0x6002A9D")]
			[Address(RVA = "0x7B38", Offset = "0x7B38", VA = "0x7B38", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06002A9E RID: 10910 RVA: 0x00008610 File Offset: 0x00006810
		// (set) Token: 0x06002A9F RID: 10911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000817")]
		public bool IsPressed
		{
			[Token(Token = "0x6002A9E")]
			[Address(RVA = "0x7B39", Offset = "0x7B39", VA = "0x7B39", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002A9F")]
			[Address(RVA = "0x7B3A", Offset = "0x7B3A", VA = "0x7B3A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400015A RID: 346
		// (add) Token: 0x06002AA0 RID: 10912 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002AA1 RID: 10913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400015A")]
		public event Action<IPlayerInput, InputAction.CallbackContext> PressEndedEvent
		{
			[Token(Token = "0x6002AA0")]
			[Address(RVA = "0x7B3B", Offset = "0x7B3B", VA = "0x7B3B", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002AA1")]
			[Address(RVA = "0x7B3C", Offset = "0x7B3C", VA = "0x7B3C", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400015B RID: 347
		// (add) Token: 0x06002AA2 RID: 10914 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002AA3 RID: 10915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400015B")]
		public event Action<IPlayerInput, InputAction.CallbackContext> PressStartEvent
		{
			[Token(Token = "0x6002AA2")]
			[Address(RVA = "0x7B3D", Offset = "0x7B3D", VA = "0x7B3D", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002AA3")]
			[Address(RVA = "0x7B3E", Offset = "0x7B3E", VA = "0x7B3E", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA4")]
		[Address(RVA = "0x7B3F", Offset = "0x7B3F", VA = "0x7B3F")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Input_PlayerInputController__Start(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a1e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InputAction_CallbackContext__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Input_PlayerInputController_PressEndedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Input_PlayerInputController_PressStartedEventHandler__);
		    DAT_ram_00a5a1e2 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_InputAction_CallbackContext__TypeInfo);
		  System_Action_HIDParser_HIDReportData___Invoke
		            (uVar1,param1,Method_Gameplay_Input_PlayerInputController_PressStartedEventHandler__,0);
		  UnityEngine_InputSystem_InputAction__add_started(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_InputAction_CallbackContext__TypeInfo);
		  System_Action_HIDParser_HIDReportData___Invoke
		            (uVar1,param1,Method_Gameplay_Input_PlayerInputController_PressEndedEventHandler__,0);
		  UnityEngine_InputSystem_InputAction__add_canceled(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA5")]
		[Address(RVA = "0x7B40", Offset = "0x7B40", VA = "0x7B40")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Input_PlayerInputController__OnDestroy(int param1,undefined4 param2)
		
		{
		  UnityEngine_InputSystem_InputActionAsset__IsUsableWithDevice(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA6")]
		[Address(RVA = "0x7B41", Offset = "0x7B41", VA = "0x7B41")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_Input_PlayerInputController__OnEnable(int param1,undefined4 param2)
		
		{
		  UnityEngine_InputSystem_InputActionAsset__Enable(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0x7B42", Offset = "0x7B42", VA = "0x7B42")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Gameplay_Input_PlayerInputController__OnDisable
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  int *piVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined8 local_a8;
		  undefined8 local_a0;
		  undefined8 local_98;
		  undefined8 local_90;
		  undefined4 local_88;
		  undefined8 local_80;
		  undefined8 local_78;
		  undefined8 local_70;
		  undefined8 local_68;
		  undefined8 local_60;
		  undefined4 local_58;
		  undefined8 local_50;
		  undefined4 local_48;
		  undefined8 local_44;
		  undefined8 local_3c;
		  undefined8 local_34;
		  int *local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5a1e3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_IInputReleaseHandler___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Input_IInputReleaseHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Physics2D_TypeInfo);
		    DAT_ram_00a5a1e3 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_2c = (int *)0x0;
		  *(undefined1 *)(param1 + 0x24) = 0;
		  iVar5 = *(int *)(param1 + 0x28);
		  if (iVar5 != 0) {
		    local_80 = *param2;
		    local_78 = local_80;
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),param1,&local_80,*(undefined4 *)(iVar5 + 0x14));
		  }
		  uVar3 = Utils_Cam_FlickerFixer___ctor(0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar5 = func_ii_3812(uVar3,0,0);
		  if (iVar5 == 0) {
		    if (DAT_ram_00a5a202 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_InputSystem_Pointer_TypeInfo);
		      DAT_ram_00a5a202 = '\x01';
		    }
		    UnityEngine_InputSystem_InputControl_Vector2___ReadUnprocessedValue
		              (&local_78,
		               *(undefined4 *)(**(int **)(UnityEngine_InputSystem_Pointer_TypeInfo + 0x5c) + 0xe8),
		               Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		    local_48 = 0;
		    local_88 = 0;
		    local_50 = local_78;
		    local_90 = local_78;
		    UnityEngine_Camera__ScreenPointToRay(&local_44,uVar3,&local_90,0);
		    uVar3 = *(undefined4 *)(param1 + 0x14);
		    if (*(int *)(UnityEngine_Physics2D_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Physics2D_TypeInfo);
		    }
		    local_a0 = local_3c;
		    local_98 = local_34;
		    local_a8 = local_44;
		    UnityEngine_Physics2D__Raycast(&local_78,&local_a8,INFINITY,uVar3,0);
		    local_8 = local_58;
		    local_10 = local_60;
		    local_18 = local_68;
		    local_20 = local_70;
		    local_28 = local_78;
		    uVar3 = UnityEngine_RaycastHit2D__get_distance(&local_28,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar5 = func_ii_3812(uVar3,0,0);
		    if (iVar5 == 0) {
		      uVar3 = UnityEngine_RaycastHit2D__get_distance(&local_28,0);
		      iVar5 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                        (uVar3,&local_2c,
		                         Method_UnityEngine_Component_TryGetComponent_IInputReleaseHandler___);
		      piVar1 = local_2c;
		      if (iVar5 != 0) {
		        iVar5 = *local_2c;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (Gameplay_Input_IInputReleaseHandler_TypeInfo ==
		                *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		              puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811e4726;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		        }
		        puVar4 = (uint *)func_ii_1080(local_2c,Gameplay_Input_IInputReleaseHandler_TypeInfo,0);
		code_r0x811e4726:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar1,param1,puVar4[1]);
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0x7B43", Offset = "0x7B43", VA = "0x7B43")]
		private void PressEndedEventHandler(InputAction.CallbackContext ctx)
		{
		/* --- GHIDRA: PressEndedEventHandler ---
		void Gameplay_Input_PlayerInputController__PressEndedEventHandler
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  uint *puVar4;
		  int iVar5;
		  undefined4 param2_00;
		  uint uVar6;
		  undefined8 local_a8;
		  undefined8 local_a0;
		  undefined8 local_98;
		  undefined8 local_90;
		  undefined4 local_88;
		  undefined8 local_80;
		  undefined8 local_78;
		  undefined8 local_70;
		  undefined8 local_68;
		  undefined8 local_60;
		  undefined4 local_58;
		  undefined8 local_50;
		  undefined4 local_48;
		  undefined8 local_44;
		  undefined8 local_3c;
		  undefined8 local_34;
		  int *local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5a1e4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_IInputPressHandler___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_EventSystems_EventSystem_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Input_IInputPressHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RaycastResult__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Physics2D_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_EventSystems_PointerEventData_TypeInfo);
		    DAT_ram_00a5a1e4 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_2c = (int *)0x0;
		  *(undefined1 *)(param1 + 0x24) = 1;
		  iVar5 = *(int *)(param1 + 0x2c);
		  if (iVar5 != 0) {
		    local_80 = *param2;
		    local_78 = local_80;
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),param1,&local_80,*(undefined4 *)(iVar5 + 0x14));
		  }
		  uVar3 = Utils_Cam_FlickerFixer___ctor(0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar5 = func_ii_3812(uVar3,0,0);
		  if (iVar5 == 0) {
		    if (DAT_ram_00a5a202 == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_InputSystem_Pointer_TypeInfo);
		      DAT_ram_00a5a202 = '\x01';
		    }
		    UnityEngine_InputSystem_InputControl_Vector2___ReadUnprocessedValue
		              (&local_78,
		               *(undefined4 *)(**(int **)(UnityEngine_InputSystem_Pointer_TypeInfo + 0x5c) + 0xe8),
		               Method_UnityEngine_InputSystem_InputControl_Vector2__ReadValue__);
		    uVar1 = local_78;
		    if (*(int *)(UnityEngine_EventSystems_EventSystem_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_EventSystems_EventSystem_TypeInfo);
		    }
		    param1_00 = UnityEngine_EventSystems_PointerEventData__ToString(0);
		    param2_00 = *(undefined4 *)(param1 + 0x18);
		    iVar5 = unnamed_function_1417(UnityEngine_EventSystems_PointerEventData_TypeInfo);
		    UnityEngine_EventSystems_PointerEventData__set_reentered(iVar5,param2_00,0);
		    *(undefined8 *)(iVar5 + 200) = uVar1;
		    UnityEngine_EventSystems_EventSystem__RaycastComparer
		              (param1_00,iVar5,*(undefined4 *)(param1 + 0x20),0);
		    if (*(int *)(*(int *)(param1 + 0x20) + 0xc) < 1) {
		      local_48 = 0;
		      local_88 = 0;
		      local_50 = uVar1;
		      local_90 = uVar1;
		      UnityEngine_Camera__ScreenPointToRay(&local_44,uVar3,&local_90,0);
		      uVar3 = *(undefined4 *)(param1 + 0x14);
		      if (*(int *)(UnityEngine_Physics2D_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Physics2D_TypeInfo);
		      }
		      local_a0 = local_3c;
		      local_98 = local_34;
		      local_a8 = local_44;
		      UnityEngine_Physics2D__Raycast(&local_78,&local_a8,INFINITY,uVar3,0);
		      local_8 = local_58;
		      local_10 = local_60;
		      local_18 = local_68;
		      local_20 = local_70;
		      local_28 = local_78;
		      uVar3 = UnityEngine_RaycastHit2D__get_distance(&local_28,0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar5 = func_ii_3812(uVar3,0,0);
		      if (iVar5 == 0) {
		        uVar3 = UnityEngine_RaycastHit2D__get_distance(&local_28,0);
		        iVar5 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                          (uVar3,&local_2c,
		                           Method_UnityEngine_Component_TryGetComponent_IInputPressHandler___);
		        piVar2 = local_2c;
		        if (iVar5 != 0) {
		          iVar5 = *local_2c;
		          if (*(ushort *)(iVar5 + 0xb6) != 0) {
		            uVar6 = 0;
		            do {
		              if (Gameplay_Input_IInputPressHandler_TypeInfo ==
		                  *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		                puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 +
		                                 0xc0);
		                goto code_r0x811e4a78;
		              }
		              uVar6 = uVar6 + 1;
		            } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		          }
		          puVar4 = (uint *)func_ii_1080(local_2c,Gameplay_Input_IInputPressHandler_TypeInfo,0);
		code_r0x811e4a78:
		          (**(code **)((ulonglong)*puVar4 * 4))(piVar2,param1,puVar4[1]);
		        }
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AA9")]
		[Address(RVA = "0x7B44", Offset = "0x7B44", VA = "0x7B44")]
		private void PressStartedEventHandler(InputAction.CallbackContext ctx)
		{
		/* --- GHIDRA: PressStartedEventHandler ---
		void Gameplay_Input_PlayerInputController__PressStartedEventHandler(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a1e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RaycastResult___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_RaycastResult__TypeInfo);
		    DAT_ram_00a5a1e5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_RaycastResult__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_RaycastResult___ctor__);
		  *(undefined4 *)(param1 + 0x20) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AAA")]
		[Address(RVA = "0x7B45", Offset = "0x7B45", VA = "0x7B45")]
		public PlayerInputController()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Input_PlayerInputController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a1e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12629);
		    DAT_ram_00a5a1e6 = '\x01';
		  }
		  return StringLiteral_12629;
		}
		*/

		}

		// Token: 0x04001741 RID: 5953
		[Token(Token = "0x4001741")]
		private const string PRESS_ACTION = "Press";

		// Token: 0x04001742 RID: 5954
		[Token(Token = "0x4001742")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private InputActionAsset _actionsAsset;

		// Token: 0x04001743 RID: 5955
		[Token(Token = "0x4001743")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LayerMask _layerMask;

		// Token: 0x04001744 RID: 5956
		[Token(Token = "0x4001744")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EventSystem _eventSystem;

		// Token: 0x04001745 RID: 5957
		[Token(Token = "0x4001745")]
		[FieldOffset(Offset = "0x1C")]
		private InputAction _clickAction;

		// Token: 0x04001746 RID: 5958
		[Token(Token = "0x4001746")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<RaycastResult> _raycastResults;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsPressed ---
		void Gameplay_Input_PlayerInputController__set_IsPressed
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a1dd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo)
		    ;
		    DAT_ram_00a5a1dd = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_PressEndedEvent ---
		void Gameplay_Input_PlayerInputController__add_PressEndedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a1de == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo)
		    ;
		    DAT_ram_00a5a1de = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_PressEndedEvent ---
		void Gameplay_Input_PlayerInputController__remove_PressEndedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a1df == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo)
		    ;
		    DAT_ram_00a5a1df = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_PressStartEvent ---
		void Gameplay_Input_PlayerInputController__add_PressStartEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a1e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo)
		    ;
		    DAT_ram_00a5a1e0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_IPlayerInput__InputAction_CallbackContext__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_PressStartEvent ---
		void Gameplay_Input_PlayerInputController__remove_PressStartEvent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a1e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InputAction_CallbackContext__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Input_PlayerInputController_PressEndedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Input_PlayerInputController_PressStartedEventHandler__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12699);
		    DAT_ram_00a5a1e1 = '\x01';
		  }
		  uVar1 = UnityEngine_InputSystem_InputActionAsset__FromJson
		                    (*(undefined4 *)(param1 + 0x10),StringLiteral_12699,0,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar2 = unnamed_function_1417(System_Action_InputAction_CallbackContext__TypeInfo);
		  System_Action_HIDParser_HIDReportData___Invoke
		            (uVar2,param1,Method_Gameplay_Input_PlayerInputController_PressStartedEventHandler__,0);
		  UnityEngine_InputSystem_InputAction__get_inProgress(uVar1,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_InputAction_CallbackContext__TypeInfo);
		  System_Action_HIDParser_HIDReportData___Invoke
		            (uVar1,param1,Method_Gameplay_Input_PlayerInputController_PressEndedEventHandler__,0);
		  UnityEngine_InputSystem_InputAction__remove_started(uVar2,uVar1,0);
		  return;
		}
		*/

}
