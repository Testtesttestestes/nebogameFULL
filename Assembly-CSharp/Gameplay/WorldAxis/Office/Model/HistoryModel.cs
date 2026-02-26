using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.WorldAxis.Office.View.History;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Combat;
using Protocol.Dic;
using UI.Elements.Filters.GenericFilter;
using UnityEngine;

namespace Gameplay.WorldAxis.Office.Model
{
	// Token: 0x020002CC RID: 716
	[Token(Token = "0x20002CC")]
	public class HistoryModel : AbstractModel
	{
		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700027C")]
		public Dictionaries Dict
		{
			[Token(Token = "0x60010E6")]
			[Address(RVA = "0x62E3", Offset = "0x62E3", VA = "0x62E3")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x000046E0 File Offset: 0x000028E0
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027D")]
		public uint NextPageNumber
		{
			[Token(Token = "0x60010E7")]
			[Address(RVA = "0x62E4", Offset = "0x62E4", VA = "0x62E4")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60010E8")]
			[Address(RVA = "0x62E5", Offset = "0x62E5", VA = "0x62E5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027E")]
		public BattleHistoryListElement.BattleHistoryListElementArgs[] LastRequestedBattles
		{
			[Token(Token = "0x60010E9")]
			[Address(RVA = "0x62E6", Offset = "0x62E6", VA = "0x62E6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010EA")]
			[Address(RVA = "0x62E7", Offset = "0x62E7", VA = "0x62E7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700027F")]
		public FilterWithIconListElement.FilterWithIconData[] ColossusFilters
		{
			[Token(Token = "0x60010EB")]
			[Address(RVA = "0x62E8", Offset = "0x62E8", VA = "0x62E8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000280")]
		public HistoryModel.BattleFullInfo CurrentBattleInfo
		{
			[Token(Token = "0x60010EC")]
			[Address(RVA = "0x62E9", Offset = "0x62E9", VA = "0x62E9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010ED")]
			[Address(RVA = "0x62EA", Offset = "0x62EA", VA = "0x62EA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010EE")]
		[Address(RVA = "0x62EB", Offset = "0x62EB", VA = "0x62EB")]
		public HistoryModel(UserData user)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_WorldAxis_Office_Model_HistoryModel___ctor
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58b0d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		              );
		    DAT_ram_00a58b0d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  uVar2 = Core_Extensions_Dict_CollectionsDicExt__GetDescription(param2,0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  uVar2 = Core_Extensions_Dict_ColossusDicExt__GetIcon1024(param2,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060010EF RID: 4335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60010EF")]
		[Address(RVA = "0x62EC", Offset = "0x62EC", VA = "0x62EC")]
		private FilterWithIconListElement.FilterWithIconData CreateFilterDatas(ColossusDic dic)
		{
		/* --- GHIDRA: CreateFilterDatas ---
		void Gameplay_WorldAxis_Office_Model_HistoryModel__CreateFilterDatas
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param3_00;
		  int param3_01;
		  
		  if (DAT_ram_00a58b0e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BattleHistoryListElement_BattleHistoryListElementArgs__Clear__
		              );
		    DAT_ram_00a58b0e = '\x01';
		  }
		  param3_00 = *(int *)(param1 + 0x2c);
		  param3_01 = *(int *)(param3_00 + 0xc);
		  *(undefined4 *)(param3_00 + 0xc) = 0;
		  *(int *)(param3_00 + 0x10) = *(int *)(param3_00 + 0x10) + 1;
		  if (0 < param3_01) {
		    func_ii_2064(*(undefined4 *)(param3_00 + 8),0,param3_01,0);
		  }
		  Gameplay_WorldAxis_Office_Model_HistoryModel__CreateBattlesList(param1,param2,param3_00);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F0")]
		[Address(RVA = "0x62ED", Offset = "0x62ED", VA = "0x62ED")]
		public void CreateBattlesList(ProtoGetColossusBattlesAns msg)
		{
		/* --- GHIDRA: CreateBattlesList ---
		void Gameplay_WorldAxis_Office_Model_HistoryModel__CreateBattlesList
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58b0f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoGetColossusBattlesAns_Types_ColossusBattle__BattleHistoryListElement_BattleHistoryListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_BattleHistoryListElement_BattleHistoryListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoGetColossusBattlesAns_Types_ColossusBattle__BattleHistoryListElement_BattleHistoryListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_HistoryModel_ConstructArgs__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BattleHistoryListElement_BattleHistoryListElementArgs__AddRange__
		              );
		    DAT_ram_00a58b0f = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 0xc);
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_ProtoGetColossusBattlesAns_Types_ColossusBattle__BattleHistoryListElement_BattleHistoryListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_WorldAxis_Office_Model_HistoryModel_ConstructArgs__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_Select_ProtoGetColossusBattlesAns_Types_ColossusBattle__BattleHistoryListElement_BattleHistoryListElementArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_BattleHistoryListElement_BattleHistoryListElementArgs___
		                      );
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  func_ii_6335(*(undefined4 *)(param1 + 0x2c),uVar1,
		               Method_System_Collections_Generic_List_BattleHistoryListElement_BattleHistoryListElementArgs__AddRange__
		              );
		  *(undefined4 *)(param1 + 0x1c) = *(undefined4 *)(param2 + 0x18);
		  return;
		}
		*/

		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F1")]
		[Address(RVA = "0x62EE", Offset = "0x62EE", VA = "0x62EE")]
		public void AddBattles(ProtoGetColossusBattlesAns msg)
		{
		/* --- GHIDRA: AddBattles ---
		int Gameplay_WorldAxis_Office_Model_HistoryModel__AddBattles
		              (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58b10 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ColossusDic__get_Item__);
		    DAT_ram_00a58b10 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement_BattleHistoryListElementArgs_TypeInfo
		                        );
		  Gameplay_WorldAxis_Office_View_History_BattleHistoryListElement___ctor(param1_00,0);
		  *(int *)(param1_00 + 0x1c) = param2;
		  iVar2 = *(int *)(*(int *)(param2 + 0x24) + 0xc);
		  uVar1 = Core_Gameplay_Managers_ClansManager__ShowClanInfoWindow
		                    (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(iVar2 + 0x1c),
		                     *(undefined4 *)(iVar2 + 0x20),0);
		  *(undefined4 *)(param1_00 + 0x24) = uVar1;
		  iVar2 = *(int *)(*(int *)(param2 + 0x28) + 0xc);
		  uVar1 = Core_Gameplay_Managers_ClansManager__ShowClanInfoWindow
		                    (*(undefined4 *)(param1 + 0xc),*(undefined4 *)(iVar2 + 0x1c),
		                     *(undefined4 *)(iVar2 + 0x20),0);
		  *(undefined4 *)(param1_00 + 0x28) = uVar1;
		  *(undefined4 *)(param1_00 + 0x2c) = *(undefined4 *)(param1 + 0x14);
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param2 + 0x20),
		                     Method_System_Collections_Generic_Dictionary_uint__ColossusDic__get_Item__);
		  *(undefined4 *)(param1_00 + 0x20) = uVar1;
		  *(undefined4 *)(param1_00 + 0x30) = *(undefined4 *)(param1 + 8);
		  return param1_00;
		}
		*/

		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60010F2")]
		[Address(RVA = "0x62EF", Offset = "0x62EF", VA = "0x62EF")]
		private BattleHistoryListElement.BattleHistoryListElementArgs ConstructArgs(ProtoGetColossusBattlesAns.Types.ColossusBattle battle)
		{
		/* --- GHIDRA: ConstructArgs ---
		void Gameplay_WorldAxis_Office_Model_HistoryModel__ConstructArgs
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param5;
		  undefined4 param1_00;
		  undefined4 param4_00;
		  
		  if (DAT_ram_00a58b11 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Model_HistoryModel_BattleFullInfo_TypeInfo);
		    DAT_ram_00a58b11 = '\x01';
		  }
		  param4_00 = *(undefined4 *)(param1 + 0x28);
		  param5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                     (*(undefined4 *)(param1 + 0x10),0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_WorldAxis_Office_Model_HistoryModel_BattleFullInfo_TypeInfo);
		  Gameplay_WorldAxis_Office_Model_HistoryModel_Participant___ctor
		            (param1_00,param2,param3,param4_00,param5,param1);
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010F3")]
		[Address(RVA = "0x62F0", Offset = "0x62F0", VA = "0x62F0")]
		public void PopulateParticipants(IList<ProtoGetColossusBattleInfoAns.Types.BattleParticipants> participants, BattleHistoryListElement.BattleHistoryListElementArgs battle)
		{
		}

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[FieldOffset(Offset = "0xC")]
		private ClansManager _clansManager;

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[FieldOffset(Offset = "0x10")]
		private DictManager _dictManager;

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x14")]
		private ColossusRatingDic[] _validRatings;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, ColossusDic> _colossusById;

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[FieldOffset(Offset = "0x28")]
		private readonly int _maxPlayers;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0x2C")]
		public readonly List<BattleHistoryListElement.BattleHistoryListElementArgs> Battles;

		// Token: 0x020002CD RID: 717
		[Token(Token = "0x20002CD")]
		public class Participant
		{
			// Token: 0x060010F4 RID: 4340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010F4")]
			[Address(RVA = "0x62F1", Offset = "0x62F1", VA = "0x62F1")]
			public Participant()
			{
			}

			// Token: 0x040008C0 RID: 2240
			[Token(Token = "0x40008C0")]
			[FieldOffset(Offset = "0x8")]
			public ProtoGetColossusBattleInfoAns.Types.BattleParticipants Info;

			// Token: 0x040008C1 RID: 2241
			[Token(Token = "0x40008C1")]
			[FieldOffset(Offset = "0xC")]
			public bool IsDead;

			// Token: 0x040008C2 RID: 2242
			[Token(Token = "0x40008C2")]
			[FieldOffset(Offset = "0x10")]
			public StonesTypes StoneType;

			// Token: 0x040008C3 RID: 2243
			[Token(Token = "0x40008C3")]
			[FieldOffset(Offset = "0x14")]
			public Sprite DollSprite;
		}

		// Token: 0x020002CE RID: 718
		[Token(Token = "0x20002CE")]
		public class BattleFullInfo
		{
			// Token: 0x060010F5 RID: 4341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010F5")]
			[Address(RVA = "0x62F2", Offset = "0x62F2", VA = "0x62F2")]
			public BattleFullInfo(IList<ProtoGetColossusBattleInfoAns.Types.BattleParticipants> participants, BattleHistoryListElement.BattleHistoryListElementArgs battle, int maxPlayers, Dictionaries dict)
			{
			}

			// Token: 0x040008C4 RID: 2244
			[Token(Token = "0x40008C4")]
			[FieldOffset(Offset = "0x8")]
			public BattleHistoryListElement.BattleHistoryListElementArgs Battle;

			// Token: 0x040008C5 RID: 2245
			[Token(Token = "0x40008C5")]
			[FieldOffset(Offset = "0xC")]
			public HistoryModel.Participant[] WinSquad;

			// Token: 0x040008C6 RID: 2246
			[Token(Token = "0x40008C6")]
			[FieldOffset(Offset = "0x10")]
			public HistoryModel.Participant[] LoseSquad;

			// Token: 0x040008C7 RID: 2247
			[Token(Token = "0x40008C7")]
			[FieldOffset(Offset = "0x14")]
			public int MaxPlayers;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_LastRequestedBattles ---
		undefined4
		Gameplay_WorldAxis_Office_Model_HistoryModel__set_LastRequestedBattles(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58b0b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ColossusDic__FilterWithIconListElement_FilterWithIconData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_FilterWithIconListElement_FilterWithIconData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ColossusDic__FilterWithIconListElement_FilterWithIconData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_HistoryModel_CreateFilterDatas__);
		    DAT_ram_00a58b0b = '\x01';
		  }
		  iVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0x10),0);
		  param1_00 = *(undefined4 *)(iVar1 + 0x1ec);
		  uVar2 = unnamed_function_1417
		                    (System_Func_ColossusDic__FilterWithIconListElement_FilterWithIconData__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar2,param1,Method_Gameplay_WorldAxis_Office_Model_HistoryModel_CreateFilterDatas__,0)
		  ;
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_00,uVar2,
		                     Method_System_Linq_Enumerable_Select_ColossusDic__FilterWithIconListElement_FilterWithIconData___
		                    );
		  uVar2 = func_ii_6295(uVar2,
		                       Method_System_Linq_Enumerable_ToArray_FilterWithIconListElement_FilterWithIconData___
		                      );
		  return uVar2;
		}
		*/


		/* --- GHIDRA: set_CurrentBattleInfo ---
		void Gameplay_WorldAxis_Office_Model_HistoryModel__set_CurrentBattleInfo
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a58b0c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ColossusRatingDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToDictionary_ColossusDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_ColossusRatingDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_ColossusDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ColossusRatingDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BattleHistoryListElement_BattleHistoryListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BattleHistoryListElement_BattleHistoryListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ColossusSlotsInfoDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_HistoryModel___c___ctor_b__22_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_HistoryModel___c___ctor_b__22_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo);
		    DAT_ram_00a58b0c = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_BattleHistoryListElement_BattleHistoryListElementArgs__TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,
		             Method_System_Collections_Generic_List_BattleHistoryListElement_BattleHistoryListElementArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x80f761a7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f761a7:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		        goto code_r0x80f76256;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80f76256:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  iVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0x10),0);
		  uVar2 = *(undefined4 *)(iVar5 + 0x238);
		  if (*(int *)(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[1];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo + 0x5c);
		    }
		    uVar7 = *puVar6;
		    iVar5 = unnamed_function_1417(System_Func_ColossusRatingDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar5,uVar7,Method_Gameplay_WorldAxis_Office_Model_HistoryModel___c___ctor_b__22_0__,
		               0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo + 0x5c) + 4) = iVar5
		    ;
		  }
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar2,iVar5,Method_System_Linq_Enumerable_Where_ColossusRatingDic___);
		  uVar2 = func_ii_6295(uVar2,Method_System_Linq_Enumerable_ToArray_ColossusRatingDic___);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  iVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0x10),0);
		  uVar2 = *(undefined4 *)(iVar5 + 0x1ec);
		  if (*(int *)(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo + 0x5c);
		  iVar5 = puVar6[2];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo);
		      puVar6 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo + 0x5c);
		    }
		    uVar7 = *puVar6;
		    iVar5 = unnamed_function_1417(System_Func_ColossusDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar5,uVar7,Method_Gameplay_WorldAxis_Office_Model_HistoryModel___c___ctor_b__22_1__,
		               0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_Office_Model_HistoryModel___c_TypeInfo + 0x5c) + 8) = iVar5
		    ;
		  }
		  uVar2 = System_Linq_Enumerable__ToDictionary_object__object_
		                    (uVar2,iVar5,Method_System_Linq_Enumerable_ToDictionary_ColossusDic__uint___);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  iVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0x10),0);
		  *(undefined4 *)(param1 + 0x28) = *(undefined4 *)(*(int *)(iVar5 + 0x204) + 0xc);
		  return;
		}
		*/

}
