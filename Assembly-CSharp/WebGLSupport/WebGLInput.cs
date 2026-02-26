using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AOT;
using Il2CppDummyDll;
using UnityEngine;

namespace WebGLSupport
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public class WebGLInput : MonoBehaviour, IComparable<WebGLInput>
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		public static string CanvasId
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x5660", Offset = "0x5660", VA = "0x5660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x5661", Offset = "0x5661", VA = "0x5661")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x5663", Offset = "0x5663", VA = "0x5663")]
		private IInputField Setup()
		{
		/* --- GHIDRA: Setup ---
		void WebGLSupport_WebGLInput__Setup(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a648b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_WebGLInputMobile___);
		    DAT_ram_00a648b1 = '\x01';
		  }
		  uVar1 = WebGLSupport_WebGLInput___cctor(param1,param1);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  iVar2 = UnityEngine_Application__SetLogCallbackDefined(0);
		  if (iVar2 != 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    UnityEngine_GameObject__GetComponent_object_
		              (uVar1,Method_UnityEngine_GameObject_AddComponent_WebGLInputMobile___);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x5664", Offset = "0x5664", VA = "0x5664")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void WebGLSupport_WebGLInput__Awake(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 param1_00;
		  int iVar7;
		  float fVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  int param4;
		  int *piVar12;
		  int iVar13;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  if (DAT_ram_00a648b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_int__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_int__int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInput__set_Item__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_IInputField_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_WebGLSupport_WebGLInput_OnBlur__);
		    Mono_Security_ASN1__get_Item(&Method_WebGLSupport_WebGLInput_OnEditEnd__);
		    Mono_Security_ASN1__get_Item(&Method_WebGLSupport_WebGLInput_OnFocus__);
		    Mono_Security_ASN1__get_Item(&Method_WebGLSupport_WebGLInput_OnTab__);
		    Mono_Security_ASN1__get_Item(&Method_WebGLSupport_WebGLInput_OnValueChange__);
		    Mono_Security_ASN1__get_Item(&Method_WebGLSupport_WebGLInput_OnWindowBlur__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648b2 = '\x01';
		  }
		  piVar12 = *(int **)(param1 + 0x14);
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x138);
		        goto code_r0x825a0223;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,0xf);
		code_r0x825a0223:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		  WebGLSupport_WebGLInput__OnWindowBlur(&local_10,puVar2,uVar3,puVar2);
		  uVar1 = 0;
		  piVar12 = *(int **)(param1 + 0x14);
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x825a02c8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,0);
		code_r0x825a02c8:
		  uVar1 = 0;
		  iVar13 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		  piVar12 = *(int **)(param1 + 0x14);
		  iVar7 = *piVar12;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x825a034d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,2);
		code_r0x825a034d:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		  iVar7 = 0xe;
		  if (0xe < iVar4) {
		    iVar7 = iVar4;
		  }
		  if (*(char *)(param1 + 0x19) == '\0') {
		    if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Application_TypeInfo);
		    }
		    iVar4 = UnityEngine_Application__SetLogCallbackDefined(0);
		    if (iVar4 == 0) {
		      iVar4 = UnityEngine_Screen__get_width(0);
		      if (ABS((float)iVar4 - (float)local_c) < 2.1474836e+09) {
		        iVar4 = (int)((float)iVar4 - (float)local_c);
		      }
		      else {
		        iVar4 = -0x80000000;
		      }
		      if (ABS((float)local_10) < 2.1474836e+09) {
		        iVar9 = (int)(float)local_10;
		      }
		      else {
		        iVar9 = -0x80000000;
		      }
		      if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		        func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		      }
		      if (DAT_ram_00a648f7 == '\0') {
		        Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		        DAT_ram_00a648f7 = '\x01';
		      }
		      if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		        func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		      }
		      uVar1 = 0;
		      uVar3 = *(undefined4 *)(*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x5c) + 4);
		      piVar12 = *(int **)(param1 + 0x14);
		      iVar10 = *piVar12;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        do {
		          if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xd8)
		            ;
		            goto code_r0x825a0750;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,3);
		code_r0x825a0750:
		      uVar1 = 0;
		      uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		      piVar12 = *(int **)(param1 + 0x14);
		      iVar10 = *piVar12;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        do {
		          if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xe8)
		            ;
		            goto code_r0x825a07d5;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,5);
		code_r0x825a07d5:
		      uVar1 = 0;
		      uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		      piVar12 = *(int **)(param1 + 0x14);
		      iVar10 = *piVar12;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        do {
		          if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 200);
		            goto code_r0x825a085a;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,1);
		code_r0x825a085a:
		      iVar10 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		      if (ABS((float)local_8) < 2.1474836e+09) {
		        iVar11 = (int)(float)local_8;
		      }
		      else {
		        iVar11 = -0x80000000;
		      }
		      param1_00 = unnamed_function_1428(uVar3);
		      uVar5 = unnamed_function_1428(uVar5);
		      uVar6 = unnamed_function_1428(uVar6);
		      uVar3 = import::env::WebGLInputCreate
		                        (param1_00,iVar9,iVar4,iVar11,1,iVar7,uVar5,uVar6,(uint)(iVar10 != 0),
		                         (uint)(iVar13 == 7),1);
		      goto code_r0x825a08bc;
		    }
		  }
		  iVar4 = UnityEngine_Screen__get_width(0);
		  fVar8 = (float)iVar4 - ((float)local_c + (float)local_4);
		  if (ABS(fVar8) < 2.1474836e+09) {
		    iVar4 = (int)fVar8;
		  }
		  else {
		    iVar4 = -0x80000000;
		  }
		  if (ABS((float)local_10) < 2.1474836e+09) {
		    iVar9 = (int)(float)local_10;
		  }
		  else {
		    iVar9 = -0x80000000;
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		  }
		  if (DAT_ram_00a648f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		    DAT_ram_00a648f7 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar3 = *(undefined4 *)(*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x5c) + 4);
		  piVar12 = *(int **)(param1 + 0x14);
		  iVar10 = *piVar12;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xd8);
		        goto code_r0x825a04ae;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,3);
		code_r0x825a04ae:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		  piVar12 = *(int **)(param1 + 0x14);
		  iVar10 = *piVar12;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0xe8);
		        goto code_r0x825a0533;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,5);
		code_r0x825a0533:
		  uVar1 = 0;
		  uVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		  piVar12 = *(int **)(param1 + 0x14);
		  iVar10 = *piVar12;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 200);
		        goto code_r0x825a05b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,1);
		code_r0x825a05b8:
		  iVar10 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		  if (ABS((float)local_4) < 2.1474836e+09) {
		    iVar11 = (int)(float)local_4;
		  }
		  else {
		    iVar11 = -0x80000000;
		  }
		  if (ABS((float)local_8) < 2.1474836e+09) {
		    param4 = (int)(float)local_8;
		  }
		  else {
		    param4 = -0x80000000;
		  }
		  param1_00 = unnamed_function_1428(uVar3);
		  uVar5 = unnamed_function_1428(uVar5);
		  uVar6 = unnamed_function_1428(uVar6);
		  uVar3 = import::env::WebGLInputCreate
		                    (param1_00,iVar9,iVar4,param4,iVar11,iVar7,uVar5,uVar6,(uint)(iVar10 != 0),
		                     (uint)(iVar13 == 7),0);
		code_r0x825a08bc:
		  unnamed_function_1427(param1_00);
		  unnamed_function_1427(uVar5);
		  unnamed_function_1427(uVar6);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		    uVar3 = *(undefined4 *)(param1 + 0x10);
		  }
		  Gameplay_Inventory_View_Info_InfoBox_TitleIconLoaderValueRow__set_Value
		            (**(undefined4 **)(WebGLSupport_WebGLInput_TypeInfo + 0x5c),uVar3,param1,
		             Method_System_Collections_Generic_Dictionary_int__WebGLInput__set_Item__);
		  uVar3 = *(undefined4 *)(param1 + 0x10);
		  piVar12 = *(int **)(param1 + 0x14);
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 200);
		        goto code_r0x825a098d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,1);
		code_r0x825a098d:
		  iVar13 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		  import::env::WebGLInputEnterSubmit(uVar3,(uint)(iVar13 != 2));
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = 0;
		  uVar3 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke(uVar3,0,Method_WebGLSupport_WebGLInput_OnFocus__,0);
		  uVar3 = unnamed_function_1434(uVar3);
		  import::env::WebGLInputOnFocus(uVar5,uVar3);
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  uVar3 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke(uVar3,0,Method_WebGLSupport_WebGLInput_OnBlur__,0);
		  uVar3 = unnamed_function_1434(uVar3);
		  import::env::WebGLInputOnBlur(uVar5,uVar3);
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  uVar3 = unnamed_function_1417(System_Action_int__string__TypeInfo);
		  System_Action_int__int___Invoke(uVar3,0,Method_WebGLSupport_WebGLInput_OnValueChange__,0);
		  uVar3 = unnamed_function_1434(uVar3);
		  import::env::WebGLInputOnValueChange(uVar5,uVar3);
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  uVar3 = unnamed_function_1417(System_Action_int__string__TypeInfo);
		  System_Action_int__int___Invoke(uVar3,0,Method_WebGLSupport_WebGLInput_OnEditEnd__,0);
		  uVar3 = unnamed_function_1434(uVar3);
		  import::env::WebGLInputOnEditEnd(uVar5,uVar3);
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  uVar3 = unnamed_function_1417(System_Action_int__int__TypeInfo);
		  System_Action_int__HierarchyNode___Invoke(uVar3,0,Method_WebGLSupport_WebGLInput_OnTab__,0);
		  uVar3 = unnamed_function_1434(uVar3);
		  import::env::WebGLInputTab(uVar5,uVar3);
		  uVar3 = *(undefined4 *)(param1 + 0x10);
		  piVar12 = *(int **)(param1 + 0x14);
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0xf0);
		        goto code_r0x825a0b05;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,6);
		code_r0x825a0b05:
		  iVar13 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		  if (iVar13 < 1) {
		    uVar5 = 0x80000;
		  }
		  else {
		    piVar12 = *(int **)(param1 + 0x14);
		    iVar7 = *piVar12;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xf0);
		          goto code_r0x825a0b9b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,6);
		code_r0x825a0b9b:
		    if (iVar13 < 1) {
		      uVar3 = 0;
		    }
		    uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		  }
		  import::env::WebGLInputMaxLength(uVar3,uVar5);
		  import::env::WebGLInputFocus(*(undefined4 *)(param1 + 0x10));
		  piVar12 = *(int **)(param1 + 0x14);
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0x130);
		        goto code_r0x825a0c39;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,0xe);
		code_r0x825a0c39:
		  iVar13 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		  if (iVar13 != 0) {
		    uVar1 = 0;
		    uVar3 = *(undefined4 *)(param1 + 0x10);
		    piVar12 = *(int **)(param1 + 0x14);
		    iVar13 = *piVar12;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      do {
		        if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0xd8);
		          goto code_r0x825a0cc5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar12,WebGLSupport_IInputField_TypeInfo,3);
		code_r0x825a0cc5:
		    iVar13 = (**(code **)((ulonglong)*puVar2 * 4))(piVar12,puVar2[1]);
		    import::env::WebGLInputSetSelectionRange(uVar3,0,*(undefined4 *)(iVar13 + 8));
		  }
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,Method_WebGLSupport_WebGLInput_OnWindowBlur__,0);
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  WebGLSupport_WebGLWindow__remove_OnFocusEvent(uVar3,uVar3);
		  return;
		}
		*/

		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x5665", Offset = "0x5665", VA = "0x5665")]
		public void OnSelect()
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x5666", Offset = "0x5666", VA = "0x5666")]
		private void OnWindowBlur()
		{
		/* --- GHIDRA: OnWindowBlur ---
		void WebGLSupport_WebGLInput__OnWindowBlur
		               (float *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  float fVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int iVar8;
		  undefined8 *puVar9;
		  uint uVar10;
		  uint uVar11;
		  undefined4 *puVar12;
		  uint uVar13;
		  float *pfVar14;
		  float fVar15;
		  float *pfVar16;
		  float fVar17;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a648b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponentInParent_Canvas___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3___TypeInfo);
		    DAT_ram_00a648b3 = '\x01';
		  }
		  iVar5 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Vector3___TypeInfo,4);
		  UnityEngine_RectTransform__GetLocalCorners(param3,iVar5,0);
		  uVar6 = UnityEngine_Component__GetComponentInChildren___Il2CppFullySharedGenericType_
		                    (param3,Method_UnityEngine_Component_GetComponentInParent_Canvas___);
		  iVar7 = UnityEngine_Canvas__remove_willRenderCanvases(uVar6,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar8 = UnityEngine_Component__GetComponent_object_(uVar6,0);
		  if (iVar8 == 0) {
		    iVar7 = 0;
		  }
		  if (iVar7 == 0) {
		    uVar13 = *(uint *)(iVar5 + 0xc);
		code_r0x825a1242:
		    if (0 < (int)uVar13) {
		      iVar5 = iVar5 + 0x10;
		      if (uVar13 == 1) {
		        fVar3 = 3.4028235e+38;
		        fVar1 = -3.4028235e+38;
		        uVar10 = 0;
		        fVar2 = -3.4028235e+38;
		        fVar4 = 3.4028235e+38;
		      }
		      else {
		        fVar3 = 3.4028235e+38;
		        fVar1 = -3.4028235e+38;
		        uVar10 = 0;
		        fVar2 = -3.4028235e+38;
		        fVar4 = 3.4028235e+38;
		        uVar11 = 0;
		        do {
		          pfVar14 = (float *)(iVar5 + uVar10 * 0xc);
		          fVar15 = *pfVar14;
		          if (fVar2 <= fVar15) {
		            fVar2 = fVar15;
		          }
		          pfVar16 = (float *)(iVar5 + (uVar10 | 1) * 0xc);
		          fVar17 = *pfVar16;
		          if (fVar2 <= fVar17) {
		            fVar2 = fVar17;
		          }
		          if (fVar15 <= fVar4) {
		            fVar4 = fVar15;
		          }
		          if (fVar17 <= fVar4) {
		            fVar4 = fVar17;
		          }
		          fVar15 = pfVar14[1];
		          if (fVar1 <= fVar15) {
		            fVar1 = fVar15;
		          }
		          fVar17 = pfVar16[1];
		          if (fVar1 <= fVar17) {
		            fVar1 = fVar17;
		          }
		          if (fVar15 <= fVar3) {
		            fVar3 = fVar15;
		          }
		          if (fVar17 <= fVar3) {
		            fVar3 = fVar17;
		          }
		          uVar10 = uVar10 + 2;
		          uVar11 = uVar11 + 2;
		        } while (uVar11 != (uVar13 & 0xfffffffe));
		      }
		      if ((uVar13 & 1) != 0) {
		        pfVar14 = (float *)(iVar5 + uVar10 * 0xc);
		        fVar15 = *pfVar14;
		        if (fVar2 <= fVar15) {
		          fVar2 = fVar15;
		        }
		        if (fVar15 <= fVar4) {
		          fVar4 = fVar15;
		        }
		        fVar15 = pfVar14[1];
		        if (fVar1 <= fVar15) {
		          fVar1 = fVar15;
		        }
		        if (fVar15 <= fVar3) {
		          fVar3 = fVar15;
		        }
		      }
		      goto code_r0x825a13ab;
		    }
		  }
		  else {
		    uVar6 = UnityEngine_Canvas__SetExternalCanvasEnabled(uVar6,0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar7 = UnityEngine_Component__GetComponent_object_(uVar6,0);
		    if (iVar7 == 0) {
		      uVar6 = UnityEngine_Camera__CalculateFrustumCorners(0);
		    }
		    if (0 < *(int *)(iVar5 + 0xc)) {
		      iVar7 = 0;
		      do {
		        iVar8 = iVar5 + iVar7 * 0xc;
		        puVar12 = (undefined4 *)(iVar8 + 0x18);
		        local_20 = *puVar12;
		        puVar9 = (undefined8 *)(iVar8 + 0x10);
		        local_28 = *puVar9;
		        local_10 = local_28;
		        local_8 = local_20;
		        UnityEngine_Camera__ScreenToWorldPoint(&local_1c,uVar6,&local_28,0);
		        *puVar12 = local_14;
		        *puVar9 = local_1c;
		        iVar7 = iVar7 + 1;
		        uVar13 = *(uint *)(iVar5 + 0xc);
		      } while (iVar7 < (int)uVar13);
		      goto code_r0x825a1242;
		    }
		  }
		  fVar2 = -3.4028235e+38;
		  fVar4 = 3.4028235e+38;
		  fVar1 = -3.4028235e+38;
		  fVar3 = 3.4028235e+38;
		code_r0x825a13ab:
		  param1[1] = fVar3;
		  *param1 = fVar4;
		  param1[3] = fVar1 - fVar3;
		  param1[2] = fVar2 - fVar4;
		  return;
		}
		*/

		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x5667", Offset = "0x5667", VA = "0x5667")]
		private Rect GetScreenCoordinates(RectTransform uiElement)
		{
		/* --- GHIDRA: GetScreenCoordinates ---
		void WebGLSupport_WebGLInput__GetScreenCoordinates(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a648b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInput__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInput__Remove__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_IInputField_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_WebGLSupport_WebGLInput_OnWindowBlur__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648b4 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		  }
		  iVar2 = GAFInternal_Core_GAFSetSequenceEvent__subscribe
		                    (**(undefined4 **)(WebGLSupport_WebGLInput_TypeInfo + 0x5c),
		                     *(undefined4 *)(param1 + 0x10),
		                     Method_System_Collections_Generic_Dictionary_int__WebGLInput__ContainsKey__);
		  if (iVar2 != 0) {
		    import::env::WebGLInputDelete(*(undefined4 *)(param1 + 0x10));
		    param1_01 = *(int **)(param1 + 0x14);
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x148);
		          goto code_r0x825a0fa4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,WebGLSupport_IInputField_TypeInfo,0x11);
		code_r0x825a0fa4:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		    if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		      func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_Enumerator_int__TMP_ResourceManager_FontAssetRef___MoveNext
		              (**(undefined4 **)(WebGLSupport_WebGLInput_TypeInfo + 0x5c),
		               *(undefined4 *)(param1 + 0x10),
		               Method_System_Collections_Generic_Dictionary_int__WebGLInput__Remove__);
		    *(undefined4 *)(param1 + 0x10) = 0xffffffff;
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,param1,Method_WebGLSupport_WebGLInput_OnWindowBlur__,0);
		    if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		      func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		    }
		    WebGLSupport_WebGLWindow__add_OnBlurEvent(param1_00,param1_00);
		  }
		  return;
		}
		*/

			return default(Rect);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x5668", Offset = "0x5668", VA = "0x5668")]
		internal void DeactivateInputField()
		{
		/* --- GHIDRA: DeactivateInputField ---
		void WebGLSupport_WebGLInput__DeactivateInputField(undefined4 param1,undefined4 param2)
		
		{
		  WebGLSupport_WebGLInputMobile__OnFocusOut(0);
		  UnityEngine_Input__ResetInputAxes(0,0);
		  return;
		}
		*/

		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x5669", Offset = "0x5669", VA = "0x5669")]
		[MonoPInvokeCallback(typeof(Action<int>))]
		private static void OnFocus(int id)
		{
		/* --- GHIDRA: OnFocus ---
		int WebGLSupport_WebGLInput__OnFocus(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a648b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput__Blur_d__18_TypeInfo);
		    DAT_ram_00a648b6 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(WebGLSupport_WebGLInput__Blur_d__18_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x4BB6", Offset = "0x4BB6", VA = "0x4BB6")]
		[MonoPInvokeCallback(typeof(Action<int>))]
		private static void OnBlur(int id)
		{
		/* --- GHIDRA: OnBlur ---
		void WebGLSupport_WebGLInput__OnBlur(undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a648b7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInput__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInput__get_Item__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_IInputField_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		    DAT_ram_00a648b7 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		  }
		  iVar2 = GAFInternal_Core_GAFSetSequenceEvent__subscribe
		                    (**(undefined4 **)(WebGLSupport_WebGLInput_TypeInfo + 0x5c),param1,
		                     Method_System_Collections_Generic_Dictionary_int__WebGLInput__ContainsKey__);
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		      func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		    }
		    iVar2 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                      (**(undefined4 **)(WebGLSupport_WebGLInput_TypeInfo + 0x5c),param1,
		                       Method_System_Collections_Generic_Dictionary_int__WebGLInput__get_Item__);
		    piVar6 = *(int **)(iVar2 + 0x14);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x128);
		          goto code_r0x825a1b3e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,WebGLSupport_IInputField_TypeInfo,0xd);
		code_r0x825a1b3e:
		    iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    if (iVar7 == 0) {
		      uVar1 = 0;
		      piVar6 = *(int **)(iVar2 + 0x14);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		            goto code_r0x825a1bc4;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,WebGLSupport_IInputField_TypeInfo,4);
		code_r0x825a1bc4:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar6,param2,puVar3[1]);
		    }
		    uVar1 = 0;
		    piVar6 = *(int **)(iVar2 + 0x14);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x825a1c4a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,WebGLSupport_IInputField_TypeInfo,0);
		code_r0x825a1c4a:
		    iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    if (iVar7 == 5) {
		      uVar1 = 0;
		      piVar6 = *(int **)(iVar2 + 0x14);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		            goto code_r0x825a1cd4;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,WebGLSupport_IInputField_TypeInfo,3);
		code_r0x825a1cd4:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      iVar7 = System_String__Split(uVar4,param2,1,0);
		      if (iVar7 == 0) {
		        piVar6 = *(int **)(iVar2 + 0x14);
		        iVar7 = *piVar6;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8)
		              ;
		              goto code_r0x825a1d63;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar6,WebGLSupport_IInputField_TypeInfo,3);
		code_r0x825a1d63:
		        param2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      }
		    }
		    uVar1 = 0;
		    piVar6 = *(int **)(iVar2 + 0x14);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd8);
		          goto code_r0x825a1de9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,WebGLSupport_IInputField_TypeInfo,3);
		code_r0x825a1de9:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    iVar7 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                      (param2,uVar4,0);
		    if (iVar7 != 0) {
		      iVar7 = import::env::WebGLInputSelectionStart(param1);
		      iVar5 = import::env::WebGLInputSelectionEnd(param1);
		      piVar6 = *(int **)(iVar2 + 0x14);
		      iVar8 = *piVar6;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xd8);
		            goto code_r0x825a1e85;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,WebGLSupport_IInputField_TypeInfo,3);
		code_r0x825a1e85:
		      iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      iVar8 = *(int *)(iVar8 + 8) - *(int *)(param2 + 8);
		      uVar1 = 0;
		      piVar6 = *(int **)(iVar2 + 0x14);
		      iVar2 = *piVar6;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd8);
		            goto code_r0x825a1f13;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,WebGLSupport_IInputField_TypeInfo,3);
		code_r0x825a1f13:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      uVar4 = unnamed_function_1428(uVar4);
		      import::env::WebGLInputText(param1,uVar4);
		      unnamed_function_1427(uVar4);
		      import::env::WebGLInputSetSelectionRange(param1,iVar8 + iVar7,iVar8 + iVar5);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x566A", Offset = "0x566A", VA = "0x566A")]
		private static IEnumerator Blur(int id)
		{
		/* --- GHIDRA: Blur ---
		void WebGLSupport_WebGLInput__Blur(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  
		  if (DAT_ram_00a648ba == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInput__ContainsKey__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_IInputField_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		    DAT_ram_00a648ba = '\x01';
		  }
		  piVar7 = *(int **)(param1 + 0x14);
		  if (piVar7 != (int *)0x0) {
		    uVar1 = 0;
		    iVar8 = *piVar7;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x100);
		          goto code_r0x825a28f8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,WebGLSupport_IInputField_TypeInfo,8);
		code_r0x825a28f8:
		    iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		    if (iVar8 != 0) {
		      if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		        func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		      }
		      iVar4 = GAFInternal_Core_GAFSetSequenceEvent__subscribe
		                        (**(undefined4 **)(WebGLSupport_WebGLInput_TypeInfo + 0x5c),
		                         *(undefined4 *)(param1 + 0x10),
		                         Method_System_Collections_Generic_Dictionary_int__WebGLInput__ContainsKey__
		                        );
		      iVar8 = UnityEngine_Application_TypeInfo;
		      if (iVar4 == 0) {
		        if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Application_TypeInfo);
		        }
		        iVar4 = UnityEngine_Application__SetLogCallbackDefined(0);
		        if (iVar4 != 0) {
		          return;
		        }
		        WebGLSupport_WebGLInput__Awake(param1,iVar8);
		      }
		      else {
		        iVar8 = import::env::WebGLInputIsFocus(*(undefined4 *)(param1 + 0x10));
		        if (iVar8 == 0) {
		          import::env::WebGLInputFocus(*(undefined4 *)(param1 + 0x10));
		        }
		      }
		      uVar5 = import::env::WebGLInputSelectionStart(*(undefined4 *)(param1 + 0x10));
		      uVar6 = import::env::WebGLInputSelectionEnd(*(undefined4 *)(param1 + 0x10));
		      iVar8 = import::env::WebGLInputSelectionDirection(*(undefined4 *)(param1 + 0x10));
		      piVar7 = *(int **)(param1 + 0x14);
		      iVar4 = *piVar7;
		      uVar1 = (uint)*(ushort *)(iVar4 + 0xb6);
		      if (iVar8 == -1) {
		        if (uVar1 != 0) {
		          uVar2 = 0;
		          do {
		            if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0x110
		                               );
		              goto code_r0x825a2a20;
		            }
		            uVar2 = uVar2 + 1;
		          } while (uVar1 != uVar2);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar7,WebGLSupport_IInputField_TypeInfo,10);
		code_r0x825a2a20:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar5,puVar3[1]);
		        uVar1 = 0;
		        piVar7 = *(int **)(param1 + 0x14);
		        iVar8 = *piVar7;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x120
		                               );
		              goto code_r0x825a2a9f;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar7,WebGLSupport_IInputField_TypeInfo,0xc);
		code_r0x825a2a9f:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar6,puVar3[1]);
		      }
		      else {
		        if (uVar1 != 0) {
		          uVar2 = 0;
		          do {
		            if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + iVar4 + 0x110
		                               );
		              goto code_r0x825a2b11;
		            }
		            uVar2 = uVar2 + 1;
		          } while (uVar1 != uVar2);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar7,WebGLSupport_IInputField_TypeInfo,10);
		code_r0x825a2b11:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar6,puVar3[1]);
		        uVar1 = 0;
		        piVar7 = *(int **)(param1 + 0x14);
		        iVar8 = *piVar7;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x120
		                               );
		              goto code_r0x825a2b90;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar7,WebGLSupport_IInputField_TypeInfo,0xc);
		code_r0x825a2b90:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar5,puVar3[1]);
		      }
		      uVar1 = 0;
		      piVar7 = *(int **)(param1 + 0x14);
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x150);
		            goto code_r0x825a2c16;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar7,WebGLSupport_IInputField_TypeInfo,0x12);
		code_r0x825a2c16:
		      (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x4BB7", Offset = "0x4BB7", VA = "0x4BB7")]
		[MonoPInvokeCallback(typeof(Action<int, string>))]
		private static void OnValueChange(int id, string value)
		{
		/* --- GHIDRA: OnValueChange ---
		void WebGLSupport_WebGLInput__OnValueChange(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a648b8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInput__get_Item__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_IInputField_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		    DAT_ram_00a648b8 = '\x01';
		  }
		  uVar1 = 0;
		  if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		  }
		  iVar2 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                    (**(undefined4 **)(WebGLSupport_WebGLInput_TypeInfo + 0x5c),param1,
		                     Method_System_Collections_Generic_Dictionary_int__WebGLInput__get_Item__);
		  piVar4 = *(int **)(iVar2 + 0x14);
		  iVar2 = *piVar4;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x128);
		        goto code_r0x825a20b9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,WebGLSupport_IInputField_TypeInfo,0xd);
		code_r0x825a20b9:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  if (iVar2 == 0) {
		    if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		      func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		    }
		    iVar2 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                      (**(undefined4 **)(WebGLSupport_WebGLInput_TypeInfo + 0x5c),param1,
		                       Method_System_Collections_Generic_Dictionary_int__WebGLInput__get_Item__);
		    piVar4 = *(int **)(iVar2 + 0x14);
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x825a2176;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,WebGLSupport_IInputField_TypeInfo,4);
		code_r0x825a2176:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar4,param2,puVar3[1]);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x4BB8", Offset = "0x4BB8", VA = "0x4BB8")]
		[MonoPInvokeCallback(typeof(Action<int, string>))]
		private static void OnEditEnd(int id, string value)
		{
		/* --- GHIDRA: OnEditEnd ---
		void WebGLSupport_WebGLInput__OnEditEnd(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a648b9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInput__get_Item__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		    DAT_ram_00a648b9 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		  }
		  param1_00 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                        (**(undefined4 **)(WebGLSupport_WebGLInput_TypeInfo + 0x5c),param1,
		                         Method_System_Collections_Generic_Dictionary_int__WebGLInput__get_Item__);
		  if (*(int *)(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo);
		  }
		  WebGLSupport_WebGLInput_WebGLInputTabFocus__Remove(param1_00,param2,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x4BB9", Offset = "0x4BB9", VA = "0x4BB9")]
		[MonoPInvokeCallback(typeof(Action<int, int>))]
		private static void OnTab(int id, int value)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x566B", Offset = "0x566B", VA = "0x566B")]
		private void Update()
		{
		/* --- GHIDRA: Update ---
		void WebGLSupport_WebGLInput__Update(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a648bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInput__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInput__get_Item__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		    DAT_ram_00a648bb = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		  }
		  iVar1 = GAFInternal_Core_GAFSetSequenceEvent__subscribe
		                    (**(undefined4 **)(WebGLSupport_WebGLInput_TypeInfo + 0x5c),
		                     *(undefined4 *)(param1 + 0x10),
		                     Method_System_Collections_Generic_Dictionary_int__WebGLInput__ContainsKey__);
		  if (iVar1 != 0) {
		    UnityEngine_Input__ResetInputAxes(1,0);
		    WebGLSupport_WebGLInputMobile__OnFocusOut(0);
		    if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		      func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		    }
		    iVar1 = WebGLSupport_WebGLInput_TypeInfo;
		    param1_00 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                          (**(undefined4 **)(WebGLSupport_WebGLInput_TypeInfo + 0x5c),
		                           *(undefined4 *)(param1 + 0x10),
		                           Method_System_Collections_Generic_Dictionary_int__WebGLInput__get_Item__)
		    ;
		    WebGLSupport_WebGLInput__GetScreenCoordinates(param1_00,iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x566C", Offset = "0x566C", VA = "0x566C")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void WebGLSupport_WebGLInput__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a648bc == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo);
		    DAT_ram_00a648bc = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo);
		  }
		  WebGLSupport_WebGLInput___ctor(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x566D", Offset = "0x566D", VA = "0x566D")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void WebGLSupport_WebGLInput__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a648bd == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo);
		    DAT_ram_00a648bd = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo);
		  }
		  if (DAT_ram_00a648c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_WebGLInput__Remove__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo);
		    DAT_ram_00a648c0 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo);
		  }
		  func_ii_4876(**(undefined4 **)(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo + 0x5c),param1,
		               Method_System_Collections_Generic_List_WebGLInput__Remove__);
		  return;
		}
		*/

		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x566E", Offset = "0x566E", VA = "0x566E")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		int WebGLSupport_WebGLInput__OnDisable(int param1,int param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  float4 param2_00;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  float4 local_14;
		  float4 local_10;
		  float4 local_4;
		  
		  if (DAT_ram_00a648be == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_IInputField_TypeInfo);
		    DAT_ram_00a648be = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0x14);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0x138);
		        goto code_r0x825a2f8d;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,0xf);
		code_r0x825a2f8d:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  WebGLSupport_WebGLInput__OnWindowBlur(&local_14,puVar3,uVar4,puVar3);
		  param2_00 = local_10;
		  fVar1 = local_14;
		  uVar2 = 0;
		  piVar5 = *(int **)(param2 + 0x14);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (WebGLSupport_IInputField_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0x138);
		        goto code_r0x825a3029;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,WebGLSupport_IInputField_TypeInfo,0xf);
		code_r0x825a3029:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  WebGLSupport_WebGLInput__OnWindowBlur(&local_14,puVar3,uVar4,puVar3);
		  local_4 = local_10;
		  iVar6 = System_Double__CompareTo(&local_4,(float)param2_00,0);
		  if (iVar6 == 0) {
		    local_4 = fVar1;
		    iVar6 = System_Double__CompareTo(&local_4,(float)local_14,0);
		  }
		  return iVar6;
		}
		*/

		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x566F", Offset = "0x566F", VA = "0x566F", Slot = "4")]
		public int CompareTo(WebGLInput other)
		{
		/* --- GHIDRA: CompareTo ---
		void WebGLSupport_WebGLInput__CompareTo(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x10) = 0xffffffff;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x5670", Offset = "0x5670", VA = "0x5670")]
		public WebGLInput()
		{
		/* --- GHIDRA: .ctor ---
		void WebGLSupport_WebGLInput___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  if (DAT_ram_00a648bf == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_WebGLInput__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_WebGLInput__Sort__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo);
		    DAT_ram_00a648bf = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo);
		  }
		  iVar1 = Method_System_Collections_Generic_List_WebGLInput__Add__;
		  param1_00 = **(int **)(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo + 0x5c);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param1,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  func_ii_15909(**(undefined4 **)(WebGLSupport_WebGLInput_WebGLInputTabFocus_TypeInfo + 0x5c),
		                Method_System_Collections_Generic_List_WebGLInput__Sort__);
		  return;
		}
		*/

		/* --- GHIDRA: .cctor ---
		int WebGLSupport_WebGLInput___cctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a648b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_InputField___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TMP_InputField___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WrappedInputField_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WrappedTMPInputField_TypeInfo);
		    DAT_ram_00a648b0 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_InputField___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_Component__GetComponent_object_(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_InputField___);
		    iVar2 = unnamed_function_1417(WebGLSupport_WrappedInputField_TypeInfo);
		    if (DAT_ram_00a648c5 == '\0') {
		      Mono_Security_ASN1__get_Item(&WebGLSupport_Detail_RebuildChecker_TypeInfo);
		      DAT_ram_00a648c5 = '\x01';
		    }
		    *(undefined4 *)(iVar2 + 8) = uVar1;
		    iVar3 = unnamed_function_1417(WebGLSupport_Detail_RebuildChecker_TypeInfo);
		    *(int *)(iVar3 + 8) = iVar2;
		    *(int *)(iVar2 + 0xc) = iVar3;
		    return iVar2;
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TMP_InputField___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_Component__GetComponent_object_(uVar1,0);
		  if (iVar2 != 0) {
		    uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TMP_InputField___);
		    iVar2 = unnamed_function_1417(WebGLSupport_WrappedTMPInputField_TypeInfo);
		    if (DAT_ram_00a648c8 == '\0') {
		      Mono_Security_ASN1__get_Item(&WebGLSupport_Detail_RebuildChecker_TypeInfo);
		      DAT_ram_00a648c8 = '\x01';
		    }
		    *(undefined4 *)(iVar2 + 8) = uVar1;
		    iVar3 = unnamed_function_1417(WebGLSupport_Detail_RebuildChecker_TypeInfo);
		    *(int *)(iVar3 + 8) = iVar2;
		    *(int *)(iVar2 + 0xc) = iVar3;
		    return iVar2;
		  }
		  uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar4 = unnamed_function_2232(&StringLiteral_4557);
		  System_String__Concat(uVar1,uVar4,0);
		  uVar4 = unnamed_function_2232(&Method_WebGLSupport_WebGLInput_Setup__);
		  func_ii_1050(uVar1,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, WebGLInput> instances;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x10")]
		internal int id;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x14")]
		private IInputField input;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x18")]
		private bool blurBlock;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x19")]
		[Tooltip("show input element on canvas. this will make you select text by drag.")]
		public bool showHtmlElement;

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		private static class WebGLInputTabFocus
		{
			// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x5671", Offset = "0x5671", VA = "0x5671")]
			public static void Add(WebGLInput input)
			{
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x5672", Offset = "0x5672", VA = "0x5672")]
			public static void Remove(WebGLInput input)
			{
			}

			// Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x5673", Offset = "0x5673", VA = "0x5673")]
			public static void OnTab(WebGLInput input, int value)
			{
			}

			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x40000C4")]
			[FieldOffset(Offset = "0x0")]
			private static List<WebGLInput> inputs;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CanvasId ---
		void WebGLSupport_WebGLInput__get_CanvasId(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a648ae == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		    DAT_ram_00a648ae = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		  }
		  *(undefined4 *)(*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x5c) + 4) = param1;
		  return;
		}
		*/


		/* --- GHIDRA: set_CanvasId ---
		void WebGLSupport_WebGLInput__set_CanvasId(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a648af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInput___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_int__WebGLInput__TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27972);
		    DAT_ram_00a648af = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_int__WebGLInput__TypeInfo);
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (uVar1,Method_System_Collections_Generic_Dictionary_int__WebGLInput___ctor__);
		  **(undefined4 **)(WebGLSupport_WebGLInput_TypeInfo + 0x5c) = uVar1;
		  uVar1 = StringLiteral_27972;
		  if (DAT_ram_00a648f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		    DAT_ram_00a648f6 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		  }
		  *(undefined4 *)(*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x5c) + 4) = uVar1;
		  return;
		}
		*/

}
