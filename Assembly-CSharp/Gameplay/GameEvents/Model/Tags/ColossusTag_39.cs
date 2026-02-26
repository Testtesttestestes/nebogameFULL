using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x0200079E RID: 1950
	[Token(Token = "0x200079E")]
	public class ColossusTag_39 : AbstractTag
	{
		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06002E5E RID: 11870 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x170008F4")]
		public uint ColossusId
		{
			[Token(Token = "0x6002E5E")]
			[Address(RVA = "0x7ED9", Offset = "0x7ED9", VA = "0x7ED9")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x6002E5F")]
		[Address(RVA = "0x7EDA", Offset = "0x7EDA", VA = "0x7EDA", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E60")]
		[Address(RVA = "0x7EDB", Offset = "0x7EDB", VA = "0x7EDB")]
		public ColossusTag_39()
		{
		}

		// Token: 0x04001973 RID: 6515
		[Token(Token = "0x4001973")]
		public const string COLOSSUS_TITLE = "colossus_title";

		// Token: 0x04001974 RID: 6516
		[Token(Token = "0x4001974")]
		public const string COLOSSUS_VIEW = "colossus_view";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ColossusId ---
		int Gameplay_GameEvents_Model_Tags_ColossusTag_39__get_ColossusId
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,int param5,
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
		  
		  if (DAT_ram_00a574d3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_AprTagView___);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3190);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21423);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21425);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a574d3 = '\x01';
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
		    return 0;
		  }
		  uVar7 = 0;
		  uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		  *param4 = uVar1;
		  param1_00 = (int *)param1[2];
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80d948d3;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d948d3:
		  uVar1 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
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
		  uVar1 = Core_Extensions_Dict_DictExt__GetShoppingDiff(uVar1,iVar5,0);
		  iVar4 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21423,0);
		  if (iVar4 == 0) {
		    iVar4 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21425,0);
		    if (iVar4 != 0) {
		      *param4 = StringLiteral_5;
		      iVar4 = Gameplay_Collections_Model_Factories_CollectionDataFactory__Create
		                        (param1,StringLiteral_3190,*(undefined4 *)(param5 + 8),
		                         Method_Gameplay_GameEvents_Model_Tags_AbstractTag_GetView_AprTagView___);
		      uVar1 = Core_Extensions_Dict_ColossusDicExt__GetIsleIcon(uVar1,0);
		      *(undefined4 *)(iVar4 + 0x58) = 2;
		      *(undefined4 *)(iVar4 + 0x60) = uVar1;
		    }
		    return iVar2;
		  }
		  uVar1 = Core_Extensions_Dict_CollectionsDicExt__GetDescription(uVar1,0);
		  *param4 = uVar1;
		  return iVar2;
		}
		*/

}
