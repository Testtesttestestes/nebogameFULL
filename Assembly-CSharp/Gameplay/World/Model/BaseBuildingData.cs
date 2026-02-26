using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.World.Model
{
	// Token: 0x02000361 RID: 865
	[Token(Token = "0x2000361")]
	public abstract class BaseBuildingData<T> : BaseBuildingData where T : Enum
	{
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060013C3 RID: 5059
		[Token(Token = "0x17000313")]
		public abstract T Type { [Token(Token = "0x60013C3")] get; }

		// Token: 0x060013C4 RID: 5060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013C4")]
		protected BaseBuildingData(Dictionaries dictionaries)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_Model_BaseBuildingData___ctor(int param1,longlong param2,undefined4 param3)
		
		{
		  float param2_00;
		  undefined4 param1_00;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a58c74 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58c74 = '\x01';
		  }
		  *(longlong *)(*(int *)(param1 + 0xc) + 0x18) = param2;
		  if (param2 != 0) {
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    param2_00 = Utils_StringUtils___cctor(param2,0);
		    param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  }
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsUpgrading ---
		int * Gameplay_World_Model_BaseBuildingData__get_IsUpgrading(int *param1)
		
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


		/* --- GHIDRA: set_BuildPriceCoeff ---
		void Gameplay_World_Model_BaseBuildingData__set_BuildPriceCoeff
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  double dVar1;
		  
		  if (DAT_ram_00a58c73 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_25458);
		    DAT_ram_00a58c73 = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = param2;
		  dVar1 = Core_Extensions_Dict_DictExt__GetIntParameter(param2,StringLiteral_25458,0);
		  *(double *)(param1 + 0x20) = dVar1;
		  return;
		}
		*/


		/* --- GHIDRA: SetUpgradeTimer ---
		undefined4
		Gameplay_World_Model_BaseBuildingData__SetUpgradeTimer
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param5;
		  undefined4 param6;
		  
		  if (DAT_ram_00a58c75 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3700);
		    DAT_ram_00a58c75 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  param1_00 = unnamed_function_1417
		                        (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (param1_00,param2,param3,uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3700,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))
		                    (param1,*(undefined4 *)(*param1 + 300));
		  param5 = *(undefined4 *)(iVar2 + 0x18);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x128) * 4))
		                    (param1,*(undefined4 *)(*param1 + 300));
		  param6 = *(undefined4 *)(iVar2 + 0x14);
		  uVar1 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__Dispose
		            (uVar1,param2,param3,param1_00,param5,param6,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetUpgradeRequirementsProvider ---
		int Gameplay_World_Model_BaseBuildingData__GetUpgradeRequirementsProvider
		              (int param1,undefined4 param2)
		
		{
		  float fVar1;
		  int iVar2;
		  double dVar3;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a58c76 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a58c76 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x14) != 0) &&
		     (fVar1 = func_ii_7103(*(int *)(param1 + 0x14),0), iVar2 = 0, 0.0 < fVar1)) {
		    fVar1 = func_ii_7103(*(undefined4 *)(param1 + 0x14),0);
		    dVar3 = *(double *)(param1 + 0x20);
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    iVar2 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		    *(double *)(iVar2 + 0x18) = CEIL((double)(fVar1 * 1000.0) / dVar3);
		  }
		  return iVar2;
		}
		*/


		/* --- GHIDRA: get_AcceleratePrice ---
		void Gameplay_World_Model_BaseBuildingData__get_AcceleratePrice
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1[3] + 0x10) = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))(param1,*(undefined4 *)(*param1 + 0x14c));
		  return;
		}
		*/

}
