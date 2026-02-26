using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.CaptainTab;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Boss.View.InvitesTab
{
	// Token: 0x02000B6D RID: 2925
	[Token(Token = "0x2000B6D")]
	public class BossInviteItemView : MonoBehaviour
	{
		// Token: 0x140001BE RID: 446
		// (add) Token: 0x06004706 RID: 18182 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004707 RID: 18183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001BE")]
		public event Action<BossInviteData> ClickEvent
		{
			[Token(Token = "0x6004706")]
			[Address(RVA = "0x959C", Offset = "0x959C", VA = "0x959C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004707")]
			[Address(RVA = "0x959D", Offset = "0x959D", VA = "0x959D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004709 RID: 18185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E23")]
		public BossInviteData Data
		{
			[Token(Token = "0x6004708")]
			[Address(RVA = "0x959E", Offset = "0x959E", VA = "0x959E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004709")]
			[Address(RVA = "0x959F", Offset = "0x959F", VA = "0x959F")]
			set
			{
			}
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470A")]
		[Address(RVA = "0x95A0", Offset = "0x95A0", VA = "0x95A0")]
		private void DataOnCaptainUserDataChangedEvent()
		{
		/* --- GHIDRA: DataOnCaptainUserDataChangedEvent ---
		void Gameplay_Boss_View_InvitesTab_BossInviteItemView__DataOnCaptainUserDataChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x17000E24 RID: 3620
		// (set) Token: 0x0600470B RID: 18187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E24")]
		public bool Selected
		{
			[Token(Token = "0x600470B")]
			[Address(RVA = "0x95A1", Offset = "0x95A1", VA = "0x95A1")]
			set
			{
			}
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470C")]
		[Address(RVA = "0x95A2", Offset = "0x95A2", VA = "0x95A2")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Boss_View_InvitesTab_BossInviteItemView__Awake
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x20);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x24),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600470D RID: 18189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470D")]
		[Address(RVA = "0x95A3", Offset = "0x95A3", VA = "0x95A3")]
		private void ClickHandlerOnOnClickEvent(PointerEventData data)
		{
		/* --- GHIDRA: ClickHandlerOnOnClickEvent ---
		void Gameplay_Boss_View_InvitesTab_BossInviteItemView__ClickHandlerOnOnClickEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57a16 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_InvitesTab_BossInviteItemView_ClickHandlerOnOnClickEvent__
		              );
		    DAT_ram_00a57a16 = '\x01';
		  }
		  if (DAT_ram_00a57a14 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_InvitesTab_BossInviteItemView_DataOnCaptainUserDataChangedEvent__
		              );
		    DAT_ram_00a57a14 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  if (param1_00 != 0) {
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Boss_View_InvitesTab_BossInviteItemView_DataOnCaptainUserDataChangedEvent__
		               ,0);
		    Gameplay_Boss_Model_BossInviteData__add_CaptainUserDataChangedEvent(param1_00,uVar1,0);
		  }
		  *(undefined4 *)(param1 + 0x24) = 0;
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Boss_View_InvitesTab_BossInviteItemView_ClickHandlerOnOnClickEvent__,0)
		  ;
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___get_Count(param1_01,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600470E RID: 18190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470E")]
		[Address(RVA = "0x95A4", Offset = "0x95A4", VA = "0x95A4")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470F")]
		[Address(RVA = "0x95A5", Offset = "0x95A5", VA = "0x95A5")]
		public BossInviteItemView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_InvitesTab_BossInviteItemView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a17 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInviteData__TypeInfo);
		    DAT_ram_00a57a17 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa0);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossInviteData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInviteData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa0,iVar2,param1_00);
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

		// Token: 0x040026F6 RID: 9974
		[Token(Token = "0x40026F6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x040026F7 RID: 9975
		[Token(Token = "0x40026F7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BossUserListItemView _userListView;

		// Token: 0x040026F8 RID: 9976
		[Token(Token = "0x40026F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeViewUGUI;

		// Token: 0x040026F9 RID: 9977
		[Token(Token = "0x40026F9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x040026FB RID: 9979
		[Token(Token = "0x40026FB")]
		[FieldOffset(Offset = "0x24")]
		private BossInviteData _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Boss_View_InvitesTab_BossInviteItemView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a13 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInviteData__TypeInfo);
		    DAT_ram_00a57a13 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossInviteData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInviteData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: get_Data ---
		void Gameplay_Boss_View_InvitesTab_BossInviteItemView__get_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a57a14 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_InvitesTab_BossInviteItemView_DataOnCaptainUserDataChangedEvent__
		              );
		    DAT_ram_00a57a14 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  if (param1_00 != 0) {
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Boss_View_InvitesTab_BossInviteItemView_DataOnCaptainUserDataChangedEvent__
		               ,0);
		    Gameplay_Boss_Model_BossInviteData__add_CaptainUserDataChangedEvent(param1_00,uVar1,0);
		  }
		  *(int *)(param1 + 0x24) = param2;
		  if (param2 != 0) {
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param1,
		               Method_Gameplay_Boss_View_InvitesTab_BossInviteItemView_DataOnCaptainUserDataChangedEvent__
		               ,0);
		    Gameplay_Boss_Model_BossInviteData__set_CaptainUserData(param2,uVar1,0);
		    Gameplay_Boss_View_CaptainTab_BossUserListItemView__get_UserData
		              (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(*(int *)(param1 + 0x24) + 0x18),param1
		              );
		    UI_Elements_RightPanel_TitleWithLevel__set_Level
		              (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*(int *)(param1 + 0x24) + 8),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_Boss_View_InvitesTab_BossInviteItemView__set_Data(int param1,undefined4 param2)
		
		{
		  Gameplay_Boss_View_CaptainTab_BossUserListItemView__get_UserData
		            (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(*(int *)(param1 + 0x24) + 0x18),param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void Gameplay_Boss_View_InvitesTab_BossInviteItemView__set_Selected(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57a15 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PointerEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Boss_View_InvitesTab_BossInviteItemView_ClickHandlerOnOnClickEvent__
		              );
		    DAT_ram_00a57a15 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_PointerEventData__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Boss_View_InvitesTab_BossInviteItemView_ClickHandlerOnOnClickEvent__,0)
		  ;
		  Gameplay_Chat_View_Smiles_SmileItemView__HandleSmileDicChanged(param1_01,param1_00,0);
		  return;
		}
		*/

}
