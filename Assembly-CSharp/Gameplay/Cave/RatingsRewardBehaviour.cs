using System;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Gameplay.Cave
{
	// Token: 0x02000B2F RID: 2863
	[Token(Token = "0x2000B2F")]
	public class RatingsRewardBehaviour : BaseRewardBehaviour
	{
		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DB5")]
		public override RewardTypes[] RewardTypesList
		{
			[Token(Token = "0x6004597")]
			[Address(RVA = "0x9439", Offset = "0x9439", VA = "0x9439", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004598")]
		[Address(RVA = "0x943A", Offset = "0x943A", VA = "0x943A", Slot = "5")]
		public override CaveModel.RewardInCave GetReward(IGame game, RewardInfo info)
		{
		/* --- GHIDRA: GetReward ---
		void Gameplay_Cave_RatingsRewardBehaviour__GetReward(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5796f == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_RewardTypes___TypeInfo);
		    DAT_ram_00a5796f = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(Protocol_Consts_RewardTypes___TypeInfo,1);
		  *(undefined4 *)(iVar1 + 0x10) = 0x14;
		  *(int *)(param1 + 8) = iVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004599")]
		[Address(RVA = "0x943B", Offset = "0x943B", VA = "0x943B")]
		public RatingsRewardBehaviour()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RewardTypesList ---
		int Gameplay_Cave_RatingsRewardBehaviour__get_RewardTypesList
		              (undefined4 param1,int *param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5796e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_CaveModel_RewardInCave_TypeInfo);
		    DAT_ram_00a5796e = '\x01';
		  }
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80e090ca;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80e090ca:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetExperienceDic(uVar3,5,0);
		  uVar5 = *(undefined4 *)(param3 + 0xc);
		  uVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param3 + 0x10),4,
		                     Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		  uVar3 = Core_Extensions_Dict_UserMenuActionDicExt__GetTitle(uVar3,0);
		  uVar6 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  iVar7 = unnamed_function_1417(Gameplay_Cave_CaveModel_RewardInCave_TypeInfo);
		  *(undefined4 *)(iVar7 + 0x14) = uVar4;
		  *(undefined4 *)(iVar7 + 8) = uVar5;
		  *(undefined4 *)(iVar7 + 0x10) = uVar6;
		  *(undefined4 *)(iVar7 + 0x18) = 0;
		  *(undefined4 *)(iVar7 + 0xc) = uVar3;
		  return iVar7;
		}
		*/

}
