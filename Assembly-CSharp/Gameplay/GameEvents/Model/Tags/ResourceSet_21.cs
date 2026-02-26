using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B1 RID: 1969
	[Token(Token = "0x20007B1")]
	public class ResourceSet_21 : AbstractTag
	{
		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002E9A RID: 11930 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700090C")]
		public double[] ResourceSetArray
		{
			[Token(Token = "0x6002E9A")]
			[Address(RVA = "0x7F15", Offset = "0x7F15", VA = "0x7F15")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x000094B0 File Offset: 0x000076B0
		[Token(Token = "0x6002E9B")]
		[Address(RVA = "0x7F16", Offset = "0x7F16", VA = "0x7F16", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E9C")]
		[Address(RVA = "0x7F17", Offset = "0x7F17", VA = "0x7F17")]
		public ResourceSet_21()
		{
		}

		// Token: 0x04001988 RID: 6536
		[Token(Token = "0x4001988")]
		public const string RESOURCE_SET = "resource_set";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ResourceSetArray ---
		int Gameplay_GameEvents_Model_Tags_ResourceSet_21__get_ResourceSetArray
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int param1_00;
		  int iVar5;
		  uint uVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a574e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_2556);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26444);
		    DAT_ram_00a574e3 = '\x01';
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
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0xf4));
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))(param1,uVar1);
		  uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar3 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar2,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar3 == 0) {
		    uVar7 = 0;
		  }
		  else {
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = uVar2;
		    iVar4 = System_Collections_CollectionBase___ctor(param2,StringLiteral_26444,0);
		    if (iVar4 == 0) {
		      return iVar3;
		    }
		    if (DAT_ram_00a574e2 == '\0') {
		      Mono_Security_ASN1__get_Item(&double___TypeInfo);
		      DAT_ram_00a574e2 = '\x01';
		    }
		    iVar4 = 0;
		    uVar1 = CONCAT44(uVar7,*(undefined4 *)(*param1 + 0xec));
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,uVar1);
		    uVar7 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    param1_00 = Mono_Security_ASN1Convert__ToOid(double___TypeInfo,uVar2);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,CONCAT44(uVar7,*(undefined4 *)(*param1 + 0xec)));
		    if (iVar5 != 0) {
		      do {
		        *(undefined8 *)(param1_00 + iVar4 * 8 + 0x10) =
		             *(undefined8 *)(param1[5] + iVar4 * 8 + 0x10);
		        iVar4 = iVar4 + 1;
		        uVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xec));
		      } while ((longlong)iVar4 < (longlong)(ulonglong)uVar6);
		    }
		    uVar7 = Utils_MoneyUtils__ExtractArtifactCost(param1_00,0);
		    uVar7 = Core_Extensions_Dict_ResourceSetExt__ToLocaleString
		                      (uVar7,NAN,0,StringLiteral_2556,0,0,0);
		  }
		  *param4 = uVar7;
		  return iVar3;
		}
		*/

}
