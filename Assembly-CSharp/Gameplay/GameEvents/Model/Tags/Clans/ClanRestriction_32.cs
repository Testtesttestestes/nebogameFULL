using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.Clans
{
	// Token: 0x020007C5 RID: 1989
	[Token(Token = "0x20007C5")]
	public class ClanRestriction_32 : AbstractTag
	{
		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002ED7 RID: 11991 RVA: 0x00009750 File Offset: 0x00007950
		[Token(Token = "0x17000920")]
		public uint RestrictionId
		{
			[Token(Token = "0x6002ED7")]
			[Address(RVA = "0x7F46", Offset = "0x7F46", VA = "0x7F46")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00009768 File Offset: 0x00007968
		[Token(Token = "0x6002ED8")]
		[Address(RVA = "0x7F47", Offset = "0x7F47", VA = "0x7F47", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED9")]
		[Address(RVA = "0x7F48", Offset = "0x7F48", VA = "0x7F48")]
		public ClanRestriction_32()
		{
		}

		// Token: 0x040019A5 RID: 6565
		[Token(Token = "0x40019A5")]
		public const string CLAN_RESTRICTION_TITLE = "clanrestriction";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RestrictionId ---
		int Gameplay_GameEvents_Model_Tags_Clans_ClanRestriction_32__get_RestrictionId
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  int *param1_00;
		  double dVar5;
		  uint uVar6;
		  int param2_00;
		  
		  if (DAT_ram_00a574f9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21215);
		    DAT_ram_00a574f9 = '\x01';
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
		    uVar1 = 0;
		  }
		  else {
		    uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = uVar1;
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21215,0);
		    if (iVar3 == 0) {
		      return iVar2;
		    }
		    param1_00 = (int *)param1[2];
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar6 = 0;
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar6 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x80d9a217;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d9a217:
		    uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		    dVar5 = *(double *)(param1[5] + 0x10);
		    if (dVar5 < 4294967296.0 && 0.0 <= dVar5) {
		      iVar3 = (int)dVar5;
		    }
		    else {
		      iVar3 = 0;
		    }
		    if (ABS(dVar5) < 2147483648.0) {
		      param2_00 = (int)dVar5;
		    }
		    else {
		      param2_00 = -0x80000000;
		    }
		    if (0.0 <= dVar5) {
		      param2_00 = iVar3;
		    }
		    uVar1 = Core_Extensions_Dict_DictExt__GetNotificationCategoryDic(uVar1,param2_00,0);
		    uVar1 = Core_Extensions_Dict_ClanRatingKindDicExt__GetDescription(uVar1,0);
		  }
		  *param4 = uVar1;
		  return iVar2;
		}
		*/

}
