using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.SourceTags.Tags
{
	// Token: 0x020007B9 RID: 1977
	[Token(Token = "0x20007B9")]
	public class ClanSourceTag : AbstractTag
	{
		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000915")]
		public override RepeatedField<string> TextTags
		{
			[Token(Token = "0x6002EB3")]
			[Address(RVA = "0x7F2E", Offset = "0x7F2E", VA = "0x7F2E", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x00009630 File Offset: 0x00007830
		[Token(Token = "0x17000916")]
		public override uint Len
		{
			[Token(Token = "0x6002EB4")]
			[Address(RVA = "0x7F2F", Offset = "0x7F2F", VA = "0x7F2F", Slot = "5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB5")]
		[Address(RVA = "0x7F30", Offset = "0x7F30", VA = "0x7F30")]
		public ClanSourceTag()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_GameEvents_Model_Tags_SourceTags_Tags_ClanSourceTag___ctor
		              (int *param1,undefined4 param2,int param3,undefined4 *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined8 param2_00;
		  undefined8 local_10;
		  int local_4;
		  
		  if (DAT_ram_00a574ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ClanShortInfo__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21212);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5431);
		    DAT_ram_00a574ec = '\x01';
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
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0xf4)));
		  iVar2 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (uVar1,param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  if (iVar2 == 0) {
		    *param4 = 0;
		  }
		  else {
		    uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_11610,param2,0);
		    *param4 = uVar1;
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_21212,0);
		    if (iVar3 != 0) {
		      param2_00 = func_ii_7271(*(undefined4 *)(*(int *)(param3 + 0x24) + 0x30),0,
		                               Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		      iVar3 = func_ii_7090(*(undefined4 *)(*(int *)(param3 + 0x18) + 0x18),param2_00,&local_4,
		                           Method_System_Collections_Generic_Dictionary_ulong__ClanShortInfo__TryGetValue__
		                          );
		      if (iVar3 == 0) {
		        local_10 = param2_00;
		        uVar1 = func_ii_1081(DAT_ram_00a66968,&local_10);
		        uVar1 = func_ii_4419(StringLiteral_5431,uVar1,0);
		        *param4 = uVar1;
		      }
		      else {
		        *param4 = *(undefined4 *)(local_4 + 0x18);
		      }
		    }
		  }
		  return iVar2;
		}
		*/

		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x00009648 File Offset: 0x00007848
		[Token(Token = "0x6002EB6")]
		[Address(RVA = "0x7F31", Offset = "0x7F31", VA = "0x7F31", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x04001999 RID: 6553
		[Token(Token = "0x4001999")]
		public const string TITLE = "clan_title";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Len ---
		void Gameplay_GameEvents_Model_Tags_SourceTags_Tags_ClanSourceTag__get_Len
		               (int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a574eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21212);
		    DAT_ram_00a574eb = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_string__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (param1_00,Method_Google_Protobuf_Collections_RepeatedField_string___ctor__);
		  param1[6] = param1_00;
		  param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		  func_ii_6441(param1_01,StringLiteral_21212,
		               Method_Google_Protobuf_Collections_RepeatedField_string__Add__);
		  return;
		}
		*/

}
