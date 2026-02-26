using System;
using System.Runtime.CompilerServices;
using Gameplay.SmallGames.Controller;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View.DailyRewards
{
	// Token: 0x0200052D RID: 1325
	[Token(Token = "0x200052D")]
	public class DailyRewardsWindow : ClosableBaseWindow<DailyRewardsWindow.DailyRewardsWindowArgs>
	{
		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C1")]
		public override string WindowId
		{
			[Token(Token = "0x6001F81")]
			[Address(RVA = "0x70E6", Offset = "0x70E6", VA = "0x70E6", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400013B RID: 315
		// (add) Token: 0x06001F82 RID: 8066 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001F83 RID: 8067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400013B")]
		public event Action<RewardsTab> TabSelectedEvent
		{
			[Token(Token = "0x6001F82")]
			[Address(RVA = "0x70E7", Offset = "0x70E7", VA = "0x70E7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001F83")]
			[Address(RVA = "0x70E8", Offset = "0x70E8", VA = "0x70E8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C2")]
		public TextMeshProUGUI AdditionalBonusAnnotation
		{
			[Token(Token = "0x6001F84")]
			[Address(RVA = "0x70E9", Offset = "0x70E9", VA = "0x70E9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001F85 RID: 8069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C3")]
		public Button TakeButton
		{
			[Token(Token = "0x6001F85")]
			[Address(RVA = "0x70EA", Offset = "0x70EA", VA = "0x70EA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005C4")]
		public Button AccountsButton
		{
			[Token(Token = "0x6001F86")]
			[Address(RVA = "0x70EB", Offset = "0x70EB", VA = "0x70EB")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001F87")]
		[Address(RVA = "0x70EC", Offset = "0x70EC", VA = "0x70EC")]
		public SingleRewardView[] Init(int rewardsCount)
		{
		/* --- GHIDRA: <OnShow>b__31_1 ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow___OnShow_b__31_1
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x74);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x54),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: <OnShow>b__31_0 ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow___OnShow_b__31_0
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x74);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x50),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58298 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6096);
		    DAT_ram_00a58298 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0x4c) + 0x30);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6096,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,param2_00,0);
		  System_Collections_Generic_Dictionary_int__object___get_Count
		            (*(undefined4 *)(*(int *)(param1 + 0x4c) + 0x2c),1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x58),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x60),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F88")]
		[Address(RVA = "0x70ED", Offset = "0x70ED", VA = "0x70ED")]
		public void DrawPending()
		{
		/* --- GHIDRA: DrawPending ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__DrawPending
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58299 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6095);
		    DAT_ram_00a58299 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(*(int *)(param1 + 0x4c) + 0x30);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_6095,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,param2_00,0);
		  System_Collections_Generic_Dictionary_int__object___get_Count
		            (*(undefined4 *)(*(int *)(param1 + 0x4c) + 0x2c),0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x58),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x60),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F89")]
		[Address(RVA = "0x70EE", Offset = "0x70EE", VA = "0x70EE")]
		public void DrawReceived()
		{
		/* --- GHIDRA: DrawReceived ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__DrawReceived
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 uVar3;
		  int iVar4;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5829a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_DailyRewardsWindow_DailyRewardsWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__OnShow_b__31_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__OnShow_b__31_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__OnShow_b__31_2__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5829a = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_DailyRewardsWindow_DailyRewardsWindowArgs__OnShow__
		              );
		  Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__InvokeSelectedEvent(param1,param1);
		  uVar3 = *(undefined8 *)(param1 + 0x44);
		  iVar4 = *(int *)(param1 + 0x4c);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (iVar4,0);
		  UnityEngine_Transform___ctor(&local_c,uVar1,0);
		  *(undefined4 *)(iVar4 + 0x44) = local_4;
		  *(undefined8 *)(iVar4 + 0x3c) = local_c;
		  *(undefined8 *)(iVar4 + 0x34) = uVar3;
		  uVar3 = *(undefined8 *)(param1 + 0x44);
		  iVar4 = *(int *)(param1 + 0x50);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (iVar4,0);
		  UnityEngine_Transform___ctor(&local_c,uVar1,0);
		  *(undefined4 *)(iVar4 + 0x44) = local_4;
		  *(undefined8 *)(iVar4 + 0x3c) = local_c;
		  *(undefined8 *)(iVar4 + 0x34) = uVar3;
		  uVar3 = *(undefined8 *)(param1 + 0x44);
		  iVar4 = *(int *)(param1 + 0x54);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (iVar4,0);
		  UnityEngine_Transform___ctor(&local_c,uVar1,0);
		  *(undefined4 *)(iVar4 + 0x44) = local_4;
		  *(undefined8 *)(iVar4 + 0x3c) = local_c;
		  *(undefined8 *)(iVar4 + 0x34) = uVar3;
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x4c) + 0x24) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__OnShow_b__31_0__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x50) + 0x24) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__OnShow_b__31_1__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x54) + 0x24) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__OnShow_b__31_2__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  iVar4 = *(int *)(param1 + 0x74);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(param1 + 0x4c),
		               *(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8A")]
		[Address(RVA = "0x70EF", Offset = "0x70EF", VA = "0x70EF", Slot = "22")]
		protected override void OnShow(DailyRewardsWindow.DailyRewardsWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5829b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_DailyRewardsWindow_DailyRewardsWindowArgs__OnClose__
		              );
		    DAT_ram_00a5829b = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_DailyRewardsWindow_DailyRewardsWindowArgs__OnClose__
		            );
		  if (*(char *)(param1 + 0x70) != '\0') {
		    iVar1 = **(int **)(param1 + 0x6c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x6c),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x6c) = 0;
		  }
		  func_ii_14558(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x4c) + 0x24) + 0xb4),0);
		  func_ii_14558(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x50) + 0x24) + 0xb4),0);
		  func_ii_14558(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x54) + 0x24) + 0xb4),0);
		  return;
		}
		*/

		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0x70F0", Offset = "0x70F0", VA = "0x70F0", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__OnClose
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x74);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0x70F1", Offset = "0x70F1", VA = "0x70F1")]
		private void InvokeSelectedEvent(RewardsTab tab)
		{
		/* --- GHIDRA: InvokeSelectedEvent ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__InvokeSelectedEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *param1_00;
		  int *param4;
		  
		  if (DAT_ram_00a5829c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_DailyRewardsWindow_DailyRewardsWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_SmallGames_Controller_DailyRewardsViewMediator_TypeInfo);
		    DAT_ram_00a5829c = '\x01';
		  }
		  if (*(char *)(param1 + 0x70) == '\0') {
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_DailyRewardsWindow_DailyRewardsWindowArgs__get_WindowArgs__
		                        );
		    param4 = *(int **)(iVar1 + 0x18);
		    param2_00 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))
		                          (param4,*(undefined4 *)(*param4 + 0x104));
		    param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))
		                       (param4,*(undefined4 *)(*param4 + 0x114));
		    param1_00 = (int *)unnamed_function_1417
		                                 (Gameplay_SmallGames_Controller_DailyRewardsViewMediator_TypeInfo);
		    if (DAT_ram_00a582b7 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__DailyRewardsWindow___ctor__
		                );
		      DAT_ram_00a582b7 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (param1_00,param2_00,param3,param4,
		               Method_MVC_AbstractViewMediator_SmallGamesModel__SmallGamesEvents__SmallGamesController__DailyRewardsWindow___ctor__
		              );
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		              (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		    *(undefined1 *)(param1 + 0x70) = 1;
		    *(int **)(param1 + 0x6c) = param1_00;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0x70F2", Offset = "0x70F2", VA = "0x70F2")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0x70F3", Offset = "0x70F3", VA = "0x70F3")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__DestroyMVC
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5829d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_DailyRewardsWindow_DailyRewardsWindowArgs___ctor__
		              );
		    DAT_ram_00a5829d = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_DailyRewardsWindow_DailyRewardsWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0x70F4", Offset = "0x70F4", VA = "0x70F4")]
		public DailyRewardsWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x74);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x4c),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04001136 RID: 4406
		[Token(Token = "0x4001136")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SmallGames/DailyRewardsWindow";

		// Token: 0x04001137 RID: 4407
		[Token(Token = "0x4001137")]
		private const string LOCALIZATION_TAKE_BONUS = "DAILY_REWARDS/TAKE_BONUS";

		// Token: 0x04001138 RID: 4408
		[Token(Token = "0x4001138")]
		private const string LOCALIZATION_REWARD_RECEIVED_ANNOTATION = "DAILY_REWARDS/REWARD_RECEIVED_ANNOTATION";

		// Token: 0x04001139 RID: 4409
		[Token(Token = "0x4001139")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private SingleRewardView _rewardPanelPrefab;

		// Token: 0x0400113A RID: 4410
		[Token(Token = "0x400113A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rewardsParent;

		// Token: 0x0400113B RID: 4411
		[Token(Token = "0x400113B")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private RectTransform _activeTabsParent;

		// Token: 0x0400113C RID: 4412
		[Token(Token = "0x400113C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _inactiveTabsParent;

		// Token: 0x0400113D RID: 4413
		[Token(Token = "0x400113D")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private RewardsTab _dailyTab;

		// Token: 0x0400113E RID: 4414
		[Token(Token = "0x400113E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RewardsTab _hourlyTab;

		// Token: 0x0400113F RID: 4415
		[Token(Token = "0x400113F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private RewardsTab _subscriptionTab;

		// Token: 0x04001140 RID: 4416
		[Token(Token = "0x4001140")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI _annotation;

		// Token: 0x04001141 RID: 4417
		[Token(Token = "0x4001141")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _additionalBonusAnnotation;

		// Token: 0x04001142 RID: 4418
		[Token(Token = "0x4001142")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _takeButton;

		// Token: 0x04001143 RID: 4419
		[Token(Token = "0x4001143")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private DoubleRewardView _doublePanel;

		// Token: 0x04001144 RID: 4420
		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _accountsButton;

		// Token: 0x04001145 RID: 4421
		[Token(Token = "0x4001145")]
		[FieldOffset(Offset = "0x6C")]
		private DailyRewardsViewMediator _mediator;

		// Token: 0x04001146 RID: 4422
		[Token(Token = "0x4001146")]
		[FieldOffset(Offset = "0x70")]
		private bool _mvcSetUp;

		// Token: 0x0200052E RID: 1326
		[Token(Token = "0x200052E")]
		public class DailyRewardsWindowArgs : BaseWindowArgs
		{
			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x06001F93 RID: 8083 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170005C5")]
			public SmallGamesController Controller
			{
				[Token(Token = "0x6001F93")]
				[Address(RVA = "0x70F8", Offset = "0x70F8", VA = "0x70F8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06001F94 RID: 8084 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F94")]
			[Address(RVA = "0x70F9", Offset = "0x70F9", VA = "0x70F9")]
			public DailyRewardsWindowArgs(SmallGamesController controller)
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__get_WindowId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58295 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_RewardsTab__TypeInfo);
		    DAT_ram_00a58295 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x74);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_RewardsTab__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_RewardsTab__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x74,iVar2,param1_00);
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


		/* --- GHIDRA: add_TabSelectedEvent ---
		void Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__add_TabSelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58296 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_RewardsTab__TypeInfo);
		    DAT_ram_00a58296 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x74);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_RewardsTab__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_RewardsTab__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x74,iVar2,param1_00);
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


		/* --- GHIDRA: get_AccountsButton ---
		int * Gameplay_SmallGames_View_DailyRewards_DailyRewardsWindow__get_AccountsButton
		                (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int iVar8;
		  undefined4 param1_00;
		  int *piVar9;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58297 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_SingleRewardView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_SmallGames_View_DailyRewards_SingleRewardView___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a58297 = '\x01';
		  }
		  local_8 = 0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x40),0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar8 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80ec545d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ec56a0:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ec56a8;
		    }
		code_r0x80ec545d:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ec56a0;
		    if (iVar8 == 0) goto code_r0x80ec56f1;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(piVar9[1] * 8 + iVar8 + 200);
		          goto code_r0x80ec553a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80ec5682:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ec56a8;
		    }
		code_r0x80ec553a:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80ec5682;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ec56a8;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ec56a8:
		  iVar8 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x80ec56f1:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_c;
		      if (piVar5 != (int *)0x0) {
		        iVar8 = *piVar5;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80ec5781;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80ec5781:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar5 = (int *)Mono_Security_ASN1Convert__ToOid
		                                (Gameplay_SmallGames_View_DailyRewards_SingleRewardView___TypeInfo,
		                                 param2);
		      if (0 < param2 + -1) {
		        iVar8 = 0;
		        do {
		          uVar3 = *(undefined4 *)(param1 + 0x40);
		          param1_00 = *(undefined4 *)(param1 + 0x3c);
		          if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		            func_ii_306000(UnityEngine_Object_TypeInfo);
		          }
		          iVar4 = func_ii_6805(param1_00,uVar3,
		                               Method_UnityEngine_Object_Instantiate_SingleRewardView___);
		          if ((iVar4 != 0) &&
		             (iVar7 = func_ii_1082(iVar4,*(undefined4 *)(*piVar5 + 0x20)), iVar7 == 0)) {
		            uVar3 = func_ii_1083();
		            func_ii_1050(uVar3,0);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          piVar5[iVar8 + 4] = iVar4;
		          iVar8 = iVar8 + 1;
		        } while (iVar8 != param2 + -1);
		      }
		      iVar8 = *(int *)(param1 + 100);
		      if ((iVar8 != 0) && (iVar4 = func_ii_1082(iVar8,*(undefined4 *)(*piVar5 + 0x20)), iVar4 == 0))
		      {
		        uVar3 = func_ii_1083();
		        func_ii_1050(uVar3,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar5[param2 + 3] = iVar8;
		      return piVar5;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x13c,&local_14);
		  iVar8 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar8 != 1) {
		    import::env::__resumeException(uVar3);
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
		*/

}
