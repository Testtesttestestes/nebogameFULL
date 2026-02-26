using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Dev
{
	// Token: 0x020010B0 RID: 4272
	[Token(Token = "0x20010B0")]
	public class DevMenuShowConsole : MonoBehaviour
	{
		// Token: 0x0600632C RID: 25388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600632C")]
		[Address(RVA = "0xAF38", Offset = "0xAF38", VA = "0xAF38")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Core_Dev_DevMenuShowConsole__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6076d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Dev_DevMenuShowConsole_ClickHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a6076d = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(param1_00,param1,Method_Core_Dev_DevMenuShowConsole_ClickHandler__,0)
		  ;
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600632D RID: 25389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600632D")]
		[Address(RVA = "0xAF39", Offset = "0xAF39", VA = "0xAF39")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Core_Dev_DevMenuShowConsole__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = LunarConsolePlugin_LunarConsole__SetConsoleInstanceEnabled(0);
		  if (iVar1 != 0) {
		    LunarConsolePlugin_LunarConsole__TrackEvent(0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600632E RID: 25390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600632E")]
		[Address(RVA = "0xAF3A", Offset = "0xAF3A", VA = "0xAF3A")]
		private void ClickHandler()
		{
		}

		// Token: 0x0600632F RID: 25391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600632F")]
		[Address(RVA = "0xAF3B", Offset = "0xAF3B", VA = "0xAF3B")]
		public DevMenuShowConsole()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dev_DevMenuShowConsole___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6076e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6076e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x14,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0400352C RID: 13612
		[Token(Token = "0x400352C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _button;
	}
}
