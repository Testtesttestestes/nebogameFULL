using System;
using System.Collections.Generic;
using Gameplay.GameEvents.Model.Tags.Factories;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GameEvents.Model.Tags.Repo
{
	// Token: 0x020007BE RID: 1982
	[Token(Token = "0x20007BE")]
	public class MetaTagFactoriesRepository : IMetaTagFactoriesRepository, IDisposable
	{
		// Token: 0x06002EC1 RID: 11969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC1")]
		[Address(RVA = "0x7F39", Offset = "0x7F39", VA = "0x7F39")]
		public void Add(IMetaTagFactory factory)
		{
		/* --- GHIDRA: Add ---
		int Gameplay_GameEvents_Model_Tags_Repo_MetaTagFactoriesRepository__Add
		              (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a574f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventTagDic_Types_Tag__IMetaTagFactory__TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_EventTagDic_Types_Tag_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8425);
		    DAT_ram_00a574f1 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(param1 + 8),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_EventTagDic_Types_Tag__IMetaTagFactory__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    local_4 = param2;
		    uVar2 = func_ii_1081(Protocol_Dic_EventTagDic_Types_Tag_TypeInfo,&local_4);
		    local_8 = param2;
		    param3_00 = func_ii_1081(DAT_ram_00a66958,&local_8);
		    uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_8425,uVar2,param3_00,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar2,0);
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x000096A8 File Offset: 0x000078A8
		[Token(Token = "0x6002EC2")]
		[Address(RVA = "0x7F3A", Offset = "0x7F3A", VA = "0x7F3A", Slot = "4")]
		public bool TryGetFactory(EventTagDic.Types.Tag id, out IMetaTagFactory factory)
		{
		/* --- GHIDRA: TryGetFactory ---
		void Gameplay_GameEvents_Model_Tags_Repo_MetaTagFactoriesRepository__TryGetFactory
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a574f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventTagDic_Types_Tag__IMetaTagFactory__Clear__
		              );
		    DAT_ram_00a574f3 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 8),
		             Method_System_Collections_Generic_Dictionary_EventTagDic_Types_Tag__IMetaTagFactory__Clear__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: TryGetFactory ---
		void Gameplay_GameEvents_Model_Tags_Repo_MetaTagFactoriesRepository__TryGetFactory
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a574f3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventTagDic_Types_Tag__IMetaTagFactory__Clear__
		              );
		    DAT_ram_00a574f3 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 8),
		             Method_System_Collections_Generic_Dictionary_EventTagDic_Types_Tag__IMetaTagFactory__Clear__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x000096C0 File Offset: 0x000078C0
		[Token(Token = "0x6002EC3")]
		[Address(RVA = "0x7F3B", Offset = "0x7F3B", VA = "0x7F3B", Slot = "5")]
		public bool TryGetFactory(EventTagDic.Types.Tag[] ids, out List<IMetaTagFactory> factories)
		{
			return default(bool);
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC4")]
		[Address(RVA = "0x7F3C", Offset = "0x7F3C", VA = "0x7F3C", Slot = "6")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_GameEvents_Model_Tags_Repo_MetaTagFactoriesRepository__Dispose
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a574f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventTagDic_Types_Tag__IMetaTagFactory___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_EventTagDic_Types_Tag__IMetaTagFactory__TypeInfo
		              );
		    DAT_ram_00a574f4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_EventTagDic_Types_Tag__IMetaTagFactory__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_EventTagDic_Types_Tag__IMetaTagFactory___ctor__
		            );
		  *(undefined4 *)(param1 + 8) = param1_00;
		  Gameplay_GameEvents_Model_Tags_Repo_MetaTagFactoriesRepository___ctor(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC5")]
		[Address(RVA = "0x7F3D", Offset = "0x7F3D", VA = "0x7F3D")]
		public MetaTagFactoriesRepository()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_Model_Tags_Repo_MetaTagFactoriesRepository___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a574f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_StringTag_44___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_UserRatingTypeTag_19___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ItemsTag_11___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_CultTag_13___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanRatingKingTag_20___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_DailyQuestTag_36___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ProfessionTag_27___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_IntervalTag_16___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_EventURLBannerTag_43___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ArtikulTag_9___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_OptionTag_41___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_MedalTag_10___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ColossusTag_39___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_CollectionPartTag_46___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_BonusTag_42___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_LocaleTag_50___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_AccountTag_8___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_EventAssetsTag_45___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_TournamentTypeTag_15___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ViewTag_7___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_CollectionsTag_33___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_EventMilestone_48___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ExternalMoney_35___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ResourceSet_21___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_DailyGoalTag_49___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_OptionTypeTag_40___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanWarLeague_31___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_BossInstanceTypeTag_34___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_PromotionTag_38___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_UserBuildingTag_4___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_Isle_29___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_GameEvent_47___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_TimestampTag_2___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_SpellTag_5___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_IntTag_1___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanRestriction_32___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanBuilding_23___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanWarSeason_30___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_EventAssetsTag_45__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_SpellTag_5__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_UserBuildingTag_4__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_EventMilestone_48__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ItemsTag_11__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ColossusTag_39__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ProfessionTag_27__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_TimestampTag_2__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanBuilding_23__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_IntTag_1__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_CollectionsTag_33__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_EventURLBannerTag_43__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ResourceSet_21__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_CollectionPartTag_46__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_DailyQuestTag_36__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_CultTag_13__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_DailyGoalTag_49__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_LocaleTag_50__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ArtikulTag_9__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_OptionTag_41__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_MedalTag_10__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ViewTag_7__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanRatingKingTag_20__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_GameEvent_47__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanRestriction_32__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanWarSeason_30__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_BonusTag_42__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_PromotionTag_38__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_AccountTag_8__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_OptionTypeTag_40__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_UserRatingTypeTag_19__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_Isle_29__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_BossInstanceTypeTag_34__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_StringTag_44__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_TournamentTypeTag_15__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanWarLeague_31__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ExternalMoney_35__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_IntervalTag_16__TypeInfo);
		    DAT_ram_00a574f5 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_IntTag_1__TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,1,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_IntTag_1___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_TimestampTag_2__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,2,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_TimestampTag_2___ctor__)
		  ;
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_UserBuildingTag_4__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,4,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_UserBuildingTag_4___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_SpellTag_5__TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,5,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_SpellTag_5___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ViewTag_7__TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,7,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ViewTag_7___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_AccountTag_8__TypeInfo)
		  ;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,8,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_AccountTag_8___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ArtikulTag_9__TypeInfo)
		  ;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,9,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ArtikulTag_9___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ItemsTag_11__TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0xb,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ItemsTag_11___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_MedalTag_10__TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,10,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_MedalTag_10___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_CultTag_13__TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0xd,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_CultTag_13___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_TournamentTypeTag_15__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0xf,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_TournamentTypeTag_15___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_IntervalTag_16__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x10,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_IntervalTag_16___ctor__)
		  ;
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_UserRatingTypeTag_19__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x13,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_UserRatingTypeTag_19___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanRatingKingTag_20__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x14,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanRatingKingTag_20___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ResourceSet_21__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x15,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ResourceSet_21___ctor__)
		  ;
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanBuilding_23__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x17,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanBuilding_23___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ProfessionTag_27__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x1b,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ProfessionTag_27___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_Isle_29__TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x1d,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_Isle_29___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanWarSeason_30__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x1e,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanWarSeason_30___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanWarLeague_31__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x1f,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanWarLeague_31___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanRestriction_32__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x20,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ClanRestriction_32___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_CollectionsTag_33__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x21,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_CollectionsTag_33___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_BossInstanceTypeTag_34__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x22,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_BossInstanceTypeTag_34___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ExternalMoney_35__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x23,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ExternalMoney_35___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_DailyQuestTag_36__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x24,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_DailyQuestTag_36___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_PromotionTag_38__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x26,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_PromotionTag_38___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ColossusTag_39__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x27,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_ColossusTag_39___ctor__)
		  ;
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_OptionTypeTag_40__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x28,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_OptionTypeTag_40___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_OptionTag_41__TypeInfo)
		  ;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x29,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_OptionTag_41___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_BonusTag_42__TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x2a,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_BonusTag_42___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_EventURLBannerTag_43__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x2b,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_EventURLBannerTag_43___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_StringTag_44__TypeInfo)
		  ;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x2c,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_StringTag_44___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_EventAssetsTag_45__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x2d,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_EventAssetsTag_45___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_CollectionPartTag_46__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x2e,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_CollectionPartTag_46___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_GameEvent_47__TypeInfo)
		  ;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x2f,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_GameEvent_47___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_EventMilestone_48__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x30,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_EventMilestone_48___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_DailyGoalTag_49__TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x31,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_DailyGoalTag_49___ctor__
		            );
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_LocaleTag_50__TypeInfo)
		  ;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (uVar1,0x32,
		             Method_Gameplay_GameEvents_Model_Tags_Factories_MetaTagFactory_LocaleTag_50___ctor__);
		  Gameplay_GameEvents_Model_Tags_SourceTags_Tags_UserSourceTag__TryGetValue(param1,uVar1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC6")]
		[Address(RVA = "0x7F3E", Offset = "0x7F3E", VA = "0x7F3E")]
		protected void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_GameEvents_Model_Tags_Repo_MetaTagFactoriesRepository__Init
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a574f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventTypeDic_Types_SourceTypes__ISourceTagFactory__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventTypeDic_Types_SourceTypes__ISourceTagFactory___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_EventTypeDic_Types_SourceTypes__ISourceTagFactory__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_SourceTagFactory_ClanSourceTag___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_SourceTagFactory_UserSourceTag___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_Tags_Factories_SourceTagFactory_DefaultSourceTag___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_SourceTagFactory_DefaultSourceTag__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_SourceTagFactory_UserSourceTag__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_SourceTagFactory_ClanSourceTag__TypeInfo);
		    DAT_ram_00a574f6 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_EventTypeDic_Types_SourceTypes__ISourceTagFactory__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_EventTypeDic_Types_SourceTypes__ISourceTagFactory___ctor__
		            );
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_SourceTagFactory_UserSourceTag__TypeInfo
		                    );
		  func_ii_10812(param1_00,3,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventTypeDic_Types_SourceTypes__ISourceTagFactory__Add__
		               );
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_SourceTagFactory_ClanSourceTag__TypeInfo
		                    );
		  func_ii_10812(param1_00,5,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventTypeDic_Types_SourceTypes__ISourceTagFactory__Add__
		               );
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_SourceTagFactory_UserSourceTag__TypeInfo
		                    );
		  func_ii_10812(param1_00,1,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventTypeDic_Types_SourceTypes__ISourceTagFactory__Add__
		               );
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_Tags_Factories_SourceTagFactory_DefaultSourceTag__TypeInfo
		                    );
		  func_ii_10812(param1_00,6,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventTypeDic_Types_SourceTypes__ISourceTagFactory__Add__
		               );
		  *(undefined4 *)(param1 + 8) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x0400199E RID: 6558
		[Token(Token = "0x400199E")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<EventTagDic.Types.Tag, IMetaTagFactory> _factories;
	}
}
