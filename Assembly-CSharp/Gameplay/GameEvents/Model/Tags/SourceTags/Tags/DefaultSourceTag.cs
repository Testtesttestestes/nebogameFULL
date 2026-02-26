using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Collections;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.SourceTags.Tags
{
	// Token: 0x020007BA RID: 1978
	[Token(Token = "0x20007BA")]
	public class DefaultSourceTag : AbstractTag
	{
		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000917")]
		public override RepeatedField<string> TextTags
		{
			[Token(Token = "0x6002EB7")]
			[Address(RVA = "0x7F32", Offset = "0x7F32", VA = "0x7F32", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06002EB8 RID: 11960 RVA: 0x00009660 File Offset: 0x00007860
		[Token(Token = "0x17000918")]
		public override uint Len
		{
			[Token(Token = "0x6002EB8")]
			[Address(RVA = "0x7F33", Offset = "0x7F33", VA = "0x7F33", Slot = "5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB9")]
		[Address(RVA = "0x7F34", Offset = "0x7F34", VA = "0x7F34")]
		public DefaultSourceTag()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_Model_Tags_SourceTags_Tags_DefaultSourceTag___ctor
		               (int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a574ee == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28175);
		    DAT_ram_00a574ee = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_string__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (param1_00,Method_Google_Protobuf_Collections_RepeatedField_string___ctor__);
		  param1[6] = param1_00;
		  param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xf4));
		  func_ii_6441(param1_01,StringLiteral_28175,
		               Method_Google_Protobuf_Collections_RepeatedField_string__Add__);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Len ---
		void Gameplay_GameEvents_Model_Tags_SourceTags_Tags_DefaultSourceTag__get_Len
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a574ed == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_string__TypeInfo);
		    DAT_ram_00a574ed = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_string__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (param1_00,Method_Google_Protobuf_Collections_RepeatedField_string___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  return;
		}
		*/

}
