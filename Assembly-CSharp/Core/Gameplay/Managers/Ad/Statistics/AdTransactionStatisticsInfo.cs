using System;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Ad.Model;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Ad.Statistics
{
	// Token: 0x020011F9 RID: 4601
	[Token(Token = "0x20011F9")]
	public class AdTransactionStatisticsInfo
	{
		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06006D47 RID: 27975 RVA: 0x00014130 File Offset: 0x00012330
		// (set) Token: 0x06006D48 RID: 27976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700163A")]
		public double WatchedTime
		{
			[Token(Token = "0x6006D47")]
			[Address(RVA = "0xB82F", Offset = "0xB82F", VA = "0xB82F")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6006D48")]
			[Address(RVA = "0xB830", Offset = "0xB830", VA = "0xB830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06006D49 RID: 27977 RVA: 0x00014148 File Offset: 0x00012348
		// (set) Token: 0x06006D4A RID: 27978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700163B")]
		public double CloseTime
		{
			[Token(Token = "0x6006D49")]
			[Address(RVA = "0xB831", Offset = "0xB831", VA = "0xB831")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6006D4A")]
			[Address(RVA = "0xB832", Offset = "0xB832", VA = "0xB832")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006D4B RID: 27979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D4B")]
		[Address(RVA = "0xB833", Offset = "0xB833", VA = "0xB833")]
		public AdTransactionStatisticsInfo(AdTransaction transaction)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Ad_Statistics_AdTransactionStatisticsInfo___ctor
		               (int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a764 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a5a764 = '\x01';
		  }
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  func_ii_13875(&local_20,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  lVar1 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		  *(double *)(param1 + 0x20) = (double)lVar1;
		  return;
		}
		*/

		}

		// Token: 0x06006D4C RID: 27980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D4C")]
		[Address(RVA = "0xB834", Offset = "0xB834", VA = "0xB834")]
		public void MarkAsWatched()
		{
		/* --- GHIDRA: MarkAsWatched ---
		void Core_Gameplay_Managers_Ad_Statistics_AdTransactionStatisticsInfo__MarkAsWatched
		               (int param1,undefined4 param2)
		
		{
		  longlong lVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a765 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a5a765 = '\x01';
		  }
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  func_ii_13875(&local_20,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  lVar1 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		  *(double *)(param1 + 0x28) = (double)lVar1;
		  return;
		}
		*/

		}

		// Token: 0x06006D4D RID: 27981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D4D")]
		[Address(RVA = "0xB835", Offset = "0xB835", VA = "0xB835")]
		public void MarkAsClosed()
		{
		/* --- GHIDRA: MarkAsClosed ---
		void Core_Gameplay_Managers_Ad_Statistics_AdTransactionStatisticsInfo__MarkAsClosed
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  double dVar2;
		  double dVar3;
		  longlong param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a5a766 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5a766 = '\x01';
		  }
		  dVar2 = *(double *)(param2 + 0x28);
		  if ((0.0 < dVar2) && (dVar3 = *(double *)(param2 + 0x20), 0.0 < dVar3)) {
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    dVar2 = dVar2 - dVar3;
		    if (ABS(dVar2) < 9.223372036854776e+18) {
		      param1_00 = (longlong)dVar2;
		    }
		    else {
		      param1_00 = -0x8000000000000000;
		    }
		    fVar1 = func_ii_7331(param1_00,0);
		    *param1 = 0;
		    if (ABS(fVar1) < 2.1474836e+09) {
		      param2_00 = (int)fVar1;
		    }
		    else {
		      param2_00 = -0x80000000;
		    }
		    System_Data_SqlTypes_SqlInt32___ctor(param1,param2_00,Method_System_Nullable_int___ctor__);
		    return;
		  }
		  *param1 = 0;
		  return;
		}
		*/

		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06006D4E RID: 27982 RVA: 0x00014160 File Offset: 0x00012360
		[Token(Token = "0x1700163C")]
		public int? CallbackDelaySec
		{
			[Token(Token = "0x6006D4E")]
			[Address(RVA = "0xB836", Offset = "0xB836", VA = "0xB836")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06006D4F RID: 27983 RVA: 0x00014178 File Offset: 0x00012378
		[Token(Token = "0x1700163D")]
		public int? TransactionLifeDurationSec
		{
			[Token(Token = "0x6006D4F")]
			[Address(RVA = "0xB837", Offset = "0xB837", VA = "0xB837")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003930 RID: 14640
		[Token(Token = "0x4003930")]
		[FieldOffset(Offset = "0x8")]
		public readonly string TransactionId;

		// Token: 0x04003931 RID: 14641
		[Token(Token = "0x4003931")]
		[FieldOffset(Offset = "0x10")]
		public readonly double CreateTime;

		// Token: 0x04003932 RID: 14642
		[Token(Token = "0x4003932")]
		[FieldOffset(Offset = "0x18")]
		public readonly uint OptionId;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CloseTime ---
		void Core_Gameplay_Managers_Ad_Statistics_AdTransactionStatisticsInfo__set_CloseTime
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  longlong lVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a763 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTimeOffset_TypeInfo);
		    DAT_ram_00a5a763 = '\x01';
		  }
		  uVar1 = Core_Gameplay_Managers_Ad_Model_AdTransaction__set_Payload(param2,0);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  *(undefined4 *)(param1 + 0x18) = *(undefined4 *)(param2 + 0x10);
		  if (*(int *)(System_DateTimeOffset_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTimeOffset_TypeInfo);
		  }
		  func_ii_13875(&local_20,0);
		  local_8 = local_18;
		  local_10 = local_20;
		  lVar2 = System_DateTimeOffset__get_UtcNow(&local_10,0);
		  *(double *)(param1 + 0x10) = (double)lVar2;
		  return;
		}
		*/


		/* --- GHIDRA: get_CallbackDelaySec ---
		void Core_Gameplay_Managers_Ad_Statistics_AdTransactionStatisticsInfo__get_CallbackDelaySec
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  double dVar2;
		  double dVar3;
		  longlong param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a5a767 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5a767 = '\x01';
		  }
		  dVar2 = *(double *)(param2 + 0x28);
		  if (dVar2 <= 0.0) {
		    *param1 = 0;
		    return;
		  }
		  dVar3 = *(double *)(param2 + 0x10);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  dVar2 = dVar2 - dVar3;
		  if (ABS(dVar2) < 9.223372036854776e+18) {
		    param1_00 = (longlong)dVar2;
		  }
		  else {
		    param1_00 = -0x8000000000000000;
		  }
		  fVar1 = func_ii_7331(param1_00,0);
		  *param1 = 0;
		  if (ABS(fVar1) < 2.1474836e+09) {
		    param2_00 = (int)fVar1;
		  }
		  else {
		    param2_00 = -0x80000000;
		  }
		  System_Data_SqlTypes_SqlInt32___ctor(param1,param2_00,Method_System_Nullable_int___ctor__);
		  return;
		}
		*/

}
