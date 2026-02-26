using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x0200079F RID: 1951
	[Token(Token = "0x200079F")]
	public class CultTag_13 : AbstractTag
	{
		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x170008F5")]
		public uint CultId
		{
			[Token(Token = "0x6002E61")]
			[Address(RVA = "0x7EDC", Offset = "0x7EDC", VA = "0x7EDC")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00009120 File Offset: 0x00007320
		[Token(Token = "0x6002E62")]
		[Address(RVA = "0x7EDD", Offset = "0x7EDD", VA = "0x7EDD", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E63")]
		[Address(RVA = "0x7EDE", Offset = "0x7EDE", VA = "0x7EDE")]
		public CultTag_13()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CultId ---
		int Gameplay_GameEvents_Model_Tags_CultTag_13__get_CultId
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  double dVar7;
		  
		  if (DAT_ram_00a574d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a574d4 = '\x01';
		  }
		  if (DAT_ram_00a574cb == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_11610);
		    DAT_ram_00a574cb = '\x01';
		  }
		  uVar1 = 0;
		  if (DAT_ram_00a574ca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		    DAT_ram_00a574ca = '\x01';
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar3 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar2,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar3 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = uVar2;
		    param1_00 = (int *)param1[2];
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x80d94af9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80d94af9:
		    uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		    iVar6 = param1[5];
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xec));
		    dVar7 = *(double *)(iVar6 + iVar5 * 8 + 8);
		    if (dVar7 < 4294967296.0 && 0.0 <= dVar7) {
		      iVar5 = (int)dVar7;
		    }
		    else {
		      iVar5 = 0;
		    }
		    if (ABS(dVar7) < 2147483648.0) {
		      iVar6 = (int)dVar7;
		    }
		    else {
		      iVar6 = -0x80000000;
		    }
		    if (0.0 <= dVar7) {
		      iVar6 = iVar5;
		    }
		    uVar2 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType(uVar2,iVar6,0);
		    uVar2 = System_Collections_Generic_Dictionary_object__object____ctor(uVar2,0);
		  }
		  *param4 = uVar2;
		  return iVar3;
		}
		*/

}
