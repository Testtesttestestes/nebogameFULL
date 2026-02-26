using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Utils.Accumulators
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	public class CallAccumulator : IDisposable
	{
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000382 RID: 898 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000383 RID: 899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000011")]
		private event Action _call
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x57B5", Offset = "0x57B5", VA = "0x57B5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x57B6", Offset = "0x57B6", VA = "0x57B6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x57B7", Offset = "0x57B7", VA = "0x57B7")]
		public CallAccumulator(Action call, float timeout)
		{
		/* --- GHIDRA: .ctor ---
		void Utils_Accumulators_CallAccumulator___ctor(int param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  int local_c;
		  undefined8 local_8;
		  
		  if (*(char *)(param1 + 0x10) == '\0') {
		    if (DAT_ram_00a62850 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_CallAccumulator__RunTimer_d__8___
		                );
		      DAT_ram_00a62850 = '\x01';
		    }
		    local_8 = 0;
		    System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		    local_14 = local_28;
		    local_20 = 0xffffffff;
		    local_1c = local_30;
		    local_c = param1;
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_BossCaptainViewMediator__SetupView_d__8_
		              (&local_1c,&local_20,
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_CallAccumulator__RunTimer_d__8___
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x57B8", Offset = "0x57B8", VA = "0x57B8")]
		public void Call()
		{
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x57B9", Offset = "0x57B9", VA = "0x57B9", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Utils_Accumulators_CallAccumulator__Dispose(undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a62850 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_CallAccumulator__RunTimer_d__8___
		              );
		    DAT_ram_00a62850 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_BossCaptainViewMediator__SetupView_d__8_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_CallAccumulator__RunTimer_d__8___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x57BA", Offset = "0x57BA", VA = "0x57BA")]
		private void RunTimer()
		{
		}

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0xC")]
		private readonly float _timeout;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x10")]
		private bool _running;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add__call ---
		void Utils_Accumulators_CallAccumulator__add__call(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6284f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6284f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 8,param1_01,param1_00);
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
