using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core.Materials;
using DG.Tweening;
using Gameplay.Isles.User.Controller;
using Gameplay.Tutorial.Guide.Model.Data;
using Gameplay.Tutorial.Guide.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.EventSystems;
using Utils;
using Utils.Trackers;

namespace Gameplay.Isles.User.View.Monster
{
	// Token: 0x02000D22 RID: 3362
	[Token(Token = "0x2000D22")]
	public class IsleMonsterView : BaseIsleMonsterView, IToolTipDataProvider, IPointerClickHandler, IEventSystemHandler, IBoundsProvider, IGuideTargetResolveEventProvider, IAlpha
	{
		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06005228 RID: 21032 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B6")]
		public MonsterOnIsleAvatarAnimation AvatarAnimation
		{
			[Token(Token = "0x6005228")]
			[Address(RVA = "0x9FFF", Offset = "0x9FFF", VA = "0x9FFF")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06005229 RID: 21033 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B7")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6005229")]
			[Address(RVA = "0xA000", Offset = "0xA000", VA = "0xA000")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x0600522A RID: 21034 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B8")]
		public AsyncLoadableContentTracker Tracker
		{
			[Token(Token = "0x600522A")]
			[Address(RVA = "0xA001", Offset = "0xA001", VA = "0xA001")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x0600522B RID: 21035 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010B9")]
		public ToolTip ToolTip
		{
			[Token(Token = "0x600522B")]
			[Address(RVA = "0xA002", Offset = "0xA002", VA = "0xA002")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x0600522C RID: 21036 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		[Token(Token = "0x170010BA")]
		public Bounds Bounds
		{
			[Token(Token = "0x600522C")]
			[Address(RVA = "0xA003", Offset = "0xA003", VA = "0xA003", Slot = "14")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x140001F5 RID: 501
		// (add) Token: 0x0600522D RID: 21037 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600522E RID: 21038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F5")]
		public new event Action ClickEvent
		{
			[Token(Token = "0x600522D")]
			[Address(RVA = "0xA004", Offset = "0xA004", VA = "0xA004")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600522E")]
			[Address(RVA = "0xA005", Offset = "0xA005", VA = "0xA005")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001F6 RID: 502
		// (add) Token: 0x0600522F RID: 21039 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005230 RID: 21040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001F6")]
		public event Action<IGuideTargetResolveEventProvider> ResolveEvent
		{
			[Token(Token = "0x600522F")]
			[Address(RVA = "0xA006", Offset = "0xA006", VA = "0xA006", Slot = "15")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005230")]
			[Address(RVA = "0xA007", Offset = "0xA007", VA = "0xA007", Slot = "16")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170010BB RID: 4283
		// (set) Token: 0x06005231 RID: 21041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010BB")]
		public BackTime Backtime
		{
			[Token(Token = "0x6005231")]
			[Address(RVA = "0xA008", Offset = "0xA008", VA = "0xA008")]
			set
			{
			}
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005232")]
		[Address(RVA = "0xA009", Offset = "0xA009", VA = "0xA009")]
		private IEnumerator TimerRoutine(float backtime)
		{
		/* --- GHIDRA: TimerRoutine ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__TimerRoutine(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int param2_00;
		  undefined8 local_30;
		  ulonglong local_28;
		  undefined8 local_20;
		  uint local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  uint local_8;
		  
		  UnityEngine_SpriteRenderer__set_size(&local_10,*(undefined4 *)(param1 + 0x2c),0);
		  local_18 = local_8;
		  local_20 = local_10;
		  local_14 = 0;
		  local_28 = (ulonglong)local_8;
		  local_30 = local_10;
		  UnityEngine_SpriteRenderer__get_color(*(undefined4 *)(param1 + 0x2c),&local_30,0);
		  param2_00 = 0;
		  iVar1 = Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__Validate
		                    (*(undefined4 *)(param1 + 0x3c),0);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      Core_Animations_GameSpineAnimation__SetGrayscale
		                (*(undefined4 *)(iVar1 + param2_00 * 4 + 0x10),0.0,0);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,1,0);
		  Gameplay_Isles_User_View_Monster_IsleMonsterView__Init(param1,param2_00);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005233")]
		[Address(RVA = "0xA00A", Offset = "0xA00A", VA = "0xA00A")]
		public void Show()
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__Show(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  Utils_Trackers_AsyncLoadableContentTracker__StartTracking(*(undefined4 *)(param1 + 0x38),0);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06005234 RID: 21044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005234")]
		[Address(RVA = "0xA00B", Offset = "0xA00B", VA = "0xA00B")]
		public void Hide()
		{
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005235")]
		[Address(RVA = "0xA00C", Offset = "0xA00C", VA = "0xA00C")]
		public void SetState(IsleMonsterView.State state)
		{
		/* --- GHIDRA: SetState ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__SetState(int param1,undefined4 param2)
		
		{
		  CloudsFly_BaseWorldObjectRenderer__get_SortingOrderWithDelta
		            (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param1 + 0x14),0);
		  AssetContent_Loaders_GameSpriteRendererLoader__get_SpriteRenderer
		            (*(undefined4 *)(param1 + 0x2c),*(int *)(param1 + 0x14) + 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005236 RID: 21046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005236")]
		[Address(RVA = "0xA00D", Offset = "0xA00D", VA = "0xA00D", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		/* --- GHIDRA: ApplySortingOrder ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__ApplySortingOrder
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  int param1_01;
		  
		  if (DAT_ram_00a58d76 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_Controller_IsleMonsterViewMediator_TypeInfo);
		    DAT_ram_00a58d76 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param2 + 0x14);
		  uVar2 = *(undefined4 *)(param2 + 0xc);
		  param2_00 = *(undefined4 *)(param2 + 0x10);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_Isles_User_Controller_IsleMonsterViewMediator_TypeInfo);
		  if (DAT_ram_00a58dcb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterView___ctor__
		              );
		    DAT_ram_00a58dcb = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,uVar2,uVar1,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterView___ctor__
		            );
		  *(int **)(param1 + 0x44) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  uVar1 = *(undefined4 *)(param1 + 0x34);
		  if (*(int *)(*(int *)(param2 + 0x10) + 0x34) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    param1_01 = *(int *)(*(int *)(param2 + 0x10) + 0x40);
		    if (param1_01 == 0) {
		      uVar2 = 0;
		    }
		    else {
		      uVar2 = Unity_Hierarchy_HierarchySearchQueryDescriptor___c____ctor_b__33_1(param1_01,0);
		    }
		  }
		  UI_ToolTip_ToolTip__get_enabled(uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06005237 RID: 21047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005237")]
		[Address(RVA = "0xA00E", Offset = "0xA00E", VA = "0xA00E")]
		public void Init(UserIsle isle)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__Init(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58d77 == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_Core_DOSetter_float__TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_DOTween_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tweener___);
		    DAT_ram_00a58d77 = '\x01';
		  }
		  if (param1[0x12] != 0) {
		    func_ii_7891(param1[0x12],0,0);
		  }
		  uVar1 = unnamed_function_1417(DG_Tweening_Core_DOSetter_float__TypeInfo);
		  DG_Tweening_Core_DOSetter_Rect___Invoke(uVar1,param1,*(undefined4 *)(*param1 + 0x154),0);
		  if (*(int *)(DG_Tweening_DOTween_TypeInfo + 0x74) == 0) {
		    func_ii_306000(DG_Tweening_DOTween_TypeInfo);
		  }
		  uVar1 = DG_Tweening_DOTween__ToAlpha(uVar1,0.0,1.0,0.5,0);
		  param2_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1,0);
		  iVar2 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar1,param2_00,Method_DG_Tweening_TweenSettingsExtensions_SetLink_Tweener___);
		  param1[0x12] = iVar2;
		  return;
		}
		*/

		}

		// Token: 0x06005238 RID: 21048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005238")]
		[Address(RVA = "0xA00F", Offset = "0xA00F", VA = "0xA00F")]
		private void FadeIn()
		{
		/* --- GHIDRA: FadeIn ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__FadeIn(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (*(int *)(param1 + 0x4c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x4c),0);
		    *(undefined4 *)(param1 + 0x4c) = 0;
		  }
		  piVar1 = *(int **)(param1 + 0x44);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  if (*(int *)(param1 + 0x48) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x48),0,0);
		  }
		  Utils_Trackers_AsyncLoadableContentTracker__NotifyIfReady(*(undefined4 *)(param1 + 0x38),0);
		  *(undefined4 *)(param1 + 0x44) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06005239 RID: 21049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005239")]
		[Address(RVA = "0xA010", Offset = "0xA010", VA = "0xA010")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4 Gameplay_Isles_User_View_Monster_IsleMonsterView__Deinit(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58d78 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleMonsterView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&UI_ToolTip_Implementations_VO_Monster_IslandMonsterToolTipVO_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_AbstractMonsterToolTipVO___ctor__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_AbstractMonsterToolTipVO__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12535);
		    DAT_ram_00a58d78 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x44) + 8);
		  uVar2 = *(undefined4 *)(iVar1 + 0x40);
		  param3 = *(undefined4 *)(iVar1 + 0x48);
		  param2_00 = *(undefined4 *)(iVar1 + 0x1c);
		  param1_00 = unnamed_function_1417
		                        (UI_ToolTip_Implementations_VO_Monster_IslandMonsterToolTipVO_TypeInfo);
		  UnityEngine_InputSystem_Utilities_ForDeviceEventObservable__Subscribe
		            (param1_00,param2_00,param3,uVar2,0);
		  uVar2 = unnamed_function_1417(UI_ToolTip_ToolTipData_AbstractMonsterToolTipVO__TypeInfo);
		  UI_ToolTip_ToolTipData_object____ctor
		            (uVar2,StringLiteral_12535,param1_00,
		             Method_UI_ToolTip_ToolTipData_AbstractMonsterToolTipVO___ctor__);
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600523A RID: 21050 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600523A")]
		[Address(RVA = "0xA011", Offset = "0xA011", VA = "0xA011", Slot = "12")]
		public BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__GetData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x54);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = *(int *)(param1 + 0x50);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600523B")]
		[Address(RVA = "0xA012", Offset = "0xA012", VA = "0xA012", Slot = "13")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__OnPointerClick
		               (int param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  float4 local_14;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  UnityEngine_SpriteRenderer__set_size(&local_10,*(undefined4 *)(param1 + 0x2c),0);
		  local_18 = local_8;
		  local_20 = local_10;
		  local_28 = CONCAT44(param2,local_8);
		  local_30 = local_10;
		  local_14 = (float4)param2;
		  UnityEngine_SpriteRenderer__get_color(*(undefined4 *)(param1 + 0x2c),&local_30,0);
		  iVar2 = 0;
		  iVar1 = Gameplay_Isles_User_View_Monster_MonsterOnIsleAvatarAnimation__Validate
		                    (*(undefined4 *)(param1 + 0x3c),0);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      Core_Animations_GameSpineAnimation__SetGrayscale
		                (*(undefined4 *)(iVar1 + iVar2 * 4 + 0x10),param2,0);
		      iVar2 = iVar2 + 1;
		    } while (iVar2 < *(int *)(iVar1 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600523C RID: 21052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600523C")]
		[Address(RVA = "0xA013", Offset = "0xA013", VA = "0xA013", Slot = "18")]
		public void SetAlpha(float value)
		{
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600523D")]
		[Address(RVA = "0xA014", Offset = "0xA014", VA = "0xA014")]
		public IsleMonsterView()
		{
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600523E")]
		[Address(RVA = "0xA015", Offset = "0xA015", VA = "0xA015", Slot = "17")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x04002CAE RID: 11438
		[Token(Token = "0x4002CAE")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private SpriteRenderer _cloudPlatform;

		// Token: 0x04002CAF RID: 11439
		[Token(Token = "0x4002CAF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshPro _backtimeView;

		// Token: 0x04002CB0 RID: 11440
		[Token(Token = "0x4002CB0")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x04002CB1 RID: 11441
		[Token(Token = "0x4002CB1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AsyncLoadableContentTracker _tracker;

		// Token: 0x04002CB2 RID: 11442
		[Token(Token = "0x4002CB2")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MonsterOnIsleAvatarAnimation _avatarAnimation;

		// Token: 0x04002CB3 RID: 11443
		[Token(Token = "0x4002CB3")]
		[FieldOffset(Offset = "0x40")]
		private IGuideTarget _guideTarget;

		// Token: 0x04002CB4 RID: 11444
		[Token(Token = "0x4002CB4")]
		[FieldOffset(Offset = "0x44")]
		private IsleMonsterViewMediator _mediator;

		// Token: 0x04002CB5 RID: 11445
		[Token(Token = "0x4002CB5")]
		[FieldOffset(Offset = "0x48")]
		private Tween _fadeTween;

		// Token: 0x04002CB6 RID: 11446
		[Token(Token = "0x4002CB6")]
		[FieldOffset(Offset = "0x4C")]
		private Coroutine _timerRoutine;

		// Token: 0x02000D23 RID: 3363
		[Token(Token = "0x2000D23")]
		public enum State
		{
			// Token: 0x04002CBA RID: 11450
			[Token(Token = "0x4002CBA")]
			Idle = 1,
			// Token: 0x04002CBB RID: 11451
			[Token(Token = "0x4002CBB")]
			Splash
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AvatarAnimation ---
		int Gameplay_Isles_User_View_Monster_IsleMonsterView__get_AvatarAnimation
		              (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58d6f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a58d6f = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x40);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		  }
		  *(int *)(param1 + 0x40) = iVar1;
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_ToolTip ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__get_ToolTip
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d70 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Collider2D___);
		    DAT_ram_00a58d70 = '\x01';
		  }
		  param2_00 = func_ii_5677(param2,Method_UnityEngine_Component_GetComponent_Collider2D___);
		  UnityEngine_Collider2D__set_offset(&local_18,param2_00,0);
		  param1[2] = local_8;
		  param1[1] = local_10;
		  *param1 = local_18;
		  return;
		}
		*/


		/* --- GHIDRA: get_Bounds ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__get_Bounds
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58d71 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58d71 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x50,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58d72 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58d72 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x50,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__remove_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58d73 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		    DAT_ram_00a58d73 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IGuideTargetResolveEventProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGuideTargetResolveEventProvider__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x54,iVar2,param1_00);
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


		/* --- GHIDRA: add_ResolveEvent ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__add_ResolveEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58d74 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGuideTargetResolveEventProvider__TypeInfo);
		    DAT_ram_00a58d74 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IGuideTargetResolveEventProvider__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IGuideTargetResolveEventProvider__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x54,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ResolveEvent ---
		void Gameplay_Isles_User_View_Monster_IsleMonsterView__remove_ResolveEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  float fVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (*(int *)(param1 + 0x4c) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x4c),0);
		  }
		  if ((param2 != 0) && (fVar1 = func_ii_7103(param2,0), 0.0 < fVar1)) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x30),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,1,0);
		    fVar1 = func_ii_7103(param2,0);
		    if (DAT_ram_00a58d75 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Gameplay_Isles_User_View_Monster_IsleMonsterView__TimerRoutine_d__28_TypeInfo);
		      DAT_ram_00a58d75 = '\x01';
		    }
		    param1_00 = unnamed_function_1417
		                          (
		                          Gameplay_Isles_User_View_Monster_IsleMonsterView__TimerRoutine_d__28_TypeInfo
		                          );
		    *(int *)(param1_00 + 0x14) = param1;
		    *(undefined4 *)(param1_00 + 8) = 0;
		    *(float *)(param1_00 + 0x10) = fVar1;
		    uVar2 = Utils_CoroutineSource__GetMono(param1_00,0);
		    *(undefined4 *)(param1 + 0x4c) = uVar2;
		    return;
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x30),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  *(undefined4 *)(param1 + 0x4c) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: set_Backtime ---
		int Gameplay_Isles_User_View_Monster_IsleMonsterView__set_Backtime
		              (undefined4 param1,float param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58d75 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Isles_User_View_Monster_IsleMonsterView__TimerRoutine_d__28_TypeInfo);
		    DAT_ram_00a58d75 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Isles_User_View_Monster_IsleMonsterView__TimerRoutine_d__28_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x14) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(float *)(iVar1 + 0x10) = param2;
		  return iVar1;
		}
		*/

}
