using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	public class SearchInput : MonoBehaviour
	{
		// Token: 0x140000CA RID: 202
		// (add) Token: 0x06000834 RID: 2100 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000835 RID: 2101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000CA")]
		public event Action<string> InputChangedEvent
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x5BF0", Offset = "0x5BF0", VA = "0x5BF0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x5BF1", Offset = "0x5BF1", VA = "0x5BF1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000103")]
		public string FilterValue
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x1D22", Offset = "0x1D22", VA = "0x1D22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000104")]
		public string RawValue
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x5BF2", Offset = "0x5BF2", VA = "0x5BF2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x5BF3", Offset = "0x5BF3", VA = "0x5BF3")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_SearchInput__Awake(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  TMPro_TMP_InputField__set_text(*(undefined4 *)(param1 + 0x10),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x5BF4", Offset = "0x5BF4", VA = "0x5BF4")]
		public void ResetValue()
		{
		/* --- GHIDRA: ResetValue ---
		void UI_SearchInput__ResetValue(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(*(int *)(param1 + 0x10) + 0x160);
		  if ((longlong)*(int *)(iVar2 + 8) < (longlong)(ulonglong)*(uint *)(param1 + 0x14)) {
		    if (*(int *)(param1 + 0x1c) == 0) {
		      *(int *)(param1 + 0x1c) = iVar2;
		      return;
		    }
		    iVar1 = *(int *)(*(int *)(param1 + 0x1c) + 8);
		    *(int *)(param1 + 0x1c) = iVar2;
		    if ((longlong)iVar1 < (longlong)(ulonglong)*(uint *)(param1 + 0x14)) {
		      return;
		    }
		  }
		  else {
		    *(int *)(param1 + 0x1c) = iVar2;
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),iVar2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x5BF5", Offset = "0x5BF5", VA = "0x5BF5")]
		private void OnValueChangedHandler(string arg0)
		{
		/* --- GHIDRA: OnValueChangedHandler ---
		void UI_SearchInput__OnValueChangedHandler(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5b875 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_SearchInput_OnValueChangedHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		    DAT_ram_00a5b875 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x130);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(param1_00,param1,Method_UI_SearchInput_OnValueChangedHandler__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		  return;
		}
		*/

		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x5BF6", Offset = "0x5BF6", VA = "0x5BF6")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_SearchInput__OnDestroy(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x14) = 3;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x5BF7", Offset = "0x5BF7", VA = "0x5BF7")]
		public SearchInput()
		{
		/* --- GHIDRA: .ctor ---
		void UI_SearchInput___ctor(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  undefined4 uVar2;
		  int *param1_01;
		  int iVar3;
		  uint uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5b876 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_GameBgCanvas_ValidateSize__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5b876 = '\x01';
		  }
		  if (DAT_ram_00a5b8f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		    DAT_ram_00a5b8f1 = '\x01';
		  }
		  iVar5 = **(int **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener(uVar2,param1,Method_UI_GameBgCanvas_ValidateSize__,0);
		  if (DAT_ram_00a5b80a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5b80a = '\x01';
		  }
		  param1_00 = *(int *)(iVar5 + 0x10);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,uVar2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar3 = func_ii_4329(iVar5 + 0x10,param1_01,param1_00);
		    bVar1 = iVar3 == param1_00;
		    param1_00 = iVar3;
		    if (bVar1) {
		      iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                        (*(undefined4 *)(param1 + 0x30),0);
		      if ((iVar5 != 0) &&
		         (uVar4 = UnityEngine_Object__DontDestroyOnLoad(*(undefined4 *)(param1 + 0x30),0),
		         (uVar4 & 0x34) == 0x34)) {
		        uVar2 = *(undefined4 *)(param1 + 0x30);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        UnityEngine_Application__get_isPlaying(uVar2,0);
		      }
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

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _input;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private uint _filterMinNumSymbols;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x1C")]
		private string _currentValue;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InputChangedEvent ---
		void UI_SearchInput__add_InputChangedEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b873 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    DAT_ram_00a5b873 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
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


		/* --- GHIDRA: get_RawValue ---
		void UI_SearchInput__get_RawValue(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5b874 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_SearchInput_OnValueChangedHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		    DAT_ram_00a5b874 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x130);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(param1_00,param1,Method_UI_SearchInput_OnValueChangedHandler__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  return;
		}
		*/

}
