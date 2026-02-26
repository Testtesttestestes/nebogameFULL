using System;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using MVC;
using Protocol.Main;

namespace Gameplay.Experiments.Model
{
	// Token: 0x0200082A RID: 2090
	[Token(Token = "0x200082A")]
	public class ExperimentsModel : AbstractModel
	{
		// Token: 0x06003143 RID: 12611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003143")]
		[Address(RVA = "0x819B", Offset = "0x819B", VA = "0x819B")]
		public ExperimentsModel(UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Experiments_Model_ExperimentsModel___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5761b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserExperimentsAns_Types_Experiment__AddRange__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserExperimentsAns_Types_Experiment__Clear__
		              );
		    DAT_ram_00a5761b = '\x01';
		  }
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType___CalculateSize
		            (*(undefined4 *)(param1 + 0xc),
		             Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserExperimentsAns_Types_Experiment__Clear__
		            );
		  Google_Protobuf_Collections_RepeatedField_object___AddEntriesFrom
		            (*(undefined4 *)(param1 + 0xc),param2,
		             Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserExperimentsAns_Types_Experiment__AddRange__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003144 RID: 12612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003144")]
		[Address(RVA = "0x819C", Offset = "0x819C", VA = "0x819C")]
		public void SetExperiments(RepeatedField<ProtoGetUserExperimentsAns.Types.Experiment> experiments)
		{
		/* --- GHIDRA: SetExperiments ---
		uint Gameplay_Experiments_Model_ExperimentsModel__SetExperiments
		               (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5761c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_FirstOrDefault_ProtoGetUserExperimentsAns_Types_Experiment___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ProtoGetUserExperimentsAns_Types_Experiment__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Experiments_Model_ExperimentsModel___c__DisplayClass3_0__TryGetExperimentGroup_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Experiments_Model_ExperimentsModel___c__DisplayClass3_0_TypeInfo);
		    DAT_ram_00a5761c = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Experiments_Model_ExperimentsModel___c__DisplayClass3_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  *param3 = 0;
		  param1_01 = *(undefined4 *)(param1 + 0xc);
		  param1_00 = unnamed_function_1417
		                        (System_Func_ProtoGetUserExperimentsAns_Types_Experiment__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar1,
		             Method_Gameplay_Experiments_Model_ExperimentsModel___c__DisplayClass3_0__TryGetExperimentGroup_b__0__
		             ,0);
		  iVar1 = System_Func_object__bool____ctor
		                    (param1_01,param1_00,
		                     Method_System_Linq_Enumerable_FirstOrDefault_ProtoGetUserExperimentsAns_Types_Experiment___
		                    );
		  if (iVar1 != 0) {
		    *param3 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return (uint)(iVar1 != 0);
		}
		*/

		}

		// Token: 0x06003145 RID: 12613 RVA: 0x0000A020 File Offset: 0x00008220
		[Token(Token = "0x6003145")]
		[Address(RVA = "0x819D", Offset = "0x819D", VA = "0x819D")]
		public bool TryGetExperimentGroup(uint experimentId, out uint group)
		{
			return default(bool);
		}

		// Token: 0x04001AE6 RID: 6886
		[Token(Token = "0x4001AE6")]
		[FieldOffset(Offset = "0xC")]
		private readonly RepeatedField<ProtoGetUserExperimentsAns.Types.Experiment> _experiments;
	}
}
