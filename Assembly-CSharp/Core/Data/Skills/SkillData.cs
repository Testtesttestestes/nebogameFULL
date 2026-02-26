using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Data.Skills
{
	// Token: 0x020010D4 RID: 4308
	[Token(Token = "0x20010D4")]
	public class SkillData
	{
		// Token: 0x060064ED RID: 25837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064ED")]
		[Address(RVA = "0x1DA6", Offset = "0x1DA6", VA = "0x1DA6")]
		public SkillData(int id)
		{
		/* --- GHIDRA: <ToFormattedString>g__GetRelativeStringWithSign|6_0 ---
		undefined4
		Core_Data_Skills_SkillData___ToFormattedString_g__GetRelativeStringWithSign_6_0
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a6082a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_14378);
		    DAT_ram_00a6082a = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 8);
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  local_10 = *(undefined8 *)(param1 + 0x10);
		  param3 = func_ii_1081(DAT_ram_00a66964,&local_10);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_14378,uVar1,param3,0);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Core_Data_Skills_SkillData___ctor(int param1,undefined4 param2,int param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  uint uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param2_00;
		  int *piVar6;
		  int iVar7;
		  int iVar8;
		  uint uVar9;
		  int iVar10;
		  int iVar11;
		  int *piVar12;
		  
		  uVar9 = 0;
		  if (*(int *)(param1 + 8) != 0) {
		    piVar6 = *(int **)(param1 + 0x1c);
		    iVar7 = *(int *)(*(int *)(*(int *)(*(int *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0x58) +
		                                      0x10) + 0x60) + 0x10);
		    if ((*(byte *)(iVar7 + 0xbd) & 1) == 0) {
		      iVar7 = func_ii_1079(iVar7);
		    }
		    iVar10 = *piVar6;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (iVar7 == *(int *)(*(int *)(iVar10 + 0x58) + uVar9 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar9 * 8 + 4) * 8 + iVar10 + 200);
		          goto code_r0x81d566c1;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar9);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,iVar7,1);
		code_r0x81d566c1:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,param2,puVar2[1]);
		    uVar9 = *(int *)(*(int *)(param1 + 8) +
		                     ((int)(uVar3 & 0x7fffffff) % *(int *)(*(int *)(param1 + 8) + 0xc)) * 4 + 0x10)
		            - 1;
		    if (-1 < (int)uVar9) {
		      iVar10 = *(int *)(param1 + 0xc);
		      iVar7 = 0;
		      do {
		        puVar2 = (uint *)(iVar10 + 0x10 + uVar9 * 0xc);
		        if (*puVar2 == (uVar3 & 0x7fffffff)) {
		          uVar9 = puVar2[2];
		          piVar6 = *(int **)(param1 + 0x1c);
		          iVar8 = *(int *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0x10);
		          if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		            iVar8 = func_ii_1079(iVar8);
		          }
		          iVar11 = *piVar6;
		          if (*(ushort *)(iVar11 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar12 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		              if (iVar8 == *piVar12) {
		                puVar4 = (uint *)(iVar11 + piVar12[1] * 8 + 0xc0);
		                goto code_r0x81d567b4;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		          }
		          puVar4 = (uint *)func_ii_1080(piVar6,iVar8,0);
		code_r0x81d567b4:
		          iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar9,param2,puVar4[1]);
		          if (iVar8 != 0) {
		            return 1;
		          }
		        }
		        if (*(int *)(iVar10 + 0xc) <= iVar7) {
		          uVar5 = unnamed_function_2232(&System_InvalidOperationException_TypeInfo);
		          uVar5 = unnamed_function_1417(uVar5);
		          param2_00 = unnamed_function_2232(&StringLiteral_12017);
		          func_ii_3057(uVar5,param2_00,0);
		          func_ii_1050(uVar5,param3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar7 = iVar7 + 1;
		        uVar9 = puVar2[1];
		      } while (-1 < (int)uVar9);
		    }
		  }
		  return 0;
		}
		*/

		}

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x060064EE RID: 25838 RVA: 0x00013398 File Offset: 0x00011598
		[Token(Token = "0x1700146F")]
		public bool IsZero
		{
			[Token(Token = "0x60064EE")]
			[Address(RVA = "0x1DA5", Offset = "0x1DA5", VA = "0x1DA5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064EF")]
		[Address(RVA = "0x1DE0", Offset = "0x1DE0", VA = "0x1DE0")]
		public string ToFormattedString()
		{
			return null;
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F0")]
		[Address(RVA = "0xB0CA", Offset = "0xB0CA", VA = "0xB0CA")]
		public SkillData Clone()
		{
		/* --- GHIDRA: Clone ---
		int Core_Data_Skills_SkillData__Clone(undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  ulonglong uVar2;
		  
		  if (DAT_ram_00a60826 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillData_TypeInfo);
		    DAT_ram_00a60826 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Data_Skills_SkillData_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param1;
		  uVar2 = (ulonglong)(int)(((uint)param2 & 0x40000000) << 1 | (uint)param2 & 0x7fffffff);
		  *(ulonglong *)(iVar1 + 0x18) = uVar2 & (longlong)((ulonglong)(uint)param2 << 0x20) >> 0x3f;
		  if (((uint)param2 & 0x80000000) != 0) {
		    uVar2 = 0;
		  }
		  *(ulonglong *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F1")]
		[Address(RVA = "0xB0CB", Offset = "0xB0CB", VA = "0xB0CB")]
		public static SkillData CreateFromRaw(int skillId, long skillRawValue)
		{
		/* --- GHIDRA: CreateFromRaw ---
		int Core_Data_Skills_SkillData__CreateFromRaw(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60827 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillData_TypeInfo);
		    DAT_ram_00a60827 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 8);
		  iVar1 = unnamed_function_1417(Core_Data_Skills_SkillData_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  *(longlong *)(iVar1 + 0x10) = *(longlong *)(param2 + 0x10) + *(longlong *)(param1 + 0x10);
		  *(longlong *)(iVar1 + 0x18) = *(longlong *)(param2 + 0x18) + *(longlong *)(param1 + 0x18);
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F2")]
		[Address(RVA = "0xB0CC", Offset = "0xB0CC", VA = "0xB0CC")]
		public static SkillData operator +(SkillData a, SkillData b)
		{
			return null;
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F3")]
		[Address(RVA = "0xB0CD", Offset = "0xB0CD", VA = "0xB0CD")]
		public static SkillData operator -(SkillData a, SkillData b)
		{
			return null;
		}

		// Token: 0x060064F4 RID: 25844 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064F4")]
		[Address(RVA = "0xB0CE", Offset = "0xB0CE", VA = "0xB0CE")]
		[CompilerGenerated]
		private string <ToFormattedString>g__GetRelativeStringWithSign|6_0()
		{
			return null;
		}

		// Token: 0x040035D4 RID: 13780
		[Token(Token = "0x40035D4")]
		[FieldOffset(Offset = "0x8")]
		public int Id;

		// Token: 0x040035D5 RID: 13781
		[Token(Token = "0x40035D5")]
		[FieldOffset(Offset = "0x10")]
		public long AbsoluteValue;

		// Token: 0x040035D6 RID: 13782
		[Token(Token = "0x40035D6")]
		[FieldOffset(Offset = "0x18")]
		public long RelativeValue;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: op_Addition ---
		int Core_Data_Skills_SkillData__op_Addition(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a60828 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillData_TypeInfo);
		    DAT_ram_00a60828 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 8);
		  iVar1 = unnamed_function_1417(Core_Data_Skills_SkillData_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  *(longlong *)(iVar1 + 0x10) = *(longlong *)(param1 + 0x10) - *(longlong *)(param2 + 0x10);
		  *(longlong *)(iVar1 + 0x18) = *(longlong *)(param1 + 0x18) - *(longlong *)(param2 + 0x18);
		  return iVar1;
		}
		*/


		/* --- GHIDRA: op_Subtraction ---
		undefined4 Core_Data_Skills_SkillData__op_Subtraction(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  longlong lVar2;
		  
		  if (DAT_ram_00a60829 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1226);
		    Mono_Security_ASN1__get_Item(&StringLiteral_708);
		    DAT_ram_00a60829 = '\x01';
		  }
		  lVar2 = *(longlong *)(param1 + 0x18);
		  if (lVar2 < 1) {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    uVar1 = UI_SimpleIconValue__set_IconAssetId((double)lVar2,StringLiteral_28780,0);
		    uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar1,StringLiteral_708,0);
		    return uVar1;
		  }
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar1 = UI_SimpleIconValue__set_IconAssetId((double)lVar2,StringLiteral_28780,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (StringLiteral_1226,uVar1,StringLiteral_708,0);
		  return uVar1;
		}
		*/

}
