using System;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Gameplay.Cave
{
	// Token: 0x02000B30 RID: 2864
	[Token(Token = "0x2000B30")]
	public class ResourceRewardBehaviour : BaseRewardBehaviour
	{
		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x0600459A RID: 17818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DB6")]
		public override RewardTypes[] RewardTypesList
		{
			[Token(Token = "0x600459A")]
			[Address(RVA = "0x943C", Offset = "0x943C", VA = "0x943C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600459B")]
		[Address(RVA = "0x943D", Offset = "0x943D", VA = "0x943D", Slot = "5")]
		public override CaveModel.RewardInCave GetReward(IGame game, RewardInfo info)
		{
		/* --- GHIDRA: GetReward ---
		void Gameplay_Cave_ResourceRewardBehaviour__GetReward(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57971 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_RewardTypes___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__BB1422677D88C4F2FC4F5B2F17C74AE4CEBAD355ECB6CC048BB428ABBA9EB4E3
		              );
		    DAT_ram_00a57971 = '\x01';
		  }
		  param1_00 = Mono_Security_ASN1Convert__ToOid(Protocol_Consts_RewardTypes___TypeInfo,5);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (param1_00,
		             Field__PrivateImplementationDetails__BB1422677D88C4F2FC4F5B2F17C74AE4CEBAD355ECB6CC048BB428ABBA9EB4E3
		             ,0);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459C")]
		[Address(RVA = "0x943E", Offset = "0x943E", VA = "0x943E")]
		public ResourceRewardBehaviour()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Cave_ResourceRewardBehaviour___ctor(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  *(undefined8 *)(param1 + 0x14) = 0;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RewardTypesList ---
		int Gameplay_Cave_ResourceRewardBehaviour__get_RewardTypesList
		              (undefined4 param1,int *param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  uint uVar4;
		  int iVar5;
		  double dVar6;
		  undefined4 uVar7;
		  int iVar8;
		  ulonglong local_10;
		  byte local_8;
		  
		  uVar3 = 0;
		  if (DAT_ram_00a57970 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Resources__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_Resources__get_Value__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Utils_ResourceRewardsUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_CaveModel_RewardInCave_TypeInfo);
		    DAT_ram_00a57970 = '\x01';
		  }
		  uVar7 = *(undefined4 *)(param3 + 0xc);
		  if (*(int *)(Utils_ResourceRewardsUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_ResourceRewardsUtils_TypeInfo);
		  }
		  uVar4 = 0;
		  uVar1 = 0;
		  Utils_ResourceRewardsUtils__GetRewardTypes(&local_10,uVar7,0);
		  _local_8 = local_10;
		  if ((local_10 & 0xff) == 0) {
		    uVar7 = *(undefined4 *)(param3 + 0xc);
		    iVar8 = 0;
		  }
		  else {
		    iVar8 = *param2;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar4 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar4 * 8 + 4) * 8 + iVar8 + 0x178);
		          goto code_r0x80e09260;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar4);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e09260:
		    iVar8 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,CONCAT44(in_register_20000014,puVar2[1]));
		    uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    uVar7 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                      (&local_8,Method_System_Nullable_Resources__get_Value__);
		    uVar1 = Core_Extensions_Dict_ResourceSetExt__GetValue(uVar3,uVar7,0);
		    uVar7 = *(undefined4 *)(param3 + 0xc);
		    if (local_8 == 0) {
		      uVar3 = 0;
		    }
		    else {
		      uVar3 = 0;
		      param1_00 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                            (&local_8,Method_System_Nullable_Resources__get_Value__);
		      uVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param3 + 0x10),0,
		                         Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		      dVar6 = Utils_LongTap__DetectStartLongTapCoroutine_d__41__System_Collections_IEnumerator_get_Current
		                        (param1_00,(double)uVar4,0,0);
		      if (ABS(dVar6) < 2147483648.0) {
		        iVar8 = (int)dVar6;
		      }
		      else {
		        iVar8 = -0x80000000;
		      }
		      if (local_8 != 0) {
		        uVar3 = Core_Extensions_Dict_NullableResourceSetExt__GetResourcesesIds(uVar1,0);
		      }
		    }
		  }
		  uVar1 = Core_Extensions_Dict_ResourcesDicExt__GetIconForPriceSpellInCombatAssetId(uVar1,0);
		  iVar5 = unnamed_function_1417(Gameplay_Cave_CaveModel_RewardInCave_TypeInfo);
		  *(int *)(iVar5 + 0x14) = iVar8;
		  *(undefined4 *)(iVar5 + 8) = uVar7;
		  *(undefined4 *)(iVar5 + 0x10) = uVar1;
		  *(undefined4 *)(iVar5 + 0x18) = 0;
		  *(undefined4 *)(iVar5 + 0xc) = uVar3;
		  return iVar5;
		}
		*/

}
