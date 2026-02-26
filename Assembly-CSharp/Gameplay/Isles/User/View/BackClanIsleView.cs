using System;
using System.Runtime.CompilerServices;
using AssetContent;
using CloudsFly;
using Gameplay.Isles.User.Controller;
using Il2CppDummyDll;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D0E RID: 3342
	[Token(Token = "0x2000D0E")]
	public class BackClanIsleView : BaseWorldObjectRenderer, IToolTipDataProvider
	{
		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06005183 RID: 20867 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001082")]
		public ToolTip ToolTip
		{
			[Token(Token = "0x6005183")]
			[Address(RVA = "0x9F5F", Offset = "0x9F5F", VA = "0x9F5F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06005184 RID: 20868 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001083")]
		public GameAssetViewSpriteRenderer BgSprite
		{
			[Token(Token = "0x6005184")]
			[Address(RVA = "0x9F60", Offset = "0x9F60", VA = "0x9F60")]
			get
			{
				return null;
			}
		}

		// Token: 0x140001EE RID: 494
		// (add) Token: 0x06005185 RID: 20869 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005186 RID: 20870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001EE")]
		public event Action ClickEvent
		{
			[Token(Token = "0x6005185")]
			[Address(RVA = "0x9F61", Offset = "0x9F61", VA = "0x9F61")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005186")]
			[Address(RVA = "0x9F62", Offset = "0x9F62", VA = "0x9F62")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005187")]
		[Address(RVA = "0x9F63", Offset = "0x9F63", VA = "0x9F63")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Isles_User_View_BackClanIsleView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58d1a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Isles_User_View_BackClanIsleView_BgOnClickEvent__)
		    ;
		    DAT_ram_00a58d1a = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417(System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Gameplay_Isles_User_View_BackClanIsleView_BgOnClickEvent__,0);
		  AssetContent_GameAssetViewSpriteRenderer__add_ClickedEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005188 RID: 20872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005188")]
		[Address(RVA = "0x9F64", Offset = "0x9F64", VA = "0x9F64")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Isles_User_View_BackClanIsleView__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x30);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005189 RID: 20873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005189")]
		[Address(RVA = "0x9F65", Offset = "0x9F65", VA = "0x9F65")]
		private void BgOnClickEvent(GameAssetViewSpriteRenderer gameAssetViewSpriteRenderer)
		{
		/* --- GHIDRA: BgOnClickEvent ---
		void Gameplay_Isles_User_View_BackClanIsleView__BgOnClickEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58d1b == '\0') {
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
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_Controller_BackClanIsleViewMediator_TypeInfo);
		    DAT_ram_00a58d1b = '\x01';
		  }
		  param4 = *(undefined4 *)(param2 + 0x14);
		  param3_00 = *(undefined4 *)(param2 + 0xc);
		  param2_00 = *(undefined4 *)(param2 + 0x10);
		  param1_00 = (int *)unnamed_function_1417
		                               (Gameplay_Isles_User_Controller_BackClanIsleViewMediator_TypeInfo);
		  if (DAT_ram_00a58d87 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BackClanIsleView___ctor__
		              );
		    DAT_ram_00a58d87 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1_00,param2_00,param3_00,param4,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BackClanIsleView___ctor__
		            );
		  *(int **)(param1 + 0x2c) = param1_00;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		            (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x0600518A RID: 20874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600518A")]
		[Address(RVA = "0x9F66", Offset = "0x9F66", VA = "0x9F66")]
		public void Init(UserIsle isle)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Isles_User_View_BackClanIsleView__Init(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x2c);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x2c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600518B RID: 20875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600518B")]
		[Address(RVA = "0x9F67", Offset = "0x9F67", VA = "0x9F67")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Gameplay_Isles_User_View_BackClanIsleView__Deinit(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  param1_00 = *(undefined4 *)(param1 + 0x24);
		  param2_00 = func_ii_4075(param1,0);
		  CloudsFly_BaseWorldObjectRenderer__get_SortingOrderWithDelta(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600518C RID: 20876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600518C")]
		[Address(RVA = "0x9F68", Offset = "0x9F68", VA = "0x9F68", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600518D")]
		[Address(RVA = "0x9F69", Offset = "0x9F69", VA = "0x9F69", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		/* --- GHIDRA: ApplySortingLayerId ---
		int Gameplay_Isles_User_View_BackClanIsleView__ApplySortingLayerId(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a58d1c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__BackClanIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_ClanData__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_ClanData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12530);
		    DAT_ram_00a58d1c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_ClanData__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12530,Method_UI_ToolTip_ToolTipData_ClanData___ctor__);
		  *(undefined4 *)(param1_00 + 0x1c) =
		       *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x2c) + 8) + 8) + 0x68);
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600518E RID: 20878 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600518E")]
		[Address(RVA = "0x9F6A", Offset = "0x9F6A", VA = "0x9F6A", Slot = "10")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600518F")]
		[Address(RVA = "0x9F6B", Offset = "0x9F6B", VA = "0x9F6B")]
		public BackClanIsleView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_View_BackClanIsleView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58d1d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58d1d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x28,param1_01,param1_00);
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

		}

		// Token: 0x04002C57 RID: 11351
		[Token(Token = "0x4002C57")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _bgSprite;

		// Token: 0x04002C58 RID: 11352
		[Token(Token = "0x4002C58")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x04002C59 RID: 11353
		[Token(Token = "0x4002C59")]
		[FieldOffset(Offset = "0x2C")]
		private BackClanIsleViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BgSprite ---
		void Gameplay_Isles_User_View_BackClanIsleView__get_BgSprite
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58d17 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58d17 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
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
		void Gameplay_Isles_User_View_BackClanIsleView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a58d18 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a58d18 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
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
		void Gameplay_Isles_User_View_BackClanIsleView__remove_ClickEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58d19 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Isles_User_View_BackClanIsleView_BgOnClickEvent__)
		    ;
		    DAT_ram_00a58d19 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  param1_00 = unnamed_function_1417(System_Action_GameAssetViewSpriteRenderer__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Gameplay_Isles_User_View_BackClanIsleView_BgOnClickEvent__,0);
		  AssetContent_GameAssetViewSpriteRenderer__get_SpriteRenderer(param1_01,param1_00,0);
		  return;
		}
		*/

}
