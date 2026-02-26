using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B7 RID: 1975
	[Token(Token = "0x20007B7")]
	public class UserRatingTypeTag_19 : AbstractTag
	{
		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x000095D0 File Offset: 0x000077D0
		[Token(Token = "0x17000913")]
		public uint RatingKindId
		{
			[Token(Token = "0x6002EAD")]
			[Address(RVA = "0x7F28", Offset = "0x7F28", VA = "0x7F28")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x6002EAE")]
		[Address(RVA = "0x7F29", Offset = "0x7F29", VA = "0x7F29", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAF")]
		[Address(RVA = "0x7F2A", Offset = "0x7F2A", VA = "0x7F2A")]
		public UserRatingTypeTag_19()
		{
		}

		// Token: 0x04001994 RID: 6548
		[Token(Token = "0x4001994")]
		public const string USER_RATING_TYPE = "user_rating_type";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RatingKindId ---
		int Gameplay_GameEvents_Model_Tags_UserRatingTypeTag_19__get_RatingKindId
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
		  
		  if (DAT_ram_00a574e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13326);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28181);
		    DAT_ram_00a574e9 = '\x01';
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
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_28181,0);
		    if (iVar3 != 0) {
		      param1_00 = (int *)param1[2];
		      iVar3 = *param1_00;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar7 = 0;
		        do {
		          if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + iVar3 + 0xd0);
		            goto code_r0x80d985dd;
		          }
		          uVar7 = uVar7 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		      }
		      puVar4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d985dd:
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
		      iVar3 = Core_Extensions_Dict_DictExt__GetExperienceDic(uVar1,iVar5,0);
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
		        iVar3 = func_ii_4419(StringLiteral_13326,uVar1,0);
		        *param4 = iVar3;
		      }
		      else {
		        iVar3 = Gameplay_UserInfo_View_TitleIconValueBackground__set_Index(iVar3,0);
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
