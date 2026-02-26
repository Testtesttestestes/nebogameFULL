using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.Clans
{
	// Token: 0x020007C7 RID: 1991
	[Token(Token = "0x20007C7")]
	public class ClanWarSeason_30 : AbstractTag
	{
		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x000097B0 File Offset: 0x000079B0
		[Token(Token = "0x17000922")]
		public uint SeasonId
		{
			[Token(Token = "0x6002EDD")]
			[Address(RVA = "0x7F4C", Offset = "0x7F4C", VA = "0x7F4C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x000097C8 File Offset: 0x000079C8
		[Token(Token = "0x6002EDE")]
		[Address(RVA = "0x7F4D", Offset = "0x7F4D", VA = "0x7F4D", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDF")]
		[Address(RVA = "0x7F4E", Offset = "0x7F4E", VA = "0x7F4E")]
		public ClanWarSeason_30()
		{
		}

		// Token: 0x040019A7 RID: 6567
		[Token(Token = "0x40019A7")]
		public const string SEASON_TITLE = "season_title";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SeasonId ---
		int Gameplay_GameEvents_Model_Tags_Clans_ClanWarSeason_30__get_SeasonId
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5,
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
		  
		  if (DAT_ram_00a574fb == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26610);
		    DAT_ram_00a574fb = '\x01';
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
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_26610,0);
		    if (iVar3 == 0) {
		      return iVar2;
		    }
		    param1_00 = (int *)param1[2];
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar7 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x80d9a5b1;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar7);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d9a5b1:
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
		    uVar1 = Core_Extensions_Dict_DictExt__TryGetScriptsConstDic(uVar1,iVar5,0);
		    uVar1 = Core_Extensions_Dict_ClanRestrictionDicExt__GetIcon(uVar1,0);
		  }
		  *param4 = uVar1;
		  return iVar2;
		}
		*/

}
