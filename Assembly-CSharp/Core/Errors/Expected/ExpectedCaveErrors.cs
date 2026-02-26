using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001049 RID: 4169
	[Token(Token = "0x2001049")]
	public class ExpectedCaveErrors : ExpectedBillingErrors
	{
		// Token: 0x06006214 RID: 25108 RVA: 0x000123D8 File Offset: 0x000105D8
		[Token(Token = "0x6006214")]
		[Address(RVA = "0xAE3F", Offset = "0xAE3F", VA = "0xAE3F", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006215 RID: 25109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006215")]
		[Address(RVA = "0xAE40", Offset = "0xAE40", VA = "0xAE40")]
		public ExpectedCaveErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Errors_Expected_ExpectedCaveErrors___ctor(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int param2_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param3_00;
		  int *param1_00;
		  int iVar6;
		  int *param1_01;
		  int iVar7;
		  int param2_01;
		  int *piVar8;
		  
		  param2_01 = 0;
		  uVar2 = 0;
		  if (DAT_ram_00a5a366 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoChangeAprAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4157);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4159);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25334);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4156);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4158);
		    DAT_ram_00a5a366 = '\x01';
		  }
		  if (param2 != -8) {
		    if (param2 == -7) {
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = func_ii_7508(StringLiteral_4157,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar2,2,uVar4,0);
		      return 1;
		    }
		    if (param2 != -6) {
		      if (param2 == -5) {
		        uVar2 = System_Uri___ctor(0);
		        uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar2 = 1;
		        uVar5 = func_ii_7508(StringLiteral_4156,1,0,1,0,0,0,0);
		        Core_Application_App__get_ToastController(uVar4,2,uVar5,0);
		      }
		      return uVar2;
		    }
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = func_ii_7508(StringLiteral_4158,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar2,2,uVar4,0);
		    return 1;
		  }
		  param1_00 = *(int **)(param1 + 8);
		  if ((param1_00 != (int *)0x0) && (Protocol_Services_ProtoChangeAprAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Services_ProtoChangeAprAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00 = Mono_Security_ASN1Convert__ToOid
		                        (string___TypeInfo,*(undefined4 *)(param1_00[4] + 0xc));
		  iVar6 = *(int *)(param1_00[4] + 0xc);
		  if (0 < iVar6) {
		    do {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *param1_01;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		            puVar3 = (uint *)(piVar8[1] * 8 + iVar7 + 0x178);
		            goto code_r0x8120c419;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8120c419:
		      uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		      uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		      uVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00[4],param2_01,
		                         Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		      uVar2 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0___ctor
		                        (uVar2,uVar4,0);
		      uVar2 = func_ii_14054(uVar2,0);
		      *(undefined4 *)(param2_00 + param2_01 * 4 + 0x10) = uVar2;
		      param2_01 = param2_01 + 1;
		    } while (param2_01 != iVar6);
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_4159,1,0,1,0,0,0,0);
		  uVar4 = System_Uri___ctor(0);
		  uVar4 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar4,0);
		  uVar5 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar5,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  param3_00 = UnityEngine_Assertions_Assert__IsFalse(StringLiteral_1238,param2_00,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar5,StringLiteral_25334,param3_00,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(uVar2,uVar5,0);
		  Core_Application_App__get_ToastController(uVar4,2,uVar2,0);
		  return 1;
		}
		*/

		}
	}
}
