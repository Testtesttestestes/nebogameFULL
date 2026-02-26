using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Portals.View.MyBetsTab;
using Gameplay.Portals.View.TotalizatorTab;
using Gameplay.Rating.Model;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Portal;

namespace Gameplay.Portals.Model
{
	// Token: 0x020005D0 RID: 1488
	[Token(Token = "0x20005D0")]
	public class PortalsMyBetsModel : RatingModel
	{
		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060023C9 RID: 9161 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023CA RID: 9162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BA")]
		public RepeatedField<BetHistoryRow> History
		{
			[Token(Token = "0x60023C9")]
			[Address(RVA = "0x751B", Offset = "0x751B", VA = "0x751B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023CA")]
			[Address(RVA = "0x751C", Offset = "0x751C", VA = "0x751C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023CC RID: 9164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BB")]
		public StageInPortalsMyBetsListElement.StageInPortalsMyBetsListElementArgs[] HistoryCache
		{
			[Token(Token = "0x60023CB")]
			[Address(RVA = "0x751D", Offset = "0x751D", VA = "0x751D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023CC")]
			[Address(RVA = "0x751E", Offset = "0x751E", VA = "0x751E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060023CD RID: 9165 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023CE RID: 9166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BC")]
		public UserInPortalTotalizatorListElement.UserInPortalTotalizatorListElementArgs[] UsersCache
		{
			[Token(Token = "0x60023CD")]
			[Address(RVA = "0x751F", Offset = "0x751F", VA = "0x751F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023CE")]
			[Address(RVA = "0x7520", Offset = "0x7520", VA = "0x7520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060023CF RID: 9167 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060023D0 RID: 9168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BD")]
		public BetList CurrentBetList
		{
			[Token(Token = "0x60023CF")]
			[Address(RVA = "0x7521", Offset = "0x7521", VA = "0x7521")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60023D0")]
			[Address(RVA = "0x7522", Offset = "0x7522", VA = "0x7522")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006BE")]
		public IGame Game
		{
			[Token(Token = "0x60023D1")]
			[Address(RVA = "0x7523", Offset = "0x7523", VA = "0x7523")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D2")]
		[Address(RVA = "0x7524", Offset = "0x7524", VA = "0x7524")]
		public PortalsMyBetsModel(UserData user, IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Model_PortalsMyBetsModel___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58127 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_Bet__UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_Bet__UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Portals_Model_PortalsMyBetsModel_ConstructArgs__);
		    DAT_ram_00a58127 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x54) + 0x18);
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Func_Bet__UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_Portals_Model_PortalsMyBetsModel_ConstructArgs__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_Select_Bet__UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___
		                    );
		  uVar1 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs___
		                      );
		  *(undefined4 *)(param1 + 0x50) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D3")]
		[Address(RVA = "0x7525", Offset = "0x7525", VA = "0x7525")]
		public void PopulateUsers()
		{
		/* --- GHIDRA: PopulateUsers ---
		void Gameplay_Portals_Model_PortalsMyBetsModel__PopulateUsers(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 *puVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  undefined4 uVar10;
		  uint uVar11;
		  int local_20;
		  undefined8 *local_1c;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 uStack_c;
		  undefined4 local_8;
		  undefined4 uStack_4;
		  
		  if (DAT_ram_00a58128 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_BetHistoryRow___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_GroupBy_BetHistoryRow__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToDictionary_IGrouping_uint__BetHistoryRow___uint__List_BetHistoryRow____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_BetHistoryRow___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_BetHistoryRow___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_BetHistoryRow___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_BetHistoryRow__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_IGrouping_uint__BetHistoryRow___List_BetHistoryRow___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IGrouping_uint__BetHistoryRow___uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_uint__List_BetHistoryRow___get_Key__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_KeyValuePair_uint__List_BetHistoryRow___get_Value__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_StageInPortalsMyBetsListElement_StageInPortalsMyBetsListElementArgs__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_StageInPortalsMyBetsListElement_StageInPortalsMyBetsListElementArgs__ToArray__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_StageInPortalsMyBetsListElement_StageInPortalsMyBetsListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_StageInPortalsMyBetsListElement_StageInPortalsMyBetsListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_View_MyBetsTab_StageInPortalsMyBetsListElement_StageInPortalsMyBetsListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Model_PortalsMyBetsModel___c__PopulateHistory_b__21_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Model_PortalsMyBetsModel___c__PopulateHistory_b__21_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Model_PortalsMyBetsModel___c__PopulateHistory_b__21_2__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo);
		    DAT_ram_00a58128 = '\x01';
		  }
		  local_8 = 0;
		  uStack_4 = 0;
		  local_10 = 0;
		  uStack_c = 0;
		  local_18 = 0;
		  uVar4 = *(undefined4 *)(param1 + 0x48);
		  if (*(int *)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x5c);
		  iVar6 = puVar5[1];
		  if (iVar6 == 0) {
		    if (*(int *)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x5c);
		    }
		    uVar10 = *puVar5;
		    iVar6 = unnamed_function_1417(System_Func_BetHistoryRow__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar6,uVar10,
		               Method_Gameplay_Portals_Model_PortalsMyBetsModel___c__PopulateHistory_b__21_0__,0);
		    *(int *)(*(int *)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x5c) + 4) = iVar6;
		  }
		  uVar4 = System_Linq_Enumerable__GroupBy_object__uint_
		                    (uVar4,iVar6,Method_System_Linq_Enumerable_GroupBy_BetHistoryRow__uint___);
		  if (*(int *)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo);
		  }
		  puVar5 = *(undefined4 **)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x5c);
		  iVar7 = puVar5[2];
		  iVar6 = Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo;
		  if (iVar7 == 0) {
		    if (*(int *)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo);
		      puVar5 = *(undefined4 **)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x5c);
		    }
		    uVar10 = *puVar5;
		    iVar7 = unnamed_function_1417(System_Func_IGrouping_uint__BetHistoryRow___uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar7,uVar10,
		               Method_Gameplay_Portals_Model_PortalsMyBetsModel___c__PopulateHistory_b__21_1__,0);
		    iVar6 = Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo;
		    *(int *)(*(int *)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x5c) + 8) = iVar7;
		  }
		  if (*(int *)(iVar6 + 0x74) == 0) {
		    func_ii_306000(iVar6);
		    iVar6 = Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo;
		  }
		  puVar5 = *(undefined4 **)(iVar6 + 0x5c);
		  iVar8 = puVar5[3];
		  if (iVar8 == 0) {
		    if (*(int *)(iVar6 + 0x74) == 0) {
		      func_ii_306000(iVar6);
		      puVar5 = *(undefined4 **)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x5c);
		    }
		    uVar10 = *puVar5;
		    iVar8 = unnamed_function_1417
		                      (System_Func_IGrouping_uint__BetHistoryRow___List_BetHistoryRow___TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar8,uVar10,
		               Method_Gameplay_Portals_Model_PortalsMyBetsModel___c__PopulateHistory_b__21_2__,0);
		    *(int *)(*(int *)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x5c) + 0xc) = iVar8;
		  }
		  uVar11 = 0;
		  uVar4 = System_Linq_Enumerable__ToDictionary_object__object__object_
		                    (uVar4,iVar7,iVar8,
		                     Method_System_Linq_Enumerable_ToDictionary_IGrouping_uint__BetHistoryRow___uint__List_BetHistoryRow____
		                    );
		  iVar6 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_StageInPortalsMyBetsListElement_StageInPortalsMyBetsListElementArgs__TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar6,
		             Method_System_Collections_Generic_List_StageInPortalsMyBetsListElement_StageInPortalsMyBetsListElementArgs___ctor__
		            );
		  piVar9 = *(int **)(param1 + 0x58);
		  iVar7 = *piVar9;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8 + 4) * 8 + iVar7 + 0x290);
		        goto code_r0x80ea61e4;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea61e4:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar9,puVar2[1]);
		  uVar10 = *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x10) + 0xc);
		  System_Collections_Generic_List_object___GetEnumerator
		            (&local_18,uVar4,
		             Method_System_Collections_Generic_Dictionary_uint__List_BetHistoryRow___GetEnumerator__
		            );
		  local_20 = 0;
		  local_1c = &local_18;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x155,&local_18,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_uint__List_BetHistoryRow___MoveNext__
		                      );
		    uVar1 = local_8;
		    uVar4 = uStack_c;
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ea6437;
		    }
		    if (iVar8 == 0) break;
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Portals_View_MyBetsTab_StageInPortalsMyBetsListElement_StageInPortalsMyBetsListElementArgs_TypeInfo
		                      );
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ea6411:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ea6437;
		    }
		    if (DAT_ram_00a58114 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&
		                       Method_UI_Elements_GenericList_SelectableListElementArgs_StageInPortalsMyBetsListElement___ctor__
		                );
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80ea6411;
		      DAT_ram_00a58114 = '\x01';
		    }
		    DAT_ram_009d3e38 = 0;
		    UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		              (iVar7,
		               Method_UI_Elements_GenericList_SelectableListElementArgs_StageInPortalsMyBetsListElement___ctor__
		              );
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ea6411;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x111,
		                       *(undefined4 *)(param1 + 0xc),uVar4,uVar10,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ea6437;
		    }
		    *(undefined4 *)(iVar7 + 0x20) = uVar1;
		    *(int *)(iVar7 + 0x1c) = iVar3 + 1;
		    iVar8 = 
		    Method_System_Collections_Generic_List_StageInPortalsMyBetsListElement_StageInPortalsMyBetsListElementArgs__Add__
		    ;
		    *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		    uVar11 = *(uint *)(iVar6 + 0xc);
		    if (uVar11 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		      *(uint *)(iVar6 + 0xc) = uVar11 + 1;
		      *(int *)(*(int *)(iVar6 + 8) + uVar11 * 4 + 0x10) = iVar7;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar6,iVar7,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ea6437:
		        iVar7 = global_1;
		        iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar7 == iVar8) {
		          piVar9 = (int *)import::env::__cxa_begin_catch(uVar4);
		          iVar7 = *piVar9;
		          iVar8 = 0;
		          DAT_ram_009d3e38 = 0;
		          local_20 = iVar7;
		          import::env::invoke_v(0x123);
		          iVar3 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar3 != 1) {
		code_r0x80ea6484:
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 0) {
		              if ((iVar8 == 0) ||
		                 ((((iVar8 != 1 && (iVar8 != 2)) && (iVar8 != 3)) &&
		                  (((iVar8 != 4 && (iVar8 != 5)) && ((iVar8 != 6 && (iVar8 == 7)))))))) {
		                uVar4 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                                  (iVar6,
		                                   Method_System_Collections_Generic_List_StageInPortalsMyBetsListElement_StageInPortalsMyBetsListElementArgs__ToArray__
		                                  );
		                *(undefined4 *)(param1 + 0x4c) = uVar4;
		              }
		              return;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar4 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x112,&local_20);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          import::env::__resumeException(uVar4);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  iVar8 = 7;
		  iVar7 = local_20;
		  goto code_r0x80ea6484;
		}
		*/

		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D4")]
		[Address(RVA = "0x7526", Offset = "0x7526", VA = "0x7526")]
		public void PopulateHistory()
		{
		/* --- GHIDRA: PopulateHistory ---
		int Gameplay_Portals_Model_PortalsMyBetsModel__PopulateHistory
		              (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  uint *puVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined8 uVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a58129 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		              );
		    DAT_ram_00a58129 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Portals_View_TotalizatorTab_UserInPortalTotalizatorListElement_UserInPortalTotalizatorListElementArgs_TypeInfo
		                        );
		  Gameplay_Clans_Office_View_ClanResumesTab_UserInRatingListElement___ctor(param1_00,0);
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  piVar3 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8))
		      {
		        puVar1 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80ea65f1;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80ea65f1:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,uVar2,puVar1[1]);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  uVar5 = *(undefined8 *)(param2 + 0x18);
		  *(undefined1 *)(param1_00 + 0x40) = 1;
		  *(undefined4 *)(param1_00 + 0x28) = 1;
		  *(undefined8 *)(param1_00 + 0x20) = uVar5;
		  *(undefined4 *)(param1_00 + 0x30) = *(undefined4 *)(param2 + 0x10);
		  uVar6 = 0;
		  piVar3 = *(int **)(param1 + 0x58);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 0x290);
		        goto code_r0x80ea66a1;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3a);
		code_r0x80ea66a1:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		  uVar2 = Core_Extensions_Dict_PortalDicExt__GetAssetId
		                    (*(undefined4 *)(*(int *)(iVar4 + 0x10) + 0x3c),0);
		  *(undefined4 *)(param1_00 + 0x34) = uVar2;
		  *(undefined4 *)(param1_00 + 0x3c) = *(undefined4 *)(param2 + 0x20);
		  return param1_00;
		}
		*/

		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60023D5")]
		[Address(RVA = "0x7527", Offset = "0x7527", VA = "0x7527")]
		private UserInPortalTotalizatorListElement.UserInPortalTotalizatorListElementArgs ConstructArgs(Bet bet)
		{
		/* --- GHIDRA: ConstructArgs ---
		void Gameplay_Portals_Model_PortalsMyBetsModel__ConstructArgs(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5812a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo);
		    DAT_ram_00a5812a = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Portals_Model_PortalsMyBetsModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Game ---
		void Gameplay_Portals_Model_PortalsMyBetsModel__get_Game
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Gameplay_Rating_Model_RatingModel__get_CultsSubFilters(param1,param2,param1);
		  *(undefined4 *)(param1 + 0x58) = param3;
		  return;
		}
		*/

}
