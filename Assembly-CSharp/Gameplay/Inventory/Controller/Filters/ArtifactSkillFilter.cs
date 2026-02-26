using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Filters;

namespace Gameplay.Inventory.Controller.Filters
{
	// Token: 0x020006C4 RID: 1732
	[Token(Token = "0x20006C4")]
	public class ArtifactSkillFilter : IArtifactFilter
	{
		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060029E6 RID: 10726 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060029E7 RID: 10727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E6")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60029E6")]
			[Address(RVA = "0x7A8F", Offset = "0x7A8F", VA = "0x7A8F", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029E7")]
			[Address(RVA = "0x7A90", Offset = "0x7A90", VA = "0x7A90", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x00007EA8 File Offset: 0x000060A8
		[Token(Token = "0x60029E8")]
		[Address(RVA = "0x7A91", Offset = "0x7A91", VA = "0x7A91", Slot = "6")]
		public bool Filter(ArtifactData artifactData)
		{
			return default(bool);
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029E9")]
		[Address(RVA = "0x7A92", Offset = "0x7A92", VA = "0x7A92")]
		public ArtifactSkillFilter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		int Gameplay_Inventory_Controller_Filters_ArtifactSkillFilter__set_FilterInfo
		              (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a18f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Enumerator_int__Dispose__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Enumerator_int__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_int__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    DAT_ram_00a5a18f = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  if (*(char *)(*(int *)(param1 + 8) + 0x10) == '\0') {
		    iVar1 = 1;
		  }
		  else {
		    piVar3 = *(int **)(*(int *)(param1 + 8) + 0xc);
		    if (piVar3 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar3 + 0xb8) <
		           (uint)*(byte *)(System_Collections_Generic_List_int__TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar3 + 100) +
		                   (uint)*(byte *)(System_Collections_Generic_List_int__TypeInfo + 0xb8) * 4 + -4)
		          != System_Collections_Generic_List_int__TypeInfo)) {
		        System_Activator__CreateInstance(piVar3,System_Collections_Generic_List_int__TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_10,piVar3,Method_System_Collections_Generic_List_int__GetEnumerator__);
		    local_18 = 0;
		    local_14 = &local_10;
		    do {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar1 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x216,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_int__MoveNext__);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811da122:
		          iVar4 = global_1;
		          iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar4 == iVar1) {
		            piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		            iVar1 = *piVar3;
		            DAT_ram_009d3e38 = 0;
		            local_18 = iVar1;
		            import::env::invoke_v(0x123);
		            iVar4 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar4 != 1) {
		              if (iVar1 == 0) {
		                DAT_ram_009d3e38 = 0;
		                return 0;
		              }
		              System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            param1_00 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x274,&local_18);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 != 1) {
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
		        if (iVar1 == 0) goto code_r0x811da0fb;
		        iVar4 = *(int *)(*(int *)(*(int *)(param2 + 0x74) + 0x20) + 0x10);
		      } while (*(int *)(iVar4 + 0xc) < local_8._4_4_ + 1);
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x273,iVar4,local_8._4_4_
		                         ,Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		      iVar4 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar4 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811da122;
		      }
		    } while (iVar2 == 0);
		code_r0x811da0fb:
		    DAT_ram_009d3e38 = 0;
		  }
		  return iVar1;
		}
		*/

}
