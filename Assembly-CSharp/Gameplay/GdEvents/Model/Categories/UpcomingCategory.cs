using System;
using Core.GameTime;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.Model.Categories
{
	// Token: 0x02000762 RID: 1890
	[Token(Token = "0x2000762")]
	public class UpcomingCategory : AbstractGdEventCatData
	{
		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x00008AA8 File Offset: 0x00006CA8
		[Token(Token = "0x170008AD")]
		public override Category Category
		{
			[Token(Token = "0x6002D02")]
			[Address(RVA = "0x7D80", Offset = "0x7D80", VA = "0x7D80", Slot = "6")]
			get
			{
				return Category.Unknown;
			}
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D03")]
		[Address(RVA = "0x7D81", Offset = "0x7D81", VA = "0x7D81")]
		public UpcomingCategory(string title, ICurrentTimeProvider timeProvider, ITimeOffsetProvider timeOffsetProvider, TimerStrings timerStrings)
		{
		/* --- GHIDRA: .ctor ---
		float Gameplay_GdEvents_Model_Categories_UpcomingCategory___ctor
		                (int param1,int param2,undefined4 param3)
		
		{
		  ulonglong uVar1;
		  undefined4 in_register_20000004;
		  uint *puVar2;
		  float fVar3;
		  int *param1_00;
		  int iVar4;
		  ulonglong uVar5;
		  double dVar6;
		  longlong param1_01;
		  uint uVar7;
		  
		  if (DAT_ram_00a5a2f6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5a2f6 = '\x01';
		  }
		  uVar5 = *(ulonglong *)(*(int *)(param2 + 0x10) + 0x18);
		  param1_00 = *(int **)(param1 + 0x14);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811fab73;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x811fab73:
		  uVar1 = (**(code **)((ulonglong)*puVar2 * 4))(CONCAT44(in_register_20000004,param1_00),puVar2[1]);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  dVar6 = (double)uVar5 - (double)uVar1;
		  if (ABS(dVar6) < 9.223372036854776e+18) {
		    param1_01 = (longlong)dVar6;
		  }
		  else {
		    param1_01 = -0x8000000000000000;
		  }
		  fVar3 = func_ii_7331(param1_01,0);
		  return fVar3;
		}
		*/

		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x00008AC0 File Offset: 0x00006CC0
		[Token(Token = "0x6002D04")]
		[Address(RVA = "0x7D82", Offset = "0x7D82", VA = "0x7D82", Slot = "7")]
		public override float GetBackTime(GdEventData evt)
		{
		/* --- GHIDRA: GetBackTime ---
		uint Gameplay_GdEvents_Model_Categories_UpcomingCategory__GetBackTime
		               (int param1,int param2,undefined4 param3)
		
		{
		  ulonglong uVar1;
		  ulonglong uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  ulonglong uVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a5a2f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo);
		    DAT_ram_00a5a2f7 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x14);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811fac6d;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x811fac6d:
		  uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar7 = 1;
		  uVar6 = *(ulonglong *)(*(int *)(param2 + 0x10) + 0x18);
		  if ((uVar1 < uVar6) && (uVar1 < *(ulonglong *)(*(int *)(param2 + 0x10) + 0x20))) {
		    uVar7 = 0;
		    piVar4 = *(int **)(param1 + 0x10);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		          puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811fad1a;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo,0);
		code_r0x811fad1a:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    uVar7 = (uint)(uVar2 <= uVar6 - uVar1);
		  }
		  return uVar7;
		}
		*/

			return 0f;
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x00008AD8 File Offset: 0x00006CD8
		[Token(Token = "0x6002D05")]
		[Address(RVA = "0x7D83", Offset = "0x7D83", VA = "0x7D83", Slot = "9")]
		public override bool IsBackTimeAvail(GdEventData evt)
		{
		/* --- GHIDRA: IsBackTimeAvail ---
		undefined4
		Gameplay_GdEvents_Model_Categories_UpcomingCategory__IsBackTimeAvail
		          (int param1,int param2,undefined4 param3)
		
		{
		  ulonglong uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  ulonglong uVar4;
		  uint uVar5;
		  ulonglong uVar6;
		  
		  if (DAT_ram_00a5a2f8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    DAT_ram_00a5a2f8 = '\x01';
		  }
		  if (*(char *)(*(int *)(param2 + 0x10) + 0x10) == '\0') {
		    uVar5 = 0;
		    param1_00 = *(int **)(param1 + 0x14);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811fadd9;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar5);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x811fadd9:
		    uVar1 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    uVar4 = *(ulonglong *)(*(int *)(param2 + 0x10) + 0x20);
		    uVar6 = *(ulonglong *)(*(int *)(param2 + 0x10) + 0x18);
		    if (uVar1 < uVar6 && uVar1 < uVar4) {
		      return 1;
		    }
		    if ((uVar6 < uVar1) && (uVar1 != uVar4)) {
		      return 1;
		    }
		  }
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[Token(Token = "0x6002D06")]
		[Address(RVA = "0x7D84", Offset = "0x7D84", VA = "0x7D84", Slot = "10")]
		public override bool IsFit(GdEventData evt)
		{
		/* --- GHIDRA: IsFit ---
		undefined4
		Gameplay_GdEvents_Model_Categories_UpcomingCategory__IsFit
		          (int param1,int param2,int param3,undefined4 param4)
		
		{
		  ulonglong uVar1;
		  ulonglong uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  ulonglong uVar7;
		  ulonglong uVar8;
		  uint uVar9;
		  undefined4 *puVar10;
		  
		  if (DAT_ram_00a5a2f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17268);
		    DAT_ram_00a5a2f9 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x14);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar9 = 0;
		    do {
		      if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8)) {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811faecc;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar9);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x811faecc:
		  uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  iVar5 = *(int *)(param2 + 0x10);
		  if (*(char *)(iVar5 + 0x10) == '\0') {
		    uVar7 = *(ulonglong *)(iVar5 + 0x20);
		    uVar8 = *(ulonglong *)(iVar5 + 0x18);
		    if ((uVar1 < uVar8) && (uVar1 < uVar7)) {
		      uVar9 = 0;
		      piVar4 = *(int **)(param1 + 0x10);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8)) {
		            puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811faf8a;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar9);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo,0);
		code_r0x811faf8a:
		      uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		      if (uVar2 < uVar8 - uVar1) {
		        return *(undefined4 *)(param3 + 8);
		      }
		      uVar9 = 0;
		      piVar4 = *(int **)(param1 + 0x10);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8)) {
		            puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811fb019;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar9);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo,0);
		code_r0x811fb019:
		      uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		      if (uVar8 - uVar1 < uVar2) {
		        return *(undefined4 *)(param3 + 0x10);
		      }
		    }
		    if ((uVar8 < uVar1) && (uVar7 < uVar1)) {
		      return *(undefined4 *)(param3 + 0x18);
		    }
		    puVar10 = &StringLiteral_17268;
		    if (uVar1 < uVar7) {
		      puVar10 = (undefined4 *)(param3 + 0x18);
		    }
		    puVar6 = &StringLiteral_17268;
		    if (uVar8 < uVar1) {
		      puVar6 = puVar10;
		    }
		  }
		  else {
		    puVar6 = &StringLiteral_17268;
		  }
		  return *puVar6;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002D07")]
		[Address(RVA = "0x7D85", Offset = "0x7D85", VA = "0x7D85", Slot = "8")]
		public override string GetBackTimeTitle(GdEventData evt, TimerStrings timerStrings)
		{
		/* --- GHIDRA: GetBackTimeTitle ---
		void Gameplay_GdEvents_Model_Categories_UpcomingCategory__GetBackTimeTitle
		               (int param1,undefined4 param2)
		
		{
		  undefined8 uVar1;
		  uint uVar2;
		  int param2_00;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  undefined4 param1_02;
		  
		  if (DAT_ram_00a5a2fa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_LinqExtensions_Sort_GdEventData___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_Model_Categories_UpcomingCategory___c__DisplayClass7_0__Sort_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Model_Categories_UpcomingCategory___c__DisplayClass7_0_TypeInfo);
		    DAT_ram_00a5a2fa = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_GdEvents_Model_Categories_UpcomingCategory___c__DisplayClass7_0_TypeInfo
		                        );
		  param1_01 = *(int **)(param1 + 0x14);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811fb12f;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x811fb12f:
		  uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  *(undefined8 *)(param2_00 + 8) = uVar1;
		  param1_02 = *(undefined4 *)(param1 + 0xc);
		  param1_00 = unnamed_function_1417(System_Comparison_GdEventData__TypeInfo);
		  System_Collections_Generic_Comparer_object___get_Default
		            (param1_00,param2_00,
		             Method_Gameplay_GdEvents_Model_Categories_UpcomingCategory___c__DisplayClass7_0__Sort_b__0__
		             ,0);
		  Sirenix_Utilities_LinqExtensions__Sort___Il2CppFullySharedGenericType_
		            (param1_02,param1_00,Method_Sirenix_Utilities_LinqExtensions_Sort_GdEventData___);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D08")]
		[Address(RVA = "0x7D86", Offset = "0x7D86", VA = "0x7D86", Slot = "11")]
		protected override void Sort()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Category ---
		void Gameplay_GdEvents_Model_Categories_UpcomingCategory__get_Category
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a2eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GdEventData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GdEventData__TypeInfo);
		    DAT_ram_00a5a2eb = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_GdEventData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_GdEventData___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  *(undefined4 *)(param1 + 0x18) = param5;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  return;
		}
		*/

}
