using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UI.ToolTip.Controller;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;

namespace UI.ToolTip
{
	// Token: 0x0200013B RID: 315
	[Token(Token = "0x200013B")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(LongTap))]
	public class ToolTip : MonoBehaviour, IToolTipSource, IDisposable, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013E")]
		public IToolTipController ToolTipController
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x5CDC", Offset = "0x5CDC", VA = "0x5CDC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x5CDD", Offset = "0x5CDD", VA = "0x5CDD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700013F")]
		public LongTap LongTap
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x5CDE", Offset = "0x5CDE", VA = "0x5CDE")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x5CDF", Offset = "0x5CDF", VA = "0x5CDF", Slot = "9")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000971")]
		[Address(RVA = "0x5CE0", Offset = "0x5CE0", VA = "0x5CE0", Slot = "7")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000972")]
		[Address(RVA = "0x5CE1", Offset = "0x5CE1", VA = "0x5CE1", Slot = "8")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000973")]
		[Address(RVA = "0x5CE2", Offset = "0x5CE2", VA = "0x5CE2")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000974")]
		[Address(RVA = "0x5CE3", Offset = "0x5CE3", VA = "0x5CE3")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void UI_ToolTip_ToolTip__OnDisable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = System_Uri___ctor(0);
		  *(undefined4 *)(param1 + 0x10) = *(undefined4 *)(*(int *)(iVar1 + 0x18) + 0x40);
		  return;
		}
		*/

		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000975")]
		[Address(RVA = "0x5CE4", Offset = "0x5CE4", VA = "0x5CE4")]
		private void Awake()
		{
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x5CE5", Offset = "0x5CE5", VA = "0x5CE5")]
		private void Start()
		{
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x5CE6", Offset = "0x5CE6", VA = "0x5CE6")]
		private void HandleStartLongTapEvent(LongTap sender)
		{
		/* --- GHIDRA: HandleStartLongTapEvent ---
		void UI_ToolTip_ToolTip__HandleStartLongTapEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5b8d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_Controller_IToolTipController_TypeInfo);
		    DAT_ram_00a5b8d5 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_ToolTip_Controller_IToolTipController_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x8138f619;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,UI_ToolTip_Controller_IToolTipController_TypeInfo,3);
		code_r0x8138f619:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x5CE7", Offset = "0x5CE7", VA = "0x5CE7")]
		private void HandleCancelLongTapEvent(LongTap sender)
		{
		/* --- GHIDRA: HandleCancelLongTapEvent ---
		void UI_ToolTip_ToolTip__HandleCancelLongTapEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5b8d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_Controller_IToolTipController_TypeInfo);
		    DAT_ram_00a5b8d4 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_ToolTip_Controller_IToolTipController_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x8138f4c7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,UI_ToolTip_Controller_IToolTipController_TypeInfo,2);
		code_r0x8138f4c7:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x5CE8", Offset = "0x5CE8", VA = "0x5CE8")]
		private void HandleLongTapEvent(LongTap sender)
		{
		/* --- GHIDRA: HandleLongTapEvent ---
		void UI_ToolTip_ToolTip__HandleLongTapEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5b8d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_Controller_IToolTipController_TypeInfo);
		    DAT_ram_00a5b8d4 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_ToolTip_Controller_IToolTipController_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x8138f570;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,UI_ToolTip_Controller_IToolTipController_TypeInfo,2);
		code_r0x8138f570:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x5CE9", Offset = "0x5CE9", VA = "0x5CE9")]
		private void HandleShow()
		{
		/* --- GHIDRA: HandleShow ---
		void UI_ToolTip_ToolTip__HandleShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5b8d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_Controller_IToolTipController_TypeInfo);
		    DAT_ram_00a5b8d5 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_ToolTip_Controller_IToolTipController_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x8138f6c2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,UI_ToolTip_Controller_IToolTipController_TypeInfo,3);
		code_r0x8138f6c2:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x5CEA", Offset = "0x5CEA", VA = "0x5CEA")]
		private void HandleHide()
		{
		/* --- GHIDRA: HandleHide ---
		undefined4 UI_ToolTip_ToolTip__HandleHide(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b8d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_TryGetComponent_IToolTipDataProvider___);
		    DAT_ram_00a5b8d6 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (param1,&local_4,
		                     Method_UnityEngine_Component_TryGetComponent_IToolTipDataProvider___);
		  if (iVar1 != 0) {
		    return local_4;
		  }
		  uVar2 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData(param1,0);
		  uVar3 = unnamed_function_2232(&StringLiteral_9183);
		  uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar3,uVar2,0);
		  uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar3 = unnamed_function_1417(uVar3);
		  System_String__Concat(uVar3,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_UI_ToolTip_ToolTip_get_ToolTipDataProvider__);
		  func_ii_1050(uVar3,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000140")]
		public IToolTipDataProvider ToolTipDataProvider
		{
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x5CEB", Offset = "0x5CEB", VA = "0x5CEB", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x5CEC", Offset = "0x5CEC", VA = "0x5CEC", Slot = "5")]
		public void GetStartPosition(out Vector3 position)
		{
		/* --- GHIDRA: GetStartPosition ---
		undefined4 UI_ToolTip_ToolTip__GetStartPosition(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = UnityEngine_Awaitable___c____cctor_b__76_1(param1,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x00003798 File Offset: 0x00001998
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000141")]
		public new bool enabled
		{
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x5CED", Offset = "0x5CED", VA = "0x5CED")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x5CEE", Offset = "0x5CEE", VA = "0x5CEE")]
			set
			{
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x5CEF", Offset = "0x5CEF", VA = "0x5CEF")]
		public ToolTip()
		{
		}

		// Token: 0x0400038A RID: 906
		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x14")]
		private LongTap _longTap;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ToolTipController ---
		undefined4 UI_ToolTip_ToolTip__set_ToolTipController(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5b8d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_LongTap___);
		    DAT_ram_00a5b8d3 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) != 0) {
		    return *(undefined4 *)(param1 + 0x14);
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_LongTap___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_ToolTipDataProvider ---
		void UI_ToolTip_ToolTip__get_ToolTipDataProvider(int param1,undefined4 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 uVar2;
		  
		  if (DAT_ram_00a5b8d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_LongTap___);
		    DAT_ram_00a5b8d3 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_LongTap___);
		    *(int *)(param1 + 0x14) = iVar1;
		  }
		  else {
		    iVar1 = *(int *)(param1 + 0x14);
		  }
		  uVar2 = *(undefined8 *)(iVar1 + 0x28);
		  param2[2] = 0;
		  *param2 = (int)uVar2;
		  param2[1] = (int)((ulonglong)uVar2 >> 0x20);
		  return;
		}
		*/


		/* --- GHIDRA: get_enabled ---
		void UI_ToolTip_ToolTip__get_enabled(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  UnityEngine_Object__op_Implicit(param1,param2,0);
		  if (DAT_ram_00a5b8d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_LongTap___);
		    DAT_ram_00a5b8d3 = '\x01';
		  }
		  if (*(int *)(param1 + 0x14) == 0) {
		    param1_00 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_LongTap___);
		    *(undefined4 *)(param1 + 0x14) = param1_00;
		  }
		  else {
		    param1_00 = *(undefined4 *)(param1 + 0x14);
		  }
		  param2_00 = UnityEngine_Awaitable___c____cctor_b__76_1(param1,0);
		  UnityEngine_Object__op_Implicit(param1_00,param2_00,0);
		  return;
		}
		*/

}
