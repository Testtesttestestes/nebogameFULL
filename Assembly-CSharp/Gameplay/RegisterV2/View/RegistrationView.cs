using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.RegisterV2.Control;
using Gameplay.RegisterV2.Events;
using Gameplay.RegisterV2.Model;
using Gameplay.RegisterV2.View.CultSelector;
using Gameplay.RegisterV2.View.GenderSelector;
using Gameplay.Tutorial.Guide.View;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.Filters.GenericFilter;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Utils;

namespace Gameplay.RegisterV2.View
{
	// Token: 0x0200055E RID: 1374
	[Token(Token = "0x200055E")]
	public class RegistrationView : MonoBehaviour
	{
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700060C")]
		public MonoPointerClickHandler ForegroundClick
		{
			[Token(Token = "0x6002104")]
			[Address(RVA = "0x7266", Offset = "0x7266", VA = "0x7266")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700060D")]
		public DeselectableGenericFilterView Spells
		{
			[Token(Token = "0x6002105")]
			[Address(RVA = "0x7267", Offset = "0x7267", VA = "0x7267")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700060E")]
		public RegistrationRewardsView Rewards
		{
			[Token(Token = "0x6002106")]
			[Address(RVA = "0x7268", Offset = "0x7268", VA = "0x7268")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700060F")]
		public GraphicPointerView PointerView
		{
			[Token(Token = "0x6002107")]
			[Address(RVA = "0x7269", Offset = "0x7269", VA = "0x7269")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000610")]
		public TextMeshProUGUI CultDescription
		{
			[Token(Token = "0x6002108")]
			[Address(RVA = "0x726A", Offset = "0x726A", VA = "0x726A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000611")]
		public GameAssetViewRawImage AvatarView
		{
			[Token(Token = "0x6002109")]
			[Address(RVA = "0x726B", Offset = "0x726B", VA = "0x726B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000612")]
		public GenderSelector GenderSelector
		{
			[Token(Token = "0x600210A")]
			[Address(RVA = "0x726C", Offset = "0x726C", VA = "0x726C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000613")]
		public TextMeshProUGUI IncorrectNickMessage
		{
			[Token(Token = "0x600210B")]
			[Address(RVA = "0x726D", Offset = "0x726D", VA = "0x726D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000614")]
		public NickInputField NickInputSkin
		{
			[Token(Token = "0x600210C")]
			[Address(RVA = "0x726E", Offset = "0x726E", VA = "0x726E")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000140 RID: 320
		// (add) Token: 0x0600210D RID: 8461 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600210E RID: 8462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000140")]
		public event Action<CultDic> OnCultChanged
		{
			[Token(Token = "0x600210D")]
			[Address(RVA = "0x726F", Offset = "0x726F", VA = "0x726F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600210E")]
			[Address(RVA = "0x7270", Offset = "0x7270", VA = "0x7270")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000141 RID: 321
		// (add) Token: 0x0600210F RID: 8463 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002110 RID: 8464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000141")]
		public event Action OnRegisterClicked
		{
			[Token(Token = "0x600210F")]
			[Address(RVA = "0x7271", Offset = "0x7271", VA = "0x7271")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002110")]
			[Address(RVA = "0x7272", Offset = "0x7272", VA = "0x7272")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000142 RID: 322
		// (add) Token: 0x06002111 RID: 8465 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002112 RID: 8466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000142")]
		public event Action<string, bool> OnNickStatusChanged
		{
			[Token(Token = "0x6002111")]
			[Address(RVA = "0x7273", Offset = "0x7273", VA = "0x7273")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002112")]
			[Address(RVA = "0x7274", Offset = "0x7274", VA = "0x7274")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000143 RID: 323
		// (add) Token: 0x06002113 RID: 8467 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002114 RID: 8468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000143")]
		public event Action<string> OnNickChanged
		{
			[Token(Token = "0x6002113")]
			[Address(RVA = "0x7275", Offset = "0x7275", VA = "0x7275")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002114")]
			[Address(RVA = "0x7276", Offset = "0x7276", VA = "0x7276")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000144 RID: 324
		// (add) Token: 0x06002115 RID: 8469 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002116 RID: 8470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000144")]
		public event Action OnSaveProgressClicked
		{
			[Token(Token = "0x6002115")]
			[Address(RVA = "0x7277", Offset = "0x7277", VA = "0x7277")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002116")]
			[Address(RVA = "0x7278", Offset = "0x7278", VA = "0x7278")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000145 RID: 325
		// (add) Token: 0x06002117 RID: 8471 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002118 RID: 8472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000145")]
		public event Action OnGenerateNick
		{
			[Token(Token = "0x6002117")]
			[Address(RVA = "0x7279", Offset = "0x7279", VA = "0x7279")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002118")]
			[Address(RVA = "0x727A", Offset = "0x727A", VA = "0x727A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000146 RID: 326
		// (add) Token: 0x06002119 RID: 8473 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600211A RID: 8474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000146")]
		public event Action OnRegistrationComplete
		{
			[Token(Token = "0x6002119")]
			[Address(RVA = "0x727B", Offset = "0x727B", VA = "0x727B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600211A")]
			[Address(RVA = "0x727C", Offset = "0x727C", VA = "0x727C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211B")]
		[Address(RVA = "0x727D", Offset = "0x727D", VA = "0x727D")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_RegisterV2_View_RegistrationView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x5c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 100),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211C")]
		[Address(RVA = "0x727E", Offset = "0x727E", VA = "0x727E")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_RegisterV2_View_RegistrationView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58361 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_MonoBehaviourWithStates_ClientStateChangedDelegate_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__add_CurrentStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_HandleSpellDeselect__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_HandleSpellSelected__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RegisterV2_View_RegistrationView_LeftArrowClick__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RegisterV2_View_RegistrationView_OnCultDeselect__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RegisterV2_View_RegistrationView_OnCultSelected__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RegisterV2_View_RegistrationView_OnEndEditNick__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_OnGenerateNickClicked__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_OnNickStatusChangedListener__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_OnRegisterButtonClicked__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_RightArrowClick__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_ShowRewardsPopup__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RegisterV2_View_RegistrationView_SpellsAndCultDescriptionPanelOnCurrentStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_CultListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_CultListElementArgs__AddListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		    DAT_ram_00a58361 = '\x01';
		  }
		  Gameplay_RegisterV2_View_RegistrationView__LeftArrowClick(param1,param1);
		  AssetContent_GameAnimationView__get_Interactable(*(undefined4 *)(param1 + 0x48),0,0);
		  Gameplay_UserInfo_View_PatternTextInput__get_Status(*(undefined4 *)(param1 + 0x14),1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x18);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_CultListElementArgs__TypeInfo);
		  func_ii_7054(uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_OnCultSelected__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_CultListElementArgs__AddListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x24);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_CultListElementArgs__TypeInfo);
		  func_ii_7054(uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_OnCultDeselect__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_CultListElementArgs__AddListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_OnRegisterButtonClicked__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar1,param1,
		             Method_Gameplay_RegisterV2_View_RegistrationView_OnNickStatusChangedListener__,0);
		  Gameplay_UserInfo_View_NickVariantItemRow___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x130);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_OnEndEditNick__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_OnGenerateNickClicked__,0
		            );
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_LeftArrowClick__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_RightArrowClick__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x60) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_ShowRewardsPopup__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x30);
		  uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_HandleSpellSelected__,0);
		  UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData___ctor
		            (uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x30);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_HandleSpellDeselect__,0);
		  UI_Elements_GenericList_SelectableListElementArgs___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x6c);
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_MonoBehaviourWithStates_ClientStateChangedDelegate_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__TypeInfo
		                    );
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate_ByteEnum___Invoke
		            (uVar1,param1,
		             Method_Gameplay_RegisterV2_View_RegistrationView_SpellsAndCultDescriptionPanelOnCurrentStateChangedEvent__
		             ,0);
		  UI_MonoBehaviourWithStates_Int32Enum___HandleCurrentStateChanged
		            (uVar2,uVar1,
		             Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__add_CurrentStateChangedEvent__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211D")]
		[Address(RVA = "0x727F", Offset = "0x727F", VA = "0x727F")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_RegisterV2_View_RegistrationView__Start
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  if (param3 == 2) {
		    UI_Elements_Filters_GenericFilter_GenericFilterView__SelectElement
		              (*(undefined4 *)(param1 + 0x30),0xffffffff,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600211E RID: 8478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211E")]
		[Address(RVA = "0x7280", Offset = "0x7280", VA = "0x7280")]
		private void SpellsAndCultDescriptionPanelOnCurrentStateChangedEvent(SpellsAndCultDescriptionPanel.SpellsAndCultDescriptionPanelState fromstate, SpellsAndCultDescriptionPanel.SpellsAndCultDescriptionPanelState tostate)
		{
		/* --- GHIDRA: SpellsAndCultDescriptionPanelOnCurrentStateChangedEvent ---
		void Gameplay_RegisterV2_View_RegistrationView__SpellsAndCultDescriptionPanelOnCurrentStateChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 100),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600211F RID: 8479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211F")]
		[Address(RVA = "0x7281", Offset = "0x7281", VA = "0x7281")]
		private void HandleSpellDeselect()
		{
		/* --- GHIDRA: HandleSpellDeselect ---
		void Gameplay_RegisterV2_View_RegistrationView__HandleSpellDeselect
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58362 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SpellDic_TypeInfo);
		    DAT_ram_00a58362 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 100),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param2 != (int *)0x0),0);
		  if (param2 != (int *)0x0) {
		    if (Protocol_Dic_SpellDic_TypeInfo != *param2) {
		      System_Activator__CreateInstance(param2,Protocol_Dic_SpellDic_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar2 = *(int **)(*(int *)(param1 + 100) + 0x10);
		    uVar1 = Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId(param2,0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		    piVar2 = *(int **)(*(int *)(param1 + 100) + 0x14);
		    uVar1 = Core_Extensions_Dict_SpellDicExt__GetDescription(param2,0);
		    iVar3 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		              (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002120")]
		[Address(RVA = "0x7282", Offset = "0x7282", VA = "0x7282")]
		private void HandleSpellSelected(object obj)
		{
		/* --- GHIDRA: HandleSpellSelected ---
		void Gameplay_RegisterV2_View_RegistrationView__HandleSpellSelected(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  uint uVar1;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x5c),0);
		  uVar1 = func_ii_12174(*(undefined4 *)(param1 + 0x5c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,uVar1 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002121")]
		[Address(RVA = "0x7283", Offset = "0x7283", VA = "0x7283")]
		private void ShowRewardsPopup()
		{
		/* --- GHIDRA: ShowRewardsPopup ---
		void Gameplay_RegisterV2_View_RegistrationView__ShowRewardsPopup(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58363 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_CultSelectorListArgs__CultListElement__CultListElementArgs__get_SelectedIndex__
		              );
		    DAT_ram_00a58363 = '\x01';
		  }
		  Gameplay_RegisterV2_View_RegistrationView__SelectCult
		            (param1,*(int *)(*(int *)(param1 + 0x10) + 0x20) + 1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x7284", Offset = "0x7284", VA = "0x7284")]
		private void RightArrowClick()
		{
		/* --- GHIDRA: RightArrowClick ---
		void Gameplay_RegisterV2_View_RegistrationView__RightArrowClick(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58364 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_CultSelectorListArgs__CultListElement__CultListElementArgs__get_SelectedIndex__
		              );
		    DAT_ram_00a58364 = '\x01';
		  }
		  Gameplay_RegisterV2_View_RegistrationView__SelectCult
		            (param1,*(int *)(*(int *)(param1 + 0x10) + 0x20) + -1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x7285", Offset = "0x7285", VA = "0x7285")]
		private void LeftArrowClick()
		{
		/* --- GHIDRA: LeftArrowClick ---
		void Gameplay_RegisterV2_View_RegistrationView__LeftArrowClick(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58365 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_RegisterV2_Control_RegisterController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_RegisterV2_Events_RegisterEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_RegisterV2_Control_RegisterMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_RegisterV2_Model_RegisterModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RegisterV2_View_RegistrationView_OnRegistrationProcessCompleteEvent__
		              );
		    DAT_ram_00a58365 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_RegisterV2_Events_RegisterEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x8c) = uVar1;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar4 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(Gameplay_RegisterV2_Model_RegisterModel_TypeInfo);
		  Gameplay_RegisterV2_Model_RegisterModel__Dispose(uVar1,uVar4,0,param1);
		  *(undefined4 *)(param1 + 0x90) = uVar1;
		  uVar4 = *(undefined4 *)(param1 + 0x8c);
		  iVar2 = unnamed_function_1417(Gameplay_RegisterV2_Control_RegisterController_TypeInfo);
		  if (DAT_ram_00a58387 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_RegisterModel__RegisterEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_Auth2Service___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58387 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (iVar2,uVar1,uVar4,Method_MVC_AbstractController_RegisterModel__RegisterEvents___ctor__)
		  ;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_Auth2Service___);
		  *(undefined4 *)(iVar2 + 0x18) = uVar1;
		  *(int *)(param1 + 0x94) = iVar2;
		  uVar1 = *(undefined4 *)(param1 + 0x90);
		  uVar4 = *(undefined4 *)(param1 + 0x8c);
		  piVar3 = (int *)unnamed_function_1417(Gameplay_RegisterV2_Control_RegisterMediator_TypeInfo);
		  if (DAT_ram_00a58394 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_RegisterModel__RegisterEvents__RegisterController__RegistrationView___ctor__
		              );
		    DAT_ram_00a58394 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar3,uVar1,uVar4,iVar2,
		             Method_MVC_AbstractViewMediator_RegisterModel__RegisterEvents__RegisterController__RegistrationView___ctor__
		            );
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  *(int **)(param1 + 0x98) = piVar3;
		  iVar5 = *(int *)(param1 + 0x8c);
		  uVar4 = *(undefined4 *)(iVar5 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_RegisterV2_View_RegistrationView_OnRegistrationProcessCompleteEvent__,0
		            );
		  piVar3 = (int *)UnityEngine_UI_Image__set_sprite(uVar4,uVar1,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar3 == (int *)0x0) {
		    *(undefined4 *)(iVar5 + 0x18) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar3) ||
		          (*(int **)(iVar5 + 0x18) = piVar3, *piVar3 != iVar2)) {
		    System_Activator__CreateInstance(piVar3,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x94),0);
		  return;
		}
		*/

		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x7286", Offset = "0x7286", VA = "0x7286")]
		private void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		void Gameplay_RegisterV2_View_RegistrationView__InitMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x88);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002125")]
		[Address(RVA = "0x7287", Offset = "0x7287", VA = "0x7287")]
		private void OnRegistrationProcessCompleteEvent()
		{
		/* --- GHIDRA: OnRegistrationProcessCompleteEvent ---
		void Gameplay_RegisterV2_View_RegistrationView__OnRegistrationProcessCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a58366 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RegisterV2_View_RegistrationView_OnRegistrationProcessCompleteEvent__
		              );
		    DAT_ram_00a58366 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x8c);
		  param1_02 = *(undefined4 *)(iVar1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_RegisterV2_View_RegistrationView_OnRegistrationProcessCompleteEvent__,0
		            );
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x18) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 0x18) = param1_01, *param1_01 != iVar2)) {
		    System_Activator__CreateInstance(param1_01,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x94),0);
		  iVar2 = **(int **)(param1 + 0x98);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		            (*(int **)(param1 + 0x98),*(undefined4 *)(iVar2 + 0x134));
		  iVar2 = **(int **)(param1 + 0x94);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x94),*(undefined4 *)(iVar2 + 0xec));
		  iVar2 = **(int **)(param1 + 0x90);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (*(int **)(param1 + 0x90),*(undefined4 *)(iVar2 + 0xec));
		  *(undefined8 *)(param1 + 0x94) = 0;
		  *(undefined8 *)(param1 + 0x8c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002126 RID: 8486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002126")]
		[Address(RVA = "0x7288", Offset = "0x7288", VA = "0x7288")]
		private void DisposeMVC()
		{
		/* --- GHIDRA: DisposeMVC ---
		void Gameplay_RegisterV2_View_RegistrationView__DisposeMVC(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58367 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_RegisterV2_View_CultSelector_CultSelectorListArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_CultDic__CultListElementArgs___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_CultListElementArgs___);
		    Mono_Security_ASN1__get_Item(&System_Func_CultDic__CultListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_CultSelectorListArgs__CultListElement__CultListElementArgs__set_Data__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView___c__SetCults_b__76_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_RegisterV2_View_RegistrationView___c_TypeInfo);
		    DAT_ram_00a58367 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (param2 == 0) {
		    uVar1 = unnamed_function_1417
		                      (Gameplay_RegisterV2_View_CultSelector_CultSelectorListArgs_TypeInfo);
		    if (DAT_ram_00a58381 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_UI_Elements_GenericList_SelectedGenericListArgs_CultListElementArgs___ctor__
		                );
		      DAT_ram_00a58381 = '\x01';
		    }
		    UI_Elements_GenericList_SelectableListElement_object___get_Data
		              (uVar1,
		               Method_UI_Elements_GenericList_SelectedGenericListArgs_CultListElementArgs___ctor__);
		  }
		  else {
		    if (*(int *)(Gameplay_RegisterV2_View_RegistrationView___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_RegisterV2_View_RegistrationView___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(Gameplay_RegisterV2_View_RegistrationView___c_TypeInfo + 0x5c);
		    param1_01 = puVar2[1];
		    if (param1_01 == 0) {
		      if (*(int *)(Gameplay_RegisterV2_View_RegistrationView___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_RegisterV2_View_RegistrationView___c_TypeInfo);
		        puVar2 = *(undefined4 **)(Gameplay_RegisterV2_View_RegistrationView___c_TypeInfo + 0x5c);
		      }
		      uVar1 = *puVar2;
		      param1_01 = unnamed_function_1417(System_Func_CultDic__CultListElementArgs__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (param1_01,uVar1,
		                 Method_Gameplay_RegisterV2_View_RegistrationView___c__SetCults_b__76_0__,0);
		      *(int *)(*(int *)(Gameplay_RegisterV2_View_RegistrationView___c_TypeInfo + 0x5c) + 4) =
		           param1_01;
		    }
		    uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (param2,param1_01,
		                       Method_System_Linq_Enumerable_Select_CultDic__CultListElementArgs___);
		    param2_00 = System_Linq_Enumerable__Select_object__object_
		                          (uVar1,Method_System_Linq_Enumerable_ToList_CultListElementArgs___);
		    uVar1 = unnamed_function_1417
		                      (Gameplay_RegisterV2_View_CultSelector_CultSelectorListArgs_TypeInfo);
		    if (DAT_ram_00a58382 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_UI_Elements_GenericList_SelectedGenericListArgs_CultListElementArgs___ctor__
		                );
		      DAT_ram_00a58382 = '\x01';
		    }
		    UI_Elements_GenericList_SelectedGenericListArgs_object____ctor
		              (uVar1,param2_00,
		               Method_UI_Elements_GenericList_SelectedGenericListArgs_CultListElementArgs___ctor__);
		  }
		  UI_Elements_GenericList_SelectorGenericList_object__object__object___get_SelectedIndex
		            (param1_00,uVar1,
		             Method_UI_Elements_GenericList_SelectorGenericList_CultSelectorListArgs__CultListElement__CultListElementArgs__set_Data__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002127 RID: 8487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002127")]
		[Address(RVA = "0x7289", Offset = "0x7289", VA = "0x7289")]
		public void SetCults(List<CultDic> value)
		{
		/* --- GHIDRA: SetCults ---
		void Gameplay_RegisterV2_View_RegistrationView__SetCults(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  int param2_00;
		  int *piVar5;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a58368 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_CultListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_CultListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_CultSelectorListArgs__CultListElement__CultListElementArgs__get_Data__
		              );
		    DAT_ram_00a58368 = '\x01';
		  }
		  do {
		    piVar3 = *(int **)(*(int *)(*(int *)(param1 + 0x10) + 0x28) + 8);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_CultListElementArgs__TypeInfo == *piVar5) {
		          puVar2 = (uint *)(iVar4 + piVar5[1] * 8 + 0xc0);
		          goto code_r0x80ed734d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,
		                                  System_Collections_Generic_ICollection_CultListElementArgs__TypeInfo
		                                  ,0);
		code_r0x80ed734d:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    if (iVar4 <= param2_00) {
		      return;
		    }
		    piVar3 = *(int **)(*(int *)(*(int *)(param1 + 0x10) + 0x28) + 8);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_CultListElementArgs__TypeInfo == *piVar5) {
		          puVar2 = (uint *)(iVar4 + piVar5[1] * 8 + 0xc0);
		          goto code_r0x80ed73d7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,
		                                  System_Collections_Generic_IList_CultListElementArgs__TypeInfo,0);
		code_r0x80ed73d7:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param2_00,puVar2[1]);
		    if (param2 == *(int *)(*(int *)(iVar4 + 0xc) + 0xc)) {
		      Gameplay_RegisterV2_View_RegistrationView__SelectCult(param1,param2_00,puVar2);
		      return;
		    }
		    param2_00 = param2_00 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06002128 RID: 8488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002128")]
		[Address(RVA = "0x728A", Offset = "0x728A", VA = "0x728A")]
		public void SelectCult(uint cultId)
		{
		/* --- GHIDRA: SelectCult ---
		void Gameplay_RegisterV2_View_RegistrationView__SelectCult(int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5836a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5836a = '\x01';
		  }
		  if (param2 == 0) {
		    param2 = StringLiteral_5;
		  }
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(*(int *)(param1 + 0x14) + 0x10),param2,0);
		  return;
		}
		*/

		/* --- GHIDRA: SelectCult ---
		void Gameplay_RegisterV2_View_RegistrationView__SelectCult(int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5836a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5836a = '\x01';
		  }
		  if (param2 == 0) {
		    param2 = StringLiteral_5;
		  }
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(*(int *)(param1 + 0x14) + 0x10),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002129")]
		[Address(RVA = "0x728B", Offset = "0x728B", VA = "0x728B")]
		private void SelectCult(int index)
		{
		}

		// Token: 0x17000615 RID: 1557
		// (set) Token: 0x0600212A RID: 8490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000615")]
		public string CurrentNick
		{
			[Token(Token = "0x600212A")]
			[Address(RVA = "0x728C", Offset = "0x728C", VA = "0x728C")]
			set
			{
			}
		}

		// Token: 0x17000616 RID: 1558
		// (set) Token: 0x0600212B RID: 8491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000616")]
		public string NickPattern
		{
			[Token(Token = "0x600212B")]
			[Address(RVA = "0x728D", Offset = "0x728D", VA = "0x728D")]
			set
			{
			}
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212C")]
		[Address(RVA = "0x728E", Offset = "0x728E", VA = "0x728E")]
		private void OnNickStatusChangedListener(bool status)
		{
		/* --- GHIDRA: OnNickStatusChangedListener ---
		void Gameplay_RegisterV2_View_RegistrationView__OnNickStatusChangedListener
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5836b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Image___);
		    DAT_ram_00a5836b = '\x01';
		  }
		  piVar1 = (int *)func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                               Method_UnityEngine_Component_GetComponent_Image___);
		  local_8 = 0x3f8000003f800000;
		  local_10 = 0x3f8000003f800000;
		  local_18 = 0x3f8000003f800000;
		  local_20 = 0x3f8000003f800000;
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x178) * 4))
		            (piVar1,&local_20,*(undefined4 *)(*piVar1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212D")]
		[Address(RVA = "0x728F", Offset = "0x728F", VA = "0x728F")]
		private void PutOutNickInputField()
		{
		/* --- GHIDRA: PutOutNickInputField ---
		void Gameplay_RegisterV2_View_RegistrationView__PutOutNickInputField
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5836c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Image___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_NickInputField_NickInputFiledStates__set_CurrentState__
		              );
		    DAT_ram_00a5836c = '\x01';
		  }
		  piVar1 = (int *)func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                               Method_UnityEngine_Component_GetComponent_Image___);
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(param1 + 0x40),2,
		             Method_UI_MonoBehaviourWithStates_NickInputField_NickInputFiledStates__set_CurrentState__
		            );
		  Gameplay_UserInfo_View_PatternTextInput__get_Status(*(undefined4 *)(param1 + 0x14),1,0);
		  local_8 = param2[1];
		  local_10 = *param2;
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x178) * 4))
		            (piVar1,&local_10,*(undefined4 *)(*piVar1 + 0x17c));
		  return;
		}
		*/

		}

		// Token: 0x0600212E RID: 8494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600212E")]
		[Address(RVA = "0x7290", Offset = "0x7290", VA = "0x7290")]
		private void LightUpNickInputFiled(in Color color)
		{
		/* --- GHIDRA: LightUpNickInputFiled ---
		void Gameplay_RegisterV2_View_RegistrationView__LightUpNickInputFiled
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_UserInfo_View_PatternTextInput__get_Status(*(undefined4 *)(param1 + 0x14),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x17000617 RID: 1559
		// (set) Token: 0x0600212F RID: 8495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000617")]
		public bool NickInputStatus
		{
			[Token(Token = "0x600212F")]
			[Address(RVA = "0x7291", Offset = "0x7291", VA = "0x7291")]
			set
			{
			}
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002130")]
		[Address(RVA = "0x7292", Offset = "0x7292", VA = "0x7292")]
		private void OnRegisterButtonClicked()
		{
		/* --- GHIDRA: OnRegisterButtonClicked ---
		void Gameplay_RegisterV2_View_RegistrationView__OnRegisterButtonClicked
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  Gameplay_RegisterV2_View_CultsFade__HandleStateChangedEvent(*(undefined4 *)(param1 + 0x34),param1)
		  ;
		  iVar1 = *(int *)(param1 + 0x70);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002131")]
		[Address(RVA = "0x7293", Offset = "0x7293", VA = "0x7293")]
		private void OnCultSelected(CultListElementArgs args)
		{
		/* --- GHIDRA: OnCultSelected ---
		void Gameplay_RegisterV2_View_RegistrationView__OnCultSelected
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar2 = *(int *)(param1 + 0x7c);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param2,*(undefined4 *)(iVar2 + 0x14));
		  }
		  iVar2 = func_ii_4769(param2,0);
		  if (iVar2 == 0) {
		    if (DAT_ram_00a5836b == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Image___);
		      DAT_ram_00a5836b = '\x01';
		    }
		    piVar1 = (int *)func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                                 Method_UnityEngine_Component_GetComponent_Image___);
		    local_8 = 0x3f8000003f800000;
		    local_10 = 0x3f8000003f800000;
		    local_18 = 0x3f8000003f800000;
		    local_20 = 0x3f8000003f800000;
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x178) * 4))
		              (piVar1,&local_20,*(undefined4 *)(*piVar1 + 0x17c));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002132")]
		[Address(RVA = "0x7294", Offset = "0x7294", VA = "0x7294")]
		private void OnEndEditNick(string nick)
		{
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002133")]
		[Address(RVA = "0x7295", Offset = "0x7295", VA = "0x7295")]
		private void OnGenerateNickClicked()
		{
		/* --- GHIDRA: OnGenerateNickClicked ---
		void Gameplay_RegisterV2_View_RegistrationView__OnGenerateNickClicked
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5836d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectorGenericList_CultSelectorListArgs__CultListElement__CultListElementArgs__SelectByIndex__
		              );
		    DAT_ram_00a5836d = '\x01';
		  }
		  UI_Elements_GenericList_SelectorGenericList_object__object__object___SelectByIndex
		            (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 8),1,
		             Method_UI_Elements_GenericList_SelectorGenericList_CultSelectorListArgs__CultListElement__CultListElementArgs__SelectByIndex__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002134")]
		[Address(RVA = "0x7296", Offset = "0x7296", VA = "0x7296")]
		private void OnCultDeselect(CultListElementArgs args)
		{
		/* --- GHIDRA: OnCultDeselect ---
		void Gameplay_RegisterV2_View_RegistrationView__OnCultDeselect
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x38),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002135")]
		[Address(RVA = "0x7297", Offset = "0x7297", VA = "0x7297")]
		public void SetEnableIncorrectNickMessage(bool value)
		{
		/* --- GHIDRA: SetEnableIncorrectNickMessage ---
		void Gameplay_RegisterV2_View_RegistrationView__SetEnableIncorrectNickMessage
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5836e == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_SpellDic__FilterWithIconListElement_FilterWithIconData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_FilterWithIconListElement_FilterWithIconData___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_SpellDic__FilterWithIconListElement_FilterWithIconData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RegisterV2_View_RegistrationView_ConstructArgs__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14560);
		    DAT_ram_00a5836e = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Func_SpellDic__FilterWithIconListElement_FilterWithIconData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_ConstructArgs__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_SpellDic__FilterWithIconListElement_FilterWithIconData___
		                    );
		  iVar2 = func_ii_6295(uVar1,
		                       Method_System_Linq_Enumerable_ToArray_FilterWithIconListElement_FilterWithIconData___
		                      );
		  if (*(int *)(iVar2 + 0xc) == 0) {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7109(StringLiteral_14560,0);
		    return;
		  }
		  iVar3 = **(int **)(param1 + 0x30);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe0) * 4))
		            (*(int **)(param1 + 0x30),iVar2,*(undefined4 *)(iVar3 + 0xe4));
		  UI_Elements_Filters_GenericFilter_GenericFilterView__SelectElement
		            (*(undefined4 *)(param1 + 0x30),0xffffffff,0);
		  return;
		}
		*/

		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002136")]
		[Address(RVA = "0x7298", Offset = "0x7298", VA = "0x7298")]
		public void SetSpells(IEnumerable<SpellDic> spells)
		{
		/* --- GHIDRA: SetSpells ---
		void Gameplay_RegisterV2_View_RegistrationView__SetSpells
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x44),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002137 RID: 8503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002137")]
		[Address(RVA = "0x7299", Offset = "0x7299", VA = "0x7299")]
		public void SetPointerActive(bool value)
		{
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002138")]
		[Address(RVA = "0x729A", Offset = "0x729A", VA = "0x729A")]
		public void SetRegisterButtonActive(bool value)
		{
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002139")]
		[Address(RVA = "0x729B", Offset = "0x729B", VA = "0x729B")]
		public void SetGenerateNickButtonActive(bool value)
		{
		/* --- GHIDRA: SetGenerateNickButtonActive ---
		void Gameplay_RegisterV2_View_RegistrationView__SetGenerateNickButtonActive
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x44),0);
		  func_ii_8007(uVar1,0,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x44),0);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = 0x4348b333c36cb333;
		  local_18 = 0x4348b333c36cb333;
		  DG_Tweening_ShortcutExtensions__DOMoveZ(uVar1,&local_18,0.0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600213A RID: 8506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213A")]
		[Address(RVA = "0x729C", Offset = "0x729C", VA = "0x729C")]
		public void ShowPointerOnGenerateButton()
		{
		/* --- GHIDRA: ShowPointerOnGenerateButton ---
		void Gameplay_RegisterV2_View_RegistrationView__ShowPointerOnGenerateButton
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x44),0);
		  func_ii_8007(uVar1,0,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(param1 + 0x44),0);
		  local_4 = 0;
		  local_10 = 0;
		  local_c = 0xc38b800000000000;
		  local_18 = 0xc38b800000000000;
		  DG_Tweening_ShortcutExtensions__DOMoveZ(uVar1,&local_18,0.0,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600213B RID: 8507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213B")]
		[Address(RVA = "0x729D", Offset = "0x729D", VA = "0x729D")]
		public void ShowPointerOnRegisterButton()
		{
		/* --- GHIDRA: ShowPointerOnRegisterButton ---
		int Gameplay_RegisterV2_View_RegistrationView__ShowPointerOnRegisterButton
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5836f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		              );
		    DAT_ram_00a5836f = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    UI_Elements_Filters_GenericFilter_FilterWithIconListElement_FilterWithIconData_TypeInfo
		                    );
		  *(int *)(iVar1 + 0xc) = param2;
		  *(undefined4 *)(iVar1 + 8) = *(undefined4 *)(param2 + 0x40);
		  uVar2 = Core_Extensions_Dict_SpellDicExt__GetAssetId(param2,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600213C RID: 8508 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600213C")]
		[Address(RVA = "0x729E", Offset = "0x729E", VA = "0x729E")]
		private FilterWithIconListElement.FilterWithIconData ConstructArgs(SpellDic dic)
		{
			return null;
		}

		// Token: 0x0600213D RID: 8509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213D")]
		[Address(RVA = "0x729F", Offset = "0x729F", VA = "0x729F")]
		public RegistrationView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_RegisterV2_View_RegistrationView___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58370 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_RegisterV2_View_RegistrationView___c_TypeInfo);
		    DAT_ram_00a58370 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_RegisterV2_View_RegistrationView___c_TypeInfo);
		  **(undefined4 **)(Gameplay_RegisterV2_View_RegistrationView___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001207 RID: 4615
		[Token(Token = "0x4001207")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("_cultSectorList")]
		[SerializeField]
		private CultSectorList _cultList;

		// Token: 0x04001208 RID: 4616
		[Token(Token = "0x4001208")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private PatternTextInput _nickInput;

		// Token: 0x04001209 RID: 4617
		[Token(Token = "0x4001209")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _registerButton;

		// Token: 0x0400120A RID: 4618
		[Token(Token = "0x400120A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _generateNickButton;

		// Token: 0x0400120B RID: 4619
		[Token(Token = "0x400120B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _leftArrowButton;

		// Token: 0x0400120C RID: 4620
		[Token(Token = "0x400120C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _rightArrowButton;

		// Token: 0x0400120D RID: 4621
		[Token(Token = "0x400120D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GenderSelector _genderSelector;

		// Token: 0x0400120E RID: 4622
		[Token(Token = "0x400120E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameAssetViewRawImage _avatarView;

		// Token: 0x0400120F RID: 4623
		[Token(Token = "0x400120F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DeselectableGenericFilterView _spells;

		// Token: 0x04001210 RID: 4624
		[Token(Token = "0x4001210")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private CultsFade _cultsFader;

		// Token: 0x04001211 RID: 4625
		[Token(Token = "0x4001211")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _incorrectNickMessage;

		// Token: 0x04001212 RID: 4626
		[Token(Token = "0x4001212")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _cultDescription;

		// Token: 0x04001213 RID: 4627
		[Token(Token = "0x4001213")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private NickInputField _nickInputSkin;

		// Token: 0x04001214 RID: 4628
		[Token(Token = "0x4001214")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GraphicPointerView _pointerView;

		// Token: 0x04001215 RID: 4629
		[Token(Token = "0x4001215")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameAnimationView _pointerAnimation;

		// Token: 0x04001216 RID: 4630
		[Token(Token = "0x4001216")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Color _warnColorForNickINputField;

		// Token: 0x04001217 RID: 4631
		[Token(Token = "0x4001217")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private RegistrationRewardsView _rewardsView;

		// Token: 0x04001218 RID: 4632
		[Token(Token = "0x4001218")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _rewardButton;

		// Token: 0x04001219 RID: 4633
		[Token(Token = "0x4001219")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private RegistrationTitleDescription _spellTitleDescription;

		// Token: 0x0400121A RID: 4634
		[Token(Token = "0x400121A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MonoPointerClickHandler _foregroundClick;

		// Token: 0x0400121B RID: 4635
		[Token(Token = "0x400121B")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private SpellsAndCultDescriptionPanel _spellsAndCultDescriptionPanel;

		// Token: 0x04001223 RID: 4643
		[Token(Token = "0x4001223")]
		[FieldOffset(Offset = "0x8C")]
		private RegisterEvents _events;

		// Token: 0x04001224 RID: 4644
		[Token(Token = "0x4001224")]
		[FieldOffset(Offset = "0x90")]
		private RegisterModel _model;

		// Token: 0x04001225 RID: 4645
		[Token(Token = "0x4001225")]
		[FieldOffset(Offset = "0x94")]
		private RegisterController _controller;

		// Token: 0x04001226 RID: 4646
		[Token(Token = "0x4001226")]
		[FieldOffset(Offset = "0x98")]
		private RegisterMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_NickInputSkin ---
		void Gameplay_RegisterV2_View_RegistrationView__get_NickInputSkin
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58352 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CultDic__TypeInfo);
		    DAT_ram_00a58352 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x70);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_CultDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CultDic__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x70,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnCultChanged ---
		void Gameplay_RegisterV2_View_RegistrationView__add_OnCultChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58353 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CultDic__TypeInfo);
		    DAT_ram_00a58353 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x70);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_CultDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_CultDic__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x70,iVar2,param1_00);
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


		/* --- GHIDRA: remove_OnCultChanged ---
		void Gameplay_RegisterV2_View_RegistrationView__remove_OnCultChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58354 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58354 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x74);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x74,param1_01,param1_00);
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


		/* --- GHIDRA: add_OnRegisterClicked ---
		void Gameplay_RegisterV2_View_RegistrationView__add_OnRegisterClicked
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58355 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58355 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x74);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x74,param1_01,param1_00);
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


		/* --- GHIDRA: remove_OnRegisterClicked ---
		void Gameplay_RegisterV2_View_RegistrationView__remove_OnRegisterClicked
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58356 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__bool__TypeInfo);
		    DAT_ram_00a58356 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x78);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_string__bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x78,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnNickStatusChanged ---
		void Gameplay_RegisterV2_View_RegistrationView__add_OnNickStatusChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58357 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__bool__TypeInfo);
		    DAT_ram_00a58357 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x78);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_string__bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x78,iVar2,param1_00);
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


		/* --- GHIDRA: remove_OnNickStatusChanged ---
		void Gameplay_RegisterV2_View_RegistrationView__remove_OnNickStatusChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58358 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    DAT_ram_00a58358 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x7c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_string__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x7c,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnNickChanged ---
		void Gameplay_RegisterV2_View_RegistrationView__add_OnNickChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58359 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    DAT_ram_00a58359 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x7c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_string__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x7c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_OnNickChanged ---
		void Gameplay_RegisterV2_View_RegistrationView__remove_OnNickChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5835a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5835a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x80);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x80,param1_01,param1_00);
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


		/* --- GHIDRA: add_OnSaveProgressClicked ---
		void Gameplay_RegisterV2_View_RegistrationView__add_OnSaveProgressClicked
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5835b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5835b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x80);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x80,param1_01,param1_00);
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


		/* --- GHIDRA: remove_OnSaveProgressClicked ---
		void Gameplay_RegisterV2_View_RegistrationView__remove_OnSaveProgressClicked
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5835c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5835c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x84);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x84,param1_01,param1_00);
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


		/* --- GHIDRA: add_OnGenerateNick ---
		void Gameplay_RegisterV2_View_RegistrationView__add_OnGenerateNick
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5835d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5835d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x84);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x84,param1_01,param1_00);
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


		/* --- GHIDRA: remove_OnGenerateNick ---
		void Gameplay_RegisterV2_View_RegistrationView__remove_OnGenerateNick
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5835e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5835e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x88);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x88,param1_01,param1_00);
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


		/* --- GHIDRA: add_OnRegistrationComplete ---
		void Gameplay_RegisterV2_View_RegistrationView__add_OnRegistrationComplete
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5835f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5835f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x88);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x88,param1_01,param1_00);
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


		/* --- GHIDRA: remove_OnRegistrationComplete ---
		void Gameplay_RegisterV2_View_RegistrationView__remove_OnRegistrationComplete
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58360 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_object__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_MonoBehaviourWithStates_ClientStateChangedDelegate_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__remove_CurrentStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_HandleSpellDeselect__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_HandleSpellSelected__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RegisterV2_View_RegistrationView_LeftArrowClick__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RegisterV2_View_RegistrationView_OnCultDeselect__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RegisterV2_View_RegistrationView_OnCultSelected__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_RegisterV2_View_RegistrationView_OnEndEditNick__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_OnGenerateNickClicked__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_OnNickStatusChangedListener__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_OnRegisterButtonClicked__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_RightArrowClick__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_RegisterV2_View_RegistrationView_ShowRewardsPopup__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_RegisterV2_View_RegistrationView_SpellsAndCultDescriptionPanelOnCurrentStateChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_CultListElementArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Events_UnityEvent_CultListElementArgs__RemoveListener__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		    DAT_ram_00a58360 = '\x01';
		  }
		  Gameplay_RegisterV2_View_RegistrationView__OnRegistrationProcessCompleteEvent(param1,param1);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x18);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_CultListElementArgs__TypeInfo);
		  func_ii_7054(uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_OnCultSelected__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_CultListElementArgs__RemoveListener__)
		  ;
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x24);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_CultListElementArgs__TypeInfo);
		  func_ii_7054(uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_OnCultDeselect__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_CultListElementArgs__RemoveListener__)
		  ;
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_OnRegisterButtonClicked__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_bool__TypeInfo);
		  System_Action_AsyncGPUReadbackRequest___Invoke
		            (uVar1,param1,
		             Method_Gameplay_RegisterV2_View_RegistrationView_OnNickStatusChangedListener__,0);
		  Gameplay_UserInfo_View_PatternTextInput__add_OnStatusChanged(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x130);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_OnEndEditNick__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_string__RemoveListener__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_OnGenerateNickClicked__,0
		            );
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_LeftArrowClick__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_RightArrowClick__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x60) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_ShowRewardsPopup__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x30);
		  uVar1 = unnamed_function_1417(System_Action_object__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_HandleSpellSelected__,0);
		  UI_Elements_Filters_GenericFilter_GenericFilterView__add_SelectedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x30);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_RegisterV2_View_RegistrationView_HandleSpellDeselect__,0);
		  UI_Elements_Filters_GenericFilter_DeselectableGenericFilterView__add_DeselectedEvent
		            (uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x6c);
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_MonoBehaviourWithStates_ClientStateChangedDelegate_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__TypeInfo
		                    );
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate_ByteEnum___Invoke
		            (uVar1,param1,
		             Method_Gameplay_RegisterV2_View_RegistrationView_SpellsAndCultDescriptionPanelOnCurrentStateChangedEvent__
		             ,0);
		  UI_MonoBehaviourWithStates_Int32Enum___get_CurrentState
		            (uVar2,uVar1,
		             Method_UI_MonoBehaviourWithStates_SpellsAndCultDescriptionPanel_SpellsAndCultDescriptionPanelState__remove_CurrentStateChangedEvent__
		            );
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentNick ---
		void Gameplay_RegisterV2_View_RegistrationView__set_CurrentNick
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_UserInfo_View_PatternTextInput__get_Pattern(*(undefined4 *)(param1 + 0x14),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_NickPattern ---
		void Gameplay_RegisterV2_View_RegistrationView__set_NickPattern
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *piVar2;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (param2 == 0) {
		    if (DAT_ram_00a5836c == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Image___);
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_UI_MonoBehaviourWithStates_NickInputField_NickInputFiledStates__set_CurrentState__
		                );
		      DAT_ram_00a5836c = '\x01';
		    }
		    piVar2 = (int *)func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                                 Method_UnityEngine_Component_GetComponent_Image___);
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(param1 + 0x40),2,
		               Method_UI_MonoBehaviourWithStates_NickInputField_NickInputFiledStates__set_CurrentState__
		              );
		    Gameplay_UserInfo_View_PatternTextInput__get_Status(*(undefined4 *)(param1 + 0x14),1,0);
		    local_18 = *(undefined8 *)(param1 + 0x54);
		    local_20 = *(undefined8 *)(param1 + 0x4c);
		    (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x178) * 4))
		              (piVar2,&local_20,*(undefined4 *)(*piVar2 + 0x17c));
		  }
		  else {
		    iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x14) + 0x10) + 0x160),0);
		    if (iVar1 == 0) {
		      if (DAT_ram_00a5836b == '\0') {
		        Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Image___);
		        DAT_ram_00a5836b = '\x01';
		      }
		      piVar2 = (int *)func_ii_5677(*(undefined4 *)(param1 + 0x14),
		                                   Method_UnityEngine_Component_GetComponent_Image___);
		      local_8 = 0x3f8000003f800000;
		      local_10 = 0x3f8000003f800000;
		      local_28 = 0x3f8000003f800000;
		      local_30 = 0x3f8000003f800000;
		      (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x178) * 4))
		                (piVar2,&local_30,*(undefined4 *)(*piVar2 + 0x17c));
		    }
		  }
		  return;
		}
		*/

}
