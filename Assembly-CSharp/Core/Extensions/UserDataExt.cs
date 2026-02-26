using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Extensions
{
	// Token: 0x02000F15 RID: 3861
	[Token(Token = "0x2000F15")]
	public static class UserDataExt
	{
		// Token: 0x06005D48 RID: 23880 RVA: 0x00010D28 File Offset: 0x0000EF28
		[Token(Token = "0x6005D48")]
		[Address(RVA = "0xA9BB", Offset = "0xA9BB", VA = "0xA9BB")]
		public static bool IsLegendaryUser(this UserData user)
		{
		/* --- GHIDRA: <IsLegendaryUser>g__CheckApr|0_0 ---
		undefined4
		Core_Extensions_UserDataExt___IsLegendaryUser_g__CheckApr_0_0(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x34);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_00,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == 0x86) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

		/* --- GHIDRA: IsLegendaryUser ---
		undefined4
		Core_Extensions_UserDataExt__IsLegendaryUser(int param1,undefined4 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  double dVar6;
		  int *param1_00;
		  int iVar7;
		  uint uVar8;
		  
		  uVar8 = 0;
		  if (DAT_ram_00a5ace1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_MedalInfo___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24593);
		    DAT_ram_00a5ace1 = '\x01';
		  }
		  *param2 = 0;
		  iVar1 = Sirenix_Utilities_LinqExtensions__IsNullOrEmpty_object_
		                    (*(undefined4 *)(param1 + 0x40),
		                     Method_Sirenix_Utilities_LinqExtensions_IsNullOrEmpty_MedalInfo___);
		  if (iVar1 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar1 = *param1_00;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 + iVar1 + 0x178);
		          goto code_r0x812cdb04;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x812cdb04:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		    iVar1 = 0;
		    dVar6 = Core_Extensions_Dict_DictExt__GetIntParameter(uVar4,StringLiteral_24593,0);
		    iVar7 = *(int *)(*(int *)(param1 + 0x40) + 0xc);
		    if (0 < iVar7) {
		      do {
		        uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		        iVar5 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0x40),iVar1,
		                           Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__get_Item__);
		        iVar5 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0___ctor
		                          (uVar4,*(undefined4 *)(iVar5 + 0xc),iVar1);
		        if ((iVar5 != 0) && (dVar6 == (double)*(uint *)(iVar5 + 0x1c))) {
		          uVar3 = Gameplay_Aprs_Model_AprData__GetAppropriateApr(iVar5,param1,uVar3,0);
		          *param2 = uVar3;
		          return 1;
		        }
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != iVar7);
		    }
		  }
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x00010D40 File Offset: 0x0000EF40
		[Token(Token = "0x6005D49")]
		[Address(RVA = "0xA9BC", Offset = "0xA9BC", VA = "0xA9BC")]
		public static bool TryGetIndividualApr(this UserData user, out AprDicWrapper aprDic)
		{
		/* --- GHIDRA: TryGetIndividualApr ---
		undefined4
		Core_Extensions_UserDataExt__TryGetIndividualApr(int param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int param1_00;
		  int iVar3;
		  longlong lVar4;
		  int *param1_01;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  uint uVar8;
		  int iVar9;
		  int iVar10;
		  
		  if (DAT_ram_00a5ace2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_uint___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a5ace2 = '\x01';
		  }
		  *param2 = 0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar8 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x812cdc85;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x812cdc85:
		  iVar5 = 0;
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		  param1_00 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param1,0);
		  if (DAT_ram_00a5acfc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Item__);
		    DAT_ram_00a5acfc = '\x01';
		  }
		  iVar6 = *(int *)(*(int *)(param1_00 + 0xcc) + 0xc);
		  if (0 < iVar6) {
		    do {
		      iVar7 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1_00 + 0xcc),iVar5,
		                         Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Item__);
		      if (*(longlong *)(iVar7 + 0x20) == lVar4) goto code_r0x812cde9b;
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar6);
		  }
		  iVar6 = *(int *)(*(int *)(param1 + 0x34) + 0x30);
		  iVar5 = 0;
		  if (DAT_ram_00a5acfb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Item__);
		    DAT_ram_00a5acfb = '\x01';
		  }
		  iVar7 = *(int *)(param1_00 + 0xcc);
		  if (0 < *(int *)(iVar7 + 0xc)) {
		    do {
		      iVar7 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar7,iVar5,
		                         Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Item__);
		      if (iVar6 == *(int *)(iVar7 + 0xc)) {
		        if (*(char *)(iVar7 + 0x10) != '\0') goto code_r0x812cde9b;
		        break;
		      }
		      iVar5 = iVar5 + 1;
		      iVar7 = *(int *)(param1_00 + 0xcc);
		    } while (iVar5 < *(int *)(iVar7 + 0xc));
		  }
		  iVar5 = *(int *)(param1 + 0x40);
		  if (iVar5 == 0) {
		    return 0;
		  }
		  iVar6 = 0;
		  iVar9 = *(int *)(iVar5 + 0xc);
		  if (iVar9 < 1) {
		    return 0;
		  }
		  do {
		    iVar7 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(param1 + 0x40),iVar6,
		                       Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__get_Item__);
		    iVar5 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0___ctor
		                      (param1_00,*(undefined4 *)(iVar7 + 0xc),iVar5);
		    uVar2 = *(undefined4 *)(iVar5 + 0x28);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    iVar5 = Core_Extensions_Dict_RewardInfoExt__ToRewardDataArray(uVar2,0xf,0);
		    if (iVar5 == 0) {
		      iVar5 = 0;
		    }
		    else {
		      iVar3 = System_Linq_Enumerable__First_long_
		                        (*(undefined4 *)(iVar5 + 0x10),Method_System_Linq_Enumerable_First_uint___);
		      if (DAT_ram_00a5acfb == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Count__);
		        Mono_Security_ASN1__get_Item
		                  (&Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Item__);
		        DAT_ram_00a5acfb = '\x01';
		      }
		      iVar5 = 0;
		      iVar7 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1_00 + 0xcc),0,
		                         Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Item__);
		      iVar10 = *(int *)(iVar7 + 0xc);
		      while (iVar3 != iVar10) {
		        iVar5 = iVar5 + 1;
		        iVar7 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1_00 + 0xcc),iVar5,
		                           Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Item__)
		        ;
		        iVar10 = *(int *)(iVar7 + 0xc);
		      }
		      if (*(char *)(iVar7 + 0x10) != '\0') {
		code_r0x812cde9b:
		        *param2 = iVar7;
		        return 1;
		      }
		    }
		    iVar6 = iVar6 + 1;
		    if (iVar6 == iVar9) {
		      return 0;
		    }
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x00010D58 File Offset: 0x0000EF58
		[Token(Token = "0x6005D4A")]
		[Address(RVA = "0xA9BD", Offset = "0xA9BD", VA = "0xA9BD")]
		public static bool TryGetIsleForHideUserContent(this UserData user, out IsleInfoDic isleInfoDic)
		{
		/* --- GHIDRA: TryGetIsleForHideUserContent ---
		undefined4 Core_Extensions_UserDataExt__TryGetIsleForHideUserContent(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  longlong lVar2;
		  int iVar3;
		  longlong lVar4;
		  undefined1 auStack_4 [4];
		  
		  if (DAT_ram_00a5ace3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a5ace3 = '\x01';
		  }
		  uVar1 = 1;
		  iVar3 = *(int *)(*(int *)(*param1 + 0x38) + 0x10);
		  if ((*(char *)(iVar3 + 0x20) == '\0') &&
		     (lVar4 = *(longlong *)(iVar3 + 0x18),
		     lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(*param1,0),
		     lVar4 != lVar2)) {
		    uVar1 = Core_Extensions_UserDataExt__IsLegendaryUser(*param1,auStack_4,param1);
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x00010D70 File Offset: 0x0000EF70
		[Token(Token = "0x6005D4B")]
		[Address(RVA = "0xA9BE", Offset = "0xA9BE", VA = "0xA9BE")]
		[CompilerGenerated]
		internal static bool <IsLegendaryUser>g__CheckApr|0_0(ref UserDataExt.<>c__DisplayClass0_0 A_0)
		{
			return default(bool);
		}
	}
}
