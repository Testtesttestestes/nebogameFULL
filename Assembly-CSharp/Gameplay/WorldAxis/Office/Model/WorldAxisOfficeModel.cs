using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.World.Model;
using Gameplay.WorldAxis.Model;
using Gameplay.WorldAxis.Office.View;
using Gameplay.WorldAxis.Office.View.Schedule;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Dic;
using UI.Tabs;

namespace Gameplay.WorldAxis.Office.Model
{
	// Token: 0x020002D6 RID: 726
	[Token(Token = "0x20002D6")]
	public class WorldAxisOfficeModel : AbstractModel
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700028A")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6001123")]
			[Address(RVA = "0x6320", Offset = "0x6320", VA = "0x6320")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x6321", Offset = "0x6321", VA = "0x6321")]
		public WorldAxisOfficeModel(UserData user, WorldAxisModel worldAxisModel)
		{
		/* --- GHIDRA: <AddRating>b__12_0 ---
		void Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel___AddRating_b__12_0
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined8 uVar2;
		  
		  if (DAT_ram_00a58b27 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__)
		    ;
		    DAT_ram_00a58b27 = '\x01';
		  }
		  uVar1 = func_ii_7325(*(undefined4 *)(param2 + 0xc),param3,0);
		  *(undefined4 *)(param1 + 8) = uVar1;
		  uVar2 = func_ii_7271(*(undefined4 *)(param2 + 0x10),0,
		                       Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__);
		  *(undefined8 *)(param1 + 0x10) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001126 RID: 4390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028B")]
		public ColossusBattleListElement.ColossusBattleListElementArgs[] ColossusBattles
		{
			[Token(Token = "0x6001125")]
			[Address(RVA = "0x6322", Offset = "0x6322", VA = "0x6322")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001126")]
			[Address(RVA = "0x6323", Offset = "0x6323", VA = "0x6323")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x6324", Offset = "0x6324", VA = "0x6324")]
		public List<TabBarItemData<WorldAxisOfficeWindow.Tab>> GetTabBarItemData()
		{
		/* --- GHIDRA: GetTabBarItemData ---
		void Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__GetTabBarItemData
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58b22 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ColossusBattleData__ColossusBattleListElement_ColossusBattleListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_ColossusBattleListElement_ColossusBattleListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ColossusBattleData__ColossusBattleListElement_ColossusBattleListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel_CreateArgs__);
		    DAT_ram_00a58b22 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x18);
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_ColossusBattleData__ColossusBattleListElement_ColossusBattleListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel_CreateArgs__,0
		            );
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_Select_ColossusBattleData__ColossusBattleListElement_ColossusBattleListElementArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_ColossusBattleListElement_ColossusBattleListElementArgs___
		                      );
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x6325", Offset = "0x6325", VA = "0x6325")]
		public void RepopulateColossusBattles()
		{
		/* --- GHIDRA: RepopulateColossusBattles ---
		void Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__RepopulateColossusBattles
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  int param1_01;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58b23 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__WorldAxisOfficeModel_ColossusClanRating____set_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_OrderByDescending_WorldAxisOfficeModel_ColossusClanRating__long___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ColossusRating__WorldAxisOfficeModel_ColossusClanRating___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToArray_WorldAxisOfficeModel_ColossusClanRating___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_WorldAxisOfficeModel_ColossusClanRating__long__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ColossusRating__WorldAxisOfficeModel_ColossusClanRating__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel___c__AddRating_b__12_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel___c_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__AddRating_b__12_0__);
		    DAT_ram_00a58b23 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417
		                    (System_Func_ColossusRating__WorldAxisOfficeModel_ColossusClanRating__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,
		             Method_Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__AddRating_b__12_0__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ColossusRating__WorldAxisOfficeModel_ColossusClanRating___
		                    );
		  if (*(int *)(Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)
		            (Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel___c_TypeInfo + 0x5c);
		  param1_01 = puVar2[1];
		  if (param1_01 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)
		                (Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_01 = unnamed_function_1417
		                          (System_Func_WorldAxisOfficeModel_ColossusClanRating__long__TypeInfo);
		    System_Func_object__Int32Enum___Invoke
		              (param1_01,param2_00,
		               Method_Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel___c__AddRating_b__12_1__,
		               0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel___c_TypeInfo + 0x5c) + 4)
		         = param1_01;
		  }
		  uVar1 = System_Linq_Enumerable__OrderByDescending_KeyValuePair_object__object___uint_
		                    (uVar1,param1_01,
		                     Method_System_Linq_Enumerable_OrderByDescending_WorldAxisOfficeModel_ColossusClanRating__long___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_WorldAxisOfficeModel_ColossusClanRating___
		                      );
		  System_Collections_Generic_Dictionary_uint__object___get_Item
		            (param1_00,param3,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__WorldAxisOfficeModel_ColossusClanRating____set_Item__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001129")]
		[Address(RVA = "0x6326", Offset = "0x6326", VA = "0x6326")]
		public void AddRating(IList<ColossusRating> ratings, uint colossusId)
		{
		/* --- GHIDRA: AddRating ---
		undefined4
		Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__AddRating
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58b24 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__WorldAxisOfficeModel_ColossusClanRating____get_Item__
		              );
		    DAT_ram_00a58b24 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 0x14),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__WorldAxisOfficeModel_ColossusClanRating____get_Item__
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x6327", Offset = "0x6327", VA = "0x6327")]
		public IList<WorldAxisOfficeModel.ColossusClanRating> GetRating(uint colossusId)
		{
		/* --- GHIDRA: GetRating ---
		int Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__GetRating
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a58b25 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_Office_View_Schedule_ColossusBattleListElement_ColossusBattleListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58b25 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_Office_View_Schedule_ColossusBattleListElement_ColossusBattleListElementArgs_TypeInfo
		                        );
		  Gameplay_WorldAxis_Office_View_Schedule_ColossusBattleListElement___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param2;
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x6328", Offset = "0x6328", VA = "0x6328")]
		private ColossusBattleListElement.ColossusBattleListElementArgs CreateArgs(ColossusBattleData data)
		{
		/* --- GHIDRA: CreateArgs ---
		int Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__CreateArgs
		              (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined8 uVar3;
		  
		  if (DAT_ram_00a58b26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel_ColossusClanRating_TypeInfo);
		    DAT_ram_00a58b26 = '\x01';
		  }
		  uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(param1 + 0xc),0);
		  iVar2 = unnamed_function_1417
		                    (
		                    Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel_ColossusClanRating_TypeInfo
		                    );
		  if (DAT_ram_00a58b27 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__)
		    ;
		    DAT_ram_00a58b27 = '\x01';
		  }
		  uVar1 = func_ii_7325(*(undefined4 *)(param2 + 0xc),uVar1,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  uVar3 = func_ii_7271(*(undefined4 *)(param2 + 0x10),0,
		                       Method_Google_Protobuf_Collections_RepeatedField_long__get_Item__);
		  *(undefined8 *)(iVar2 + 0x10) = uVar3;
		  return iVar2;
		}
		*/

			return null;
		}

		// Token: 0x040008E7 RID: 2279
		[Token(Token = "0x40008E7")]
		[FieldOffset(Offset = "0xC")]
		private readonly DictManager _dictManager;

		// Token: 0x040008E8 RID: 2280
		[Token(Token = "0x40008E8")]
		[FieldOffset(Offset = "0x10")]
		public readonly WorldAxisModel WorldAxisModel;

		// Token: 0x040008E9 RID: 2281
		[Token(Token = "0x40008E9")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<uint, WorldAxisOfficeModel.ColossusClanRating[]> _colossusRatingsDict;

		// Token: 0x020002D7 RID: 727
		[Token(Token = "0x20002D7")]
		public class ColossusClanRating
		{
			// Token: 0x0600112D RID: 4397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600112D")]
			[Address(RVA = "0x632A", Offset = "0x632A", VA = "0x632A")]
			public ColossusClanRating(ColossusRating rating, Dictionaries dict)
			{
			}

			// Token: 0x0600112E RID: 4398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600112E")]
			[Address(RVA = "0x632B", Offset = "0x632B", VA = "0x632B")]
			public ColossusClanRating()
			{
			}

			// Token: 0x040008EB RID: 2283
			[Token(Token = "0x40008EB")]
			[FieldOffset(Offset = "0x8")]
			public ClanData ClanData;

			// Token: 0x040008EC RID: 2284
			[Token(Token = "0x40008EC")]
			[FieldOffset(Offset = "0x10")]
			public long Score;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Dict ---
		void Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__get_Dict
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58b20 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__WorldAxisOfficeModel_ColossusClanRating_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_uint__WorldAxisOfficeModel_ColossusClanRating____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58b20 = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_uint__WorldAxisOfficeModel_ColossusClanRating____TypeInfo
		                    );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar2,
		             Method_System_Collections_Generic_Dictionary_uint__WorldAxisOfficeModel_ColossusClanRating_____ctor__
		            );
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80f77dc8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f77dc8:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0xc) = uVar2;
		  Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__GetTabBarItemData(param1,uVar2);
		  return;
		}
		*/


		/* --- GHIDRA: set_ColossusBattles ---
		int Gameplay_WorldAxis_Office_Model_WorldAxisOfficeModel__set_ColossusBattles
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a58b21 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab___ctor__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17794);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4245);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10752);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17768);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17823);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17797);
		    DAT_ram_00a58b21 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab___TypeInfo
		                        );
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,5,
		             Method_System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab____ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17823,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab__TypeInfo);
		  UI_Tabs_TabBarItemData_UInt32Enum____ctor
		            (uVar3,uVar2,0,Method_UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab___ctor__);
		  iVar1 = Method_System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_00 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  if (*(char *)(*(int *)(param1 + 0x10) + 0x20) != '\0') {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17768,1,0,1,0,0,0,0);
		    uVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab__TypeInfo);
		    UI_Tabs_TabBarItemData_UInt32Enum____ctor
		              (uVar3,uVar2,1,Method_UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab___ctor__);
		    iVar1 = Method_System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab___Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar3;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4245,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab__TypeInfo);
		  UI_Tabs_TabBarItemData_UInt32Enum____ctor
		            (uVar3,uVar2,2,Method_UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab___ctor__);
		  iVar1 = Method_System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_00 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17794,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab__TypeInfo);
		  UI_Tabs_TabBarItemData_UInt32Enum____ctor
		            (uVar3,uVar2,3,Method_UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab___ctor__);
		  iVar1 = Method_System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_00 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_17797,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab__TypeInfo);
		  UI_Tabs_TabBarItemData_UInt32Enum____ctor
		            (uVar3,uVar2,4,Method_UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab___ctor__);
		  iVar1 = Method_System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_00 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10752,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab__TypeInfo);
		  UI_Tabs_TabBarItemData_UInt32Enum____ctor
		            (uVar3,uVar2,5,Method_UI_Tabs_TabBarItemData_WorldAxisOfficeWindow_Tab___ctor__);
		  iVar1 = Method_System_Collections_Generic_List_TabBarItemData_WorldAxisOfficeWindow_Tab___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_00 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar3;
		    return param1_00;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return param1_00;
		}
		*/

}
