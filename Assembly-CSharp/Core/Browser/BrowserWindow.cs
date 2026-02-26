using System;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Browser
{
	// Token: 0x0200110D RID: 4365
	[Token(Token = "0x200110D")]
	public class BrowserWindow : ClosableBaseWindow<BrowserWindow.BrowserWindowArgs>
	{
		// Token: 0x170014A2 RID: 5282
		// (get) Token: 0x060065D7 RID: 26071 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170014A2")]
		public override string WindowId
		{
			[Token(Token = "0x60065D7")]
			[Address(RVA = "0xB160", Offset = "0xB160", VA = "0xB160", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060065D8 RID: 26072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D8")]
		[Address(RVA = "0xB161", Offset = "0xB161", VA = "0xB161")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Core_Browser_BrowserWindow__OnDestroy(int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  float fVar3;
		  undefined4 *puVar4;
		  int param1_01;
		  int param1_02;
		  int param1_03;
		  int param1_04;
		  int param1_05;
		  int param1_06;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a8dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BrowserWindow_BrowserWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_WebViewObject___);
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Common_Settings_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Browser_BrowserWindow___c__OnShow_b__6_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Browser_BrowserWindow___c__OnShow_b__6_1__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Browser_BrowserWindow___c__OnShow_b__6_2__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Browser_BrowserWindow___c__OnShow_b__6_3__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Browser_BrowserWindow___c__OnShow_b__6_4__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Browser_BrowserWindow___c__OnShow_b__6_5__);
		    Mono_Security_ASN1__get_Item(&Core_Browser_BrowserWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5a8dc = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_BrowserWindow_BrowserWindowArgs__OnShow__);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  uVar1 = UnityEngine_GameObject__GetComponent_object_
		                    (uVar1,Method_UnityEngine_GameObject_AddComponent_WebViewObject___);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  iVar2 = UnityEngine_RefreshRate__ToString(0);
		  if (*(int *)(ScreenAdaptation_Common_Settings_TypeInfo + 0x74) == 0) {
		    func_ii_306000(ScreenAdaptation_Common_Settings_TypeInfo);
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x3c);
		  fVar3 = *(float *)(**(int **)(ScreenAdaptation_Common_Settings_TypeInfo + 0x5c) + 8);
		  if (*(int *)(Core_Browser_BrowserWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Browser_BrowserWindow___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c);
		  param1_01 = puVar4[1];
		  param1_00 = Core_Browser_BrowserWindow___c_TypeInfo;
		  if (param1_01 == 0) {
		    if (*(int *)(Core_Browser_BrowserWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Browser_BrowserWindow___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar4;
		    param1_01 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,uVar5,Method_Core_Browser_BrowserWindow___c__OnShow_b__6_0__,0);
		    param1_00 = Core_Browser_BrowserWindow___c_TypeInfo;
		    *(int *)(*(int *)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c) + 4) = param1_01;
		  }
		  if (*(int *)(param1_00 + 0x74) == 0) {
		    func_ii_306000(param1_00);
		    param1_00 = Core_Browser_BrowserWindow___c_TypeInfo;
		  }
		  puVar4 = *(undefined4 **)(param1_00 + 0x5c);
		  param1_02 = puVar4[2];
		  if (param1_02 == 0) {
		    if (*(int *)(param1_00 + 0x74) == 0) {
		      func_ii_306000(param1_00);
		      puVar4 = *(undefined4 **)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar4;
		    param1_02 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_02,uVar5,Method_Core_Browser_BrowserWindow___c__OnShow_b__6_1__,0);
		    param1_00 = Core_Browser_BrowserWindow___c_TypeInfo;
		    *(int *)(*(int *)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c) + 8) = param1_02;
		  }
		  if (*(int *)(param1_00 + 0x74) == 0) {
		    func_ii_306000(param1_00);
		    param1_00 = Core_Browser_BrowserWindow___c_TypeInfo;
		  }
		  puVar4 = *(undefined4 **)(param1_00 + 0x5c);
		  param1_03 = puVar4[3];
		  if (param1_03 == 0) {
		    if (*(int *)(param1_00 + 0x74) == 0) {
		      func_ii_306000(param1_00);
		      puVar4 = *(undefined4 **)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar4;
		    param1_03 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_03,uVar5,Method_Core_Browser_BrowserWindow___c__OnShow_b__6_2__,0);
		    param1_00 = Core_Browser_BrowserWindow___c_TypeInfo;
		    *(int *)(*(int *)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c) + 0xc) = param1_03;
		  }
		  if (*(int *)(param1_00 + 0x74) == 0) {
		    func_ii_306000(param1_00);
		    param1_00 = Core_Browser_BrowserWindow___c_TypeInfo;
		  }
		  puVar4 = *(undefined4 **)(param1_00 + 0x5c);
		  param1_04 = puVar4[4];
		  if (param1_04 == 0) {
		    if (*(int *)(param1_00 + 0x74) == 0) {
		      func_ii_306000(param1_00);
		      puVar4 = *(undefined4 **)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar4;
		    param1_04 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_04,uVar5,Method_Core_Browser_BrowserWindow___c__OnShow_b__6_3__,0);
		    param1_00 = Core_Browser_BrowserWindow___c_TypeInfo;
		    *(int *)(*(int *)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c) + 0x10) = param1_04;
		  }
		  if (*(int *)(param1_00 + 0x74) == 0) {
		    func_ii_306000(param1_00);
		    param1_00 = Core_Browser_BrowserWindow___c_TypeInfo;
		  }
		  puVar4 = *(undefined4 **)(param1_00 + 0x5c);
		  param1_05 = puVar4[5];
		  if (param1_05 == 0) {
		    if (*(int *)(param1_00 + 0x74) == 0) {
		      func_ii_306000(param1_00);
		      puVar4 = *(undefined4 **)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar4;
		    param1_05 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_05,uVar5,Method_Core_Browser_BrowserWindow___c__OnShow_b__6_4__,0);
		    param1_00 = Core_Browser_BrowserWindow___c_TypeInfo;
		    *(int *)(*(int *)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c) + 0x14) = param1_05;
		  }
		  if (*(int *)(param1_00 + 0x74) == 0) {
		    func_ii_306000(param1_00);
		    param1_00 = Core_Browser_BrowserWindow___c_TypeInfo;
		  }
		  puVar4 = *(undefined4 **)(param1_00 + 0x5c);
		  param1_06 = puVar4[6];
		  if (param1_06 == 0) {
		    if (*(int *)(param1_00 + 0x74) == 0) {
		      func_ii_306000(param1_00);
		      puVar4 = *(undefined4 **)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar4;
		    param1_06 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_06,uVar5,Method_Core_Browser_BrowserWindow___c__OnShow_b__6_5__,0);
		    *(int *)(*(int *)(Core_Browser_BrowserWindow___c_TypeInfo + 0x5c) + 0x18) = param1_06;
		  }
		  WebViewObject__IsWebViewAvailable
		            (uVar1,param1_01,param1_02,param1_03,param1_04,param1_05,param1_06,0,1,StringLiteral_5,0
		             ,1,0,1,0,0);
		  WebViewObject__SetMargins(*(undefined4 *)(param1 + 0x3c),1,0);
		  fVar3 = ((float)iVar2 / fVar3) * 105.0;
		  if (ABS(fVar3) < 2.1474836e+09) {
		    iVar2 = (int)fVar3;
		  }
		  else {
		    iVar2 = -0x80000000;
		  }
		  WebViewObject__SetCenterPositionWithScale(*(undefined4 *)(param1 + 0x3c),0,0,iVar2,0,0,0);
		  uVar5 = *(undefined4 *)(param1 + 0x3c);
		  uVar1 = System_Uri__get_PrivateAbsolutePath(*(undefined4 *)(param2 + 0x18),0);
		  WebViewObject__SetURLPattern(uVar5,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060065D9 RID: 26073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D9")]
		[Address(RVA = "0xB162", Offset = "0xB162", VA = "0xB162", Slot = "22")]
		protected override void OnShow(BrowserWindow.BrowserWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Core_Browser_BrowserWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a8dd == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a8dd = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Application__get_isPlaying(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060065DA RID: 26074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065DA")]
		[Address(RVA = "0xB163", Offset = "0xB163", VA = "0xB163", Slot = "25")]
		protected override void HandleCloseButton()
		{
		/* --- GHIDRA: HandleCloseButton ---
		void Core_Browser_BrowserWindow__HandleCloseButton(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a8de == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a8de = '\x01';
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  UnityEngine_Application__get_isPlaying(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060065DB RID: 26075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065DB")]
		[Address(RVA = "0xB164", Offset = "0xB164", VA = "0xB164", Slot = "29")]
		protected override void HandleBackButton()
		{
		/* --- GHIDRA: HandleBackButton ---
		void Core_Browser_BrowserWindow__HandleBackButton(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a8df == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_BrowserWindow_BrowserWindowArgs___ctor__);
		    DAT_ram_00a5a8df = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_BrowserWindow_BrowserWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060065DC RID: 26076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065DC")]
		[Address(RVA = "0xB165", Offset = "0xB165", VA = "0xB165")]
		public BrowserWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Browser_BrowserWindow___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x04003667 RID: 13927
		[Token(Token = "0x4003667")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/BrowserWindow";

		// Token: 0x04003668 RID: 13928
		[Token(Token = "0x4003668")]
		[FieldOffset(Offset = "0x3C")]
		private WebViewObject _webView;

		// Token: 0x0200110E RID: 4366
		[Token(Token = "0x200110E")]
		public class BrowserWindowArgs : BaseWindowArgs
		{
			// Token: 0x060065DD RID: 26077 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60065DD")]
			[Address(RVA = "0xB166", Offset = "0xB166", VA = "0xB166")]
			public BrowserWindowArgs(Uri uri)
			{
			}

			// Token: 0x04003669 RID: 13929
			[Token(Token = "0x4003669")]
			[FieldOffset(Offset = "0x18")]
			public readonly Uri Uri;
		}
	}
}
