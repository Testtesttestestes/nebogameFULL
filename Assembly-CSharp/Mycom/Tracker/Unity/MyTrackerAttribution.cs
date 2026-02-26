using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Mycom.Tracker.Unity
{
	// Token: 0x0200133F RID: 4927
	[Token(Token = "0x200133F")]
	public sealed class MyTrackerAttribution
	{
		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x060074A3 RID: 29859 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060074A4 RID: 29860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700177F")]
		public string Deeplink
		{
			[Token(Token = "0x60074A3")]
			[Address(RVA = "0xBE6F", Offset = "0xBE6F", VA = "0xBE6F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60074A4")]
			[Address(RVA = "0xBE70", Offset = "0xBE70", VA = "0xBE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060074A5 RID: 29861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074A5")]
		[Address(RVA = "0xBE71", Offset = "0xBE71", VA = "0xBE71")]
		internal MyTrackerAttribution(string deeplink)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Mycom_Tracker_Unity_MyTrackerAttribution___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a596d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Mycom_Tracker_Unity_Internal_Interfaces_ITrackerConfig_TypeInfo);
		    DAT_ram_00a596d2 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Mycom_Tracker_Unity_Internal_Interfaces_ITrackerConfig_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8104ec02;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                Mycom_Tracker_Unity_Internal_Interfaces_ITrackerConfig_TypeInfo,0);
		code_r0x8104ec02:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

		}
	}
}
