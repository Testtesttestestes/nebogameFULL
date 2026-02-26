using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Model;
using Gameplay.GameEvents.View.Lists;
using Il2CppDummyDll;
using UI;
using UI.Tabs;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GameEvents.View
{
	// Token: 0x0200077C RID: 1916
	[Token(Token = "0x200077C")]
	public class GameEventsListView : MonoBehaviourWithStates<GameEventsListView.GameEventsListViewStates>
	{
		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008C2")]
		public Toggle SelectAll
		{
			[Token(Token = "0x6002D99")]
			[Address(RVA = "0x7E17", Offset = "0x7E17", VA = "0x7E17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008C3")]
		public Button DeleteButton
		{
			[Token(Token = "0x6002D9A")]
			[Address(RVA = "0x7E18", Offset = "0x7E18", VA = "0x7E18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008C4")]
		public Button CancelEditMode
		{
			[Token(Token = "0x6002D9B")]
			[Address(RVA = "0x7E19", Offset = "0x7E19", VA = "0x7E19")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008C5")]
		public TabBar TabBar
		{
			[Token(Token = "0x6002D9C")]
			[Address(RVA = "0x7E1A", Offset = "0x7E1A", VA = "0x7E1A")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000165 RID: 357
		// (add) Token: 0x06002D9D RID: 11677 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002D9E RID: 11678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000165")]
		public event Action<GameEventsListView> OnReady
		{
			[Token(Token = "0x6002D9D")]
			[Address(RVA = "0x7E1B", Offset = "0x7E1B", VA = "0x7E1B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002D9E")]
			[Address(RVA = "0x7E1C", Offset = "0x7E1C", VA = "0x7E1C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9F")]
		[Address(RVA = "0x7E1D", Offset = "0x7E1D", VA = "0x7E1D")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GameEvents_View_GameEventsListView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5748f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_View_GameEventsListView_HandleListAdapterInit__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_GameEventsListView_GameEventsListViewStates__set_CurrentState__
		              );
		    DAT_ram_00a5748f = '\x01';
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,1,
		             Method_UI_MonoBehaviourWithStates_GameEventsListView_GameEventsListViewStates__set_CurrentState__
		            );
		  piVar1 = *(int **)(param1 + 0x20);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_GameEvents_View_GameEventsListView_HandleListAdapterInit__,0);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x298) * 4))
		            (piVar1,param1_00,*(undefined4 *)(iVar2 + 0x29c));
		  return;
		}
		*/

		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA0")]
		[Address(RVA = "0x7E1E", Offset = "0x7E1E", VA = "0x7E1E")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_GameEvents_View_GameEventsListView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57490 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_View_GameEventsListView_HandleListAdapterInit__);
		    DAT_ram_00a57490 = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x20);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_GameEvents_View_GameEventsListView_HandleListAdapterInit__,0);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2a0) * 4))
		            (piVar1,param1_00,*(undefined4 *)(iVar2 + 0x2a4));
		  iVar2 = *(int *)(param1 + 0x38);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA1")]
		[Address(RVA = "0x7E1F", Offset = "0x7E1F", VA = "0x7E1F")]
		private void HandleListAdapterInit()
		{
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002DA3 RID: 11683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C6")]
		public List<GameEventsListView.GameEventsListItemWrapper> Events
		{
			[Token(Token = "0x6002DA2")]
			[Address(RVA = "0x7E20", Offset = "0x7E20", VA = "0x7E20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DA3")]
			[Address(RVA = "0x7E21", Offset = "0x7E21", VA = "0x7E21")]
			set
			{
			}
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA4")]
		[Address(RVA = "0x7E22", Offset = "0x7E22", VA = "0x7E22")]
		private void HandleEventsChanges()
		{
		/* --- GHIDRA: HandleEventsChanges ---
		void Gameplay_GameEvents_View_GameEventsListView__HandleEventsChanges(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint param2_00;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a57491 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__get_Count__
		              );
		    DAT_ram_00a57491 = '\x01';
		  }
		  param2_00 = 1;
		  if (*(int *)(param1 + 0x3c) != 0) {
		    param2_00 = (uint)(*(int *)(*(int *)(param1 + 0x3c) + 0xc) == 0);
		  }
		  iVar3 = *(int *)(param1 + 0x30);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    do {
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,param2_00,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  iVar3 = *(int *)(param1 + 0x34);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    do {
		      uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,param2_00 ^ 1,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA5")]
		[Address(RVA = "0x7E23", Offset = "0x7E23", VA = "0x7E23")]
		private void ValidateEmptyList()
		{
		/* --- GHIDRA: ValidateEmptyList ---
		void Gameplay_GameEvents_View_GameEventsListView__ValidateEmptyList
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57492 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_int__get_Item__);
		    DAT_ram_00a57492 = '\x01';
		  }
		  iVar2 = *(int *)(param2 + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = System_Linq_Enumerable__ToList_object_
		                        (param2,param2_00,Method_System_Collections_Generic_List_int__get_Item__);
		      if (DAT_ram_00a57493 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__RemoveAt__
		                  );
		        DAT_ram_00a57493 = '\x01';
		      }
		      iVar3 = *(int *)(param1 + 0x20);
		      if (DAT_ram_00a574aa == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__RemoveItems__
		                  );
		        DAT_ram_00a574aa = '\x01';
		      }
		      Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		                (*(undefined4 *)(iVar3 + 0xa0),iVar1 - param2_00,1,0,
		                 Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__RemoveItems__
		                );
		      UnityEngine_TextCore_Glyph__set_atlasIndex
		                (*(undefined4 *)(param1 + 0x3c),iVar1 - param2_00,
		                 Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__RemoveAt__
		                );
		      Gameplay_GameEvents_View_GameEventsListView__HandleEventsChanges(param1,param2_00);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  Gameplay_GameEvents_View_GameEventsListView__HandleEventsChanges(param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA6")]
		[Address(RVA = "0x7E24", Offset = "0x7E24", VA = "0x7E24")]
		public void RemoveEvents(List<int> indexes)
		{
		/* --- GHIDRA: RemoveEvents ---
		void Gameplay_GameEvents_View_GameEventsListView__RemoveEvents
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57493 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__RemoveAt__
		              );
		    DAT_ram_00a57493 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x20);
		  if (DAT_ram_00a574aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__RemoveItems__
		              );
		    DAT_ram_00a574aa = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___NotifyListChangedExternally
		            (*(undefined4 *)(iVar1 + 0xa0),param2,1,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__RemoveItems__
		            );
		  UnityEngine_TextCore_Glyph__set_atlasIndex
		            (*(undefined4 *)(param1 + 0x3c),param2,
		             Method_System_Collections_Generic_List_GameEventsListView_GameEventsListItemWrapper__RemoveAt__
		            );
		  Gameplay_GameEvents_View_GameEventsListView__HandleEventsChanges(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA7")]
		[Address(RVA = "0x7E25", Offset = "0x7E25", VA = "0x7E25")]
		public void RemoveEvent(int index)
		{
		/* --- GHIDRA: RemoveEvent ---
		void Gameplay_GameEvents_View_GameEventsListView__RemoveEvent(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57494 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_GameEventsListView_GameEventsListViewStates___ctor__
		              );
		    DAT_ram_00a57494 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_UI_MonoBehaviourWithStates_GameEventsListView_GameEventsListViewStates___ctor__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA8")]
		[Address(RVA = "0x7E26", Offset = "0x7E26", VA = "0x7E26")]
		public GameEventsListView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_View_GameEventsListView___ctor(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x040018FE RID: 6398
		[Token(Token = "0x40018FE")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x040018FF RID: 6399
		[Token(Token = "0x40018FF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameEventsListAdapter _listAdapter;

		// Token: 0x04001900 RID: 6400
		[Token(Token = "0x4001900")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Toggle _selectAll;

		// Token: 0x04001901 RID: 6401
		[Token(Token = "0x4001901")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _deleteButton;

		// Token: 0x04001902 RID: 6402
		[Token(Token = "0x4001902")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _cancelEditMode;

		// Token: 0x04001903 RID: 6403
		[Token(Token = "0x4001903")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform[] _listIsEmptyItems;

		// Token: 0x04001904 RID: 6404
		[Token(Token = "0x4001904")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Transform[] _listIsNotEmptyItems;

		// Token: 0x04001906 RID: 6406
		[Token(Token = "0x4001906")]
		[FieldOffset(Offset = "0x3C")]
		private List<GameEventsListView.GameEventsListItemWrapper> _eventWrappers;

		// Token: 0x0200077D RID: 1917
		[Token(Token = "0x200077D")]
		public class GameEventsListItemWrapper : IDisposable
		{
			// Token: 0x06002DA9 RID: 11689 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DA9")]
			[Address(RVA = "0x7E27", Offset = "0x7E27", VA = "0x7E27", Slot = "1")]
			protected override void Finalize()
			{
			}

			// Token: 0x06002DAA RID: 11690 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DAA")]
			[Address(RVA = "0x7E28", Offset = "0x7E28", VA = "0x7E28", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x170008C7 RID: 2247
			// (get) Token: 0x06002DAB RID: 11691 RVA: 0x00008CE8 File Offset: 0x00006EE8
			// (set) Token: 0x06002DAC RID: 11692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008C7")]
			public bool IsEditMode
			{
				[Token(Token = "0x6002DAB")]
				[Address(RVA = "0x7E29", Offset = "0x7E29", VA = "0x7E29")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002DAC")]
				[Address(RVA = "0x7E2A", Offset = "0x7E2A", VA = "0x7E2A")]
				set
				{
				}
			}

			// Token: 0x14000166 RID: 358
			// (add) Token: 0x06002DAD RID: 11693 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06002DAE RID: 11694 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x14000166")]
			public event Action OnEditModeChanged
			{
				[Token(Token = "0x6002DAD")]
				[Address(RVA = "0x7E2B", Offset = "0x7E2B", VA = "0x7E2B")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6002DAE")]
				[Address(RVA = "0x7E2C", Offset = "0x7E2C", VA = "0x7E2C")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x14000167 RID: 359
			// (add) Token: 0x06002DAF RID: 11695 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06002DB0 RID: 11696 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x14000167")]
			public event Action OnSelectedChanged
			{
				[Token(Token = "0x6002DAF")]
				[Address(RVA = "0x7E2D", Offset = "0x7E2D", VA = "0x7E2D")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6002DB0")]
				[Address(RVA = "0x7E2E", Offset = "0x7E2E", VA = "0x7E2E")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x170008C8 RID: 2248
			// (get) Token: 0x06002DB1 RID: 11697 RVA: 0x00008D00 File Offset: 0x00006F00
			// (set) Token: 0x06002DB2 RID: 11698 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008C8")]
			public bool Selected
			{
				[Token(Token = "0x6002DB1")]
				[Address(RVA = "0x7E2F", Offset = "0x7E2F", VA = "0x7E2F")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002DB2")]
				[Address(RVA = "0x7E30", Offset = "0x7E30", VA = "0x7E30")]
				set
				{
				}
			}

			// Token: 0x06002DB3 RID: 11699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DB3")]
			[Address(RVA = "0x7E31", Offset = "0x7E31", VA = "0x7E31")]
			public GameEventsListItemWrapper()
			{
			}

			// Token: 0x04001907 RID: 6407
			[Token(Token = "0x4001907")]
			[FieldOffset(Offset = "0x8")]
			private bool _isEditMode;

			// Token: 0x0400190A RID: 6410
			[Token(Token = "0x400190A")]
			[FieldOffset(Offset = "0x14")]
			private bool _selected;

			// Token: 0x0400190B RID: 6411
			[Token(Token = "0x400190B")]
			[FieldOffset(Offset = "0x18")]
			public GameEventData EvtData;

			// Token: 0x0400190C RID: 6412
			[Token(Token = "0x400190C")]
			[FieldOffset(Offset = "0x1C")]
			public EventHandler<GameEventData> ItemClickHandler;

			// Token: 0x0400190D RID: 6413
			[Token(Token = "0x400190D")]
			[FieldOffset(Offset = "0x20")]
			public EventHandler<GameEventsListView.GameEventsListItemWrapper> SelectHandler;
		}

		// Token: 0x0200077E RID: 1918
		[Token(Token = "0x200077E")]
		public enum GameEventsListViewStates
		{
			// Token: 0x0400190F RID: 6415
			[Token(Token = "0x400190F")]
			UNKNOWN,
			// Token: 0x04001910 RID: 6416
			[Token(Token = "0x4001910")]
			DEFAULT,
			// Token: 0x04001911 RID: 6417
			[Token(Token = "0x4001911")]
			EDIT
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TabBar ---
		void Gameplay_GameEvents_View_GameEventsListView__get_TabBar
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5748c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameEventsListView__TypeInfo);
		    DAT_ram_00a5748c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_GameEventsListView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GameEventsListView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnReady ---
		void Gameplay_GameEvents_View_GameEventsListView__add_OnReady
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5748d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameEventsListView__TypeInfo);
		    DAT_ram_00a5748d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_GameEventsListView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GameEventsListView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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


		/* --- GHIDRA: remove_OnReady ---
		void Gameplay_GameEvents_View_GameEventsListView__remove_OnReady(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5748e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_View_GameEventsListView_HandleListAdapterInit__);
		    DAT_ram_00a5748e = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x20);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_GameEvents_View_GameEventsListView_HandleListAdapterInit__,0);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2a0) * 4))
		            (piVar1,param1_00,*(undefined4 *)(iVar2 + 0x2a4));
		  return;
		}
		*/


		/* --- GHIDRA: get_Events ---
		void Gameplay_GameEvents_View_GameEventsListView__get_Events
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  if (param2 != *(int *)(param1 + 0x3c)) {
		    *(int *)(param1 + 0x3c) = param2;
		    Gameplay_GameEvents_View_GameEventsListView__HandleEventsChanges(param1,param1);
		    param2_00 = *(undefined4 *)(param1 + 0x3c);
		    iVar1 = *(int *)(param1 + 0x20);
		    if (DAT_ram_00a574ab == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__ResetItems__
		                );
		      DAT_ram_00a574ab = '\x01';
		    }
		    Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		              (*(undefined4 *)(iVar1 + 0xa0),param2_00,0,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__ResetItems__
		              );
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_GameEvents_View_GameEventsListView__set_Events(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  Gameplay_GameEvents_View_GameEventsListView__HandleEventsChanges(param1,param1);
		  param2_00 = *(undefined4 *)(param1 + 0x3c);
		  iVar1 = *(int *)(param1 + 0x20);
		  if (DAT_ram_00a574ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__ResetItems__
		              );
		    DAT_ram_00a574ab = '\x01';
		  }
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(iVar1 + 0xa0),param2_00,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_GameEventsListView_GameEventsListItemWrapper__ResetItems__
		            );
		  return;
		}
		*/

}
