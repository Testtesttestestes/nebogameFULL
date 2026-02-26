using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public abstract class AbstractFpsCounter : MonoBehaviour
	{
		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x56DE", Offset = "0x56DE", VA = "0x56DE")]
		private void Update()
		{
		}

		// Token: 0x0600023A RID: 570
		[Token(Token = "0x600023A")]
		public abstract void HandleUpdate();

		// Token: 0x0600023B RID: 571
		[Token(Token = "0x600023B")]
		public abstract void HandleFpsCalculated(float fps);

		// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x56DF", Offset = "0x56DF", VA = "0x56DF")]
		protected AbstractFpsCounter()
		{
		/* --- GHIDRA: .ctor ---
		void Utils_AbstractFpsCounter___ctor(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int *piVar1;
		  undefined4 param1_01;
		  int iVar2;
		  undefined4 param1_02;
		  int param2_00;
		  int iVar3;
		  
		  if (DAT_ram_00a648e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_InputAction_CallbackContext__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_InputNavigator_SelectElement__);
		    DAT_ram_00a648e8 = '\x01';
		  }
		  if (*(char *)(param1 + 0x14) != '\0') {
		    iVar2 = *(int *)(param1 + 0x20);
		    if (DAT_ram_00a648ea == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Selectable__get_Count__);
		      Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Selectable__get_Item__);
		      DAT_ram_00a648ea = '\x01';
		    }
		    param1_00 = Utils_InputNavigator__SetIndex(param1,param1);
		    param2_00 = *(int *)(param1_00 + 0xc) + -1;
		    iVar3 = iVar2;
		    if (param2_00 < iVar2) {
		      iVar3 = 0;
		    }
		    if (-1 < iVar2) {
		      param2_00 = iVar3;
		    }
		    *(int *)(param1 + 0x20) = param2_00;
		    piVar1 = (int *)System_Linq_Enumerable__ToList_object_
		                              (param1_00,param2_00,
		                               Method_System_Collections_Generic_List_Selectable__get_Item__);
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x1f0) * 4))(piVar1,*(undefined4 *)(*piVar1 + 500));
		  }
		  param1_02 = *(undefined4 *)(param1 + 0x10);
		  param1_01 = unnamed_function_1417(System_Action_InputAction_CallbackContext__TypeInfo);
		  System_Action_HIDParser_HIDReportData___Invoke
		            (param1_01,param1,Method_Utils_InputNavigator_SelectElement__,0);
		  UnityEngine_InputSystem_InputAction__remove_canceled(param1_02,param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _refreshInterval;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x14")]
		private float _totalFrames;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x18")]
		private float _timePassed;
	}
}
