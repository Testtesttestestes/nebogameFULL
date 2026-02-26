using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils.Fps
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public class FpsStats : AbstractFpsCounter
	{
		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000F")]
		public event Action<float> AverageFpsCalculatedEvent
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x579F", Offset = "0x579F", VA = "0x579F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x57A0", Offset = "0x57A0", VA = "0x57A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x57A1", Offset = "0x57A1", VA = "0x57A1", Slot = "4")]
		public override void HandleUpdate()
		{
		/* --- GHIDRA: HandleUpdate ---
		void Utils_Fps_FpsStats__HandleUpdate(int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x57A2", Offset = "0x57A2", VA = "0x57A2", Slot = "5")]
		public override void HandleFpsCalculated(float fps)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x57A3", Offset = "0x57A3", VA = "0x57A3")]
		public FpsStats()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_AverageFpsCalculatedEvent ---
		void Utils_Fps_FpsStats__add_AverageFpsCalculatedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62848 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_float__TypeInfo);
		    DAT_ram_00a62848 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_float__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_float__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
