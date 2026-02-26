using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GameEvents.View
{
	// Token: 0x02000781 RID: 1921
	[Token(Token = "0x2000781")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Toggle))]
	public class ToggleTextColorSwitcher : MonoBehaviour
	{
		// Token: 0x06002DBA RID: 11706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBA")]
		[Address(RVA = "0x7E38", Offset = "0x7E38", VA = "0x7E38")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_GameEvents_View_ToggleTextColorSwitcher__Start(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5749f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5749f = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 != 0) {
		    iVar1 = 0x18;
		    if (*(char *)(*(int *)(param1 + 0x10) + 0xc4) == '\0') {
		      iVar1 = 0x28;
		    }
		    local_18 = ((undefined8 *)(param1 + iVar1))[1];
		    local_20 = *(undefined8 *)(param1 + iVar1);
		    iVar1 = **(int **)(param1 + 0x14);
		    local_10 = local_20;
		    local_8 = local_18;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		              (*(int **)(param1 + 0x14),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBB")]
		[Address(RVA = "0x7E39", Offset = "0x7E39", VA = "0x7E39")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_GameEvents_View_ToggleTextColorSwitcher__OnEnable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a574a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_View_ToggleTextColorSwitcher_OnValueChanged__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a574a0 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 != 0) {
		    param1_00 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xc0);
		    uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		    UnityEngine_UI_Toggle__set_group
		              (uVar2,param1,Method_Gameplay_GameEvents_View_ToggleTextColorSwitcher_OnValueChanged__
		               ,0);
		    UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		              (param1_00,uVar2,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBC")]
		[Address(RVA = "0x7E3A", Offset = "0x7E3A", VA = "0x7E3A")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GameEvents_View_ToggleTextColorSwitcher__OnDestroy
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar1 = 0x18;
		  if (param2 == 0) {
		    iVar1 = 0x28;
		  }
		  local_18 = ((undefined8 *)(param1 + iVar1))[1];
		  local_20 = *(undefined8 *)(param1 + iVar1);
		  iVar1 = **(int **)(param1 + 0x14);
		  local_10 = local_20;
		  local_8 = local_18;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x14),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBD")]
		[Address(RVA = "0x7E3B", Offset = "0x7E3B", VA = "0x7E3B")]
		private void OnValueChanged(bool value)
		{
		/* --- GHIDRA: OnValueChanged ---
		void Gameplay_GameEvents_View_ToggleTextColorSwitcher__OnValueChanged(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x28) = 0x3f8000003f800000;
		  *(undefined8 *)(param1 + 0x18) = 0x3f8000003f800000;
		  *(undefined8 *)(param1 + 0x30) = 0x3f8000003f800000;
		  *(undefined8 *)(param1 + 0x20) = 0x3f8000003f800000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DBE")]
		[Address(RVA = "0x7E3C", Offset = "0x7E3C", VA = "0x7E3C")]
		public ToggleTextColorSwitcher()
		{
		}

		// Token: 0x04001918 RID: 6424
		[Token(Token = "0x4001918")]
		[FieldOffset(Offset = "0x10")]
		private Toggle _toggle;

		// Token: 0x04001919 RID: 6425
		[Token(Token = "0x4001919")]
		[FieldOffset(Offset = "0x14")]
		private TextMeshProUGUI _label;

		// Token: 0x0400191A RID: 6426
		[Token(Token = "0x400191A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _isOnColor;

		// Token: 0x0400191B RID: 6427
		[Token(Token = "0x400191B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _isOffColor;
	}
}
