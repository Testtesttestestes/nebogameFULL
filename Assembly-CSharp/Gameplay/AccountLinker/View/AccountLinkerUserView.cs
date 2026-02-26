using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.AccountLinker.Model;
using Gameplay.Aprs.View;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DF4 RID: 3572
	[Token(Token = "0x2000DF4")]
	public class AccountLinkerUserView : MonoBehaviour
	{
		// Token: 0x06005731 RID: 22321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005731")]
		[Address(RVA = "0xA4AC", Offset = "0xA4AC", VA = "0xA4AC")]
		private void Awake()
		{
		/* --- GHIDRA: <HandleUserChanged>b__17_1 ---
		void Gameplay_AccountLinker_View_AccountLinkerUserView___HandleUserChanged_b__17_1
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param1_00;
		  undefined4 param1_01;
		  
		  param1_00 = *(int *)(param1 + 0x24);
		  *(undefined4 *)(param1_00 + 0x30) = *(undefined4 *)(*(int *)(param1 + 0x34) + 8);
		  param1_01 = *(undefined4 *)(param1 + 0x28);
		  uVar1 = Gameplay_UserInfo_View_BaseInfoBox__HandleVisibleChanged(param1_00,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_01,uVar1 ^ 1,0);
		  return;
		}
		*/

		/* --- GHIDRA: <HandleUserChanged>b__17_0 ---
		void Gameplay_AccountLinker_View_AccountLinkerUserView___HandleUserChanged_b__17_0
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x30);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(param1 + 0x34),
		             *(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		/* --- GHIDRA: Awake ---
		void Gameplay_AccountLinker_View_AccountLinkerUserView__Awake(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x34) != 0) {
		    *(undefined4 *)(param1 + 0x34) = 0;
		    Gameplay_AccountLinker_View_AccountLinkerUserView__set_User(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005732 RID: 22322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005732")]
		[Address(RVA = "0xA4AD", Offset = "0xA4AD", VA = "0xA4AD")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_AccountLinker_View_AccountLinkerUserView__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58907 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_LinkerUser__TypeInfo);
		    DAT_ram_00a58907 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_EventHandler_LinkerUser__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_LinkerUser__TypeInfo), iVar2 == 0))
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

		}

		// Token: 0x14000207 RID: 519
		// (add) Token: 0x06005733 RID: 22323 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005734 RID: 22324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000207")]
		public event EventHandler<LinkerUser> OnSelectEvent
		{
			[Token(Token = "0x6005733")]
			[Address(RVA = "0xA4AE", Offset = "0xA4AE", VA = "0xA4AE")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005734")]
			[Address(RVA = "0xA4AF", Offset = "0xA4AF", VA = "0xA4AF")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06005735 RID: 22325 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005736 RID: 22326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011C5")]
		public LinkerUser User
		{
			[Token(Token = "0x6005735")]
			[Address(RVA = "0xA4B0", Offset = "0xA4B0", VA = "0xA4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005736")]
			[Address(RVA = "0xA4B1", Offset = "0xA4B1", VA = "0xA4B1")]
			set
			{
			}
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005737")]
		[Address(RVA = "0xA4B2", Offset = "0xA4B2", VA = "0xA4B2")]
		private void HandleUserChanged()
		{
		/* --- GHIDRA: HandleUserChanged ---
		void Gameplay_AccountLinker_View_AccountLinkerUserView__HandleUserChanged
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x28);
		  uVar1 = Gameplay_UserInfo_View_BaseInfoBox__HandleVisibleChanged(*(undefined4 *)(param1 + 0x24),0)
		  ;
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,uVar1 ^ 1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005738 RID: 22328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005738")]
		[Address(RVA = "0xA4B3", Offset = "0xA4B3", VA = "0xA4B3")]
		private void HandleSkillsClick()
		{
		}

		// Token: 0x06005739 RID: 22329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005739")]
		[Address(RVA = "0xA4B4", Offset = "0xA4B4", VA = "0xA4B4")]
		public AccountLinkerUserView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_View_AccountLinkerUserView___ctor
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                    (*(undefined4 *)(*(int *)(param1 + 0x34) + 0xc),0);
		  (**(code **)((ulonglong)*(uint *)(*param2 + 0x2d0) * 4))
		            (param2,uVar1,*(undefined4 *)(*param2 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x04002F32 RID: 12082
		[Token(Token = "0x4002F32")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<TextMeshProUGUI> _nickFields;

		// Token: 0x04002F33 RID: 12083
		[Token(Token = "0x4002F33")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _selectButton;

		// Token: 0x04002F34 RID: 12084
		[Token(Token = "0x4002F34")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserNickCultLevelExpView _levelView;

		// Token: 0x04002F35 RID: 12085
		[Token(Token = "0x4002F35")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private AprView _aprView;

		// Token: 0x04002F36 RID: 12086
		[Token(Token = "0x4002F36")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _faqButton;

		// Token: 0x04002F37 RID: 12087
		[Token(Token = "0x4002F37")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SkillsInfoView _skillsView;

		// Token: 0x04002F38 RID: 12088
		[Token(Token = "0x4002F38")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _contentContainer;

		// Token: 0x04002F39 RID: 12089
		[Token(Token = "0x4002F39")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _skillsCloseButton;

		// Token: 0x04002F3B RID: 12091
		[Token(Token = "0x4002F3B")]
		[FieldOffset(Offset = "0x34")]
		private LinkerUser _user;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnSelectEvent ---
		void Gameplay_AccountLinker_View_AccountLinkerUserView__add_OnSelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58908 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_LinkerUser__TypeInfo);
		    DAT_ram_00a58908 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_EventHandler_LinkerUser__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_LinkerUser__TypeInfo), iVar2 == 0))
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


		/* --- GHIDRA: get_User ---
		void Gameplay_AccountLinker_View_AccountLinkerUserView__get_User
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x34)) {
		    *(int *)(param1 + 0x34) = param2;
		    Gameplay_AccountLinker_View_AccountLinkerUserView__set_User(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_User ---
		void Gameplay_AccountLinker_View_AccountLinkerUserView__set_User(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param3;
		  undefined4 uVar3;
		  int *param1_00;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58909 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_View_AccountLinkerUserView_HandleSkillsClick__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_View_AccountLinkerUserView__HandleUserChanged_b__17_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_View_AccountLinkerUserView__HandleUserChanged_b__17_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_AccountLinker_View_AccountLinkerUserView__HandleUserChanged_b__17_2__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TextMeshProUGUI__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TextMeshProUGUI__ForEach__)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58909 = '\x01';
		  }
		  if (*(int *)(param1 + 0x34) == 0) {
		    uVar4 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,
		               Method_Gameplay_AccountLinker_View_AccountLinkerUserView_HandleSkillsClick__,0);
		    UnityEngine_Events_UnityAction___ctor(uVar4,uVar3,0);
		    func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4),0);
		    func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4),0);
		    return;
		  }
		  *(undefined4 *)(*(int *)(param1 + 0x24) + 0x2c) = *(undefined4 *)(*(int *)(param1 + 0x34) + 0xc);
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  uVar3 = unnamed_function_1417(System_Action_TextMeshProUGUI__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_AccountLinker_View_AccountLinkerUserView__HandleUserChanged_b__17_0__,0
		            );
		  System_Collections_Generic_List_UsageHint___FindLastIndex
		            (uVar4,uVar3,Method_System_Collections_Generic_List_TextMeshProUGUI__ForEach__);
		  iVar5 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x138) * 4))
		            (*(int **)(param1 + 0x1c),
		             *(undefined4 *)(*(int *)(*(int *)(param1 + 0x34) + 0xc) + 0x38),
		             *(undefined4 *)(iVar5 + 0x13c));
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0xc);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80f48a17;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f48a17:
		  param3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Gameplay_UserInfo_View_UserNickCultLevelExpView__SetCult(uVar3,uVar4,param3,0);
		  Gameplay_UserInfo_View_UserNickCultLevelExpView__SetNick
		            (*(undefined4 *)(param1 + 0x18),
		             *(undefined4 *)(*(int *)(*(int *)(param1 + 0x34) + 0xc) + 0x4c),0);
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(*(int *)(param1 + 0x34) + 0xc),0);
		  Gameplay_UserInfo_View_UserNickCultLevelExpView__HandleOnUserExperienceChangedEvent(uVar4,uVar3,0)
		  ;
		  Gameplay_UserInfo_View_UserNickCultLevelExpView__get_User
		            (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*(int *)(param1 + 0x34) + 0xc),0);
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_AccountLinker_View_AccountLinkerUserView__HandleUserChanged_b__17_1__,0
		            );
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar3,0);
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_AccountLinker_View_AccountLinkerUserView__HandleUserChanged_b__17_2__,0
		            );
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar3,0);
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_AccountLinker_View_AccountLinkerUserView_HandleSkillsClick__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar3,0);
		  return;
		}
		*/

}
