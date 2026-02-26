using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Core.Dev
{
	// Token: 0x020010B3 RID: 4275
	[Token(Token = "0x20010B3")]
	public class LaunchLevelPlayTestSuite : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06006341 RID: 25409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006341")]
		[Address(RVA = "0xAF4D", Offset = "0xAF4D", VA = "0xAF4D")]
		private void Start()
		{
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006342")]
		[Address(RVA = "0xAF4E", Offset = "0xAF4E", VA = "0xAF4E", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006343")]
		[Address(RVA = "0xAF4F", Offset = "0xAF4F", VA = "0xAF4F")]
		public LaunchLevelPlayTestSuite()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Dev_LaunchLevelPlayTestSuite___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6077a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6077a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x38,param1_01,param1_00);
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
	}
}
