using System;
using Il2CppDummyDll;
using JetBrains.Annotations;

namespace Utils
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public class BackTime : IComparable
	{
		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1CA5", Offset = "0x1CA5", VA = "0x1CA5")]
		public BackTime(float value = 0f)
		{
		/* --- GHIDRA: .ctor ---
		void Utils_BackTime___ctor(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param3_00;
		  int param1_00;
		  uint uVar2;
		  int local_4;
		  
		  if (DAT_ram_00a6283f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TimerTracker_TimerWrapper__Add__);
		    Mono_Security_ASN1__get_Item(&Utils_Timers_TimerTracker_TimerWrapper_TypeInfo);
		    DAT_ram_00a6283f = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0xc),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    param3_00 = unnamed_function_1417(Utils_Timers_TimerTracker_TimerWrapper_TypeInfo);
		    *(undefined4 *)(param3_00 + 0xc) = param3;
		    *(undefined4 *)(param3_00 + 8) = param2;
		    System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		              (*(undefined4 *)(param1 + 0xc),param2,param3_00,
		               Method_System_Collections_Generic_Dictionary_uint__TimerTracker_TimerWrapper__Add__);
		    iVar1 = Method_System_Collections_Generic_List_TimerTracker_TimerWrapper__Add__;
		    param1_00 = *(int *)(param1 + 0x10);
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar2 = *(uint *)(param1_00 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		      *(int *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param3_00;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,param3_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38)
		                );
		    }
		  }
		  else {
		    *(undefined4 *)(local_4 + 0xc) = param3;
		  }
		  return;
		}
		*/

		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002880 File Offset: 0x00000A80
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public float Backtime
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x1BC0", Offset = "0x1BC0", VA = "0x1BC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x2197", Offset = "0x2197", VA = "0x2197")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x1700005A")]
		public float OriginalValue
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x56C7", Offset = "0x56C7", VA = "0x56C7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x56C8", Offset = "0x56C8", VA = "0x56C8", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		undefined4 Utils_BackTime__ToString(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  float fVar3;
		  float fVar4;
		  float fVar5;
		  float4 local_4;
		  
		  if (DAT_ram_00a648dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    DAT_ram_00a648dd = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(Utils_BackTime_TypeInfo + 0xb8) <= (uint)*(byte *)(*param2 + 0xb8)) &&
		       (*(int *)(*(int *)(*param2 + 100) + (uint)*(byte *)(Utils_BackTime_TypeInfo + 0xb8) * 4 + -4)
		        == Utils_BackTime_TypeInfo)) {
		      fVar4 = *(float *)(param1 + 0xc);
		      fVar3 = UnityEngine_Time__get_timeScale(0);
		      fVar4 = fVar4 - fVar3;
		      local_4 = (float4)0.0;
		      if (0.0 <= fVar4) {
		        local_4 = (float4)fVar4;
		      }
		      fVar5 = (float)param2[3];
		      fVar4 = UnityEngine_Time__get_timeScale(0);
		      fVar3 = 0.0;
		      if (0.0 <= fVar5 - fVar4) {
		        fVar3 = fVar5 - fVar4;
		      }
		      uVar1 = System_Double__CompareTo(&local_4,fVar3,0);
		      return uVar1;
		    }
		  }
		  uVar1 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar1 = unnamed_function_1417(uVar1);
		  uVar2 = unnamed_function_2232(&StringLiteral_9805);
		  System_String__Concat(uVar1,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Utils_BackTime_CompareTo__);
		  func_ii_1050(uVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x56C9", Offset = "0x56C9", VA = "0x56C9", Slot = "4")]
		public int CompareTo(object obj)
		{
		/* --- GHIDRA: CompareTo ---
		uint Utils_BackTime__CompareTo(int param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  
		  fVar2 = *(float *)(param1 + 0xc);
		  fVar1 = UnityEngine_Time__get_timeScale(0);
		  fVar2 = fVar2 - fVar1;
		  fVar1 = 0.0;
		  if (0.0 <= fVar2) {
		    fVar1 = fVar2;
		  }
		  fVar3 = *(float *)(param2 + 0xc);
		  fVar2 = UnityEngine_Time__get_timeScale(0);
		  fVar3 = fVar3 - fVar2;
		  fVar2 = 0.0;
		  if (0.0 <= fVar3) {
		    fVar2 = fVar3;
		  }
		  return (uint)(fVar2 < fVar1);
		}
		*/

			return 0;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x56CA", Offset = "0x56CA", VA = "0x56CA")]
		public static bool operator >([NotNull] BackTime lt, [NotNull] BackTime rt)
		{
			return default(bool);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x56CB", Offset = "0x56CB", VA = "0x56CB")]
		public static bool operator <(BackTime lt, BackTime rt)
		{
			return default(bool);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x56CC", Offset = "0x56CC", VA = "0x56CC")]
		public static bool operator >=([NotNull] BackTime lt, [NotNull] BackTime rt)
		{
			return default(bool);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x56CD", Offset = "0x56CD", VA = "0x56CD")]
		public static bool operator <=(BackTime lt, BackTime rt)
		{
			return default(bool);
		}

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x8")]
		private float _originalValue;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0xC")]
		private float _backtime;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Backtime ---
		int * Utils_BackTime__set_Backtime(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_OriginalValue ---
		undefined4 Utils_BackTime__get_OriginalValue(int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  float fVar1;
		  undefined4 uVar2;
		  float fVar3;
		  
		  if (DAT_ram_00a648dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12051);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_202);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1236);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3738);
		    DAT_ram_00a648dc = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  System_Text_Latin1Encoding___cctor(param1_00,StringLiteral_3738,0);
		  func_ii_2010(param1_00,StringLiteral_12051,0);
		  Sirenix_Serialization_BaseFormatter_Nullable_int____RegisterReferenceID
		            (param1_00,*(float *)(param1 + 8),0);
		  func_ii_2010(param1_00,StringLiteral_1236,0);
		  func_ii_2010(param1_00,StringLiteral_202,0);
		  fVar3 = *(float *)(param1 + 0xc);
		  fVar1 = UnityEngine_Time__get_timeScale(0);
		  fVar3 = fVar3 - fVar1;
		  fVar1 = 0.0;
		  if (0.0 <= fVar3) {
		    fVar1 = fVar3;
		  }
		  Sirenix_Serialization_BaseFormatter_Nullable_int____RegisterReferenceID(param1_00,fVar1,0);
		  func_ii_2010(param1_00,StringLiteral_1236,0);
		  func_ii_2010(param1_00,StringLiteral_28773,0);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		  return uVar2;
		}
		*/


		/* --- GHIDRA: op_GreaterThan ---
		uint Utils_BackTime__op_GreaterThan(int param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  
		  fVar2 = *(float *)(param1 + 0xc);
		  fVar1 = UnityEngine_Time__get_timeScale(0);
		  fVar2 = fVar2 - fVar1;
		  fVar1 = 0.0;
		  if (0.0 <= fVar2) {
		    fVar1 = fVar2;
		  }
		  fVar3 = *(float *)(param2 + 0xc);
		  fVar2 = UnityEngine_Time__get_timeScale(0);
		  fVar3 = fVar3 - fVar2;
		  fVar2 = 0.0;
		  if (0.0 <= fVar3) {
		    fVar2 = fVar3;
		  }
		  return (uint)(fVar1 < fVar2);
		}
		*/


		/* --- GHIDRA: op_LessThan ---
		uint Utils_BackTime__op_LessThan(int param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  
		  fVar2 = *(float *)(param1 + 0xc);
		  fVar1 = UnityEngine_Time__get_timeScale(0);
		  fVar2 = fVar2 - fVar1;
		  fVar1 = 0.0;
		  if (0.0 <= fVar2) {
		    fVar1 = fVar2;
		  }
		  fVar3 = *(float *)(param2 + 0xc);
		  fVar2 = UnityEngine_Time__get_timeScale(0);
		  fVar3 = fVar3 - fVar2;
		  fVar2 = 0.0;
		  if (0.0 <= fVar3) {
		    fVar2 = fVar3;
		  }
		  return (uint)(fVar2 <= fVar1);
		}
		*/


		/* --- GHIDRA: op_GreaterThanOrEqual ---
		uint Utils_BackTime__op_GreaterThanOrEqual(int param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  float fVar2;
		  float fVar3;
		  
		  fVar2 = *(float *)(param1 + 0xc);
		  fVar1 = UnityEngine_Time__get_timeScale(0);
		  fVar2 = fVar2 - fVar1;
		  fVar1 = 0.0;
		  if (0.0 <= fVar2) {
		    fVar1 = fVar2;
		  }
		  fVar3 = *(float *)(param2 + 0xc);
		  fVar2 = UnityEngine_Time__get_timeScale(0);
		  fVar3 = fVar3 - fVar2;
		  fVar2 = 0.0;
		  if (0.0 <= fVar3) {
		    fVar2 = fVar3;
		  }
		  return (uint)(fVar1 <= fVar2);
		}
		*/

}
