using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	public class OpToken : IOpToken, IDisposable
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00002AF0 File Offset: 0x00000CF0
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006D")]
		public OpToken.OpTokenStatus Status
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x5743", Offset = "0x5743", VA = "0x5743", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return OpToken.OpTokenStatus.IDLE;
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x5744", Offset = "0x5744", VA = "0x5744")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x1700006E")]
		public bool IsPending
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x5745", Offset = "0x5745", VA = "0x5745")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x1700006F")]
		public bool IsIdle
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x5746", Offset = "0x5746", VA = "0x5746")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000070")]
		public object CustomData
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x5747", Offset = "0x5747", VA = "0x5747")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x5748", Offset = "0x5748", VA = "0x5748")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000071")]
		public object Index
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x5749", Offset = "0x5749", VA = "0x5749", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x574A", Offset = "0x574A", VA = "0x574A", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x574B", Offset = "0x574B", VA = "0x574B", Slot = "9")]
		public virtual void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Utils_OpToken__Dispose(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined4 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x574C", Offset = "0x574C", VA = "0x574C")]
		public OpToken()
		{
		/* --- GHIDRA: .ctor ---
		void Utils_OpToken___ctor(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 8) == 0) {
		    *(undefined4 *)(param1 + 8) = 1;
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Utils_OpToken___ctor(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 8) == 0) {
		    *(undefined4 *)(param1 + 8) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x574D", Offset = "0x574D", VA = "0x574D")]
		public OpToken(object index)
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x574E", Offset = "0x574E", VA = "0x574E", Slot = "10")]
		public virtual void Run()
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x574F", Offset = "0x574F", VA = "0x574F", Slot = "11")]
		public virtual void Cancel()
		{
		/* --- GHIDRA: Cancel ---
		void Utils_OpToken__Cancel(undefined4 param1,undefined4 param2)
		
		{
		  Utils_OpTokenRepository__Remove(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0200004C RID: 76
		[Token(Token = "0x200004C")]
		public enum OpTokenStatus
		{
			// Token: 0x0400012E RID: 302
			[Token(Token = "0x400012E")]
			IDLE,
			// Token: 0x0400012F RID: 303
			[Token(Token = "0x400012F")]
			PENDING,
			// Token: 0x04000130 RID: 304
			[Token(Token = "0x4000130")]
			COMPLETE,
			// Token: 0x04000131 RID: 305
			[Token(Token = "0x4000131")]
			FAILED,
			// Token: 0x04000132 RID: 306
			[Token(Token = "0x4000132")]
			CANCELLED
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Index ---
		void Utils_OpToken__get_Index(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  int *piVar3;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  local_c = 0;
		  local_8 = &local_4;
		  DAT_ram_009d3e38 = 0;
		  local_4 = param1;
		  import::env::invoke_vii(*(undefined4 *)(*param1 + 0x108),param1,*(undefined4 *)(*param1 + 0x10c));
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    DAT_ram_009d3e38 = 0;
		    return;
		  }
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar2;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      if (iVar2 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x17,&local_c);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(param1_00);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
