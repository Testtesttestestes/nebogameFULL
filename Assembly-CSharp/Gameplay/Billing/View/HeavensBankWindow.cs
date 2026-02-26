using System;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Billing.View
{
	// Token: 0x02000BDF RID: 3039
	[Token(Token = "0x2000BDF")]
	public class HeavensBankWindow : ClosableBaseWindow<HeavensBankWindow.HeavensBankWindowArgs>
	{
		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06004A99 RID: 19097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F0E")]
		public override string WindowId
		{
			[Token(Token = "0x6004A99")]
			[Address(RVA = "0x98FB", Offset = "0x98FB", VA = "0x98FB", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004A9A RID: 19098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A9A")]
		[Address(RVA = "0x98FC", Offset = "0x98FC", VA = "0x98FC")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Billing_View_HeavensBankWindow__OnDestroy(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  float fVar4;
		  float fVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int param1_00;
		  int param1_01;
		  int param1_02;
		  int param1_03;
		  int param1_04;
		  float fVar8;
		  int iVar9;
		  undefined4 uVar10;
		  
		  if (DAT_ram_00a608fb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_HeavensBankWindow_HeavensBankWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_WebViewObject___);
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Common_Settings_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Billing_View_HeavensBankWindow___c__OnShow_b__6_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Billing_View_HeavensBankWindow___c__OnShow_b__6_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Billing_View_HeavensBankWindow___c__OnShow_b__6_2__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Billing_View_HeavensBankWindow___c__OnShow_b__6_3__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Billing_View_HeavensBankWindow___c__OnShow_b__6_4__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Billing_View_HeavensBankWindow___c__OnShow_b__6_5__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a608fb = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_HeavensBankWindow_HeavensBankWindowArgs__OnShow__
		              );
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  uVar1 = UnityEngine_GameObject__GetComponent_object_
		                    (uVar1,Method_UnityEngine_GameObject_AddComponent_WebViewObject___);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  iVar2 = UnityEngine_RefreshRate__ToString(0);
		  if (*(int *)(ScreenAdaptation_Common_Settings_TypeInfo + 0x74) == 0) {
		    func_ii_306000(ScreenAdaptation_Common_Settings_TypeInfo);
		  }
		  fVar4 = *(float *)(**(int **)(ScreenAdaptation_Common_Settings_TypeInfo + 0x5c) + 8);
		  iVar3 = UnityEngine_Screen__get_width(0);
		  fVar5 = *(float *)(**(int **)(ScreenAdaptation_Common_Settings_TypeInfo + 0x5c) + 0xc);
		  uVar1 = *(undefined4 *)(param1 + 0x3c);
		  if (*(int *)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c);
		  iVar7 = puVar6[1];
		  iVar9 = Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo;
		  if (iVar7 == 0) {
		    if (*(int *)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c);
		    }
		    uVar10 = *puVar6;
		    iVar7 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (iVar7,uVar10,Method_Gameplay_Billing_View_HeavensBankWindow___c__OnShow_b__6_0__,0);
		    iVar9 = Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo;
		    *(int *)(*(int *)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c) + 4) = iVar7;
		  }
		  if (*(int *)(iVar9 + 0x74) == 0) {
		    func_ii_306000(iVar9);
		    iVar9 = Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo;
		  }
		  puVar6 = *(undefined4 **)(iVar9 + 0x5c);
		  param1_00 = puVar6[2];
		  if (param1_00 == 0) {
		    if (*(int *)(iVar9 + 0x74) == 0) {
		      func_ii_306000(iVar9);
		      puVar6 = *(undefined4 **)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c);
		    }
		    uVar10 = *puVar6;
		    param1_00 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,uVar10,Method_Gameplay_Billing_View_HeavensBankWindow___c__OnShow_b__6_1__,
		               0);
		    iVar9 = Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo;
		    *(int *)(*(int *)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c) + 8) = param1_00;
		  }
		  if (*(int *)(iVar9 + 0x74) == 0) {
		    func_ii_306000(iVar9);
		    iVar9 = Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo;
		  }
		  puVar6 = *(undefined4 **)(iVar9 + 0x5c);
		  param1_01 = puVar6[3];
		  if (param1_01 == 0) {
		    if (*(int *)(iVar9 + 0x74) == 0) {
		      func_ii_306000(iVar9);
		      puVar6 = *(undefined4 **)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c);
		    }
		    uVar10 = *puVar6;
		    param1_01 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,uVar10,Method_Gameplay_Billing_View_HeavensBankWindow___c__OnShow_b__6_2__,
		               0);
		    iVar9 = Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo;
		    *(int *)(*(int *)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c) + 0xc) =
		         param1_01;
		  }
		  if (*(int *)(iVar9 + 0x74) == 0) {
		    func_ii_306000(iVar9);
		    iVar9 = Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo;
		  }
		  puVar6 = *(undefined4 **)(iVar9 + 0x5c);
		  param1_02 = puVar6[4];
		  if (param1_02 == 0) {
		    if (*(int *)(iVar9 + 0x74) == 0) {
		      func_ii_306000(iVar9);
		      puVar6 = *(undefined4 **)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c);
		    }
		    uVar10 = *puVar6;
		    param1_02 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_02,uVar10,Method_Gameplay_Billing_View_HeavensBankWindow___c__OnShow_b__6_3__,
		               0);
		    iVar9 = Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo;
		    *(int *)(*(int *)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c) + 0x10) =
		         param1_02;
		  }
		  if (*(int *)(iVar9 + 0x74) == 0) {
		    func_ii_306000(iVar9);
		    iVar9 = Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo;
		  }
		  puVar6 = *(undefined4 **)(iVar9 + 0x5c);
		  param1_03 = puVar6[5];
		  if (param1_03 == 0) {
		    if (*(int *)(iVar9 + 0x74) == 0) {
		      func_ii_306000(iVar9);
		      puVar6 = *(undefined4 **)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c);
		    }
		    uVar10 = *puVar6;
		    param1_03 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_03,uVar10,Method_Gameplay_Billing_View_HeavensBankWindow___c__OnShow_b__6_4__,
		               0);
		    iVar9 = Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo;
		    *(int *)(*(int *)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c) + 0x14) =
		         param1_03;
		  }
		  if (*(int *)(iVar9 + 0x74) == 0) {
		    func_ii_306000(iVar9);
		    iVar9 = Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo;
		  }
		  puVar6 = *(undefined4 **)(iVar9 + 0x5c);
		  param1_04 = puVar6[6];
		  if (param1_04 == 0) {
		    if (*(int *)(iVar9 + 0x74) == 0) {
		      func_ii_306000(iVar9);
		      puVar6 = *(undefined4 **)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c);
		    }
		    uVar10 = *puVar6;
		    param1_04 = unnamed_function_1417(System_Action_string__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_04,uVar10,Method_Gameplay_Billing_View_HeavensBankWindow___c__OnShow_b__6_5__,
		               0);
		    *(int *)(*(int *)(Gameplay_Billing_View_HeavensBankWindow___c_TypeInfo + 0x5c) + 0x18) =
		         param1_04;
		  }
		  WebViewObject__IsWebViewAvailable
		            (uVar1,iVar7,param1_00,param1_01,param1_02,param1_03,param1_04,0,0,StringLiteral_5,0,1,0
		             ,1,0,0);
		  WebViewObject__SetMargins(*(undefined4 *)(param1 + 0x3c),1,0);
		  fVar5 = (float)iVar3 / fVar5;
		  fVar8 = fVar5 * 30.0;
		  if (ABS(fVar8) < 2.1474836e+09) {
		    iVar3 = (int)fVar8;
		  }
		  else {
		    iVar3 = -0x80000000;
		  }
		  fVar4 = (float)iVar2 / fVar4;
		  fVar8 = fVar4 * 105.0;
		  if (ABS(fVar8) < 2.1474836e+09) {
		    iVar2 = (int)fVar8;
		  }
		  else {
		    iVar2 = -0x80000000;
		  }
		  fVar5 = fVar5 * 110.0;
		  if (ABS(fVar5) < 2.1474836e+09) {
		    iVar9 = (int)fVar5;
		  }
		  else {
		    iVar9 = -0x80000000;
		  }
		  fVar4 = fVar4 * 120.0;
		  if (ABS(fVar4) < 2.1474836e+09) {
		    iVar7 = (int)fVar4;
		  }
		  else {
		    iVar7 = -0x80000000;
		  }
		  WebViewObject__SetCenterPositionWithScale
		            (*(undefined4 *)(param1 + 0x3c),iVar7,iVar9,iVar2,iVar3,0,0);
		  uVar10 = *(undefined4 *)(param1 + 0x3c);
		  uVar1 = System_Uri__get_PrivateAbsolutePath(*(undefined4 *)(param2 + 0x18),0);
		  WebViewObject__SetURLPattern(uVar10,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A9B")]
		[Address(RVA = "0x98FD", Offset = "0x98FD", VA = "0x98FD", Slot = "22")]
		protected override void OnShow(HeavensBankWindow.HeavensBankWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Billing_View_HeavensBankWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a608fc == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a608fc = '\x01';
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

		// Token: 0x06004A9C RID: 19100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A9C")]
		[Address(RVA = "0x98FE", Offset = "0x98FE", VA = "0x98FE", Slot = "25")]
		protected override void HandleCloseButton()
		{
		/* --- GHIDRA: HandleCloseButton ---
		void Gameplay_Billing_View_HeavensBankWindow__HandleCloseButton(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a608fd == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a608fd = '\x01';
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

		// Token: 0x06004A9D RID: 19101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A9D")]
		[Address(RVA = "0x98FF", Offset = "0x98FF", VA = "0x98FF", Slot = "29")]
		protected override void HandleBackButton()
		{
		/* --- GHIDRA: HandleBackButton ---
		void Gameplay_Billing_View_HeavensBankWindow__HandleBackButton(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a608fe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_HeavensBankWindow_HeavensBankWindowArgs___ctor__
		              );
		    DAT_ram_00a608fe = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_HeavensBankWindow_HeavensBankWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A9E")]
		[Address(RVA = "0x9900", Offset = "0x9900", VA = "0x9900")]
		public HeavensBankWindow()
		{
		}

		// Token: 0x04002895 RID: 10389
		[Token(Token = "0x4002895")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Bank/HeavensBankWindow";

		// Token: 0x04002896 RID: 10390
		[Token(Token = "0x4002896")]
		[FieldOffset(Offset = "0x3C")]
		private WebViewObject _webView;

		// Token: 0x02000BE0 RID: 3040
		[Token(Token = "0x2000BE0")]
		public class HeavensBankWindowArgs : BaseWindowArgs
		{
			// Token: 0x06004A9F RID: 19103 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004A9F")]
			[Address(RVA = "0x9901", Offset = "0x9901", VA = "0x9901")]
			public HeavensBankWindowArgs(Uri uri)
			{
			}

			// Token: 0x04002897 RID: 10391
			[Token(Token = "0x4002897")]
			[FieldOffset(Offset = "0x18")]
			public readonly Uri Uri;
		}
	}
}
