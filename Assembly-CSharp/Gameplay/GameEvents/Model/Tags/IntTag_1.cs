using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A7 RID: 1959
	[Token(Token = "0x20007A7")]
	public class IntTag_1 : AbstractTag
	{
		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002E7A RID: 11898 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x17000900")]
		public double Value
		{
			[Token(Token = "0x6002E7A")]
			[Address(RVA = "0x7EF5", Offset = "0x7EF5", VA = "0x7EF5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x6002E7B")]
		[Address(RVA = "0x7EF6", Offset = "0x7EF6", VA = "0x7EF6", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E7C")]
		[Address(RVA = "0x7EF7", Offset = "0x7EF7", VA = "0x7EF7")]
		public IntTag_1()
		{
		/* --- GHIDRA: .ctor ---
		double Gameplay_GameEvents_Model_Tags_IntTag_1___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = param1[5];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  return *(double *)(iVar2 + iVar1 * 8 + 8);
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Value ---
		int Gameplay_GameEvents_Model_Tags_IntTag_1__get_Value
		              (int *param1,undefined4 param2,undefined4 param3,int *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  float8 local_8;
		  
		  if (DAT_ram_00a574da == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a574da = '\x01';
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
		    local_8 = *(float8 *)(param1[5] + 0x10);
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
