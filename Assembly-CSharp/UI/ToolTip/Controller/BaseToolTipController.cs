using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Controller
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	public abstract class BaseToolTipController : IToolTipController, IDisposable
	{
		// Token: 0x140000D4 RID: 212
		// (add) Token: 0x06000A0B RID: 2571 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A0C RID: 2572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D4")]
		public event Action<IToolTipSource> ShownEvent
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x5D67", Offset = "0x5D67", VA = "0x5D67", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x5D68", Offset = "0x5D68", VA = "0x5D68", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000A0E RID: 2574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014C")]
		public Vector2 RadiusAroundPointer
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x5D69", Offset = "0x5D69", VA = "0x5D69")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x5D6A", Offset = "0x5D6A", VA = "0x5D6A")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x5D6B", Offset = "0x5D6B", VA = "0x5D6B", Slot = "9")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void UI_ToolTip_Controller_BaseToolTipController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined8 *param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59995 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__TypeInfo);
		    DAT_ram_00a59995 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine___ctor__);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  *(undefined4 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  *(undefined8 *)(param1 + 0x20) = *param4;
		  return;
		}
		*/

		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x5D6C", Offset = "0x5D6C", VA = "0x5D6C")]
		public BaseToolTipController(Canvas canvas, RectTransform layer, Vector2 padding)
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Controller_BaseToolTipController___ctor(int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  undefined4 param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a59996 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_IToolTipDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_IToolTipSource_TypeInfo);
		    DAT_ram_00a59996 = '\x01';
		  }
		  if (param1[4] != 0) {
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0x118) * 4))
		              (param1,param1[4],*(undefined4 *)(*param1 + 0x11c));
		  }
		  param1[4] = (int)param2;
		  uVar1 = 0;
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (UI_ToolTip_IToolTipSource_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8109ba90;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,UI_ToolTip_IToolTipSource_TypeInfo,0);
		code_r0x8109ba90:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (UI_ToolTip_IToolTipDataProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8109bb10;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,UI_ToolTip_IToolTipDataProvider_TypeInfo,0);
		code_r0x8109bb10:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xf0) * 4))
		                        (piVar3,param1[6],*(undefined4 *)(*piVar3 + 0xf4));
		  iVar4 = func_ii_5677(param1_00,Method_UnityEngine_Component_GetComponent_RectTransform___);
		  param1[5] = iVar4;
		  iVar4 = param1[3];
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param1[4],*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x5D6D", Offset = "0x5D6D", VA = "0x5D6D", Slot = "10")]
		public virtual void Show(IToolTipSource source)
		{
		/* --- GHIDRA: Show ---
		void UI_ToolTip_Controller_BaseToolTipController__Show(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x10),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x5D6E", Offset = "0x5D6E", VA = "0x5D6E")]
		protected void OnTooltipShown()
		{
		/* --- GHIDRA: OnTooltipShown ---
		void UI_ToolTip_Controller_BaseToolTipController__OnTooltipShown
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59997 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59997 = '\x01';
		  }
		  if (param2 == *(int *)(param1 + 0x10)) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar1,0);
		    *(undefined8 *)(param1 + 0x10) = 0;
		    if (DAT_ram_00a5999a == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__Remove__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__get_Item__
		                );
		      DAT_ram_00a5999a = '\x01';
		    }
		    uVar1 = System_Data_DataRelationCollection__Add
		                      (*(undefined4 *)(param1 + 8),param2,
		                       Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__get_Item__
		                      );
		    System_Linq_Enumerable__First_KeyValuePair_object__object__
		              (*(undefined4 *)(param1 + 8),param2,
		               Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__Remove__);
		    func_ii_7950(uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x5D6F", Offset = "0x5D6F", VA = "0x5D6F", Slot = "11")]
		public virtual void Hide(IToolTipSource source)
		{
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x5D70", Offset = "0x5D70", VA = "0x5D70")]
		protected void SetCurrentView(RectTransform view)
		{
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x5D71", Offset = "0x5D71", VA = "0x5D71")]
		protected void SetCurrentSource(IToolTipSource dataProvider)
		{
		/* --- GHIDRA: SetCurrentSource ---
		void UI_ToolTip_Controller_BaseToolTipController__SetCurrentSource
		               (int param1,undefined8 *param2,undefined8 *param3,undefined4 param4)
		
		{
		  float fVar1;
		  undefined8 uVar2;
		  
		  uVar2 = *param2;
		  fVar1 = UnityEngine_Canvas__get_pixelRect(*(undefined4 *)(param1 + 0x1c),0);
		  *param3 = CONCAT44(fVar1 * (float)((ulonglong)uVar2 >> 0x20),fVar1 * (float)uVar2);
		  return;
		}
		*/

		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x5D72", Offset = "0x5D72", VA = "0x5D72")]
		protected void GetContentSize(in Vector2 contentSize, out Vector2 result)
		{
		/* --- GHIDRA: GetContentSize ---
		void UI_ToolTip_Controller_BaseToolTipController__GetContentSize
		               (int param1,float *param2,undefined4 param3,float *param4,undefined4 param5)
		
		{
		  bool bVar1;
		  bool bVar2;
		  float fVar3;
		  float fVar4;
		  int iVar5;
		  float fVar6;
		  float fVar7;
		  float fVar8;
		  undefined8 uVar9;
		  float fVar10;
		  float fVar11;
		  float fVar12;
		  float fVar13;
		  float fVar14;
		  undefined1 auStack_10 [8];
		  float4 local_8;
		  float4 local_4;
		  
		  uVar9 = *(undefined8 *)(param1 + 0x28);
		  fVar3 = UnityEngine_Canvas__get_pixelRect(*(undefined4 *)(param1 + 0x1c),0);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(auStack_10,param3,0);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(auStack_10,param3,0);
		  fVar4 = UnityEngine_Canvas__get_pixelRect(*(undefined4 *)(param1 + 0x1c),0);
		  fVar6 = *param2;
		  fVar7 = param2[1];
		  param4[2] = 0.0;
		  fVar10 = (float)local_4 * fVar4;
		  fVar11 = fVar10 * 0.5;
		  fVar14 = fVar3 * (float)((ulonglong)uVar9 >> 0x20);
		  param4[1] = fVar11 + fVar7 + fVar14 * 0.70710677;
		  fVar3 = fVar3 * (float)uVar9;
		  fVar4 = (float)local_8 * fVar4;
		  fVar13 = fVar4 * 0.5;
		  *param4 = fVar6 + fVar3 * 0.70710677 + fVar13;
		  fVar8 = fVar4 + fVar3 + fVar6;
		  bVar2 = (fVar6 - fVar3) - fVar4 < *(float *)(param1 + 0x20);
		  iVar5 = UnityEngine_RefreshRate__ToString(0);
		  fVar4 = (float)iVar5 - *(float *)(param1 + 0x20);
		  if (bVar2 || fVar4 < fVar8) {
		    fVar12 = (fVar6 - fVar3) - fVar13;
		    if (fVar8 <= fVar4) {
		      fVar12 = fVar3 + fVar6 + fVar13;
		    }
		    *param4 = fVar12;
		  }
		  iVar5 = UnityEngine_Screen__get_width(0);
		  fVar6 = *(float *)(param1 + 0x24);
		  fVar3 = (float)iVar5 - fVar6;
		  bVar1 = (fVar7 - fVar14) - fVar10 < fVar6;
		  fVar10 = fVar10 + fVar14 + fVar7;
		  if (bVar1 || fVar3 < fVar10) {
		    fVar6 = (fVar7 - fVar14) - fVar11;
		    if (fVar10 <= fVar3) {
		      fVar6 = fVar11 + fVar14 + fVar7;
		    }
		    param4[1] = fVar6;
		  }
		  if ((bVar2) && (fVar4 < fVar8)) {
		    iVar5 = UnityEngine_RefreshRate__ToString(0);
		    *param4 = (float)(iVar5 / 2);
		  }
		  if ((bVar1) && (fVar3 < fVar10)) {
		    iVar5 = UnityEngine_Screen__get_width(0);
		    param4[1] = (float)(iVar5 / 2);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x5D73", Offset = "0x5D73", VA = "0x5D73")]
		public void GetPosition(in Vector3 center, RectTransform target, out Vector3 result)
		{
		/* --- GHIDRA: GetPosition ---
		int UI_ToolTip_Controller_BaseToolTipController__GetPosition
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59998 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_ToolTip_Controller_BaseToolTipController__UpdateToolTipPositionCoroutine_d__22_TypeInfo
		              );
		    DAT_ram_00a59998 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    UI_ToolTip_Controller_BaseToolTipController__UpdateToolTipPositionCoroutine_d__22_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x5D74", Offset = "0x5D74", VA = "0x5D74")]
		protected IEnumerator UpdateToolTipPositionCoroutine(RectTransform target)
		{
		/* --- GHIDRA: UpdateToolTipPositionCoroutine ---
		void UI_ToolTip_Controller_BaseToolTipController__UpdateToolTipPositionCoroutine
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a59999 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__Add__);
		    DAT_ram_00a59999 = '\x01';
		  }
		  if (DAT_ram_00a59998 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_ToolTip_Controller_BaseToolTipController__UpdateToolTipPositionCoroutine_d__22_TypeInfo
		              );
		    DAT_ram_00a59998 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        UI_ToolTip_Controller_BaseToolTipController__UpdateToolTipPositionCoroutine_d__22_TypeInfo
		                        );
		  *(int *)(param1_00 + 0x14) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  *(undefined4 *)(param1_00 + 0x10) = param3;
		  param3_00 = Utils_CoroutineSource__GetMono(param1_00,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (*(undefined4 *)(param1 + 8),param2,param3_00,
		             Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__Add__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x5D75", Offset = "0x5D75", VA = "0x5D75")]
		protected void StartUpdateToolTipPositionCoroutine(IToolTipSource source, RectTransform target)
		{
		/* --- GHIDRA: StartUpdateToolTipPositionCoroutine ---
		void UI_ToolTip_Controller_BaseToolTipController__StartUpdateToolTipPositionCoroutine
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5999a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__get_Item__);
		    DAT_ram_00a5999a = '\x01';
		  }
		  param1_00 = System_Data_DataRelationCollection__Add
		                        (*(undefined4 *)(param1 + 8),param2,
		                         Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__get_Item__
		                        );
		  System_Linq_Enumerable__First_KeyValuePair_object__object__
		            (*(undefined4 *)(param1 + 8),param2,
		             Method_System_Collections_Generic_Dictionary_IToolTipSource__Coroutine__Remove__);
		  func_ii_7950(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x5D76", Offset = "0x5D76", VA = "0x5D76")]
		protected void StopUpdateToolTipPositionCoroutine(IToolTipSource source)
		{
		}

		// Token: 0x06000A1B RID: 2587
		[Token(Token = "0x6000A1B")]
		protected abstract void GetPointerPosition(out Vector3 position);

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<IToolTipSource, Coroutine> _coroutines;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x10")]
		protected IToolTipSource _currentSource;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x14")]
		protected RectTransform _currentView;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x18")]
		public readonly RectTransform Layer;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x1C")]
		public readonly Canvas Canvas;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x20")]
		public readonly Vector2 Padding;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ShownEvent ---
		void UI_ToolTip_Controller_BaseToolTipController__add_ShownEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59994 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IToolTipSource__TypeInfo);
		    DAT_ram_00a59994 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IToolTipSource__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IToolTipSource__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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
