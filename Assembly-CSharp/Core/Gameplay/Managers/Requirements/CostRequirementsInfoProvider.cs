using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Balance;
using Core.Data.InfoRows;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Gameplay.Managers.Requirements
{
	// Token: 0x02001193 RID: 4499
	[Token(Token = "0x2001193")]
	public class CostRequirementsInfoProvider : AbstractInformationProvider
	{
		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06006AE5 RID: 27365 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006AE6 RID: 27366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D8")]
		public ResourceSet Cost
		{
			[Token(Token = "0x6006AE5")]
			[Address(RVA = "0xB5F5", Offset = "0xB5F5", VA = "0xB5F5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AE6")]
			[Address(RVA = "0xB5F6", Offset = "0xB5F6", VA = "0xB5F6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AE7")]
		[Address(RVA = "0xB5F7", Offset = "0xB5F7", VA = "0xB5F7", Slot = "7")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  *(undefined4 *)(param1 + 0x18) = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  Core_Data_InfoRows_AbstractInformationProvider__Dispose(param1,param3,0,0);
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  *(undefined4 *)(param1 + 0x20) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AE8")]
		[Address(RVA = "0xB5F8", Offset = "0xB5F8", VA = "0xB5F8")]
		public CostRequirementsInfoProvider(IBalanceSource balanceSource, UserData loggedUser, ResourceSet cost)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider___ctor
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int iVar6;
		  int *piVar7;
		  
		  if (DAT_ram_00a638d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13140);
		    DAT_ram_00a638d8 = '\x01';
		  }
		  if (param1[6] == 0) {
		    iVar2 = param1[2];
		    piVar7 = (int *)param1[4];
		    uVar1 = 0;
		    uVar3 = Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__PrepareInformation
		                      (param1,0);
		    iVar6 = *piVar7;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		          goto code_r0x823124b0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar7,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,2);
		code_r0x823124b0:
		    (**(code **)((ulonglong)*puVar5 * 4))(piVar7,iVar2,uVar3,puVar5[1]);
		    return;
		  }
		  iVar2 = System_Collections_CollectionBase___ctor
		                    (param1[6],**(undefined4 **)(DAT_ram_00a66978 + 0x5c),0);
		  iVar6 = param1[2];
		  piVar7 = (int *)param1[4];
		  if (iVar2 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = func_ii_7508(StringLiteral_13140,1,0,1,0,0,0,0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,uVar3,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    uVar4 = Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__PrepareInformation
		                      (param1,0);
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		          goto code_r0x823125af;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(piVar7,
		                                  Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                  ,1);
		code_r0x823125af:
		    (**(code **)((ulonglong)*puVar5 * 4))(piVar7,iVar6,uVar3,uVar4,puVar5[1]);
		    return;
		  }
		  iVar2 = *param1;
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                    (param1,param1[6],*(undefined4 *)(iVar2 + 0x104));
		  uVar4 = Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__PrepareInformation
		                    (param1,iVar2);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x8231265a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar7,
		                                Core_Gameplay_Managers_Requirements_ListFillBehaviors_IListFillBehavior_TypeInfo
		                                ,1);
		code_r0x8231265a:
		  (**(code **)((ulonglong)*puVar5 * 4))(piVar7,iVar6,uVar3,uVar4,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AE9")]
		[Address(RVA = "0xB5F9", Offset = "0xB5F9", VA = "0xB5F9", Slot = "9")]
		protected override void PrepareInformation()
		{
		/* --- GHIDRA: PrepareInformation ---
		int Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__PrepareInformation
		              (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  int param1_01;
		  uint uVar2;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a638d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IInformationRow__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_ValueRow_TypeInfo);
		    DAT_ram_00a638d9 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x1c) != 0) &&
		     (iVar1 = Core_Extensions_Dict_ResourceSetExt__GetDelta(*(int *)(param1 + 0x1c),0), iVar1 == 0))
		  {
		    param1_00 = unnamed_function_1417(System_Collections_Generic_List_IInformationRow__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (param1_00,Method_System_Collections_Generic_List_IInformationRow___ctor__);
		    param1_01 = unnamed_function_1417(Core_Data_InfoRows_ValueRow_TypeInfo);
		    System_Collections_Generic_List_object____ctor(param1_01,0);
		    *(undefined4 *)(param1_01 + 0x20) = *(undefined4 *)(param1 + 0x1c);
		    *(undefined4 *)(param1_01 + 0x30) = *(undefined4 *)(param1 + 0xc);
		    *(undefined4 *)(param1_01 + 0x34) = *(undefined4 *)(param1 + 0x20);
		    iVar1 = Method_System_Collections_Generic_List_IInformationRow__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param1_01;
		      return param1_00;
		    }
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006AEA")]
		[Address(RVA = "0xB5FA", Offset = "0xB5FA", VA = "0xB5FA")]
		public List<IInformationRow> GetCost()
		{
			return null;
		}

		// Token: 0x04003887 RID: 14471
		[Token(Token = "0x4003887")]
		public const string REQUIREMENTS_COST = "REQUIREMENTS/COST";

		// Token: 0x04003888 RID: 14472
		[Token(Token = "0x4003888")]
		[FieldOffset(Offset = "0x18")]
		public string CostTitle;

		// Token: 0x0400388A RID: 14474
		[Token(Token = "0x400388A")]
		[FieldOffset(Offset = "0x20")]
		private IBalanceSource _balanceSource;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Cost ---
		void Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__set_Cost
		               (int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x20) = 0;
		  Core_Data_InfoRows_AbstractInformationProvider__set_ListFillBehavior(param1,0);
		  return;
		}
		*/

}
