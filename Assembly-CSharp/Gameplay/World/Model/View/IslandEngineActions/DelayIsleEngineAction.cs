using System;
using System.Collections;
using CloudsFly;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.World.Model.View.IslandEngineActions
{
	// Token: 0x0200036F RID: 879
	[Token(Token = "0x200036F")]
	public class DelayIsleEngineAction : BaseIsleEngineAction
	{
		// Token: 0x0600147C RID: 5244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x6646", Offset = "0x6646", VA = "0x6646")]
		public DelayIsleEngineAction(IIsleWorldObjectEngine engine, float delay)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Model_View_IslandEngineActions_DelayIsleEngineAction___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  uVar1 = *(undefined4 *)(param1 + 0xc);
		  if (DAT_ram_00a58c9b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_World_Model_View_IslandEngineActions_DelayIsleEngineAction__DelayRoutine_d__4_TypeInfo
		              );
		    DAT_ram_00a58c9b = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_World_Model_View_IslandEngineActions_DelayIsleEngineAction__DelayRoutine_d__4_TypeInfo
		                        );
		  *(int *)(param1_00 + 0x18) = param1;
		  *(undefined4 *)(param1_00 + 8) = 0;
		  *(undefined4 *)(param1_00 + 0x14) = param2;
		  *(undefined4 *)(param1_00 + 0x10) = uVar1;
		  uVar1 = Utils_CoroutineSource__GetMono(param1_00,0);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600147D RID: 5245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x6647", Offset = "0x6647", VA = "0x6647", Slot = "5")]
		public override void Invoke(Action<BaseIsleEngineAction> endCallback)
		{
		/* --- GHIDRA: Invoke ---
		int Gameplay_World_Model_View_IslandEngineActions_DelayIsleEngineAction__Invoke
		              (undefined4 param1,undefined4 param2,float param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58c9b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_World_Model_View_IslandEngineActions_DelayIsleEngineAction__DelayRoutine_d__4_TypeInfo
		              );
		    DAT_ram_00a58c9b = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_World_Model_View_IslandEngineActions_DelayIsleEngineAction__DelayRoutine_d__4_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x18) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x14) = param2;
		  *(float *)(iVar1 + 0x10) = param3;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600147E RID: 5246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x6648", Offset = "0x6648", VA = "0x6648")]
		private IEnumerator DelayRoutine(Action<BaseIsleEngineAction> callback, float delay)
		{
		/* --- GHIDRA: DelayRoutine ---
		void Gameplay_World_Model_View_IslandEngineActions_DelayIsleEngineAction__DelayRoutine
		               (int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x10) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x10),0);
		  }
		  *(undefined4 *)(param1 + 0x10) = 0;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x6649", Offset = "0x6649", VA = "0x6649", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x664A", Offset = "0x664A", VA = "0x664A", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x04000AE2 RID: 2786
		[Token(Token = "0x4000AE2")]
		[FieldOffset(Offset = "0xC")]
		private readonly float _delay;

		// Token: 0x04000AE3 RID: 2787
		[Token(Token = "0x4000AE3")]
		[FieldOffset(Offset = "0x10")]
		private Coroutine _routine;
	}
}
