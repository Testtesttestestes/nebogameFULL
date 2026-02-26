using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Filters
{
	// Token: 0x020001E9 RID: 489
	[Token(Token = "0x20001E9")]
	public class SimpleToggleWithData : MonoBehaviour
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A5")]
		public object Data
		{
			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x5FA2", Offset = "0x5FA2", VA = "0x5FA2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x5FA3", Offset = "0x5FA3", VA = "0x5FA3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001A6")]
		public Toggle Toggle
		{
			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x5FA4", Offset = "0x5FA4", VA = "0x5FA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001A7")]
		public Image BG
		{
			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x5FA5", Offset = "0x5FA5", VA = "0x5FA5")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000E7 RID: 231
		// (add) Token: 0x06000CA3 RID: 3235 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000CA4 RID: 3236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E7")]
		public event Action<SimpleToggleWithData> ToggleEvent
		{
			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x5FA6", Offset = "0x5FA6", VA = "0x5FA6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x5FA7", Offset = "0x5FA7", VA = "0x5FA7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x5FA8", Offset = "0x5FA8", VA = "0x5FA8")]
		public void Init(object data, [Optional] string text)
		{
		/* --- GHIDRA: Init ---
		void UI_Filters_SimpleToggleWithData__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63937 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_SimpleToggleWithData_ToggleClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a63937 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,Method_UI_Filters_SimpleToggleWithData_ToggleClickedEventHandler__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  return;
		}
		*/

		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x5FA9", Offset = "0x5FA9", VA = "0x5FA9")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Filters_SimpleToggleWithData__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a63938 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Filters_SimpleToggleWithData_ToggleClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a63938 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,Method_UI_Filters_SimpleToggleWithData_ToggleClickedEventHandler__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  return;
		}
		*/

		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x5FAA", Offset = "0x5FAA", VA = "0x5FAA")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x5FAB", Offset = "0x5FAB", VA = "0x5FAB")]
		private void ToggleClickedEventHandler(bool enable)
		{
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x5FAC", Offset = "0x5FAC", VA = "0x5FAC")]
		public SimpleToggleWithData()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Filters_SimpleToggleWithData___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a63939 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a63939 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x44,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Toggle _toggle;

		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bg;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BG ---
		void UI_Filters_SimpleToggleWithData__get_BG(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63935 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SimpleToggleWithData__TypeInfo);
		    DAT_ram_00a63935 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_SimpleToggleWithData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SimpleToggleWithData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: add_ToggleEvent ---
		void UI_Filters_SimpleToggleWithData__add_ToggleEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63936 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SimpleToggleWithData__TypeInfo);
		    DAT_ram_00a63936 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_SimpleToggleWithData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SimpleToggleWithData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ToggleEvent ---
		void UI_Filters_SimpleToggleWithData__remove_ToggleEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  UnityEngine_Component__GetComponentInChildren_object_(*(undefined4 *)(param1 + 0x10),param3,0);
		  return;
		}
		*/

}
