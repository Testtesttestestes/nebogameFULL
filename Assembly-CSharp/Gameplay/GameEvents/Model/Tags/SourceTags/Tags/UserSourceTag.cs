using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.SourceTags.Tags
{
	// Token: 0x020007BB RID: 1979
	[Token(Token = "0x20007BB")]
	public class UserSourceTag : AbstractTag
	{
		// Token: 0x06002EBA RID: 11962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBA")]
		[Address(RVA = "0x7F35", Offset = "0x7F35", VA = "0x7F35")]
		public UserSourceTag()
		{
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06002EBB RID: 11963 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000919")]
		public override RepeatedField<string> TextTags
		{
			[Token(Token = "0x6002EBB")]
			[Address(RVA = "0x7F36", Offset = "0x7F36", VA = "0x7F36", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002EBC RID: 11964 RVA: 0x00009678 File Offset: 0x00007878
		[Token(Token = "0x1700091A")]
		public override uint Len
		{
			[Token(Token = "0x6002EBC")]
			[Address(RVA = "0x7F37", Offset = "0x7F37", VA = "0x7F37", Slot = "5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x00009690 File Offset: 0x00007890
		[Token(Token = "0x6002EBD")]
		[Address(RVA = "0x7F38", Offset = "0x7F38", VA = "0x7F38", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
		/* --- GHIDRA: TryGetValue ---
		void Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a574f0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventTagDic_Types_Tag__IMetaTagFactory__Add__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_Tags_Factories_IMetaTagFactory_TypeInfo)
		    ;
		    DAT_ram_00a574f0 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 8);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_GameEvents_Model_Tags_Factories_IMetaTagFactory_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80d99092;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                Gameplay_GameEvents_Model_Tags_Factories_IMetaTagFactory_TypeInfo,0)
		  ;
		code_r0x80d99092:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  func_ii_10812(param1_00,param2_00,param2,
		                Method_System_Collections_Generic_Dictionary_EventTagDic_Types_Tag__IMetaTagFactory__Add__
		               );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0400199C RID: 6556
		[Token(Token = "0x400199C")]
		public const string NICK = "user_game_nick";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Len ---
		int Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__get_Len
		              (int *param1,undefined4 param2,int param3,undefined4 *param4,undefined4 param5,
		              undefined4 param6)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined8 param2_00;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a574ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__UserData__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28175);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17327);
		    DAT_ram_00a574ef = '\x01';
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
		    iVar3 = System_Collections_CollectionBase___ctor(param2,StringLiteral_28175,0);
		    if (iVar3 != 0) {
		      param2_00 = func_ii_7271(*(undefined4 *)(*(int *)(param3 + 0x24) + 0x30),0,
		                               Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		      iVar3 = func_ii_7090(*(undefined4 *)(*(int *)(param3 + 0x18) + 0x14),param2_00,&local_4,
		                           Method_System_Collections_Generic_Dictionary_ulong__UserData__TryGetValue__
		                          );
		      if (iVar3 == 0) {
		        local_10 = param2_00;
		        uVar1 = func_ii_1081(DAT_ram_00a66968,&local_10);
		        uVar1 = func_ii_4419(StringLiteral_17327,uVar1,0);
		        *param4 = uVar1;
		      }
		      else {
		        uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(local_4,0);
		        *param4 = uVar1;
		      }
		    }
		  }
		  return iVar2;
		}
		*/

}
