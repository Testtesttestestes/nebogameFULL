using System;
using CloudsFly;
using Gameplay.Isles.Base;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.World.Model.View.IslandEngineActions
{
	// Token: 0x02000373 RID: 883
	[Token(Token = "0x2000373")]
	public class SetIsleEngineAction : BaseIsleEngineAction
	{
		// Token: 0x06001491 RID: 5265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x665B", Offset = "0x665B", VA = "0x665B")]
		public SetIsleEngineAction(IIsleWorldObjectEngine engine, IIsle isle, IIsle parentIsle, Vector3 position)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Model_View_IslandEngineActions_SetIsleEngineAction___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined8 local_48;
		  undefined4 local_40;
		  undefined8 local_38;
		  undefined4 local_30;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a58ca1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&CloudsFly_IIsleWorldObjectEngine_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_Base_IIsle_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17937);
		    DAT_ram_00a58ca1 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x10);
		  uVar4 = *(undefined4 *)(param1 + 0xc);
		  piVar5 = *(int **)(param1 + 8);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (CloudsFly_IIsleWorldObjectEngine_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f951b9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,CloudsFly_IIsleWorldObjectEngine_TypeInfo,0);
		code_r0x80f951b9:
		  (**(code **)((ulonglong)*puVar2 * 4))(&local_2c,piVar5,uVar3,puVar2[1]);
		  local_8 = *(undefined4 *)(param1 + 0x1c);
		  local_10 = *(undefined8 *)(param1 + 0x14);
		  uVar1 = 0;
		  local_18 = local_24;
		  local_20 = local_2c;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (CloudsFly_IIsleWorldObjectEngine_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x80f95266;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,CloudsFly_IIsleWorldObjectEngine_TypeInfo,1);
		code_r0x80f95266:
		  local_30 = local_18;
		  local_40 = local_8;
		  local_38 = local_20;
		  local_48 = local_10;
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4,&local_38,&local_48,puVar2[1]);
		  uVar1 = 0;
		  piVar5 = *(int **)(param1 + 0xc);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Isles_Base_IIsle_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f95323;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_Isles_Base_IIsle_TypeInfo,0);
		code_r0x80f95323:
		  local_10 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_10);
		  uVar3 = func_ii_4419(StringLiteral_17937,uVar3,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar3,0);
		  (**(code **)((ulonglong)*(uint *)(param2 + 0xc) * 4))
		            (*(undefined4 *)(param2 + 0x20),param1,*(undefined4 *)(param2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x665C", Offset = "0x665C", VA = "0x665C", Slot = "5")]
		public override void Invoke(Action<BaseIsleEngineAction> endCallback)
		{
		/* --- GHIDRA: Invoke ---
		void Gameplay_World_Model_View_IslandEngineActions_SetIsleEngineAction__Invoke
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a58ca2 == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_IIsleWorldObjectEngine_TypeInfo);
		    DAT_ram_00a58ca2 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (CloudsFly_IIsleWorldObjectEngine_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0);
		        goto code_r0x80f9542e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,CloudsFly_IIsleWorldObjectEngine_TypeInfo,6);
		code_r0x80f9542e:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x665D", Offset = "0x665D", VA = "0x665D", Slot = "6")]
		public override void Cancel()
		{
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x665E", Offset = "0x665E", VA = "0x665E", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x04000AF1 RID: 2801
		[Token(Token = "0x4000AF1")]
		[FieldOffset(Offset = "0xC")]
		private IIsle _isle;

		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		[FieldOffset(Offset = "0x10")]
		private IIsle _parentIsle;

		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 _position;
	}
}
