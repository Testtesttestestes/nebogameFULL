using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Balance;
using Protocol.Common;
using Utils;

namespace Gameplay.User.Model
{
	// Token: 0x0200041E RID: 1054
	[Token(Token = "0x200041E")]
	public class EnergyRegenStatus : IDisposable
	{
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x1700045B")]
		public uint MaxEnergy
		{
			[Token(Token = "0x60018E5")]
			[Address(RVA = "0x6A84", Offset = "0x6A84", VA = "0x6A84")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060018E7 RID: 6375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045C")]
		public BackTime EnergyRecoveryBacktime
		{
			[Token(Token = "0x60018E6")]
			[Address(RVA = "0x6A85", Offset = "0x6A85", VA = "0x6A85")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018E7")]
			[Address(RVA = "0x6A86", Offset = "0x6A86", VA = "0x6A86")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045D")]
		public BackTime FullEnergyRecoveryBacktime
		{
			[Token(Token = "0x60018E8")]
			[Address(RVA = "0x6A87", Offset = "0x6A87", VA = "0x6A87")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018E9")]
			[Address(RVA = "0x6A88", Offset = "0x6A88", VA = "0x6A88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x6A89", Offset = "0x6A89", VA = "0x6A89")]
		public EnergyRegenStatus(ResourceSet money, ProtoGetEnergyRegenStatusAns status, double energyRecoveryIncrementPercentPerInterval, uint energyRecoveryIncrementInterval)
		{
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x6A8A", Offset = "0x6A8A", VA = "0x6A8A", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4 Gameplay_User_Model_EnergyRegenStatus__Dispose(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5994e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26141);
		    DAT_ram_00a5994e = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x40);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x81095f6f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81095f6f:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar3,StringLiteral_26141,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x04000D29 RID: 3369
		[Token(Token = "0x4000D29")]
		[FieldOffset(Offset = "0x8")]
		private ProtoGetEnergyRegenStatusAns _status;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FullEnergyRecoveryBacktime ---
		void Gameplay_User_Model_EnergyRegenStatus__set_FullEnergyRecoveryBacktime
		               (int param1,int param2,int param3,double param4,uint param5,undefined4 param6)
		
		{
		  float fVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  double dVar4;
		  double param2_00;
		  double dVar5;
		  longlong lVar6;
		  longlong param1_00;
		  
		  uVar3 = 0;
		  if (DAT_ram_00a5994d == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5994d = '\x01';
		  }
		  if (*(double *)(param2 + 0x20) < (double)*(uint *)(param3 + 0x10)) {
		    uVar3 = *(uint *)(param3 + 0xc);
		  }
		  *(int *)(param1 + 8) = param3;
		  *(uint *)(param3 + 0xc) = uVar3;
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar1 = func_ii_7331((ulonglong)uVar3,0);
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,fVar1,0);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  if (uVar3 != 0) {
		    dVar4 = (double)*(uint *)(*(int *)(param1 + 8) + 0x10);
		    param2_00 = dVar4 * param4;
		    dVar5 = *(double *)(param2 + 0x20);
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    dVar4 = System_Decimal__Max(dVar5 + param2_00,dVar4,0);
		    dVar4 = func_ii_6931((double)*(uint *)(*(int *)(param1 + 8) + 0x10) - dVar4,param2_00,0);
		    dVar4 = CEIL(dVar4) * (double)param5 + (double)uVar3;
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    if (dVar4 < 1.8446744073709552e+19 && 0.0 <= dVar4) {
		      lVar6 = (longlong)dVar4;
		    }
		    else {
		      lVar6 = 0;
		    }
		    if (ABS(dVar4) < 9.223372036854776e+18) {
		      param1_00 = (longlong)dVar4;
		    }
		    else {
		      param1_00 = -0x8000000000000000;
		    }
		    if (0.0 <= dVar4) {
		      param1_00 = lVar6;
		    }
		    fVar1 = Utils_StringUtils___cctor(param1_00,0);
		    uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,fVar1,0);
		    *(undefined4 *)(param1 + 0x10) = uVar2;
		    return;
		  }
		  uVar2 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar2,0.0,0);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  return;
		}
		*/

}
