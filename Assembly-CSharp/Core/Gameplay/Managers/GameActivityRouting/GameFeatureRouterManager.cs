using System;
using System.Runtime.CompilerServices;
using CloudsFly.Movement;
using Core.Data;
using Gameplay.Discounts.Controller;
using Gameplay.Rating.View;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;
using UI.Windows;

namespace Core.Gameplay.Managers.GameActivityRouting
{
	// Token: 0x020011C4 RID: 4548
	[Token(Token = "0x20011C4")]
	public class GameFeatureRouterManager : IGameManager, IBaseManager
	{
		// Token: 0x140002C9 RID: 713
		// (add) Token: 0x06006C4F RID: 27727 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C50 RID: 27728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C9")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006C4F")]
			[Address(RVA = "0xB73C", Offset = "0xB73C", VA = "0xB73C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C50")]
			[Address(RVA = "0xB73D", Offset = "0xB73D", VA = "0xB73D", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002CA RID: 714
		// (add) Token: 0x06006C51 RID: 27729 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006C52 RID: 27730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002CA")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006C51")]
			[Address(RVA = "0xB73E", Offset = "0xB73E", VA = "0xB73E", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006C52")]
			[Address(RVA = "0xB73F", Offset = "0xB73F", VA = "0xB73F", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C53")]
		[Address(RVA = "0xB740", Offset = "0xB740", VA = "0xB740", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C54")]
		[Address(RVA = "0xB741", Offset = "0xB741", VA = "0xB741", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__Deinit
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a6e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_8428);
		    DAT_ram_00a5a6e1 = '\x01';
		  }
		  return StringLiteral_8428;
		}
		*/

		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06006C55 RID: 27733 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001625")]
		public string Name
		{
			[Token(Token = "0x6006C55")]
			[Address(RVA = "0xB742", Offset = "0xB742", VA = "0xB742", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C56")]
		[Address(RVA = "0xB743", Offset = "0xB743", VA = "0xB743")]
		public void ShowBank(OptionTypesDic.Types.OptionType optionType, WindowOpenReasonSource source = WindowOpenReasonSource.DefaultSource)
		{
		/* --- GHIDRA: ShowBank ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowBank
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a6e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_View_AuchanWindow_AuchanWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12566);
		    DAT_ram_00a5a6e4 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Auchan_View_AuchanWindow_AuchanWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12566,param1_00,0,0);
		  return;
		}
		*/

		/* --- GHIDRA: ShowBank ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowBank
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a6e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Auchan_View_AuchanWindow_AuchanWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12566);
		    DAT_ram_00a5a6e4 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Auchan_View_AuchanWindow_AuchanWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12566,param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06006C57 RID: 27735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C57")]
		[Address(RVA = "0xB744", Offset = "0xB744", VA = "0xB744")]
		public void ShowBank(Resources resId, WindowOpenReasonSource source = WindowOpenReasonSource.DefaultSource)
		{
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C58")]
		[Address(RVA = "0xB745", Offset = "0xB745", VA = "0xB745")]
		public void ShowAuchan()
		{
		/* --- GHIDRA: ShowAuchan ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowAuchan
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a6e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_View_GiftsWindow_GiftsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_GiftsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12627);
		    DAT_ram_00a5a6e5 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Gifts_View_GiftsWindow_GiftsWindowArgs_TypeInfo);
		  Core_Browser_BrowserWindow___ctor(param1_00,param2,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12627,param1_00,
		             Method_UI_Windows_PopupController_Show_GiftsWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C59")]
		[Address(RVA = "0xB746", Offset = "0xB746", VA = "0xB746")]
		public void ShowGifts(UserData user)
		{
		/* --- GHIDRA: ShowGifts ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowGifts
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a6e6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a6e6 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x8125b48c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125b48c:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		            (*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20),3,
		             Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C5A")]
		[Address(RVA = "0xB747", Offset = "0xB747", VA = "0xB747")]
		public void ShowMyShopBuilding(UserData user)
		{
		/* --- GHIDRA: ShowMyShopBuilding ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowMyShopBuilding
		          (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a6e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_View_RatingWindow_RatingWindowArgs_TypeInfo);
		    DAT_ram_00a5a6e7 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Rating_View_RatingWindow_RatingWindowArgs_TypeInfo);
		  Gameplay_Rating_View_RatingWindow___ctor(uVar1,0);
		  if (DAT_ram_00a5a6e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_RatingWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12661);
		    DAT_ram_00a5a6e8 = '\x01';
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar2,StringLiteral_12661,uVar1,
		                     Method_UI_Windows_PopupController_Show_RatingWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006C5B")]
		[Address(RVA = "0xB748", Offset = "0xB748", VA = "0xB748")]
		public RatingWindow ShowRatingWindow()
		{
		/* --- GHIDRA: ShowRatingWindow ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowRatingWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  undefined4 param3_00;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  undefined8 local_10;
		  int local_4;
		  
		  if (DAT_ram_00a5a6e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_View_CraftWindow_CraftWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_CraftWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4488);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22016);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12605);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25418);
		    DAT_ram_00a5a6e9 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar3 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar3 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar3 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x8125b68f;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar3);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8125b68f:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  iVar5 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar2,StringLiteral_22016,0);
		  local_4 = iVar5;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar3 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar3 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x8125b754;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar3);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8125b754:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  uVar3 = Core_Data_UserData__set_LevelDic(uVar2,0);
		  if ((longlong)(ulonglong)uVar3 < (longlong)iVar5) {
		    iVar5 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		    UI_Windows_Alert__Show(iVar5,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_4488,1,0,1,0,0,0,0);
		    iVar6 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    param3_00 = func_ii_4443(&local_4,0);
		    local_10 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_25418,param3_00,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar6 + 0x10) = local_10;
		    uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar2,iVar6,0);
		    *(undefined4 *)(iVar5 + 0x1c) = uVar2;
		    UI_Windows_UnityInstantiator___ctor(iVar5,0);
		  }
		  else {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    iVar5 = unnamed_function_1417(Gameplay_Craft_View_CraftWindow_CraftWindowArgs_TypeInfo);
		    Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar5,0);
		    *(undefined4 *)(iVar5 + 0x18) = param2;
		    Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		              (uVar2,StringLiteral_12605,iVar5,Method_UI_Windows_PopupController_Show_CraftWindow___
		              );
		  }
		  return;
		}
		*/

		/* --- GHIDRA: ShowRatingWindow ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowRatingWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  undefined4 param3_00;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  undefined8 local_10;
		  int local_4;
		  
		  if (DAT_ram_00a5a6e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_View_CraftWindow_CraftWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_CraftWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4488);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22016);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12605);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25418);
		    DAT_ram_00a5a6e9 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar3 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar3 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar3 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x8125b68f;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar3);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8125b68f:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  iVar5 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar2,StringLiteral_22016,0);
		  local_4 = iVar5;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar4;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar3 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar3 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x8125b754;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar3);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8125b754:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  uVar3 = Core_Data_UserData__set_LevelDic(uVar2,0);
		  if ((longlong)(ulonglong)uVar3 < (longlong)iVar5) {
		    iVar5 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		    UI_Windows_Alert__Show(iVar5,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_4488,1,0,1,0,0,0,0);
		    iVar6 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    param3_00 = func_ii_4443(&local_4,0);
		    local_10 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_25418,param3_00,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar6 + 0x10) = local_10;
		    uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar2,iVar6,0);
		    *(undefined4 *)(iVar5 + 0x1c) = uVar2;
		    UI_Windows_UnityInstantiator___ctor(iVar5,0);
		  }
		  else {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    iVar5 = unnamed_function_1417(Gameplay_Craft_View_CraftWindow_CraftWindowArgs_TypeInfo);
		    Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar5,0);
		    *(undefined4 *)(iVar5 + 0x18) = param2;
		    Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		              (uVar2,StringLiteral_12605,iVar5,Method_UI_Windows_PopupController_Show_CraftWindow___
		              );
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006C5C")]
		[Address(RVA = "0xB749", Offset = "0xB749", VA = "0xB749")]
		public RatingWindow ShowRatingWindow(RatingWindow.RatingWindowArgs args)
		{
			return null;
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C5D")]
		[Address(RVA = "0xB74A", Offset = "0xB74A", VA = "0xB74A")]
		public void ShowCraft(uint schemeId = 0U)
		{
		/* --- GHIDRA: ShowCraft ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowCraft
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5a6ea == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_UserInfoWindow___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_UserInfoWindow___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_UserInfoWindow___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_UserInfoWindow___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserInfoWindow__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_GetWindows_UserInfoWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_HasOpenWindow_UserInfoWindow___)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_UserInfoWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager___c__DisplayClass18_0__ShowUserWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager___c__DisplayClass18_0_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12683);
		    DAT_ram_00a5a6ea = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager___c__DisplayClass18_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 8) = param2;
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  iVar2 = UI_Windows_PopupController__GetWindows_object_
		                    (uVar1,Method_UI_Windows_PopupController_HasOpenWindow_UserInfoWindow___);
		  if (iVar2 != 0) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		    uVar1 = UI_Windows_PopupController__GetLastWindow_object_
		                      (uVar1,Method_UI_Windows_PopupController_GetWindows_UserInfoWindow___);
		    uVar3 = unnamed_function_1417(System_Func_UserInfoWindow__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar3,param2_00,
		               Method_Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager___c__DisplayClass18_0__ShowUserWindow_b__0__
		               ,0);
		    uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (uVar1,uVar3,Method_System_Linq_Enumerable_Where_UserInfoWindow___);
		    uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_UserInfoWindow___);
		    iVar2 = System_Linq_Enumerable__OrderBy_object__ulong_
		                      (uVar1,Method_System_Linq_Enumerable_Any_UserInfoWindow___);
		    if (iVar2 != 0) {
		      uVar3 = System_Uri___ctor(0);
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar3,0);
		      uVar1 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                        (uVar1,Method_System_Linq_Enumerable_Last_UserInfoWindow___);
		      UI_Windows_PopupController__CloseAll(uVar3,uVar1,0);
		      return;
		    }
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12683,*(undefined4 *)(param2_00 + 8),
		             Method_UI_Windows_PopupController_Show_UserInfoWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C5E")]
		[Address(RVA = "0xB74B", Offset = "0xB74B", VA = "0xB74B")]
		public void ShowUserWindow(UserInfoWindow.UserInfoWindowArgs args)
		{
		/* --- GHIDRA: ShowUserWindow ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowUserWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a6eb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Discounts_View_DiscountsWindow_DicountsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_DiscountsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12611);
		    DAT_ram_00a5a6eb = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Discounts_View_DiscountsWindow_DicountsWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12611,param1_00,
		             Method_UI_Windows_PopupController_Show_DiscountsWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C5F")]
		[Address(RVA = "0xB74C", Offset = "0xB74C", VA = "0xB74C")]
		public void ShowDiscountsWindow(DiscountsController controller)
		{
		/* --- GHIDRA: ShowDiscountsWindow ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowDiscountsWindow
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5a6ec == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a6ec = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1f8);
		        goto code_r0x8125bae4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x8125bae4:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_AccountsManager__Init(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006C60 RID: 27744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C60")]
		[Address(RVA = "0xB74D", Offset = "0xB74D", VA = "0xB74D")]
		public void ShowAccountsListWindow()
		{
		/* --- GHIDRA: ShowAccountsListWindow ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowAccountsListWindow
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  longlong lVar5;
		  undefined8 uVar6;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  undefined4 param1_00;
		  longlong lVar10;
		  uint uVar11;
		  
		  if (DAT_ram_00a5a6ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager_HandleMoveToClanIsleCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13095);
		    DAT_ram_00a5a6ed = '\x01';
		  }
		  if (*(int *)(param2 + 0x68) == 0) {
		    iVar8 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		    UI_Windows_Alert__Show(iVar8,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_13095,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar8 + 0x1c) = uVar2;
		    UI_Windows_UnityInstantiator___ctor(iVar8,0);
		    return;
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  UI_Windows_PopupController__Close(uVar2,0,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 + 0x110);
		        goto code_r0x8125bc60;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125bc60:
		  uVar6 = CONCAT44(in_register_20000014,puVar3[1]);
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar6);
		  uVar2 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar8 = *(int *)(*(int *)(iVar8 + 0x14) + 0x28);
		  if ((iVar8 != 0) &&
		     (lVar10 = *(longlong *)(iVar8 + 0x18),
		     lVar5 = Gameplay_World_Model_ClanData__set_ClanCultDic(*(undefined4 *)(param2 + 0x68),0),
		     lVar10 == lVar5)) {
		    Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		              (iVar8,2,
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__TryOpenBuildingByType__
		              );
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 + 0x110);
		        goto code_r0x8125bd2e;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125bd2e:
		  uVar6 = CONCAT44(uVar2,puVar3[1]);
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar6);
		  uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar9 = *(int *)(iVar8 + 8);
		  param1_00 = *(undefined4 *)(iVar9 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar2,param1,
		             Method_Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager_HandleMoveToClanIsleCompleteEvent__
		             ,0);
		  iVar8 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar8 == 0) {
		    *(undefined4 *)(iVar9 + 0xc) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar8,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar8,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar9 + 0xc) = iVar4;
		    uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar9 = func_ii_1082(iVar8,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar9 == 0) {
		      System_Activator__CreateInstance(iVar8,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 + 0x110);
		        goto code_r0x8125be48;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125be48:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,CONCAT44(uVar1,puVar3[1]));
		  uVar6 = Gameplay_World_Model_ClanData__set_ClanCultDic(*(undefined4 *)(param2 + 0x68),0);
		  Core_Gameplay_Managers_WorldManager__GoToUserIsleById(uVar2,uVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x06006C61 RID: 27745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C61")]
		[Address(RVA = "0xB74E", Offset = "0xB74E", VA = "0xB74E")]
		public void ShowClanSpells(UserData user)
		{
		/* --- GHIDRA: ShowClanSpells ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowClanSpells
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a6ee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager_HandleMoveToClanIsleCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a6ee = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x8125bf65;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125bf65:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 8);
		  param1_00 = *(undefined4 *)(iVar7 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager_HandleMoveToClanIsleCompleteEvent__
		             ,0);
		  iVar6 = func_ii_7048(param1_00,uVar3,0);
		  uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0xc) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0xc) = iVar4;
		    uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x8125c083;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125c083:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar6 = *(int *)(*(int *)(iVar6 + 0x14) + 0x28);
		  if (iVar6 != 0) {
		    Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		              (iVar6,2,
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__TryOpenBuildingByType__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C62")]
		[Address(RVA = "0xB74F", Offset = "0xB74F", VA = "0xB74F")]
		private void HandleMoveToClanIsleCompleteEvent(WorldMovementTypes obj)
		{
		/* --- GHIDRA: HandleMoveToClanIsleCompleteEvent ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__HandleMoveToClanIsleCompleteEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  longlong lVar5;
		  undefined8 uVar6;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  undefined4 param1_00;
		  longlong lVar10;
		  uint uVar11;
		  
		  if (DAT_ram_00a5a6ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager_HandleMoveToClanIsleCompleteEvent2__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13095);
		    DAT_ram_00a5a6ef = '\x01';
		  }
		  if (*(int *)(param2 + 0x68) == 0) {
		    iVar8 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		    UI_Windows_Alert__Show(iVar8,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = func_ii_7508(StringLiteral_13095,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar8 + 0x1c) = uVar2;
		    UI_Windows_UnityInstantiator___ctor(iVar8,0);
		    return;
		  }
		  uVar2 = System_Uri___ctor(0);
		  uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  UI_Windows_PopupController__Close(uVar2,0,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 + 0x110);
		        goto code_r0x8125c228;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125c228:
		  uVar6 = CONCAT44(in_register_20000014,puVar3[1]);
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar6);
		  uVar2 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar8 = *(int *)(*(int *)(iVar8 + 0x14) + 0x28);
		  if ((iVar8 != 0) &&
		     (lVar10 = *(longlong *)(iVar8 + 0x18),
		     lVar5 = Gameplay_World_Model_ClanData__set_ClanCultDic(*(undefined4 *)(param2 + 0x68),0),
		     lVar10 == lVar5)) {
		    Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		              (iVar8,1,
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__TryOpenBuildingByType__
		              );
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 + 0x110);
		        goto code_r0x8125c2f6;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125c2f6:
		  uVar6 = CONCAT44(uVar2,puVar3[1]);
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar6);
		  uVar1 = (undefined4)((ulonglong)uVar6 >> 0x20);
		  iVar9 = *(int *)(iVar8 + 8);
		  param1_00 = *(undefined4 *)(iVar9 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar2,param1,
		             Method_Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager_HandleMoveToClanIsleCompleteEvent2__
		             ,0);
		  iVar8 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar8 == 0) {
		    *(undefined4 *)(iVar9 + 0xc) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar8,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar8,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar9 + 0xc) = iVar4;
		    uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar9 = func_ii_1082(iVar8,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar9 == 0) {
		      System_Activator__CreateInstance(iVar8,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar11 * 8 + 4) * 8 + iVar8 + 0x110);
		        goto code_r0x8125c410;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar11);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125c410:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,CONCAT44(uVar1,puVar3[1]));
		  uVar6 = Gameplay_World_Model_ClanData__set_ClanCultDic(*(undefined4 *)(param2 + 0x68),0);
		  Core_Gameplay_Managers_WorldManager__GoToUserIsleById(uVar2,uVar6,0);
		  return;
		}
		*/

		}

		// Token: 0x06006C63 RID: 27747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C63")]
		[Address(RVA = "0xB750", Offset = "0xB750", VA = "0xB750")]
		public void ShowClanIsleBuildings(UserData user)
		{
		/* --- GHIDRA: ShowClanIsleBuildings ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowClanIsleBuildings
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a6f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_View_MarketWindow_MarketWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12649);
		    DAT_ram_00a5a6f0 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417(Gameplay_Market_View_MarketWindow_MarketWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = param2;
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12649,param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C64")]
		[Address(RVA = "0xB751", Offset = "0xB751", VA = "0xB751")]
		public void ShowMarketWindow(uint artikulId = 0U)
		{
		/* --- GHIDRA: ShowMarketWindow ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowMarketWindow
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a6f1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager_HandleMoveToClanIsleCompleteEvent2__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a6f1 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x8125c593;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125c593:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar7 = *(int *)(iVar6 + 8);
		  param1_00 = *(undefined4 *)(iVar7 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar3,param1,
		             Method_Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager_HandleMoveToClanIsleCompleteEvent2__
		             ,0);
		  iVar6 = func_ii_7048(param1_00,uVar3,0);
		  uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0xc) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0xc) = iVar4;
		    uVar3 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x8125c6b1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8125c6b1:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar6 = *(int *)(*(int *)(iVar6 + 0x14) + 0x28);
		  if (iVar6 != 0) {
		    Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		              (iVar6,1,
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__TryOpenBuildingByType__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C65")]
		[Address(RVA = "0xB752", Offset = "0xB752", VA = "0xB752")]
		private void HandleMoveToClanIsleCompleteEvent2(WorldMovementTypes obj)
		{
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C66")]
		[Address(RVA = "0xB753", Offset = "0xB753", VA = "0xB753")]
		public GameFeatureRouterManager()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6de == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6de = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6df == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6df = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a6e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a6e0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__get_Name
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5a6e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a6e2 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 400);
		        goto code_r0x8125b208;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x8125b208:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_BankManager__Deinit(param1_00,param2,param3,0);
		  return;
		}
		*/

}
