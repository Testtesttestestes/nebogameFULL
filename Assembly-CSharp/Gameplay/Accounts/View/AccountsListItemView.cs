using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DC8 RID: 3528
	[Token(Token = "0x2000DC8")]
	public class AccountsListItemView : MonoBehaviourWithStates<AccountsListItemView.States>, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000203 RID: 515
		// (add) Token: 0x0600560B RID: 22027 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600560C RID: 22028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000203")]
		public event Action<IAccountDataDecorator> SelectEvent
		{
			[Token(Token = "0x600560B")]
			[Address(RVA = "0xA3AB", Offset = "0xA3AB", VA = "0xA3AB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600560C")]
			[Address(RVA = "0xA3AC", Offset = "0xA3AC", VA = "0xA3AC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600560D")]
		[Address(RVA = "0xA3AD", Offset = "0xA3AD", VA = "0xA3AD")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Accounts_View_AccountsListItemView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int iVar3;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a58889 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_View_AccountsListItemView_BacktimeformatCallback__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_View_AccountsListItemView_HandleButtonClick__);
		    Mono_Security_ASN1__get_Item(&UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58889 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x24);
		  uVar1 = unnamed_function_1417(UI_AbstractBacktimeView_FormatCallback_TypeInfo);
		  UI_AbstractBacktimeView___ctor
		            (uVar1,param1,
		             Method_Gameplay_Accounts_View_AccountsListItemView_BacktimeformatCallback__,0);
		  *(undefined4 *)(iVar2 + 0x14) = uVar1;
		  iVar2 = *(int *)(param1 + 0x2c);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      param1_00 = *(undefined4 *)(*(int *)(iVar2 + iVar3 * 4 + 0x10) + 0xb4);
		      uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar1,param1,Method_Gameplay_Accounts_View_AccountsListItemView_HandleButtonClick__
		                 ,0);
		      Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_00,uVar1,0);
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600560E RID: 22030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600560E")]
		[Address(RVA = "0xA3AE", Offset = "0xA3AE", VA = "0xA3AE")]
		private void Awake()
		{
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x0600560F RID: 22031 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005610 RID: 22032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700117D")]
		public IAccountDataDecorator Data
		{
			[Token(Token = "0x600560F")]
			[Address(RVA = "0xA3AF", Offset = "0xA3AF", VA = "0xA3AF")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005610")]
			[Address(RVA = "0xA3B0", Offset = "0xA3B0", VA = "0xA3B0")]
			set
			{
			}
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005611")]
		[Address(RVA = "0x1D32", Offset = "0x1D32", VA = "0x1D32")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005612")]
		[Address(RVA = "0xA3B1", Offset = "0xA3B1", VA = "0xA3B1")]
		private void HandleButtonClick()
		{
		/* --- GHIDRA: HandleButtonClick ---
		undefined4
		Gameplay_Accounts_View_AccountsListItemView__HandleButtonClick
		          (undefined4 param1,float param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  undefined4 param3_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5888b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20450);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2493);
		    DAT_ram_00a5888b = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_2493,1,0,1,0,0,0,0);
		  param2_00 = Mono_Security_ASN1Convert__ToOid
		                        (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param3_00 = Utils_TimeUtils__DateFormat((double)param2,0);
		  local_8 = 0;
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_8,StringLiteral_20450,param3_00,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(param2_00 + 0x10) = local_8;
		  uVar1 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar1,param2_00,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06005613 RID: 22035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005613")]
		[Address(RVA = "0xA3B2", Offset = "0xA3B2", VA = "0xA3B2")]
		private string BacktimeformatCallback(float value)
		{
		/* --- GHIDRA: BacktimeformatCallback ---
		void Gameplay_Accounts_View_AccountsListItemView__BacktimeformatCallback
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Accounts_View_AccountsListView__get_MapOfListItemPrefabs(param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005614")]
		[Address(RVA = "0xA3B3", Offset = "0xA3B3", VA = "0xA3B3")]
		public void NotifyDataUpdated()
		{
		/* --- GHIDRA: NotifyDataUpdated ---
		void Gameplay_Accounts_View_AccountsListItemView__NotifyDataUpdated
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x34),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005615 RID: 22037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005615")]
		[Address(RVA = "0xA3B4", Offset = "0xA3B4", VA = "0xA3B4", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Accounts_View_AccountsListItemView__OnPointerClick
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5888c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_AccountsListItemView_States___ctor__);
		    DAT_ram_00a5888c = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_AccountsListItemView_States___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06005616 RID: 22038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005616")]
		[Address(RVA = "0xA3B5", Offset = "0xA3B5", VA = "0xA3B5")]
		public AccountsListItemView()
		{
		}

		// Token: 0x04002EA5 RID: 11941
		[Token(Token = "0x4002EA5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002EA6 RID: 11942
		[Token(Token = "0x4002EA6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImage _image;

		// Token: 0x04002EA7 RID: 11943
		[Token(Token = "0x4002EA7")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002EA8 RID: 11944
		[Token(Token = "0x4002EA8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameRawImage _saleRibbon;

		// Token: 0x04002EA9 RID: 11945
		[Token(Token = "0x4002EA9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button[] _buttons;

		// Token: 0x04002EAB RID: 11947
		[Token(Token = "0x4002EAB")]
		[FieldOffset(Offset = "0x34")]
		private IAccountDataDecorator _data;

		// Token: 0x02000DC9 RID: 3529
		[Token(Token = "0x2000DC9")]
		public enum States
		{
			// Token: 0x04002EAD RID: 11949
			[Token(Token = "0x4002EAD")]
			UNKNOWN,
			// Token: 0x04002EAE RID: 11950
			[Token(Token = "0x4002EAE")]
			ACTIVE,
			// Token: 0x04002EAF RID: 11951
			[Token(Token = "0x4002EAF")]
			NOT_ACTIVE
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectEvent ---
		void Gameplay_Accounts_View_AccountsListItemView__add_SelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58887 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAccountDataDecorator__TypeInfo);
		    DAT_ram_00a58887 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IAccountDataDecorator__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAccountDataDecorator__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SelectEvent ---
		void Gameplay_Accounts_View_AccountsListItemView__remove_SelectEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  int iVar2;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a58888 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_View_AccountsListItemView_HandleButtonClick__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58888 = '\x01';
		  }
		  if (*(int *)(param1 + 0x34) != 0) {
		    *(undefined4 *)(param1 + 0x34) = 0;
		    Gameplay_Accounts_View_AccountsListView__get_MapOfListItemPrefabs(param1,0);
		  }
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      param1_01 = *(undefined4 *)(*(int *)(iVar1 + iVar2 * 4 + 0x10) + 0xb4);
		      param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (param1_00,param1,
		                 Method_Gameplay_Accounts_View_AccountsListItemView_HandleButtonClick__,0);
		      UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_Accounts_View_AccountsListItemView__get_Data(int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x34)) {
		    *(int *)(param1 + 0x34) = param2;
		    Gameplay_Accounts_View_AccountsListView__get_MapOfListItemPrefabs(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_Accounts_View_AccountsListItemView__set_Data(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x34),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
