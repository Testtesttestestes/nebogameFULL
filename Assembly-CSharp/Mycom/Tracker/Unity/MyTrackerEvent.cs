using System;
using Il2CppDummyDll;

namespace Mycom.Tracker.Unity
{
	// Token: 0x02001341 RID: 4929
	[Token(Token = "0x2001341")]
	public abstract class MyTrackerEvent
	{
		// Token: 0x060074B7 RID: 29879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074B7")]
		[Address(RVA = "0xBE83", Offset = "0xBE83", VA = "0xBE83")]
		internal MyTrackerEvent(AppEventEnum appEvent)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Mycom_Tracker_Unity_MyTrackerEvent___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a596e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITrackerParams_TypeInfo);
		    DAT_ram_00a596e2 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITrackerParams_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8104f682;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                Mycom_Tracker_Unity_Internal_Interfaces_ITrackerParams_TypeInfo,0);
		code_r0x8104f682:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x04003D39 RID: 15673
		[Token(Token = "0x4003D39")]
		[FieldOffset(Offset = "0x8")]
		internal readonly AppEventEnum appEvent;
	}
}
