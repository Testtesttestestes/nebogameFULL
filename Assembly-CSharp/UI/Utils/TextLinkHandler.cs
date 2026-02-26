using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Utils
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	[RequireComponent(typeof(TextMeshProUGUI))]
	public class TextLinkHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x140000D0 RID: 208
		// (add) Token: 0x0600090B RID: 2315 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600090C RID: 2316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D0")]
		public event EventHandler<TMP_LinkInfo> LinkClickEvent
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x5C8A", Offset = "0x5C8A", VA = "0x5C8A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x5C8B", Offset = "0x5C8B", VA = "0x5C8B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x5C8C", Offset = "0x5C8C", VA = "0x5C8C")]
		public TextMeshProUGUI GetTextField()
		{
		/* --- GHIDRA: GetTextField ---
		void UI_Utils_TextLinkHandler__GetTextField(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined8 uVar3;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b8ba == '\0') {
		    Mono_Security_ASN1__get_Item(&TMPro_TMP_TextUtilities_TypeInfo);
		    DAT_ram_00a5b8ba = '\x01';
		  }
		  if (DAT_ram_00a5b8b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		    DAT_ram_00a5b8b9 = '\x01';
		  }
		  if (param1[4] == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		    param1[4] = iVar1;
		  }
		  else {
		    iVar1 = param1[4];
		  }
		  uVar3 = *(undefined8 *)(param2 + 200);
		  if (*(int *)(TMPro_TMP_TextUtilities_TypeInfo + 0x74) == 0) {
		    func_ii_306000(TMPro_TMP_TextUtilities_TypeInfo);
		  }
		  local_4 = 0;
		  local_10 = 0;
		  local_18 = uVar3;
		  local_c = (int)uVar3;
		  local_8 = (int)((ulonglong)uVar3 >> 0x20);
		  iVar2 = TMPro_TMP_TextUtilities__FindIntersectingLine(iVar1,&local_18,0,0);
		  if (iVar2 != -1) {
		    iVar1 = TMPro_TMP_Text__set_margin(iVar1,0);
		    iVar1 = *(int *)(iVar1 + 0x34) + iVar2 * 0x1c;
		    local_20 = *(undefined4 *)(iVar1 + 0x28);
		    local_28 = *(undefined8 *)(iVar1 + 0x20);
		    local_30 = *(undefined8 *)(iVar1 + 0x18);
		    local_38 = *(undefined8 *)(iVar1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		              (param1,&local_38,*(undefined4 *)(*param1 + 0xec));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x5C8D", Offset = "0x5C8D", VA = "0x5C8D", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void UI_Utils_TextLinkHandler__OnPointerClick(int param1,undefined8 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  if (iVar1 != 0) {
		    local_8 = *(undefined4 *)(param2 + 3);
		    local_10 = param2[2];
		    local_18 = param2[1];
		    local_20 = *param2;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,&local_20,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x5C8E", Offset = "0x5C8E", VA = "0x5C8E", Slot = "5")]
		protected virtual void Handle(TMP_LinkInfo linkInfo)
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x5C8F", Offset = "0x5C8F", VA = "0x5C8F")]
		public TextLinkHandler()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Utils_TextLinkHandler___ctor(int param1,undefined8 *param2,undefined4 param3)
		
		{
		  float fVar1;
		  float4 fVar2;
		  float4 fVar3;
		  int *param1_00;
		  int iVar4;
		  float fVar5;
		  int param1_01;
		  float fVar6;
		  int iVar7;
		  undefined1 local_10 [8];
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a5b8bb == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    DAT_ram_00a5b8bb = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar4 + 0xc)) {
		    fVar5 = (float)((ulonglong)*param2 >> 0x20);
		    fVar1 = (float)*param2;
		    iVar7 = 0;
		    do {
		      param1_01 = *(int *)(iVar4 + iVar7 * 4 + 0x10);
		      param1_00 = (int *)System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                                   (param1_01,0);
		      if ((param1_00 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *param1_00)) {
		        System_Activator__CreateInstance(param1_00,UnityEngine_RectTransform_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      UnityEngine_RectTransform__remove_reapplyDrivenProperties(local_10,param1_00,0);
		      fVar3 = local_4;
		      fVar2 = local_8;
		      func_ii_7888(local_10,param1_00,0);
		      fVar6 = local_10._0_4_ - (float)fVar2 * 0.5;
		      if ((((fVar6 <= fVar1) && (fVar1 < (float)fVar2 + fVar6)) &&
		          (fVar6 = local_10._4_4_ - (float)fVar3 * 0.5, fVar6 <= fVar5)) &&
		         (fVar5 < (float)fVar3 + fVar6)) {
		        UnityEngine_Events_UnityEvent__GetDelegate(*(undefined4 *)(param1_01 + 0xb4),0);
		        return;
		      }
		      iVar7 = iVar7 + 1;
		    } while (iVar7 < *(int *)(iVar4 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x10")]
		private TextMeshProUGUI _textField;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_LinkClickEvent ---
		void UI_Utils_TextLinkHandler__add_LinkClickEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b8b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_TMP_LinkInfo__TypeInfo);
		    DAT_ram_00a5b8b8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_EventHandler_TMP_LinkInfo__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_TMP_LinkInfo__TypeInfo), iVar2 == 0))
		    break;
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


		/* --- GHIDRA: remove_LinkClickEvent ---
		undefined4 UI_Utils_TextLinkHandler__remove_LinkClickEvent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b8b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		    DAT_ram_00a5b8b9 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) != 0) {
		    return *(undefined4 *)(param1 + 0x10);
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return uVar1;
		}
		*/

}
