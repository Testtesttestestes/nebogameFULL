using System;
using Il2CppDummyDll;

namespace Mycom.Tracker.Unity
{
	// Token: 0x0200133D RID: 4925
	[Token(Token = "0x200133D")]
	public static class LibraryLogger
	{
		// Token: 0x06007492 RID: 29842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007492")]
		[Address(RVA = "0xBE5E", Offset = "0xBE5E", VA = "0xBE5E")]
		public static void Log(string message)
		{
		/* --- GHIDRA: Log ---
		void Mycom_Tracker_Unity_LibraryLogger__Log(undefined4 param1)
		
		{
		  if (DAT_ram_00a596c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_LibraryLogger_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18963);
		    DAT_ram_00a596c2 = '\x01';
		  }
		  **(undefined4 **)(Mycom_Tracker_Unity_LibraryLogger_TypeInfo + 0x5c) = StringLiteral_18963;
		  return;
		}
		*/

		}

		// Token: 0x04003D34 RID: 15668
		[Token(Token = "0x4003D34")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string Tag;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: .cctor ---
		undefined4 Mycom_Tracker_Unity_LibraryLogger___cctor(undefined4 param1)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a596c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_MyTracker_TypeInfo);
		    DAT_ram_00a596c3 = '\x01';
		  }
		  if (*(int *)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Mycom_Tracker_Unity_MyTracker_TypeInfo);
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Mycom_Tracker_Unity_MyTracker_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x8104decc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Mycom_Tracker_Unity_Internal_Interfaces_ITracker_TypeInfo,
		                                2);
		code_r0x8104decc:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

}
