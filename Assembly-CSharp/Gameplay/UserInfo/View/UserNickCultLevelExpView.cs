using System;
using AssetContent.Loaders;
using Core.Data;
using Core.Gameplay.Managers;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x02000408 RID: 1032
	[Token(Token = "0x2000408")]
	public class UserNickCultLevelExpView : MonoBehaviour
	{
		// Token: 0x0600183C RID: 6204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x69F0", Offset = "0x69F0", VA = "0x69F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000449")]
		public UserData User
		{
			[Token(Token = "0x600183D")]
			[Address(RVA = "0x69F1", Offset = "0x69F1", VA = "0x69F1")]
			get
			{
				return null;
			}
			[Token(Token = "0x600183E")]
			[Address(RVA = "0x69F2", Offset = "0x69F2", VA = "0x69F2")]
			set
			{
			}
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x69F3", Offset = "0x69F3", VA = "0x69F3")]
		private void HandleUserChanged(UserData fromUser, UserData toUser)
		{
		/* --- GHIDRA: HandleUserChanged ---
		void Gameplay_UserInfo_View_UserNickCultLevelExpView__HandleUserChanged
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_UserInfo_View_UserNickCultLevelExpView__SetNick(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x69F4", Offset = "0x69F4", VA = "0x69F4")]
		private void HadleOnUserCultChangedEvent(CultDic cult)
		{
		/* --- GHIDRA: HadleOnUserCultChangedEvent ---
		void Gameplay_UserInfo_View_UserNickCultLevelExpView__HadleOnUserCultChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                    (*(undefined4 *)(param1 + 0x2c),0);
		  iVar2 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x69F5", Offset = "0x69F5", VA = "0x69F5")]
		private void HandleOnUserNickChangedEvent()
		{
		/* --- GHIDRA: HandleOnUserNickChangedEvent ---
		void Gameplay_UserInfo_View_UserNickCultLevelExpView__HandleOnUserNickChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 0x2c),0);
		  Gameplay_UserInterface_View_LevelView__set_IsPremiumExp
		            (*(undefined4 *)(param1 + 0x14),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001842")]
		[Address(RVA = "0x69F6", Offset = "0x69F6", VA = "0x69F6")]
		private void HandleOnUserLevelChangedEvent()
		{
		/* --- GHIDRA: HandleOnUserLevelChangedEvent ---
		void Gameplay_UserInfo_View_UserNickCultLevelExpView__HandleOnUserLevelChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  float param2_00;
		  int param1_00;
		  ulonglong uVar2;
		  
		  param1_00 = *(int *)(*(int *)(param1 + 0x28) + 0x14);
		  iVar1 = Gameplay_User_Model_UserModel__get_ExperienceProgress(param1_00,param1);
		  if (iVar1 == 0) {
		    param2_00 = 1.0;
		  }
		  else {
		    uVar2 = *(ulonglong *)(*(int *)(param1_00 + 8) + 0x58);
		    iVar1 = Gameplay_User_Model_UserModel__get_ExperienceProgress(param1_00,param1);
		    param2_00 = UnityEngine_Camera__set_orthographicSize
		                          ((float)uVar2,(float)*(ulonglong *)(iVar1 + 0x10),0);
		  }
		  Gameplay_UserInterface_View_ClanNickCultIndexView___ctor
		            (*(undefined4 *)(param1 + 0x14),param2_00,0);
		  Gameplay_UserInterface_View_LevelView__get_IsPremiumExp
		            (*(undefined4 *)(param1 + 0x14),(uint)*(byte *)(*(int *)(param1 + 0x2c) + 0x74),0);
		  return;
		}
		*/

		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001843")]
		[Address(RVA = "0x69F7", Offset = "0x69F7", VA = "0x69F7")]
		private void HandleOnUserExperienceChangedEvent()
		{
		/* --- GHIDRA: HandleOnUserExperienceChangedEvent ---
		void Gameplay_UserInfo_View_UserNickCultLevelExpView__HandleOnUserExperienceChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_UserInterface_View_LevelView__set_IsPremiumExp(*(undefined4 *)(param1 + 0x14),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001844")]
		[Address(RVA = "0x69F8", Offset = "0x69F8", VA = "0x69F8")]
		public void SetLevel(uint value)
		{
		/* --- GHIDRA: SetLevel ---
		void Gameplay_UserInfo_View_UserNickCultLevelExpView__SetLevel
		               (int param1,float param2,undefined4 param3)
		
		{
		  Gameplay_UserInterface_View_ClanNickCultIndexView___ctor(*(undefined4 *)(param1 + 0x14),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001845")]
		[Address(RVA = "0x69F9", Offset = "0x69F9", VA = "0x69F9")]
		public void SetExperienceProgress(float value)
		{
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001846")]
		[Address(RVA = "0x69FA", Offset = "0x69FA", VA = "0x69FA")]
		public void SetNick(string value)
		{
		/* --- GHIDRA: SetNick ---
		void Gameplay_UserInfo_View_UserNickCultLevelExpView__SetNick
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a598fd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a598fd = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x1c);
		  if (param2 != piVar4[5]) {
		    piVar4[5] = param2;
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe0) * 4))(piVar4,*(undefined4 *)(*piVar4 + 0xe4));
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar2,0,0);
		  if (iVar1 != 0) {
		    uVar3 = *(undefined4 *)(param1 + 0x24);
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetIconWhitBgForNickBarAssetId(param2,0);
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (uVar3,uVar2,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		  }
		  uVar3 = *(undefined4 *)(param1 + 0x20);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetIcon46x52AssetId(param2,0);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar3,uVar2,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x69FB", Offset = "0x69FB", VA = "0x69FB")]
		public void SetCult(CultDic value)
		{
		/* --- GHIDRA: SetCult ---
		void Gameplay_UserInfo_View_UserNickCultLevelExpView__SetCult
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  
		  *(undefined4 *)(param1 + 0x28) = param3;
		  param2_00 = *(int *)(param1 + 0x2c);
		  if (param2 != param2_00) {
		    *(int *)(param1 + 0x2c) = param2;
		    Gameplay_UserInfo_View_UserNickCultLevelExpView__set_User(param1,param2_00,param2,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x69FC", Offset = "0x69FC", VA = "0x69FC")]
		public void Init(UserData user, UserManager userManager)
		{
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x69FD", Offset = "0x69FD", VA = "0x69FD")]
		public UserNickCultLevelExpView()
		{
		}

		// Token: 0x04000CF7 RID: 3319
		[Token(Token = "0x4000CF7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x04000CF8 RID: 3320
		[Token(Token = "0x4000CF8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LevelView _levelView;

		// Token: 0x04000CF9 RID: 3321
		[Token(Token = "0x4000CF9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RankView _rankView;

		// Token: 0x04000CFA RID: 3322
		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CultView2 _cultView;

		// Token: 0x04000CFB RID: 3323
		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImageLoader _nickBackground;

		// Token: 0x04000CFC RID: 3324
		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0x24")]
		[Header("Optional")]
		[SerializeField]
		private GameRawImageLoader _cultDecorForAvator;

		// Token: 0x04000CFD RID: 3325
		[Token(Token = "0x4000CFD")]
		[FieldOffset(Offset = "0x28")]
		private UserManager _userManager;

		// Token: 0x04000CFE RID: 3326
		[Token(Token = "0x4000CFE")]
		[FieldOffset(Offset = "0x2C")]
		private UserData _user;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_User ---
		void Gameplay_UserInfo_View_UserNickCultLevelExpView__get_User
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  param2_00 = *(int *)(param1 + 0x2c);
		  if (param2 != param2_00) {
		    *(int *)(param1 + 0x2c) = param2;
		    Gameplay_UserInfo_View_UserNickCultLevelExpView__set_User(param1,param2_00,param2,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_User ---
		void Gameplay_UserInfo_View_UserNickCultLevelExpView__set_User
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  float param2_00;
		  ulonglong uVar3;
		  int param1_00;
		  
		  if (DAT_ram_00a598fc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_CultDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_View_UserNickCultLevelExpView_HadleOnUserCultChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_UserNickCultLevelExpView_HandleOnUserExperienceChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_UserNickCultLevelExpView_HandleOnUserLevelChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_UserNickCultLevelExpView_HandleOnUserNickChangedEvent__
		              );
		    DAT_ram_00a598fc = '\x01';
		  }
		  if (param2 != 0) {
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_View_UserNickCultLevelExpView_HandleOnUserLevelChangedEvent__
		               ,0);
		    Core_Data_UserData__add_OnUserLevelChangedEvent(param2,uVar2,0);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_View_UserNickCultLevelExpView_HandleOnUserExperienceChangedEvent__
		               ,0);
		    Core_Data_UserData__add_OnUserExperienceChangedEvent(param2,uVar2,0);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_View_UserNickCultLevelExpView_HandleOnUserNickChangedEvent__
		               ,0);
		    Core_Data_UserData__add_OnUserNickChangedEvent(param2,uVar2,0);
		    uVar2 = unnamed_function_1417(System_Action_CultDic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_View_UserNickCultLevelExpView_HadleOnUserCultChangedEvent__,
		               0);
		    Core_Data_UserData__add_OnUserCultChangedEvent(param2,uVar2,0);
		  }
		  if (param3 != 0) {
		    iVar1 = func_ii_7112(*(undefined4 *)(param1 + 0x28),0);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_View_UserNickCultLevelExpView_HandleOnUserLevelChangedEvent__
		               ,0);
		    Core_Data_UserData__remove_UserSkillsChangedEvent(param3,uVar2,0);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_View_UserNickCultLevelExpView_HandleOnUserExperienceChangedEvent__
		               ,0);
		    Core_Data_UserData__remove_OnUserNickChangedEvent(param3,uVar2,0);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_View_UserNickCultLevelExpView_HandleOnUserNickChangedEvent__
		               ,0);
		    Core_Data_UserData__remove_BalanceChangedEvent(param3,uVar2,0);
		    uVar2 = unnamed_function_1417(System_Action_CultDic__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_UserInfo_View_UserNickCultLevelExpView_HadleOnUserCultChangedEvent__,
		               0);
		    Core_Data_UserData__remove_OnUserAprChangedEvent(param3,uVar2,0);
		    if (iVar1 == param3) {
		      param1_00 = *(int *)(*(int *)(param1 + 0x28) + 0x14);
		      iVar1 = Gameplay_User_Model_UserModel__get_ExperienceProgress(param1_00,param1);
		      if (iVar1 == 0) {
		        param2_00 = 1.0;
		      }
		      else {
		        uVar3 = *(ulonglong *)(*(int *)(param1_00 + 8) + 0x58);
		        iVar1 = Gameplay_User_Model_UserModel__get_ExperienceProgress(param1_00,param1);
		        param2_00 = UnityEngine_Camera__set_orthographicSize
		                              ((float)uVar3,(float)*(ulonglong *)(iVar1 + 0x10),0);
		      }
		    }
		    else {
		      param2_00 = 0.0;
		    }
		    Gameplay_UserInterface_View_ClanNickCultIndexView___ctor
		              (*(undefined4 *)(param1 + 0x14),param2_00,0);
		    Gameplay_UserInfo_View_UserNickCultLevelExpView__SetNick
		              (param1,*(undefined4 *)(param3 + 0x4c),param1);
		    uVar2 = Core_Data_UserData__set_LevelDic(param3,0);
		    Gameplay_UserInterface_View_LevelView__set_IsPremiumExp(*(undefined4 *)(param1 + 0x14),uVar2,0);
		    uVar2 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(param3,0);
		    iVar1 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x10),uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		    Gameplay_UserInterface_View_LocationOwnerIndexView___ctor
		              (*(undefined4 *)(param1 + 0x18),
		               *(undefined4 *)(*(int *)(*(int *)(param1 + 0x2c) + 0x34) + 0x28),0);
		    Gameplay_UserInterface_View_LevelView__get_IsPremiumExp
		              (*(undefined4 *)(param1 + 0x14),(uint)*(byte *)(*(int *)(param1 + 0x2c) + 0x74),0);
		  }
		  return;
		}
		*/

}
