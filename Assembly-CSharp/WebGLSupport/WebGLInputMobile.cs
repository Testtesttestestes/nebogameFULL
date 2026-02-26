using System;
using System.Collections;
using System.Collections.Generic;
using AOT;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace WebGLSupport
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public class WebGLInputMobile : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x5644", Offset = "0x5644", VA = "0x5644")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void WebGLSupport_WebGLInputMobile__Awake(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a648a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInputMobile__set_Item__);
		    Mono_Security_ASN1__get_Item(&Method_WebGLSupport_WebGLInputMobile_OnTouchEnd__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInputMobile_TypeInfo);
		    DAT_ram_00a648a7 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == -1) {
		    uVar1 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke(uVar1,0,Method_WebGLSupport_WebGLInputMobile_OnTouchEnd__,0);
		    uVar1 = unnamed_function_1434(uVar1);
		    uVar1 = import::env::WebGLInputMobileRegister(uVar1);
		    *(undefined4 *)(param1 + 0x10) = uVar1;
		    if (*(int *)(WebGLSupport_WebGLInputMobile_TypeInfo + 0x74) == 0) {
		      func_ii_306000(WebGLSupport_WebGLInputMobile_TypeInfo);
		      uVar1 = *(undefined4 *)(param1 + 0x10);
		    }
		    Gameplay_Inventory_View_Info_InfoBox_TitleIconLoaderValueRow__set_Value
		              (**(undefined4 **)(WebGLSupport_WebGLInputMobile_TypeInfo + 0x5c),uVar1,param1,
		               Method_System_Collections_Generic_Dictionary_int__WebGLInputMobile__set_Item__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x5645", Offset = "0x5645", VA = "0x5645", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerDown ---
		int WebGLSupport_WebGLInputMobile__OnPointerDown(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a648a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInputMobile__RegisterOnFocusOut_d__5_TypeInfo);
		    DAT_ram_00a648a9 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(WebGLSupport_WebGLInputMobile__RegisterOnFocusOut_d__5_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x4BB2", Offset = "0x4BB2", VA = "0x4BB2")]
		[MonoPInvokeCallback(typeof(Action<int>))]
		private static void OnTouchEnd(int id)
		{
		/* --- GHIDRA: OnTouchEnd ---
		void WebGLSupport_WebGLInputMobile__OnTouchEnd(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a648aa == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_WebGLInput___);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInputMobile__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInputMobile__get_Item__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInputMobile_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11915);
		    DAT_ram_00a648aa = '\x01';
		  }
		  local_4 = param1;
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  uVar1 = func_ii_4419(StringLiteral_11915,uVar1,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  if (*(int *)(WebGLSupport_WebGLInputMobile_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInputMobile_TypeInfo);
		  }
		  param1_00 = System_Collections_Generic_Dictionary_int__Int32Enum___get_Count
		                        (**(undefined4 **)(WebGLSupport_WebGLInputMobile_TypeInfo + 0x5c),param1,
		                         Method_System_Collections_Generic_Dictionary_int__WebGLInputMobile__get_Item__
		                        );
		  uVar1 = func_ii_5677(param1_00,Method_UnityEngine_Component_GetComponent_WebGLInput___);
		  WebGLSupport_WebGLInput__GetScreenCoordinates(uVar1,param1);
		  *(undefined4 *)(param1_00 + 0x10) = 0xffffffff;
		  System_Collections_Generic_Dictionary_Enumerator_int__TMP_ResourceManager_FontAssetRef___MoveNext
		            (**(undefined4 **)(WebGLSupport_WebGLInputMobile_TypeInfo + 0x5c),param1,
		             Method_System_Collections_Generic_Dictionary_int__WebGLInputMobile__Remove__);
		  return;
		}
		*/

		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x5646", Offset = "0x5646", VA = "0x5646")]
		private static IEnumerator RegisterOnFocusOut(int id)
		{
			return null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x4BB3", Offset = "0x4BB3", VA = "0x4BB3")]
		[MonoPInvokeCallback(typeof(Action<int>))]
		private static void OnFocusOut(int id)
		{
		/* --- GHIDRA: OnFocusOut ---
		void WebGLSupport_WebGLInputMobile__OnFocusOut(undefined4 param1)
		
		{
		  if (DAT_ram_00a53bac == 0) {
		    DAT_ram_00a53bac = func_ii_2140(s_UnityEngine_Input__ResetInputAxe_ram_0007226a);
		  }
		  (**(code **)((ulonglong)DAT_ram_00a53bac * 4))();
		  return;
		}
		*/

		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x5647", Offset = "0x5647", VA = "0x5647")]
		public WebGLInputMobile()
		{
		/* --- GHIDRA: .ctor ---
		void WebGLSupport_WebGLInputMobile___ctor(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a648ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__WebGLInputMobile___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_int__WebGLInputMobile__TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInputMobile_TypeInfo);
		    DAT_ram_00a648ab = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_int__WebGLInputMobile__TypeInfo);
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_int__WebGLInputMobile___ctor__);
		  **(undefined4 **)(WebGLSupport_WebGLInputMobile_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, WebGLInputMobile> instances;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x10")]
		private int id;
	}
}
