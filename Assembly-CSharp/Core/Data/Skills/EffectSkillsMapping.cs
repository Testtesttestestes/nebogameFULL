using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Core.Data.Skills
{
	// Token: 0x020010D1 RID: 4305
	[Token(Token = "0x20010D1")]
	public static class EffectSkillsMapping
	{
		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x060064D8 RID: 25816 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700146E")]
		public static Dictionary<int, string> SkillsIndexNameDefinition
		{
			[Token(Token = "0x60064D8")]
			[Address(RVA = "0xB0BA", Offset = "0xB0BA", VA = "0xB0BA")]
			get
			{
				return null;
			}
		}

		// Token: 0x040035CC RID: 13772
		[Token(Token = "0x40035CC")]
		public const string TURNS_DURATION_NAME = "duration";

		// Token: 0x040035CD RID: 13773
		[Token(Token = "0x40035CD")]
		public const string TIME_DURATION__NAME = "time_durationSEC";

		// Token: 0x040035CE RID: 13774
		[Token(Token = "0x40035CE")]
		public const string MAX_STACK_SIZE_NAME = "maxStackSize";

		// Token: 0x040035CF RID: 13775
		[Token(Token = "0x40035CF")]
		public const string CASTER_SCALER_MULTIPLIER_NAME = "casterScaler";

		// Token: 0x040035D0 RID: 13776
		[Token(Token = "0x40035D0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, string> _skillsIndexNameDefinition;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SkillsIndexNameDefinition ---
		void Core_Data_Skills_EffectSkillsMapping__get_SkillsIndexNameDefinition(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a60813 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_int__string__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_int__string___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_int__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_EffectSkillsMapping_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22759);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21064);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27723);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25310);
		    DAT_ram_00a60813 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_int__string__TypeInfo);
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_int__string___ctor__);
		  UnityEngine_Object__GetInstanceID
		            (param1_00,0,StringLiteral_22759,
		             Method_System_Collections_Generic_Dictionary_int__string__Add__);
		  UnityEngine_Object__GetInstanceID
		            (param1_00,1,StringLiteral_27723,
		             Method_System_Collections_Generic_Dictionary_int__string__Add__);
		  UnityEngine_Object__GetInstanceID
		            (param1_00,2,StringLiteral_25310,
		             Method_System_Collections_Generic_Dictionary_int__string__Add__);
		  UnityEngine_Object__GetInstanceID
		            (param1_00,3,StringLiteral_21064,
		             Method_System_Collections_Generic_Dictionary_int__string__Add__);
		  **(undefined4 **)(Core_Data_Skills_EffectSkillsMapping_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: .cctor ---
		void Core_Data_Skills_EffectSkillsMapping___cctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a60814 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__SkillData___ctor__);
		    DAT_ram_00a60814 = '\x01';
		  }
		  System_Collections_Generic_Dictionary_int__TMP_ResourceManager_FontAssetRef___set_Item
		            (param1,Method_System_Collections_Generic_Dictionary_int__SkillData___ctor__);
		  return;
		}
		*/

}
