using System;
using Core.GameTime;
using Il2CppDummyDll;

namespace Gameplay.GdEvents.Model.Categories
{
	// Token: 0x0200075F RID: 1887
	[Token(Token = "0x200075F")]
	public class CurrentCategory : AbstractGdEventCatData
	{
		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x00008A30 File Offset: 0x00006C30
		[Token(Token = "0x170008AC")]
		public override Category Category
		{
			[Token(Token = "0x6002CF7")]
			[Address(RVA = "0x7D75", Offset = "0x7D75", VA = "0x7D75", Slot = "6")]
			get
			{
				return Category.Unknown;
			}
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CF8")]
		[Address(RVA = "0x7D76", Offset = "0x7D76", VA = "0x7D76")]
		public CurrentCategory(string title, ICurrentTimeProvider timeProvider, ITimeOffsetProvider timeOffsetProvider, TimerStrings timerStrings)
		{
		/* --- GHIDRA: .ctor ---
		float Gameplay_GdEvents_Model_Categories_CurrentCategory___ctor
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
		  
		  if (DAT_ram_00a5a2ef == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5a2ef = '\x01';
		  }
		  uVar5 = *(ulonglong *)(*(int *)(param2 + 0x10) + 0x20);
		  param1_00 = *(int **)(param1 + 0x14);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811fa499;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x811fa499:
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

		// Token: 0x06002CF9 RID: 11513 RVA: 0x00008A48 File Offset: 0x00006C48
		[Token(Token = "0x6002CF9")]
		[Address(RVA = "0x7D77", Offset = "0x7D77", VA = "0x7D77", Slot = "7")]
		public override float GetBackTime(GdEventData evt)
		{
		/* --- GHIDRA: GetBackTime ---
		uint Gameplay_GdEvents_Model_Categories_CurrentCategory__GetBackTime
		               (int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  ulonglong uVar2;
		  ulonglong uVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  ulonglong uVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a5a2f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo);
		    DAT_ram_00a5a2f0 = '\x01';
		  }
		  piVar5 = *(int **)(param1 + 0x14);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar8 = 0;
		    do {
		      if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		        puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811fa593;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar5,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x811fa593:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		  uVar7 = *(ulonglong *)(*(int *)(param2 + 0x10) + 0x20);
		  bVar1 = uVar2 <= *(ulonglong *)(*(int *)(param2 + 0x10) + 0x18);
		  if ((!bVar1) && (uVar2 < uVar7)) {
		    uVar8 = 0;
		    piVar5 = *(int **)(param1 + 0x10);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		          puVar4 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811fa642;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo,0);
		code_r0x811fa642:
		    uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    if (uVar7 - uVar2 < uVar3) {
		      return 0;
		    }
		  }
		  return (uint)(uVar2 <= uVar7 || bVar1);
		}
		*/

			return 0f;
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x00008A60 File Offset: 0x00006C60
		[Token(Token = "0x6002CFA")]
		[Address(RVA = "0x7D78", Offset = "0x7D78", VA = "0x7D78", Slot = "9")]
		public override bool IsBackTimeAvail(GdEventData evt)
		{
		/* --- GHIDRA: IsBackTimeAvail ---
		uint Gameplay_GdEvents_Model_Categories_CurrentCategory__IsBackTimeAvail
		               (int param1,int param2,undefined4 param3)
		
		{
		  ulonglong uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  uint uVar4;
		  ulonglong uVar5;
		  ulonglong uVar6;
		  
		  uVar4 = 0;
		  if (DAT_ram_00a5a2f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    DAT_ram_00a5a2f1 = '\x01';
		  }
		  if (*(char *)(*(int *)(param2 + 0x10) + 0x10) != '\0') {
		    param1_00 = *(int **)(param1 + 0x14);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811fa70a;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x811fa70a:
		    uVar1 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    uVar5 = *(ulonglong *)(*(int *)(param2 + 0x10) + 0x20);
		    uVar6 = *(ulonglong *)(*(int *)(param2 + 0x10) + 0x18);
		    if ((uVar6 <= uVar1) || (uVar4 = 1, uVar5 <= uVar1)) {
		      uVar4 = (uint)(uVar1 != uVar5 && uVar6 < uVar1);
		    }
		  }
		  return uVar4;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x00008A78 File Offset: 0x00006C78
		[Token(Token = "0x6002CFB")]
		[Address(RVA = "0x7D79", Offset = "0x7D79", VA = "0x7D79", Slot = "10")]
		public override bool IsFit(GdEventData evt)
		{
		/* --- GHIDRA: IsFit ---
		undefined4
		Gameplay_GdEvents_Model_Categories_CurrentCategory__IsFit
		          (int param1,int param2,int param3,undefined4 param4)
		
		{
		  ulonglong uVar1;
		  ulonglong uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  uint uVar7;
		  undefined4 *puVar8;
		  ulonglong uVar9;
		  ulonglong uVar10;
		  
		  if (DAT_ram_00a5a2f2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6020);
		    DAT_ram_00a5a2f2 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x14);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811fa7f9;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x811fa7f9:
		  uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  iVar5 = *(int *)(param2 + 0x10);
		  if (*(char *)(iVar5 + 0x10) == '\0') {
		    return StringLiteral_6020;
		  }
		  uVar9 = *(ulonglong *)(iVar5 + 0x18);
		  uVar10 = *(ulonglong *)(iVar5 + 0x20);
		  if (uVar9 <= uVar1 || uVar10 <= uVar1) {
		    if ((uVar9 < uVar1) && (uVar1 < uVar10)) {
		      uVar7 = 0;
		      piVar4 = *(int **)(param1 + 0x10);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		            puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811fa8c6;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo,0);
		code_r0x811fa8c6:
		      uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		      if (uVar2 < uVar10 - uVar1) goto code_r0x811fa8dd;
		      uVar7 = 0;
		      piVar4 = *(int **)(param1 + 0x10);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		            puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811fa956;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_GdEvents_Model_ITimeOffsetProvider_TypeInfo,0);
		code_r0x811fa956:
		      uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		      if (uVar10 - uVar1 < uVar2) {
		        return *(undefined4 *)(param3 + 0x14);
		      }
		    }
		    puVar8 = &StringLiteral_6020;
		    if (uVar10 < uVar1) {
		      puVar8 = (undefined4 *)(param3 + 0x14);
		    }
		    puVar6 = &StringLiteral_6020;
		    if (uVar9 < uVar1) {
		      puVar6 = puVar8;
		    }
		    return *puVar6;
		  }
		code_r0x811fa8dd:
		  return *(undefined4 *)(param3 + 0xc);
		}
		*/

			return default(bool);
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002CFC")]
		[Address(RVA = "0x7D7A", Offset = "0x7D7A", VA = "0x7D7A", Slot = "8")]
		public override string GetBackTimeTitle(GdEventData evt, TimerStrings timerStrings)
		{
		/* --- GHIDRA: GetBackTimeTitle ---
		void Gameplay_GdEvents_Model_Categories_CurrentCategory__GetBackTimeTitle
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  int param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5a2f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_GdEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_LinqExtensions_Sort_GdEventData___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_Model_Categories_CurrentCategory___c__Sort_b__7_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_Categories_CurrentCategory___c_TypeInfo);
		    DAT_ram_00a5a2f3 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xc);
		  if (*(int *)(Gameplay_GdEvents_Model_Categories_CurrentCategory___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_GdEvents_Model_Categories_CurrentCategory___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Gameplay_GdEvents_Model_Categories_CurrentCategory___c_TypeInfo + 0x5c);
		  param1_01 = puVar1[1];
		  if (param1_01 == 0) {
		    if (*(int *)(Gameplay_GdEvents_Model_Categories_CurrentCategory___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_GdEvents_Model_Categories_CurrentCategory___c_TypeInfo);
		      puVar1 = *(undefined4 **)
		                (Gameplay_GdEvents_Model_Categories_CurrentCategory___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    param1_01 = unnamed_function_1417(System_Comparison_GdEventData__TypeInfo);
		    System_Collections_Generic_Comparer_object___get_Default
		              (param1_01,param2_00,
		               Method_Gameplay_GdEvents_Model_Categories_CurrentCategory___c__Sort_b__7_0__,0);
		    *(int *)(*(int *)(Gameplay_GdEvents_Model_Categories_CurrentCategory___c_TypeInfo + 0x5c) + 4) =
		         param1_01;
		  }
		  Sirenix_Utilities_LinqExtensions__Sort___Il2CppFullySharedGenericType_
		            (param1_00,param1_01,Method_Sirenix_Utilities_LinqExtensions_Sort_GdEventData___);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CFD")]
		[Address(RVA = "0x7D7B", Offset = "0x7D7B", VA = "0x7D7B", Slot = "11")]
		protected override void Sort()
		{
		/* --- GHIDRA: Sort ---
		void Gameplay_GdEvents_Model_Categories_CurrentCategory__Sort(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a2f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GdEvents_Model_Categories_CurrentCategory___c_TypeInfo);
		    DAT_ram_00a5a2f4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_GdEvents_Model_Categories_CurrentCategory___c_TypeInfo);
		  **(undefined4 **)(Gameplay_GdEvents_Model_Categories_CurrentCategory___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}
	}
}
