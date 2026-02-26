using System;
using System.Collections.Generic;
using Core.Rounting;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path.Factories
{
	// Token: 0x020011ED RID: 4589
	[Token(Token = "0x20011ED")]
	public class PathNodeFactoryRepository : IPathNodeFactoryRepository, IDisposable
	{
		// Token: 0x06006CF9 RID: 27897 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006CF9")]
		[Address(RVA = "0xB7E2", Offset = "0xB7E2", VA = "0xB7E2", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository__ToString
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a734 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__IPathNodeFactory__Clear__);
		    DAT_ram_00a5a734 = '\x01';
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 8),
		             Method_System_Collections_Generic_Dictionary_string__IPathNodeFactory__Clear__);
		  *(undefined4 *)(param1 + 0xc) = 0;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006CFA RID: 27898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CFA")]
		[Address(RVA = "0xB7E3", Offset = "0xB7E3", VA = "0xB7E3", Slot = "5")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository__Dispose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a735 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__IPathNodeFactory___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__IPathNodeFactory__TypeInfo);
		    DAT_ram_00a5a735 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_string__IPathNodeFactory__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_string__IPathNodeFactory___ctor__);
		  *(undefined4 *)(param1 + 8) = param1_00;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository__TryGetFactory
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006CFB RID: 27899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CFB")]
		[Address(RVA = "0xB7E4", Offset = "0xB7E4", VA = "0xB7E4")]
		public PathNodeFactoryRepository(IPathNodeFactory defaultNodeFactory)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a736 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__IPathNodeFactory__Add__);
		    Mono_Security_ASN1__get_Item(&Core_Rounting_IPathNodeFactory_TypeInfo);
		    DAT_ram_00a5a736 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 8);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Rounting_IPathNodeFactory_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81264205;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Rounting_IPathNodeFactory_TypeInfo,0);
		code_r0x81264205:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,param2_00,param2,
		             Method_System_Collections_Generic_Dictionary_string__IPathNodeFactory__Add__);
		  return;
		}
		*/

		}

		// Token: 0x06006CFC RID: 27900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CFC")]
		[Address(RVA = "0xB7E5", Offset = "0xB7E5", VA = "0xB7E5")]
		public void Add(IPathNodeFactory factory)
		{
		/* --- GHIDRA: Add ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository__Add
		          (int param1,undefined4 param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a737 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__IPathNodeFactory__TryGetValue__
		              );
		    DAT_ram_00a5a737 = '\x01';
		  }
		  iVar1 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                    (*(undefined4 *)(param1 + 8),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_string__IPathNodeFactory__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    *param3 = *(undefined4 *)(param1 + 0xc);
		  }
		  return 1;
		}
		*/

		}

		// Token: 0x06006CFD RID: 27901 RVA: 0x000140E8 File Offset: 0x000122E8
		[Token(Token = "0x6006CFD")]
		[Address(RVA = "0xB7E6", Offset = "0xB7E6", VA = "0xB7E6", Slot = "4")]
		public bool TryGetFactory(string name, out IPathNodeFactory factory)
		{
		/* --- GHIDRA: TryGetFactory ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository__TryGetFactory
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a738 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Collections___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Sync___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Menu___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_GuideSettings___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Craft___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_BattlesList___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_ClanManagement___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Auchan___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Tournaments___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_BlitzTournaments___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_BossList___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Feedback___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_ArenaBuilding___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Bank___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Home___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Idle___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_SaveProgress___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_VortexInfo___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_MarketBuilding___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_SlotsDiamond___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_CaveBuilding___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_ClanHome___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_MagicSchoolBuilding___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_UserInfo___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_DailyRewards___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_TreeBuilding___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_SlotsOnyx___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_MenuSettings___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_CommonRatings___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_EndlessOptions___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Notifications___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Slots___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_DailyQuests___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_SlotsOnyx__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_BattlesList__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Slots__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_EndlessOptions__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_UserInfo__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_BlitzTournaments__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Home__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_SlotsDiamond__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Bank__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Sync__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Craft__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_TreeBuilding__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_DailyRewards__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_DailyQuests__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_SaveProgress__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_MenuSettings__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_BossList__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Collections__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_MagicSchoolBuilding__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_CaveBuilding__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_GuideSettings__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_ArenaBuilding__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_CommonRatings__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Feedback__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Auchan__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_MarketBuilding__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Menu__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Tournaments__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_ClanManagement__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Idle__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_ClanHome__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Notifications__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_VortexInfo__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_25243);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24507);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25357);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24371);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20733);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20488);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25358);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20575);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24267);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25278);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27814);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27858);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21200);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21411);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21204);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22937);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26553);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25662);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22015);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22492);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22491);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27541);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19916);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20002);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20463);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28177);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27283);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27287);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27286);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21863);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28311);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21072);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23146);
		    DAT_ram_00a5a738 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Idle__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_24507,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Idle___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Home__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_24371,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Home___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_ClanHome__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_21200,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_ClanHome___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_UserInfo__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_28177,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_UserInfo___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_CaveBuilding__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_21072,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_CaveBuilding___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_ArenaBuilding__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_19916,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_ArenaBuilding___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_TreeBuilding__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_27858,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_TreeBuilding___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_MarketBuilding__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_25278,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_MarketBuilding___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_MagicSchoolBuilding__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_25243,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_MagicSchoolBuilding___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Tournaments__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_27814,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Tournaments___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_BlitzTournaments__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_20575,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_BlitzTournaments___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_VortexInfo__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_28311,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_VortexInfo___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_BossList__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_20733,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_BossList___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Auchan__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_20002,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Auchan___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Craft__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_22015,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Craft___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_CommonRatings__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_21863,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_CommonRatings___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Slots__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_27283,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Slots___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_SlotsDiamond__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_27286,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_SlotsDiamond___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_SlotsOnyx__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_27287,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_SlotsOnyx___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_ClanManagement__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_21204,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_ClanManagement___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Collections__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_21411,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Collections___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Bank__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_20463,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Bank___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_EndlessOptions__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_22937,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_EndlessOptions___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_DailyQuests__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_22491,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_DailyQuests___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_DailyRewards__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_22492,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_DailyRewards___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Menu__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_25357,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Menu___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_MenuSettings__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_25358,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_MenuSettings___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_GuideSettings__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_24267,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_GuideSettings___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Feedback__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_23146,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Feedback___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Notifications__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_25662,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Notifications___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Sync__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_27541,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_Sync___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_SaveProgress__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_26553,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_SaveProgress___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_BattlesList__TypeInfo
		                    );
		  Unity_Jobs_IJobParallelForExtensions_ParallelForJobStruct_UITKTextJobSystem_PrepareTextJobData___Initialize
		            (uVar1,StringLiteral_20488,
		             Method_Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactory_BattlesList___ctor__
		            );
		  Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository___ctor
		            (param1,uVar1,param1);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CFE")]
		[Address(RVA = "0xB7E7", Offset = "0xB7E7", VA = "0xB7E7")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		int Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Factories_PathNodeFactoryRepository__Init
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a739 == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27696);
		    DAT_ram_00a5a739 = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,1);
		  *(undefined4 *)(iVar1 + 0x10) = StringLiteral_27696;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0400390B RID: 14603
		[Token(Token = "0x400390B")]
		[FieldOffset(Offset = "0x8")]
		private readonly Dictionary<string, IPathNodeFactory> _factories;

		// Token: 0x0400390C RID: 14604
		[Token(Token = "0x400390C")]
		[FieldOffset(Offset = "0xC")]
		private IPathNodeFactory _defaultFactory;
	}
}
