using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Requirements
{
	// Token: 0x02001197 RID: 4503
	[Token(Token = "0x2001197")]
	public class RequirementsManager : IGameManager, IBaseManager, IRequirementValidator
	{
		// Token: 0x140002BA RID: 698
		// (add) Token: 0x06006AFE RID: 27390 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006AFF RID: 27391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002BA")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006AFE")]
			[Address(RVA = "0xB605", Offset = "0xB605", VA = "0xB605", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006AFF")]
			[Address(RVA = "0xB606", Offset = "0xB606", VA = "0xB606", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002BB RID: 699
		// (add) Token: 0x06006B00 RID: 27392 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006B01 RID: 27393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002BB")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006B00")]
			[Address(RVA = "0xB607", Offset = "0xB607", VA = "0xB607", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006B01")]
			[Address(RVA = "0xB608", Offset = "0xB608", VA = "0xB608", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06006B02 RID: 27394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015DA")]
		public string Name
		{
			[Token(Token = "0x6006B02")]
			[Address(RVA = "0xB609", Offset = "0xB609", VA = "0xB609", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006B03 RID: 27395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B03")]
		[Address(RVA = "0xB60A", Offset = "0xB60A", VA = "0xB60A", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Requirements_RequirementsManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  *(undefined4 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B04")]
		[Address(RVA = "0xB60B", Offset = "0xB60B", VA = "0xB60B", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4
		Core_Gameplay_Managers_Requirements_RequirementsManager__Deinit
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0x14),0);
		  uVar1 = Core_Extensions_Dict_DictExt__GetStringParameter(uVar1,param2,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006B05 RID: 27397 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006B05")]
		[Address(RVA = "0xB60C", Offset = "0xB60C", VA = "0xB60C")]
		public RequirementDic GetRequirementDic(uint requirementId)
		{
		/* --- GHIDRA: GetRequirementDic ---
		uint Core_Gameplay_Managers_Requirements_RequirementsManager__GetRequirementDic
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  uint uVar3;
		  int iVar4;
		  uint uVar5;
		  int param1_01;
		  
		  param1_00 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                        (*(undefined4 *)(param1 + 0x14),0);
		  iVar2 = Core_Extensions_Dict_DictExt__GetStringParameter(param1_00,param2,0);
		  uVar3 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckMaterials
		                    (param1,*(undefined4 *)(iVar2 + 0x14),param3,param1);
		  uVar1 = 1;
		  param1_01 = *(int *)(iVar2 + 0x10);
		  if (((param1_01 != 0) && (*(int *)(param1 + 0x10) == param3)) &&
		     (iVar4 = Core_Extensions_Dict_ResourceSetExt__GetDelta(param1_01,0), iVar4 == 0)) {
		    uVar1 = Core_Extensions_Dict_ResourceSetExt__IsZero
		                      (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x78),param1_01,0);
		  }
		  uVar5 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                    (param1,*(undefined4 *)(iVar2 + 0x18),param3,param1);
		  return uVar5 & uVar1 & uVar3;
		}
		*/

			return null;
		}

		// Token: 0x06006B06 RID: 27398 RVA: 0x00013B90 File Offset: 0x00011D90
		[Token(Token = "0x6006B06")]
		[Address(RVA = "0xB60D", Offset = "0xB60D", VA = "0xB60D", Slot = "11")]
		public bool Check(uint requirementId, UserData user)
		{
		/* --- GHIDRA: Check ---
		undefined4
		Core_Gameplay_Managers_Requirements_RequirementsManager__Check
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0x14),0);
		  iVar2 = Core_Extensions_Dict_DictExt__GetStringParameter(uVar1,param2,0);
		  uVar1 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                    (param1,*(undefined4 *)(iVar2 + 0x18),param3,param1);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006B07 RID: 27399 RVA: 0x00013BA8 File Offset: 0x00011DA8
		[Token(Token = "0x6006B07")]
		[Address(RVA = "0xB60E", Offset = "0xB60E", VA = "0xB60E", Slot = "12")]
		public bool CheckRestrictions(uint requirementId, UserData user)
		{
		/* --- GHIDRA: CheckRestrictions ---
		uint Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestrictions
		               (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  longlong lVar3;
		  
		  lVar1 = *(longlong *)(param3 + 0x10);
		  lVar2 = *(longlong *)(param2 + 0x18);
		  lVar3 = *(longlong *)(param2 + 0x10);
		  if (lVar3 != 0) {
		    if (lVar2 != 0) {
		      return (uint)(lVar1 <= lVar2 && lVar3 <= lVar1);
		    }
		    return (uint)(lVar3 <= lVar1);
		  }
		  if (lVar2 == 0) {
		    return (uint)(lVar1 == 0);
		  }
		  return (uint)(lVar1 <= lVar2);
		}
		*/

		/* --- GHIDRA: CheckRestrictions ---
		uint Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestrictions
		               (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  longlong lVar1;
		  longlong lVar2;
		  longlong lVar3;
		  
		  lVar1 = *(longlong *)(param3 + 0x10);
		  lVar2 = *(longlong *)(param2 + 0x18);
		  lVar3 = *(longlong *)(param2 + 0x10);
		  if (lVar3 != 0) {
		    if (lVar2 != 0) {
		      return (uint)(lVar1 <= lVar2 && lVar3 <= lVar1);
		    }
		    return (uint)(lVar3 <= lVar1);
		  }
		  if (lVar2 == 0) {
		    return (uint)(lVar1 == 0);
		  }
		  return (uint)(lVar1 <= lVar2);
		}
		*/

			return default(bool);
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x00013BC0 File Offset: 0x00011DC0
		[Token(Token = "0x6006B08")]
		[Address(RVA = "0xB60F", Offset = "0xB60F", VA = "0xB60F", Slot = "14")]
		public bool CheckRestriction(RestrictionInfo restrictionInfo, TriggerValue triggerValue)
		{
		/* --- GHIDRA: CheckRestriction ---
		uint Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		               (undefined4 param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint *puVar1;
		  int *piVar2;
		  uint uVar3;
		  int iVar4;
		  longlong lVar5;
		  longlong lVar6;
		  longlong lVar7;
		  int iVar8;
		  int iVar9;
		  int local_4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a5a63c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_RestrictionInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_RestrictionInfo__TypeInfo);
		    DAT_ram_00a5a63c = '\x01';
		  }
		  local_4 = 0;
		  iVar8 = *param2;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_RestrictionInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8)) {
		        puVar1 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar3 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81248b23;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar3);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_RestrictionInfo__TypeInfo,0);
		code_r0x81248b23:
		  iVar8 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  if (iVar8 == 0) {
		    uVar3 = 1;
		  }
		  else {
		    do {
		      iVar9 = *param2;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar3 = 0;
		        do {
		          piVar2 = (int *)(*(int *)(iVar9 + 0x58) + uVar3 * 8);
		          if (System_Collections_Generic_IList_RestrictionInfo__TypeInfo == *piVar2) {
		            puVar1 = (uint *)(iVar9 + piVar2[1] * 8 + 0xc0);
		            goto code_r0x81248bab;
		          }
		          uVar3 = uVar3 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar3);
		      }
		      puVar1 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IList_RestrictionInfo__TypeInfo,0);
		code_r0x81248bab:
		      iVar9 = (**(code **)((ulonglong)*puVar1 * 4))(param2,iVar4,puVar1[1]);
		      piVar2 = (int *)Core_Gameplay_Managers_UserManager__get_User(param3,0);
		      (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                (piVar2,*(undefined4 *)(iVar9 + 0xc),&local_4,*(undefined4 *)(*piVar2 + 0x104));
		      lVar5 = *(longlong *)(iVar9 + 0x18);
		      lVar6 = *(longlong *)(local_4 + 0x10);
		      lVar7 = *(longlong *)(iVar9 + 0x10);
		      if (lVar7 == 0) {
		        if (lVar5 == 0) {
		          uVar3 = (uint)(lVar6 == 0);
		        }
		        else {
		          uVar3 = (uint)(lVar6 <= lVar5);
		        }
		      }
		      else if (lVar5 == 0) {
		        uVar3 = (uint)(lVar7 <= lVar6);
		      }
		      else {
		        uVar3 = (uint)(lVar6 <= lVar5 && lVar7 <= lVar6);
		      }
		      iVar4 = iVar4 + 1;
		    } while ((iVar4 < iVar8) && (uVar3 != 0));
		  }
		  return uVar3;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006B09 RID: 27401 RVA: 0x00013BD8 File Offset: 0x00011DD8
		[Token(Token = "0x6006B09")]
		[Address(RVA = "0xB610", Offset = "0xB610", VA = "0xB610", Slot = "13")]
		public bool CheckRestrictions(IList<RestrictionInfo> restrictionsInfo, UserData user)
		{
			return default(bool);
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x00013BF0 File Offset: 0x00011DF0
		[Token(Token = "0x6006B0A")]
		[Address(RVA = "0xB611", Offset = "0xB611", VA = "0xB611", Slot = "15")]
		public bool CheckPrice(ResourceSet price, UserData user)
		{
		/* --- GHIDRA: CheckPrice ---
		undefined4
		Core_Gameplay_Managers_Requirements_RequirementsManager__CheckPrice
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0x14),0);
		  iVar2 = Core_Extensions_Dict_DictExt__GetStringParameter(uVar1,param2,0);
		  uVar1 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckMaterials
		                    (param1,*(undefined4 *)(iVar2 + 0x14),param3,param1);
		  return uVar1;
		}
		*/

		/* --- GHIDRA: CheckPrice ---
		undefined4
		Core_Gameplay_Managers_Requirements_RequirementsManager__CheckPrice
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0x14),0);
		  iVar2 = Core_Extensions_Dict_DictExt__GetStringParameter(uVar1,param2,0);
		  uVar1 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckMaterials
		                    (param1,*(undefined4 *)(iVar2 + 0x14),param3,param1);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x00013C08 File Offset: 0x00011E08
		[Token(Token = "0x6006B0B")]
		[Address(RVA = "0xB612", Offset = "0xB612", VA = "0xB612", Slot = "16")]
		public bool CheckPrice(uint requirementId, UserData user)
		{
			return default(bool);
		}

		// Token: 0x06006B0C RID: 27404 RVA: 0x00013C20 File Offset: 0x00011E20
		[Token(Token = "0x6006B0C")]
		[Address(RVA = "0xB613", Offset = "0xB613", VA = "0xB613", Slot = "17")]
		public bool CheckMaterials(uint requirementId, UserData user)
		{
		/* --- GHIDRA: CheckMaterials ---
		undefined4
		Core_Gameplay_Managers_Requirements_RequirementsManager__CheckMaterials
		          (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param2_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a63e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a5a63e = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == param3) {
		    uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                      (*(undefined4 *)(param1 + 0x14),0);
		    iVar3 = Core_Extensions_Dict_DictExt__GetStringParameter(uVar2,param2,0);
		    uVar2 = Core_Extensions_Dict_ResourceSetExt__Multiply
		                      (*(undefined4 *)(param3 + 0x78),*(undefined4 *)(iVar3 + 0x10),0);
		    param2_00 = Core_Gameplay_Managers_Requirements_RequirementsManager__GetMaxQuotient
		                          (param1,*(undefined4 *)(iVar3 + 0x14),param3,param3);
		    iVar3 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                      (param3,*(undefined4 *)(iVar3 + 0x18),param3,param3);
		    if (iVar3 != 0) {
		      if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Math_TypeInfo);
		      }
		      uVar1 = System_Data_Common_DataStorage__HasValue(uVar2,param2_00,0);
		    }
		  }
		  return uVar1;
		}
		*/

		/* --- GHIDRA: CheckMaterials ---
		undefined4
		Core_Gameplay_Managers_Requirements_RequirementsManager__CheckMaterials
		          (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param2_00;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5a63e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a5a63e = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) == param3) {
		    uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                      (*(undefined4 *)(param1 + 0x14),0);
		    iVar3 = Core_Extensions_Dict_DictExt__GetStringParameter(uVar2,param2,0);
		    uVar2 = Core_Extensions_Dict_ResourceSetExt__Multiply
		                      (*(undefined4 *)(param3 + 0x78),*(undefined4 *)(iVar3 + 0x10),0);
		    param2_00 = Core_Gameplay_Managers_Requirements_RequirementsManager__GetMaxQuotient
		                          (param1,*(undefined4 *)(iVar3 + 0x14),param3,param3);
		    iVar3 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                      (param3,*(undefined4 *)(iVar3 + 0x18),param3,param3);
		    if (iVar3 != 0) {
		      if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Math_TypeInfo);
		      }
		      uVar1 = System_Data_Common_DataStorage__HasValue(uVar2,param2_00,0);
		    }
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x00013C38 File Offset: 0x00011E38
		[Token(Token = "0x6006B0D")]
		[Address(RVA = "0xB614", Offset = "0xB614", VA = "0xB614", Slot = "18")]
		public bool CheckMaterials(RepeatedField<RewardInfo> materials, UserData user)
		{
			return default(bool);
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x00013C50 File Offset: 0x00011E50
		[Token(Token = "0x6006B0E")]
		[Address(RVA = "0xB615", Offset = "0xB615", VA = "0xB615")]
		public uint GetMaxQuotient(uint requirementId, UserData user)
		{
		/* --- GHIDRA: GetMaxQuotient ---
		undefined4
		Core_Gameplay_Managers_Requirements_RequirementsManager__GetMaxQuotient
		          (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  uint uVar6;
		  uint param2_01;
		  int iVar7;
		  int iVar8;
		  int *param1_00;
		  undefined4 param1_01;
		  int iVar9;
		  undefined4 uVar10;
		  int param2_02;
		  int *piVar11;
		  
		  param2_02 = 0;
		  if (DAT_ram_00a5a63f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_SingleOrDefault_MedalInfo___);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalInfo__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Requirements_RequirementsManager___c__DisplayClass22_0__GetMaterialsMaxQuotient_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Requirements_RequirementsManager___c__DisplayClass22_0_TypeInfo
		              );
		    DAT_ram_00a5a63f = '\x01';
		  }
		  iVar8 = *(int *)(param2 + 0xc);
		  if (iVar8 < 1) {
		    return 0x7fffffff;
		  }
		  uVar3 = 0x7fffffff;
		  do {
		    iVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (param2,param2_02,
		                       Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__get_Item__);
		    if ((*(int *)(param1 + 0x10) == param3) && (*(int *)(iVar4 + 0xc) == 0xc)) {
		      param2_00 = 0;
		      iVar1 = *(int *)(*(int *)(iVar4 + 0x10) + 0xc);
		      if (0 < iVar1) {
		        do {
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar2 = *param1_00;
		          if (*(ushort *)(iVar2 + 0xb6) != 0) {
		            uVar6 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar2 + 0x58) + uVar6 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar11) {
		                puVar5 = (uint *)(piVar11[1] * 8 + iVar2 + 0x120);
		                goto code_r0x81248f62;
		              }
		              uVar6 = uVar6 + 1;
		            } while (*(ushort *)(iVar2 + 0xb6) != uVar6);
		          }
		          puVar5 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x81248f62:
		          iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(param1_00,puVar5[1]);
		          param1_01 = *(undefined4 *)(iVar2 + 0x10);
		          uVar10 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                             (*(undefined4 *)(iVar4 + 0x10),param2_00,
		                              Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		          uVar6 = Core_Gameplay_Managers_Skins_SkinManager__PlanePackage(param1_01,uVar10,0);
		          param2_01 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                                (*(undefined4 *)(iVar4 + 0x10),param2_00 | 1,
		                                 Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		          if (uVar6 < param2_01) {
		            return 0;
		          }
		          uVar10 = UnitySourceGeneratedAssemblyMonoScriptTypes_v1___ctor(uVar6,param2_01,0);
		          if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		            func_ii_306000(System_Math_TypeInfo);
		          }
		          uVar3 = System_Data_Common_DataStorage__HasValue(uVar10,uVar3,0);
		          param2_00 = param2_00 + 2;
		        } while ((int)param2_00 < iVar1);
		      }
		    }
		    else if (*(int *)(iVar4 + 0xc) == 0x6e) {
		      iVar2 = 0;
		      iVar1 = 0;
		      iVar9 = *(int *)(*(int *)(iVar4 + 0x10) + 0xc);
		      if (0 < iVar9) {
		        do {
		          iVar7 = unnamed_function_1417
		                            (
		                            Core_Gameplay_Managers_Requirements_RequirementsManager___c__DisplayClass22_0_TypeInfo
		                            );
		          uVar3 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                            (*(undefined4 *)(iVar4 + 0x10),iVar1,
		                             Method_Google_Protobuf_Collections_RepeatedField_uint__get_Item__);
		          *(undefined4 *)(iVar7 + 8) = uVar3;
		          uVar10 = *(undefined4 *)(param3 + 0x40);
		          uVar3 = unnamed_function_1417(System_Func_MedalInfo__bool__TypeInfo);
		          System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                    (uVar3,iVar7,
		                     Method_Core_Gameplay_Managers_Requirements_RequirementsManager___c__DisplayClass22_0__GetMaterialsMaxQuotient_b__0__
		                     ,0);
		          iVar7 = UI_SimpleIconValue__set_Value
		                            (uVar10,uVar3,Method_System_Linq_Enumerable_SingleOrDefault_MedalInfo___
		                            );
		          iVar2 = iVar2 + (uint)(iVar7 != 0);
		          iVar1 = iVar1 + 1;
		        } while (iVar1 != iVar9);
		      }
		      uVar3 = 1;
		      if (iVar9 != iVar2) {
		        return 0;
		      }
		    }
		    param2_02 = param2_02 + 1;
		    if (param2_02 == iVar8) {
		      return uVar3;
		    }
		  } while( true );
		}
		*/

			return 0U;
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x00013C68 File Offset: 0x00011E68
		[Token(Token = "0x6006B0F")]
		[Address(RVA = "0xB616", Offset = "0xB616", VA = "0xB616")]
		public uint GetMaterialsMaxQuotient(RepeatedField<RewardInfo> materials, UserData user)
		{
			return 0U;
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B10")]
		[Address(RVA = "0xB617", Offset = "0xB617", VA = "0xB617")]
		public RequirementsManager()
		{
		}

		// Token: 0x04003896 RID: 14486
		[Token(Token = "0x4003896")]
		[FieldOffset(Offset = "0x10")]
		private UserData _loggedUser;

		// Token: 0x04003897 RID: 14487
		[Token(Token = "0x4003897")]
		[FieldOffset(Offset = "0x14")]
		private DictManager _dictManager;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_Requirements_RequirementsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a637 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a637 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_Requirements_RequirementsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a638 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a638 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_Requirements_RequirementsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a639 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a639 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		undefined4
		Core_Gameplay_Managers_Requirements_RequirementsManager__remove_DeinitCompleteEvent
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a63a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_13564);
		    DAT_ram_00a5a63a = '\x01';
		  }
		  return StringLiteral_13564;
		}
		*/


		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_Requirements_RequirementsManager__get_Name(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a63b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a63b = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x81248683;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81248683:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x81248738;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81248738:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  *(undefined4 *)(param1 + 0x14) = uVar3;
		  iVar5 = *(int *)(param1 + 8);
		  if (iVar5 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),param1,*(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

}
