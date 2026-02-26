using System;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Gameplay.Cave
{
	// Token: 0x02000B2E RID: 2862
	[Token(Token = "0x2000B2E")]
	public class ExpRewardBehaviour : BaseRewardBehaviour
	{
		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DB4")]
		public override RewardTypes[] RewardTypesList
		{
			[Token(Token = "0x6004594")]
			[Address(RVA = "0x9436", Offset = "0x9436", VA = "0x9436", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004595")]
		[Address(RVA = "0x9437", Offset = "0x9437", VA = "0x9437", Slot = "5")]
		public override CaveModel.RewardInCave GetReward(IGame game, RewardInfo info)
		{
		/* --- GHIDRA: GetReward ---
		void Gameplay_Cave_ExpRewardBehaviour__GetReward(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5796d == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_RewardTypes___TypeInfo);
		    DAT_ram_00a5796d = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(Protocol_Consts_RewardTypes___TypeInfo,1);
		  *(undefined4 *)(iVar1 + 0x10) = 7;
		  *(int *)(param1 + 8) = iVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004596")]
		[Address(RVA = "0x9438", Offset = "0x9438", VA = "0x9438")]
		public ExpRewardBehaviour()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RewardTypesList ---
		int Gameplay_Cave_ExpRewardBehaviour__get_RewardTypesList
		              (undefined4 param1,int *param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5796c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_CaveModel_RewardInCave_TypeInfo);
		    DAT_ram_00a5796c = '\x01';
		  }
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80e08f84;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e08f84:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetArtikulTypeMenuActionDic(uVar3,1,0);
		  uVar6 = *(undefined4 *)(param3 + 0xc);
		  uVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param3 + 0x10),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		  uVar5 = Core_Extensions_Dict_ExperienceDicExt__GetIcon32AssetId(uVar3,0);
		  uVar3 = Core_Extensions_Dict_ExperienceDicExt__GetIcon256AssetId(uVar3,0);
		  iVar7 = unnamed_function_1417(Gameplay_Cave_CaveModel_RewardInCave_TypeInfo);
		  *(undefined4 *)(iVar7 + 0x14) = uVar4;
		  *(undefined4 *)(iVar7 + 8) = uVar6;
		  *(undefined4 *)(iVar7 + 0x10) = uVar3;
		  *(undefined4 *)(iVar7 + 0x18) = 0;
		  *(undefined4 *)(iVar7 + 0xc) = uVar5;
		  return iVar7;
		}
		*/

}
