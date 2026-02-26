using System;
using CloudsFly;
using CloudsFly.Movement;
using Gameplay.Isles.Base;
using Il2CppDummyDll;

namespace Gameplay.World.Model.View.IslandEngineActions
{
	// Token: 0x02000371 RID: 881
	[Token(Token = "0x2000371")]
	public class MoveToIslandEngineAction : BaseIsleEngineAction
	{
		// Token: 0x06001487 RID: 5255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001487")]
		[Address(RVA = "0x6651", Offset = "0x6651", VA = "0x6651")]
		public MoveToIslandEngineAction(IIsleWorldObjectEngine engine, IIsle isle, WorldMovementTypes type)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Model_View_IslandEngineActions_MoveToIslandEngineAction___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a58c9d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_IIsleWorldObjectEngine_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Model_View_IslandEngineActions_MoveToIslandEngineAction_Callback__
		              );
		    DAT_ram_00a58c9d = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = param2;
		  uVar3 = *(undefined4 *)(param1 + 0xc);
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  param1_01 = *(int **)(param1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_World_Model_View_IslandEngineActions_MoveToIslandEngineAction_Callback__
		             ,0);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (CloudsFly_IIsleWorldObjectEngine_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80f94e48;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,CloudsFly_IIsleWorldObjectEngine_TypeInfo,2);
		code_r0x80f94e48:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_01,uVar3,uVar4,param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06001488 RID: 5256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001488")]
		[Address(RVA = "0x6652", Offset = "0x6652", VA = "0x6652", Slot = "5")]
		public override void Invoke(Action<BaseIsleEngineAction> endCallback)
		{
		/* --- GHIDRA: Invoke ---
		void Gameplay_World_Model_View_IslandEngineActions_MoveToIslandEngineAction__Invoke
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a58c9e == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_IIsleWorldObjectEngine_TypeInfo);
		    DAT_ram_00a58c9e = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (CloudsFly_IIsleWorldObjectEngine_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0);
		        goto code_r0x80f94eeb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,CloudsFly_IIsleWorldObjectEngine_TypeInfo,6);
		code_r0x80f94eeb:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001489")]
		[Address(RVA = "0x6653", Offset = "0x6653", VA = "0x6653", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148A")]
		[Address(RVA = "0x6654", Offset = "0x6654", VA = "0x6654", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_World_Model_View_IslandEngineActions_MoveToIslandEngineAction__Dispose
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x6655", Offset = "0x6655", VA = "0x6655")]
		private void Callback()
		{
		}

		// Token: 0x04000AE9 RID: 2793
		[Token(Token = "0x4000AE9")]
		[FieldOffset(Offset = "0xC")]
		private IIsle _isle;

		// Token: 0x04000AEA RID: 2794
		[Token(Token = "0x4000AEA")]
		[FieldOffset(Offset = "0x10")]
		private WorldMovementTypes _type;

		// Token: 0x04000AEB RID: 2795
		[Token(Token = "0x4000AEB")]
		[FieldOffset(Offset = "0x14")]
		private Action<BaseIsleEngineAction> _endCallback;
	}
}
