using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Chat;
using Protocol.Combat;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;
using Protocol.SmallGames;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F46 RID: 3910
	[Token(Token = "0x2000F46")]
	public static class DictExt
	{
		// Token: 0x06005E16 RID: 24086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E16")]
		[Address(RVA = "0xAA7D", Offset = "0xAA7D", VA = "0xAA7D")]
		private static void LogGetWarning(object id, string msg)
		{
		/* --- GHIDRA: LogGetWarning ---
		int Core_Extensions_Dict_DictExt__LogGetWarning(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  undefined1 auStack_10 [8];
		  int local_8;
		  undefined4 local_4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a5ace6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_ArtikulTypeDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulTypeDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtikulTypeDic__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_Dict_DictExt___c__GetArtikulType_b__1_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3312);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11315);
		    DAT_ram_00a5ace6 = '\x01';
		  }
		  if (param2 != 0) {
		    local_4 = *(undefined4 *)(param1 + 0xd0);
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    iVar1 = puVar3[1];
		    if (iVar1 == 0) {
		      if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		        puVar3 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar3;
		      iVar1 = unnamed_function_1417(System_Func_ArtikulTypeDic__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (iVar1,uVar2,Method_Core_Extensions_Dict_DictExt___c__GetArtikulType_b__1_0__,0);
		      *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 4) = iVar1;
		    }
		    iVar1 = func_ii_8597(&local_4,iVar1,param2,
		                         Method_Core_Extensions_Dict_DictExt_BinarySearch_ArtikulTypeDic__uint___);
		    if (iVar1 == 0) {
		      local_8 = param2;
		      param3_00 = func_ii_1081(DAT_ram_00a66958,&local_8);
		      uVar2 = StringLiteral_3312;
		      if (DAT_ram_00a5ace5 == '\0') {
		        Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		        Mono_Security_ASN1__get_Item(&StringLiteral_18888);
		        DAT_ram_00a5ace5 = '\x01';
		      }
		      uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                        (StringLiteral_18888,uVar2,param3_00,0);
		      if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(OKG_Logs_Debug_TypeInfo);
		      }
		      func_ii_7830(uVar2,0);
		      if (*(int *)(Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo);
		      }
		      iVar1 = Core_Extensions_Dict_NotFoundInDictsUtil__CreateNotFoundArtikulDic
		                        (param2,StringLiteral_11315,auStack_10);
		      func_ii_6441(*(undefined4 *)(param1 + 0xd0),iVar1,
		                   Method_Google_Protobuf_Collections_RepeatedField_ArtikulTypeDic__Add__);
		    }
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E17")]
		[Address(RVA = "0xAA7E", Offset = "0xAA7E", VA = "0xAA7E")]
		public static ArtikulTypeDic GetArtikulType(this Dictionaries dict, uint typeId)
		{
		/* --- GHIDRA: GetArtikulType ---
		undefined4 Core_Extensions_Dict_DictExt__GetArtikulType(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int local_4;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a5ace7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ItemQualityDic__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ItemQualityDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ItemQualityDic__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10019);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11315);
		    DAT_ram_00a5ace7 = '\x01';
		  }
		  iVar5 = *(int *)(*(int *)(param1 + 0x44) + 0xc);
		  if (0 < iVar5) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x44),iVar1,
		                         Method_Google_Protobuf_Collections_RepeatedField_ItemQualityDic__get_Item__
		                        );
		      if (*(int *)(iVar2 + 0xc) == param2) {
		        return iVar2;
		      }
		      iVar1 = iVar1 + 1;
		    } while (iVar1 != iVar5);
		  }
		  local_4 = param2;
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar4 = StringLiteral_10019;
		  if (DAT_ram_00a5ace5 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_18888);
		    DAT_ram_00a5ace5 = '\x01';
		  }
		  uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_18888,uVar4,uVar3,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  uVar3 = 0;
		  func_ii_7830(uVar4,0);
		  iVar1 = Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo;
		  if (param2 != 0) {
		    if (*(int *)(Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_NotFoundInDictsUtil__CreateNotFoundArtikulTypeDic
		                      (param2,iVar1,iVar1);
		    func_ii_6441(*(undefined4 *)(param1 + 0x44),uVar3,
		                 Method_Google_Protobuf_Collections_RepeatedField_ItemQualityDic__Add__);
		  }
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E18")]
		[Address(RVA = "0xAA7F", Offset = "0xAA7F", VA = "0xAA7F")]
		public static ItemQualityDic GetItemQuality(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetItemQuality ---
		undefined4
		Core_Extensions_Dict_DictExt__GetItemQuality(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5acea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_SpellDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_SpellDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_Dict_DictExt___c__GetSpell_b__5_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5acea = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0x4c);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[4];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_SpellDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar1,Method_Core_Extensions_Dict_DictExt___c__GetSpell_b__5_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x10) = param1_00;
		  }
		  uVar1 = func_ii_8597(&local_4,param1_00,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_SpellDic__uint___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E19")]
		[Address(RVA = "0x445B", Offset = "0x445B", VA = "0x445B")]
		public static ArtikulDic GetArtikul(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetArtikul ---
		undefined4 Core_Extensions_Dict_DictExt__GetArtikul(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x70);
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
		      if (*(int *)(iVar1 + 0xc) == 1) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E1A RID: 24090 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E1A")]
		[Address(RVA = "0x36DD", Offset = "0x36DD", VA = "0x36DD")]
		public static ModifierDic GetModifier(this Dictionaries dict, uint modifierId)
		{
		/* --- GHIDRA: GetModifier ---
		void Core_Extensions_Dict_DictExt__GetModifier
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int param1_00;
		  int param2_00;
		  
		  if (DAT_ram_00a60816 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_uint__long___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_long___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__long__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_Skills_SkillCollection___c___ctor_b__2_0__);
		    Mono_Security_ASN1__get_Item(&Core_Data_Skills_SkillCollection___c_TypeInfo);
		    DAT_ram_00a60816 = '\x01';
		  }
		  if (*(int *)(Core_Data_Skills_SkillCollection___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_Skills_SkillCollection___c_TypeInfo);
		  }
		  piVar2 = *(int **)(Core_Data_Skills_SkillCollection___c_TypeInfo + 0x5c);
		  param1_00 = piVar2[1];
		  param2_00 = Core_Data_Skills_SkillCollection___c_TypeInfo;
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Data_Skills_SkillCollection___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Data_Skills_SkillCollection___c_TypeInfo);
		      piVar2 = *(int **)(Core_Data_Skills_SkillCollection___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *piVar2;
		    param1_00 = unnamed_function_1417(System_Func_uint__long__TypeInfo);
		    System_Func_uint__Int32Enum___Invoke
		              (param1_00,param2_00,Method_Core_Data_Skills_SkillCollection___c___ctor_b__2_0__,0);
		    *(int *)(*(int *)(Core_Data_Skills_SkillCollection___c_TypeInfo + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Select_uint__Int32Enum_
		                    (param2,param1_00,Method_System_Linq_Enumerable_Select_uint__long___);
		  uVar1 = System_Linq_Enumerable__ToList_int_(uVar1,Method_System_Linq_Enumerable_ToList_long___);
		  func_ii_8056(param1,uVar1,param2_00);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E1B")]
		[Address(RVA = "0xAA80", Offset = "0xAA80", VA = "0xAA80")]
		public static SpellDic GetSpell(this Dictionaries dict, uint spellId)
		{
		/* --- GHIDRA: GetSpell ---
		undefined4
		Core_Extensions_Dict_DictExt__GetSpell(int param1,int param2,int param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5aceb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SpellLevelDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SpellLevelDic__get_Item__);
		    DAT_ram_00a5aceb = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x50) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x50),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_SpellLevelDic__get_Item__)
		      ;
		      if ((param2 == *(int *)(iVar1 + 0xc)) && (*(int *)(iVar1 + 0x10) == param3)) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E1C")]
		[Address(RVA = "0xAA81", Offset = "0xAA81", VA = "0xAA81")]
		public static SpellLevelDic GetSpellLevelDic(this Dictionaries dict, uint spellId, uint level)
		{
		/* --- GHIDRA: GetSpellLevelDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetSpellLevelDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5acec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_EffectDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_EffectDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_Dict_DictExt___c__GetEffect_b__7_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5acec = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0x54);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[5];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_EffectDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar1,Method_Core_Extensions_Dict_DictExt___c__GetEffect_b__7_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x14) = param1_00;
		  }
		  uVar1 = func_ii_8597(&local_4,param1_00,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_EffectDic__uint___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E1D")]
		[Address(RVA = "0xAA82", Offset = "0xAA82", VA = "0xAA82")]
		public static EffectDic GetEffect(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetEffect ---
		undefined4
		Core_Extensions_Dict_DictExt__GetEffect(int param1,int param2,int param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5aced == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectLevelDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EffectLevelDic__get_Item__);
		    DAT_ram_00a5aced = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x58) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x58),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_EffectLevelDic__get_Item__
		                        );
		      if ((param2 == *(int *)(iVar1 + 0xc)) && (*(int *)(iVar1 + 0x10) == param3)) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E1E RID: 24094 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E1E")]
		[Address(RVA = "0xAA83", Offset = "0xAA83", VA = "0xAA83")]
		public static EffectLevelDic GetEffectLevelDic(this Dictionaries dict, uint effectId, uint level)
		{
		/* --- GHIDRA: GetEffectLevelDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetEffectLevelDic(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int param2_00;
		  
		  if (DAT_ram_00a5acee == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_CombatTypeGemSetsDic___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CombatTypeGemSetsDic__get_Item__);
		    DAT_ram_00a5acee = '\x01';
		  }
		  iVar1 = func_ii_6330(*(undefined4 *)(param1 + 200),
		                       Method_System_Linq_Enumerable_Count_CombatTypeGemSetsDic___);
		  if (0 < iVar1) {
		    param2_00 = 0;
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 200),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_CombatTypeGemSetsDic__get_Item__
		                        );
		      if ((ulonglong)*(uint *)(iVar2 + 0xc) == (longlong)(param2 + 1)) {
		        return iVar2;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x1e4),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_CombatTypeGemSetsDic__get_Item__
		                    );
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E1F")]
		[Address(RVA = "0xAA84", Offset = "0xAA84", VA = "0xAA84")]
		public static CombatTypeGemSetsDic GetGemsSetByCombatType(this Dictionaries dict, int combatType)
		{
		/* --- GHIDRA: GetGemsSetByCombatType ---
		int Core_Extensions_Dict_DictExt__GetGemsSetByCombatType(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a5acef == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_GameFieldGemSetsDic___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_GameFieldGemSetsDic__get_Item__);
		    DAT_ram_00a5acef = '\x01';
		  }
		  iVar3 = func_ii_6330(*(undefined4 *)(param1 + 0xc4),
		                       Method_System_Linq_Enumerable_Count_GameFieldGemSetsDic___);
		  if (0 < iVar3) {
		    if (param2 == 0) {
		      iVar1 = 0;
		      do {
		        iVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0xc4),iVar1,
		                           Method_Google_Protobuf_Collections_RepeatedField_GameFieldGemSetsDic__get_Item__
		                          );
		        if (*(char *)(iVar4 + 0x14) == '\0') {
		          iVar4 = iVar2;
		        }
		        iVar2 = iVar4;
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != iVar3);
		    }
		    else {
		      iVar1 = 0;
		      do {
		        iVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0xc4),iVar1,
		                           Method_Google_Protobuf_Collections_RepeatedField_GameFieldGemSetsDic__get_Item__
		                          );
		        if (*(int *)(iVar4 + 0xc) == *(int *)(param2 + 0x10)) {
		          return iVar4;
		        }
		        if (*(char *)(iVar4 + 0x14) == '\0') {
		          iVar4 = iVar2;
		        }
		        iVar2 = iVar4;
		        iVar1 = iVar1 + 1;
		      } while (iVar1 != iVar3);
		    }
		  }
		  return iVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E20")]
		[Address(RVA = "0xAA85", Offset = "0xAA85", VA = "0xAA85")]
		public static GameFieldGemSetsDic GetGameFiledGems(this Dictionaries dict, CombatTypeGemSetsDic gemSet)
		{
		/* --- GHIDRA: GetGameFiledGems ---
		int Core_Extensions_Dict_DictExt__GetGameFiledGems(int param1,uint param2,undefined4 param3)
		
		{
		  int param1_00;
		  int param2_00;
		  int iVar1;
		  uint uVar2;
		  int param2_01;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a5acf0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ArtikulTypeFilters__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeFilters___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtikulTypeFilters__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtikulTypeFilters__get_Item__);
		    DAT_ram_00a5acf0 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ArtikulTypeFilters__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ArtikulTypeFilters___ctor__);
		  iVar1 = *(int *)(param1 + 0x174);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      param2_00 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (iVar1,param2_01,
		                             Method_Google_Protobuf_Collections_RepeatedField_ArtikulTypeFilters__get_Item__
		                            );
		      iVar1 = Method_System_Collections_Generic_List_ArtikulTypeFilters__Add__;
		      if ((*(uint *)(param2_00 + 0x10) & param2) != 0) {
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar2 = *(uint *)(param1_00 + 0xc);
		        if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		          *(int *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2_00;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param2_00,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      param2_01 = param2_01 + 1;
		      iVar1 = *(int *)(param1 + 0x174);
		    } while (param2_01 < *(int *)(iVar1 + 0xc));
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E21")]
		[Address(RVA = "0xAA86", Offset = "0xAA86", VA = "0xAA86")]
		public static List<ArtikulTypeFilters> GetArtikulTypeFiltersByFilterType(this Dictionaries dict, ArtikulTypeFilters.Types.FilterType filterType)
		{
		/* --- GHIDRA: GetArtikulTypeFiltersByFilterType ---
		int Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined1 auStack_10 [8];
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5acf2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_Dict_DictExt_BinarySearch_AprDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_AprDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_Dict_DictExt___c__GetApr_b__13_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3192);
		    DAT_ram_00a5acf2 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0x34);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[7];
		  if (iVar3 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_AprDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar3,uVar1,Method_Core_Extensions_Dict_DictExt___c__GetApr_b__13_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x1c) = iVar3;
		  }
		  iVar3 = func_ii_8597(&local_4,iVar3,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_AprDic__uint___);
		  if (iVar3 == 0) {
		    local_8 = param2;
		    param3_00 = func_ii_1081(DAT_ram_00a66958,&local_8);
		    uVar1 = StringLiteral_3192;
		    if (DAT_ram_00a5ace5 == '\0') {
		      Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		      Mono_Security_ASN1__get_Item(&StringLiteral_18888);
		      DAT_ram_00a5ace5 = '\x01';
		    }
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_18888,uVar1,param3_00,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar1,0);
		    if (*(int *)(Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_NotFoundInDictsUtil_TypeInfo);
		    }
		    iVar3 = Core_Extensions_Dict_NotFoundInDictsUtil__CreateNotFoundItemQualityDic
		                      (param2,auStack_10,auStack_10);
		  }
		  return iVar3;
		}
		*/

			return null;
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E22")]
		[Address(RVA = "0x216E", Offset = "0x216E", VA = "0x216E")]
		public static ArtikulTypeFilters GetArtikulTypeFiltersByFilterId(this Dictionaries dict, uint filterId)
		{
		/* --- GHIDRA: GetArtikulTypeFiltersByFilterId ---
		void Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterId
		               (int param1,undefined4 param2,int param3)
		
		{
		  System_Collections_Generic_List_uint___GetRange
		            (param1,*(undefined4 *)(param1 + 0xc),param2,
		             *(undefined4 *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0x48));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E23")]
		[Address(RVA = "0xAA87", Offset = "0xAA87", VA = "0xAA87")]
		public static AprDic GetApr(this Dictionaries dict, uint aprId)
		{
		/* --- GHIDRA: GetApr ---
		undefined4 Core_Extensions_Dict_DictExt__GetApr(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (0 < *(int *)(param1 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E24 RID: 24100 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E24")]
		[Address(RVA = "0x1F34", Offset = "0x1F34", VA = "0x1F34")]
		public static AprMarkersDic GetAprMarker(this Dictionaries dict, uint markerId)
		{
		/* --- GHIDRA: GetAprMarker ---
		undefined4 Core_Extensions_Dict_DictExt__GetAprMarker(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  param1_00 = *(int *)(param1 + 0x1c);
		  param2_00 = 0;
		  if (DAT_ram_00a5acf4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__);
		    DAT_ram_00a5acf4 = '\x01';
		  }
		  if (*(int *)(param1_00 + 0xc) < 1) {
		    uVar2 = 0;
		  }
		  else {
		    while (iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                             (param1_00,param2_00,
		                              Method_Google_Protobuf_Collections_RepeatedField_ContentResourceAsset__get_Item__
		                             ), *(int *)(iVar1 + 0xc) != 0x90) {
		      param2_00 = param2_00 + 1;
		      if (*(int *)(param1_00 + 0xc) <= param2_00) {
		        return 0;
		      }
		    }
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E25")]
		[Address(RVA = "0xAA88", Offset = "0xAA88", VA = "0xAA88")]
		public static ContentResourceAsset GetAsset(this RepeatedField<ContentResourceAsset> content, uint id)
		{
		/* --- GHIDRA: GetAsset ---
		undefined4 Core_Extensions_Dict_DictExt__GetAsset(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5acf5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__);
		    DAT_ram_00a5acf5 = '\x01';
		  }
		  if (0 < *(int *)(param1 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__get_Item__
		                        );
		      if (param2 == *(int *)(iVar1 + 0xc)) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E26")]
		[Address(RVA = "0xAA89", Offset = "0xAA89", VA = "0xAA89")]
		public static string GetString(this RepeatedField<ContentStringMessage> content, uint id)
		{
		/* --- GHIDRA: GetString ---
		int Core_Extensions_Dict_DictExt__GetString(int param1,uint param2,undefined4 param3)
		
		{
		  int param1_00;
		  int param2_00;
		  int iVar1;
		  uint uVar2;
		  int param2_01;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a5acf6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ArtikulTypeMetaFilterDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ArtikulTypeMetaFilterDic__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ArtikulTypeMetaFilterDic__get_Item__
		              );
		    DAT_ram_00a5acf6 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_ArtikulTypeMetaFilterDic__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic___ctor__);
		  iVar1 = *(int *)(param1 + 0x244);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      param2_00 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (iVar1,param2_01,
		                             Method_Google_Protobuf_Collections_RepeatedField_ArtikulTypeMetaFilterDic__get_Item__
		                            );
		      iVar1 = Method_System_Collections_Generic_List_ArtikulTypeMetaFilterDic__Add__;
		      if ((*(uint *)(param2_00 + 0x10) & param2) != 0) {
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar2 = *(uint *)(param1_00 + 0xc);
		        if (uVar2 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		          *(int *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2_00;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param2_00,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      param2_01 = param2_01 + 1;
		      iVar1 = *(int *)(param1 + 0x244);
		    } while (param2_01 < *(int *)(iVar1 + 0xc));
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E27")]
		[Address(RVA = "0xAA8A", Offset = "0xAA8A", VA = "0xAA8A")]
		public static List<ArtikulTypeMetaFilterDic> GetAllArtikulTypeMetaFilterByType(this Dictionaries dic, ArtikulTypeFilters.Types.FilterType filterType)
		{
		/* --- GHIDRA: GetAllArtikulTypeMetaFilterByType ---
		undefined4
		Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType
		          (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5acf7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CultDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CultDic__get_Item__);
		    DAT_ram_00a5acf7 = '\x01';
		  }
		  if ((param2 != 0) && (iVar2 = *(int *)(*(int *)(param1 + 0x30) + 0xc), 0 < iVar2)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x30),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_CultDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E28")]
		[Address(RVA = "0xAA8B", Offset = "0xAA8B", VA = "0xAA8B")]
		public static CultDic GetCult(this Dictionaries dicts, uint cultId)
		{
		/* --- GHIDRA: GetCult ---
		undefined4 Core_Extensions_Dict_DictExt__GetCult(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5acf8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanCultDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanCultDic__get_Item__);
		    DAT_ram_00a5acf8 = '\x01';
		  }
		  if ((param2 != 0) && (iVar2 = *(int *)(*(int *)(param1 + 0x24) + 0xc), 0 < iVar2)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x24),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ClanCultDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E29")]
		[Address(RVA = "0xAA8C", Offset = "0xAA8C", VA = "0xAA8C")]
		public static ClanCultDic GetClanCult(this Dictionaries dicts, uint cultId)
		{
		/* --- GHIDRA: GetClanCult ---
		undefined4 Core_Extensions_Dict_DictExt__GetClanCult(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5acfb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Item__);
		    DAT_ram_00a5acfb = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0xcc);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0xcc);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E2A")]
		[Address(RVA = "0x1AFC", Offset = "0x1AFC", VA = "0x1AFC")]
		public static ResourcesDic GetResourcesDic(this Dictionaries dicts, Resources id)
		{
		/* --- GHIDRA: GetResourcesDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetResourcesDic(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x10),0xb1,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E2B")]
		[Address(RVA = "0x1BBA", Offset = "0x1BBA", VA = "0x1BBA")]
		public static UserSkillDic GetUserSkillDic(this Dictionaries dicts, int id)
		{
		/* --- GHIDRA: GetUserSkillDic ---
		void Core_Extensions_Dict_DictExt__GetUserSkillDic
		               (int param1,undefined4 param2,longlong param3,longlong param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  longlong local_8;
		  
		  local_8 = param3;
		  if (DAT_ram_00a57bd3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a57bd3 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = Core_Extensions_Dict_UserSkillDicExt__GetTitle(param2,0);
		  AssetContent_GameImage__get_AssetId(uVar3,uVar1,0);
		  uVar1 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar3 = UI_SimpleIconValue__set_IconAssetId((double)param3,StringLiteral_28780,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,uVar3,0);
		  uVar3 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = UI_SimpleIconValue__set_IconAssetId((double)param4,StringLiteral_28780,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar3,uVar1,0);
		  iVar2 = System_Int64__CompareTo(&local_8,param4,0);
		  if (iVar2 < 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x28);
		    uVar1 = *(undefined4 *)(param1 + 0x2c);
		  }
		  else if (iVar2 == 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x30);
		    uVar1 = uVar3;
		  }
		  else {
		    uVar3 = *(undefined4 *)(param1 + 0x2c);
		    uVar1 = *(undefined4 *)(param1 + 0x28);
		  }
		  func_ii_7050(*(undefined4 *)(param1 + 0x14),uVar3,0);
		  func_ii_7050(*(undefined4 *)(param1 + 0x18),uVar1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E2C")]
		[Address(RVA = "0xAA8D", Offset = "0xAA8D", VA = "0xAA8D")]
		public static IsleInfoDic GetIsleInfoDicByIsleId(this Dictionaries dictionaries, uint isleId)
		{
		/* --- GHIDRA: GetIsleInfoDicByIsleId ---
		undefined4
		Core_Extensions_Dict_DictExt__GetIsleInfoDicByIsleId(int param1,longlong param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5acfc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Item__);
		    DAT_ram_00a5acfc = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0xcc) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0xcc),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_IsleInfoDic__get_Item__);
		      if (*(longlong *)(iVar1 + 0x20) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E2D")]
		[Address(RVA = "0xAA8E", Offset = "0xAA8E", VA = "0xAA8E")]
		public static IsleInfoDic GetIsleInfoDicByUserId(this Dictionaries dictionaries, ulong userId)
		{
		/* --- GHIDRA: GetIsleInfoDicByUserId ---
		undefined4
		Core_Extensions_Dict_DictExt__GetIsleInfoDicByUserId(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5acfd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserBuildingTypeDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserBuildingTypeDic__get_Item__);
		    DAT_ram_00a5acfd = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_UserBuildingTypeDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x10);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E2E")]
		[Address(RVA = "0xAA8F", Offset = "0xAA8F", VA = "0xAA8F")]
		public static UserBuildingTypeDic GetUserBuildingTypeDic(this Dictionaries dictionaries, UserBuildingTypes buildingType)
		{
		/* --- GHIDRA: GetUserBuildingTypeDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetUserBuildingTypeDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5acfe == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_UserBuildingViewsDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserBuildingViewsDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__GetUserBuildingViewsDic_b__25_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5acfe = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0x17c);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[8];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_UserBuildingViewsDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar1,
		               Method_Core_Extensions_Dict_DictExt___c__GetUserBuildingViewsDic_b__25_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x20) = param1_00;
		  }
		  uVar1 = func_ii_8597(&local_4,param1_00,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_UserBuildingViewsDic__uint___
		                      );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E2F")]
		[Address(RVA = "0xAA90", Offset = "0xAA90", VA = "0xAA90")]
		public static UserBuildingViewsDic GetUserBuildingViewsDic(this Dictionaries dict, uint buildingViewId)
		{
		/* --- GHIDRA: GetUserBuildingViewsDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetUserBuildingViewsDic
		          (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5acff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserBuildingLevelDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserBuildingLevelDic__get_Item__);
		    DAT_ram_00a5acff = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x14);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_UserBuildingLevelDic__get_Item__
		                        );
		      if ((param2 == *(int *)(iVar1 + 0xc)) && (*(int *)(iVar1 + 0x10) == param3)) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x14);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E30")]
		[Address(RVA = "0xAA91", Offset = "0xAA91", VA = "0xAA91")]
		public static UserBuildingLevelDic GetUserBuildingLevelDic(this Dictionaries dictionaries, UserBuildingTypes buildingType, uint level)
		{
		/* --- GHIDRA: GetUserBuildingLevelDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 local_4;
		  
		  iVar1 = 0;
		  local_4 = 0;
		  if (DAT_ram_00a5ad03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Item__);
		    DAT_ram_00a5ad03 = '\x01';
		  }
		  if ((param1 != 0) && (iVar3 = *(int *)(param1 + 0x9c), 0 < *(int *)(iVar3 + 0xc))) {
		    do {
		      iVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar3,iVar1,
		                         Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Item__
		                        );
		      iVar2 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar3 + 0xc),param2,0);
		      if (iVar2 != 0) {
		        iVar1 = *(int *)(iVar3 + 0x10);
		        goto code_r0x812d6014;
		      }
		      iVar1 = iVar1 + 1;
		      iVar3 = *(int *)(param1 + 0x9c);
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		    iVar1 = 0;
		  }
		code_r0x812d6014:
		  iVar1 = System_Net_WebHeaderCollection__Add(iVar1,&local_4,0);
		  if (iVar1 == 0) {
		    local_4 = 0;
		  }
		  return local_4;
		}
		*/

			return null;
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		[Token(Token = "0x6005E31")]
		[Address(RVA = "0xAA92", Offset = "0xAA92", VA = "0xAA92")]
		public static int GetIntParameter(this Dictionaries dict, string paramName)
		{
		/* --- GHIDRA: GetIntParameter ---
		double Core_Extensions_Dict_DictExt__GetIntParameter(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  int iVar2;
		  undefined4 param1_00;
		  int iVar3;
		  float8 local_8;
		  
		  if (DAT_ram_00a5ad00 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    DAT_ram_00a5ad00 = '\x01';
		  }
		  local_8 = 0.0;
		  if (DAT_ram_00a5ad03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Item__);
		    DAT_ram_00a5ad03 = '\x01';
		  }
		  if (param1 == 0) {
		    param1_00 = 0;
		  }
		  else {
		    iVar2 = 0;
		    iVar3 = *(int *)(param1 + 0x9c);
		    if (*(int *)(iVar3 + 0xc) < 1) {
		      param1_00 = 0;
		    }
		    else {
		      do {
		        iVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (iVar3,iVar2,
		                           Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Item__
		                          );
		        iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar3 + 0xc),param2,0);
		        if (iVar1 != 0) {
		          param1_00 = *(undefined4 *)(iVar3 + 0x10);
		          goto code_r0x812ce0ca;
		        }
		        iVar2 = iVar2 + 1;
		        iVar3 = *(int *)(param1 + 0x9c);
		      } while (iVar2 < *(int *)(iVar3 + 0xc));
		      param1_00 = 0;
		    }
		  }
		code_r0x812ce0ca:
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		  }
		  param3_00 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		  iVar2 = func_ii_6596(param1_00,0x1ff,param3_00,&local_8,0);
		  if (iVar2 == 0) {
		    local_8 = 0.0;
		  }
		  return (double)local_8;
		}
		*/

			return 0;
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x00010E00 File Offset: 0x0000F000
		[Token(Token = "0x6005E32")]
		[Address(RVA = "0xAA93", Offset = "0xAA93", VA = "0xAA93")]
		public static double GetDoubleParameter(this Dictionaries dict, string paramName)
		{
		/* --- GHIDRA: GetDoubleParameter ---
		undefined8
		Core_Extensions_Dict_DictExt__GetDoubleParameter(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  int iVar2;
		  undefined4 param1_00;
		  int iVar3;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5ad01 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    DAT_ram_00a5ad01 = '\x01';
		  }
		  local_8 = 0;
		  if (DAT_ram_00a5ad03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Item__);
		    DAT_ram_00a5ad03 = '\x01';
		  }
		  if (param1 == 0) {
		    param1_00 = 0;
		  }
		  else {
		    iVar2 = 0;
		    iVar3 = *(int *)(param1 + 0x9c);
		    if (*(int *)(iVar3 + 0xc) < 1) {
		      param1_00 = 0;
		    }
		    else {
		      do {
		        iVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (iVar3,iVar2,
		                           Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Item__
		                          );
		        iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar3 + 0xc),param2,0);
		        if (iVar1 != 0) {
		          param1_00 = *(undefined4 *)(iVar3 + 0x10);
		          goto code_r0x812d6181;
		        }
		        iVar2 = iVar2 + 1;
		        iVar3 = *(int *)(param1 + 0x9c);
		      } while (iVar2 < *(int *)(iVar3 + 0xc));
		      param1_00 = 0;
		    }
		  }
		code_r0x812d6181:
		  if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		  }
		  param3_00 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		  iVar2 = func_ii_6588(param1_00,0x1ff,param3_00,&local_8,0);
		  if (iVar2 == 0) {
		    local_8 = 0;
		  }
		  return local_8;
		}
		*/

			return 0.0;
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x00010E18 File Offset: 0x0000F018
		[Token(Token = "0x6005E33")]
		[Address(RVA = "0xAA94", Offset = "0xAA94", VA = "0xAA94")]
		public static long GetLongParameter(this Dictionaries dict, string paramName)
		{
		/* --- GHIDRA: GetLongParameter ---
		uint Core_Extensions_Dict_DictExt__GetLongParameter(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  uint uVar2;
		  int iVar3;
		  byte local_1;
		  
		  param2_00 = 0;
		  local_1 = 0;
		  if (DAT_ram_00a5ad03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Item__);
		    DAT_ram_00a5ad03 = '\x01';
		  }
		  if ((param1 != 0) && (iVar3 = *(int *)(param1 + 0x9c), 0 < *(int *)(iVar3 + 0xc))) {
		    do {
		      iVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar3,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Item__
		                        );
		      iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar3 + 0xc),param2,0);
		      if (iVar1 != 0) {
		        param2_00 = *(int *)(iVar3 + 0x10);
		        goto code_r0x812d6264;
		      }
		      param2_00 = param2_00 + 1;
		      iVar3 = *(int *)(param1 + 0x9c);
		    } while (param2_00 < *(int *)(iVar3 + 0xc));
		    param2_00 = 0;
		  }
		code_r0x812d6264:
		  if (*(int *)(DAT_ram_00a66944 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a66944);
		  }
		  uVar2 = Unity_Services_LevelPlay_LevelPlayAdInfo__GetAdSize(param2_00,&local_1,0);
		  return uVar2 & local_1 != 0;
		}
		*/

			return 0L;
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x00010E30 File Offset: 0x0000F030
		[Token(Token = "0x6005E34")]
		[Address(RVA = "0xAA95", Offset = "0xAA95", VA = "0xAA95")]
		public static bool GetBoolParameter(this Dictionaries dict, string paramName)
		{
		/* --- GHIDRA: GetBoolParameter ---
		undefined4
		Core_Extensions_Dict_DictExt__GetBoolParameter(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  float8 local_8;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5ad02 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a5ad02 = '\x01';
		  }
		  local_8 = 0.0;
		  if (DAT_ram_00a5ad03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Item__);
		    DAT_ram_00a5ad03 = '\x01';
		  }
		  if ((param1 != 0) && (iVar4 = *(int *)(param1 + 0x9c), 0 < *(int *)(iVar4 + 0xc))) {
		    do {
		      iVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar4,iVar5,
		                         Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Item__
		                        );
		      iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar4 + 0xc),param2,0);
		      if (iVar1 != 0) {
		        iVar5 = *(int *)(iVar4 + 0x10);
		        if (iVar5 != 0) {
		          iVar4 = 0;
		          uVar2 = System_Data_DataSet__ReadXmlSchema(iVar5,1,*(int *)(iVar5 + 8) + -2,0);
		          iVar5 = System_Net_WebConnection__ReadLine(uVar2,0x2c,0,0);
		          uVar2 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		          if (0 < *(int *)(iVar5 + 0xc)) {
		            do {
		              uVar3 = *(undefined4 *)(iVar5 + iVar4 * 4 + 0x10);
		              if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		                func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		              }
		              iVar4 = iVar4 + 1;
		              param3_00 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		              iVar1 = func_ii_6596(uVar3,0x1ff,param3_00,&local_8,0);
		              if (iVar1 != 0) {
		                Core_Extensions_Dict_ResourceSetExt__HasNewCurrency(uVar2,iVar4,(double)local_8,0);
		              }
		            } while (iVar4 < *(int *)(iVar5 + 0xc));
		          }
		          return uVar2;
		        }
		        break;
		      }
		      iVar5 = iVar5 + 1;
		      iVar4 = *(int *)(param1 + 0x9c);
		    } while (iVar5 < *(int *)(iVar4 + 0xc));
		  }
		  uVar2 = unnamed_function_2232(&StringLiteral_6531);
		  uVar3 = unnamed_function_2232(&StringLiteral_436);
		  uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__(uVar2,param2,uVar3,0);
		  uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar3 = unnamed_function_1417(uVar3);
		  System_String__Concat(uVar3,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Core_Extensions_Dict_DictExt_GetResourceSetParameter__);
		  func_ii_1050(uVar3,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E35")]
		public static T[] GetArrayParameter<T>(this Dictionaries dict, string paramName)
		{
		/* --- GHIDRA: GetArrayParameter<__Il2CppFullySharedGenericType> ---
		undefined4
		Core_Extensions_Dict_DictExt__GetArrayParameter___Il2CppFullySharedGenericType_
		          (int param1,int param2)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  if (*(int *)(param2 + 0x1c) == 0) {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_string___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28547);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28773);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1238);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28745);
		    if (*(int *)(param2 + 0x1c) == 0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param2);
		    }
		  }
		  if (param1 == 0) {
		    return StringLiteral_28745;
		  }
		  iVar3 = *(int *)(*(int *)(param2 + 0x1c) + 0xc);
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  if (*(int *)(iVar3 + 0x74) == 0) {
		    func_ii_306000(iVar3);
		  }
		  iVar3 = *(int *)(*(int *)(param2 + 0x1c) + 0xc);
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  param1_00 = StringLiteral_28547;
		  uVar2 = StringLiteral_1238;
		  iVar3 = *(int *)(*(int *)(iVar3 + 0x5c) + 4);
		  if (iVar3 == 0) {
		    iVar3 = *(int *)(*(int *)(param2 + 0x1c) + 0xc);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    if (*(int *)(iVar3 + 0x74) == 0) {
		      func_ii_306000(iVar3);
		    }
		    iVar4 = *(int *)(param2 + 0x1c);
		    iVar3 = *(int *)(iVar4 + 0xc);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		      iVar4 = *(int *)(param2 + 0x1c);
		    }
		    uVar1 = **(undefined4 **)(iVar3 + 0x5c);
		    iVar3 = *(int *)(iVar4 + 8);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    iVar3 = unnamed_function_1417(iVar3);
		    func_ii_7795(iVar3,uVar1,*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x10),
		                 *(undefined4 *)(*(int *)(param2 + 0x1c) + 0x14));
		    iVar4 = *(int *)(*(int *)(param2 + 0x1c) + 0xc);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      iVar4 = func_ii_1079(iVar4);
		    }
		    *(int *)(*(int *)(iVar4 + 0x5c) + 4) = iVar3;
		    iVar4 = *(int *)(*(int *)(param2 + 0x1c) + 0xc);
		    if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		      func_ii_1079(iVar4);
		    }
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1,iVar3,*(undefined4 *)(*(int *)(param2 + 0x1c) + 0x18));
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_string___);
		  uVar2 = UnityEngine_Assertions_Assert__IsFalse(uVar2,uVar1,0);
		  uVar2 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (param1_00,uVar2,StringLiteral_28773,0);
		  return uVar2;
		}
		*/

		/* --- GHIDRA: GetArrayParameter<int> ---
		undefined4
		Core_Extensions_Dict_DictExt__GetArrayParameter_int_(undefined4 param1,undefined4 param2,int param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (*(int *)(param3 + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		  }
		  uVar1 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(param1,param2,0);
		  iVar3 = **(int **)(param3 + 0x1c);
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  piVar2 = (int *)unnamed_function_1417(iVar3);
		  puVar4 = *(uint **)(*(int *)(param3 + 0x1c) + 4);
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar2,puVar4);
		  iVar3 = *(int *)(*piVar2 + 0xe4);
		  local_8 = uVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 8) * 4))
		            (*(undefined4 *)(iVar3 + 4),iVar3,piVar2,&local_8,&local_4);
		  return local_4;
		}
		*/

			return null;
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E36")]
		[Address(RVA = "0xAA96", Offset = "0xAA96", VA = "0xAA96")]
		public static ResourceSet GetResourceSetParameter(this Dictionaries dict, string paramName)
		{
		/* --- GHIDRA: GetResourceSetParameter ---
		undefined4
		Core_Extensions_Dict_DictExt__GetResourceSetParameter
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Item__);
		    DAT_ram_00a5ad03 = '\x01';
		  }
		  if ((param1 != 0) && (iVar2 = *(int *)(param1 + 0x9c), 0 < *(int *)(iVar2 + 0xc))) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar2,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ServerParameter__get_Item__
		                        );
		      iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar2 + 0xc),param2,0);
		      if (iVar1 != 0) {
		        return *(undefined4 *)(iVar2 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		      iVar2 = *(int *)(param1 + 0x9c);
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E37")]
		[Address(RVA = "0xAA97", Offset = "0xAA97", VA = "0xAA97")]
		public static string GetStringParameter(this Dictionaries dict, string paramName)
		{
		/* --- GHIDRA: GetStringParameter ---
		undefined4
		Core_Extensions_Dict_DictExt__GetStringParameter(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5ad04 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_RequirementDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_RequirementDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__GetRequirementDic_b__34_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad04 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xa8);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[9];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_RequirementDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar1,Method_Core_Extensions_Dict_DictExt___c__GetRequirementDic_b__34_0__,
		               0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x24) = param1_00;
		  }
		  uVar1 = func_ii_8597(&local_4,param1_00,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_RequirementDic__uint___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E38")]
		[Address(RVA = "0xAA98", Offset = "0xAA98", VA = "0xAA98")]
		public static RequirementDic GetRequirementDic(this Dictionaries dict, uint requirementId)
		{
		/* --- GHIDRA: GetRequirementDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetRequirementDic(int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  if (DAT_ram_00a5ad05 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserMenuActionDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserMenuActionDic__get_Item__);
		    DAT_ram_00a5ad05 = '\x01';
		  }
		  if ((param1 != 0) && (iVar1 = *(int *)(param1 + 0x284), 0 < *(int *)(iVar1 + 0xc))) {
		    param2_00 = 0;
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_UserMenuActionDic__get_Item__
		                        );
		      if (*(ulonglong *)(iVar1 + 0x10) == (ulonglong)param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x284);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E39")]
		[Address(RVA = "0xAA99", Offset = "0xAA99", VA = "0xAA99")]
		public static UserMenuActionDic GetUserMenuActionDic(this Dictionaries dict, uint actionId)
		{
		/* --- GHIDRA: GetUserMenuActionDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetUserMenuActionDic(int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  if (DAT_ram_00a5ad06 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtikulMenuActionDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtikulMenuActionDic__get_Item__);
		    DAT_ram_00a5ad06 = '\x01';
		  }
		  if ((param1 != 0) && (iVar1 = *(int *)(param1 + 0x24c), 0 < *(int *)(iVar1 + 0xc))) {
		    param2_00 = 0;
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ArtikulMenuActionDic__get_Item__
		                        );
		      if (*(ulonglong *)(iVar1 + 0x10) == (ulonglong)param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x24c);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E3A")]
		[Address(RVA = "0xAA9A", Offset = "0xAA9A", VA = "0xAA9A")]
		public static ArtikulMenuActionDic GetArtikulMenuActionDic(this Dictionaries dict, uint actionId)
		{
		/* --- GHIDRA: GetArtikulMenuActionDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetArtikulMenuActionDic
		          (int param1,uint param2,uint param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  if (DAT_ram_00a5ad07 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ArtikulTypeMenuActionDic__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ArtikulTypeMenuActionDic__get_Item__
		              );
		    DAT_ram_00a5ad07 = '\x01';
		  }
		  if ((param1 != 0) && (iVar1 = *(int *)(param1 + 0x250), 0 < *(int *)(iVar1 + 0xc))) {
		    param2_00 = 0;
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ArtikulTypeMenuActionDic__get_Item__
		                        );
		      if (((ulonglong)param2 == *(ulonglong *)(iVar1 + 0x18)) &&
		         (*(ulonglong *)(iVar1 + 0x10) == (ulonglong)param3)) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x250);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E3B")]
		[Address(RVA = "0xAA9B", Offset = "0xAA9B", VA = "0xAA9B")]
		public static ArtikulTypeMenuActionDic GetArtikulTypeMenuActionDic(this Dictionaries dict, uint actionId, uint artikulTypeId)
		{
		/* --- GHIDRA: GetArtikulTypeMenuActionDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetArtikulTypeMenuActionDic(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int param2_00;
		  
		  if (DAT_ram_00a5ad08 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_ExperienceDic___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ExperienceDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ExperienceDic__get_Item__);
		    DAT_ram_00a5ad08 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x254);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    param2_00 = 0;
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar2,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ExperienceDic__get_Item__)
		      ;
		      if ((longlong)param2 == *(longlong *)(iVar2 + 0x10)) {
		        uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0x254),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_ExperienceDic__get_Item__
		                          );
		        return uVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar2 = *(int *)(param1 + 0x254);
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		  }
		  uVar1 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                    (iVar2,Method_System_Linq_Enumerable_Last_ExperienceDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E3C")]
		[Address(RVA = "0xAA9C", Offset = "0xAA9C", VA = "0xAA9C")]
		public static ExperienceDic GetExperienceDic(this Dictionaries dict, ExperienceDic.Types.ExperienceTypes expId)
		{
		/* --- GHIDRA: GetExperienceDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetExperienceDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad09 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserRatingKindDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserRatingKindDic__get_Item__);
		    DAT_ram_00a5ad09 = '\x01';
		  }
		  if ((param2 != 0) && (iVar2 = *(int *)(param1 + 0x260), 0 < *(int *)(iVar2 + 0xc))) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar2,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_UserRatingKindDic__get_Item__
		                        );
		      if (param2 == *(int *)(iVar2 + 0xc)) {
		        uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0x260),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_UserRatingKindDic__get_Item__
		                          );
		        return uVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar2 = *(int *)(param1 + 0x260);
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E3D")]
		[Address(RVA = "0xAA9D", Offset = "0xAA9D", VA = "0xAA9D")]
		public static UserRatingKindDic GetUserRatingKindDic(this Dictionaries dict, uint kindId)
		{
		/* --- GHIDRA: GetUserRatingKindDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetUserRatingKindDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad0a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanRatingKindDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanRatingKindDic__get_Item__);
		    DAT_ram_00a5ad0a = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x264);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar2,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ClanRatingKindDic__get_Item__
		                        );
		      if (param2 == *(int *)(iVar2 + 0xc)) {
		        uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0x264),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_ClanRatingKindDic__get_Item__
		                          );
		        return uVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar2 = *(int *)(param1 + 0x264);
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E3E")]
		[Address(RVA = "0xAA9E", Offset = "0xAA9E", VA = "0xAA9E")]
		public static ClanRatingKindDic GetClanRatingKindDic(this Dictionaries dict, uint kindId)
		{
		/* --- GHIDRA: GetClanRatingKindDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetClanRatingKindDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad0b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CultRatingKindDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CultRatingKindDic__get_Item__);
		    DAT_ram_00a5ad0b = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x268);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar2,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_CultRatingKindDic__get_Item__
		                        );
		      if (param2 == *(int *)(iVar2 + 0xc)) {
		        uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0x268),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_CultRatingKindDic__get_Item__
		                          );
		        return uVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar2 = *(int *)(param1 + 0x268);
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E3F")]
		[Address(RVA = "0xAA9F", Offset = "0xAA9F", VA = "0xAA9F")]
		public static CultRatingKindDic GetCultRatingKindDic(this Dictionaries dict, uint kindId)
		{
		/* --- GHIDRA: GetCultRatingKindDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetCultRatingKindDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad0c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RatingKindTypeDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RatingKindTypeDic__get_Item__);
		    DAT_ram_00a5ad0c = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x25c);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar2,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_RatingKindTypeDic__get_Item__
		                        );
		      if (param2 == *(int *)(iVar2 + 0xc)) {
		        uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0x25c),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_RatingKindTypeDic__get_Item__
		                          );
		        return uVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar2 = *(int *)(param1 + 0x25c);
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E40")]
		[Address(RVA = "0xAAA0", Offset = "0xAAA0", VA = "0xAAA0")]
		public static RatingKindTypeDic GetRatingKindDic(this Dictionaries dict, RatingKindTypeDic.Types.RatingKindType kindTypeId)
		{
		/* --- GHIDRA: GetRatingKindDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetRatingKindDic(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad0d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardDic__get_Item__);
		    DAT_ram_00a5ad0d = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x26c);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_RewardDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x26c);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E41 RID: 24129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E41")]
		[Address(RVA = "0xAAA1", Offset = "0xAAA1", VA = "0xAAA1")]
		public static RewardDic GetRewardDic(this Dictionaries dict, RewardTypes rewardType)
		{
		/* --- GHIDRA: GetRewardDic ---
		uint Core_Extensions_Dict_DictExt__GetRewardDic
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5ad0f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_ArtikulDismantleInfoDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulDismantleInfoDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__TryGetArtikulDismantleInfoDic_b__45_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad0f = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xb8);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar2 = puVar1[10];
		  if (iVar2 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    iVar2 = unnamed_function_1417(System_Func_ArtikulDismantleInfoDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,param2_00,
		               Method_Core_Extensions_Dict_DictExt___c__TryGetArtikulDismantleInfoDic_b__45_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x28) = iVar2;
		  }
		  iVar2 = func_ii_8597(&local_4,iVar2,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_ArtikulDismantleInfoDic__uint___
		                      );
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

		/* --- GHIDRA: GetRewardDic ---
		uint Core_Extensions_Dict_DictExt__GetRewardDic
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5ad0f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_ArtikulDismantleInfoDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulDismantleInfoDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__TryGetArtikulDismantleInfoDic_b__45_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad0f = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xb8);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar2 = puVar1[10];
		  if (iVar2 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    iVar2 = unnamed_function_1417(System_Func_ArtikulDismantleInfoDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,param2_00,
		               Method_Core_Extensions_Dict_DictExt___c__TryGetArtikulDismantleInfoDic_b__45_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x28) = iVar2;
		  }
		  iVar2 = func_ii_8597(&local_4,iVar2,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_ArtikulDismantleInfoDic__uint___
		                      );
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

			return null;
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E42")]
		[Address(RVA = "0xAAA2", Offset = "0xAAA2", VA = "0xAAA2")]
		public static RewardDic GetRewardDic(this Dictionaries dict, uint rewardId)
		{
			return null;
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x00010E48 File Offset: 0x0000F048
		[Token(Token = "0x6005E43")]
		[Address(RVA = "0xAAA3", Offset = "0xAAA3", VA = "0xAAA3")]
		public static bool TryGetArtikulDismantleInfoDic(this Dictionaries dict, uint artikulId, out ArtikulDismantleInfoDic result)
		{
		/* --- GHIDRA: TryGetArtikulDismantleInfoDic ---
		undefined4
		Core_Extensions_Dict_DictExt__TryGetArtikulDismantleInfoDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad14 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalRanks__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalRanks__get_Item__);
		    DAT_ram_00a5ad14 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x130) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x130),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_MedalRanks__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E44")]
		[Address(RVA = "0x2243", Offset = "0x2243", VA = "0x2243")]
		public static TriggerDic GetTriggerDic(this Dictionaries dict, uint triggerId)
		{
			return null;
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E45")]
		[Address(RVA = "0x445E", Offset = "0x445E", VA = "0x445E")]
		public static MedalDic GetMedalDic(this Dictionaries dict, uint medalId)
		{
			return null;
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E46")]
		[Address(RVA = "0x1BF0", Offset = "0x1BF0", VA = "0x1BF0")]
		public static MedalCategoryDic GetMedalCategory(this Dictionaries dict, uint categoryId)
		{
		/* --- GHIDRA: GetMedalCategory ---
		undefined4 Core_Extensions_Dict_DictExt__GetMedalCategory(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad13 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalTypeDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalTypeDic__get_Item__);
		    DAT_ram_00a5ad13 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x108) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x108),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_MedalTypeDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E47")]
		[Address(RVA = "0x1BF1", Offset = "0x1BF1", VA = "0x1BF1")]
		public static MedalTypeDic GetMedalType(this Dictionaries dict, uint typeId)
		{
		/* --- GHIDRA: GetMedalType ---
		void Core_Extensions_Dict_DictExt__GetMedalType(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57da2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDicWrapper___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_SortedList_uint__MedalDicWrapper__TypeInfo);
		    DAT_ram_00a57da2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_SortedList_uint__MedalDicWrapper__TypeInfo);
		  System_Collections_Generic_SortedList_object__object___set_Capacity
		            (uVar1,Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper___ctor__);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__MedalDicWrapper__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,Method_System_Collections_Generic_Dictionary_uint__MedalDicWrapper___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E48")]
		[Address(RVA = "0xAAA4", Offset = "0xAAA4", VA = "0xAAA4")]
		public static MedalRanks GetMedalRank(this Dictionaries dict, uint rankId)
		{
		/* --- GHIDRA: GetMedalRank ---
		undefined4 Core_Extensions_Dict_DictExt__GetMedalRank(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad15 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TreeLevelDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TreeLevelDic__get_Item__);
		    DAT_ram_00a5ad15 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x278) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x278),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_TreeLevelDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E49")]
		[Address(RVA = "0xAAA5", Offset = "0xAAA5", VA = "0xAAA5")]
		public static TreeLevelDic GetTreeLevelDic(this Dictionaries dict, uint level)
		{
		/* --- GHIDRA: GetTreeLevelDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetTreeLevelDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad16 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArenaLevelDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArenaLevelDic__get_Item__);
		    DAT_ram_00a5ad16 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x104) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x104),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ArenaLevelDic__get_Item__)
		      ;
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E4A")]
		[Address(RVA = "0xAAA6", Offset = "0xAAA6", VA = "0xAAA6")]
		public static ArenaLevelDic GetArenaLevelDic(this Dictionaries dict, uint level)
		{
		/* --- GHIDRA: GetArenaLevelDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetArenaLevelDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad17 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ShopLevelDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ShopLevelDic__get_Item__);
		    DAT_ram_00a5ad17 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x138) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x138),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ShopLevelDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E4B")]
		[Address(RVA = "0xAAA7", Offset = "0xAAA7", VA = "0xAAA7")]
		public static ShopLevelDic GetShopLevelDic(this Dictionaries dict, uint level)
		{
		/* --- GHIDRA: GetShopLevelDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetShopLevelDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad18 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CaveLevelDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CaveLevelDic__get_Item__);
		    DAT_ram_00a5ad18 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x100) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x100),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_CaveLevelDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E4C")]
		[Address(RVA = "0xAAA8", Offset = "0xAAA8", VA = "0xAAA8")]
		public static CaveLevelDic GetCaveLevel(this Dictionaries dict, uint level)
		{
		/* --- GHIDRA: GetCaveLevel ---
		undefined4 Core_Extensions_Dict_DictExt__GetCaveLevel(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad19 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserLevelDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserLevelDic__get_Item__);
		    DAT_ram_00a5ad19 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x60) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x60),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_UserLevelDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E4D")]
		[Address(RVA = "0xAAA9", Offset = "0xAAA9", VA = "0xAAA9")]
		public static UserLevelDic GetUserLevelDic(this Dictionaries dict, uint level)
		{
		/* --- GHIDRA: GetUserLevelDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetUserLevelDic(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int param2_00;
		  
		  if (DAT_ram_00a5ad1a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SlotArtikulTypesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SlotArtikulTypesDic__get_Item__);
		    DAT_ram_00a5ad1a = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x194) + 0xc);
		  if (0 < iVar2) {
		    param2_00 = 0;
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x194),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_SlotArtikulTypesDic__get_Item__
		                        );
		      if ((ulonglong)*(uint *)(iVar1 + 0xc) == (longlong)param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E4E")]
		[Address(RVA = "0xAAAA", Offset = "0xAAAA", VA = "0xAAAA")]
		public static SlotArtikulTypesDic GetArtikulTypesBySlotId(this Dictionaries dict, int slotId)
		{
		/* --- GHIDRA: GetArtikulTypesBySlotId ---
		undefined4
		Core_Extensions_Dict_DictExt__GetArtikulTypesBySlotId(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad1b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_GenderDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_GenderDic__get_Item__);
		    DAT_ram_00a5ad1b = '\x01';
		  }
		  if ((param2 != 0) && (iVar3 = *(int *)(*(int *)(param1 + 0x27c) + 0xc), 0 < iVar3)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x27c),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_GenderDic__get_Item__);
		      if (param2 == *(int *)(iVar1 + 0xc)) {
		        uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0x27c),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_GenderDic__get_Item__);
		        return uVar2;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E4F")]
		[Address(RVA = "0xAAAB", Offset = "0xAAAB", VA = "0xAAAB")]
		public static GenderDic GetGenderDic(this Dictionaries dict, uint gender)
		{
		/* --- GHIDRA: GetGenderDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetGenderDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad1c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServiceOptionsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ServiceOptionsDic__get_Item__);
		    DAT_ram_00a5ad1c = '\x01';
		  }
		  if ((param2 != 0) && (iVar3 = *(int *)(*(int *)(param1 + 100) + 0xc), 0 < iVar3)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 100),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ServiceOptionsDic__get_Item__
		                        );
		      if (param2 == *(int *)(iVar1 + 0x10)) {
		        uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 100),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_ServiceOptionsDic__get_Item__
		                          );
		        return uVar2;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E50")]
		[Address(RVA = "0xAAAC", Offset = "0xAAAC", VA = "0xAAAC")]
		public static ServiceOptionsDic GetServiceOptionDic(this Dictionaries dict, ServiceOptionsDic.Types.ServiceTypes serviceId)
		{
		/* --- GHIDRA: GetServiceOptionDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetServiceOptionDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad1d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UIResourceDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UIResourceDic__get_Item__);
		    DAT_ram_00a5ad1d = '\x01';
		  }
		  if (((param1 != 0) && (iVar1 = func_ii_4769(param2,0), iVar1 == 0)) &&
		     (iVar1 = *(int *)(*(int *)(param1 + 0x274) + 0xc), 0 < iVar1)) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x274),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_UIResourceDic__get_Item__)
		      ;
		      iVar3 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar2 + 0xc),param2,0);
		      if (iVar3 != 0) {
		        return *(undefined4 *)(iVar2 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E51")]
		[Address(RVA = "0xAAAD", Offset = "0xAAAD", VA = "0xAAAD")]
		public static string GetUIResourceAssetId(this Dictionaries dict, string key)
		{
		/* --- GHIDRA: GetUIResourceAssetId ---
		undefined4 Core_Extensions_Dict_DictExt__GetUIResourceAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5ad1e == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_BattleAccountCoefs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_BattleAccountCoefs___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BattleAccountCoefs__get_Count__);
		    DAT_ram_00a5ad1e = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0x13c) + 0xc) < 1) {
		    uVar1 = unnamed_function_1417(Protocol_Dic_BattleAccountCoefs_TypeInfo);
		    return uVar1;
		  }
		  uVar1 = System_Linq_Enumerable__Count_object_
		                    (*(int *)(param1 + 0x13c),
		                     Method_System_Linq_Enumerable_First_BattleAccountCoefs___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E52 RID: 24146 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E52")]
		[Address(RVA = "0xAAAE", Offset = "0xAAAE", VA = "0xAAAE")]
		public static BattleAccountCoefs GetBattleAccountCoeffsDic(this Dictionaries dict)
		{
		/* --- GHIDRA: GetBattleAccountCoeffsDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetBattleAccountCoeffsDic
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5ad1f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_MonsterDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_MonsterDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_Dict_DictExt___c__GetMonsterDic_b__61_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad1f = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0x38);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[0xd];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_MonsterDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar1,Method_Core_Extensions_Dict_DictExt___c__GetMonsterDic_b__61_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x34) = param1_00;
		  }
		  uVar1 = func_ii_8597(&local_4,param1_00,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_MonsterDic__uint___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E53")]
		[Address(RVA = "0xAAAF", Offset = "0xAAAF", VA = "0xAAAF")]
		public static MonsterDic GetMonsterDic(this Dictionaries dict, uint monsterId)
		{
		/* --- GHIDRA: GetMonsterDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetMonsterDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad21 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EventCategoriesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EventCategoriesDic__get_Item__);
		    DAT_ram_00a5ad21 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x1b8) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x1b8),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_EventCategoriesDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E54 RID: 24148 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E54")]
		[Address(RVA = "0x1AAE", Offset = "0x1AAE", VA = "0x1AAE")]
		public static EventTypeDic GetEventTypeDic(this Dictionaries dict, uint type)
		{
			return null;
		}

		// Token: 0x06005E55 RID: 24149 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E55")]
		[Address(RVA = "0xAAB0", Offset = "0xAAB0", VA = "0xAAB0")]
		public static EventCategoriesDic GetEventCategoriesDic(this Dictionaries dict, EventCategoriesDic.Types.Category id)
		{
		/* --- GHIDRA: GetEventCategoriesDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetEventCategoriesDic
		          (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad22 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EventTypeActionDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EventTypeActionDic__get_Item__);
		    DAT_ram_00a5ad22 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x270) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x270),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_EventTypeActionDic__get_Item__
		                        );
		      if ((param2 == *(int *)(iVar1 + 0xc)) && (*(int *)(iVar1 + 0x10) == param3)) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E56 RID: 24150 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E56")]
		[Address(RVA = "0xAAB1", Offset = "0xAAB1", VA = "0xAAB1")]
		public static EventTypeActionDic GetEventTypeActionDic(this Dictionaries dict, uint eventId, uint actionId)
		{
		/* --- GHIDRA: GetEventTypeActionDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetEventTypeActionDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad23 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EventActionDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EventActionDic__get_Item__);
		    DAT_ram_00a5ad23 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x7c) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x7c),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_EventActionDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E57 RID: 24151 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E57")]
		[Address(RVA = "0xAAB2", Offset = "0xAAB2", VA = "0xAAB2")]
		public static EventActionDic GetEventActionDic(this Dictionaries dict, uint actionId)
		{
		/* --- GHIDRA: GetEventActionDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetEventActionDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad24 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EventTagDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EventTagDic__get_Item__);
		    DAT_ram_00a5ad24 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x288) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x288),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_EventTagDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E58 RID: 24152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E58")]
		[Address(RVA = "0xAAB3", Offset = "0xAAB3", VA = "0xAAB3")]
		public static EventTagDic GetEventTagDic(this Dictionaries dict, uint tagId)
		{
		/* --- GHIDRA: GetEventTagDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetEventTagDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CollectionRanksInfoDic__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CollectionRanksInfoDic__get_Item__)
		    ;
		    DAT_ram_00a5ad26 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x1a0);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar2,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_CollectionRanksInfoDic__get_Item__
		                        );
		      if (param2 == *(int *)(iVar2 + 0xc)) {
		        uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0x1a0),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_CollectionRanksInfoDic__get_Item__
		                          );
		        return uVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar2 = *(int *)(param1 + 0x1a0);
		    } while (param2_00 < *(int *)(iVar2 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E59 RID: 24153 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E59")]
		[Address(RVA = "0x1AA1", Offset = "0x1AA1", VA = "0x1AA1")]
		public static CollectionsDic GetCollectionsDic(this Dictionaries dict, uint collectionId)
		{
		/* --- GHIDRA: GetCollectionsDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetCollectionsDic(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined4 uVar4;
		  int *param1_01;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57ece == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_CollectionData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_Model_CollectionDicGroup_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic___get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57ece = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param2 + 0xc);
		  param1_01 = *(int **)(param1 + 0x18);
		  iVar5 = *param1_01;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80e79fe3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e79fe3:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar6 = *(undefined4 *)(iVar5 + 0x1a0);
		  uVar3 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 0xc),uVar4,
		                     Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__CollectionRanksDic___get_Item__
		                    );
		  uVar4 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 8),uVar4,
		                     Method_System_Collections_Generic_Dictionary_uint__Dictionary_uint__MedalDic___get_Item__
		                    );
		  param1_00 = unnamed_function_1417(Gameplay_Collections_Model_CollectionDicGroup_TypeInfo);
		  Gameplay_Collections_Model_CollectionDicGroup__get_MaxRank
		            (param1_00,param2,uVar6,uVar3,uVar4,uVar6);
		  uVar3 = *(undefined4 *)(param1 + 0x14);
		  uVar6 = *(undefined4 *)(param1 + 0x10);
		  uVar4 = unnamed_function_1417(Core_Data_CollectionData_TypeInfo);
		  Core_Data_CollectionData__get_TitleToLower(uVar4,param1_00,uVar6,uVar3,0);
		  return uVar4;
		}
		*/

			return null;
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E5A")]
		[Address(RVA = "0xAAB4", Offset = "0xAAB4", VA = "0xAAB4")]
		public static CollectionRanksInfoDic GetCollectionRankInfoDic(this Dictionaries dict, uint rank)
		{
		/* --- GHIDRA: GetCollectionRankInfoDic ---
		uint Core_Extensions_Dict_DictExt__GetCollectionRankInfoDic
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5ad27 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_DailyQuestsDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IListExt_BinarySearch_DailyQuestsDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__TryGetDailyQuestsDic_b__69_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad27 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 400);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar2 = puVar1[0xf];
		  if (iVar2 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    iVar2 = unnamed_function_1417(System_Func_DailyQuestsDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,param2_00,
		               Method_Core_Extensions_Dict_DictExt___c__TryGetDailyQuestsDic_b__69_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x3c) = iVar2;
		  }
		  iVar2 = Unity_Jobs_IJobParallelForExtensions__Run_UITKTextJobSystem_PrepareTextJobData_
		                    (param1_00,iVar2,param2,
		                     Method_Core_Extensions_IListExt_BinarySearch_DailyQuestsDic__uint___);
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

			return null;
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x00010E60 File Offset: 0x0000F060
		[Token(Token = "0x6005E5B")]
		[Address(RVA = "0xAAB5", Offset = "0xAAB5", VA = "0xAAB5")]
		public static bool TryGetDailyQuestsDic(this Dictionaries dict, uint questId, out DailyQuestsDic result)
		{
		/* --- GHIDRA: TryGetDailyQuestsDic ---
		uint Core_Extensions_Dict_DictExt__TryGetDailyQuestsDic
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5ad28 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_DailyGoalDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IListExt_BinarySearch_DailyGoalDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__TryGetDailyGoalDic_b__70_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad28 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x2e0);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar2 = puVar1[0x10];
		  if (iVar2 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    iVar2 = unnamed_function_1417(System_Func_DailyGoalDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,param2_00,Method_Core_Extensions_Dict_DictExt___c__TryGetDailyGoalDic_b__70_0__
		               ,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x40) = iVar2;
		  }
		  iVar2 = Unity_Jobs_IJobParallelForExtensions__Run_UITKTextJobSystem_PrepareTextJobData_
		                    (param1_00,iVar2,param2,
		                     Method_Core_Extensions_IListExt_BinarySearch_DailyGoalDic__uint___);
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x00010E78 File Offset: 0x0000F078
		[Token(Token = "0x6005E5C")]
		[Address(RVA = "0xAAB6", Offset = "0xAAB6", VA = "0xAAB6")]
		public static bool TryGetDailyGoalDic(this Dictionaries dict, uint questId, out DailyGoalDic result)
		{
		/* --- GHIDRA: TryGetDailyGoalDic ---
		undefined4 Core_Extensions_Dict_DictExt__TryGetDailyGoalDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad29 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_DailyQuestCategoriesDic__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_DailyQuestCategoriesDic__get_Item__
		              );
		    DAT_ram_00a5ad29 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x18c) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x18c),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_DailyQuestCategoriesDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E5D")]
		[Address(RVA = "0xAAB7", Offset = "0xAAB7", VA = "0xAAB7")]
		public static DailyQuestCategoriesDic GetDailyQuestCategoriesDic(this Dictionaries dict, uint categoryId)
		{
		/* --- GHIDRA: GetDailyQuestCategoriesDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetDailyQuestCategoriesDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad2b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_OptionTypesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_OptionTypesDic__get_Item__);
		    DAT_ram_00a5ad2b = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x23c) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x23c),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_OptionTypesDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E5E")]
		[Address(RVA = "0x1D49", Offset = "0x1D49", VA = "0x1D49")]
		public static PromotionsDic GetPromotionsDic(this Dictionaries dict, uint id)
		{
			return null;
		}

		// Token: 0x06005E5F RID: 24159 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E5F")]
		[Address(RVA = "0xAAB8", Offset = "0xAAB8", VA = "0xAAB8")]
		public static OptionTypesDic GetOptionTypesDic(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetOptionTypesDic ---
		uint Core_Extensions_Dict_DictExt__GetOptionTypesDic
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5ad2c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_DiamondOptionsDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IListExt_BinarySearch_DiamondOptionsDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__TryGetDiamondOptionsDic_b__74_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad2c = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa4);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar2 = puVar1[0x11];
		  if (iVar2 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    iVar2 = unnamed_function_1417(System_Func_DiamondOptionsDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,param2_00,
		               Method_Core_Extensions_Dict_DictExt___c__TryGetDiamondOptionsDic_b__74_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x44) = iVar2;
		  }
		  iVar2 = Unity_Jobs_IJobParallelForExtensions__Run_UITKTextJobSystem_PrepareTextJobData_
		                    (param1_00,iVar2,param2,
		                     Method_Core_Extensions_IListExt_BinarySearch_DiamondOptionsDic__uint___);
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

			return null;
		}

		// Token: 0x06005E60 RID: 24160 RVA: 0x00010E90 File Offset: 0x0000F090
		[Token(Token = "0x6005E60")]
		[Address(RVA = "0xAAB9", Offset = "0xAAB9", VA = "0xAAB9")]
		public static bool TryGetDiamondOptionsDic(this Dictionaries dict, uint optionId, out DiamondOptionsDic result)
		{
		/* --- GHIDRA: TryGetDiamondOptionsDic ---
		uint Core_Extensions_Dict_DictExt__TryGetDiamondOptionsDic
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  uVar1 = 0;
		  if (DAT_ram_00a5ad2d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_CrystalEnergyOptionsDic__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CrystalEnergyOptionsDic__get_Item__
		              );
		    DAT_ram_00a5ad2d = '\x01';
		  }
		  *param3 = 0;
		  iVar3 = *(int *)(*(int *)(param1 + 0x68) + 0xc);
		  if (0 < iVar3) {
		    iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(param1 + 0x68),0,
		                       Method_Google_Protobuf_Collections_RepeatedField_CrystalEnergyOptionsDic__get_Item__
		                      );
		    *param3 = iVar2;
		    uVar1 = 1;
		    if (*(int *)(*(int *)(*(int *)(iVar2 + 0xc) + 0xc) + 0xc) != param2) {
		      do {
		        param2_00 = param2_00 + 1;
		        if (iVar3 == param2_00) break;
		        iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0x68),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_CrystalEnergyOptionsDic__get_Item__
		                          );
		        *param3 = iVar2;
		      } while (*(int *)(*(int *)(*(int *)(iVar2 + 0xc) + 0xc) + 0xc) != param2);
		      uVar1 = (uint)(param2_00 < iVar3);
		    }
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E61 RID: 24161 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		[Token(Token = "0x6005E61")]
		[Address(RVA = "0xAABA", Offset = "0xAABA", VA = "0xAABA")]
		public static bool TryGetCrystalEnergyOptionsDic(this Dictionaries dict, uint optionId, out CrystalEnergyOptionsDic result)
		{
		/* --- GHIDRA: TryGetCrystalEnergyOptionsDic ---
		uint Core_Extensions_Dict_DictExt__TryGetCrystalEnergyOptionsDic
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5ad2e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_NewResourceOptionsDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IListExt_BinarySearch_NewResourceOptionsDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__TryGetNewResourceOptionsDic_b__76_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad2e = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x1a4);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar2 = puVar1[0x12];
		  if (iVar2 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    iVar2 = unnamed_function_1417(System_Func_NewResourceOptionsDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,param2_00,
		               Method_Core_Extensions_Dict_DictExt___c__TryGetNewResourceOptionsDic_b__76_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x48) = iVar2;
		  }
		  iVar2 = Unity_Jobs_IJobParallelForExtensions__Run_UITKTextJobSystem_PrepareTextJobData_
		                    (param1_00,iVar2,param2,
		                     Method_Core_Extensions_IListExt_BinarySearch_NewResourceOptionsDic__uint___);
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E62 RID: 24162 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		[Token(Token = "0x6005E62")]
		[Address(RVA = "0xAABB", Offset = "0xAABB", VA = "0xAABB")]
		public static bool TryGetNewResourceOptionsDic(this Dictionaries dict, uint optionId, out NewResourceOptionsDic result)
		{
		/* --- GHIDRA: TryGetNewResourceOptionsDic ---
		uint Core_Extensions_Dict_DictExt__TryGetNewResourceOptionsDic
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  uVar1 = 0;
		  if (DAT_ram_00a5ad2f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ColossusFragmentsOptionsDic__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ColossusFragmentsOptionsDic__get_Item__
		              );
		    DAT_ram_00a5ad2f = '\x01';
		  }
		  *param3 = 0;
		  iVar3 = *(int *)(*(int *)(param1 + 0x20c) + 0xc);
		  if (0 < iVar3) {
		    iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(param1 + 0x20c),0,
		                       Method_Google_Protobuf_Collections_RepeatedField_ColossusFragmentsOptionsDic__get_Item__
		                      );
		    *param3 = iVar2;
		    uVar1 = 1;
		    if (*(int *)(*(int *)(*(int *)(iVar2 + 0xc) + 0xc) + 0xc) != param2) {
		      do {
		        param2_00 = param2_00 + 1;
		        if (iVar3 == param2_00) break;
		        iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0x20c),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_ColossusFragmentsOptionsDic__get_Item__
		                          );
		        *param3 = iVar2;
		      } while (*(int *)(*(int *)(*(int *)(iVar2 + 0xc) + 0xc) + 0xc) != param2);
		      uVar1 = (uint)(param2_00 < iVar3);
		    }
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E63 RID: 24163 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		[Token(Token = "0x6005E63")]
		[Address(RVA = "0xAABC", Offset = "0xAABC", VA = "0xAABC")]
		public static bool TryGetColossusFragmentsOptionsDic(this Dictionaries dict, uint optionId, out ColossusFragmentsOptionsDic result)
		{
		/* --- GHIDRA: TryGetColossusFragmentsOptionsDic ---
		uint Core_Extensions_Dict_DictExt__TryGetColossusFragmentsOptionsDic
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5ad30 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulOptionsDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IListExt_BinarySearch_ArtikulOptionsDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__TryGetArtikulOptionsDic_b__78_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad30 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x164);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar2 = puVar1[0x13];
		  if (iVar2 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    iVar2 = unnamed_function_1417(System_Func_ArtikulOptionsDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,param2_00,
		               Method_Core_Extensions_Dict_DictExt___c__TryGetArtikulOptionsDic_b__78_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x4c) = iVar2;
		  }
		  iVar2 = Unity_Jobs_IJobParallelForExtensions__Run_UITKTextJobSystem_PrepareTextJobData_
		                    (param1_00,iVar2,param2,
		                     Method_Core_Extensions_IListExt_BinarySearch_ArtikulOptionsDic__uint___);
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E64 RID: 24164 RVA: 0x00010EF0 File Offset: 0x0000F0F0
		[Token(Token = "0x6005E64")]
		[Address(RVA = "0xAABD", Offset = "0xAABD", VA = "0xAABD")]
		public static bool TryGetArtikulOptionsDic(this Dictionaries dict, uint optionId, out ArtikulOptionsDic result)
		{
		/* --- GHIDRA: TryGetArtikulOptionsDic ---
		undefined4
		Core_Extensions_Dict_DictExt__TryGetArtikulOptionsDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad31 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_StoneDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_StoneDic__get_Item__);
		    DAT_ram_00a5ad31 = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param1 + 0x290) + 0xc);
		  if (0 < iVar3) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x290),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_StoneDic__get_Item__);
		      if (param2 == *(int *)(iVar1 + 0xc)) {
		        uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0x290),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_StoneDic__get_Item__);
		        return uVar2;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E65 RID: 24165 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E65")]
		[Address(RVA = "0xAABE", Offset = "0xAABE", VA = "0xAABE")]
		public static StoneDic GetStoneDic(this Dictionaries dict, StonesTypes stone)
		{
		/* --- GHIDRA: GetStoneDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetStoneDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad32 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BossTypeDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BossTypeDic__get_Item__);
		    DAT_ram_00a5ad32 = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param1 + 0x158) + 0xc);
		  if (0 < iVar3) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x158),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_BossTypeDic__get_Item__);
		      if (param2 == *(int *)(iVar1 + 0xc)) {
		        uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                          (*(undefined4 *)(param1 + 0x158),param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_BossTypeDic__get_Item__)
		        ;
		        return uVar2;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E66")]
		[Address(RVA = "0xAABF", Offset = "0xAABF", VA = "0xAABF")]
		public static BossTypeDic GetBossTypeDic(this Dictionaries dict, int typeId)
		{
		/* --- GHIDRA: GetBossTypeDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetBossTypeDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad33 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BonusDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_BonusDic__get_Item__);
		    DAT_ram_00a5ad33 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x280) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x280),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_BonusDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E67")]
		[Address(RVA = "0xAAC0", Offset = "0xAAC0", VA = "0xAAC0")]
		public static BonusDic GetBonusDic(this Dictionaries dict, uint bonusId)
		{
		/* --- GHIDRA: GetBonusDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetBonusDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad34 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CurrenciesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_CurrenciesDic__get_Item__);
		    DAT_ram_00a5ad34 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x170) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x170),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_CurrenciesDic__get_Item__)
		      ;
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E68 RID: 24168 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E68")]
		[Address(RVA = "0xAAC1", Offset = "0xAAC1", VA = "0xAAC1")]
		public static CurrenciesDic GetCurrenciesDic(this Dictionaries dict, uint currencyId)
		{
		/* --- GHIDRA: GetCurrenciesDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetCurrenciesDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad36 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PaymentBonusesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PaymentBonusesDic__get_Item__);
		    DAT_ram_00a5ad36 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x114) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x114),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_PaymentBonusesDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

		/* --- GHIDRA: GetCurrenciesDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetCurrenciesDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad36 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PaymentBonusesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PaymentBonusesDic__get_Item__);
		    DAT_ram_00a5ad36 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x114) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x114),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_PaymentBonusesDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E69 RID: 24169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E69")]
		[Address(RVA = "0xAAC2", Offset = "0xAAC2", VA = "0xAAC2")]
		public static CurrenciesDic GetCurrenciesDic(this Dictionaries dict, string currencyCode)
		{
			return null;
		}

		// Token: 0x06005E6A RID: 24170 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E6A")]
		[Address(RVA = "0xAAC3", Offset = "0xAAC3", VA = "0xAAC3")]
		public static PaymentBonusesDic GetPaymentBonusDic(this Dictionaries dict, uint paymentBonusId)
		{
		/* --- GHIDRA: GetPaymentBonusDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetPaymentBonusDic
		          (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad38 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ScriptsConstsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ScriptsConstsDic__get_Item__);
		    DAT_ram_00a5ad38 = '\x01';
		  }
		  uVar1 = 1;
		  iVar3 = *(int *)(*(int *)(param1 + 0x110) + 0xc);
		  if (iVar3 < 1) {
		code_r0x812d82ed:
		    *param3 = 0;
		    return 0;
		  }
		  iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x110),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_ScriptsConstsDic__get_Item__);
		  *param3 = iVar2;
		  iVar2 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar2 + 0x14),param2,0);
		  if (iVar2 == 0) {
		    do {
		      param2_00 = param2_00 + 1;
		      if (param2_00 == iVar3) goto code_r0x812d82ed;
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x110),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ScriptsConstsDic__get_Item__
		                        );
		      *param3 = iVar2;
		      iVar2 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar2 + 0x14),param2,0);
		    } while (iVar2 == 0);
		    uVar1 = (uint)(param2_00 < iVar3);
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E6B RID: 24171 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E6B")]
		[Address(RVA = "0x1D40", Offset = "0x1D40", VA = "0x1D40")]
		public static OptionStickerDic GetOptionStickerDic(this Dictionaries dict, uint stickerId)
		{
			return null;
		}

		// Token: 0x06005E6C RID: 24172 RVA: 0x00010F08 File Offset: 0x0000F108
		[Token(Token = "0x6005E6C")]
		[Address(RVA = "0xAAC4", Offset = "0xAAC4", VA = "0xAAC4")]
		public static bool TryGetScriptsConstDic(this Dictionaries dict, string constName, out ScriptsConstsDic dic)
		{
		/* --- GHIDRA: TryGetScriptsConstDic ---
		undefined4
		Core_Extensions_Dict_DictExt__TryGetScriptsConstDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad39 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanSeasonDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanSeasonDic__get_Item__);
		    DAT_ram_00a5ad39 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0xdc) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0xdc),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ClanSeasonDic__get_Item__)
		      ;
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E6D")]
		[Address(RVA = "0xAAC5", Offset = "0xAAC5", VA = "0xAAC5")]
		public static ClanSeasonDic GetClanSeasonDic(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetClanSeasonDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetClanSeasonDic
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad3a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_SeasonLeagueDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_SeasonLeagueDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass88_0__GetSeasonLeagueDic_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass88_0_TypeInfo);
		    DAT_ram_00a5ad3a = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass88_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param3;
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0xe0);
		  uVar1 = unnamed_function_1417(System_Func_SeasonLeagueDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass88_0__GetSeasonLeagueDic_b__0__,0)
		  ;
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_SeasonLeagueDic___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E6E")]
		[Address(RVA = "0xAAC6", Offset = "0xAAC6", VA = "0xAAC6")]
		public static SeasonLeagueDic GetSeasonLeagueDic(this Dictionaries dict, uint seasonId, uint leagueId)
		{
		/* --- GHIDRA: GetSeasonLeagueDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetSeasonLeagueDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5ad3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_CraftSchemeDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_CraftSchemeDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__GetCraftSchemeDic_b__89_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad3b = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xb0);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[0x14];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_CraftSchemeDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar1,Method_Core_Extensions_Dict_DictExt___c__GetCraftSchemeDic_b__89_0__,
		               0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x50) = param1_00;
		  }
		  uVar1 = func_ii_8597(&local_4,param1_00,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_CraftSchemeDic__uint___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E6F")]
		[Address(RVA = "0xAAC7", Offset = "0xAAC7", VA = "0xAAC7")]
		public static CraftSchemeDic GetCraftSchemeDic(this Dictionaries dict, uint schemeId)
		{
		/* --- GHIDRA: GetCraftSchemeDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetCraftSchemeDic(int param1,undefined8 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad3c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_SlotMachineSymbolDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_SlotMachineSymbolDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_DictExt___c__DisplayClass90_0__GetSlotMachineSymbolDic_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass90_0_TypeInfo);
		    DAT_ram_00a5ad3c = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass90_0_TypeInfo);
		  *(undefined8 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x294);
		  uVar1 = unnamed_function_1417(System_Func_SlotMachineSymbolDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass90_0__GetSlotMachineSymbolDic_b__0__
		             ,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_FirstOrDefault_SlotMachineSymbolDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E70")]
		[Address(RVA = "0xAAC8", Offset = "0xAAC8", VA = "0xAAC8")]
		public static SlotMachineSymbolDic GetSlotMachineSymbolDic(this Dictionaries dict, ulong symbolId)
		{
		/* --- GHIDRA: GetSlotMachineSymbolDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetSlotMachineSymbolDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatRoomDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatRoomDic__get_Item__);
		    DAT_ram_00a5ad3e = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x80) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x80),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ChatRoomDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

		/* --- GHIDRA: GetSlotMachineSymbolDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetSlotMachineSymbolDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatRoomDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatRoomDic__get_Item__);
		    DAT_ram_00a5ad3e = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x80) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x80),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ChatRoomDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E71")]
		[Address(RVA = "0xAAC9", Offset = "0xAAC9", VA = "0xAAC9")]
		public static SlotMachineSymbolDic GetSlotMachineSymbolDic(this Dictionaries dict, SlotMachineSymbol symbol)
		{
			return null;
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E72")]
		[Address(RVA = "0xAACA", Offset = "0xAACA", VA = "0xAACA")]
		public static ChatRoomDic GetChatRoomDic(this Dictionaries dict, RoomKey.Types.ChatRoomTypes type)
		{
		/* --- GHIDRA: GetChatRoomDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetChatRoomDic(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatRoomDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatRoomDic__get_Item__);
		    DAT_ram_00a5ad3f = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x80) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x80),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ChatRoomDic__get_Item__);
		      if (*(char *)(iVar1 + 0x28) != '\0') {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E73 RID: 24179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E73")]
		[Address(RVA = "0xAACB", Offset = "0xAACB", VA = "0xAACB")]
		public static ChatRoomDic GetDefaultChatRoomDic(this Dictionaries dict)
		{
		/* --- GHIDRA: GetDefaultChatRoomDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetDefaultChatRoomDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad40 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatBanDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ChatBanDic__get_Item__);
		    DAT_ram_00a5ad40 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x84) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x84),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ChatBanDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E74 RID: 24180 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E74")]
		[Address(RVA = "0xAACC", Offset = "0xAACC", VA = "0xAACC")]
		public static ChatBanDic GetChatBanDic(this Dictionaries dict, uint banId)
		{
		/* --- GHIDRA: GetChatBanDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetChatBanDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad41 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_BlitzTournamentsDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_BlitzTournamentsDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_DictExt___c__DisplayClass95_0__GetBlitzTournamentsDic_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass95_0_TypeInfo);
		    DAT_ram_00a5ad41 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass95_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0xc0);
		  uVar1 = unnamed_function_1417(System_Func_BlitzTournamentsDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass95_0__GetBlitzTournamentsDic_b__0__
		             ,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_FirstOrDefault_BlitzTournamentsDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E75")]
		[Address(RVA = "0xAACD", Offset = "0xAACD", VA = "0xAACD")]
		public static BlitzTournamentsDic GetBlitzTournamentsDic(this Dictionaries dict, uint typeId)
		{
		/* --- GHIDRA: GetBlitzTournamentsDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetBlitzTournamentsDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad42 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_TournamentDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_TournamentDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass96_0__GetTournamentDic_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass96_0_TypeInfo);
		    DAT_ram_00a5ad42 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass96_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x90);
		  uVar1 = unnamed_function_1417(System_Func_TournamentDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass96_0__GetTournamentDic_b__0__,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_TournamentDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E76")]
		[Address(RVA = "0xAACE", Offset = "0xAACE", VA = "0xAACE")]
		public static TournamentDic GetTournamentDic(this Dictionaries dict, uint type)
		{
		/* --- GHIDRA: GetTournamentDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetTournamentDic(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad44 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_IsleAnimationsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_IsleAnimationsDic__get_Item__);
		    DAT_ram_00a5ad44 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x160);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_IsleAnimationsDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x160);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E77 RID: 24183 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E77")]
		[Address(RVA = "0x1E14", Offset = "0x1E14", VA = "0x1E14")]
		public static IsleDecorationsDic GetIsleDecorationsDic(this Dictionaries dictionaries, uint decorationId)
		{
		/* --- GHIDRA: GetIsleDecorationsDic ---
		void Core_Extensions_Dict_DictExt__GetIsleDecorationsDic(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58d56 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__GameAssetViewSpriteRenderer__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__GameAssetViewSpriteRenderer__set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_GameAssetViewSpriteRenderer___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9966);
		    DAT_ram_00a58d56 = '\x01';
		  }
		  iVar1 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(param1 + 0x2c),*(undefined4 *)(param2 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__GameAssetViewSpriteRenderer__ContainsKey__
		                    );
		  if (iVar1 == 0) {
		    uVar2 = *(undefined4 *)(param1 + 0x24);
		    uVar3 = *(undefined4 *)(param1 + 0x28);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    uVar2 = func_ii_6805(uVar3,uVar2,
		                         Method_UnityEngine_Object_Instantiate_GameAssetViewSpriteRenderer___);
		    uVar3 = Core_Extensions_Dict_IsleAnimationsDicExt__GetDescriptionWhitOutCoolDown(param2,0);
		    AssetContent_GameAssetViewSpriteRenderer__get_AssetId(uVar2,uVar3,0);
		    AssetContent_GameAssetViewSpriteRenderer__get_Interactable(uVar2,0,0);
		    System_Collections_Generic_Dictionary_uint__object___get_Item
		              (*(undefined4 *)(param1 + 0x2c),*(undefined4 *)(param2 + 0xc),uVar2,
		               Method_System_Collections_Generic_Dictionary_uint__GameAssetViewSpriteRenderer__set_Item__
		              );
		    uVar3 = func_ii_4075(param1,0);
		    CloudsFly_BaseWorldObjectRenderer__get_SortingOrderWithDelta(uVar2,uVar3,0);
		    func_ii_7665(uVar2,*(undefined4 *)(param1 + 0x18),0);
		  }
		  else {
		    local_4 = *(undefined4 *)(param2 + 0xc);
		    uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		    uVar2 = func_ii_4419(StringLiteral_9966,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar2,0);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E78")]
		[Address(RVA = "0xAACF", Offset = "0xAACF", VA = "0xAACF")]
		public static IsleAnimationsDic GetIsleAnimationDic(this Dictionaries dictionaries, uint animationId)
		{
		/* --- GHIDRA: GetIsleAnimationDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetIsleAnimationDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad47 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_ProfessionDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_ProfessionDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass101_0__GetProfessionDic_b__0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass101_0_TypeInfo);
		    DAT_ram_00a5ad47 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass101_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0xac);
		  uVar1 = unnamed_function_1417(System_Func_ProfessionDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass101_0__GetProfessionDic_b__0__,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_ProfessionDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E79")]
		[Address(RVA = "0x1B76", Offset = "0x1B76", VA = "0x1B76")]
		public static BossGroupDic GetBossGroupDic(this Dictionaries dict, uint groupId)
		{
			return null;
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E7A")]
		[Address(RVA = "0x1B70", Offset = "0x1B70", VA = "0x1B70")]
		public static BossCategoryDic GetBossCategoryDic(this Dictionaries dict, int category)
		{
			return null;
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E7B")]
		[Address(RVA = "0xAAD0", Offset = "0xAAD0", VA = "0xAAD0")]
		public static ProfessionDic GetProfessionDic(this Dictionaries dict, uint professionId)
		{
		/* --- GHIDRA: GetProfessionDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetProfessionDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5ad48 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_DiscountsDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_DiscountsDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__GetDiscountsDic_b__102_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad48 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0x1b0);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[0x15];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_DiscountsDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar1,Method_Core_Extensions_Dict_DictExt___c__GetDiscountsDic_b__102_0__,0
		              );
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x54) = param1_00;
		  }
		  uVar1 = func_ii_8597(&local_4,param1_00,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_DiscountsDic__uint___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E7C")]
		[Address(RVA = "0xAAD1", Offset = "0xAAD1", VA = "0xAAD1")]
		public static DiscountsDic GetDiscountsDic(this Dictionaries dict, uint discountId)
		{
		/* --- GHIDRA: GetDiscountsDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetDiscountsDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5ad49 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_ArtikulDismantleInfoDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulDismantleInfoDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__GetDismantleInfoDic_b__103_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad49 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xb8);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[0x16];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_ArtikulDismantleInfoDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar1,
		               Method_Core_Extensions_Dict_DictExt___c__GetDismantleInfoDic_b__103_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x58) = param1_00;
		  }
		  uVar1 = func_ii_8597(&local_4,param1_00,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_ArtikulDismantleInfoDic__uint___
		                      );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E7D RID: 24189 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E7D")]
		[Address(RVA = "0xAAD2", Offset = "0xAAD2", VA = "0xAAD2")]
		public static ArtikulDismantleInfoDic GetDismantleInfoDic(this Dictionaries dict, uint artikulId)
		{
		/* --- GHIDRA: GetDismantleInfoDic ---
		uint Core_Extensions_Dict_DictExt__GetDismantleInfoDic
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5ad4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_HordeDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_HordeDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass105_0__TryGetHordeDic_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass105_0_TypeInfo);
		    DAT_ram_00a5ad4b = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass105_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param1_01 = *(undefined4 *)(param1 + 0x220);
		  param1_00 = unnamed_function_1417(System_Func_HordeDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_00,iVar1,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass105_0__TryGetHordeDic_b__0__,0);
		  iVar1 = System_Func_object__bool____ctor
		                    (param1_01,param1_00,Method_System_Linq_Enumerable_FirstOrDefault_HordeDic___);
		  *param3 = iVar1;
		  return (uint)(iVar1 != 0);
		}
		*/

			return null;
		}

		// Token: 0x06005E7E RID: 24190 RVA: 0x00010F20 File Offset: 0x0000F120
		[Token(Token = "0x6005E7E")]
		[Address(RVA = "0x1F77", Offset = "0x1F77", VA = "0x1F77")]
		public static bool TryGetMarketOptionsDic(this Dictionaries dict, uint optionId, out MarketOptionsDic result)
		{
			return default(bool);
		}

		// Token: 0x06005E7F RID: 24191 RVA: 0x00010F38 File Offset: 0x0000F138
		[Token(Token = "0x6005E7F")]
		[Address(RVA = "0xAAD3", Offset = "0xAAD3", VA = "0xAAD3")]
		public static bool TryGetHordeDic(this Dictionaries dict, uint mainMonsterId, out HordeDic result)
		{
		/* --- GHIDRA: TryGetHordeDic ---
		undefined4 Core_Extensions_Dict_DictExt__TryGetHordeDic(int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5ad4c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_MonsterHordesDic__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IListExt_BinarySearch_MonsterHordesDic__ulong___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__GetHordeMonsterDic_b__106_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad4c = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x210);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[0x18];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_MonsterHordesDic__ulong__TypeInfo);
		    func_ii_7542(param1_00,param2_00,
		                 Method_Core_Extensions_Dict_DictExt___c__GetHordeMonsterDic_b__106_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x60) = param1_00;
		  }
		  uVar1 = Core_Extensions_IListExt__BinarySearch_object__uint_
		                    (uVar1,param1_00,(ulonglong)param2,
		                     Method_Core_Extensions_IListExt_BinarySearch_MonsterHordesDic__ulong___);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E80 RID: 24192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E80")]
		[Address(RVA = "0xAAD4", Offset = "0xAAD4", VA = "0xAAD4")]
		public static MonsterHordesDic GetHordeMonsterDic(this Dictionaries dict, uint monsterId)
		{
		/* --- GHIDRA: GetHordeMonsterDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetHordeMonsterDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a5ad4d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_MonsterHordesDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_MonsterHordesDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_MonsterHordesDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_MonsterHordesDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_MonsterHordesDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_DictExt___c__GetHordeMonstersByMainMonsterIdSorted_b__107_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_DictExt___c__DisplayClass107_0__GetHordeMonstersByMainMonsterIdSorted_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass107_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad4d = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass107_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  uVar3 = *(undefined4 *)(param1 + 0x210);
		  uVar2 = unnamed_function_1417(System_Func_MonsterHordesDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass107_0__GetHordeMonstersByMainMonsterIdSorted_b__0__
		             ,0);
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,uVar2,Method_System_Linq_Enumerable_Where_MonsterHordesDic___);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar1 = puVar4[0x19];
		  if (iVar1 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar4;
		    iVar1 = unnamed_function_1417(System_Func_MonsterHordesDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar1,uVar3,
		               Method_Core_Extensions_Dict_DictExt___c__GetHordeMonstersByMainMonsterIdSorted_b__107_1__
		               ,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 100) = iVar1;
		  }
		  uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar2,iVar1,Method_System_Linq_Enumerable_OrderBy_MonsterHordesDic__uint___);
		  uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_MonsterHordesDic___);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005E81 RID: 24193 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E81")]
		[Address(RVA = "0xAAD5", Offset = "0xAAD5", VA = "0xAAD5")]
		public static MonsterHordesDic[] GetHordeMonstersByMainMonsterIdSorted(this Dictionaries dict, uint mainMonsterId)
		{
		/* --- GHIDRA: GetHordeMonstersByMainMonsterIdSorted ---
		undefined4
		Core_Extensions_Dict_DictExt__GetHordeMonstersByMainMonsterIdSorted
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad4e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_DuelTypesDict___);
		    Mono_Security_ASN1__get_Item(&System_Func_DuelTypesDict__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass108_0__GetDuelTypeDic_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass108_0_TypeInfo);
		    DAT_ram_00a5ad4e = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass108_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0xf4);
		  uVar1 = unnamed_function_1417(System_Func_DuelTypesDict__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass108_0__GetDuelTypeDic_b__0__,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_DuelTypesDict___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E82 RID: 24194 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E82")]
		[Address(RVA = "0xAAD6", Offset = "0xAAD6", VA = "0xAAD6")]
		public static DuelTypesDict GetDuelTypeDic(this Dictionaries dict, uint duelType)
		{
		/* --- GHIDRA: GetDuelTypeDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetDuelTypeDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad4f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_DuelUserStateFlags___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_DuelUserStateFlags___);
		    Mono_Security_ASN1__get_Item(&System_Func_DuelUserStateFlags__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_DictExt___c__DisplayClass109_0__GetDuelUserStateFlags_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass109_0_TypeInfo);
		    DAT_ram_00a5ad4f = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass109_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0xfc);
		  uVar1 = unnamed_function_1417(System_Func_DuelUserStateFlags__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass109_0__GetDuelUserStateFlags_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_Where_DuelUserStateFlags___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_DuelUserStateFlags___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E83 RID: 24195 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E83")]
		[Address(RVA = "0xAAD7", Offset = "0xAAD7", VA = "0xAAD7")]
		public static DuelUserStateFlags[] GetDuelUserStateFlags(this Dictionaries dict, int flags)
		{
		/* --- GHIDRA: GetDuelUserStateFlags ---
		undefined4
		Core_Extensions_Dict_DictExt__GetDuelUserStateFlags(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad50 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_GreatRewardSets___);
		    Mono_Security_ASN1__get_Item(&System_Func_GreatRewardSets__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass110_0__GetGreatRewardSet_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass110_0_TypeInfo);
		    DAT_ram_00a5ad50 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass110_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x1dc);
		  uVar1 = unnamed_function_1417(System_Func_GreatRewardSets__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass110_0__GetGreatRewardSet_b__0__,0)
		  ;
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_GreatRewardSets___
		                    );
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E84 RID: 24196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E84")]
		[Address(RVA = "0xAAD8", Offset = "0xAAD8", VA = "0xAAD8")]
		public static GreatRewardSets GetGreatRewardSet(this Dictionaries dict, uint setId)
		{
		/* --- GHIDRA: GetGreatRewardSet ---
		undefined4
		Core_Extensions_Dict_DictExt__GetGreatRewardSet(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a5ad51 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_RatingPrizeDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_RatingPrizeDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingPrizeDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingPrizeDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__GetUserPrizesByKindId_b__111_1__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_DictExt___c__DisplayClass111_0__GetUserPrizesByKindId_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass111_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad51 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass111_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  uVar3 = *(undefined4 *)(param1 + 0x2a8);
		  uVar2 = unnamed_function_1417(System_Func_RatingPrizeDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass111_0__GetUserPrizesByKindId_b__0__
		             ,0);
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,uVar2,Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar1 = puVar4[0x1a];
		  if (iVar1 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar4;
		    iVar1 = unnamed_function_1417(System_Func_RatingPrizeDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar1,uVar3,Method_Core_Extensions_Dict_DictExt___c__GetUserPrizesByKindId_b__111_1__
		               ,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x68) = iVar1;
		  }
		  uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar2,iVar1,Method_System_Linq_Enumerable_OrderBy_RatingPrizeDic__uint___);
		  uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_RatingPrizeDic___);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E85")]
		[Address(RVA = "0xAAD9", Offset = "0xAAD9", VA = "0xAAD9")]
		public static RatingPrizeDic[] GetUserPrizesByKindId(this Dictionaries dict, uint kindId)
		{
		/* --- GHIDRA: GetUserPrizesByKindId ---
		undefined4
		Core_Extensions_Dict_DictExt__GetUserPrizesByKindId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a5ad52 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_RatingPrizeDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_RatingPrizeDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingPrizeDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingPrizeDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__GetClanPrizesByKindId_b__112_1__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_DictExt___c__DisplayClass112_0__GetClanPrizesByKindId_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass112_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad52 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass112_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  uVar3 = *(undefined4 *)(param1 + 700);
		  uVar2 = unnamed_function_1417(System_Func_RatingPrizeDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass112_0__GetClanPrizesByKindId_b__0__
		             ,0);
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,uVar2,Method_System_Linq_Enumerable_Where_RatingPrizeDic___);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar1 = puVar4[0x1b];
		  if (iVar1 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar4;
		    iVar1 = unnamed_function_1417(System_Func_RatingPrizeDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar1,uVar3,Method_Core_Extensions_Dict_DictExt___c__GetClanPrizesByKindId_b__112_1__
		               ,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x6c) = iVar1;
		  }
		  uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar2,iVar1,Method_System_Linq_Enumerable_OrderBy_RatingPrizeDic__uint___);
		  uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_RatingPrizeDic___);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E86")]
		[Address(RVA = "0xAADA", Offset = "0xAADA", VA = "0xAADA")]
		public static RatingPrizeDic[] GetClanPrizesByKindId(this Dictionaries dict, uint kindId)
		{
		/* --- GHIDRA: GetClanPrizesByKindId ---
		undefined4
		Core_Extensions_Dict_DictExt__GetClanPrizesByKindId(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad54 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_ClanLeagueDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_ClanLeagueDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass114_0__GetClanLeagueDic_b__0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass114_0_TypeInfo);
		    DAT_ram_00a5ad54 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass114_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0xd4);
		  uVar1 = unnamed_function_1417(System_Func_ClanLeagueDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass114_0__GetClanLeagueDic_b__0__,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_ClanLeagueDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E87")]
		[Address(RVA = "0x1DCA", Offset = "0x1DCA", VA = "0x1DCA")]
		public static RatingTypesDic GetRatingTypeDic(this Dictionaries dict, uint typeId)
		{
		/* --- GHIDRA: GetRatingTypeDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetRatingTypeDic(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int param1_00;
		  
		  param1_00 = *(int *)(param1 + 0x20);
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
		      if (*(int *)(iVar1 + 0xc) == 0x31) {
		        return *(undefined4 *)(iVar1 + 0x10);
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E88")]
		[Address(RVA = "0xAADB", Offset = "0xAADB", VA = "0xAADB")]
		public static ClanLeagueDic GetClanLeagueDic(this Dictionaries dict, uint leagueId)
		{
		/* --- GHIDRA: GetClanLeagueDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetClanLeagueDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad55 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_ZigguratLevelDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_ZigguratLevelDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_DictExt___c__DisplayClass115_0__GetZigguratLevelDic_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass115_0_TypeInfo);
		    DAT_ram_00a5ad55 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass115_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x28);
		  uVar1 = unnamed_function_1417(System_Func_ZigguratLevelDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass115_0__GetZigguratLevelDic_b__0__,
		             0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_FirstOrDefault_ZigguratLevelDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E89")]
		[Address(RVA = "0xAADC", Offset = "0xAADC", VA = "0xAADC")]
		public static ZigguratLevelDic GetZigguratLevelDic(this Dictionaries dict, uint level)
		{
		/* --- GHIDRA: GetZigguratLevelDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetZigguratLevelDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  
		  if (DAT_ram_00a5ad56 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_SeasonLeagueRewardsDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_SeasonLeagueRewardsDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_SeasonLeagueRewardsDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_SeasonLeagueRewardsDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_SeasonLeagueRewardsDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__GetSeasonLeagueRewardsSorted_b__116_1__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_DictExt___c__DisplayClass116_0__GetSeasonLeagueRewardsSorted_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass116_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad56 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass116_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  uVar3 = *(undefined4 *)(param1 + 0xe4);
		  uVar2 = unnamed_function_1417(System_Func_SeasonLeagueRewardsDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass116_0__GetSeasonLeagueRewardsSorted_b__0__
		             ,0);
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar3,uVar2,Method_System_Linq_Enumerable_Where_SeasonLeagueRewardsDic___);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar4 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar1 = puVar4[0x1c];
		  if (iVar1 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar4 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar4;
		    iVar1 = unnamed_function_1417(System_Func_SeasonLeagueRewardsDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar1,uVar3,
		               Method_Core_Extensions_Dict_DictExt___c__GetSeasonLeagueRewardsSorted_b__116_1__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x70) = iVar1;
		  }
		  uVar2 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar2,iVar1,
		                     Method_System_Linq_Enumerable_OrderBy_SeasonLeagueRewardsDic__uint___);
		  uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_SeasonLeagueRewardsDic___);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E8A")]
		[Address(RVA = "0xAADD", Offset = "0xAADD", VA = "0xAADD")]
		public static SeasonLeagueRewardsDic[] GetSeasonLeagueRewardsSorted(this Dictionaries dict, uint leagueId)
		{
		/* --- GHIDRA: GetSeasonLeagueRewardsSorted ---
		undefined4
		Core_Extensions_Dict_DictExt__GetSeasonLeagueRewardsSorted
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad57 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_UserLevelsDiffShoppingDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserLevelsDiffShoppingDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass117_0__GetShoppingDiff_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass117_0_TypeInfo);
		    DAT_ram_00a5ad57 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass117_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x150);
		  uVar1 = unnamed_function_1417(System_Func_UserLevelsDiffShoppingDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass117_0__GetShoppingDiff_b__0__,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_FirstOrDefault_UserLevelsDiffShoppingDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E8B")]
		[Address(RVA = "0xAADE", Offset = "0xAADE", VA = "0xAADE")]
		public static UserLevelsDiffShoppingDic GetShoppingDiff(this Dictionaries dict, uint level)
		{
		/* --- GHIDRA: GetShoppingDiff ---
		undefined4
		Core_Extensions_Dict_DictExt__GetShoppingDiff(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad58 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_ColossusDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_ColossusDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass118_0__GetColossusDic_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass118_0_TypeInfo);
		    DAT_ram_00a5ad58 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass118_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x1ec);
		  uVar1 = unnamed_function_1417(System_Func_ColossusDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass118_0__GetColossusDic_b__0__,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_ColossusDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E8C")]
		[Address(RVA = "0xAADF", Offset = "0xAADF", VA = "0xAADF")]
		public static ColossusDic GetColossusDic(this Dictionaries dict, uint colossusId)
		{
		/* --- GHIDRA: GetColossusDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetColossusDic(int param1,undefined8 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad59 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_DollsInfoDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_DollsInfoDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass119_0__GetDollInfoDic_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass119_0_TypeInfo);
		    DAT_ram_00a5ad59 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass119_0_TypeInfo);
		  *(undefined8 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x1f0);
		  uVar1 = unnamed_function_1417(System_Func_DollsInfoDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass119_0__GetDollInfoDic_b__0__,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_DollsInfoDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E8D RID: 24205 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E8D")]
		[Address(RVA = "0xAAE0", Offset = "0xAAE0", VA = "0xAAE0")]
		public static DollsInfoDic GetDollInfoDic(this Dictionaries dict, ulong dollId)
		{
		/* --- GHIDRA: GetDollInfoDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetDollInfoDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad5a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_ColossusPartiesInfoDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_ColossusPartiesInfoDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass120_0__GetPartyInfoDic_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass120_0_TypeInfo);
		    DAT_ram_00a5ad5a = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass120_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x200);
		  uVar1 = unnamed_function_1417(System_Func_ColossusPartiesInfoDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass120_0__GetPartyInfoDic_b__0__,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_FirstOrDefault_ColossusPartiesInfoDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E8E")]
		[Address(RVA = "0xAAE1", Offset = "0xAAE1", VA = "0xAAE1")]
		public static ColossusPartiesInfoDic GetPartyInfoDic(this Dictionaries dict, uint partyId)
		{
		/* --- GHIDRA: GetPartyInfoDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetPartyInfoDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad5b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_PortalStageDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_PortalStageDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_DictExt___c__DisplayClass121_0__GetPortalStagesCount_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass121_0_TypeInfo);
		    DAT_ram_00a5ad5b = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass121_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x2fc);
		  uVar1 = unnamed_function_1417(System_Func_PortalStageDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass121_0__GetPortalStagesCount_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__Count_KeyValuePair_uint__object__
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_Count_PortalStageDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x00010F50 File Offset: 0x0000F150
		[Token(Token = "0x6005E8F")]
		[Address(RVA = "0xAAE2", Offset = "0xAAE2", VA = "0xAAE2")]
		public static int GetPortalStagesCount(this Dictionaries dict, uint portalId)
		{
		/* --- GHIDRA: GetPortalStagesCount ---
		undefined4
		Core_Extensions_Dict_DictExt__GetPortalStagesCount(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad5c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TutorialUIPointerDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TutorialUIPointerDic__get_Item__);
		    DAT_ram_00a5ad5c = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x29c) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x29c),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_TutorialUIPointerDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return 0;
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E90")]
		public static TListElement BinarySearch<TListElement, SValue>(in IList<TListElement> list, Func<TListElement, SValue> getter, SValue searchValue) where TListElement : class where SValue : IComparable
		{
			return null;
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E91")]
		[Address(RVA = "0xAAE3", Offset = "0xAAE3", VA = "0xAAE3")]
		public static TutorialUIPointerDic GetTutorialUIPointerDic(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetTutorialUIPointerDic ---
		int Core_Extensions_Dict_DictExt__GetTutorialUIPointerDic(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  int param2_00;
		  int iVar2;
		  uint uVar3;
		  int param2_01;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a5ad5d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserAccountLevelsDic__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserAccountLevelsDic___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_UserAccountLevelsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserAccountLevelsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserAccountLevelsDic__get_Item__);
		    DAT_ram_00a5ad5d = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_UserAccountLevelsDic__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_UserAccountLevelsDic___ctor__);
		  iVar2 = *(int *)(*(int *)(param1 + 0x230) + 0xc);
		  if (0 < iVar2) {
		    do {
		      param2_00 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (*(undefined4 *)(param1 + 0x230),param2_01,
		                             Method_Google_Protobuf_Collections_RepeatedField_UserAccountLevelsDic__get_Item__
		                            );
		      iVar1 = Method_System_Collections_Generic_List_UserAccountLevelsDic__Add__;
		      if (*(int *)(*(int *)(param2_00 + 0xc) + 0xc) == param2) {
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar3 = *(uint *)(param1_00 + 0xc);
		        if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		          *(int *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param2_00;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param2_00,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      param2_01 = param2_01 + 1;
		    } while (param2_01 != iVar2);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E92")]
		[Address(RVA = "0xAAE4", Offset = "0xAAE4", VA = "0xAAE4")]
		public static List<UserAccountLevelsDic> GetUserAccountLevels(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetUserAccountLevels ---
		int Core_Extensions_Dict_DictExt__GetUserAccountLevels(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  int param2_00;
		  int iVar2;
		  uint uVar3;
		  int param2_01;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a5ad5e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ClanAccountLevelsDic__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ClanAccountLevelsDic___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ClanAccountLevelsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanAccountLevelsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanAccountLevelsDic__get_Item__);
		    DAT_ram_00a5ad5e = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ClanAccountLevelsDic__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ClanAccountLevelsDic___ctor__);
		  iVar2 = *(int *)(*(int *)(param1 + 0x22c) + 0xc);
		  if (0 < iVar2) {
		    do {
		      param2_00 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (*(undefined4 *)(param1 + 0x22c),param2_01,
		                             Method_Google_Protobuf_Collections_RepeatedField_ClanAccountLevelsDic__get_Item__
		                            );
		      iVar1 = Method_System_Collections_Generic_List_ClanAccountLevelsDic__Add__;
		      if (*(int *)(*(int *)(param2_00 + 0xc) + 0xc) == param2) {
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar3 = *(uint *)(param1_00 + 0xc);
		        if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		          *(int *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param2_00;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param2_00,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      param2_01 = param2_01 + 1;
		    } while (param2_01 != iVar2);
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x06005E93 RID: 24211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E93")]
		[Address(RVA = "0xAAE5", Offset = "0xAAE5", VA = "0xAAE5")]
		public static List<ClanAccountLevelsDic> GetClanAccountLevels(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetClanAccountLevels ---
		undefined4
		Core_Extensions_Dict_DictExt__GetClanAccountLevels(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad5f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AccountDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AccountDic__get_Item__);
		    DAT_ram_00a5ad5f = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x6c) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x6c),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_AccountDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E94")]
		[Address(RVA = "0xAAE6", Offset = "0xAAE6", VA = "0xAAE6")]
		public static AccountDic GetAccountDic(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetAccountDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetAccountDic(int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad62 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AccountOptionsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AccountOptionsDic__get_Item__);
		    DAT_ram_00a5ad62 = '\x01';
		  }
		  uVar1 = 1;
		  iVar3 = *(int *)(*(int *)(param1 + 0x134) + 0xc);
		  if (iVar3 < 1) {
		code_r0x812da4e9:
		    *param3 = 0;
		    return 0;
		  }
		  iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x134),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_AccountOptionsDic__get_Item__)
		  ;
		  *param3 = iVar2;
		  if (*(int *)(*(int *)(iVar2 + 0xc) + 0xc) != param2) {
		    do {
		      param2_00 = param2_00 + 1;
		      if (param2_00 == iVar3) goto code_r0x812da4e9;
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x134),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_AccountOptionsDic__get_Item__
		                        );
		      *param3 = iVar2;
		    } while (param2 != *(int *)(*(int *)(iVar2 + 0xc) + 0xc));
		    uVar1 = (uint)(param2_00 < iVar3);
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x00010F68 File Offset: 0x0000F168
		[Token(Token = "0x6005E95")]
		[Address(RVA = "0x1D3F", Offset = "0x1D3F", VA = "0x1D3F")]
		public static bool TryGetAccountDic(this Dictionaries dict, uint id, out AccountDic result)
		{
		/* --- GHIDRA: TryGetAccountDic ---
		undefined4 Core_Extensions_Dict_DictExt__TryGetAccountDic(int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int param2_00;
		  
		  if (DAT_ram_00a5ad37 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_OptionStickerDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_OptionStickerDic__get_Item__);
		    DAT_ram_00a5ad37 = '\x01';
		  }
		  if ((param2 != 0) && (iVar2 = *(int *)(*(int *)(param1 + 0x28c) + 0xc), 0 < iVar2)) {
		    param2_00 = 0;
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x28c),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_OptionStickerDic__get_Item__
		                        );
		      if (*(ulonglong *)(iVar1 + 0x10) == (ulonglong)param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E96 RID: 24214 RVA: 0x00010F80 File Offset: 0x0000F180
		[Token(Token = "0x6005E96")]
		[Address(RVA = "0x1D43", Offset = "0x1D43", VA = "0x1D43")]
		public static bool TryGetAccountOptionsDicByAccountId(this Dictionaries dict, uint accountId, out List<AccountOptionsDic> result)
		{
		/* --- GHIDRA: TryGetAccountOptionsDicByAccountId ---
		uint Core_Extensions_Dict_DictExt__TryGetAccountOptionsDicByAccountId
		               (undefined4 param1,undefined4 param2,int param3)
		
		{
		  int iVar1;
		  
		  iVar1 = func_ii_7703(param1,param2,
		                       *(undefined4 *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0x74));
		  return (uint)(iVar1 != -1);
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x00010F98 File Offset: 0x0000F198
		[Token(Token = "0x6005E97")]
		[Address(RVA = "0xAAE7", Offset = "0xAAE7", VA = "0xAAE7")]
		public static bool TryGetAccountOptionsDicByOptionId(this Dictionaries dict, uint optionId, out AccountOptionsDic result)
		{
		/* --- GHIDRA: TryGetAccountOptionsDicByOptionId ---
		undefined4
		Core_Extensions_Dict_DictExt__TryGetAccountOptionsDicByOptionId
		          (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad63 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_EndlessPaymentOptionListOptionDic__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_EndlessPaymentOptionListOptionDic__get_Item__
		              );
		    DAT_ram_00a5ad63 = '\x01';
		  }
		  uVar1 = 1;
		  iVar3 = *(int *)(*(int *)(param1 + 0x2f4) + 0xc);
		  if (iVar3 < 1) {
		code_r0x812da5a6:
		    *param3 = 0;
		    return 0;
		  }
		  iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x2f4),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_EndlessPaymentOptionListOptionDic__get_Item__
		                    );
		  *param3 = iVar2;
		  if (*(int *)(*(int *)(iVar2 + 0xc) + 0xc) != param2) {
		    do {
		      param2_00 = param2_00 + 1;
		      if (param2_00 == iVar3) goto code_r0x812da5a6;
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x2f4),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_EndlessPaymentOptionListOptionDic__get_Item__
		                        );
		      *param3 = iVar2;
		    } while (param2 != *(int *)(*(int *)(iVar2 + 0xc) + 0xc));
		    uVar1 = (uint)(param2_00 < iVar3);
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E98 RID: 24216 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		[Token(Token = "0x6005E98")]
		[Address(RVA = "0xAAE8", Offset = "0xAAE8", VA = "0xAAE8")]
		public static bool TryGetEndlessPaymentOptionDicByOptionId(this Dictionaries dict, uint optionId, out EndlessPaymentOptionListOptionDic result)
		{
		/* --- GHIDRA: TryGetEndlessPaymentOptionDicByOptionId ---
		undefined4
		Core_Extensions_Dict_DictExt__TryGetEndlessPaymentOptionDicByOptionId
		          (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad64 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RegularOptionsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RegularOptionsDic__get_Item__);
		    DAT_ram_00a5ad64 = '\x01';
		  }
		  uVar1 = 1;
		  iVar3 = *(int *)(*(int *)(param1 + 0x334) + 0xc);
		  if (iVar3 < 1) {
		code_r0x812da669:
		    *param3 = 0;
		    return 0;
		  }
		  iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x334),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_RegularOptionsDic__get_Item__)
		  ;
		  *param3 = iVar2;
		  if (*(int *)(*(int *)(*(int *)(iVar2 + 0xc) + 0xc) + 0xc) != param2) {
		    do {
		      param2_00 = param2_00 + 1;
		      if (param2_00 == iVar3) goto code_r0x812da669;
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x334),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_RegularOptionsDic__get_Item__
		                        );
		      *param3 = iVar2;
		    } while (param2 != *(int *)(*(int *)(*(int *)(iVar2 + 0xc) + 0xc) + 0xc));
		    uVar1 = (uint)(param2_00 < iVar3);
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E99 RID: 24217 RVA: 0x00010FC8 File Offset: 0x0000F1C8
		[Token(Token = "0x6005E99")]
		[Address(RVA = "0xAAE9", Offset = "0xAAE9", VA = "0xAAE9")]
		public static bool TryGetRegularOptionsDicByOptionId(this Dictionaries dict, uint optionId, out RegularOptionsDic result)
		{
		/* --- GHIDRA: TryGetRegularOptionsDicByOptionId ---
		undefined4
		Core_Extensions_Dict_DictExt__TryGetRegularOptionsDicByOptionId
		          (int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad65 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AccountOptionsDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AccountOptionsDic__get_Item__);
		    DAT_ram_00a5ad65 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x134) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x134),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_AccountOptionsDic__get_Item__
		                        );
		      if (*(int *)(*(int *)(iVar1 + 0xc) + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005E9A RID: 24218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E9A")]
		[Address(RVA = "0xAAEA", Offset = "0xAAEA", VA = "0xAAEA")]
		public static AccountOptionsDic GetAccountOptionsDicByOptionId(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetAccountOptionsDicByOptionId ---
		undefined4
		Core_Extensions_Dict_DictExt__GetAccountOptionsDicByOptionId
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5ad66 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_UserSlotsDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IListExt_BinarySearch_UserSlotsDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__GetUserSlotsDic_b__133_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad66 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x19c);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[0x1d];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_UserSlotsDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,param2_00,
		               Method_Core_Extensions_Dict_DictExt___c__GetUserSlotsDic_b__133_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x74) = param1_00;
		  }
		  uVar1 = Unity_Jobs_IJobParallelForExtensions__Run_UITKTextJobSystem_PrepareTextJobData_
		                    (uVar1,param1_00,param2,
		                     Method_Core_Extensions_IListExt_BinarySearch_UserSlotsDic__uint___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E9B")]
		[Address(RVA = "0xAAEB", Offset = "0xAAEB", VA = "0xAAEB")]
		public static UserSlotsDic GetUserSlotsDic(this Dictionaries dict, uint slotId)
		{
		/* --- GHIDRA: GetUserSlotsDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetUserSlotsDic(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad67 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PointsForMonsterDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PointsForMonsterDic__get_Item__);
		    DAT_ram_00a5ad67 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x3c);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_PointsForMonsterDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x3c);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E9C")]
		[Address(RVA = "0xAAEC", Offset = "0xAAEC", VA = "0xAAEC")]
		public static PointsForMonsterDic GetPointPointsForMonsterDic(this Dictionaries dict, PointsForMonsterDic.Types.HzTypes type)
		{
		/* --- GHIDRA: GetPointPointsForMonsterDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetPointPointsForMonsterDic
		          (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad68 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanBuildingLevelDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanBuildingLevelDic__get_Item__);
		    DAT_ram_00a5ad68 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ClanBuildingLevelDic__get_Item__
		                        );
		      if ((param2 == *(int *)(iVar1 + 0xc)) && (*(int *)(iVar1 + 0x10) == param3)) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x1c);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E9D")]
		[Address(RVA = "0xAAED", Offset = "0xAAED", VA = "0xAAED")]
		public static ClanBuildingLevelDic GetClanBuildingLevel(this Dictionaries dict, uint type, uint level)
		{
		/* --- GHIDRA: GetClanBuildingLevel ---
		undefined4
		Core_Extensions_Dict_DictExt__GetClanBuildingLevel(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad69 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SocialGiftDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_SocialGiftDic__get_Item__);
		    DAT_ram_00a5ad69 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0xbc) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0xbc),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_SocialGiftDic__get_Item__)
		      ;
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E9E RID: 24222 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E9E")]
		[Address(RVA = "0xAAEE", Offset = "0xAAEE", VA = "0xAAEE")]
		public static SocialGiftDic GetGiftDic(this Dictionaries dict, uint giftId)
		{
		/* --- GHIDRA: GetGiftDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetGiftDic
		          (int param1,int param2,int param3,int param4,undefined4 param5)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad6a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanBuildingViewDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanBuildingViewDic__get_Item__);
		    DAT_ram_00a5ad6a = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x20);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (iVar1,param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_ClanBuildingViewDic__get_Item__
		                        );
		      if (((*(int *)(iVar1 + 0x10) == param2) && (*(int *)(iVar1 + 0x14) == param3)) &&
		         (*(int *)(iVar1 + 0xc) == param4)) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		      iVar1 = *(int *)(param1 + 0x20);
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005E9F RID: 24223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005E9F")]
		[Address(RVA = "0xAAEF", Offset = "0xAAEF", VA = "0xAAEF")]
		public static ClanBuildingViewDic GetClanBuildingView(this Dictionaries dict, uint type, uint level, uint cultId)
		{
		/* --- GHIDRA: GetClanBuildingView ---
		undefined4
		Core_Extensions_Dict_DictExt__GetClanBuildingView(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad6b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_ClanBuildingTypeDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_ClanBuildingTypeDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_DictExt___c__DisplayClass138_0__GetClanBuildingTypeDic_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass138_0_TypeInfo);
		    DAT_ram_00a5ad6b = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass138_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Func_ClanBuildingTypeDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass138_0__GetClanBuildingTypeDic_b__0__
		             ,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_FirstOrDefault_ClanBuildingTypeDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005EA0 RID: 24224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA0")]
		[Address(RVA = "0xAAF0", Offset = "0xAAF0", VA = "0xAAF0")]
		public static ClanBuildingTypeDic GetClanBuildingTypeDic(this Dictionaries dict, uint typeId)
		{
		/* --- GHIDRA: GetClanBuildingTypeDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetClanBuildingTypeDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad6c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_UIElementsDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_UIElementsDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass139_0__GetUIElementsDic_b__0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass139_0_TypeInfo);
		    DAT_ram_00a5ad6c = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass139_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x1c8);
		  uVar1 = unnamed_function_1417(System_Func_UIElementsDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass139_0__GetUIElementsDic_b__0__,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_UIElementsDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA1")]
		[Address(RVA = "0xAAF1", Offset = "0xAAF1", VA = "0xAAF1")]
		public static UIElementsDic GetUIElementsDic(this Dictionaries dict, UIElementsDic.Types.UIElementId elementId)
		{
		/* --- GHIDRA: GetUIElementsDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetUIElementsDic(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int param2_00;
		  
		  if (DAT_ram_00a5ad6d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_LocalNotificationDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_LocalNotificationDic__get_Item__);
		    DAT_ram_00a5ad6d = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x2b4) + 0xc);
		  if (0 < iVar2) {
		    param2_00 = 0;
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x2b4),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_LocalNotificationDic__get_Item__
		                        );
		      if ((ulonglong)*(uint *)(iVar1 + 0xc) == (longlong)param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA2")]
		[Address(RVA = "0xAAF2", Offset = "0xAAF2", VA = "0xAAF2")]
		public static LocalNotificationDic GetLocalNotificationDic(this Dictionaries dict, int id)
		{
		/* --- GHIDRA: GetLocalNotificationDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetLocalNotificationDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad6e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_LocalNotificationScheduleDic__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_LocalNotificationScheduleDic__get_Item__
		              );
		    DAT_ram_00a5ad6e = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x2b8) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x2b8),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_LocalNotificationScheduleDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA3")]
		[Address(RVA = "0xAAF3", Offset = "0xAAF3", VA = "0xAAF3")]
		public static LocalNotificationScheduleDic GetLocalNotificationScheduleDic(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetLocalNotificationScheduleDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetLocalNotificationScheduleDic
		          (int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad6f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_NotificationGroupDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_NotificationGroupDic__get_Item__);
		    DAT_ram_00a5ad6f = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x2b0) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x2b0),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_NotificationGroupDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA4")]
		[Address(RVA = "0xAAF4", Offset = "0xAAF4", VA = "0xAAF4")]
		public static NotificationGroupDic GetNotificationGroupDic(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetNotificationGroupDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetNotificationGroupDic(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad70 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_NotificationCategoryDic__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_NotificationCategoryDic__get_Item__
		              );
		    DAT_ram_00a5ad70 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x2ac) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x2ac),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_NotificationCategoryDic__get_Item__
		                        );
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA5")]
		[Address(RVA = "0xAAF5", Offset = "0xAAF5", VA = "0xAAF5")]
		public static NotificationCategoryDic GetNotificationCategoryDic(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetNotificationCategoryDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetNotificationCategoryDic
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5ad73 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_ClanRestrictionDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_ClanRestrictionDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__GetClanRestriction_b__146_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad73 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0xe8);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[0x1f];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_ClanRestrictionDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar1,
		               Method_Core_Extensions_Dict_DictExt___c__GetClanRestriction_b__146_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x7c) = param1_00;
		  }
		  uVar1 = func_ii_8597(&local_4,param1_00,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_ClanRestrictionDic__uint___)
		  ;
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA6")]
		[Address(RVA = "0x1DDB", Offset = "0x1DDB", VA = "0x1DDB")]
		public static DollSkillDic GetDollSkillDic(this Dictionaries dict, uint skillId)
		{
		/* --- GHIDRA: GetDollSkillDic ---
		undefined4 Core_Extensions_Dict_DictExt__GetDollSkillDic(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Core_Extensions_Dict_DictExt__GetAsset(*(undefined4 *)(param1 + 0x1c),0xac,0);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA7")]
		[Address(RVA = "0x2240", Offset = "0x2240", VA = "0x2240")]
		public static BattleBonusMedal GetBattleBonusMedal(this Dictionaries dict, uint medalId)
		{
		/* --- GHIDRA: GetBattleBonusMedal ---
		undefined4
		Core_Extensions_Dict_DictExt__GetBattleBonusMedal
		          (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  uint uVar11;
		  int iVar12;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a7a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_RestrictionInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RestrictionInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RestrictionInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_RestrictionInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21131);
		    DAT_ram_00a5a7a6 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_RestrictionInfo__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_RestrictionInfo___ctor__);
		  piVar7 = *(int **)(param1 + 0x18);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 + 0xd0);
		        goto code_r0x8126cd7c;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x8126cd7c:
		  uVar11 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  iVar8 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar4,StringLiteral_21131,0);
		  iVar12 = *param2;
		  if (*(ushort *)(iVar12 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_RestrictionInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar12 + 0x58) + uVar11 * 8)) {
		        puVar3 = (uint *)(iVar12 + *(int *)(*(int *)(iVar12 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8126ce0e;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar12 + 0xb6) != uVar11);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_RestrictionInfo__TypeInfo,0);
		code_r0x8126ce0e:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x8126ce38:
		  do {
		    do {
		      piVar7 = local_4;
		      iVar12 = *local_4;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar12 + 0x58) + uVar11 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar5 = (undefined4 *)(iVar12 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x8126cede;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar11);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar5 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8126cf22:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8126d1d6;
		      }
		code_r0x8126cede:
		      DAT_ram_009d3e38 = 0;
		      iVar12 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8126cf22;
		      if (iVar12 == 0) goto code_r0x8126d21f;
		      iVar12 = *local_4;
		      if (*(ushort *)(iVar12 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar12 + 0x58) + uVar11 * 8);
		          if (System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo == *piVar10) {
		            puVar5 = (undefined4 *)(iVar12 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x8126cfcd;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar12 + 0xb6) != uVar11);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar5 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_RestrictionInfo__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8126d127:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8126d1d6;
		      }
		code_r0x8126cfcd:
		      DAT_ram_009d3e38 = 0;
		      iVar12 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8126d127;
		      piVar7 = *(int **)(param1 + 0x18);
		      iVar9 = *piVar7;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar11 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8);
		          if (Core_Dict_IDictProvider_TypeInfo == *piVar10) {
		            puVar5 = (undefined4 *)(piVar10[1] * 8 + iVar9 + 0xd0);
		            goto code_r0x8126d0a3;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar5 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                          Core_Dict_IDictProvider_TypeInfo,2);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8126d131:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8126d1d6;
		      }
		code_r0x8126d0a3:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii(*puVar5,piVar7,puVar5[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8126d131;
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_0000223f + 4,uVar4,
		                         *(undefined4 *)(iVar12 + 0xc),0);
		      iVar1 = DAT_ram_009d3e38;
		      iVar9 = Method_System_Collections_Generic_List_RestrictionInfo__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8126d1d6;
		      }
		    } while ((ulonglong)*(uint *)(iVar6 + 0x10) == (longlong)iVar8);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar11 = *(uint *)(iVar2 + 0xc);
		    if (uVar11 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar11 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar11 * 4 + 0x10) = iVar12;
		      goto code_r0x8126ce38;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar12,
		               *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar12 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8126d1d6:
		  iVar8 = global_1;
		  iVar12 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar12) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_c = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x8126d21f:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_8;
		      if (piVar7 != (int *)0x0) {
		        uVar11 = 0;
		        iVar8 = *piVar7;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		              puVar3 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x8126d29a;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x8126d29a:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		      }
		      if (local_c != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar11 = 0;
		      piVar7 = *(int **)(param1 + 0x20);
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo ==
		              *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 + 0xd0);
		            goto code_r0x8126d323;
		          }
		          uVar11 = uVar11 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar7,
		                                    Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo
		                                    ,2);
		code_r0x8126d323:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,iVar2,param3,puVar3[1]);
		      return uVar4;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 5,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EA8")]
		[Address(RVA = "0xAAF6", Offset = "0xAAF6", VA = "0xAAF6")]
		public static ClanRestrictionDic GetClanRestriction(this Dictionaries dict, uint id)
		{
		/* --- GHIDRA: GetClanRestriction ---
		uint Core_Extensions_Dict_DictExt__GetClanRestriction
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5ad74 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_GameEventDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_GameEventDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__TryGetGameEventDic_b__147_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad74 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1 + 0x2d4);
		  if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		  iVar2 = puVar1[0x20];
		  if (iVar2 == 0) {
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		      puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    iVar2 = unnamed_function_1417(System_Func_GameEventDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,param2_00,
		               Method_Core_Extensions_Dict_DictExt___c__TryGetGameEventDic_b__147_0__,0);
		    *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x80) = iVar2;
		  }
		  iVar2 = func_ii_8597(&local_4,iVar2,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_GameEventDic__uint___);
		  *param3 = iVar2;
		  return (uint)(iVar2 != 0);
		}
		*/

			return null;
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		[Token(Token = "0x6005EA9")]
		[Address(RVA = "0xAAF7", Offset = "0xAAF7", VA = "0xAAF7")]
		public static bool TryGetGameEventDic(this Dictionaries dict, uint id, out GameEventDic evtDic)
		{
		/* --- GHIDRA: TryGetGameEventDic ---
		uint Core_Extensions_Dict_DictExt__TryGetGameEventDic
		               (int param1,longlong param2,int *param3,undefined4 param4)
		
		{
		  undefined4 *puVar1;
		  int iVar2;
		  undefined4 param2_00;
		  uint uVar3;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5ad75 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_ThemeDuelDic__ulong___);
		    Mono_Security_ASN1__get_Item(&System_Func_ThemeDuelDic__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__TryGetThemeDuelDic_b__148_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad75 = '\x01';
		  }
		  if (param2 == 0) {
		    *param3 = 0;
		    uVar3 = 0;
		  }
		  else {
		    local_4 = *(undefined4 *)(param1 + 0x2e4);
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		    }
		    puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    iVar2 = puVar1[0x21];
		    if (iVar2 == 0) {
		      if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		        puVar1 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar1;
		      iVar2 = unnamed_function_1417(System_Func_ThemeDuelDic__ulong__TypeInfo);
		      func_ii_7542(iVar2,param2_00,
		                   Method_Core_Extensions_Dict_DictExt___c__TryGetThemeDuelDic_b__148_0__,0);
		      *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x84) = iVar2;
		    }
		    iVar2 = Google_Protobuf_Reflection_DescriptorUtil__ConvertAndMakeReadOnly___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                      (&local_4,iVar2,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_ThemeDuelDic__ulong___);
		    *param3 = iVar2;
		    uVar3 = (uint)(iVar2 != 0);
		  }
		  return uVar3;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		[Token(Token = "0x6005EAA")]
		[Address(RVA = "0xAAF8", Offset = "0xAAF8", VA = "0xAAF8")]
		public static bool TryGetThemeDuelDic(this Dictionaries dict, ulong id, out ThemeDuelDic themeDuelDic)
		{
		/* --- GHIDRA: TryGetThemeDuelDic ---
		uint Core_Extensions_Dict_DictExt__TryGetThemeDuelDic
		               (int param1,longlong param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 param2_00;
		  undefined4 local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5ad76 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_AnnouncementsDic__ulong___);
		    Mono_Security_ASN1__get_Item(&System_Func_AnnouncementsDic__ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__TryGetAnnouncementsDic_b__149_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad76 = '\x01';
		  }
		  *param3 = 0;
		  if (param2 != 0) {
		    local_4 = *(undefined4 *)(param1 + 0x300);
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    iVar3 = puVar2[0x22];
		    if (iVar3 == 0) {
		      if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		        puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar2;
		      iVar3 = unnamed_function_1417(System_Func_AnnouncementsDic__ulong__TypeInfo);
		      func_ii_7542(iVar3,param2_00,
		                   Method_Core_Extensions_Dict_DictExt___c__TryGetAnnouncementsDic_b__149_0__,0);
		      *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x88) = iVar3;
		    }
		    iVar3 = Google_Protobuf_Reflection_DescriptorUtil__ConvertAndMakeReadOnly___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                      (&local_4,iVar3,param2,
		                       Method_Core_Extensions_Dict_DictExt_BinarySearch_AnnouncementsDic__ulong___);
		    *param3 = iVar3;
		    uVar1 = (uint)(iVar3 != 0);
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x00011010 File Offset: 0x0000F210
		[Token(Token = "0x6005EAB")]
		[Address(RVA = "0xAAF9", Offset = "0xAAF9", VA = "0xAAF9")]
		public static bool TryGetAnnouncementsDic(this Dictionaries dict, ulong id, out AnnouncementsDic result)
		{
		/* --- GHIDRA: TryGetAnnouncementsDic ---
		uint Core_Extensions_Dict_DictExt__TryGetAnnouncementsDic
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 param2_00;
		  undefined4 local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5ad77 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_CompetitionDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_CompetitionDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__TryGetCompetitionDic_b__150_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad77 = '\x01';
		  }
		  *param3 = 0;
		  if (param2 != 0) {
		    local_4 = *(undefined4 *)(param1 + 0x304);
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    iVar3 = puVar2[0x23];
		    if (iVar3 == 0) {
		      if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		        puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar2;
		      iVar3 = unnamed_function_1417(System_Func_CompetitionDic__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (iVar3,param2_00,
		                 Method_Core_Extensions_Dict_DictExt___c__TryGetCompetitionDic_b__150_0__,0);
		      *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x8c) = iVar3;
		    }
		    iVar3 = func_ii_8597(&local_4,iVar3,param2,
		                         Method_Core_Extensions_Dict_DictExt_BinarySearch_CompetitionDic__uint___);
		    *param3 = iVar3;
		    uVar1 = (uint)(iVar3 != 0);
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x00011028 File Offset: 0x0000F228
		[Token(Token = "0x6005EAC")]
		[Address(RVA = "0xAAFA", Offset = "0xAAFA", VA = "0xAAFA")]
		public static bool TryGetCompetitionDic(this Dictionaries dict, uint id, out CompetitionDic result)
		{
		/* --- GHIDRA: TryGetCompetitionDic ---
		uint Core_Extensions_Dict_DictExt__TryGetCompetitionDic
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 param2_00;
		  undefined4 local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5ad78 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt_BinarySearch_CompetitionRatingKindDic__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_CompetitionRatingKindDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__TryGetCompetitionRatingKindDic_b__151_0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad78 = '\x01';
		  }
		  *param3 = 0;
		  if (param2 != 0) {
		    local_4 = *(undefined4 *)(param1 + 0x308);
		    if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		    iVar3 = puVar2[0x24];
		    if (iVar3 == 0) {
		      if (*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Extensions_Dict_DictExt___c_TypeInfo);
		        puVar2 = *(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar2;
		      iVar3 = unnamed_function_1417(System_Func_CompetitionRatingKindDic__uint__TypeInfo);
		      System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                (iVar3,param2_00,
		                 Method_Core_Extensions_Dict_DictExt___c__TryGetCompetitionRatingKindDic_b__151_0__,
		                 0);
		      *(int *)(*(int *)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) + 0x90) = iVar3;
		    }
		    iVar3 = func_ii_8597(&local_4,iVar3,param2,
		                         Method_Core_Extensions_Dict_DictExt_BinarySearch_CompetitionRatingKindDic__uint___
		                        );
		    *param3 = iVar3;
		    uVar1 = (uint)(iVar3 != 0);
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x00011040 File Offset: 0x0000F240
		[Token(Token = "0x6005EAD")]
		[Address(RVA = "0xAAFB", Offset = "0xAAFB", VA = "0xAAFB")]
		public static bool TryGetCompetitionRatingKindDic(this Dictionaries dict, uint id, out CompetitionRatingKindDic result)
		{
		/* --- GHIDRA: TryGetCompetitionRatingKindDic ---
		undefined4
		Core_Extensions_Dict_DictExt__TryGetCompetitionRatingKindDic
		          (int param1,undefined8 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad7b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_Fresco_Types_GroupsDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_Fresco_Types_GroupsDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass154_0__GetFrescoGroupDic_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass154_0_TypeInfo);
		    DAT_ram_00a5ad7b = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass154_0_TypeInfo);
		  *(undefined8 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x32c);
		  uVar1 = unnamed_function_1417(System_Func_Fresco_Types_GroupsDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass154_0__GetFrescoGroupDic_b__0__,0)
		  ;
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_FirstOrDefault_Fresco_Types_GroupsDic___);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x00011058 File Offset: 0x0000F258
		[Token(Token = "0x6005EAE")]
		[Address(RVA = "0x1D18", Offset = "0x1D18", VA = "0x1D18")]
		public static bool TryGetAntiqArtifact(this Dictionaries dicts, ulong id, out Antiq.Types.ArtifactsDic result)
		{
		/* --- GHIDRA: TryGetAntiqArtifact ---
		void Core_Extensions_Dict_DictExt__TryGetAntiqArtifact
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a594a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EffectData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_EffectData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_ObjectModel_ReadOnlyCollection_EffectData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_ObjectModel_ReadOnlyCollection_EffectData__TypeInfo);
		    DAT_ram_00a594a1 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_EffectData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_EffectData___ctor__);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 0x14) = param2;
		  param2_00 = *(undefined4 *)(param1 + 8);
		  uVar1 = unnamed_function_1417
		                    (System_Collections_ObjectModel_ReadOnlyCollection_EffectData__TypeInfo);
		  System_Runtime_CompilerServices_ReadOnlyCollectionBuilder___Il2CppFullySharedGenericType___set_Item
		            (uVar1,param2_00,
		             Method_System_Collections_ObjectModel_ReadOnlyCollection_EffectData___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x00011070 File Offset: 0x0000F270
		[Token(Token = "0x6005EAF")]
		[Address(RVA = "0x2A42", Offset = "0x2A42", VA = "0x2A42")]
		public static bool TryGetAntiqEffect(this Dictionaries dicts, ulong id, out Antiq.Types.EffectsDic result)
		{
		/* --- GHIDRA: TryGetAntiqEffect ---
		undefined4 Core_Extensions_Dict_DictExt__TryGetAntiqEffect(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = Core_Extensions_Dict_DictExt__GetApr(*(undefined4 *)(param1 + 0x24),0xe7,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EB0")]
		[Address(RVA = "0xAAFC", Offset = "0xAAFC", VA = "0xAAFC")]
		public static Fresco.Types.GroupsDic GetFrescoGroupDic(this Dictionaries dict, ulong frescoGroupId)
		{
		/* --- GHIDRA: GetFrescoGroupDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetFrescoGroupDic(int param1,undefined8 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad7c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_Fresco_Types_FrescoDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_Fresco_Types_FrescoDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_Dict_DictExt___c__DisplayClass155_0__GetFrescoDic_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass155_0_TypeInfo);
		    DAT_ram_00a5ad7c = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass155_0_TypeInfo);
		  *(undefined8 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x330);
		  uVar1 = unnamed_function_1417(System_Func_Fresco_Types_FrescoDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass155_0__GetFrescoDic_b__0__,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_FirstOrDefault_Fresco_Types_FrescoDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EB1")]
		[Address(RVA = "0xAAFD", Offset = "0xAAFD", VA = "0xAAFD")]
		public static Fresco.Types.FrescoDic GetFrescoDic(this Dictionaries dict, ulong frescoId)
		{
		/* --- GHIDRA: GetFrescoDic ---
		undefined4
		Core_Extensions_Dict_DictExt__GetFrescoDic(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5ad7d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_RegularOptionsDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_RegularOptionsDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Extensions_Dict_DictExt___c__DisplayClass156_0__GetRegularOptionsDic_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c__DisplayClass156_0_TypeInfo);
		    DAT_ram_00a5ad7d = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c__DisplayClass156_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x334);
		  uVar1 = unnamed_function_1417(System_Func_RegularOptionsDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Core_Extensions_Dict_DictExt___c__DisplayClass156_0__GetRegularOptionsDic_b__0__
		             ,0);
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_Where_RegularOptionsDic___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005EB2")]
		[Address(RVA = "0xAAFE", Offset = "0xAAFE", VA = "0xAAFE")]
		public static IEnumerable<RegularOptionsDic> GetRegularOptionsDic(this Dictionaries dict, RegularOptionsDic.Types.Kind kindId)
		{
		/* --- GHIDRA: GetRegularOptionsDic ---
		void Core_Extensions_Dict_DictExt__GetRegularOptionsDic(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5ad7e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_DictExt___c_TypeInfo);
		    DAT_ram_00a5ad7e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Extensions_Dict_DictExt___c_TypeInfo);
		  **(undefined4 **)(Core_Extensions_Dict_DictExt___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: BinarySearch<object, uint> ---
		void Core_Extensions_Dict_DictExt__BinarySearch_object__uint_
		               (int param1,float param2,undefined4 param3)
		
		{
		  float fVar1;
		  
		  *(float *)(param1 + 8) = param2;
		  fVar1 = UnityEngine_Time__get_timeScale(0);
		  *(float *)(param1 + 0xc) = fVar1 + param2;
		  return;
		}
		*/


		/* --- GHIDRA: BinarySearch<object, ulong> ---
		/* WARNING: Type propagation algorithm not settling */
		
		undefined4
		Core_Extensions_Dict_DictExt__BinarySearch_object__ulong_
		          (undefined4 *param1,undefined4 param2,undefined4 *******param3,int param4)
		
		{
		  ushort uVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int param3_00;
		  int param2_00;
		  int *piVar10;
		  int iVar11;
		  undefined4 *puVar12;
		  int iVar13;
		  uint uVar14;
		  int iVar15;
		  undefined4 *******pppppppuVar16;
		  int iVar17;
		  int iVar18;
		  int *piVar19;
		  undefined4 *******local_10;
		  int local_c;
		  int local_8;
		  byte local_4;
		  
		  iVar17 = 0;
		  iVar8 = *(int *)(param4 + 0x1c);
		  local_10 = param3;
		  if (iVar8 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		    iVar8 = *(int *)(param4 + 0x1c);
		  }
		  iVar9 = *(int *)(iVar8 + 0x20);
		  param3_00 = *(int *)(iVar9 + 0x84);
		  uVar1 = *(ushort *)(iVar9 + 0xbd);
		  iVar3 = param3_00;
		  if ((uVar1 & 1) == 0) {
		    iVar3 = func_ii_1079(iVar9);
		    iVar8 = *(int *)(param4 + 0x1c);
		    iVar9 = *(int *)(iVar8 + 0x20);
		    uVar1 = *(ushort *)(iVar9 + 0xbd);
		    iVar3 = *(int *)(iVar3 + 0x84);
		  }
		  iVar3 = (int)&local_10 - (iVar3 + 0x17U & 0xfffffff0);
		  if ((uVar1 & 1) == 0) {
		    iVar9 = func_ii_1079(iVar9);
		    iVar8 = *(int *)(param4 + 0x1c);
		  }
		  iVar9 = iVar3 - (*(int *)(iVar9 + 0x84) + 0x17U & 0xfffffff0);
		  uVar14 = param3_00 + 0xfU & 0xfffffff0;
		  param2_00 = iVar9 - uVar14;
		  param1_00 = unnamed_function_714((param2_00 - uVar14) - uVar14,0,param3_00);
		  piVar10 = (int *)*param1;
		  iVar8 = *(int *)(iVar8 + 4);
		  if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		    iVar8 = func_ii_1079(iVar8);
		  }
		  iVar11 = *piVar10;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (iVar8 == *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x813a4656;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar10,iVar8,0);
		code_r0x813a4656:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar10,puVar4[1]);
		  iVar8 = iVar8 + -1;
		  if (-1 < iVar8) {
		code_r0x813a4679:
		    do {
		      piVar10 = (int *)*param1;
		      iVar11 = *(int *)(*(int *)(param4 + 0x1c) + 0xc);
		      if ((*(byte *)(iVar11 + 0xbd) & 1) == 0) {
		        iVar11 = func_ii_1079(iVar11);
		      }
		      iVar15 = (iVar8 - iVar17) / 2 + iVar17;
		      iVar18 = *piVar10;
		      if (*(ushort *)(iVar18 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar19 = (int *)(*(int *)(iVar18 + 0x58) + uVar2 * 8);
		          if (iVar11 == *piVar19) {
		            puVar4 = (uint *)(iVar18 + piVar19[1] * 8 + 0xc0);
		            goto code_r0x813a470e;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar18 + 0xb6) != uVar2);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar10,iVar11,0);
		code_r0x813a470e:
		      iVar11 = (**(code **)((ulonglong)*puVar4 * 4))(piVar10,iVar15,puVar4[1]);
		      puVar12 = *(undefined4 **)(*(int *)(param4 + 0x1c) + 0x1c);
		      local_c = iVar11;
		      local_8 = param2_00;
		      (**(code **)((ulonglong)(uint)puVar12[2] * 4))(*puVar12,puVar12,param2,&local_c,param2_00);
		      uVar5 = unnamed_function_713(param1_00,param2_00,param3_00);
		      piVar10 = (int *)(*(int *)(param4 + 0x1c) + 0x20);
		      pppppppuVar16 = param3;
		      if (-1 < *(int *)(*piVar10 + 0x14)) {
		        pppppppuVar16 = &local_10;
		      }
		      uVar6 = unnamed_function_713(param2_00 - uVar14,pppppppuVar16,param3_00);
		      iVar7 = func_ii_1081(*piVar10,uVar6);
		      iVar13 = *(int *)(param4 + 0x1c);
		      iVar18 = *(int *)(iVar13 + 0x20);
		      if ((*(byte *)(iVar18 + 0xbd) & 1) == 0) {
		        iVar18 = func_ii_1079(iVar18);
		        iVar13 = *(int *)(param4 + 0x1c);
		      }
		      local_c = iVar7;
		      func_ii_8296(iVar18,*(undefined4 *)(iVar13 + 0x24),iVar3,uVar5,&local_c,&local_4);
		      if (local_4 != 0) {
		        return iVar11;
		      }
		      puVar12 = *(undefined4 **)(*(int *)(param4 + 0x1c) + 0x1c);
		      local_c = iVar11;
		      local_8 = param2_00;
		      (**(code **)((ulonglong)(uint)puVar12[2] * 4))(*puVar12,puVar12,param2,&local_c,param2_00);
		      uVar5 = unnamed_function_713(uVar5,param2_00,param3_00);
		      piVar10 = (int *)(*(int *)(param4 + 0x1c) + 0x20);
		      pppppppuVar16 = param3;
		      if (-1 < *(int *)(*piVar10 + 0x14)) {
		        pppppppuVar16 = &local_10;
		      }
		      uVar6 = unnamed_function_713(uVar6,pppppppuVar16,param3_00);
		      uVar6 = func_ii_1081(*piVar10,uVar6);
		      iVar18 = *(int *)(param4 + 0x1c);
		      iVar11 = *(int *)(iVar18 + 0x20);
		      if ((*(byte *)(iVar11 + 0xbd) & 1) == 0) {
		        iVar11 = func_ii_1079(iVar11);
		        iVar18 = *(int *)(param4 + 0x1c);
		      }
		      _local_4 = uVar6;
		      func_ii_8296(iVar11,*(undefined4 *)(iVar18 + 0x28),iVar9,uVar5,&local_4,&local_c);
		      if (0 < local_c) {
		        iVar8 = iVar15 + -1;
		        if (iVar8 < iVar17) {
		          return 0;
		        }
		        goto code_r0x813a4679;
		      }
		      iVar17 = iVar15 + 1;
		    } while (iVar17 <= iVar8);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: BinarySearch<object, __Il2CppFullySharedGenericType> ---
		undefined4
		Core_Extensions_Dict_DictExt__BinarySearch_object____Il2CppFullySharedGenericType_
		          (undefined4 param1,undefined4 param2,int param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int param1_01;
		  
		  if (*(int *)(param3 + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param3);
		  }
		  uVar1 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(param1,param2,0);
		  param1_01 = **(int **)(param3 + 0x1c);
		  if ((*(byte *)(param1_01 + 0xbd) & 1) == 0) {
		    param1_01 = func_ii_1079(param1_01);
		  }
		  param1_00 = (int *)unnamed_function_1417(param1_01);
		  Core_ExternAppMethods__GetAdSources(param1_00,*(undefined4 *)(*(int *)(param3 + 0x1c) + 4));
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe0) * 4))
		                    (param1_00,uVar1,*(undefined4 *)(*param1_00 + 0xe4));
		  return uVar1;
		}
		*/

}
