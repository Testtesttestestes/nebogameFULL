using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UI.Price;
using UnityEngine;

namespace Scripts.UI.Filters
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public class ClampedNumberInput : MonoBehaviour
	{
		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600038E RID: 910 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600038F RID: 911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000012")]
		public event Action<long> InputChangedEvent
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x57C0", Offset = "0x57C0", VA = "0x57C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x57C1", Offset = "0x57C1", VA = "0x57C1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00002D90 File Offset: 0x00000F90
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		public long CurrentValue
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x57C2", Offset = "0x57C2", VA = "0x57C2")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x57C3", Offset = "0x57C3", VA = "0x57C3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x57C4", Offset = "0x57C4", VA = "0x57C4")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Scripts_UI_Filters_ClampedNumberInput__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a62859 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Scripts_UI_Filters_ClampedNumberInput_OnValueChangedHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		    DAT_ram_00a62859 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x130);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(param1_00,param1,Method_Scripts_UI_Filters_ClampedNumberInput_OnValueChangedHandler__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		  return;
		}
		*/

		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x57C5", Offset = "0x57C5", VA = "0x57C5")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x57C6", Offset = "0x57C6", VA = "0x57C6")]
		public void SetMaxValue(long maxValue)
		{
		/* --- GHIDRA: SetMaxValue ---
		void Scripts_UI_Filters_ClampedNumberInput__SetMaxValue
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Price_PriceItemRenderer__SetIcon(*(undefined4 *)(param1 + 0x14),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x57C7", Offset = "0x57C7", VA = "0x57C7")]
		public void Init(string iconAssetId)
		{
		/* --- GHIDRA: Init ---
		void Scripts_UI_Filters_ClampedNumberInput__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  uint param2_01;
		  longlong local_10;
		  longlong local_8;
		  
		  local_8 = 0;
		  iVar1 = System_Collections_Specialized_NameValueCollection__get_Item(param2,&local_8,0);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_4769(param2,0);
		    if (iVar1 == 0) {
		      local_10 = *(longlong *)(param1 + 0x38);
		      goto code_r0x820f9f9c;
		    }
		    local_10 = 0;
		  }
		  else {
		    local_10 = local_8;
		    if (*(longlong *)(param1 + 0x20) <= local_8) {
		      local_10 = *(longlong *)(param1 + 0x20);
		    }
		  }
		  *(longlong *)(param1 + 0x38) = local_10;
		code_r0x820f9f9c:
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  param2_00 = UnityEngine_GameObject__SetActive(&local_10,0);
		  TMPro_TMP_InputField__set_text(param1_00,param2_00,0);
		  if (*(longlong *)(param1 + 0x38) < *(longlong *)(param1 + 0x28)) {
		    param2_01 = 0;
		  }
		  else {
		    param2_01 = (uint)(*(longlong *)(param1 + 0x38) <= *(longlong *)(param1 + 0x30));
		  }
		  UI_Price_PriceItemRenderer__set_TruncatePrice(*(undefined4 *)(param1 + 0x14),param2_01,0);
		  iVar1 = *(int *)(param1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined8 *)(param1 + 0x38),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1C73", Offset = "0x1C73", VA = "0x1C73")]
		public void UpdateUpperBound(long maxValue)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1C71", Offset = "0x1C71", VA = "0x1C71")]
		public void UpdateLowerBound(long minValue)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1C75", Offset = "0x1C75", VA = "0x1C75")]
		public void SetValue(long value)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x57C8", Offset = "0x57C8", VA = "0x57C8")]
		private void OnValueChangedHandler(string str)
		{
		/* --- GHIDRA: OnValueChangedHandler ---
		void Scripts_UI_Filters_ClampedNumberInput__OnValueChangedHandler(int param1,undefined4 param2)
		
		{
		  uint param2_00;
		  
		  if (*(longlong *)(param1 + 0x38) < *(longlong *)(param1 + 0x28)) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (uint)(*(longlong *)(param1 + 0x38) <= *(longlong *)(param1 + 0x30));
		  }
		  UI_Price_PriceItemRenderer__set_TruncatePrice(*(undefined4 *)(param1 + 0x14),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x57C9", Offset = "0x57C9", VA = "0x57C9")]
		private void ValidateInput()
		{
		/* --- GHIDRA: ValidateInput ---
		void Scripts_UI_Filters_ClampedNumberInput__ValidateInput(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x30) = 0x7fffffffffffffff;
		  *(undefined8 *)(param1 + 0x28) = 0x8000000000000000;
		  *(undefined8 *)(param1 + 0x20) = 0x7fffffffffffffff;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x57CA", Offset = "0x57CA", VA = "0x57CA")]
		public ClampedNumberInput()
		{
		}

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _input;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private PriceItemRenderer _validationRenderer;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x20")]
		private long _maxValue;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x28")]
		private long _lowerBound;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x30")]
		private long _upperBound;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InputChangedEvent ---
		void Scripts_UI_Filters_ClampedNumberInput__add_InputChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62857 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    DAT_ram_00a62857 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_long__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_long__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: set_CurrentValue ---
		void Scripts_UI_Filters_ClampedNumberInput__set_CurrentValue(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  uint param2_00;
		  
		  if (DAT_ram_00a62858 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Scripts_UI_Filters_ClampedNumberInput_OnValueChangedHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		    DAT_ram_00a62858 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x130);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(param1_00,param1,Method_Scripts_UI_Filters_ClampedNumberInput_OnValueChangedHandler__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  if (*(longlong *)(param1 + 0x38) < *(longlong *)(param1 + 0x28)) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (uint)(*(longlong *)(param1 + 0x38) <= *(longlong *)(param1 + 0x30));
		  }
		  UI_Price_PriceItemRenderer__set_TruncatePrice(*(undefined4 *)(param1 + 0x14),param2_00,0);
		  return;
		}
		*/

}
