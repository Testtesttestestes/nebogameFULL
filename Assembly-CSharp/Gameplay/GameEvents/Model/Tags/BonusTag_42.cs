using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x02000799 RID: 1945
	[Token(Token = "0x2000799")]
	public class BonusTag_42 : AbstractTag
	{
		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x00008FD0 File Offset: 0x000071D0
		[Token(Token = "0x170008EE")]
		public uint BonusId
		{
			[Token(Token = "0x6002E4E")]
			[Address(RVA = "0x7EC9", Offset = "0x7EC9", VA = "0x7EC9")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x6002E4F")]
		[Address(RVA = "0x7ECA", Offset = "0x7ECA", VA = "0x7ECA", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E50")]
		[Address(RVA = "0x7ECB", Offset = "0x7ECB", VA = "0x7ECB")]
		public BonusTag_42()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BonusId ---
		int Gameplay_GameEvents_Model_Tags_BonusTag_42__get_BonusId
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  int iVar5;
		  double dVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a574ce == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a574ce = '\x01';
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
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0x178);
		          goto code_r0x80d93538;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80d93538:
		    uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar1,0);
		    iVar5 = param1[5];
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xec));
		    dVar6 = *(double *)(iVar5 + iVar4 * 8 + 8);
		    if (dVar6 < 4294967296.0 && 0.0 <= dVar6) {
		      iVar4 = (int)dVar6;
		    }
		    else {
		      iVar4 = 0;
		    }
		    if (ABS(dVar6) < 2147483648.0) {
		      iVar5 = (int)dVar6;
		    }
		    else {
		      iVar5 = -0x80000000;
		    }
		    if (0.0 <= dVar6) {
		      iVar5 = iVar4;
		    }
		    uVar1 = Core_Extensions_Dict_DictExt__GetBossTypeDic(uVar1,iVar5,0);
		    uVar1 = Core_Extensions_Dict_BlitzTournamentsDicExt__GetBannerAssetId(uVar1,0);
		  }
		  *param4 = uVar1;
		  return iVar2;
		}
		*/

}
