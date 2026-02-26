using System;
using CloudsFly;
using Gameplay.World.View;
using Il2CppDummyDll;

namespace Gameplay.World.Model.View.IslandEngineActions
{
	// Token: 0x02000372 RID: 882
	[Token(Token = "0x2000372")]
	public class MoveToLevelEngineAction : BaseIsleEngineAction
	{
		// Token: 0x0600148C RID: 5260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x6656", Offset = "0x6656", VA = "0x6656")]
		public MoveToLevelEngineAction(IIsleWorldObjectEngine engine, WorldLevel fromLevel, WorldLevel toLevel, Action<WorldLevel> levelChangedCallback, CloudsVerticalMovementAnimation cloudsVerticalMovementAnimation)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Model_View_IslandEngineActions_MoveToLevelEngineAction___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  int iVar4;
		  int *param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a58c9f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_IIsleWorldObjectEngine_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_World_Model_View_IslandEngineActions_MoveToLevelEngineAction_OnMovementMiddleCallback__
		              );
		    DAT_ram_00a58c9f = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  iVar3 = *(int *)(param1 + 0x10);
		  iVar4 = *(int *)(param1 + 0xc);
		  param1_01 = *(int **)(param1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_World_Model_View_IslandEngineActions_MoveToLevelEngineAction_OnMovementMiddleCallback__
		             ,0);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (CloudsFly_IIsleWorldObjectEngine_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x80f94ffb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,CloudsFly_IIsleWorldObjectEngine_TypeInfo,3);
		code_r0x80f94ffb:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_01,iVar4 < iVar3,param1_00,puVar2[1]);
		  CloudsFly_CloudsVerticalMovementAnimation__Awake
		            (*(undefined4 *)(param1 + 0x18),(uint)(*(int *)(param1 + 0xc) < *(int *)(param1 + 0x10))
		             ,0);
		  return;
		}
		*/

		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x6657", Offset = "0x6657", VA = "0x6657", Slot = "5")]
		public override void Invoke(Action<BaseIsleEngineAction> endCallback)
		{
		/* --- GHIDRA: Invoke ---
		void Gameplay_World_Model_View_IslandEngineActions_MoveToLevelEngineAction__Invoke
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x10),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x6658", Offset = "0x6658", VA = "0x6658")]
		private void OnMovementMiddleCallback()
		{
		/* --- GHIDRA: OnMovementMiddleCallback ---
		void Gameplay_World_Model_View_IslandEngineActions_MoveToLevelEngineAction__OnMovementMiddleCallback
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a58ca0 == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_IIsleWorldObjectEngine_TypeInfo);
		    DAT_ram_00a58ca0 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (CloudsFly_IIsleWorldObjectEngine_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0);
		        goto code_r0x80f950d8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,CloudsFly_IIsleWorldObjectEngine_TypeInfo,6);
		code_r0x80f950d8:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x6659", Offset = "0x6659", VA = "0x6659", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x665A", Offset = "0x665A", VA = "0x665A", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_World_Model_View_IslandEngineActions_MoveToLevelEngineAction__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined8 *param5,
		               undefined4 param6)
		
		{
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  *(undefined8 *)(param1 + 0x14) = *param5;
		  *(undefined4 *)(param1 + 0x1c) = *(undefined4 *)(param5 + 1);
		  return;
		}
		*/

		}

		// Token: 0x04000AEC RID: 2796
		[Token(Token = "0x4000AEC")]
		[FieldOffset(Offset = "0xC")]
		private WorldLevel _fromLevel;

		// Token: 0x04000AED RID: 2797
		[Token(Token = "0x4000AED")]
		[FieldOffset(Offset = "0x10")]
		private WorldLevel _toLevel;

		// Token: 0x04000AEE RID: 2798
		[Token(Token = "0x4000AEE")]
		[FieldOffset(Offset = "0x14")]
		private Action<WorldLevel> _levelChangedCallback;

		// Token: 0x04000AEF RID: 2799
		[Token(Token = "0x4000AEF")]
		[FieldOffset(Offset = "0x18")]
		private CloudsVerticalMovementAnimation _cloudsVerticalMovementAnimation;

		// Token: 0x04000AF0 RID: 2800
		[Token(Token = "0x4000AF0")]
		[FieldOffset(Offset = "0x1C")]
		private Action<BaseIsleEngineAction> _endCallback;
	}
}
