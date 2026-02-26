using System;
using System.Runtime.CompilerServices;
using Animations;
using Core.Data;
using Gameplay.Ad.BattleFinishAd.View;
using Gameplay.Combat.Model;
using Gameplay.Combat.View.Animations;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Common;
using UI;
using UI.Elements.Buttons;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Combat.View
{
	// Token: 0x02000916 RID: 2326
	[Token(Token = "0x2000916")]
	public class CombatGameOverView : MonoBehaviourWithStates<CombatGameOverView.CombatGameOverViewStates>
	{
		// Token: 0x14000175 RID: 373
		// (add) Token: 0x060036CE RID: 14030 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060036CF RID: 14031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000175")]
		public event Func<CombatGameOverView, bool> CloseRequestEvent
		{
			[Token(Token = "0x60036CE")]
			[Address(RVA = "0x86BD", Offset = "0x86BD", VA = "0x86BD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60036CF")]
			[Address(RVA = "0x86BE", Offset = "0x86BE", VA = "0x86BE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000176 RID: 374
		// (add) Token: 0x060036D0 RID: 14032 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060036D1 RID: 14033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000176")]
		public event Func<CombatGameOverView, bool> NextCombatRequestEvent
		{
			[Token(Token = "0x60036D0")]
			[Address(RVA = "0x86BF", Offset = "0x86BF", VA = "0x86BF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60036D1")]
			[Address(RVA = "0x86C0", Offset = "0x86C0", VA = "0x86C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x060036D2 RID: 14034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AD0")]
		public IndexButtonBasic ChestButton
		{
			[Token(Token = "0x60036D2")]
			[Address(RVA = "0x86C1", Offset = "0x86C1", VA = "0x86C1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x060036D3 RID: 14035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AD1")]
		public ButtonWithCost RunCombatButton
		{
			[Token(Token = "0x60036D3")]
			[Address(RVA = "0x86C2", Offset = "0x86C2", VA = "0x86C2")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x060036D4 RID: 14036 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AD2")]
		public RewardsRender RewardsRender
		{
			[Token(Token = "0x60036D4")]
			[Address(RVA = "0x86C3", Offset = "0x86C3", VA = "0x86C3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x060036D5 RID: 14037 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060036D6 RID: 14038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD3")]
		public CombatGameOverView.CombatGameOverViewArgs Args
		{
			[Token(Token = "0x60036D5")]
			[Address(RVA = "0x86C4", Offset = "0x86C4", VA = "0x86C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036D6")]
			[Address(RVA = "0x86C5", Offset = "0x86C5", VA = "0x86C5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036D7")]
		[Address(RVA = "0x86C6", Offset = "0x86C6", VA = "0x86C6")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		int * Gameplay_Combat_View_CombatGameOverView__OnDestroy(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int param1_00;
		  
		  if (DAT_ram_00a63b24 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_CombatGameOverView_HandleCloseButtonClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_CombatGameOverView_HandleRunCombatButtonOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardData__ToArray__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_CombatGameOverView_CombatGameOverViewStates__set_CurrentState__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a63b24 = '\x01';
		  }
		  param1[0x12] = param2;
		  uVar1 = 1;
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,1,0);
		  uVar5 = *(undefined4 *)(param1[9] + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Combat_View_CombatGameOverView_HandleCloseButtonClickEvent__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar2,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(param1[0x12] + 8),param1[10],
		                     *(undefined4 *)(*param1 + 0xf4));
		  param1[0xf] = iVar3;
		  iVar6 = *(int *)(param1[0x12] + 0x10);
		  uVar2 = Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_object__object__object__object___HandleGameOver
		                    (*(undefined4 *)(*(int *)(param1[0x12] + 8) + 0x20),0);
		  iVar3 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (uVar2,Method_System_Collections_Generic_List_RewardData__ToArray__);
		  param1_00 = param1[7];
		  if (*(int *)(iVar3 + 0xc) == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1_00,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = 1;
		    if (iVar6 == 0) {
		      uVar1 = 2;
		    }
		  }
		  else {
		    uVar2 = Gameplay_Combat_Control_AbstractOneOnOneCombatViewMediator_object__object__object__object___HandleGameOver
		                      (*(undefined4 *)(*(int *)(param1[0x12] + 8) + 0x20),0);
		    uVar2 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                      (uVar2,Method_System_Collections_Generic_List_RewardData__ToArray__);
		    piVar4 = (int *)func_ii_7307(param1_00,uVar2,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xf0) * 4))(piVar4,*(undefined4 *)(*piVar4 + 0xf4));
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,uVar1,
		             Method_UI_MonoBehaviourWithStates_CombatGameOverView_CombatGameOverViewStates__set_CurrentState__
		            );
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[8],0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(iVar6 != 0),0);
		  if (iVar6 != 0) {
		    uVar1 = *(undefined4 *)(param1[0x12] + 0x10);
		    uVar2 = *(undefined4 *)(param1[0x12] + 0xc);
		    uVar5 = *(undefined4 *)(param1[8] + 0xb8);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		    UI_Price_Price__SetColor(uVar5,uVar2,uVar1,0);
		    uVar2 = *(undefined4 *)(param1[8] + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Combat_View_CombatGameOverView_HandleRunCombatButtonOnClickEvent__,0)
		    ;
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  }
		  iVar3 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[0xd],0);
		  if (iVar3 != 0) {
		    Gameplay_Ad_DailyQuestsAd_Controller_DailyQuestsAdViewMediator__ValidateRoutine_d__11__System_Collections_IEnumerator_get_Current
		              (param1[0xd],*(undefined4 *)(param2 + 8),0);
		  }
		  return param1;
		}
		*/

		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036D8")]
		[Address(RVA = "0x86C7", Offset = "0x86C7", VA = "0x86C7", Slot = "5")]
		public virtual CombatGameOverView Show(CombatGameOverView.CombatGameOverViewArgs args)
		{
			return null;
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036D9")]
		[Address(RVA = "0x86C8", Offset = "0x86C8", VA = "0x86C8")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		int Gameplay_Combat_View_CombatGameOverView__Hide
		              (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  char cVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a63b25 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_InIdleOutSpineAnimation___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17762);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10333);
		    DAT_ram_00a63b25 = '\x01';
		  }
		  iVar4 = 0x2c;
		  if (*(char *)(param2 + 8) == '\0') {
		    iVar4 = 0x30;
		  }
		  uVar2 = *(undefined4 *)(param1 + iVar4);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar4 = func_ii_6805(uVar2,param3,Method_UnityEngine_Object_Instantiate_InIdleOutSpineAnimation___
		                      );
		  param1_00 = StringLiteral_17762;
		  uVar2 = StringLiteral_10333;
		  piVar3 = *(int **)(iVar4 + 0x1c);
		  cVar1 = *(char *)(param2 + 8);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  if (cVar1 == '\0') {
		    param1_00 = uVar2;
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(param1_00,1,0,1,0,0,0,0);
		  iVar5 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar5 + 0x2d4));
		  Animations_InIdleOutSpineAnimation__get_Particles(iVar4,0);
		  return iVar4;
		}
		*/

		}

		// Token: 0x060036DA RID: 14042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036DA")]
		[Address(RVA = "0x86C9", Offset = "0x86C9", VA = "0x86C9", Slot = "6")]
		protected virtual InIdleOutSpineAnimation CreateResultAnimation(GameOverData gameOverData, Transform parent)
		{
		/* --- GHIDRA: CreateResultAnimation ---
		void Gameplay_Combat_View_CombatGameOverView__CreateResultAnimation(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  ushort local_4;
		  ushort local_2;
		  
		  if (DAT_ram_00a63b26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_CombatGameOverView_HandleRunCombatButtonOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_bool__get_Value__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a63b26 = '\x01';
		  }
		  iVar1 = Core_Errors_Expected_ExpectedBillingErrors__GetErrorCode
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x48) + 0xc) + 0x78),
		                     *(undefined4 *)(*(int *)(param1 + 0x48) + 0x10),0);
		  if ((iVar1 != 0) && (iVar1 = *(int *)(param1 + 0x44), iVar1 != 0)) {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                      (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		    local_4 = 0;
		    System_Data_SqlTypes_SqlByte__ToSqlInt64(&local_4,uVar2,Method_System_Nullable_bool___ctor__);
		    local_2 = local_4;
		    if (((local_4 & 0xff) != 0) &&
		       (iVar1 = UnityEngine_UI_RawImage__set_texture
		                          (&local_2,Method_System_Nullable_bool__get_Value__), iVar1 == 0)) {
		      param1_00 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		      uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar2,param1,
		                 Method_Gameplay_Combat_View_CombatGameOverView_HandleRunCombatButtonOnClickEvent__,
		                 0);
		      UnityEngine_Events_UnityAction___ctor(param1_00,uVar2,0);
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DB")]
		[Address(RVA = "0x86CA", Offset = "0x86CA", VA = "0x86CA")]
		public void HandleRunCombatButtonOnClickEvent()
		{
		/* --- GHIDRA: HandleRunCombatButtonOnClickEvent ---
		void Gameplay_Combat_View_CombatGameOverView__HandleRunCombatButtonOnClickEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x40);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060036DC RID: 14044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DC")]
		[Address(RVA = "0x86CB", Offset = "0x86CB", VA = "0x86CB")]
		private void HandleCloseButtonClickEvent()
		{
		/* --- GHIDRA: HandleCloseButtonClickEvent ---
		void Gameplay_Combat_View_CombatGameOverView__HandleCloseButtonClickEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63b27 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_CombatGameOverView_CombatGameOverViewStates___ctor__
		              );
		    DAT_ram_00a63b27 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_UI_MonoBehaviourWithStates_CombatGameOverView_CombatGameOverViewStates___ctor__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x060036DD RID: 14045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036DD")]
		[Address(RVA = "0x86CC", Offset = "0x86CC", VA = "0x86CC")]
		public CombatGameOverView()
		{
		}

		// Token: 0x04001DFC RID: 7676
		[Token(Token = "0x4001DFC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RewardsRender _rewardsBox;

		// Token: 0x04001DFD RID: 7677
		[Token(Token = "0x4001DFD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ButtonWithCost _runCombatButton;

		// Token: 0x04001DFE RID: 7678
		[Token(Token = "0x4001DFE")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _closeButton;

		// Token: 0x04001DFF RID: 7679
		[Token(Token = "0x4001DFF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _animationContainer;

		// Token: 0x04001E00 RID: 7680
		[Token(Token = "0x4001E00")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected WinCombatGameOverAnimation _winAnimation;

		// Token: 0x04001E01 RID: 7681
		[Token(Token = "0x4001E01")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected InIdleOutSpineAnimation _loseAnimation;

		// Token: 0x04001E02 RID: 7682
		[Token(Token = "0x4001E02")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BattleFinishAdEntryView _battleFinishAdEntryView;

		// Token: 0x04001E03 RID: 7683
		[Token(Token = "0x4001E03")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private IndexButtonBasic _chestButton;

		// Token: 0x04001E04 RID: 7684
		[Token(Token = "0x4001E04")]
		[FieldOffset(Offset = "0x3C")]
		private InIdleOutSpineAnimation _resultAnimation;

		// Token: 0x02000917 RID: 2327
		[Token(Token = "0x2000917")]
		public enum CombatGameOverViewStates
		{
			// Token: 0x04001E09 RID: 7689
			[Token(Token = "0x4001E09")]
			UNKNOWN,
			// Token: 0x04001E0A RID: 7690
			[Token(Token = "0x4001E0A")]
			DEFAULT,
			// Token: 0x04001E0B RID: 7691
			[Token(Token = "0x4001E0B")]
			EMPTY
		}

		// Token: 0x02000918 RID: 2328
		[Token(Token = "0x2000918")]
		public class CombatGameOverViewArgs
		{
			// Token: 0x060036DE RID: 14046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036DE")]
			[Address(RVA = "0x86CD", Offset = "0x86CD", VA = "0x86CD")]
			public CombatGameOverViewArgs(UserData user, GameOverData gameOverData, ResourceSet nextCombatCost)
			{
			}

			// Token: 0x060036DF RID: 14047 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036DF")]
			[Address(RVA = "0x86CE", Offset = "0x86CE", VA = "0x86CE")]
			public CombatGameOverViewArgs(UserData user, GameOverData gameOverData)
			{
			}

			// Token: 0x04001E0C RID: 7692
			[Token(Token = "0x4001E0C")]
			[FieldOffset(Offset = "0x8")]
			public readonly GameOverData GameOverData;

			// Token: 0x04001E0D RID: 7693
			[Token(Token = "0x4001E0D")]
			[FieldOffset(Offset = "0xC")]
			public readonly UserData User;

			// Token: 0x04001E0E RID: 7694
			[Token(Token = "0x4001E0E")]
			[FieldOffset(Offset = "0x10")]
			[CanBeNull]
			public readonly ResourceSet NextCombatCost;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_CloseRequestEvent ---
		void Gameplay_Combat_View_CombatGameOverView__add_CloseRequestEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63b20 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_CombatGameOverView__bool__TypeInfo);
		    DAT_ram_00a63b20 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Func_CombatGameOverView__bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Func_CombatGameOverView__bool__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
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


		/* --- GHIDRA: remove_CloseRequestEvent ---
		void Gameplay_Combat_View_CombatGameOverView__remove_CloseRequestEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63b21 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_CombatGameOverView__bool__TypeInfo);
		    DAT_ram_00a63b21 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Func_CombatGameOverView__bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Func_CombatGameOverView__bool__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
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


		/* --- GHIDRA: add_NextCombatRequestEvent ---
		void Gameplay_Combat_View_CombatGameOverView__add_NextCombatRequestEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63b22 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_CombatGameOverView__bool__TypeInfo);
		    DAT_ram_00a63b22 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Func_CombatGameOverView__bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Func_CombatGameOverView__bool__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
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


		/* --- GHIDRA: set_Args ---
		void Gameplay_Combat_View_CombatGameOverView__set_Args(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63b23 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_CombatGameOverView_HandleCloseButtonClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_CombatGameOverView_HandleRunCombatButtonOnClickEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a63b23 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Combat_View_CombatGameOverView_HandleCloseButtonClickEvent__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Combat_View_CombatGameOverView_HandleRunCombatButtonOnClickEvent__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  *(undefined8 *)(param1 + 0x40) = 0;
		  *(undefined4 *)(param1 + 0x48) = 0;
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor
		                    (*(undefined4 *)(param1 + 0x3c),0);
		  if (iVar2 != 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x3c),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar1,0);
		  }
		  return;
		}
		*/

}
