using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.ProgressBars
{
	// Token: 0x0200021C RID: 540
	[Token(Token = "0x200021C")]
	public class Filler : MonoBehaviour
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00004068 File Offset: 0x00002268
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C2")]
		public float value
		{
			[Token(Token = "0x6000D6E")]
			[Address(RVA = "0x6051", Offset = "0x6051", VA = "0x6051")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D6F")]
			[Address(RVA = "0x6052", Offset = "0x6052", VA = "0x6052")]
			set
			{
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D70")]
		[Address(RVA = "0x6053", Offset = "0x6053", VA = "0x6053", Slot = "4")]
		public virtual void UpdateLayout()
		{
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D71")]
		[Address(RVA = "0x6054", Offset = "0x6054", VA = "0x6054")]
		public Filler()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_ProgressBars_Filler___ctor(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  float4 fVar2;
		  float4 fVar3;
		  float fVar4;
		  float fVar5;
		  undefined8 local_30;
		  undefined8 local_28;
		  float4 local_20;
		  float4 local_1c;
		  float4 local_18;
		  float4 local_14;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  
		  UnityEngine_RectTransform__set_anchorMax(&local_10,*(undefined4 *)(param1 + 0x1c),0);
		  fVar3 = local_c;
		  fVar2 = local_10;
		  UnityEngine_RectTransform__set_anchorMax(&local_10,*(undefined4 *)(param1 + 0x10),0);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties
		            (&local_10,*(undefined4 *)(param1 + 0x1c),0);
		  fVar4 = UnityEngine_UI_Scrollbar___ctor(*(undefined4 *)(param1 + 0x14),0);
		  fVar5 = *(float *)(*(int *)(param1 + 0x14) + 0xc0);
		  fVar4 = *(float *)(param1 + 0x18) +
		          ((float)local_8 * fVar5 * -0.5 - (float)local_8 * (1.0 - fVar4) * (1.0 - fVar5));
		  bVar1 = 1 < *(uint *)(*(int *)(param1 + 0x14) + 0xb8);
		  local_18 = (float4)fVar4;
		  local_14 = fVar3;
		  if (bVar1) {
		    local_18 = fVar2;
		    local_14 = (float4)fVar4;
		  }
		  local_28 = CONCAT44(local_14,local_18);
		  UnityEngine_RectTransform__get_anchoredPosition(*(undefined4 *)(param1 + 0x1c),&local_28,0);
		  local_20 = (float4)-fVar4;
		  local_1c = local_c;
		  if (bVar1) {
		    local_20 = local_10;
		    local_1c = (float4)-fVar4;
		  }
		  local_30 = CONCAT44(local_1c,local_20);
		  UnityEngine_RectTransform__get_anchoredPosition(*(undefined4 *)(param1 + 0x10),&local_30,0);
		  return;
		}
		*/

		}

		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x40006AF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected RectTransform _rectTransform;

		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x40006B0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Scrollbar _scrollbar;

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x18")]
		public float overflowSize;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_value ---
		void UI_Elements_ProgressBars_Filler__get_value(int param1,float param2,undefined4 param3)
		
		{
		  UnityEngine_UI_Scrollbar__get_value(*(undefined4 *)(param1 + 0x14),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_value ---
		void UI_Elements_ProgressBars_Filler__set_value(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  float fVar2;
		  float4 *pfVar3;
		  undefined8 local_28;
		  float4 local_20;
		  float4 local_1c;
		  float4 local_18;
		  undefined4 local_14;
		  float4 local_10;
		  undefined4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a6397b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    DAT_ram_00a6397b = '\x01';
		  }
		  uVar1 = UnityEngine_Transform__set_parent(*(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4),0);
		  uVar1 = func_ii_5677(uVar1,Method_UnityEngine_Component_GetComponent_RectTransform___);
		  param2_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(*(int *)(param1 + 0x14) + 0xb8) < 2) {
		    UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_10,uVar1,0);
		    fVar2 = *(float *)(param1 + 0x18);
		    UnityEngine_RectTransform__set_anchoredPosition(&local_10,*(undefined4 *)(param1 + 0x10),0);
		    local_18 = (float4)((float)local_8 + fVar2);
		    local_14 = local_c;
		    pfVar3 = &local_18;
		  }
		  else {
		    UnityEngine_RectTransform__set_anchoredPosition(&local_10,param2_00,0);
		    UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_10,uVar1,0);
		    local_20 = local_10;
		    local_1c = (float4)((float)local_4 + *(float *)(param1 + 0x18));
		    pfVar3 = &local_20;
		  }
		  local_28 = *(undefined8 *)pfVar3;
		  UnityEngine_RectTransform__get_sizeDelta(param2_00,&local_28,0);
		  return;
		}
		*/

}
