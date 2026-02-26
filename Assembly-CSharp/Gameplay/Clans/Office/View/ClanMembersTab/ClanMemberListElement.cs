using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Gameplay.Rating.View;
using Il2CppDummyDll;
using Protocol.Rating;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;

namespace Gameplay.Clans.Office.View.ClanMembersTab
{
	// Token: 0x02000A35 RID: 2613
	[Token(Token = "0x2000A35")]
	public class ClanMemberListElement : GenericListElement<ClanMemberListElement.ClanMemberListElementArgs>
	{
		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06003DDE RID: 15838 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003DDF RID: 15839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5A")]
		public ClanMemberListElement.ClanMemberListElementArgs Data
		{
			[Token(Token = "0x6003DDE")]
			[Address(RVA = "0x8C9D", Offset = "0x8C9D", VA = "0x8C9D")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003DDF")]
			[Address(RVA = "0x8C9E", Offset = "0x8C9E", VA = "0x8C9E")]
			set
			{
			}
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE0")]
		[Address(RVA = "0x8C9F", Offset = "0x8C9F", VA = "0x8C9F")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement__Awake
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a57f74 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_CallElementClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_SelectChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanMemberListElement_ClanMemberListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UnityEngine_Events_UnityAction_ClanMemberListElement_ClanMemberListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Events_UnityEvent_ClanMemberListElement_ClanMemberListElementArgs__RemoveListener__
		              );
		    DAT_ram_00a57f74 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  uVar3 = unnamed_function_1417
		                    (
		                    UnityEngine_Events_UnityAction_ClanMemberListElement_ClanMemberListElementArgs__TypeInfo
		                    );
		  func_ii_7054(uVar3,param1,
		               Method_Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_CallElementClickedEvent__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar4,uVar3,
		             Method_UnityEngine_Events_UnityEvent_ClanMemberListElement_ClanMemberListElementArgs__RemoveListener__
		            );
		  iVar5 = *(int *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar3,param1,
		             Method_Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_SelectChangedEventHandler__
		             ,0);
		  if (DAT_ram_00a57f79 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a57f79 = '\x01';
		  }
		  param1_00 = *(int *)(iVar5 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,uVar3,0);
		    uVar4 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar5 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE1")]
		[Address(RVA = "0x8CA0", Offset = "0x8CA0", VA = "0x8CA0")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement__OnDestroy
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param2 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE2")]
		[Address(RVA = "0x8CA1", Offset = "0x8CA1", VA = "0x8CA1")]
		private void CallElementClickedEvent(ClanMemberListElement.ClanMemberListElementArgs args)
		{
		/* --- GHIDRA: CallElementClickedEvent ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement__CallElementClickedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 uVar3;
		  int param1_01;
		  
		  if (DAT_ram_00a57f75 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_SelectChangedEventHandler__
		              );
		    DAT_ram_00a57f75 = '\x01';
		  }
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  if (param2 != 0) {
		    uVar3 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_SelectChangedEventHandler__
		               ,0);
		    if (DAT_ram_00a57f78 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		      DAT_ram_00a57f78 = '\x01';
		    }
		    param1_00 = *(int *)(param2 + 0x10);
		    do {
		      iVar2 = 0;
		      param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,uVar3,0);
		      param2_00 = System_Action_bool__TypeInfo;
		      if ((param1_01 != 0) &&
		         (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) {
		        System_Activator__CreateInstance(param1_01,param2_00);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar2 = func_ii_4329(param2 + 0x10,iVar2,param1_00);
		      bVar1 = iVar2 != param1_00;
		      param1_00 = iVar2;
		    } while (bVar1);
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,*(undefined4 *)(*param1 + 0x104));
		  return;
		}
		*/

		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE3")]
		[Address(RVA = "0x8CA2", Offset = "0x8CA2", VA = "0x8CA2", Slot = "4")]
		protected override void OnInit(ClanMemberListElement.ClanMemberListElementArgs args)
		{
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE4")]
		[Address(RVA = "0x8CA3", Offset = "0x8CA3", VA = "0x8CA3")]
		private void SelectChangedEventHandler(bool select)
		{
		/* --- GHIDRA: SelectChangedEventHandler ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement__SelectChangedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x20),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE5")]
		[Address(RVA = "0x8CA4", Offset = "0x8CA4", VA = "0x8CA4", Slot = "7")]
		protected virtual void Select(bool isSelected)
		{
		/* --- GHIDRA: Select ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement__Select
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  ulonglong uVar4;
		  int param1_00;
		  double param1_01;
		  
		  if (DAT_ram_00a57f76 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanMemberListElement_ClanMemberListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_ClanMemberListElementBg_States__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    DAT_ram_00a57f76 = '\x01';
		  }
		  iVar3 = param1[0xb];
		  param1_00 = *(int *)(param1[6] + 0x18);
		  uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(iVar3,uVar1,0);
		  iVar3 = param1[0xd];
		  uVar4 = *(ulonglong *)(param1[6] + 0x28);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  param1_01 = (double)uVar4;
		  uVar2 = UI_SimpleIconValue__set_IconAssetId(param1_01,StringLiteral_28780,0);
		  uVar1 = (undefined4)((ulonglong)param1_01 >> 0x20);
		  UnityEngine_Component__GetComponentInChildren_object_(iVar3,uVar2,0);
		  iVar3 = param1[0xc];
		  uVar2 = func_ii_4443(param1[6] + 8,0);
		  UnityEngine_Component__GetComponentInChildren_object_(iVar3,uVar2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1[0xe],(uint)*(byte *)(param1[6] + 0x24),0);
		  Gameplay_Rating_View_UserView__get_UserData(param1[9],param1_00,0);
		  iVar3 = param1[10];
		  uVar2 = Gameplay_Boss_View_CaptainTab_BossSkillInfoView__set_DominateCultDescription
		                    (*(undefined4 *)(param1_00 + 0x4c),0);
		  AssetContent_GameImage__get_AssetId(iVar3,uVar2,0);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1[0xf],(uint)*(byte *)(param1[6] + 0x25),
		             Method_UI_MonoBehaviourWithStates_ClanMemberListElementBg_States__set_CurrentState__);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		            (CONCAT44(uVar1,param1),*(undefined1 *)(param1[6] + 0xc),*(undefined4 *)(*param1 + 0xfc)
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE6")]
		[Address(RVA = "0x8CA5", Offset = "0x8CA5", VA = "0x8CA5", Slot = "8")]
		protected virtual void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement__ApplyArgs
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f77 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanMemberListElement_ClanMemberListElementArgs___ctor__
		              );
		    DAT_ram_00a57f77 = '\x01';
		  }
		  UI_Elements_GenericList_GenericListArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_GenericListElement_ClanMemberListElement_ClanMemberListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE7")]
		[Address(RVA = "0x8CA6", Offset = "0x8CA6", VA = "0x8CA6")]
		public ClanMemberListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f78 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a57f78 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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

		}

		// Token: 0x040022B0 RID: 8880
		[Token(Token = "0x40022B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectedImage;

		// Token: 0x040022B1 RID: 8881
		[Token(Token = "0x40022B1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x040022B2 RID: 8882
		[Token(Token = "0x40022B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameImage _cultIcon;

		// Token: 0x040022B3 RID: 8883
		[Token(Token = "0x40022B3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _nickname;

		// Token: 0x040022B4 RID: 8884
		[Token(Token = "0x40022B4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _place;

		// Token: 0x040022B5 RID: 8885
		[Token(Token = "0x40022B5")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _score;

		// Token: 0x040022B6 RID: 8886
		[Token(Token = "0x40022B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _ribbon;

		// Token: 0x040022B7 RID: 8887
		[Token(Token = "0x40022B7")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ClanMemberListElementBg _background;

		// Token: 0x02000A36 RID: 2614
		[Token(Token = "0x2000A36")]
		public class ClanMemberListElementArgs : GenericListElementArgs
		{
			// Token: 0x14000198 RID: 408
			// (add) Token: 0x06003DE8 RID: 15848 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06003DE9 RID: 15849 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x14000198")]
			public event Action<bool> SelectChangedEvent
			{
				[Token(Token = "0x6003DE8")]
				[Address(RVA = "0x8CA7", Offset = "0x8CA7", VA = "0x8CA7")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6003DE9")]
				[Address(RVA = "0x8CA8", Offset = "0x8CA8", VA = "0x8CA8")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x17000C5B RID: 3163
			// (get) Token: 0x06003DEA RID: 15850 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
			// (set) Token: 0x06003DEB RID: 15851 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C5B")]
			public ulong Rating
			{
				[Token(Token = "0x6003DEA")]
				[Address(RVA = "0x8CA9", Offset = "0x8CA9", VA = "0x8CA9")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x6003DEB")]
				[Address(RVA = "0x8CAA", Offset = "0x8CAA", VA = "0x8CAA")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000C5C RID: 3164
			// (get) Token: 0x06003DEC RID: 15852 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
			// (set) Token: 0x06003DED RID: 15853 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C5C")]
			public bool Selected
			{
				[Token(Token = "0x6003DEC")]
				[Address(RVA = "0x8CAB", Offset = "0x8CAB", VA = "0x8CAB")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003DED")]
				[Address(RVA = "0x8CAC", Offset = "0x8CAC", VA = "0x8CAC")]
				set
				{
				}
			}

			// Token: 0x06003DEE RID: 15854 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
			[Token(Token = "0x6003DEE")]
			[Address(RVA = "0x8CAD", Offset = "0x8CAD", VA = "0x8CAD")]
			public ulong SelectUserRating(UserRatingTypes ratingType, RatingPeriods period)
			{
				return 0UL;
			}

			// Token: 0x06003DEF RID: 15855 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003DEF")]
			[Address(RVA = "0x8CAE", Offset = "0x8CAE", VA = "0x8CAE")]
			public ClanMemberListElementArgs()
			{
			}

			// Token: 0x06003DF0 RID: 15856 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003DF0")]
			[Address(RVA = "0x8CAF", Offset = "0x8CAF", VA = "0x8CAF")]
			[CompilerGenerated]
			private IList<ulong> <SelectUserRating>g__SelectPeriod|17_0(ref ClanMemberListElement.ClanMemberListElementArgs.<>c__DisplayClass17_0 A_1)
			{
				return null;
			}

			// Token: 0x040022B8 RID: 8888
			[Token(Token = "0x40022B8")]
			[FieldOffset(Offset = "0xC")]
			private bool _selected;

			// Token: 0x040022BA RID: 8890
			[Token(Token = "0x40022BA")]
			[FieldOffset(Offset = "0x14")]
			public Action<ClanMemberListElement> MemberButtonClickedEventHandler;

			// Token: 0x040022BB RID: 8891
			[Token(Token = "0x40022BB")]
			[FieldOffset(Offset = "0x18")]
			public UserData UserData;

			// Token: 0x040022BC RID: 8892
			[Token(Token = "0x40022BC")]
			[FieldOffset(Offset = "0x1C")]
			public IList<ulong> TodayRating;

			// Token: 0x040022BD RID: 8893
			[Token(Token = "0x40022BD")]
			[FieldOffset(Offset = "0x20")]
			public IList<ulong> YesterdayRating;

			// Token: 0x040022BE RID: 8894
			[Token(Token = "0x40022BE")]
			[FieldOffset(Offset = "0x24")]
			public bool IsHead;

			// Token: 0x040022BF RID: 8895
			[Token(Token = "0x40022BF")]
			[FieldOffset(Offset = "0x25")]
			public bool IsMy;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement__get_Data
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param1_00;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57f72 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_SelectChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanMemberListElement_ClanMemberListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanMemberListElement_ClanMemberListElementArgs__get_Initted__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanMemberListElement_ClanMemberListElementArgs__get_args__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanMemberListElement_ClanMemberListElementArgs__set_args__
		              );
		    DAT_ram_00a57f72 = '\x01';
		  }
		  if ((char)param1[7] == '\0') {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (param1,param2,
		               Method_UI_Elements_GenericList_GenericListElement_ClanMemberListElement_ClanMemberListElementArgs__Init__
		              );
		    return;
		  }
		  iVar6 = param1[6];
		  if (iVar6 != 0) {
		    uVar4 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_SelectChangedEventHandler__
		               ,0);
		    if (DAT_ram_00a57f79 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		      DAT_ram_00a57f79 = '\x01';
		    }
		    iVar3 = *(int *)(iVar6 + 0x10);
		    do {
		      iVar5 = 0;
		      param1_00 = func_ii_7048(iVar3,uVar4,0);
		      uVar2 = System_Action_bool__TypeInfo;
		      if ((param1_00 != 0) &&
		         (iVar5 = func_ii_1082(param1_00,System_Action_bool__TypeInfo), iVar5 == 0)) {
		        System_Activator__CreateInstance(param1_00,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar5 = func_ii_4329(iVar6 + 0x10,iVar5,iVar3);
		      bVar1 = iVar5 != iVar3;
		      iVar3 = iVar5;
		    } while (bVar1);
		  }
		  param1[6] = param2;
		  if (param2 != 0) {
		    uVar4 = unnamed_function_1417(System_Action_bool__TypeInfo);
		    System_Action_AsyncGPUReadbackRequest___Invoke
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_SelectChangedEventHandler__
		               ,0);
		    if (DAT_ram_00a57f78 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		      DAT_ram_00a57f78 = '\x01';
		    }
		    iVar6 = *(int *)(param2 + 0x10);
		    do {
		      iVar3 = 0;
		      iVar5 = UnityEngine_UI_Image__set_sprite(iVar6,uVar4,0);
		      uVar2 = System_Action_bool__TypeInfo;
		      if ((iVar5 != 0) && (iVar3 = func_ii_1082(iVar5,System_Action_bool__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar5,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(param2 + 0x10,iVar3,iVar6);
		      bVar1 = iVar3 != iVar6;
		      iVar6 = iVar3;
		    } while (bVar1);
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,*(undefined4 *)(*param1 + 0x104));
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement__set_Data
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57f73 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_CallElementClickedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UnityEngine_Events_UnityAction_ClanMemberListElement_ClanMemberListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UnityEngine_Events_UnityEvent_ClanMemberListElement_ClanMemberListElementArgs__AddListener__
		              );
		    DAT_ram_00a57f73 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417
		                        (
		                        UnityEngine_Events_UnityAction_ClanMemberListElement_ClanMemberListElementArgs__TypeInfo
		                        );
		  func_ii_7054(param1_00,param1,
		               Method_Gameplay_Clans_Office_View_ClanMembersTab_ClanMemberListElement_CallElementClickedEvent__
		               ,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,
		             Method_UnityEngine_Events_UnityEvent_ClanMemberListElement_ClanMemberListElementArgs__AddListener__
		            );
		  return;
		}
		*/

}
