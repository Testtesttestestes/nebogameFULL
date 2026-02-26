using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Core.GameTime;
using Gameplay.GameEvents.Model.Tags;
using Gameplay.GameEvents.Model.Tags.Repo;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using Protocol.Events;

namespace Gameplay.GameEvents.Model
{
	// Token: 0x02000793 RID: 1939
	[Token(Token = "0x2000793")]
	public class GameEventsModel : AbstractModel
	{
		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008DE")]
		public IGame Game
		{
			[Token(Token = "0x6002E17")]
			[Address(RVA = "0x7E94", Offset = "0x7E94", VA = "0x7E94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E18")]
			[Address(RVA = "0x7E95", Offset = "0x7E95", VA = "0x7E95")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008DF")]
		public Dictionary<ulong, GameEventData> Events
		{
			[Token(Token = "0x6002E19")]
			[Address(RVA = "0x7E96", Offset = "0x7E96", VA = "0x7E96")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x00008E08 File Offset: 0x00007008
		// (set) Token: 0x06002E1B RID: 11803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E0")]
		public bool IsListEventsViewShown
		{
			[Token(Token = "0x6002E1A")]
			[Address(RVA = "0x7E97", Offset = "0x7E97", VA = "0x7E97")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002E1B")]
			[Address(RVA = "0x7E98", Offset = "0x7E98", VA = "0x7E98")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E1D RID: 11805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E1")]
		public GameEventData CurrentReadEvent
		{
			[Token(Token = "0x6002E1C")]
			[Address(RVA = "0x7E99", Offset = "0x7E99", VA = "0x7E99")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E1D")]
			[Address(RVA = "0x7E9A", Offset = "0x7E9A", VA = "0x7E9A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06002E1E RID: 11806 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002E1F RID: 11807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E2")]
		public EventCategoriesDic DefaultCategory
		{
			[Token(Token = "0x6002E1E")]
			[Address(RVA = "0x7E9B", Offset = "0x7E9B", VA = "0x7E9B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E1F")]
			[Address(RVA = "0x7E9C", Offset = "0x7E9C", VA = "0x7E9C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06002E20 RID: 11808 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x170008E3")]
		public int TotalNotViewedEventCount
		{
			[Token(Token = "0x6002E20")]
			[Address(RVA = "0x7E9D", Offset = "0x7E9D", VA = "0x7E9D")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x6002E21")]
		[Address(RVA = "0x7E9E", Offset = "0x7E9E", VA = "0x7E9E")]
		public int GetNotViewedEventCount(EventCategoriesDic.Types.Category category)
		{
		/* --- GHIDRA: <GetEvent>b__40_1 ---
		void Gameplay_GameEvents_Model_GameEventsModel___GetEvent_b__40_1(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a574c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		    DAT_ram_00a574c8 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: GetNotViewedEventCount ---
		void Gameplay_GameEvents_Model_GameEventsModel__GetNotViewedEventCount
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a574bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__set_Item__
		              );
		    DAT_ram_00a574bd = '\x01';
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__int___get_Values
		            (*(undefined4 *)(param1 + 0x2c),param2,param3,
		             Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__set_Item__
		            );
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E22")]
		[Address(RVA = "0x7E9F", Offset = "0x7E9F", VA = "0x7E9F")]
		public void SetNotViewedEventCount(EventCategoriesDic.Types.Category category, int value)
		{
		/* --- GHIDRA: SetNotViewedEventCount ---
		undefined4
		Gameplay_GameEvents_Model_GameEventsModel__SetNotViewedEventCount(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a574be == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a574be = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x220);
		        goto code_r0x80d8e04c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80d8e04c:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return *(undefined4 *)(iVar3 + 0x18);
		}
		*/

		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008E4")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x6002E23")]
			[Address(RVA = "0x7EA0", Offset = "0x7EA0", VA = "0x7EA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x00008E50 File Offset: 0x00007050
		// (set) Token: 0x06002E25 RID: 11813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E5")]
		public float? ExpirationScheduleThreshold
		{
			[Token(Token = "0x6002E24")]
			[Address(RVA = "0x7EA1", Offset = "0x7EA1", VA = "0x7EA1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E25")]
			[Address(RVA = "0x7EA2", Offset = "0x7EA2", VA = "0x7EA2")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E26")]
		[Address(RVA = "0x7EA3", Offset = "0x7EA3", VA = "0x7EA3", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_GameEvents_Model_GameEventsModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 *puVar5;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a574c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_EventCategoriesDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_GameEventData____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ClanShortInfo___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__UserData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_ulong__GameEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_ulong__ClanShortInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_GameEventData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_EventCategoriesDic___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EventCategoriesDic__Sort__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GameEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_GameEventsModel___c___ctor_b__39_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		    DAT_ram_00a574c0 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_ulong__UserData__TypeInfo);
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_ulong__UserData___ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_ulong__ClanShortInfo__TypeInfo);
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_ulong__ClanShortInfo___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_GameEventData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_GameEventData___ctor__);
		  *(undefined4 *)(param1 + 0x48) = uVar2;
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_uint__List_GameEventData___TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,Method_System_Collections_Generic_Dictionary_uint__List_GameEventData____ctor__);
		  *(undefined4 *)(param1 + 0x4c) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param6,0);
		  *(undefined4 *)(param1 + 0x24) = param4;
		  *(undefined4 *)(param1 + 0x20) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  *(undefined4 *)(param1 + 0x1c) = param5;
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_ulong__GameEventData__TypeInfo);
		  System_Collections_Generic_Dictionary_ulong__ulong___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_ulong__GameEventData___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar2;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80d91489;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80d91489:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  iVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  uVar2 = System_Linq_Enumerable__Select_object__object_
		                    (*(undefined4 *)(iVar4 + 0x1b8),
		                     Method_System_Linq_Enumerable_ToList_EventCategoriesDic___);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  if (*(int *)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar5[2];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar5;
		    iVar4 = unnamed_function_1417(System_Comparison_EventCategoriesDic__TypeInfo);
		    System_Collections_Generic_Comparer_object___get_Default
		              (iVar4,param2_00,Method_Gameplay_GameEvents_Model_GameEventsModel___c___ctor_b__39_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x5c) + 8) = iVar4;
		  }
		  Google_Protobuf_Collections_RepeatedField_uint___Contains
		            (uVar2,iVar4,Method_System_Collections_Generic_List_EventCategoriesDic__Sort__);
		  return;
		}
		*/

		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E27")]
		[Address(RVA = "0x7EA4", Offset = "0x7EA4", VA = "0x7EA4")]
		public GameEventsModel(IGame game, ISourceTagFactoriesRepository sourceTagsRepository, IMetaTagFactoriesRepository metaTagRepository, ICurrentTimeProvider currentTimeProvider, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_GameEvents_Model_GameEventsModel___ctor(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  uint uVar7;
		  undefined4 *puVar8;
		  int local_38;
		  undefined8 *local_34;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  int local_4;
		  
		  if (DAT_ram_00a574c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_GameEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_GameEventData___TryGetValue__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_ulong__GameEventData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_ulong__GameEventData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_ulong__GameEventData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_GameEventsModel_ComparisonArchivedEvents__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_GameEventsModel_ComparisonEvents__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_ulong__GameEventData__get_Value__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__Sort__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GameEventData__TypeInfo);
		    DAT_ram_00a574c2 = '\x01';
		  }
		  local_4 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  local_30 = 0;
		  iVar2 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(param1 + 0x4c),*(undefined4 *)(param2 + 0xc),&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__List_GameEventData___TryGetValue__
		                    );
		  if (iVar2 != 0) {
		    return local_4;
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_GameEventData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_GameEventData___ctor__);
		  local_4 = iVar2;
		  System_Collections_Generic_Dictionary_ulong__ulong___FindEntry
		            (&local_30,*(undefined4 *)(param1 + 0x28),
		             Method_System_Collections_Generic_Dictionary_ulong__GameEventData__GetEnumerator__);
		  local_38 = 0;
		  local_34 = &local_30;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2d5,&local_30,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_ulong__GameEventData__MoveNext__
		                      );
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80d9282e;
		    }
		    if (iVar3 == 0) break;
		    iVar1 = (int)local_18;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2d6,
		                       *(undefined4 *)((int)local_18 + 0x1c),param2,0);
		    iVar3 = DAT_ram_009d3e38;
		    iVar2 = Method_System_Collections_Generic_List_GameEventData__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80d9282e;
		    }
		    if (iVar4 != 0) {
		      *(int *)(local_4 + 0x10) = *(int *)(local_4 + 0x10) + 1;
		      uVar7 = *(uint *)(local_4 + 0xc);
		      if (uVar7 < *(uint *)(*(int *)(local_4 + 8) + 0xc)) {
		        *(uint *)(local_4 + 0xc) = uVar7 + 1;
		        *(int *)(*(int *)(local_4 + 8) + uVar7 * 4 + 0x10) = iVar1;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,local_4,iVar1,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80d9282e:
		          iVar2 = global_1;
		          iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar2 == iVar3) {
		            piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		            iVar2 = *piVar6;
		            iVar3 = 0;
		            DAT_ram_009d3e38 = 0;
		            local_38 = iVar2;
		            import::env::invoke_v(0x123);
		            iVar1 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar1 != 1) {
		code_r0x80d9287b:
		              DAT_ram_009d3e38 = 0;
		              if (iVar2 != 0) {
		                System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              if (iVar3 != 0) {
		                if (iVar3 == 1) {
		                  DAT_ram_009d3e38 = 0;
		                  return 0;
		                }
		                if (iVar3 == 2) {
		                  DAT_ram_009d3e38 = 0;
		                  return 0;
		                }
		                if (iVar3 == 3) {
		                  DAT_ram_009d3e38 = 0;
		                  return 0;
		                }
		                if (iVar3 == 4) {
		                  DAT_ram_009d3e38 = 0;
		                  return 0;
		                }
		                if (iVar3 != 5) {
		                  DAT_ram_009d3e38 = 0;
		                  return 0;
		                }
		              }
		              iVar3 = System_Collections_Generic_Dictionary_Enumerator_ulong__object___MoveNext
		                                (param2,*(undefined4 *)(param1 + 0x44),0);
		              iVar2 = local_4;
		              uVar5 = unnamed_function_1417(System_Comparison_GameEventData__TypeInfo);
		              puVar8 = &Method_Gameplay_GameEvents_Model_GameEventsModel_ComparisonArchivedEvents__;
		              if (iVar3 == 0) {
		                puVar8 = &Method_Gameplay_GameEvents_Model_GameEventsModel_ComparisonEvents__;
		              }
		              System_Collections_Generic_Comparer_object___get_Default(uVar5,param1,*puVar8,0);
		              Google_Protobuf_Collections_RepeatedField_uint___Contains
		                        (iVar2,uVar5,Method_System_Collections_Generic_List_GameEventData__Sort__);
		              return local_4;
		            }
		            uVar5 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2d7,&local_38);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 == 1) {
		            import::env::__cxa_find_matching_catch_3(0);
		            unnamed_function_937();
		            do {
		              halt_trap();
		            } while( true );
		          }
		          import::env::__resumeException(uVar5);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		    }
		  }
		  iVar3 = 5;
		  iVar2 = local_38;
		  goto code_r0x80d9287b;
		}
		*/

		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E28")]
		[Address(RVA = "0x1AC5", Offset = "0x1AC5", VA = "0x1AC5")]
		public GameEventData GetEvent(ProtoGetEventsListAns.Types.EventInfo eventInfo)
		{
		/* --- GHIDRA: GetEvent ---
		undefined4
		Gameplay_GameEvents_Model_GameEventsModel__GetEvent(int param1,undefined8 param2,int param3)
		
		{
		  undefined8 uVar1;
		  uint uVar2;
		  uint uVar3;
		  undefined4 in_register_20000024;
		  uint *puVar4;
		  uint uVar5;
		  uint *puVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  undefined4 uVar10;
		  undefined8 uVar11;
		  uint uVar12;
		  int iVar13;
		  int iVar14;
		  int *piVar15;
		  undefined8 local_8;
		  
		  piVar15 = (int *)0x0;
		  if (*(int *)(param1 + 8) != 0) {
		    iVar8 = *(int *)(*(int *)(param3 + 0x10) + 0x60);
		    piVar9 = *(int **)(param1 + 0x20);
		    local_8 = param2;
		    if (piVar9 == (int *)0x0) {
		      uVar5 = System_TimeSpan__Equals(&local_8,*(undefined4 *)(iVar8 + 0xc4));
		    }
		    else {
		      iVar8 = *(int *)(iVar8 + 4);
		      if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		        iVar8 = func_ii_1079(iVar8);
		      }
		      iVar13 = *piVar9;
		      if (*(ushort *)(iVar13 + 0xb6) != 0) {
		        uVar5 = 0;
		        do {
		          if (iVar8 == *(int *)(*(int *)(iVar13 + 0x58) + uVar5 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar5 * 8 + 4) * 8 + iVar13 + 200);
		            goto code_r0x82283d04;
		          }
		          uVar5 = uVar5 + 1;
		        } while (*(ushort *)(iVar13 + 0xb6) != uVar5);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar9,iVar8,1);
		code_r0x82283d04:
		      uVar5 = (**(code **)((ulonglong)*puVar4 * 4))
		                        (piVar9,param2,CONCAT44(in_register_20000024,puVar4[1]));
		    }
		    iVar8 = (int)(uVar5 & 0x7fffffff) % *(int *)(*(int *)(param1 + 8) + 0xc);
		    uVar12 = *(int *)(*(int *)(param1 + 8) + iVar8 * 4 + 0x10) - 1;
		    if ((int)uVar12 < 0) {
		      return 0;
		    }
		    uVar3 = 0xffffffff;
		    do {
		      uVar2 = uVar12;
		      uVar1 = local_8;
		      iVar13 = *(int *)(param1 + 0xc) + 0x10;
		      puVar4 = (uint *)(iVar13 + uVar2 * 0x18);
		      if (*puVar4 == (uVar5 & 0x7fffffff)) {
		        piVar9 = *(int **)(param1 + 0x20);
		        if (piVar9 == (int *)0x0) {
		          piVar9 = (int *)System_Collections_Generic_EqualityComparer_ulong___System_Collections_IEqualityComparer_GetHashCode
		                                    (*(undefined4 *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0xc)
		                                    );
		          iVar7 = (**(code **)((ulonglong)*(uint *)(*piVar9 + 0x100) * 4))
		                            (piVar9,*(undefined8 *)(puVar4 + 2),local_8,
		                             *(undefined4 *)(*piVar9 + 0x104));
		        }
		        else {
		          if (piVar9 == (int *)0x0) {
		            piVar9 = piVar15;
		          }
		          uVar11 = *(undefined8 *)(puVar4 + 2);
		          iVar7 = *(int *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 4);
		          if ((*(byte *)(iVar7 + 0xbd) & 1) == 0) {
		            iVar7 = func_ii_1079(iVar7);
		          }
		          iVar14 = *piVar9;
		          if (*(ushort *)(iVar14 + 0xb6) != 0) {
		            uVar12 = 0;
		            do {
		              piVar15 = (int *)(*(int *)(iVar14 + 0x58) + uVar12 * 8);
		              if (iVar7 == *piVar15) {
		                puVar6 = (uint *)(iVar14 + piVar15[1] * 8 + 0xc0);
		                goto code_r0x82283e0c;
		              }
		              uVar12 = uVar12 + 1;
		            } while (*(ushort *)(iVar14 + 0xb6) != uVar12);
		          }
		          puVar6 = (uint *)func_ii_1080(piVar9,iVar7,0);
		code_r0x82283e0c:
		          iVar7 = (**(code **)((ulonglong)*puVar6 * 4))(piVar9,uVar11,uVar1,puVar6[1]);
		          piVar15 = piVar9;
		        }
		        if (iVar7 != 0) {
		          iVar7 = *(int *)(iVar13 + uVar2 * 0x18 + 4);
		          if ((int)uVar3 < 0) {
		            *(int *)(*(int *)(param1 + 8) + iVar8 * 4 + 0x10) = iVar7 + 1;
		          }
		          else {
		            *(int *)(*(int *)(param1 + 0xc) + uVar3 * 0x18 + 0x14) = iVar7;
		          }
		          *puVar4 = 0xffffffff;
		          uVar10 = *(undefined4 *)(param1 + 0x14);
		          iVar13 = iVar13 + uVar2 * 0x18;
		          *(undefined4 *)(iVar13 + 0x10) = 0;
		          *(undefined4 *)(iVar13 + 4) = uVar10;
		          *(uint *)(param1 + 0x14) = uVar2;
		          *(int *)(param1 + 0x18) = *(int *)(param1 + 0x18) + 1;
		          *(int *)(param1 + 0x1c) = *(int *)(param1 + 0x1c) + 1;
		          return 1;
		        }
		      }
		      uVar12 = puVar4[1];
		      uVar3 = uVar2;
		    } while (-1 < (int)puVar4[1]);
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E29")]
		[Address(RVA = "0x7EA5", Offset = "0x7EA5", VA = "0x7EA5")]
		public List<GameEventData> GetEvents(EventCategoriesDic category)
		{
		/* --- GHIDRA: GetEvents ---
		undefined4
		Gameplay_GameEvents_Model_GameEventsModel__GetEvents(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a574c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_EventCategoriesDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_EventCategoriesDic__get_Item__);
		    DAT_ram_00a574c3 = '\x01';
		  }
		  iVar3 = *(int *)(*(int *)(param1 + 0x10) + 0xc);
		  if (0 < iVar3) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x10),param2_00,
		                         Method_System_Collections_Generic_List_EventCategoriesDic__get_Item__);
		      if (param2 == *(int *)(iVar1 + 0xc)) {
		        uVar2 = System_Linq_Enumerable__ToList_object_
		                          (*(undefined4 *)(param1 + 0x10),param2_00,
		                           Method_System_Collections_Generic_List_EventCategoriesDic__get_Item__);
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

		// Token: 0x06002E2A RID: 11818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E2A")]
		[Address(RVA = "0x7EA6", Offset = "0x7EA6", VA = "0x7EA6")]
		public EventCategoriesDic GetCategory(EventCategoriesDic.Types.Category id)
		{
			return null;
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x6002E2B")]
		[Address(RVA = "0x7EA7", Offset = "0x7EA7", VA = "0x7EA7")]
		private int ComparisonEvents(GameEventData x, GameEventData y)
		{
		/* --- GHIDRA: ComparisonEvents ---
		uint Gameplay_GameEvents_Model_GameEventsModel__ComparisonEvents
		               (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  ulonglong uVar2;
		  ulonglong uVar3;
		  
		  uVar1 = 1;
		  uVar2 = *(ulonglong *)(*(int *)(param2 + 0x24) + 0x28);
		  uVar3 = *(ulonglong *)(*(int *)(param3 + 0x24) + 0x28);
		  if (uVar3 <= uVar2) {
		    uVar1 = 0xffffffff;
		    if (uVar2 <= uVar3) {
		      uVar2 = *(ulonglong *)(*(int *)(param2 + 0x24) + 0x18);
		      uVar3 = *(ulonglong *)(*(int *)(param3 + 0x24) + 0x18);
		      uVar1 = 0xffffffff;
		      if (uVar2 <= uVar3) {
		        uVar1 = (uint)(uVar2 < uVar3);
		      }
		    }
		  }
		  return uVar1;
		}
		*/

			return 0;
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x6002E2C")]
		[Address(RVA = "0x7EA8", Offset = "0x7EA8", VA = "0x7EA8")]
		private int ComparisonArchivedEvents(GameEventData x, GameEventData y)
		{
		/* --- GHIDRA: ComparisonArchivedEvents ---
		int Gameplay_GameEvents_Model_GameEventsModel__ComparisonArchivedEvents
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  uint param2_00;
		  
		  iVar1 = Core_Extensions_Dict_EventInfoExt__IsDeleted(param1,param2,param1);
		  param2_00 = *(uint *)(*(int *)(iVar1 + 0x1c) + 0xc);
		  if (DAT_ram_00a574c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_GameEventData___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData__Remove__);
		    DAT_ram_00a574c5 = '\x01';
		  }
		  iVar2 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(param1 + 0x4c),param2_00,
		                     Method_System_Collections_Generic_Dictionary_uint__List_GameEventData___ContainsKey__
		                    );
		  if (iVar2 != 0) {
		    Gameplay_GameEvents_Model_GameEventsModel__GetEvent
		              (*(undefined4 *)(param1 + 0x28),(ulonglong)param2_00,
		               Method_System_Collections_Generic_Dictionary_ulong__GameEventData__Remove__);
		  }
		  return iVar1;
		}
		*/

			return 0;
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002E2D")]
		[Address(RVA = "0x7EA9", Offset = "0x7EA9", VA = "0x7EA9")]
		public GameEventData AddEvent(ProtoGetEventsListAns.Types.EventInfo evtInfo)
		{
		/* --- GHIDRA: AddEvent ---
		void Gameplay_GameEvents_Model_GameEventsModel__AddEvent
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  uint param2_00;
		  
		  if (DAT_ram_00a574c4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData__get_Item__);
		    DAT_ram_00a574c4 = '\x01';
		  }
		  iVar1 = Google_Protobuf_Collections_RepeatedField_ulong___GetEnumerator
		                    (*(undefined4 *)(param1 + 0x28),param2,
		                     Method_System_Collections_Generic_Dictionary_ulong__GameEventData__ContainsKey__
		                    );
		  if (iVar1 != 0) {
		    iVar1 = System_Collections_Generic_Dictionary_ulong__object___get_Comparer
		                      (*(undefined4 *)(param1 + 0x28),param2,
		                       Method_System_Collections_Generic_Dictionary_ulong__GameEventData__get_Item__
		                      );
		    Gameplay_GameEvents_Model_GameEventsModel__GetEvent
		              (*(undefined4 *)(param1 + 0x28),param2,
		               Method_System_Collections_Generic_Dictionary_ulong__GameEventData__Remove__);
		    param2_00 = *(uint *)(*(int *)(iVar1 + 0x1c) + 0xc);
		    if (DAT_ram_00a574c5 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_uint__List_GameEventData___ContainsKey__
		                );
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData__Remove__);
		      DAT_ram_00a574c5 = '\x01';
		    }
		    iVar2 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                      (*(undefined4 *)(param1 + 0x4c),param2_00,
		                       Method_System_Collections_Generic_Dictionary_uint__List_GameEventData___ContainsKey__
		                      );
		    if (iVar2 != 0) {
		      Gameplay_GameEvents_Model_GameEventsModel__GetEvent
		                (*(undefined4 *)(param1 + 0x28),(ulonglong)param2_00,
		                 Method_System_Collections_Generic_Dictionary_ulong__GameEventData__Remove__);
		    }
		    Gameplay_GameEvents_Model_GameEventData__set_EventTypeDic(iVar1,param1);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2E")]
		[Address(RVA = "0x7EAA", Offset = "0x7EAA", VA = "0x7EAA")]
		public void RemoveEvent(ulong id)
		{
		/* --- GHIDRA: RemoveEvent ---
		void Gameplay_GameEvents_Model_GameEventsModel__RemoveEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Gameplay_GameEvents_Model_GameEventsModel__AddEvent
		            (param1,*(undefined8 *)(*(int *)(param2 + 0x24) + 0x10),param2);
		  return;
		}
		*/

		/* --- GHIDRA: RemoveEvent ---
		void Gameplay_GameEvents_Model_GameEventsModel__RemoveEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Gameplay_GameEvents_Model_GameEventsModel__AddEvent
		            (param1,*(undefined8 *)(*(int *)(param2 + 0x24) + 0x10),param2);
		  return;
		}
		*/

		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E2F")]
		[Address(RVA = "0x7EAB", Offset = "0x7EAB", VA = "0x7EAB")]
		public void RemoveEvent(GameEventData evt)
		{
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E30")]
		[Address(RVA = "0x7EAC", Offset = "0x7EAC", VA = "0x7EAC")]
		public void ResetCacheByCategory(uint catId)
		{
		/* --- GHIDRA: ResetCacheByCategory ---
		void Gameplay_GameEvents_Model_GameEventsModel__ResetCacheByCategory
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param2_01;
		  int iVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 param1_01;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 *param2_02;
		  int iVar7;
		  undefined4 uVar8;
		  int param3_00;
		  int iVar9;
		  undefined4 local_10;
		  int local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  iVar9 = 0;
		  param3_00 = 0;
		  if (DAT_ram_00a574c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_uint__int__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__int__ContainsKey__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_uint__int___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__int__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__int__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&double___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_double___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Item__);
		    DAT_ram_00a574c6 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__int__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_00,Method_System_Collections_Generic_Dictionary_uint__int___ctor__);
		  param2_00 = System_Linq_Enumerable__ToArray_char_
		                        (*(undefined4 *)(param2 + 0x34),
		                         Method_System_Linq_Enumerable_ToArray_double___);
		  iVar7 = *(int *)(param1 + 0xc);
		  if (0 < iVar7) {
		    do {
		      param2_01 = (int *)System_Linq_Enumerable__ToList_object_
		                                   (param1,iVar9,
		                                    Method_System_Collections_Generic_List_AbstractTag__get_Item__);
		      iVar1 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                        (param1_00,*(undefined4 *)(param2_01[3] + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__int__ContainsKey__);
		      uVar8 = *(undefined4 *)(param2_01[3] + 0xc);
		      if (iVar1 == 0) {
		        System_Collections_Generic_Dictionary_uint__int____ctor
		                  (param1_00,uVar8,1,Method_System_Collections_Generic_Dictionary_uint__int__Add__);
		      }
		      else {
		        iVar1 = System_Collections_Generic_List_object___get_Item
		                          (param1_00,uVar8,
		                           Method_System_Collections_Generic_Dictionary_uint__int__get_Item__);
		        System_Collections_Generic_Dictionary_uint__int___ContainsKey
		                  (param1_00,uVar8,iVar1 + 1,
		                   Method_System_Collections_Generic_Dictionary_uint__int__set_Item__);
		      }
		      iVar1 = System_Collections_Generic_List_object___get_Item
		                        (param1_00,*(undefined4 *)(param2_01[3] + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__int__get_Item__);
		      param2_01[4] = iVar1;
		      uVar8 = (**(code **)((ulonglong)*(uint *)(*param2_01 + 0xe8) * 4))
		                        (param2_01,*(undefined4 *)(*param2_01 + 0xec));
		      iVar1 = Mono_Security_ASN1Convert__ToOid(double___TypeInfo,uVar8);
		      param2_01[5] = iVar1;
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::invoke_iii
		                        (*(undefined4 *)(*param2_01 + 0xe8),param2_01,
		                         *(undefined4 *)(*param2_01 + 0xec));
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80d91dcf:
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar1 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar1 != iVar2) goto code_r0x80d920cd;
		        puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar8);
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_ii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                           &System_Exception_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80d92056:
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::__cxa_find_matching_catch_2();
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar8,
		                             *(undefined4 *)*puVar3);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) goto code_r0x80d92056;
		          if (iVar2 != 0) {
		            import::env::__cxa_end_catch();
		            uVar8 = unnamed_function_2232(&object___TypeInfo);
		            iVar1 = Mono_Security_ASN1Convert__ToOid(uVar8,6);
		            local_4 = *(undefined4 *)(param2 + 0x20);
		            uVar8 = func_ii_1081(DAT_ram_00a66958,&local_4);
		            func_ii_4505(iVar1,uVar8);
		            *(undefined4 *)(iVar1 + 0x10) = uVar8;
		            local_8 = *(undefined4 *)(param2_01[3] + 0xc);
		            uVar8 = func_ii_1081(DAT_ram_00a66958,&local_8);
		            func_ii_4505(iVar1,uVar8);
		            *(undefined4 *)(iVar1 + 0x14) = uVar8;
		            local_c = param2_01[4];
		            uVar8 = func_ii_1081(DAT_ram_00a66954,&local_c);
		            func_ii_4505(iVar1,uVar8);
		            *(undefined4 *)(iVar1 + 0x18) = uVar8;
		            local_10 = (**(code **)((ulonglong)*(uint *)(*param2_01 + 0xe8) * 4))
		                                 (param2_01,*(undefined4 *)(*param2_01 + 0xec));
		            uVar8 = func_ii_1081(DAT_ram_00a66958,&local_10);
		            func_ii_4505(iVar1,uVar8);
		            *(undefined4 *)(iVar1 + 0x1c) = uVar8;
		            iVar2 = unnamed_function_2232(&Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		            if (*(int *)(iVar2 + 0x74) == 0) {
		              func_ii_306000(iVar2);
		            }
		            iVar2 = unnamed_function_2232(&Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		            iVar2 = *(int *)(*(int *)(iVar2 + 0x5c) + 0x10);
		            uVar8 = unnamed_function_2232(&StringLiteral_1236);
		            param1_01 = unnamed_function_2232(&StringLiteral_8423);
		            if (iVar2 == 0) {
		              iVar2 = unnamed_function_2232(&Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo)
		              ;
		              if (*(int *)(iVar2 + 0x74) == 0) {
		                func_ii_306000(iVar2);
		              }
		              iVar2 = unnamed_function_2232(&Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo)
		              ;
		              uVar6 = **(undefined4 **)(iVar2 + 0x5c);
		              uVar5 = unnamed_function_2232(&System_Func_AbstractTag__uint__TypeInfo);
		              iVar2 = unnamed_function_1417(uVar5);
		              uVar5 = unnamed_function_2232
		                                (&
		                                 Method_Gameplay_GameEvents_Model_GameEventsModel___c__FillEventTags_b__50_0__
		                                );
		              System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                        (iVar2,uVar6,uVar5,0);
		              iVar4 = unnamed_function_2232(&Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo)
		              ;
		              *(int *)(*(int *)(iVar4 + 0x5c) + 0x10) = iVar2;
		              unnamed_function_2232(&Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		            }
		            uVar5 = unnamed_function_2232
		                              (&Method_System_Linq_Enumerable_Select_AbstractTag__uint___);
		            uVar5 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                              (param1,iVar2,uVar5);
		            uVar6 = unnamed_function_2232(&Method_System_Linq_Enumerable_ToArray_uint___);
		            uVar5 = System_Linq_Enumerable__OrderBy_uint__uint_(uVar5,uVar6);
		            uVar6 = unnamed_function_2232(&Method_System_String_Join_uint___);
		            uVar8 = System_String__Join_float_(uVar8,uVar5,uVar6);
		            func_ii_4505(iVar1,uVar8);
		            *(undefined4 *)(iVar1 + 0x20) = uVar8;
		            uVar6 = *(undefined4 *)(param2 + 0x34);
		            uVar8 = unnamed_function_2232(&StringLiteral_1236);
		            uVar5 = unnamed_function_2232(&Method_System_String_Join_double___);
		            uVar8 = System_String__Join_bool_(uVar8,uVar6,uVar5);
		            func_ii_4505(iVar1,uVar8);
		            *(undefined4 *)(iVar1 + 0x24) = uVar8;
		            uVar8 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                              (param1_01,iVar1,0);
		            iVar1 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		            if (*(int *)(iVar1 + 0x74) == 0) {
		              func_ii_306000(iVar1);
		            }
		            func_ii_7830(uVar8,0);
		            goto code_r0x80d920ef;
		          }
		          param2_02 = (undefined4 *)unnamed_function_951(4);
		          *param2_02 = *puVar3;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_02,
		                     &DAT_ram_0072c9c8,0);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 != 1) goto code_r0x80d9210f;
		          uVar8 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		code_r0x80d920cd:
		          import::env::__resumeException(uVar8);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		code_r0x80d9210f:
		        do {
		          halt_trap();
		        } while( true );
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vijijji
		                (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2d4,param2_00,param3_00,0,iVar1
		                 ,0,0,uVar8,0,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) goto code_r0x80d91dcf;
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param2_01 + 0xe8) * 4))
		                        (param2_01,*(undefined4 *)(*param2_01 + 0xec));
		      param3_00 = iVar1 + param3_00;
		code_r0x80d920ef:
		      iVar9 = iVar9 + 1;
		    } while (iVar9 != iVar7);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E31")]
		[Address(RVA = "0x7EAD", Offset = "0x7EAD", VA = "0x7EAD")]
		public static void FillEventTags(List<AbstractTag> tags, ProtoGetEventsListAns.Types.EventInfo eventInfo)
		{
		/* --- GHIDRA: FillEventTags ---
		undefined4
		Gameplay_GameEvents_Model_GameEventsModel__FillEventTags(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a574c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_Tags_Factories_IMetaTagFactory_TypeInfo)
		    ;
		    DAT_ram_00a574c7 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param1 + 0xc);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_GameEvents_Model_Tags_Factories_IMetaTagFactory_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x80d92c73;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                Gameplay_GameEvents_Model_Tags_Factories_IMetaTagFactory_TypeInfo,1)
		  ;
		code_r0x80d92c73:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,uVar3,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x0400194A RID: 6474
		[Token(Token = "0x400194A")]
		[FieldOffset(Offset = "0x10")]
		public List<EventCategoriesDic> AvailableCategories;

		// Token: 0x0400194B RID: 6475
		[Token(Token = "0x400194B")]
		[FieldOffset(Offset = "0x14")]
		public readonly Dictionary<ulong, UserData> SourcesUsers;

		// Token: 0x0400194C RID: 6476
		[Token(Token = "0x400194C")]
		[FieldOffset(Offset = "0x18")]
		public readonly Dictionary<ulong, ClanShortInfo> SourcesClans;

		// Token: 0x0400194D RID: 6477
		[Token(Token = "0x400194D")]
		[FieldOffset(Offset = "0x1C")]
		public readonly ICurrentTimeProvider CurrentTimeProvider;

		// Token: 0x0400194E RID: 6478
		[Token(Token = "0x400194E")]
		[FieldOffset(Offset = "0x20")]
		private readonly ISourceTagFactoriesRepository _sourceTagsRepository;

		// Token: 0x0400194F RID: 6479
		[Token(Token = "0x400194F")]
		[FieldOffset(Offset = "0x24")]
		private readonly IMetaTagFactoriesRepository _metaTagRepository;

		// Token: 0x04001950 RID: 6480
		[Token(Token = "0x4001950")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<ulong, GameEventData> _events;

		// Token: 0x04001951 RID: 6481
		[Token(Token = "0x4001951")]
		[FieldOffset(Offset = "0x2C")]
		private readonly Dictionary<EventCategoriesDic.Types.Category, int> _notViewedEventCountByCategory;

		// Token: 0x04001956 RID: 6486
		[Token(Token = "0x4001956")]
		[FieldOffset(Offset = "0x44")]
		public EventCategoriesDic ArchiveCategoryDic;

		// Token: 0x04001957 RID: 6487
		[Token(Token = "0x4001957")]
		[FieldOffset(Offset = "0x48")]
		public readonly List<GameEventData> EventsTheActionWhichRequestCloseWindow;

		// Token: 0x04001958 RID: 6488
		[Token(Token = "0x4001958")]
		[FieldOffset(Offset = "0x4C")]
		private Dictionary<uint, List<GameEventData>> _eventsByCatsCache;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_DefaultCategory ---
		undefined4
		Gameplay_GameEvents_Model_GameEventsModel__set_DefaultCategory(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a574bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Sum_KeyValuePair_EventCategoriesDic_Types_Category__int____
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_KeyValuePair_EventCategoriesDic_Types_Category__int___int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_GameEventsModel___c__get_TotalNotViewedEventCount_b__27_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		    DAT_ram_00a574bb = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417
		                          (
		                          System_Func_KeyValuePair_EventCategoriesDic_Types_Category__int___int__TypeInfo
		                          );
		    System_Func_KeyValuePair_Int32Enum__int___bool___Invoke
		              (param1_00,param2_00,
		               Method_Gameplay_GameEvents_Model_GameEventsModel___c__get_TotalNotViewedEventCount_b__27_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x5c) + 4) =
		         param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Sum_object_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_Sum_KeyValuePair_EventCategoriesDic_Types_Category__int____
		                    );
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_TotalNotViewedEventCount ---
		undefined4
		Gameplay_GameEvents_Model_GameEventsModel__get_TotalNotViewedEventCount
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a574bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		              );
		    DAT_ram_00a574bc = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(param1 + 0x2c),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		                    );
		  if (iVar1 == 0) {
		    local_4 = 0;
		  }
		  return local_4;
		}
		*/


		/* --- GHIDRA: get_GameAudio ---
		void Gameplay_GameEvents_Model_GameEventsModel__get_GameAudio
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  *param1 = *(undefined8 *)(param2 + 0x3c);
		  return;
		}
		*/


		/* --- GHIDRA: get_ExpirationScheduleThreshold ---
		void Gameplay_GameEvents_Model_GameEventsModel__get_ExpirationScheduleThreshold
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  *(undefined8 *)(param1 + 0x3c) = *param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_ExpirationScheduleThreshold ---
		void Gameplay_GameEvents_Model_GameEventsModel__set_ExpirationScheduleThreshold
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a574bf == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__Clear__);
		    DAT_ram_00a574bf = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x34) = 0;
		  *(undefined4 *)(param1 + 0xc) = 0;
		  iVar1 = *(int *)(param1 + 0x48);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/

}
