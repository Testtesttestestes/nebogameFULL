using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007AE RID: 1966
	[Token(Token = "0x20007AE")]
	public class OptionTypeTag_40 : AbstractTag
	{
		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002E91 RID: 11921 RVA: 0x00009420 File Offset: 0x00007620
		[Token(Token = "0x17000908")]
		public OptionTypesDic.Types.OptionType OptionType
		{
			[Token(Token = "0x6002E91")]
			[Address(RVA = "0x7F0C", Offset = "0x7F0C", VA = "0x7F0C")]
			get
			{
				return OptionTypesDic.Types.OptionType.Diamond;
			}
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x6002E92")]
		[Address(RVA = "0x7F0D", Offset = "0x7F0D", VA = "0x7F0D", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E93")]
		[Address(RVA = "0x7F0E", Offset = "0x7F0E", VA = "0x7F0E")]
		public OptionTypeTag_40()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_OptionType ---
		int Gameplay_GameEvents_Model_Tags_OptionTypeTag_40__get_OptionType
		              (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
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
		  }
		  *param4 = uVar1;
		  return iVar2;
		}
		*/

}
