using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A8 RID: 1960
	[Token(Token = "0x20007A8")]
	public class IntervalTag_16 : AbstractTag
	{
		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x17000901")]
		public double Value
		{
			[Token(Token = "0x6002E7D")]
			[Address(RVA = "0x7EF8", Offset = "0x7EF8", VA = "0x7EF8")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x6002E7E")]
		[Address(RVA = "0x7EF9", Offset = "0x7EF9", VA = "0x7EF9", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E7F")]
		[Address(RVA = "0x7EFA", Offset = "0x7EFA", VA = "0x7EFA")]
		public IntervalTag_16()
		{
		}

		// Token: 0x0400197A RID: 6522
		[Token(Token = "0x400197A")]
		public const string INTERVAL_NAME = "interval";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Value ---
		int Gameplay_GameEvents_Model_Tags_IntervalTag_16__get_Value
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 in_register_20000004;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  double dVar7;
		  
		  if (DAT_ram_00a574db == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24649);
		    DAT_ram_00a574db = '\x01';
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
		  uVar1 = CONCAT44(in_register_20000004,param1);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (uVar1,*(undefined4 *)(*param1 + 0xf4));
		  uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar3 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar2,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar3 == 0) {
		    uVar5 = 0;
		  }
		  else {
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = uVar2;
		    iVar4 = System_Collections_CollectionBase___ctor(param2,StringLiteral_24649,0);
		    if (iVar4 == 0) {
		      return iVar3;
		    }
		    iVar6 = param1[5];
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (CONCAT44(uVar5,param1),*(undefined4 *)(*param1 + 0xec));
		    dVar7 = *(double *)(iVar6 + iVar4 * 8 + 8);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    uVar5 = Utils_TimeUtils__DateFormat(dVar7 / 1000.0,0);
		  }
		  *param4 = uVar5;
		  return iVar3;
		}
		*/

}
