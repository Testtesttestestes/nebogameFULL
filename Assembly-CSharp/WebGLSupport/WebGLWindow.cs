using System;
using System.Runtime.CompilerServices;
using AOT;
using Il2CppDummyDll;
using UnityEngine;

namespace WebGLSupport
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public static class WebGLWindow
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000054")]
		public static bool Focus
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x56A7", Offset = "0x56A7", VA = "0x56A7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x56A8", Offset = "0x56A8", VA = "0x56A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public static event Action OnFocusEvent
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x56A9", Offset = "0x56A9", VA = "0x56A9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x56AA", Offset = "0x56AA", VA = "0x56AA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public static event Action OnBlurEvent
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x56AB", Offset = "0x56AB", VA = "0x56AB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x56AC", Offset = "0x56AC", VA = "0x56AC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x56AD", Offset = "0x56AD", VA = "0x56AD")]
		private static void Init()
		{
		/* --- GHIDRA: Init ---
		void WebGLSupport_WebGLWindow__Init(undefined4 param1)
		
		{
		  undefined1 *puVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a648d1 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648d1 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  if (DAT_ram_00a648f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648f8 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  puVar1 = *(undefined1 **)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c);
		  *puVar1 = 1;
		  iVar2 = *(int *)(puVar1 + 4);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x56AE", Offset = "0x56AE", VA = "0x56AE")]
		[MonoPInvokeCallback(typeof(Action))]
		private static void OnWindowFocus()
		{
		/* --- GHIDRA: OnWindowFocus ---
		void WebGLSupport_WebGLWindow__OnWindowFocus(undefined4 param1)
		
		{
		  undefined1 *puVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a648d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648d2 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  if (DAT_ram_00a648f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648f8 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  puVar1 = *(undefined1 **)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c);
		  *puVar1 = 0;
		  iVar2 = *(int *)(puVar1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x56AF", Offset = "0x56AF", VA = "0x56AF")]
		[MonoPInvokeCallback(typeof(Action))]
		private static void OnWindowBlur()
		{
		/* --- GHIDRA: OnWindowBlur ---
		void WebGLSupport_WebGLWindow__OnWindowBlur(undefined4 param1)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a648d3 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648d3 = '\x01';
		  }
		  param1_00 = WebGLSupport_WebGLWindow_TypeInfo;
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  WebGLSupport_WebGLWindow__remove_OnBlurEvent(param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x56B0", Offset = "0x56B0", VA = "0x56B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void RuntimeInitializeOnLoadMethod()
		{
		/* --- GHIDRA: RuntimeInitializeOnLoadMethod ---
		void WebGLSupport_WebGLWindow__RuntimeInitializeOnLoadMethod(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a648d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_WebGLSupport_WebGLWindow___c___cctor_b__14_0__);
		    Mono_Security_ASN1__get_Item(&Method_WebGLSupport_WebGLWindow___c___cctor_b__14_1__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648d4 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow___c_TypeInfo);
		  }
		  uVar2 = **(undefined4 **)(WebGLSupport_WebGLWindow___c_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,uVar2,Method_WebGLSupport_WebGLWindow___c___cctor_b__14_0__,0);
		  *(undefined4 *)(*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c) + 4) = uVar1;
		  uVar2 = **(undefined4 **)(WebGLSupport_WebGLWindow___c_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,uVar2,Method_WebGLSupport_WebGLWindow___c___cctor_b__14_1__,0);
		  *(undefined4 *)(*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c) + 8) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Focus ---
		void WebGLSupport_WebGLWindow__get_Focus(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a648cb == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648cb = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  **(undefined1 **)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c) = (undefined1)param1;
		  return;
		}
		*/


		/* --- GHIDRA: set_Focus ---
		void WebGLSupport_WebGLWindow__set_Focus(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a648cc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648cc = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  param1_00 = *(int *)(*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c) + 4);
		  do {
		    param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param1,0);
		    if ((param1_01 != (int *)0x0) && (System_Action_TypeInfo != *param1_01)) {
		      System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		      func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		    }
		    iVar2 = func_ii_4329(*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c) + 4,param1_01,param1_00)
		    ;
		    bVar1 = iVar2 != param1_00;
		    param1_00 = iVar2;
		  } while (bVar1);
		  return;
		}
		*/


		/* --- GHIDRA: add_OnFocusEvent ---
		void WebGLSupport_WebGLWindow__add_OnFocusEvent(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a648cd == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648cd = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  param1_00 = *(int *)(*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c) + 4);
		  do {
		    param1_01 = (int *)func_ii_7048(param1_00,param1,0);
		    if ((param1_01 != (int *)0x0) && (System_Action_TypeInfo != *param1_01)) {
		      System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		      func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		    }
		    iVar2 = func_ii_4329(*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c) + 4,param1_01,param1_00)
		    ;
		    bVar1 = iVar2 != param1_00;
		    param1_00 = iVar2;
		  } while (bVar1);
		  return;
		}
		*/


		/* --- GHIDRA: remove_OnFocusEvent ---
		void WebGLSupport_WebGLWindow__remove_OnFocusEvent(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a648ce == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648ce = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  param1_00 = *(int *)(*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c) + 8);
		  do {
		    param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param1,0);
		    if ((param1_01 != (int *)0x0) && (System_Action_TypeInfo != *param1_01)) {
		      System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		      func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		    }
		    iVar2 = func_ii_4329(*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c) + 8,param1_01,param1_00)
		    ;
		    bVar1 = iVar2 != param1_00;
		    param1_00 = iVar2;
		  } while (bVar1);
		  return;
		}
		*/


		/* --- GHIDRA: add_OnBlurEvent ---
		void WebGLSupport_WebGLWindow__add_OnBlurEvent(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a648cf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648cf = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  param1_00 = *(int *)(*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c) + 8);
		  do {
		    param1_01 = (int *)func_ii_7048(param1_00,param1,0);
		    if ((param1_01 != (int *)0x0) && (System_Action_TypeInfo != *param1_01)) {
		      System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		      func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		    }
		    iVar2 = func_ii_4329(*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c) + 8,param1_01,param1_00)
		    ;
		    bVar1 = iVar2 != param1_00;
		    param1_00 = iVar2;
		  } while (bVar1);
		  return;
		}
		*/


		/* --- GHIDRA: remove_OnBlurEvent ---
		void WebGLSupport_WebGLWindow__remove_OnBlurEvent(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a648d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_WebGLSupport_WebGLWindow_OnWindowBlur__);
		    Mono_Security_ASN1__get_Item(&Method_WebGLSupport_WebGLWindow_OnWindowFocus__);
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648d0 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  if (DAT_ram_00a648f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648f8 = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  **(undefined1 **)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c) = 1;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,0,Method_WebGLSupport_WebGLWindow_OnWindowFocus__,0);
		  uVar1 = unnamed_function_1434(uVar1);
		  import::env::WebGLWindowOnFocus(uVar1);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,0,Method_WebGLSupport_WebGLWindow_OnWindowBlur__,0);
		  uVar1 = unnamed_function_1434(uVar1);
		  import::env::WebGLWindowOnBlur(uVar1);
		  import::env::WebGLWindowInjectFullscreen();
		  return;
		}
		*/


		/* --- GHIDRA: .cctor ---
		void WebGLSupport_WebGLWindow___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a648d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow___c_TypeInfo);
		    DAT_ram_00a648d5 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(WebGLSupport_WebGLWindow___c_TypeInfo);
		  **(undefined4 **)(WebGLSupport_WebGLWindow___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

}
