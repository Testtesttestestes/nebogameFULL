using System;
using System.Runtime.CompilerServices;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.WorldAxis.Colossus.Combat.Model
{
	// Token: 0x0200033B RID: 827
	[Token(Token = "0x200033B")]
	public class ColossusCombatRewards : IColossusCombatRewards
	{
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F5")]
		public int[] ColossusScores
		{
			[Token(Token = "0x600130F")]
			[Address(RVA = "0x6505", Offset = "0x6505", VA = "0x6505", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x170002F6")]
		public double CombatWinTakeOffTax
		{
			[Token(Token = "0x6001310")]
			[Address(RVA = "0x6506", Offset = "0x6506", VA = "0x6506", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F7")]
		public ResourceSet CombatWinTakeOff
		{
			[Token(Token = "0x6001311")]
			[Address(RVA = "0x6507", Offset = "0x6507", VA = "0x6507", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F8")]
		public ResourceSet CombatWinReward
		{
			[Token(Token = "0x6001312")]
			[Address(RVA = "0x6508", Offset = "0x6508", VA = "0x6508", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001313")]
		[Address(RVA = "0x6509", Offset = "0x6509", VA = "0x6509")]
		public ColossusCombatRewards(IDictProvider dictProvider)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatRewards___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  uVar1 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(param1 + 0x1c),0);
		  uVar2 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(param1 + 0x18),0);
		  uVar2 = Core_Extensions_Dict_ResourceSetExt__Round(uVar2,1.0 - *(double *)(param1 + 0x10),0);
		  uVar1 = Core_Extensions_Dict_RegularOptionDicExt__GetBankBgAssetId(uVar1,uVar2,0);
		  uVar1 = Core_Extensions_Dict_ResourceSetExt__Ceil(uVar1,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001314")]
		[Address(RVA = "0x650A", Offset = "0x650A", VA = "0x650A", Slot = "8")]
		public ResourceSet GetResources()
		{
			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CombatWinReward ---
		void Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatRewards__get_CombatWinReward
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  double dVar4;
		  int iVar5;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a58c1d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_Dict_DictExt_GetArrayParameter_int___);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21422);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21855);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21857);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21856);
		    DAT_ram_00a58c1d = '\x01';
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80f84c1e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f84c1e:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  dVar4 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar3,StringLiteral_21857,0);
		  *(double *)(param1 + 0x10) = dVar4;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80f84caf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f84caf:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__BinarySearch_object____Il2CppFullySharedGenericType_
		                    (uVar3,StringLiteral_21422,
		                     Method_Core_Extensions_Dict_DictExt_GetArrayParameter_int___);
		  *(undefined4 *)(param1 + 8) = uVar3;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80f84d46;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f84d46:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetBoolParameter(uVar3,StringLiteral_21856,0);
		  *(undefined4 *)(param1 + 0x18) = uVar3;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80f84ddb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80f84ddb:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Core_Extensions_Dict_DictExt__GetBoolParameter(uVar3,StringLiteral_21855,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar3;
		  return;
		}
		*/

}
