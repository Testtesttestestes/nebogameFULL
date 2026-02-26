using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Decorators;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Core.Data
{
	// Token: 0x020010C2 RID: 4290
	[Token(Token = "0x20010C2")]
	public class RewardData
	{
		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x0600643C RID: 25660 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700142E")]
		public IRewardInfo RewardInfo
		{
			[Token(Token = "0x600643C")]
			[Address(RVA = "0x1C3A", Offset = "0x1C3A", VA = "0x1C3A")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x0600643D RID: 25661 RVA: 0x00013068 File Offset: 0x00011268
		[Token(Token = "0x1700142F")]
		public uint RewardId
		{
			[Token(Token = "0x600643D")]
			[Address(RVA = "0x1F67", Offset = "0x1F67", VA = "0x1F67")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x0600643E RID: 25662 RVA: 0x00013080 File Offset: 0x00011280
		[Token(Token = "0x17001430")]
		public uint SortIndex
		{
			[Token(Token = "0x600643E")]
			[Address(RVA = "0xB030", Offset = "0xB030", VA = "0xB030")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x0600643F RID: 25663 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006440 RID: 25664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001431")]
		public List<object> CustomParams
		{
			[Token(Token = "0x600643F")]
			[Address(RVA = "0xB031", Offset = "0xB031", VA = "0xB031")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006440")]
			[Address(RVA = "0xB032", Offset = "0xB032", VA = "0xB032")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006441 RID: 25665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006441")]
		[Address(RVA = "0xB033", Offset = "0xB033", VA = "0xB033")]
		public RewardData(List<IRewardInfo> rewardInfoList)
		{
		/* --- GHIDRA: .ctor ---
		int Core_Data_RewardData___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a607e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IRewardInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IRewardInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IRewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_RewardData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_RewardInfoDecorator_TypeInfo);
		    DAT_ram_00a607e7 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_IRewardInfo__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_IRewardInfo___ctor__);
		  param1_01 = unnamed_function_1417(Core_Data_Decorators_RewardInfoDecorator_TypeInfo);
		  Core_Data_Decorators_RewardInfoDecorator___ctor(param1_01,param1,param1_00);
		  iVar1 = Method_System_Collections_Generic_List_IRewardInfo__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar1 = unnamed_function_1417(Core_Data_RewardData_TypeInfo);
		  *(int *)(iVar1 + 8) = param1_00;
		  return iVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		int Core_Data_RewardData___ctor(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a607e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IRewardInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IRewardInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IRewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_RewardData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Decorators_RewardInfoDecorator_TypeInfo);
		    DAT_ram_00a607e7 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_IRewardInfo__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_IRewardInfo___ctor__);
		  param1_01 = unnamed_function_1417(Core_Data_Decorators_RewardInfoDecorator_TypeInfo);
		  Core_Data_Decorators_RewardInfoDecorator___ctor(param1_01,param1,param1_00);
		  iVar1 = Method_System_Collections_Generic_List_IRewardInfo__Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param1_01;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  iVar1 = unnamed_function_1417(Core_Data_RewardData_TypeInfo);
		  *(int *)(iVar1 + 8) = param1_00;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06006442 RID: 25666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006442")]
		[Address(RVA = "0xB034", Offset = "0xB034", VA = "0xB034")]
		public RewardData()
		{
		}

		// Token: 0x06006443 RID: 25667 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006443")]
		[Address(RVA = "0xB035", Offset = "0xB035", VA = "0xB035")]
		public static RewardData Create(RewardTypes id)
		{
		/* --- GHIDRA: Create ---
		void Core_Data_RewardData__Create(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a607e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a607e8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
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

			return null;
		}

		// Token: 0x0400358A RID: 13706
		[Token(Token = "0x400358A")]
		[FieldOffset(Offset = "0x8")]
		public readonly List<IRewardInfo> RewardInfoList;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RewardId ---
		undefined4 Core_Data_RewardData__get_RewardId(undefined4 param1,undefined4 param2,int param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar4 = *(int *)(param3 + 0x1c);
		  if (iVar4 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		    iVar4 = *(int *)(param3 + 0x1c);
		  }
		  iVar4 = *(int *)(iVar4 + 4);
		  if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		    iVar4 = func_ii_1079(iVar4);
		  }
		  param1_00 = (int *)func_ii_1082(param1,iVar4);
		  if (param1_00 == (int *)0x0) {
		    uVar3 = System_Linq_Enumerable__Contains_int_
		                      (param1,param2,0,*(undefined4 *)(*(int *)(param3 + 0x1c) + 0x10));
		    return uVar3;
		  }
		  iVar4 = *(int *)(*(int *)(param3 + 0x1c) + 4);
		  if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		    iVar4 = func_ii_1079(iVar4);
		  }
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (iVar4 == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x8274637b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,iVar4,4);
		code_r0x8274637b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  return uVar3;
		}
		*/

}
