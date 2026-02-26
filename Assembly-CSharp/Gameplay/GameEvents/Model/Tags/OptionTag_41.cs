using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007AD RID: 1965
	[Token(Token = "0x20007AD")]
	public class OptionTag_41 : AbstractTag
	{
		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06002E8C RID: 11916 RVA: 0x000093C0 File Offset: 0x000075C0
		[Token(Token = "0x17000906")]
		public OptionTypesDic.Types.OptionType OptionType
		{
			[Token(Token = "0x6002E8C")]
			[Address(RVA = "0x7F07", Offset = "0x7F07", VA = "0x7F07")]
			get
			{
				return OptionTypesDic.Types.OptionType.Diamond;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06002E8D RID: 11917 RVA: 0x000093D8 File Offset: 0x000075D8
		[Token(Token = "0x17000907")]
		public uint OptionId
		{
			[Token(Token = "0x6002E8D")]
			[Address(RVA = "0x7F08", Offset = "0x7F08", VA = "0x7F08")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x000093F0 File Offset: 0x000075F0
		[Token(Token = "0x6002E8E")]
		[Address(RVA = "0x7F09", Offset = "0x7F09", VA = "0x7F09", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
		/* --- GHIDRA: TryGetValue ---
		undefined4
		Gameplay_GameEvents_Model_Tags_OptionTag_41__TryGetValue
		          (int param1,int param2,undefined4 param3,undefined4 *param4,undefined4 *param5,
		          undefined4 *param6,undefined4 param7)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 local_1c;
		  int local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a574e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_OptionTypesDic_Types_OptionType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12032);
		    DAT_ram_00a574e0 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  local_c = 0;
		  local_10 = 0;
		  local_14 = 0;
		  local_18 = param2;
		  uVar2 = func_ii_1081(Protocol_Dic_OptionTypesDic_Types_OptionType_TypeInfo,&local_18);
		  local_1c = param3;
		  param3_00 = func_ii_1081(DAT_ram_00a66958,&local_1c);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_12032,uVar2,param3_00,0);
		  *param6 = uVar2;
		  *param5 = uVar2;
		  *param4 = uVar2;
		  if (param2 == 0) {
		    uVar1 = 0;
		    piVar4 = *(int **)(param1 + 8);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x80d96b53;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d96b53:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    iVar5 = Core_Extensions_Dict_DictExt__GetOptionTypesDic(uVar2,param3,&local_4,0);
		    if (iVar5 == 0) {
		      return 1;
		    }
		    uVar2 = Core_Extensions_Dict_DiamondOptionsDicExt__GetSpecialOfferIslandIconAssetId(local_4,0);
		    *param4 = uVar2;
		    uVar2 = Core_Extensions_Dict_DiamondOptionsDicExt__GetPurchaseTitle(local_4,0);
		    *param5 = uVar2;
		    uVar2 = Core_Extensions_Dict_DiamondOptionsDicExt__GetEventPromoTitle(local_4,0);
		    *param6 = uVar2;
		    return 1;
		  }
		  if ((param2 != 1) && (param2 != 2)) {
		    if (param2 == 3) {
		      uVar1 = 0;
		      piVar4 = *(int **)(param1 + 8);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		            goto code_r0x80d96e86;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d96e86:
		      uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		      iVar5 = Core_Extensions_Dict_DictExt__TryGetColossusFragmentsOptionsDic
		                        (uVar2,param3,&local_14,0);
		      if (iVar5 == 0) {
		        return 1;
		      }
		      uVar2 = Core_Extensions_Dict_ArtikulOptionsDicExt__GetSpecialOfferBannerAssetId(local_14,0);
		      *param4 = uVar2;
		      uVar2 = Core_Extensions_Dict_ArtikulOptionsDicExt__GetPurchaseTitle(local_14,0);
		      *param5 = uVar2;
		      uVar2 = Core_Extensions_Dict_ArtikulOptionsDicExt__GetEventPromoTitle(local_14,0);
		      *param6 = uVar2;
		      return 1;
		    }
		    if (param2 == 4) {
		      uVar1 = 0;
		      piVar4 = *(int **)(param1 + 8);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		            goto code_r0x80d96c1d;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d96c1d:
		      uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		      iVar5 = Core_Extensions_Dict_DictExt__TryGetDiamondOptionsDic(uVar2,param3,&local_8,0);
		      if (iVar5 == 0) {
		        return 1;
		      }
		      uVar2 = Core_Extensions_Dict_CrystalEnergyOptionsDicExt__GetSpecialOfferIslandIconAssetId
		                        (local_8,0);
		      *param4 = uVar2;
		      uVar2 = Core_Extensions_Dict_CrystalEnergyOptionsDicExt__GetPurchaseTitle(local_8,0);
		      *param5 = uVar2;
		      uVar2 = Core_Extensions_Dict_CrystalEnergyOptionsDicExt__GetEventPromoTitle(local_8,0);
		      *param6 = uVar2;
		      return 1;
		    }
		    if (param2 != 5) {
		      if (param2 != 6) {
		        if (param2 != 10) {
		          return 0;
		        }
		        uVar1 = 0;
		        piVar4 = *(int **)(param1 + 8);
		        iVar5 = *piVar4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0)
		              ;
		              goto code_r0x80d96dbc;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d96dbc:
		        uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		        iVar5 = Core_Extensions_Dict_DictExt__TryGetNewResourceOptionsDic(uVar2,param3,&local_10,0);
		        if (iVar5 == 0) {
		          return 1;
		        }
		        uVar2 = Core_Extensions_Dict_ColossusFragmentsOptionsDicExt__GetBankBgAssetId(local_10,0);
		        *param4 = uVar2;
		        uVar2 = Core_Extensions_Dict_ColossusFragmentsOptionsDicExt__GetPurchaseTitle(local_10,0);
		        *param5 = uVar2;
		        uVar2 = Core_Extensions_Dict_ColossusFragmentsOptionsDicExt__GetEventPromoTitle(local_10,0);
		        *param6 = uVar2;
		        return 1;
		      }
		      uVar1 = 0;
		      piVar4 = *(int **)(param1 + 8);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		            goto code_r0x80d96ce7;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d96ce7:
		      uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		      iVar5 = Core_Extensions_Dict_DictExt__TryGetCrystalEnergyOptionsDic(uVar2,param3,&local_c,0);
		      if (iVar5 == 0) {
		        return 1;
		      }
		      uVar2 = Core_Extensions_Dict_NewResourceOptionsDicExt__GetSpecialOfferIslandIconAssetId
		                        (local_c,0);
		      *param4 = uVar2;
		      uVar2 = Core_Extensions_Dict_NewResourceOptionsDicExt__GetPurchaseTitle(local_c,0);
		      *param5 = uVar2;
		      uVar2 = Core_Extensions_Dict_NewResourceOptionsDicExt__GetEventPromoTitle(local_c,0);
		      *param6 = uVar2;
		      return 1;
		    }
		  }
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x00009408 File Offset: 0x00007608
		[Token(Token = "0x6002E8F")]
		[Address(RVA = "0x7F0A", Offset = "0x7F0A", VA = "0x7F0A")]
		public bool GetBaseOptionDic(OptionTypesDic.Types.OptionType type, uint optionId, out string optionTitle, out string optionEventPromoTitle, out string optionEventPromoDescription)
		{
			return default(bool);
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E90")]
		[Address(RVA = "0x7F0B", Offset = "0x7F0B", VA = "0x7F0B")]
		public OptionTag_41()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_GameEvents_Model_Tags_OptionTag_41___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  double dVar3;
		  
		  iVar2 = param1[5];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  dVar3 = *(double *)(iVar2 + iVar1 * 8 + 8);
		  if (2147483648.0 <= ABS(dVar3)) {
		    return 0x80000000;
		  }
		  return (int)dVar3;
		}
		*/

		}

		// Token: 0x04001982 RID: 6530
		[Token(Token = "0x4001982")]
		public const string OPTION_TITLE = "option_title";

		// Token: 0x04001983 RID: 6531
		[Token(Token = "0x4001983")]
		public const string OPTION_EVENT_PROMO_TITLE = "option_event_promo_title";

		// Token: 0x04001984 RID: 6532
		[Token(Token = "0x4001984")]
		public const string OPTION_EVENT_PROMO_DESCRIPTION = "option_event_promo_description";

		// Token: 0x04001985 RID: 6533
		[Token(Token = "0x4001985")]
		public const string OPTION_NOT_FOUND_TEXT = "Option Type: {0}, Id: {1} Not Found In Dicts";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_OptionId ---
		int Gameplay_GameEvents_Model_Tags_OptionTag_41__get_OptionId
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  double dVar5;
		  undefined1 auStack_10 [4];
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a574df == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_25869);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25867);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25866);
		    DAT_ram_00a574df = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  local_c = 0;
		  if (DAT_ram_00a574cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11610);
		    DAT_ram_00a574cb = '\x01';
		  }
		  uVar2 = 0;
		  if (DAT_ram_00a574ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		    DAT_ram_00a574ca = '\x01';
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar1 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (param1_00,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar1 != 0) {
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = uVar2;
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_25869,0);
		    if (iVar3 == 0) {
		      iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_25867,0);
		      if (iVar3 == 0) {
		        iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_25866,0);
		        if (iVar3 == 0) {
		          return iVar1;
		        }
		        dVar5 = *(double *)(param1[5] + 0x18);
		        if (dVar5 < 4294967296.0 && 0.0 <= dVar5) {
		          iVar3 = (int)dVar5;
		        }
		        else {
		          iVar3 = 0;
		        }
		        if (ABS(dVar5) < 2147483648.0) {
		          iVar4 = (int)dVar5;
		        }
		        else {
		          iVar4 = -0x80000000;
		        }
		        if (0.0 <= dVar5) {
		          iVar4 = iVar3;
		        }
		        dVar5 = *(double *)(param1[5] + 0x10);
		        if (ABS(dVar5) < 2147483648.0) {
		          iVar3 = (int)dVar5;
		        }
		        else {
		          iVar3 = -0x80000000;
		        }
		        iVar3 = Gameplay_GameEvents_Model_Tags_OptionTag_41__TryGetValue
		                          (param1,iVar3,iVar4,&local_4,&local_8,&local_c,auStack_10);
		        uVar2 = local_c;
		      }
		      else {
		        dVar5 = *(double *)(param1[5] + 0x18);
		        if (dVar5 < 4294967296.0 && 0.0 <= dVar5) {
		          iVar3 = (int)dVar5;
		        }
		        else {
		          iVar3 = 0;
		        }
		        if (ABS(dVar5) < 2147483648.0) {
		          iVar4 = (int)dVar5;
		        }
		        else {
		          iVar4 = -0x80000000;
		        }
		        if (0.0 <= dVar5) {
		          iVar4 = iVar3;
		        }
		        dVar5 = *(double *)(param1[5] + 0x10);
		        if (ABS(dVar5) < 2147483648.0) {
		          iVar3 = (int)dVar5;
		        }
		        else {
		          iVar3 = -0x80000000;
		        }
		        iVar3 = Gameplay_GameEvents_Model_Tags_OptionTag_41__TryGetValue
		                          (param1,iVar3,iVar4,&local_4,&local_8,&local_c,auStack_10);
		        uVar2 = local_8;
		      }
		    }
		    else {
		      dVar5 = *(double *)(param1[5] + 0x18);
		      if (dVar5 < 4294967296.0 && 0.0 <= dVar5) {
		        iVar3 = (int)dVar5;
		      }
		      else {
		        iVar3 = 0;
		      }
		      if (ABS(dVar5) < 2147483648.0) {
		        iVar4 = (int)dVar5;
		      }
		      else {
		        iVar4 = -0x80000000;
		      }
		      if (0.0 <= dVar5) {
		        iVar4 = iVar3;
		      }
		      dVar5 = *(double *)(param1[5] + 0x10);
		      if (ABS(dVar5) < 2147483648.0) {
		        iVar3 = (int)dVar5;
		      }
		      else {
		        iVar3 = -0x80000000;
		      }
		      iVar3 = Gameplay_GameEvents_Model_Tags_OptionTag_41__TryGetValue
		                        (param1,iVar3,iVar4,&local_4,&local_8,&local_c,auStack_10);
		      uVar2 = local_4;
		    }
		    if (iVar3 == 0) {
		      return iVar1;
		    }
		  }
		  *param4 = uVar2;
		  return iVar1;
		}
		*/

}
