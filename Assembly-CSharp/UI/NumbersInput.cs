using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	public class NumbersInput : MonoBehaviour
	{
		// Token: 0x140000C9 RID: 201
		// (add) Token: 0x0600082D RID: 2093 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600082E RID: 2094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C9")]
		public event Action<int> InputChangedEvent
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x5BE9", Offset = "0x5BE9", VA = "0x5BE9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x5BEA", Offset = "0x5BEA", VA = "0x5BEA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x17000102")]
		public int CurrentValue
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x5BEB", Offset = "0x5BEB", VA = "0x5BEB")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x5BEC", Offset = "0x5BEC", VA = "0x5BEC")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_NumbersInput__Awake(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 *param2_01;
		  
		  param2_01 = (undefined4 *)(param1 + 0x18);
		  iVar1 = System_Net_WebHeaderCollection__Add(param2,param2_01,0);
		  if (iVar1 == 0) {
		    *(undefined4 *)(param1 + 0x18) = 0;
		    param1_00 = *(undefined4 *)(param1 + 0x10);
		  }
		  else {
		    param1_00 = *(undefined4 *)(param1 + 0x10);
		    if (*(int *)(param1 + 0x18) != 0) {
		      param2_00 = func_ii_4443(param2_01,0);
		      goto code_r0x813892c4;
		    }
		  }
		  param2_00 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		code_r0x813892c4:
		  TMPro_TMP_InputField__set_text(param1_00,param2_00,0);
		  iVar1 = *(int *)(param1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*param2_01,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x5BED", Offset = "0x5BED", VA = "0x5BED")]
		private void OnValueChangedHandler(string str)
		{
		/* --- GHIDRA: OnValueChangedHandler ---
		void UI_NumbersInput__OnValueChangedHandler(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5b871 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_NumbersInput_OnValueChangedHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		    DAT_ram_00a5b871 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x130);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(param1_00,param1,Method_UI_NumbersInput_OnValueChangedHandler__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		  return;
		}
		*/

		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x5BEE", Offset = "0x5BEE", VA = "0x5BEE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x5BEF", Offset = "0x5BEF", VA = "0x5BEF")]
		public NumbersInput()
		{
		/* --- GHIDRA: .ctor ---
		void UI_NumbersInput___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b872 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    DAT_ram_00a5b872 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_string__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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

		}

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _input;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x18")]
		private int _currentValue;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InputChangedEvent ---
		void UI_NumbersInput__add_InputChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b86f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a5b86f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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


		/* --- GHIDRA: get_CurrentValue ---
		void UI_NumbersInput__get_CurrentValue(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5b870 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_NumbersInput_OnValueChangedHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		    DAT_ram_00a5b870 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x130);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(param1_00,param1,Method_UI_NumbersInput_OnValueChangedHandler__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  return;
		}
		*/

}
