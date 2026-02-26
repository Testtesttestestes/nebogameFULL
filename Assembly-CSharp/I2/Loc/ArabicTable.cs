using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x020013AE RID: 5038
	[Token(Token = "0x20013AE")]
	internal class ArabicTable
	{
		// Token: 0x060077CF RID: 30671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077CF")]
		[Address(RVA = "0xC12A", Offset = "0xC12A", VA = "0xC12A")]
		private ArabicTable()
		{
		/* --- GHIDRA: .ctor ---
		int I2_Loc_ArabicTable___ctor(undefined4 param1)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a54e1a == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_ArabicTable_TypeInfo);
		    DAT_ram_00a54e1a = '\x01';
		  }
		  param1_00 = *(int *)(*(int *)(I2_Loc_ArabicTable_TypeInfo + 0x5c) + 4);
		  if (param1_00 == 0) {
		    param1_00 = unnamed_function_1417(I2_Loc_ArabicTable_TypeInfo);
		    I2_Loc_ArabicMapping___ctor(param1_00,param1_00);
		    *(int *)(*(int *)(I2_Loc_ArabicTable_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x060077D0 RID: 30672 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017B6")]
		internal static ArabicTable ArabicMapper
		{
			[Token(Token = "0x60077D0")]
			[Address(RVA = "0xC12B", Offset = "0xC12B", VA = "0xC12B")]
			get
			{
				return null;
			}
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x00015FF0 File Offset: 0x000141F0
		[Token(Token = "0x60077D1")]
		[Address(RVA = "0xC12C", Offset = "0xC12C", VA = "0xC12C")]
		internal int Convert(int toBeConverted)
		{
		/* --- GHIDRA: Convert ---
		void I2_Loc_ArabicTable__Convert(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined2 *)(param1 + 8) = (undefined2)param2;
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x04003EDB RID: 16091
		[Token(Token = "0x4003EDB")]
		[FieldOffset(Offset = "0x0")]
		private static List<ArabicMapping> mapList;

		// Token: 0x04003EDC RID: 16092
		[Token(Token = "0x4003EDC")]
		[FieldOffset(Offset = "0x4")]
		private static ArabicTable arabicMapper;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ArabicMapper ---
		undefined4 I2_Loc_ArabicTable__get_ArabicMapper(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54e1b == '\0') {
		    Mono_Security_ASN1__get_Item(&I2_Loc_ArabicTable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArabicMapping__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArabicMapping__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_ArabicMapping__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArabicMapping__GetEnumerator__);
		    DAT_ram_00a54e1b = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,**(undefined4 **)(I2_Loc_ArabicTable_TypeInfo + 0x5c),
		             Method_System_Collections_Generic_List_ArabicMapping__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_ArabicMapping__MoveNext__);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar1 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar2) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar2 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return param2;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x124,&local_18);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(param1_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return param2;
		    }
		  } while (*(int *)(local_8._4_4_ + 8) != param2);
		  DAT_ram_009d3e38 = 0;
		  return *(undefined4 *)(local_8._4_4_ + 0xc);
		}
		*/

}
