using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A1 RID: 1953
	[Token(Token = "0x20007A1")]
	public class DailyQuestTag_36 : AbstractTag
	{
		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x00009168 File Offset: 0x00007368
		[Token(Token = "0x170008F7")]
		public uint DaylyQuestId
		{
			[Token(Token = "0x6002E67")]
			[Address(RVA = "0x7EE2", Offset = "0x7EE2", VA = "0x7EE2")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x00009180 File Offset: 0x00007380
		[Token(Token = "0x6002E68")]
		[Address(RVA = "0x7EE3", Offset = "0x7EE3", VA = "0x7EE3", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E69")]
		[Address(RVA = "0x7EE4", Offset = "0x7EE4", VA = "0x7EE4")]
		public DailyQuestTag_36()
		{
		}

		// Token: 0x04001976 RID: 6518
		[Token(Token = "0x4001976")]
		public const string DAILY_QUEST_TITLE = "daily_quest_title";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DaylyQuestId ---
		int Gameplay_GameEvents_Model_Tags_DailyQuestTag_36__get_DaylyQuestId
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
		  undefined4 local_4;
		  
		  if (DAT_ram_00a574d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22490);
		    DAT_ram_00a574d6 = '\x01';
		  }
		  local_4 = 0;
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
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_22490,0);
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
		          goto code_r0x80d94f60;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar6);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d94f60:
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
		    iVar3 = Core_Extensions_Dict_DictExt__GetCollectionRankInfoDic(uVar1,param2_00,&local_4,0);
		    if (iVar3 == 0) {
		      return iVar2;
		    }
		    uVar1 = Core_Extensions_Dict_DailyQuestCategoriesDicExt__GetTitle(local_4,0);
		  }
		  *param4 = uVar1;
		  return iVar2;
		}
		*/

}
