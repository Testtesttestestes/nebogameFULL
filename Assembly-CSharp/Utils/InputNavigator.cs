using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Utils
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class InputNavigator : MonoBehaviour
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x56E0", Offset = "0x56E0", VA = "0x56E0")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Utils_InputNavigator__Start(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a648e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InputAction_CallbackContext__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_InputNavigator_SelectElement__);
		    DAT_ram_00a648e9 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_InputAction_CallbackContext__TypeInfo);
		  System_Action_HIDParser_HIDReportData___Invoke
		            (param1_00,param1,Method_Utils_InputNavigator_SelectElement__,0);
		  UnityEngine_InputSystem_InputAction__add_performed(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x56E1", Offset = "0x56E1", VA = "0x56E1")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Utils_InputNavigator__OnDestroy(int param1,undefined4 param2)
		
		{
		  UnityEngine_InputSystem_InputAction__ToString(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x56E2", Offset = "0x56E2", VA = "0x56E2")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Utils_InputNavigator__OnEnable(int param1,undefined4 param2)
		
		{
		  UnityEngine_InputSystem_InputAction__Enable(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x56E3", Offset = "0x56E3", VA = "0x56E3")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Utils_InputNavigator__OnDisable(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a648f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_InputSystem_Keyboard_TypeInfo);
		    DAT_ram_00a648f9 = '\x01';
		  }
		  iVar1 = UnityEngine_InputSystem_Controls_ButtonControl__IsValueConsideredPressed
		                    (*(undefined4 *)
		                      (**(int **)(UnityEngine_InputSystem_Keyboard_TypeInfo + 0x5c) + 0xec),0);
		  if (iVar1 == 0) {
		    iVar1 = *(int *)(param1 + 0x20) + 1;
		    if ((DAT_ram_00a648ea & 1) == 0) {
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Selectable__get_Count__);
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Selectable__get_Item__);
		      DAT_ram_00a648ea = 1;
		    }
		    iVar2 = Utils_InputNavigator__SetIndex(param1,param1);
		    iVar4 = *(int *)(iVar2 + 0xc) + -1;
		    iVar5 = iVar1;
		    if (iVar4 < iVar1) {
		      iVar5 = 0;
		    }
		    if (-1 < iVar1) {
		      iVar4 = iVar5;
		    }
		    *(int *)(param1 + 0x20) = iVar4;
		    piVar3 = (int *)System_Linq_Enumerable__ToList_object_
		                              (iVar2,iVar4,
		                               Method_System_Collections_Generic_List_Selectable__get_Item__);
		  }
		  else {
		    iVar1 = *(int *)(param1 + 0x20) + -1;
		    if ((DAT_ram_00a648ea & 1) == 0) {
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Selectable__get_Count__);
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Selectable__get_Item__);
		      DAT_ram_00a648ea = 1;
		    }
		    iVar2 = Utils_InputNavigator__SetIndex(param1,param1);
		    iVar4 = *(int *)(iVar2 + 0xc) + -1;
		    iVar5 = iVar1;
		    if (iVar4 < iVar1) {
		      iVar5 = 0;
		    }
		    if (-1 < iVar1) {
		      iVar4 = iVar5;
		    }
		    *(int *)(param1 + 0x20) = iVar4;
		    piVar3 = (int *)System_Linq_Enumerable__ToList_object_
		                              (iVar2,iVar4,
		                               Method_System_Collections_Generic_List_Selectable__get_Item__);
		  }
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x1f0) * 4))(piVar3,*(undefined4 *)(*piVar3 + 500));
		  return;
		}
		*/

		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x56E4", Offset = "0x56E4", VA = "0x56E4")]
		private void SelectElement(InputAction.CallbackContext ctx)
		{
		/* --- GHIDRA: SelectElement ---
		void Utils_InputNavigator__SelectElement(int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  int *piVar1;
		  int param2_00;
		  
		  if (DAT_ram_00a648ea == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Selectable__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Selectable__get_Item__);
		    DAT_ram_00a648ea = '\x01';
		  }
		  param1_00 = Utils_InputNavigator__SetIndex(param1,0);
		  param2_00 = *(int *)(param1_00 + 0xc) + -1;
		  if (param2 < 0) {
		    *(int *)(param1 + 0x20) = param2_00;
		  }
		  else if (param2_00 < param2) {
		    param2_00 = 0;
		    *(undefined4 *)(param1 + 0x20) = 0;
		  }
		  else {
		    *(int *)(param1 + 0x20) = param2;
		    param2_00 = param2;
		  }
		  piVar1 = (int *)System_Linq_Enumerable__ToList_object_
		                            (param1_00,param2_00,
		                             Method_System_Collections_Generic_List_Selectable__get_Item__);
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x1f0) * 4))(piVar1,*(undefined4 *)(*piVar1 + 500));
		  return;
		}
		*/

		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x56E5", Offset = "0x56E5", VA = "0x56E5")]
		public void SetIndex(int value)
		{
		/* --- GHIDRA: SetIndex ---
		undefined4 Utils_InputNavigator__SetIndex(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param2_00;
		  uint uVar4;
		  
		  if (DAT_ram_00a648eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Selectable__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Selectable__Clear__);
		    DAT_ram_00a648eb = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x1c);
		  iVar3 = *(int *)(iVar2 + 0xc);
		  *(undefined4 *)(iVar2 + 0xc) = 0;
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  if (0 < iVar3) {
		    func_ii_2064(*(undefined4 *)(iVar2 + 8),0,iVar3,0);
		  }
		  iVar2 = *(int *)(param1 + 0x18);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar3 = 0;
		    do {
		      iVar1 = func_ii_12174(*(undefined4 *)(iVar2 + iVar3 * 4 + 0x10),0);
		      iVar2 = Method_System_Collections_Generic_List_Selectable__Add__;
		      if (iVar1 != 0) {
		        param2_00 = *(undefined4 *)(*(int *)(param1 + 0x18) + iVar3 * 4 + 0x10);
		        iVar1 = *(int *)(param1 + 0x1c);
		        *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		        uVar4 = *(uint *)(iVar1 + 0xc);
		        if (uVar4 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		          *(uint *)(iVar1 + 0xc) = uVar4 + 1;
		          *(undefined4 *)(*(int *)(iVar1 + 8) + uVar4 * 4 + 0x10) = param2_00;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar1,param2_00,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38)
		                    );
		        }
		      }
		      iVar3 = iVar3 + 1;
		      iVar2 = *(int *)(param1 + 0x18);
		    } while (iVar3 < *(int *)(iVar2 + 0xc));
		  }
		  return *(undefined4 *)(param1 + 0x1c);
		}
		*/

		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x56E6", Offset = "0x56E6", VA = "0x56E6")]
		private List<Selectable> GetVisibleItems()
		{
		/* --- GHIDRA: GetVisibleItems ---
		void Utils_InputNavigator__GetVisibleItems(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a648ec == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Selectable___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Selectable__TypeInfo);
		    DAT_ram_00a648ec = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_Selectable__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_Selectable___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x56E7", Offset = "0x56E7", VA = "0x56E7")]
		public InputNavigator()
		{
		}

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private InputAction _selectElementAction;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool _selectOnStart;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Selectable[] _items;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x1C")]
		private readonly List<Selectable> _visibleItems;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x20")]
		private int _index;
	}
}
