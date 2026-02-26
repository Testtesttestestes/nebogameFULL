using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A5 RID: 1957
	[Token(Token = "0x20007A5")]
	public class ExternalMoney_35 : AbstractTag
	{
		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06002E74 RID: 11892 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x170008FE")]
		public double ExternalMoney
		{
			[Token(Token = "0x6002E74")]
			[Address(RVA = "0x7EEF", Offset = "0x7EEF", VA = "0x7EEF")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x6002E75")]
		[Address(RVA = "0x7EF0", Offset = "0x7EF0", VA = "0x7EF0", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E76")]
		[Address(RVA = "0x7EF1", Offset = "0x7EF1", VA = "0x7EF1")]
		public ExternalMoney_35()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ExternalMoney ---
		int Gameplay_GameEvents_Model_Tags_ExternalMoney_35__get_ExternalMoney
		              (int *param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  float8 local_8;
		  
		  if (DAT_ram_00a574d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a574d8 = '\x01';
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
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar1 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (param1_00,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar1 == 0) {
		    iVar2 = 0;
		  }
		  else {
		    iVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = iVar2;
		    iVar3 = param1[5];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xec));
		    local_8 = (float8)(*(double *)(iVar3 + iVar2 * 8 + 8) / 100.0);
		    iVar2 = func_ii_7515(&local_8,0);
		    if (iVar2 == 0) {
		      iVar2 = StringLiteral_5;
		    }
		  }
		  *param4 = iVar2;
		  return iVar1;
		}
		*/

}
