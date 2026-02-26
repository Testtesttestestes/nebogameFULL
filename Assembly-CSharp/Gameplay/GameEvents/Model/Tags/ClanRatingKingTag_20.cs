using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x0200079B RID: 1947
	[Token(Token = "0x200079B")]
	public class ClanRatingKingTag_20 : AbstractTag
	{
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x170008F0")]
		public uint RatingKindId
		{
			[Token(Token = "0x6002E54")]
			[Address(RVA = "0x7ECF", Offset = "0x7ECF", VA = "0x7ECF")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x6002E55")]
		[Address(RVA = "0x7ED0", Offset = "0x7ED0", VA = "0x7ED0", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E56")]
		[Address(RVA = "0x7ED1", Offset = "0x7ED1", VA = "0x7ED1")]
		public ClanRatingKingTag_20()
		{
		}

		// Token: 0x0400196B RID: 6507
		[Token(Token = "0x400196B")]
		public const string CLAN_RATING_TYPE = "clan_rating_type";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RatingKindId ---
		int Gameplay_GameEvents_Model_Tags_ClanRatingKingTag_20__get_RatingKindId
		              (int *param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  double dVar6;
		  uint uVar7;
		  int local_4;
		  
		  if (DAT_ram_00a574d0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21209);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5461);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a574d0 = '\x01';
		  }
		  if (DAT_ram_00a574cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11610);
		    DAT_ram_00a574cb = '\x01';
		  }
		  if (DAT_ram_00a574ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		    DAT_ram_00a574ca = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar2 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar1,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar2 == 0) {
		    *param4 = 0;
		  }
		  else {
		    iVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = iVar3;
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21209,0);
		    if (iVar3 != 0) {
		      param1_00 = (int *)param1[2];
		      iVar3 = *param1_00;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar7 = 0;
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + iVar3 + 0xd0);
		            goto code_r0x80d93c32;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		      }
		      puVar4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d93c32:
		      uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		      iVar5 = param1[5];
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xec));
		      dVar6 = *(double *)(iVar5 + iVar3 * 8 + 8);
		      if (dVar6 < 4294967296.0 && 0.0 <= dVar6) {
		        iVar3 = (int)dVar6;
		      }
		      else {
		        iVar3 = 0;
		      }
		      if (ABS(dVar6) < 2147483648.0) {
		        iVar5 = (int)dVar6;
		      }
		      else {
		        iVar5 = -0x80000000;
		      }
		      if (0.0 <= dVar6) {
		        iVar5 = iVar3;
		      }
		      iVar3 = Core_Extensions_Dict_DictExt__GetUserRatingKindDic(uVar1,iVar5,0);
		      if (iVar3 == 0) {
		        iVar5 = param1[5];
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xec));
		        dVar6 = *(double *)(iVar5 + iVar3 * 8 + 8);
		        if (dVar6 < 4294967296.0 && 0.0 <= dVar6) {
		          iVar3 = (int)dVar6;
		        }
		        else {
		          iVar3 = 0;
		        }
		        if (ABS(dVar6) < 2147483648.0) {
		          local_4 = (int)dVar6;
		        }
		        else {
		          local_4 = -0x80000000;
		        }
		        if (0.0 <= dVar6) {
		          local_4 = iVar3;
		        }
		        uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		        iVar3 = func_ii_4419(StringLiteral_5461,uVar1,0);
		        *param4 = iVar3;
		      }
		      else {
		        iVar3 = Core_Extensions_Dict_ClanRatingKindDicExt__GetButton128AssetId(iVar3,0);
		        if (iVar3 == 0) {
		          iVar3 = StringLiteral_5;
		        }
		        *param4 = iVar3;
		      }
		    }
		  }
		  return iVar2;
		}
		*/

}
